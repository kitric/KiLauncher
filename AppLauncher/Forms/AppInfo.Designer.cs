namespace AppLauncher
{
    partial class AppInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppInfo));
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.RemoveImage = new System.Windows.Forms.Button();
            this.ChangeColor = new System.Windows.Forms.Button();
            this.bar = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.PictureBox();
            this.DeleteProcess = new System.Windows.Forms.PictureBox();
            this.DisplayName = new System.Windows.Forms.TextBox();
            this.ChangeImagePath = new System.Windows.Forms.Button();
            this.ChangePath = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.BackgroundPanel.SuspendLayout();
            this.bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.BackgroundPanel.Controls.Add(this.RemoveImage);
            this.BackgroundPanel.Controls.Add(this.ChangeColor);
            this.BackgroundPanel.Controls.Add(this.bar);
            this.BackgroundPanel.Controls.Add(this.DeleteProcess);
            this.BackgroundPanel.Controls.Add(this.DisplayName);
            this.BackgroundPanel.Controls.Add(this.ChangeImagePath);
            this.BackgroundPanel.Controls.Add(this.ChangePath);
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(530, 229);
            this.BackgroundPanel.TabIndex = 0;
            // 
            // RemoveImage
            // 
            this.RemoveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveImage.FlatAppearance.BorderSize = 0;
            this.RemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveImage.ForeColor = System.Drawing.Color.White;
            this.RemoveImage.Location = new System.Drawing.Point(3, 149);
            this.RemoveImage.Name = "RemoveImage";
            this.RemoveImage.Size = new System.Drawing.Size(527, 29);
            this.RemoveImage.TabIndex = 15;
            this.RemoveImage.Text = "Remove Image";
            this.RemoveImage.UseVisualStyleBackColor = true;
            this.RemoveImage.Click += new System.EventHandler(this.RemoveImage_Click);
            // 
            // ChangeColor
            // 
            this.ChangeColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeColor.FlatAppearance.BorderSize = 0;
            this.ChangeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeColor.ForeColor = System.Drawing.Color.White;
            this.ChangeColor.Location = new System.Drawing.Point(3, 189);
            this.ChangeColor.Name = "ChangeColor";
            this.ChangeColor.Size = new System.Drawing.Size(527, 29);
            this.ChangeColor.TabIndex = 14;
            this.ChangeColor.Text = "Change display color";
            this.ChangeColor.UseVisualStyleBackColor = true;
            //this.ChangeColor.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // bar
            // 
            this.bar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.bar.Controls.Add(this.Close);
            this.bar.Location = new System.Drawing.Point(-82, 0);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(613, 27);
            this.bar.TabIndex = 11;
            this.bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bar_MouseDown);
            this.bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bar_MouseMove);
            this.bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bar_MouseUp);
            // 
            // Close
            // 
            this.Close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Close.Image = global::AppLauncher.Properties.Resources.closeApp;
            this.Close.Location = new System.Drawing.Point(592, 4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(16, 16);
            this.Close.TabIndex = 2;
            this.Close.TabStop = false;
            //this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // DeleteProcess
            // 
            this.DeleteProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteProcess.Image = ((System.Drawing.Image)(resources.GetObject("DeleteProcess.Image")));
            this.DeleteProcess.Location = new System.Drawing.Point(497, 29);
            this.DeleteProcess.Name = "DeleteProcess";
            this.DeleteProcess.Size = new System.Drawing.Size(32, 30);
            this.DeleteProcess.TabIndex = 3;
            this.DeleteProcess.TabStop = false;
            //this.DeleteProcess.Click += new System.EventHandler(this.DeleteProcess_Click);
            // 
            // DisplayName
            // 
            this.DisplayName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.DisplayName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DisplayName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayName.ForeColor = System.Drawing.Color.White;
            this.DisplayName.Location = new System.Drawing.Point(0, 32);
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.ReadOnly = true;
            this.DisplayName.Size = new System.Drawing.Size(530, 22);
            this.DisplayName.TabIndex = 10;
            this.DisplayName.Text = "text";
            this.DisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DisplayName.DoubleClick += new System.EventHandler(this.DisplayName_DoubleClick);
            //this.DisplayName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DisplayName_Enter_Pressed);
            // 
            // ChangeImagePath
            // 
            this.ChangeImagePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeImagePath.FlatAppearance.BorderSize = 0;
            this.ChangeImagePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeImagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeImagePath.ForeColor = System.Drawing.Color.White;
            this.ChangeImagePath.Location = new System.Drawing.Point(0, 109);
            this.ChangeImagePath.Name = "ChangeImagePath";
            this.ChangeImagePath.Size = new System.Drawing.Size(530, 29);
            this.ChangeImagePath.TabIndex = 7;
            this.ChangeImagePath.Text = "Change background image";
            this.ChangeImagePath.UseVisualStyleBackColor = true;
            //this.ChangeImagePath.Click += new System.EventHandler(this.ChangeImagePath_Click);
            // 
            // ChangePath
            // 
            this.ChangePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangePath.FlatAppearance.BorderSize = 0;
            this.ChangePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePath.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePath.ForeColor = System.Drawing.Color.White;
            this.ChangePath.Location = new System.Drawing.Point(1, 70);
            this.ChangePath.Name = "ChangePath";
            this.ChangePath.Size = new System.Drawing.Size(526, 28);
            this.ChangePath.TabIndex = 4;
            this.ChangePath.Text = "Change Target";
            this.ChangePath.UseVisualStyleBackColor = true;
            //this.ChangePath.Click += new System.EventHandler(this.ChangePath_Click);
            // 
            // AppInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 229);
            this.Controls.Add(this.BackgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppInfo";
            this.Text = "AppInfo";
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            this.bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.PictureBox DeleteProcess;
        private System.Windows.Forms.Button ChangePath;
        private System.Windows.Forms.Button ChangeImagePath;
        private System.Windows.Forms.TextBox DisplayName;
        private System.Windows.Forms.Panel bar;
        private System.Windows.Forms.Button ChangeColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button RemoveImage;
        private System.Windows.Forms.PictureBox Close;
    }
}