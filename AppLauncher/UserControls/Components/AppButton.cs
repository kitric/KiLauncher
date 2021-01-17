using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AppLauncher.UserControls.Components
{
    public partial class AppButton : UserControl
    {
        public App App { get; set; }

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
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    Process.Start(this.App.ExecutablePath);
                    break;

                case MouseButtons.Right:
                    AppInfo info = new AppInfo(this);
                    info.Show();
                    break;
            }
        }
    }
}
