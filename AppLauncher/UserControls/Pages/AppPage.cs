﻿using AppLauncher.UserControls.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AppLauncher.UserControls.Pages
{
    public partial class AppPage : UserControl
    {
        internal static AppPage Instance;

        public AppPage()
        {
            InitializeComponent();
            ApplyTheme();

            Instance = this;

            this.SortModeLabel.Text = MainScreen.SortMode.ToString().Replace("_", " ");
        }

        private void ApplyTheme()
        {
            switch (MainScreen.Data.Settings.Theme)
            {
                case "Dark":
                    this.SearchBar.ForeColor = Color.Black;

                    this.CreateApp.BackColor = Color.FromArgb(20, 20, 20);
                    this.Clear.BackColor = Color.FromArgb(20, 20, 20);
                    this.SearchBar.BackColor = Color.White;

                    break;

                case "Light":
                    this.SearchBar.BackColor = Color.WhiteSmoke;
                    this.SearchBar.ForeColor = Color.Black;

                    this.SortModeLabel.ForeColor = Color.Tomato;

                    this.CreateApp.ForeColor = Color.Tomato;
                    this.CreateApp.BackColor = Color.White;

                    this.Label.ForeColor = Color.Tomato;

                    this.Clear.ForeColor = Color.Tomato;
                    this.Clear.BackColor = Color.White;

                    this.SortUp_Arrow.Image = Properties.Resources.arrowUp_red;
                    this.sortDown_Arrow.Image = Properties.Resources.arrowDown_red;
                    break;
            }
        }

        /// <summary>
        /// Contains the code that handles the search feature.
        /// </summary>
        /// <param name="query">The query.</param>
        /// 
        private void HandleSearch(string query)
        {
            AppButton[] appButtons;

            // If the query is empty, no need to execute this at all.
            if (!string.IsNullOrEmpty(query))
            {
                ClearButtons(clearCache: false);

                appButtons = GetAppButtonArray();

                // Selects all buttons from appButton whose displayName match the query.
                appButtons = appButtons.Where(x => x.App.DisplayName.ToLower().Contains(query)).ToArray();
            }
            else // Adds all buttons to the list, again.
            {
                ClearButtons(clearCache: false);
                appButtons = GetAppButtonArray();
            }
            
            this.Grid.Controls.AddRange(appButtons);

            // No results... How did that happen?!
            if (this.Grid.Controls.Count == 0) 
            {
                this.Grid.Controls.Add(Label);
            }
        }


        /// <summary>
        /// Clears all buttons.
        /// </summary>
        private void ClearButtons(bool clearCache)
        {
            // In order to not mess with the for each loop, a copy of the list must be created.
            List<AppButton> controls = new List<AppButton>(Grid.Controls.OfType<AppButton>());

            for (int i = 0; i < controls.Count; i++)
            {
                if (clearCache) controls[i].DeleteBG();

                controls[i].Dispose();
            }
        }

        /// <summary>
        /// Sorts the list and adds them to the grid accordingly.
        /// </summary>
        /// 
        public void SortButtonsList()
        {
            switch (MainScreen.SortMode)
            {
                case SortMode.Name_Asc: MainScreen.Data.Apps.Sort(MainScreen.SortByName_Asc); break;
                case SortMode.Name_Desc: MainScreen.Data.Apps.Sort(MainScreen.SortByName_Desc); break;
            }

            // Clears everything, then adds all buttons again.
            ClearButtons(clearCache: false);

            AppButton[] buttons = GetAppButtonArray();

            Grid.Controls.AddRange(buttons);

            string name = MainScreen.SortMode.ToString().Replace("_", " ");
            this.SortModeLabel.Text = name;
        }

        /// <summary>
        /// A helper method for SortButtonsList.
        /// </summary>
        /// <returns></returns>
        private static AppButton[] GetAppButtonArray()
        {
            int len = MainScreen.Data.Apps.Count;

            AppButton[] apps = new AppButton[len];
            for (int i = 0; i < len; i++)
            {
                apps[i] = new AppButton(MainScreen.Data.Apps[i]);
            }

            return apps;
        }

        #region events
        private void CreateApp_Click(object sender, EventArgs e)
        {
            GlobalFunctions.SwitchTo<NewAppPage>(MainScreen.Instance.Content);
        }

        private void SortUpArrow_Click(object sender, EventArgs e)
        {
            this.Controls.Add(SplashScreen);
            this.SplashScreen.BringToFront();

            int current = (int)MainScreen.SortMode;

            if (current == 0)
            {
                int length = Enum.GetValues(typeof(SortMode)).Length;
                MainScreen.SortMode = (SortMode)Enum.GetValues(typeof(SortMode)).GetValue(length - 1);
            }
            else
            {
                MainScreen.SortMode--;
            }

            SortButtonsList();
            this.Controls.Remove(SplashScreen);
        }

        private void SortDownArrow_Click(object sender, EventArgs e)
        {
            this.Controls.Add(SplashScreen);
            this.SplashScreen.BringToFront();

            int current = (int)MainScreen.SortMode;
            int length = Enum.GetValues(typeof(SortMode)).Length;

            if (current == length - 1)
            {
                MainScreen.SortMode = (SortMode)Enum.GetValues(typeof(SortMode)).GetValue(0);
            }
            else
            {
                MainScreen.SortMode++;
            }

            SortButtonsList();
            this.Controls.Remove(SplashScreen);
        }

        /// <summary>
        /// Erases all buttons from the grid and clears the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete all entries?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ClearButtons(true);
                MainScreen.Data.Apps.Clear();

                // Ensures everything is disposed by calling the garbage collector.
                GC.Collect();
                GC.WaitForPendingFinalizers();

                if (!Grid.Controls.Contains(Label)) this.Grid.Controls.Add(Label);
            }
        }

        private void SearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Grid.Controls.Remove(Label);
                HandleSearch(this.SearchBar.Text);
            }
        }

        private void AppPage_Load(object sender, EventArgs e)
        {
            GlobalFunctions.HideScrollbars(Grid);

            // If there are any apps in the Apps list, sort them, removing the "So Empty..." label afterwards. 
            if (MainScreen.Data.Apps.Count > 0)
            {
                SortButtonsList();
                this.Grid.Controls.Remove(Label);
            }

            this.Controls.Remove(SplashScreen);
        }
        #endregion
    }
}
