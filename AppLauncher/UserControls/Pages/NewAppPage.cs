using System;
using System.Drawing;
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
            switch (MainScreen.Data.Settings.Theme)
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


        #region events
        /// <summary>
        /// Invoked whenever the Create button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void CreateProcessButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.PathText.Text))
            {
                string name = this.DisplayName.Text == "-" || string.IsNullOrEmpty(this.DisplayName.Text) ? "" : this.DisplayName.Text;

                App app = new App(this.PathText.Text, name, SelectedColor);
                //Creates a new copy in the app cache if an image is specified.
                app.ImagePath = !string.IsNullOrEmpty(this.ImagePathText.Text) ?
                    GlobalFunctions.CreateCopyInCache(this.ImagePathText.Text, app.ID) : "";

                MainScreen.Data.Apps.Add(app);

                GlobalFunctions.SwitchTo<AppPage>(MainScreen.Instance.Content, args: new object[] { });
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
                Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*|bat files (*.bat)|*.bat|vbs files (*.vbs)|*.vbs"
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

        private void setDisplayColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                SelectedColor = colorDialog1.Color;
            }
        }
        #endregion
    }
}
