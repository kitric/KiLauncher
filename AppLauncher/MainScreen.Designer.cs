namespace AppLauncher
{
    partial class MainScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.bar = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.Content = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.AppsLB = new System.Windows.Forms.Label();
            this.Sidebar = new System.Windows.Forms.Panel();
            this.HomeLB = new System.Windows.Forms.Label();
            this.SettingsLB = new System.Windows.Forms.Label();
            this.Animator = new System.Windows.Forms.Timer(this.components);
            this.bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.Sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar
            // 
            this.bar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.bar.Controls.Add(this.CloseButton);
            this.bar.Location = new System.Drawing.Point(-185, 0);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(1231, 19);
            this.bar.TabIndex = 10;
            this.bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bar_MouseDown);
            this.bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bar_MouseMove);
            this.bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bar_MouseUp);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CloseButton.Image = global::AppLauncher.Properties.Resources.closeApp;
            this.CloseButton.Location = new System.Drawing.Point(1212, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(16, 16);
            this.CloseButton.TabIndex = 13;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.Transparent;
            this.Content.Location = new System.Drawing.Point(151, 19);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(895, 547);
            this.Content.TabIndex = 11;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(3, 3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(129, 30);
            this.Title.TabIndex = 13;
            this.Title.Text = "KiLauncher";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppsLB
            // 
            this.AppsLB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppsLB.ForeColor = System.Drawing.Color.White;
            this.AppsLB.Location = new System.Drawing.Point(15, 104);
            this.AppsLB.Name = "AppsLB";
            this.AppsLB.Size = new System.Drawing.Size(117, 23);
            this.AppsLB.TabIndex = 14;
            this.AppsLB.Text = "Your Apps";
            this.AppsLB.Click += new System.EventHandler(this.AppsLB_Click);
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.Sidebar.Controls.Add(this.HomeLB);
            this.Sidebar.Controls.Add(this.SettingsLB);
            this.Sidebar.Controls.Add(this.Title);
            this.Sidebar.Controls.Add(this.AppsLB);
            this.Sidebar.Location = new System.Drawing.Point(0, 19);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(153, 547);
            this.Sidebar.TabIndex = 15;
            // 
            // HomeLB
            // 
            this.HomeLB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLB.ForeColor = System.Drawing.Color.White;
            this.HomeLB.Location = new System.Drawing.Point(15, 66);
            this.HomeLB.Name = "HomeLB";
            this.HomeLB.Size = new System.Drawing.Size(117, 23);
            this.HomeLB.TabIndex = 16;
            this.HomeLB.Text = "Home";
            this.HomeLB.Click += new System.EventHandler(this.HomeLB_Click);
            // 
            // SettingsLB
            // 
            this.SettingsLB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsLB.ForeColor = System.Drawing.Color.White;
            this.SettingsLB.Location = new System.Drawing.Point(15, 142);
            this.SettingsLB.Name = "SettingsLB";
            this.SettingsLB.Size = new System.Drawing.Size(117, 23);
            this.SettingsLB.TabIndex = 15;
            this.SettingsLB.Text = "Settings";
            this.SettingsLB.Click += new System.EventHandler(this.SettingsLB_Click);
            // 
            // Animator
            // 
            this.Animator.Interval = 10;
            this.Animator.Tick += new System.EventHandler(this.OpenAnimation);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1046, 566);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.Text = "KiLauncher";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.Shown += new System.EventHandler(this.MainScreen_Shown);
            this.bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.Sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bar;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Label Title;
        internal System.Windows.Forms.Panel Content;
        private System.Windows.Forms.Label AppsLB;
        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.Label SettingsLB;
        private System.Windows.Forms.Label HomeLB;
        private System.Windows.Forms.Timer Animator;
    }
}

