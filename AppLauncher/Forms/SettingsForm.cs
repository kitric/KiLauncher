using AppLauncher.UserControls.Components;
using AppLauncher.UserControls.Pages;
using System;
using System.IO;
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

        private void ClearDataBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("THIS OPTION ALLOWS YOU TO RESET KILAUNCHER.\nARE YOU SURE YOU WANT TO PROCEED?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Avoids serialization.
                GlobalFunctions.canSerialize = false;

                MainScreen.Data.Apps.Clear();

                if (AppPage.Instance != null)
                {
                    MainScreen.Instance.Hide();
                    foreach (AppButton btn in AppPage.Instance.Grid.Controls)
                    {
                        btn.DeleteBG();
                        btn.Dispose();
                    }
                }

                DeleteFilesRecursively(GlobalFunctions.GetProgramAppdataFolder());

                MessageBox.Show("KiLauncher has been reset to its default stage.\nThe app will now restart.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
        }

        /// <summary>
        /// Deletes everything within path recursively.
        /// </summary>
        /// <param name="path">The parent folder. This folder won't be deleted.</param>
        private static void DeleteFilesRecursively(string path)
        {
            //If the folder is not empty.
            if (Directory.GetFileSystemEntries(path).Length > 0)
            {
                // Loops through everything within path.
                foreach (string fPath in Directory.GetFileSystemEntries(path))
                {
                    // It's a folder: recurse through its content and then delete it.
                    if (Directory.Exists(fPath))
                    {
                        // Delete everything within fPath.
                        DeleteFilesRecursively(fPath);
                        Directory.Delete(fPath); // Folder is deleted after all children have been deleted.
                    }
                    else //It's a file.
                    {
                        File.Delete(fPath);
                    }
                }

                // If the folder is empty, no need to recurse through its content, so go back and recurse through the parent folder.
            }
            else
            {
                return;
            }
        }
    }
}
