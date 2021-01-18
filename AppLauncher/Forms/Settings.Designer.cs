
namespace AppLauncher
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.Save = new System.Windows.Forms.Button();
            this.Theme = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bar = new System.Windows.Forms.Panel();
            this.CloseSettings = new System.Windows.Forms.PictureBox();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.BackgroundPanel.SuspendLayout();
            this.bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.BackgroundPanel.Controls.Add(this.Save);
            this.BackgroundPanel.Controls.Add(this.Theme);
            this.BackgroundPanel.Controls.Add(this.label2);
            this.BackgroundPanel.Controls.Add(this.label1);
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 18);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(659, 437);
            this.BackgroundPanel.TabIndex = 0;
            // 
            // Save
            // 
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(0, 401);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(659, 32);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Theme
            // 
            this.Theme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Theme.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Theme.Items.Add("Default");
            this.Theme.Items.Add("Dark");
            this.Theme.Items.Add("Light");
            this.Theme.Location = new System.Drawing.Point(85, 95);
            this.Theme.Name = "Theme";
            this.Theme.Size = new System.Drawing.Size(120, 18);
            this.Theme.TabIndex = 2;
            this.Theme.Text = "Default";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Theme: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // bar
            // 
            this.bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.bar.Controls.Add(this.CloseSettings);
            this.bar.Controls.Add(this.MinimizeButton);
            this.bar.Location = new System.Drawing.Point(0, 0);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(659, 19);
            this.bar.TabIndex = 11;
            this.bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bar_MouseDown);
            this.bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bar_MouseMove);
            this.bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bar_MouseUp);
            // 
            // CloseSettings
            // 
            this.CloseSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CloseSettings.Image = global::AppLauncher.Properties.Resources.closeApp;
            this.CloseSettings.Location = new System.Drawing.Point(640, 2);
            this.CloseSettings.Name = "CloseSettings";
            this.CloseSettings.Size = new System.Drawing.Size(16, 16);
            this.CloseSettings.TabIndex = 2;
            this.CloseSettings.TabStop = false;
            this.CloseSettings.Click += new System.EventHandler(this.CloseSettings_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Image = global::AppLauncher.Properties.Resources.MinimizeButton;
            this.MinimizeButton.Location = new System.Drawing.Point(900, 2);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(25, 16);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 454);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.BackgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.ShowIcon = false;
            this.Text = "b";
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            this.bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseSettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown Theme;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Panel bar;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.PictureBox CloseSettings;
    }
}