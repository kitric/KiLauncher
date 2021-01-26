using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AppLauncher.UserControls.Pages
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void NordicBtn_Click(object sender, EventArgs e) => Process.Start("https://github.com/nordic16");

        private void crxssedBtn_Click(object sender, EventArgs e) => Process.Start("https://github.com/crxssed7");


        private void ApplyTheme()
        {
            switch (MainScreen.Data.Settings.Theme)
            {
                case "Dark":
                    this.NordicBtn.BackColor = Color.FromArgb(19, 19, 19);
                    this.crxssedBtn.BackColor = Color.FromArgb(19, 19, 19);
                    break;

                case "Light":
                    this.BackColor = Color.White;

                    this.Title.ForeColor = Color.Tomato;

                    this.NordicBtn.BackColor = Color.FromArgb(250, 250, 250);
                    this.NordicBtn.Image = Properties.Resources.nordic_dark;

                    this.crxssedBtn.BackColor = Color.FromArgb(250, 250, 250);
                    this.crxssedBtn.Image = Properties.Resources.crxssed_dark;

                    break;
            }
        }
    }
}
