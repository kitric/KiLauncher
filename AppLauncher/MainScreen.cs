using AppLauncher.Forms;
using AppLauncher.Models;
using AppLauncher.UserControls.Pages;
using System;
using System.Drawing;
using System.IO;
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
        public static UserData Data;
        public static SortMode SortMode { get; set; }

        private bool dragging;
        private Point startPoint;


        public static MainScreen Instance;

        public MainScreen()
        {
            InitializeComponent();
            Instance = this;
        }

        static MainScreen()
        {
            Directory.CreateDirectory(Path.Combine(GlobalFunctions.GetProgramAppdataFolder(), "cache"));
            SortMode = (SortMode)Properties.Settings.Default.SortMode;
        }

        private void ApplyTheme()
        {
            switch (Data.Settings.Theme)
            {
                case "Dark":
                    this.BackColor = Color.FromArgb(20, 20, 20);
                    this.Sidebar.BackColor = Color.FromArgb(18, 18, 18);
                    this.Title.ForeColor = Color.White;

                    break;

                case "Light":
                    this.BackColor = Color.White;
                    this.Sidebar.BackColor = Color.FromArgb(250, 250, 250);
                    this.HomeLB.ForeColor = Color.Tomato;
                    this.Title.ForeColor = Color.Tomato;
                    this.AppsLB.ForeColor = Color.Tomato;
                    this.SettingsLB.ForeColor = Color.Tomato;
                    break;
            }

            this.Content.BackColor = this.BackColor;
        }


        #region events
        /// <summary>
        /// Executed when the close button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalFunctions.SerializeOrExportUserData();
            Properties.Settings.Default.SortMode = (int)SortMode;
            Properties.Settings.Default.Save();
        }

        private void AppsLB_Click(object sender, EventArgs e)
        {
            GlobalFunctions.SwitchTo<AppPage>(this.Content);
        }

        private void SettingsLB_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.Show();
        }

        private void HomeLB_Click(object sender, EventArgs e) => GlobalFunctions.SwitchTo<HomePage>(this.Content);

        private void MainScreen_Load(object sender, EventArgs e) => GlobalFunctions.DeserializeUserData();

        private void MainScreen_Shown(object sender, EventArgs e)
        {
            ApplyTheme();
            Content.Controls.Add(new HomePage());
        }

        //<Dragging events>
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

        private void bar_MouseUp(object sender, MouseEventArgs e) => dragging = false;
        //</Dragging events>
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
