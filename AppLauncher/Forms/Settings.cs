using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppLauncher
{
    public partial class Settings : Form
    {
        private bool dragging = false;
        private Point startPoint;

        public Settings()
        {
            InitializeComponent();
            RestoreSettings();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            if (Properties.Settings.Default.Theme == "Dark")
            {
                this.BackgroundPanel.BackColor = Color.FromArgb(20, 20, 20);

            }
            else if (Properties.Settings.Default.Theme == "Light")
            {

                this.BackgroundPanel.BackColor = Color.White;
                this.label1.ForeColor = Color.Tomato;
                this.label2.ForeColor = Color.Tomato;
                this.Save.ForeColor = Color.Tomato;
            }

            this.bar.BackColor = BackgroundPanel.BackColor;
        }

        /// <summary>
        /// When the settings forms is opened, retrieves the settings.
        /// </summary>
        /// 
        private void RestoreSettings()
        {
            foreach (Control control in BackgroundPanel.Controls)
            {
                if (control.GetType() == typeof(DomainUpDown))
                {
                    DomainUpDown setting = (DomainUpDown)BackgroundPanel.Controls.Find(control.Name, false)[0];
                    setting.Text = Convert.ToString(Properties.Settings.Default[setting.Name]);                
                }
            }
        }

        #region events
        private void Save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Settings saved! The app will now restart.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Properties.Settings.Default.Theme = Theme.Text;
                Properties.Settings.Default.Save();

                MainScreen.SerializeData();
                Application.Restart();
            }
        }

        private void CloseSettings_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
