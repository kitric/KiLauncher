using AppLauncher.UserControls.Components;
using System;
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
    public partial class AppInfoPage : UserControl
    {
        public AppButton AppButton { get; set; }

        public AppInfoPage(AppButton button)
        {
            this.AppButton = button;
            InitializeComponent();
            SetupWindow();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            switch (Properties.Settings.Default.Theme)
            {
                case "Dark":
                    this.BackColor = Color.FromArgb(20, 20, 20);

                    this.DisplayName.BackColor = Color.FromArgb(20, 20, 20);
                    this.ChangePath.BackColor = Color.FromArgb(20, 20, 20);
                    this.ChangeImagePath.BackColor = Color.FromArgb(20, 20, 20);
                    this.ChangeColor.BackColor = Color.FromArgb(20, 20, 20);
                    this.RemoveImage.BackColor = Color.FromArgb(20, 20, 20);
                    break;

                case "Light":
                    this.BackColor = Color.White;

                    this.DisplayName.BackColor = this.BackColor;
                    this.ChangeColor.BackColor = this.BackColor;
                    this.ChangeImagePath.BackColor = this.BackColor;
                    this.ChangePath.BackColor = this.BackColor;
                    this.RemoveImage.BackColor = this.BackColor;

                    this.DisplayName.ForeColor = Color.Tomato;
                    this.ChangeColor.ForeColor = Color.Tomato;
                    this.ChangeImagePath.ForeColor = Color.Tomato;
                    this.ChangePath.ForeColor = Color.Tomato;
                    this.RemoveImage.ForeColor = Color.Tomato;
                    break;
            }
        }

        /// <summary>
        /// Updates UI components.
        /// </summary>
        private void SetupWindow()
        {
            this.DisplayName.Text = AppButton.App.DisplayName;

        }

        
        #region events
        private void DeleteProcess_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this entry?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MainScreen.Apps.Remove(this.AppButton.App);

                //If the shortcut has a background image.
                if (this.AppButton.Button.BackgroundImage != null)
                {
                    this.AppButton.DisposeBG();
                }

                GlobalFunctions.SwitchTo<AppPage>(MainScreen.Instance.Content);
            }
        }

        
        private void ChangeImagePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files (*.png)|*.png|All files (*.*)|*.*|jpg files (*.jpg)|*.jpg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //If a shortcut background image exists, it must be deleted first.
                if (!string.IsNullOrEmpty(this.AppButton.App.ImagePath))
                {
                    this.AppButton.DisposeBG();
                }

                this.AppButton.App.ImagePath = GlobalFunctions.CreateCopyInCache(dialog.FileName, this.AppButton.ID);
            }
        }

        
        /// <summary>
        /// In case the user double clicks on a shortcut title, they'll be able to rename it.
        /// </summary>
        private void DisplayName_DoubleClick(object sender, EventArgs e)
        {
            this.DisplayName.ReadOnly = false;
        }

    
        /// <summary>
        /// In case the user is done typing the new name, they can press enter to set it.
        /// </summary>
        private void DisplayName_Enter_Pressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.AppButton.App.DisplayName = this.DisplayName.Text;
                this.AppButton.Button.Text = this.AppButton.App.DisplayName;
                this.DisplayName.ReadOnly = true;
            }
        }

        /// <summary>
        /// Changes the executable's path.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "exe files (*.exe)|*.exe|bat files (*.bat)|*.bat|vbs files (*.vbs)|*.vbs";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.AppButton.App.ExecutablePath = dialog.FileName;
            }
        }
        
        private void ChangeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.AppButton.App.DisplayColor = colorDialog1.Color;
            }
        }

        private void RemoveImage_Click(object sender, EventArgs e) => this.AppButton.DisposeBG();

        private void DeleteApp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete \"{this.AppButton.App.DisplayName}\"?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.AppButton.DisposeBG();

                MainScreen.Apps.Remove(this.AppButton.App);
                this.AppButton.Dispose();

                GlobalFunctions.SwitchTo<AppPage>(MainScreen.Instance.Content);
            }
        }
        #endregion
    }
}

