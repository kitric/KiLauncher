using System;
using System.Windows.Forms;

namespace AppLauncher.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            RestoreSettings();
        }

        #region events
        private void ExportDataBtn_Click(object sender, EventArgs e) => ExportData();

        private void ImportDataBtn_Click(object sender, EventArgs e) => ImportData();

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            MainScreen.Data.Settings.Theme = Theme.Text;

            MessageBox.Show("Settings have been saved!\nThe app will now restart.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GlobalFunctions.SerializeOrExportUserData();

            Application.Restart();
        }
        #endregion

        private void ImportData()
        {
            if (MessageBox.Show("Are you sure you want to import data?\nYour current data will be lost.", "Import data", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "apl files (*.apl)|*.apl";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    GlobalFunctions.DeserializeUserData(dialog.FileName);

                    MessageBox.Show("Data has been imported. The app will now restart.");

                    GlobalFunctions.SerializeOrExportUserData();
                    Application.Restart();
                }
            }
        }

        private void ExportData()
        {
            if (MessageBox.Show("Are you sure you want to export your data?", "Export data", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "apl files (*.apl)|*.apl";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    GlobalFunctions.SerializeOrExportUserData(dialog.FileName);
                }
            }
        }

        private void RestoreSettings()
        {
            this.Theme.Text = MainScreen.Data.Settings.Theme;
        }


    }
}
