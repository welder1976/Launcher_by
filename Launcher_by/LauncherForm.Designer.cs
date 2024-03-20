namespace Launcher {
    partial class Application {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent() {
            this.updateProgressBar = new System.Windows.Forms.ProgressBar();
            this.updateLabelText = new System.Windows.Forms.Label();
            this.currentVersionLabel = new System.Windows.Forms.Label();
            this.navbarButton2 = new System.Windows.Forms.Button();
            this.navbarPanel = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.minimizePictureBox = new System.Windows.Forms.PictureBox();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.navbarButton5 = new System.Windows.Forms.Button();
            this.navbarButton4 = new System.Windows.Forms.Button();
            this.navbarButton3 = new System.Windows.Forms.Button();
            this.navbarButton1 = new System.Windows.Forms.Button();
            this.clientReadyLabel = new System.Windows.Forms.Label();
            this.patchPanel1 = new System.Windows.Forms.Panel();
            this.patchText1 = new System.Windows.Forms.Label();
            this.patchButton1 = new System.Windows.Forms.Button();
            this.patchTitle1 = new System.Windows.Forms.Label();
            this.patchPanel2 = new System.Windows.Forms.Panel();
            this.patchText2 = new System.Windows.Forms.Label();
            this.patchButton2 = new System.Windows.Forms.Button();
            this.patchTitle2 = new System.Windows.Forms.Label();
            this.patchPanel3 = new System.Windows.Forms.Panel();
            this.patchText3 = new System.Windows.Forms.Label();
            this.patchButton3 = new System.Windows.Forms.Button();
            this.patchTitle3 = new System.Windows.Forms.Label();
            this.patchContainerPanel = new System.Windows.Forms.Panel();
            this.playButton = new System.Windows.Forms.Button();
            this.navbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.patchPanel1.SuspendLayout();
            this.patchPanel2.SuspendLayout();
            this.patchPanel3.SuspendLayout();
            this.patchContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateProgressBar
            // 
            this.updateProgressBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.updateProgressBar.Location = new System.Drawing.Point(17, 630);
            this.updateProgressBar.Name = "updateProgressBar";
            this.updateProgressBar.Size = new System.Drawing.Size(802, 60);
            this.updateProgressBar.TabIndex = 1;
            this.updateProgressBar.Visible = false;
            // 
            // updateLabelText
            // 
            this.updateLabelText.BackColor = System.Drawing.Color.Transparent;
            this.updateLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.updateLabelText.ForeColor = System.Drawing.SystemColors.Control;
            this.updateLabelText.Location = new System.Drawing.Point(17, 600);
            this.updateLabelText.Name = "updateLabelText";
            this.updateLabelText.Size = new System.Drawing.Size(802, 30);
            this.updateLabelText.TabIndex = 2;
            this.updateLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentVersionLabel
            // 
            this.currentVersionLabel.AutoSize = true;
            this.currentVersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.currentVersionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.currentVersionLabel.Location = new System.Drawing.Point(18, 600);
            this.currentVersionLabel.Name = "currentVersionLabel";
            this.currentVersionLabel.Size = new System.Drawing.Size(45, 17);
            this.currentVersionLabel.TabIndex = 3;
            this.currentVersionLabel.Text = "1.0.0";
            // 
            // navbarButton2
            // 
            this.navbarButton2.BackColor = System.Drawing.Color.Transparent;
            this.navbarButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.navbarButton2.FlatAppearance.BorderSize = 0;
            this.navbarButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.navbarButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.navbarButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navbarButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.navbarButton2.Location = new System.Drawing.Point(433, 0);
            this.navbarButton2.Name = "navbarButton2";
            this.navbarButton2.Size = new System.Drawing.Size(125, 55);
            this.navbarButton2.TabIndex = 0;
            this.navbarButton2.TabStop = false;
            this.navbarButton2.Text = "Новости";
            this.navbarButton2.UseVisualStyleBackColor = true;
            // 
            // navbarPanel
            // 
            this.navbarPanel.BackColor = System.Drawing.Color.Transparent;
            this.navbarPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navbarPanel.Controls.Add(this.logoPictureBox);
            this.navbarPanel.Controls.Add(this.imagePictureBox);
            this.navbarPanel.Controls.Add(this.minimizePictureBox);
            this.navbarPanel.Controls.Add(this.closePictureBox);
            this.navbarPanel.Controls.Add(this.navbarButton5);
            this.navbarPanel.Controls.Add(this.navbarButton4);
            this.navbarPanel.Controls.Add(this.navbarButton3);
            this.navbarPanel.Controls.Add(this.navbarButton1);
            this.navbarPanel.Controls.Add(this.navbarButton2);
            this.navbarPanel.Location = new System.Drawing.Point(0, -1);
            this.navbarPanel.Name = "navbarPanel";
            this.navbarPanel.Size = new System.Drawing.Size(1028, 350);
            this.navbarPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(300, 200);
            this.logoPictureBox.TabIndex = 2;
            this.logoPictureBox.TabStop = false;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.imagePictureBox.Location = new System.Drawing.Point(303, 61);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(580, 150);
            this.imagePictureBox.TabIndex = 8;
            this.imagePictureBox.TabStop = false;
            // 
            // minimizePictureBox
            // 
            this.minimizePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.minimizePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimizePictureBox.Image = global::Launcher.Properties.Resources.minimize_12x12;
            this.minimizePictureBox.Location = new System.Drawing.Point(955, 3);
            this.minimizePictureBox.Name = "minimizePictureBox";
            this.minimizePictureBox.Size = new System.Drawing.Size(25, 25);
            this.minimizePictureBox.TabIndex = 1;
            this.minimizePictureBox.TabStop = false;
            this.minimizePictureBox.Click += new System.EventHandler(this.minimizePictureBox_Click);
            this.minimizePictureBox.MouseEnter += new System.EventHandler(this.OnMouseEnterIcon);
            this.minimizePictureBox.MouseLeave += new System.EventHandler(this.OnMouseLeaveIcon);
            // 
            // closePictureBox
            // 
            this.closePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closePictureBox.Image = global::Launcher.Properties.Resources.cancel_12x12;
            this.closePictureBox.Location = new System.Drawing.Point(1000, 3);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(25, 25);
            this.closePictureBox.TabIndex = 1;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
            this.closePictureBox.MouseEnter += new System.EventHandler(this.OnMouseEnterIcon);
            this.closePictureBox.MouseLeave += new System.EventHandler(this.OnMouseLeaveIcon);
            // 
            // navbarButton5
            // 
            this.navbarButton5.BackColor = System.Drawing.Color.Transparent;
            this.navbarButton5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.navbarButton5.FlatAppearance.BorderSize = 0;
            this.navbarButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.navbarButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.navbarButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navbarButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.navbarButton5.Location = new System.Drawing.Point(823, 0);
            this.navbarButton5.Name = "navbarButton5";
            this.navbarButton5.Size = new System.Drawing.Size(125, 55);
            this.navbarButton5.TabIndex = 0;
            this.navbarButton5.TabStop = false;
            this.navbarButton5.Text = "Discord";
            this.navbarButton5.UseVisualStyleBackColor = false;
            // 
            // navbarButton4
            // 
            this.navbarButton4.BackColor = System.Drawing.Color.Transparent;
            this.navbarButton4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.navbarButton4.FlatAppearance.BorderSize = 0;
            this.navbarButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.navbarButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.navbarButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navbarButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.navbarButton4.Location = new System.Drawing.Point(693, 0);
            this.navbarButton4.Name = "navbarButton4";
            this.navbarButton4.Size = new System.Drawing.Size(125, 55);
            this.navbarButton4.TabIndex = 0;
            this.navbarButton4.TabStop = false;
            this.navbarButton4.Text = "Поддержка";
            this.navbarButton4.UseVisualStyleBackColor = false;
            // 
            // navbarButton3
            // 
            this.navbarButton3.BackColor = System.Drawing.Color.Transparent;
            this.navbarButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.navbarButton3.FlatAppearance.BorderSize = 0;
            this.navbarButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.navbarButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.navbarButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navbarButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.navbarButton3.Location = new System.Drawing.Point(563, 0);
            this.navbarButton3.Name = "navbarButton3";
            this.navbarButton3.Size = new System.Drawing.Size(125, 55);
            this.navbarButton3.TabIndex = 0;
            this.navbarButton3.TabStop = false;
            this.navbarButton3.Text = "Форум";
            this.navbarButton3.UseVisualStyleBackColor = false;
            // 
            // navbarButton1
            // 
            this.navbarButton1.BackColor = System.Drawing.Color.Transparent;
            this.navbarButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.navbarButton1.FlatAppearance.BorderSize = 0;
            this.navbarButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.navbarButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.navbarButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navbarButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.navbarButton1.Location = new System.Drawing.Point(303, 0);
            this.navbarButton1.Name = "navbarButton1";
            this.navbarButton1.Size = new System.Drawing.Size(125, 55);
            this.navbarButton1.TabIndex = 0;
            this.navbarButton1.TabStop = false;
            this.navbarButton1.Text = "Сайт";
            this.navbarButton1.UseVisualStyleBackColor = true;
            this.navbarButton1.Click += new System.EventHandler(this.navbarButton1_Click);
            // 
            // clientReadyLabel
            // 
            this.clientReadyLabel.BackColor = System.Drawing.Color.Transparent;
            this.clientReadyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.clientReadyLabel.Location = new System.Drawing.Point(499, 581);
            this.clientReadyLabel.Name = "clientReadyLabel";
            this.clientReadyLabel.Size = new System.Drawing.Size(320, 46);
            this.clientReadyLabel.TabIndex = 4;
            this.clientReadyLabel.Text = "Ваш клиент в курсе новых событий!";
            this.clientReadyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clientReadyLabel.Click += new System.EventHandler(this.clientReadyLabel_Click);
            // 
            // patchPanel1
            // 
            this.patchPanel1.BackColor = System.Drawing.Color.Transparent;
            this.patchPanel1.Controls.Add(this.patchText1);
            this.patchPanel1.Controls.Add(this.patchButton1);
            this.patchPanel1.Controls.Add(this.patchTitle1);
            this.patchPanel1.Location = new System.Drawing.Point(30, 76);
            this.patchPanel1.Name = "patchPanel1";
            this.patchPanel1.Size = new System.Drawing.Size(195, 300);
            this.patchPanel1.TabIndex = 5;
            // 
            // patchText1
            // 
            this.patchText1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.patchText1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patchText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.patchText1.ForeColor = System.Drawing.SystemColors.Control;
            this.patchText1.Location = new System.Drawing.Point(0, 42);
            this.patchText1.Name = "patchText1";
            this.patchText1.Size = new System.Drawing.Size(195, 216);
            this.patchText1.TabIndex = 3;
            this.patchText1.Click += new System.EventHandler(this.patchText1_Click);
            // 
            // patchButton1
            // 
            this.patchButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.patchButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.patchButton1.FlatAppearance.BorderSize = 0;
            this.patchButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patchButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.patchButton1.Location = new System.Drawing.Point(0, 253);
            this.patchButton1.Name = "patchButton1";
            this.patchButton1.Size = new System.Drawing.Size(195, 47);
            this.patchButton1.TabIndex = 2;
            this.patchButton1.TabStop = false;
            this.patchButton1.Text = "Подробнее...";
            this.patchButton1.UseVisualStyleBackColor = false;
            this.patchButton1.Click += new System.EventHandler(this.OnClickButton);
            // 
            // patchTitle1
            // 
            this.patchTitle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.patchTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.patchTitle1.Location = new System.Drawing.Point(0, 0);
            this.patchTitle1.Name = "patchTitle1";
            this.patchTitle1.Size = new System.Drawing.Size(195, 42);
            this.patchTitle1.TabIndex = 0;
            this.patchTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // patchPanel2
            // 
            this.patchPanel2.BackColor = System.Drawing.Color.Transparent;
            this.patchPanel2.Controls.Add(this.patchText2);
            this.patchPanel2.Controls.Add(this.patchButton2);
            this.patchPanel2.Controls.Add(this.patchTitle2);
            this.patchPanel2.Location = new System.Drawing.Point(260, 76);
            this.patchPanel2.Name = "patchPanel2";
            this.patchPanel2.Size = new System.Drawing.Size(195, 300);
            this.patchPanel2.TabIndex = 5;
            // 
            // patchText2
            // 
            this.patchText2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.patchText2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patchText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.patchText2.ForeColor = System.Drawing.SystemColors.Control;
            this.patchText2.Location = new System.Drawing.Point(0, 42);
            this.patchText2.Name = "patchText2";
            this.patchText2.Size = new System.Drawing.Size(195, 216);
            this.patchText2.TabIndex = 3;
            // 
            // patchButton2
            // 
            this.patchButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.patchButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.patchButton2.FlatAppearance.BorderSize = 0;
            this.patchButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patchButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.patchButton2.Location = new System.Drawing.Point(0, 253);
            this.patchButton2.Name = "patchButton2";
            this.patchButton2.Size = new System.Drawing.Size(195, 47);
            this.patchButton2.TabIndex = 2;
            this.patchButton2.TabStop = false;
            this.patchButton2.Text = "Подробнее...";
            this.patchButton2.UseVisualStyleBackColor = false;
            this.patchButton2.Click += new System.EventHandler(this.OnClickButton);
            // 
            // patchTitle2
            // 
            this.patchTitle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.patchTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.patchTitle2.Location = new System.Drawing.Point(0, 0);
            this.patchTitle2.Name = "patchTitle2";
            this.patchTitle2.Size = new System.Drawing.Size(195, 42);
            this.patchTitle2.TabIndex = 0;
            this.patchTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // patchPanel3
            // 
            this.patchPanel3.BackColor = System.Drawing.Color.Transparent;
            this.patchPanel3.Controls.Add(this.patchText3);
            this.patchPanel3.Controls.Add(this.patchButton3);
            this.patchPanel3.Controls.Add(this.patchTitle3);
            this.patchPanel3.Location = new System.Drawing.Point(490, 76);
            this.patchPanel3.Name = "patchPanel3";
            this.patchPanel3.Size = new System.Drawing.Size(195, 300);
            this.patchPanel3.TabIndex = 5;
            // 
            // patchText3
            // 
            this.patchText3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.patchText3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patchText3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.patchText3.ForeColor = System.Drawing.SystemColors.Control;
            this.patchText3.Location = new System.Drawing.Point(0, 42);
            this.patchText3.Name = "patchText3";
            this.patchText3.Size = new System.Drawing.Size(195, 216);
            this.patchText3.TabIndex = 3;
            this.patchText3.Click += new System.EventHandler(this.patchText3_Click);
            // 
            // patchButton3
            // 
            this.patchButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.patchButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.patchButton3.FlatAppearance.BorderSize = 0;
            this.patchButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patchButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.patchButton3.Location = new System.Drawing.Point(0, 253);
            this.patchButton3.Name = "patchButton3";
            this.patchButton3.Size = new System.Drawing.Size(195, 47);
            this.patchButton3.TabIndex = 2;
            this.patchButton3.TabStop = false;
            this.patchButton3.Text = "Подробнее...";
            this.patchButton3.UseVisualStyleBackColor = false;
            this.patchButton3.Click += new System.EventHandler(this.OnClickButton);
            // 
            // patchTitle3
            // 
            this.patchTitle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.patchTitle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.patchTitle3.Location = new System.Drawing.Point(0, 0);
            this.patchTitle3.Name = "patchTitle3";
            this.patchTitle3.Size = new System.Drawing.Size(195, 42);
            this.patchTitle3.TabIndex = 0;
            this.patchTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // patchContainerPanel
            // 
            this.patchContainerPanel.BackColor = System.Drawing.Color.Transparent;
            this.patchContainerPanel.Controls.Add(this.patchPanel2);
            this.patchContainerPanel.Controls.Add(this.patchPanel1);
            this.patchContainerPanel.Controls.Add(this.patchPanel3);
            this.patchContainerPanel.Location = new System.Drawing.Point(144, 200);
            this.patchContainerPanel.Name = "patchContainerPanel";
            this.patchContainerPanel.Size = new System.Drawing.Size(717, 370);
            this.patchContainerPanel.TabIndex = 4;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold);
            this.playButton.Location = new System.Drawing.Point(825, 630);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(191, 60);
            this.playButton.TabIndex = 0;
            this.playButton.TabStop = false;
            this.playButton.Text = "Играть";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.OnClickPlay);
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 700);
            this.Controls.Add(this.patchContainerPanel);
            this.Controls.Add(this.clientReadyLabel);
            this.Controls.Add(this.navbarPanel);
            this.Controls.Add(this.currentVersionLabel);
            this.Controls.Add(this.updateLabelText);
            this.Controls.Add(this.updateProgressBar);
            this.Controls.Add(this.playButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Application";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher";
            this.TransparencyKey = System.Drawing.Color.SandyBrown;
            this.Load += new System.EventHandler(this.OnLoadApplication);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Application_MouseDown);
            this.navbarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.patchPanel1.ResumeLayout(false);
            this.patchPanel2.ResumeLayout(false);
            this.patchPanel3.ResumeLayout(false);
            this.patchContainerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.ProgressBar updateProgressBar;
        private System.Windows.Forms.Label updateLabelText;
        private System.Windows.Forms.Label currentVersionLabel;
        private System.Windows.Forms.Button navbarButton2;
        private System.Windows.Forms.Button navbarButton5;
        private System.Windows.Forms.Button navbarButton4;
        private System.Windows.Forms.Button navbarButton3;
        private System.Windows.Forms.Panel navbarPanel;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.PictureBox minimizePictureBox;
        private System.Windows.Forms.Label clientReadyLabel;
        private System.Windows.Forms.Button navbarButton1;
        private System.Windows.Forms.Panel patchPanel1;
        private System.Windows.Forms.Label patchTitle1;
        private System.Windows.Forms.Button patchButton1;
        private System.Windows.Forms.Label patchText1;
        private System.Windows.Forms.Panel patchPanel2;
        private System.Windows.Forms.Label patchText2;
        private System.Windows.Forms.Button patchButton2;
        private System.Windows.Forms.Label patchTitle2;
        private System.Windows.Forms.Panel patchPanel3;
        private System.Windows.Forms.Label patchText3;
        private System.Windows.Forms.Button patchButton3;
        private System.Windows.Forms.Label patchTitle3;
        private System.Windows.Forms.Panel patchContainerPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
    }
}

