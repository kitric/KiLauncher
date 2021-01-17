﻿using AppLauncher.UserControls.Pages;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AppLauncher.UserControls.Components
{
    public partial class AppButton : UserControl
    {
        private static readonly Random random = new Random();

        public App App { get; set; }

        /// <summary>
        /// Used for identification.
        /// </summary>
        public int ID { get; set; }

        public AppButton(App app)
        {
            InitializeComponent();

            this.App = app;
            this.Button.Text = App.DisplayName;

            if (!string.IsNullOrEmpty(App.ImagePath))
            {
                this.Button.Image = GlobalFunctions.ResizeImage(Image.FromFile(App.ImagePath), this.Button.Width, this.Button.Height);
            }

            this.Button.ForeColor = App.DisplayColor;

            CreateID();
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    Process.Start(this.App.ExecutablePath);
                    break;

                case MouseButtons.Right:
                    GlobalFunctions.SwitchTo<AppInfoPage>(MainScreen.Instance.Content, new object[] { this });
                    break;
            }
        }

        /// <summary>
        /// Frees the background image used by a button.
        /// </summary>
        public void DisposeBG()
        {
            this.Button.BackgroundImage = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            if (!string.IsNullOrEmpty(App.ImagePath))
            {
                File.Delete(App.ImagePath);
            }

            this.App.ImagePath = null;
        }


        /// <summary>
        /// Creates an unique ID for each shortcut.
        /// Might need to refactor this later.
        /// </summary>
        private void CreateID()
        {
            int rand;
            bool found = false;

            while (true)
            {
                rand = random.Next(int.MaxValue - 5);

                //Loops for all created buttons. Checks if the generated ID already exists.
                foreach (App x in MainScreen.Apps)
                {
                    if (x.ID == rand)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found) { break; }
            }
            this.ID = rand;
        }
    }
}
