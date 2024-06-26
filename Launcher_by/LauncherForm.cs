﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using ICSharpCode.SharpZipLib.Zip;

namespace Launcher {
    public partial class Application : Form {

        private DownloadProgressTracker _downloadProgressTracker;
        private WebClient _webClient;

        public Version LocalVersion { get { return new Version(Properties.Settings.Default.VersionText); } }
        public Version OnlineVersion { get; private set; }

        private List<PatchNoteBlock> patchNoteBlocks = new List<PatchNoteBlock>();

        private bool _isReady;
        public bool IsReady {
            get {
                return _isReady;
            }
            set {
                _isReady = value;
                TogglePlayButton(value);
                InitializeFooter();
            }
        }

        public bool UpToDate { get { return LocalVersion >= OnlineVersion; } }

        public Application() {
            InitializeComponent();
            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
        }

        private void OnLoadApplication(object sender, EventArgs e) {
            InitializeConstantsSettings();
            InitializeFiles();
            InitializeImages();
            FetchPatchNotes();
            InitializeVersionControl();

            IsReady = UpToDate;

            _downloadProgressTracker = new DownloadProgressTracker(50, TimeSpan.FromMilliseconds(500));

            if (!UpToDate && Constants.AUTOMATICALLY_BEGIN_UPDATING) {
                DownloadFile();
            }
        }

        private void InitializeConstantsSettings() {
            Name = Constants.GAME_TITLE;
            Text = Constants.LAUNCHER_NAME;
            SetUpButtonEvents();

            currentVersionLabel.Visible = Constants.SHOW_VERSION_TEXT;

        }

        private void InitializeFiles() {
            if (!Directory.Exists(Constants.DESTINATION_PATH)) {
                Directory.CreateDirectory(Constants.DESTINATION_PATH);
            } 
        }

        private void InitializeImages() {
            LoadApplicationIcon();
            navbarPanel.BackColor = Color.FromArgb(0, 0, 0, 0); // // Make panel background semi transparent
            logoPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            imagePictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            closePictureBox.SizeMode = PictureBoxSizeMode.CenterImage; // Center the X icon
            minimizePictureBox.SizeMode = PictureBoxSizeMode.CenterImage; // Center the - icon
            try {
                logoPictureBox.Load(Constants.LOGO_URL);
                imagePictureBox.Load(Constants.IMAGE_URL);
                using (WebClient webClient = new WebClient()) {
                    using (Stream stream = webClient.OpenRead(Constants.BACKGROUND_URL)) {
                        BackgroundImage = Image.FromStream(stream);
                    }
                }
            } catch (Exception e) {
                MessageBox.Show("Лаунчеру не удалось получить некоторые игровые изображения с сервера! " + e, "Ошибка");
            }
        }


        private void LoadApplicationIcon() {
            WebRequest request = (HttpWebRequest)WebRequest.Create(Constants.APPLICATION_ICON_URL);

            Bitmap bm = new Bitmap(32,32); 
            MemoryStream memStream;

            using (Stream response = request.GetResponse().GetResponseStream()) {
                memStream = new MemoryStream();
                byte[] buffer = new byte[1024];
                int byteCount;

                do {
                    byteCount = response.Read(buffer, 0, buffer.Length);
                    memStream.Write(buffer, 0, byteCount);
                } while (byteCount > 0);
            }

            bm = new Bitmap(Image.FromStream(memStream));                 

            if (bm != null) {
                Icon = Icon.FromHandle(bm.GetHicon());
            }

        }

        private void InitializeVersionControl() {
            currentVersionLabel.Text = Properties.Settings.Default.VersionText;
            OnlineVersion = GetOnlineVersion();

            Console.WriteLine("Мы находимся на версии " + LocalVersion + " и онлайн-версия - это " + OnlineVersion);
        }

        private void InitializeFooter() {
            if (IsReady) {
                updateProgressBar.Visible = false;
                clientReadyLabel.Visible = true;
            } else {
                updateProgressBar.Visible = true;
                clientReadyLabel.Visible= false;
            }
        }

        private Version GetOnlineVersion() {
            try {
                string onlineVersion = new WebClient().DownloadString(Constants.VERSION_URL);
                Console.WriteLine(LocalVersion >= new Version(onlineVersion));
                Version.TryParse(onlineVersion, out Version result);
                return result;
            } catch {
                MessageBox.Show("Программе запуска не удалось прочитать текущую версию клиента с сервера!", "Ошибка");
                return null;
            }
        }

        private void OnClickPlay(object sender, EventArgs e) {
            if (IsReady) {
                LaunchGame();
            } else {
                DownloadFile();
            }
        }

        private void DownloadFile() {
            using (_webClient = new WebClient()) { 
                _webClient.DownloadProgressChanged += OnDownloadProgressChanged;
                _webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(OnDownloadCompleted);
                _webClient.DownloadFileAsync(new Uri(Constants.CLIENT_DOWNLOAD_URL), Constants.ZIP_PATH);
            }
            
        }

        private void OnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e) {
            _downloadProgressTracker.SetProgress(e.BytesReceived, e.TotalBytesToReceive);
            updateProgressBar.Value = e.ProgressPercentage;
            updateLabelText.Text = string.Format("Downloading: {0} of {1} @ {2}", StringUtility.FormatBytes(e.BytesReceived),
                StringUtility.FormatBytes(e.TotalBytesToReceive), _downloadProgressTracker.GetBytesPerSecondString());

        }

        private void OnDownloadCompleted(object sender, AsyncCompletedEventArgs e) {
            _downloadProgressTracker.Reset();
            updateLabelText.Text = "Загрузка готова к извлечению файлов...";

            Extract extract = new Extract(this);
            extract.Run();
        }

        public void SetLauncherReady() {
            updateLabelText.Text = "";
            if (!File.Exists(Constants.GAME_EXECUTABLE_PATH)) {
                MessageBox.Show("Не удалось установить соединение с игровым сервером. Пожалуйста, повторите попытку позже или сообщите разработчику, если проблема не устранена.", "Ошибка");
                return;
            }

            currentVersionLabel.Text = OnlineVersion.ToString();
            Properties.Settings.Default.VersionText = OnlineVersion.ToString();
            Properties.Settings.Default.Save();
            Console.WriteLine("Обновленная версия. Теперь работает на версии: " + LocalVersion);
            IsReady = true;

            if (Constants.AUTOMATICALLY_LAUNCH_GAME_AFTER_UPDATING) 
                LaunchGame();

            try {
                File.Delete(Constants.ZIP_PATH);
            } catch {
                MessageBox.Show("Не удалось удалить загруженный zip-файл после извлечения.");
            }
        }

        private void FetchPatchNotes() {
            try {
                XmlDocument doc = new XmlDocument();
                doc.Load(Constants.PATCH_NOTES_URL);

               foreach(XmlNode node in doc.DocumentElement) {
                    PatchNoteBlock block = new PatchNoteBlock();
                    for(int i = 0; i < node.ChildNodes.Count; i++) {
                        switch(i) {
                            case 0:
                                block.Title = node.ChildNodes[i].InnerText;
                                break;
                            case 1:
                                block.Text = node.ChildNodes[i].InnerText;
                                break;
                            case 2:
                                block.Link = node.ChildNodes[i].InnerText;
                                break;
                        }
                    }
                    patchNoteBlocks.Add(block);
                }
            } catch {
                patchContainerPanel.Visible = false;
                if (Constants.SHOW_ERROR_BOX_IF_PATCH_NOTES_DOWNLOAD_FAILS)
                    MessageBox.Show("Лаунчеру не удалось получить заметки об исправлениях с сервера!");
            }

            Label[] patchTitleObjects = { patchTitle1, patchTitle2, patchTitle3 };
            Label[] patchTextObjects = { patchText1, patchText2, patchText3 };

            for(int i = 0; i < patchNoteBlocks.Count; i++) {
                patchTitleObjects[i].Text = patchNoteBlocks[i].Title;
                patchTextObjects[i].Text = patchNoteBlocks[i].Text;
            }
        }

        private void LaunchGame() {
            try {
                Process.Start(Constants.GAME_EXECUTABLE_PATH);
                Environment.Exit(0);
            } catch {
                IsReady = false;
                DownloadFile();
                MessageBox.Show("Не удалось найти исполняемый файл игры! Попытка повторной загрузки - пожалуйста, подождите.", "Ошибка");
            }
        }

        private void TogglePlayButton(bool toggle) {
            switch(toggle) {
                case true:
                    playButton.BackColor = Color.Firebrick;
                    playButton.Text = "Играть";
                    break;
                case false:
                    playButton.BackColor = Color.DeepSkyBlue;
                    playButton.Text = "Обновить";
                    break;
            }
        }
        
        // Move the form with LMB
        private void Application_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                NativeWinAPI.ReleaseCapture();
                NativeWinAPI.SendMessage(Handle, NativeWinAPI.WM_NCLBUTTONDOWN, NativeWinAPI.HT_CAPTION, 0);
            }
        }
        
        private void SetUpButtonEvents() {
            Button[] buttons = { navbarButton1, navbarButton2, navbarButton3, navbarButton4, navbarButton5 };

            for(int i = 0; i < buttons.Length; i++) {
                buttons[i].Click += new EventHandler(OnClickButton);
                buttons[i].Text = Constants.NAVBAR_BUTTON_TEXT_ARRAY[i];
            }
        }

        public void OnClickButton(object sender, EventArgs e) {
            Button button = (Button) sender;
            switch(button.Name) {
                case nameof(navbarButton1):
                    System.Diagnostics.Process.Start(Constants.NAVBAR_BUTTON_1_URL);
                    break;
                case nameof(navbarButton2):
                    System.Diagnostics.Process.Start(Constants.NAVBAR_BUTTON_2_URL);
                    break;
                case nameof(navbarButton3):
                    System.Diagnostics.Process.Start(Constants.NAVBAR_BUTTON_3_URL);
                    break;
                case nameof(navbarButton4):
                    System.Diagnostics.Process.Start(Constants.NAVBAR_BUTTON_4_URL);
                    break;
                case nameof(navbarButton5):
                    System.Diagnostics.Process.Start(Constants.NAVBAR_BUTTON_5_URL);
                    break;

                case nameof(patchButton1):
                    Process.Start(patchNoteBlocks[0].Link);
                    break;
                case nameof(patchButton2):
                    Process.Start(patchNoteBlocks[1].Link);
                    break;
                case nameof(patchButton3):
                    Process.Start(patchNoteBlocks[2].Link);
                    break;
            }
        }

        private void OnMouseEnterIcon(object sender, EventArgs e) {
            var pictureBox = (PictureBox) sender;
            pictureBox.BackColor = Color.FromArgb(50, 255, 255, 255);
        }

        private void OnMouseLeaveIcon(object sender, EventArgs e) {
            var pictureBox = (PictureBox) sender;
            pictureBox.BackColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void minimizePictureBox_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void closePictureBox_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void clientReadyLabel_Click(object sender, EventArgs e)
        {

        }

        private void patchText3_Click(object sender, EventArgs e)
        {

        }

        private void navbarButton1_Click(object sender, EventArgs e)
        {

        }

        private void patchText1_Click(object sender, EventArgs e)
        {

        }
    }
}
