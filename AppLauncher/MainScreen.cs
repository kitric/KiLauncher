using AppLauncher.UserControls.Pages;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace AppLauncher
{

    public enum SortMode
    {
        Name_Asc,
        Name_Desc,
    }


    public partial class MainScreen : Form
    {
        public static List<App> Apps = new List<App>();
        public static SortMode SortMode { get; set; }

        private bool dragging;
        private Point startPoint;


        public static MainScreen Instance;

        public MainScreen()
        {
            InitializeComponent();
            Instance = this;

            ApplyTheme();
            Content.Controls.Add(new HomePage());
        }

        static MainScreen()
        {
            Directory.CreateDirectory(Path.Combine(GlobalFunctions.GetProgramAppdataFolder(), "cache"));
            SortMode = (SortMode)Properties.Settings.Default.SortMode;
            DeserializeButtons();
        }

        private void ApplyTheme()
        {
            switch (Properties.Settings.Default.Theme)
            {
                case "Dark":
                    this.BackColor = Color.FromArgb(20, 20, 20);
                    this.Sidebar.BackColor = Color.FromArgb(18, 18, 18);
                    this.Title.ForeColor = Color.White;
                    this.bar.BackColor = Color.FromArgb(this.BackColor.R + 2, this.BackColor.G + 2, this.BackColor.B + 2);

                    break;

                case "Light":
                    this.BackColor = Color.White;
                    this.Sidebar.BackColor = Color.FromArgb(250, 250, 250);
                    this.HomeLB.ForeColor = Color.Tomato;
                    this.Title.ForeColor = Color.Tomato;
                    this.AppsLB.ForeColor = Color.Tomato;
                    this.SettingsLB.ForeColor = Color.Tomato;
                    this.bar.BackColor = Color.FromArgb(this.BackColor.R - 2, this.BackColor.G - 2, this.BackColor.B - 2);
                    break;
            }

            this.Content.BackColor = this.BackColor;
        }


        #region serialization
        private static void DeserializeButtons()
        {
            string cachePath = GlobalFunctions.GetProgramAppdataFolder();
            string fpath = Path.Combine(cachePath, "buttons.apl");

            if (File.Exists(fpath))
            {
                using (FileStream fs = new FileStream(fpath, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    Apps = (List<App>)formatter.Deserialize(fs);
                }
            }
        }

        public static void SerializeData()
        {
            using (FileStream fs = new FileStream(Path.Combine(GlobalFunctions.GetProgramAppdataFolder(), "buttons.apl"), FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, Apps);
            }
        }
        #endregion

        #region events
        /// <summary>
        /// Executed when the close button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            SerializeData();
            Properties.Settings.Default.SortMode = (int)SortMode;
            Properties.Settings.Default.Save();

            Environment.Exit(0);
        }

        private void HomeLB_Click(object sender, EventArgs e)
        {
            GlobalFunctions.SwitchTo<AppPage>(this.Content);
        }

        private void SettingsLB_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void HomeLB_Click_1(object sender, EventArgs e)
        {
            GlobalFunctions.SwitchTo<HomePage>(this.Content);
        }

        //Dragging events
        private void bar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = e.Location;

        }

        private void bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                this.Location = new Point((this.Location.X - startPoint.X) + e.X, (this.Location.Y - startPoint.Y) + e.Y);
                this.Update();
            }
        }

        private void bar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        #region delegates

        /// <summary>
        /// Helps sorting the list by name (Ascendent).
        /// </summary>
        internal static readonly Comparison<App> SortByName_Asc = delegate (App button, App other)
        {
            return button.DisplayName.CompareTo(other.DisplayName);
        };


        internal static readonly Comparison<App> SortByName_Desc = delegate (App button, App other)
        {
            return -button.DisplayName.CompareTo(other.DisplayName);
        };

        #endregion
    }
}
