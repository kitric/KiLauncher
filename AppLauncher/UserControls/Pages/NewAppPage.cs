﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLauncher.UserControls.Pages
{
    public partial class NewAppPage : UserControl
    {

        private Color SelectedColor = Color.White;


        public NewAppPage()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            switch (Properties.Settings.Default.Theme)
            {
                case "Dark":
                    this.BackColor = Color.FromArgb(20, 20, 20);

                    this.DisplayName.BackColor = this.BackColor;

                    this.button1.BackColor = this.BackColor;
                    this.button2.BackColor = this.BackColor;
                    this.button3.BackColor = this.BackColor;
                    this.CreateProcessButton.BackColor = this.BackColor;

                    break;

                case "Light":
                    this.BackColor = Color.White;

                    this.Label1.ForeColor = Color.Tomato;
                    this.DisplayName.BackColor = Color.WhiteSmoke;
                    this.DisplayName.ForeColor = Color.Tomato;

                    this.label2.ForeColor = Color.Tomato;
                    this.PathText.ForeColor = Color.Tomato;


                    this.label3.ForeColor = Color.Tomato;
                    this.ImagePathText.ForeColor = Color.Tomato;

                    this.label4.ForeColor = Color.Tomato;

                    this.button1.ForeColor = Color.Tomato;
                    this.button2.ForeColor = Color.Tomato;
                    this.button3.ForeColor = Color.Tomato;
                    this.CreateProcessButton.ForeColor = Color.Tomato;

                    this.button1.BackColor = this.BackColor;
                    this.button2.BackColor = this.BackColor;
                    this.button3.BackColor = this.BackColor;
                    this.CreateProcessButton.BackColor = this.BackColor;

                    break;

            }            
        }


        /// <summary>
        /// Creates a copy of the image used in the cache.
        /// </summary>
        /// <param name="originalFilePath"></param>
        /// <param name="id"></param>
        public static string CreateCopyInCache(string originalFilePath, int id)
        {
            string extension = Path.GetExtension(originalFilePath);

            string pathToWrite = Path.Combine(GlobalFunctions.GetProgramAppdataFolder(), "cache", $"{id}_posters{extension}");

            File.Copy(originalFilePath, pathToWrite);

            return pathToWrite;

        }


        #region events
        /// <summary>
        /// Invoked whenever the Create button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void CreateProcessButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.DisplayName.Text) && !string.IsNullOrEmpty(this.PathText.Text))
            {
                App app = new App(this.PathText.Text, this.DisplayName.Text, SelectedColor);
                //Creates a new copy in the app cache if an image is specified.
                app.ImagePath = !string.IsNullOrEmpty(this.ImagePathText.Text) ? CreateCopyInCache(this.ImagePathText.Text, app.ID) : "";

                //MainScreen.Instance.Grid.Controls.Add(new AppButton(app));
                //MainScreen.Instance.Grid.Controls.Remove(MainScreen.Instance.Label);

                MainScreen.Apps.Add(app);

                GlobalFunctions.SwitchTo<AppPage>(MainScreen.Instance.Content);
            }
            else
            {
                MessageBox.Show("Invalid properties.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        /// <summary>
        /// Sets the process' path.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetExecutablePath_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog
            {
                Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*|bat files (*.bat)|*.bat"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.PathText.Text = dialog.FileName;
            }
        }

        /// <summary>
        /// Sets an optional image Path.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetImagePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.ImagePathText.Text = dialog.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                SelectedColor = colorDialog1.Color;
            }
        }
        #endregion
    }
}
