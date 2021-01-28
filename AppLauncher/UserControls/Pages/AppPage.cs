using AppLauncher.UserControls.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AppLauncher.UserControls.Pages
{
    public partial class AppPage : UserControl
    {
        public AppPage()
        {
            InitializeComponent();
            ApplyTheme();

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
        /// Adds the already-deserialized buttons in the list to the grid.
        /// </summary>
        private void AddButtonsToGrid()
        {
            // If there are buttons in the grid, remove the label.
            if (MainScreen.Data.Apps.Count > 0)
            {
                foreach (App p in MainScreen.Data.Apps)
                {
                    AppButton btn = new AppButton(p);
                    this.Grid.Controls.Add(btn);
                }

                this.Grid.Controls.Remove(Label);
            }
        }


        /// <summary>
        /// Contains the code that handles the search feature.
        /// </summary>
        /// <param name="query">The query.</param>
        /// 
        private void HandleSearch(string query)
        {
            // If the query is empty, no need to execute this at all.
            if (!string.IsNullOrEmpty(query))
            {
                ClearButtons(false);

                foreach (App p in MainScreen.Data.Apps)
                {
                    if (p.DisplayName.ToLower().Contains(query)) // Found you boi
                    {
                        this.Grid.Controls.Add(new AppButton(p));
                    }
                }

                if (this.Grid.Controls.Count == 0) // No results... How did that happen?!
                {
                    this.Grid.Controls.Add(Label);
                }

            }
            else // Adds all buttons to the list, again.
            {
                ClearButtons(false);

                MainScreen.Data.Apps.ForEach(x => Grid.Controls.Add(new AppButton(x)));
            }
        }


        /// <summary>
        /// Clears all buttons from the grid.
        /// </summary>
        private void ClearButtons(bool clearCache)
        {
            // In order to not mess with the for each loop, a copy of the list must be created.
            List<AppButton> controls = new List<AppButton>(Grid.Controls.OfType<AppButton>());

            foreach (AppButton btn in controls)
            {
                if (clearCache) btn.DeleteBG();

                btn.Dispose();
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

            // Clears everything to add them again.
            ClearButtons(false);

            foreach (App p in MainScreen.Data.Apps)
            {
                Grid.Controls.Add(new AppButton(p));
            }

            string name = MainScreen.SortMode.ToString().Replace("_", " ");
            this.SortModeLabel.Text = name;
        }


        #region events
        private void CreateApp_Click(object sender, EventArgs e)
        {
            GlobalFunctions.SwitchTo<NewAppPage>(MainScreen.Instance.Content);
        }

        private void SortUpArrow_Click(object sender, EventArgs e)
        {
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
        }

        private void SortDownArrow_Click(object sender, EventArgs e)
        {
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

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            this.Grid.Controls.Remove(Label);
            HandleSearch(this.SearchBar.Text);
        }
        #endregion

        private void AppPage_Load(object sender, EventArgs e)
        {
            GlobalFunctions.HideScrollbars(Grid);
            AddButtonsToGrid();
        }
    }
}
