
namespace AppLauncher.Forms
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SettingsPage = new System.Windows.Forms.TabControl();
            this.AppSettings = new System.Windows.Forms.TabPage();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.Theme = new System.Windows.Forms.DomainUpDown();
            this.ThemeLB = new System.Windows.Forms.Label();
            this.DataPage = new System.Windows.Forms.TabPage();
            this.ImportDataBtn = new System.Windows.Forms.Button();
            this.ExportDataBtn = new System.Windows.Forms.Button();
            this.FAQ = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearDataBtn = new System.Windows.Forms.Button();
            this.SettingsPage.SuspendLayout();
            this.AppSettings.SuspendLayout();
            this.DataPage.SuspendLayout();
            this.FAQ.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsPage
            // 
            this.SettingsPage.Controls.Add(this.AppSettings);
            this.SettingsPage.Controls.Add(this.DataPage);
            this.SettingsPage.Controls.Add(this.FAQ);
            this.SettingsPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsPage.Location = new System.Drawing.Point(0, 0);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.SelectedIndex = 0;
            this.SettingsPage.Size = new System.Drawing.Size(376, 232);
            this.SettingsPage.TabIndex = 0;
            // 
            // AppSettings
            // 
            this.AppSettings.Controls.Add(this.SaveBtn);
            this.AppSettings.Controls.Add(this.Theme);
            this.AppSettings.Controls.Add(this.ThemeLB);
            this.AppSettings.Location = new System.Drawing.Point(4, 22);
            this.AppSettings.Name = "AppSettings";
            this.AppSettings.Padding = new System.Windows.Forms.Padding(3);
            this.AppSettings.Size = new System.Drawing.Size(368, 206);
            this.AppSettings.TabIndex = 0;
            this.AppSettings.Text = "App";
            this.AppSettings.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.Location = new System.Drawing.Point(285, 176);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Theme
            // 
            this.Theme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Theme.Items.Add("Default");
            this.Theme.Items.Add("Light");
            this.Theme.Items.Add("Dark");
            this.Theme.Location = new System.Drawing.Point(48, 16);
            this.Theme.Name = "Theme";
            this.Theme.Size = new System.Drawing.Size(120, 16);
            this.Theme.TabIndex = 1;
            this.Theme.Text = "Default";
            // 
            // ThemeLB
            // 
            this.ThemeLB.AutoSize = true;
            this.ThemeLB.Location = new System.Drawing.Point(7, 15);
            this.ThemeLB.Name = "ThemeLB";
            this.ThemeLB.Size = new System.Drawing.Size(40, 13);
            this.ThemeLB.TabIndex = 0;
            this.ThemeLB.Text = "Theme";
            // 
            // DataPage
            // 
            this.DataPage.Controls.Add(this.ClearDataBtn);
            this.DataPage.Controls.Add(this.ImportDataBtn);
            this.DataPage.Controls.Add(this.ExportDataBtn);
            this.DataPage.Location = new System.Drawing.Point(4, 22);
            this.DataPage.Name = "DataPage";
            this.DataPage.Padding = new System.Windows.Forms.Padding(3);
            this.DataPage.Size = new System.Drawing.Size(368, 206);
            this.DataPage.TabIndex = 2;
            this.DataPage.Text = "Data";
            this.DataPage.UseVisualStyleBackColor = true;
            // 
            // ImportDataBtn
            // 
            this.ImportDataBtn.Location = new System.Drawing.Point(8, 54);
            this.ImportDataBtn.Name = "ImportDataBtn";
            this.ImportDataBtn.Size = new System.Drawing.Size(75, 23);
            this.ImportDataBtn.TabIndex = 1;
            this.ImportDataBtn.Text = "Import Data";
            this.ImportDataBtn.UseVisualStyleBackColor = true;
            this.ImportDataBtn.Click += new System.EventHandler(this.ImportDataBtn_Click);
            // 
            // ExportDataBtn
            // 
            this.ExportDataBtn.Location = new System.Drawing.Point(8, 18);
            this.ExportDataBtn.Name = "ExportDataBtn";
            this.ExportDataBtn.Size = new System.Drawing.Size(75, 23);
            this.ExportDataBtn.TabIndex = 0;
            this.ExportDataBtn.Text = "Export Data";
            this.ExportDataBtn.UseVisualStyleBackColor = true;
            this.ExportDataBtn.Click += new System.EventHandler(this.ExportDataBtn_Click);
            // 
            // FAQ
            // 
            this.FAQ.Controls.Add(this.panel1);
            this.FAQ.Location = new System.Drawing.Point(4, 22);
            this.FAQ.Name = "FAQ";
            this.FAQ.Padding = new System.Windows.Forms.Padding(3);
            this.FAQ.Size = new System.Drawing.Size(368, 206);
            this.FAQ.TabIndex = 1;
            this.FAQ.Text = "FAQ";
            this.FAQ.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 204);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(365, 42);
            this.label5.TabIndex = 5;
            this.label5.Text = "Let\'s say you have 2 PC\'s, and you use KiLauncher on both....\r\nYou can use export" +
    " data on the PC that has the desired data, then import it on the outdated one.\r\n" +
    "";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(2, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(368, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Exporting data? What even is that?!";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(5, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yes! The code is available on my Github page! *Beware of my bad code! You\'ve been" +
    " warned*.";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Is the project open-source?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clearing the cache can be done by clicking on the clear button. If you only want " +
    "to delete a single image, make sure it\'s not being used by any button.";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "How do I clear the cache?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClearDataBtn
            // 
            this.ClearDataBtn.Location = new System.Drawing.Point(8, 90);
            this.ClearDataBtn.Name = "ClearDataBtn";
            this.ClearDataBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearDataBtn.TabIndex = 2;
            this.ClearDataBtn.Text = "Clear Data";
            this.ClearDataBtn.UseVisualStyleBackColor = true;
            this.ClearDataBtn.Click += new System.EventHandler(this.ClearDataBtn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 232);
            this.Controls.Add(this.SettingsPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.SettingsPage.ResumeLayout(false);
            this.AppSettings.ResumeLayout(false);
            this.AppSettings.PerformLayout();
            this.DataPage.ResumeLayout(false);
            this.FAQ.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl SettingsPage;
        private System.Windows.Forms.TabPage FAQ;
        private System.Windows.Forms.TabPage AppSettings;
        private System.Windows.Forms.Label ThemeLB;
        private System.Windows.Forms.DomainUpDown Theme;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage DataPage;
        private System.Windows.Forms.Button ExportDataBtn;
        private System.Windows.Forms.Button ImportDataBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ClearDataBtn;
    }
}