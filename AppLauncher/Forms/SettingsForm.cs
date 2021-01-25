using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void ExportDataBtn_Click(object sender, EventArgs e)
        {
            ExportData();
        }

        private void ExportData()
        {
            if (MessageBox.Show("Are you sure you want to export your data?", "Export data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "*.apl files (*.apl)";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    GlobalFunctions.SerializeOrExportUserData(dialog.FileName);
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            MainScreen.Data.Settings.Theme = Theme.Text;
            MainScreen.Data.Settings.Animations = Animations.Checked;

            MessageBox.Show("Settings have been saved!\nThe app will now restart.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GlobalFunctions.SerializeOrExportUserData();

            Application.Restart();
        }

        private void RestoreSettings()
        {
            this.Theme.Text = MainScreen.Data.Settings.Theme;
            this.Animations.Checked = MainScreen.Data.Settings.Animations;
        }
    }
}
