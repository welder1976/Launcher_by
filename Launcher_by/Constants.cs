using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher {
    class Constants : Application {

        /// <summary>
        /// Core game info
        /// </summary>
        public static readonly string GAME_TITLE = "World of Warcraft";
        public static readonly string LAUNCHER_NAME = "MagicStorm";

        /// <summary>
        /// Paths & urls
        /// </summary>
        public static readonly string DESTINATION_PATH = Path.Combine((System.AppDomain.CurrentDomain.BaseDirectory), GAME_TITLE);
        public static readonly string ZIP_PATH = Path.Combine(DESTINATION_PATH, GAME_TITLE + ".zip");
        public static readonly string GAME_EXECUTABLE_PATH = Path.Combine("wow.exe");

        public static readonly string VERSION_URL = "https://localhost/updates/version.txt";
        public static readonly string APPLICATION_ICON_URL = "https://localhost/app_icon.ico"; // Needs to be .ico
        public static readonly string LOGO_URL = "https://localhost/fire_3.png"; // Updated 300 x 200 max formats: PNG / JPG / GIF
        public static readonly string IMAGE_URL = "https://localhost/logo.png"; // Title Banner 580x150 max, formats, PNG/JPG/GIF
        public static readonly string BACKGROUND_URL = "https://localhost/wallpaper.jpg";
        public static readonly string PATCH_NOTES_URL = "https://localhost/updates/updates.xml";
        public static readonly string CLIENT_DOWNLOAD_URL = "https://lepiigortv.com/Updates/client2.zip";

        /// <summary>
        /// Navigation bar buttons
        /// </summary>
        public static readonly string NAVBAR_BUTTON_1_TEXT = "Сайт";
        public static readonly string NAVBAR_BUTTON_1_URL = "https://localhost/";
        public static readonly string NAVBAR_BUTTON_2_TEXT = "Новости";
        public static readonly string NAVBAR_BUTTON_2_URL = "https://localhost/news";
        public static readonly string NAVBAR_BUTTON_3_TEXT = "Форум";
        public static readonly string NAVBAR_BUTTON_3_URL = "https://forum.localhost/";
        public static readonly string NAVBAR_BUTTON_4_TEXT = "Поддержка";
        public static readonly string NAVBAR_BUTTON_4_URL = "https://localhost/cata/support";
        public static readonly string NAVBAR_BUTTON_5_TEXT = "Discord";
        public static readonly string NAVBAR_BUTTON_5_URL = "";

        // Modify this array if you're adding or removing a button
        public static readonly string[] NAVBAR_BUTTON_TEXT_ARRAY = {NAVBAR_BUTTON_1_TEXT, NAVBAR_BUTTON_2_TEXT, NAVBAR_BUTTON_3_TEXT,
                                                                    NAVBAR_BUTTON_4_TEXT, NAVBAR_BUTTON_5_TEXT };

        /// <summary>
        /// Settings
        /// </summary>
        public static bool SHOW_VERSION_TEXT = true;
        public static bool AUTOMATICALLY_BEGIN_UPDATING = false;
        public static bool AUTOMATICALLY_LAUNCH_GAME_AFTER_UPDATING = false;
        public static bool SHOW_ERROR_BOX_IF_PATCH_NOTES_DOWNLOAD_FAILS = true;

    }
}
