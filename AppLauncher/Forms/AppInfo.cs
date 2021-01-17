using AppLauncher.UserControls.Components;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AppLauncher
{
    /// <summary>
    /// Displays information about a specific process.
    /// </summary>
    public partial class AppInfo : Form
    {

        private bool dragging = false;
        private Point startPoint;

        public AppButton AppButton { get; set; }

        public AppInfo(AppButton button)
        {
            this.AppButton = button;
            InitializeComponent();
            SetupWindow();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            if (Properties.Settings.Default.Theme == "Dark")
            {
                this.BackgroundPanel.BackColor = Color.FromArgb(20, 20, 20);
                this.DisplayName.BackColor = Color.FromArgb(20, 20, 20);

            }
            else if (Properties.Settings.Default.Theme == "Light")
            {
                this.BackgroundPanel.BackColor = Color.White;
                this.DisplayName.BackColor = Color.White;
                this.DisplayName.ForeColor = Color.Tomato;


                this.ChangePath.ForeColor = Color.Tomato;
                this.ChangeImagePath.ForeColor = Color.Tomato;
                this.RemoveImage.ForeColor = Color.Tomato;
                this.ChangeColor.ForeColor = Color.Tomato;
            }

            this.bar.BackColor = this.BackgroundPanel.BackColor;
            this.ChangePath.BackColor = this.BackgroundPanel.BackColor;
            this.ChangeImagePath.BackColor = this.BackgroundPanel.BackColor;
        }

        /// <summary>
        /// Updates UI components.
        /// </summary>
        private void SetupWindow()
        {
            //this.DisplayName.Text = AppButton.DisplayName;
            
        }

        /*
        #region events
        private void DeleteProcess_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this entry?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MainScreen.Form.Grid.Controls.Remove(MainScreen.Apps.Find(x => x.ID == AppButton.ID).Button);
                MainScreen.Apps.Remove(MainScreen.Apps.Find(x => x.ID == AppButton.ID));

                string posterCache = this.AppButton.ImagePath;

                //If the shortcut has a background image.
                if (this.AppButton.Button.BackgroundImage != null)
                {
                    this.AppButton.DisposeBG();
                    File.Delete(posterCache);
                }

                this.Close();
            }
        }

        */

        /*
        private void ChangeImagePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files (*.png)|*.png|All files (*.*)|*.*|jpg files (*.jpg)|*.jpg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //If a shortcut background image exists, it must be deleted first.
                if (!string.IsNullOrEmpty(this.AppButton.ImagePath))
                {
                    this.AppButton.DisposeBG();
                }

                this.AppButton.ImagePath = CreateApp.CreateCopyInCache(dialog.FileName, this.AppButton.ID);
            }
        }

        */

        /// <summary>
        /// In case the user double clicks a shortcut's title, they'll be able to rename it.
        /// </summary>
        private void DisplayName_DoubleClick(object sender, EventArgs e)
        {
            this.DisplayName.ReadOnly = false;
        }


        /*
        /// <summary>
        /// In case the user is done typing the new name, they can press enter to set it.
        /// </summary>
        private void DisplayName_Enter_Pressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.AppButton.DisplayName = this.DisplayName.Text;
                this.AppButton.Button.Text = this.AppButton.DisplayName;
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
                this.AppButton.ExecutablePath = dialog.FileName;
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ChangeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.AppButton.DisplayColor = colorDialog1.Color;
            }
        }

        */


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


        private void RemoveImage_Click(object sender, EventArgs e)
        {
            //this.AppButton.DisposeBG();
        }
    }
}
