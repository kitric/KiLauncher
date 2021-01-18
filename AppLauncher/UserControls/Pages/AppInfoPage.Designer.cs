
namespace AppLauncher.UserControls.Pages
{
    partial class AppInfoPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DisplayName = new System.Windows.Forms.TextBox();
            this.ChangePath = new System.Windows.Forms.Button();
            this.ChangeImagePath = new System.Windows.Forms.Button();
            this.RemoveImage = new System.Windows.Forms.Button();
            this.ChangeColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.DeleteApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayName
            // 
            this.DisplayName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.DisplayName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DisplayName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayName.ForeColor = System.Drawing.Color.White;
            this.DisplayName.Location = new System.Drawing.Point(0, 13);
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.ReadOnly = true;
            this.DisplayName.Size = new System.Drawing.Size(895, 20);
            this.DisplayName.TabIndex = 11;
            this.DisplayName.Text = "text";
            this.DisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DisplayName.DoubleClick += new System.EventHandler(this.DisplayName_DoubleClick);
            this.DisplayName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DisplayName_Enter_Pressed);
            // 
            // ChangePath
            // 
            this.ChangePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.ChangePath.FlatAppearance.BorderSize = 0;
            this.ChangePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePath.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePath.ForeColor = System.Drawing.Color.White;
            this.ChangePath.Location = new System.Drawing.Point(182, 135);
            this.ChangePath.Name = "ChangePath";
            this.ChangePath.Size = new System.Drawing.Size(526, 28);
            this.ChangePath.TabIndex = 12;
            this.ChangePath.Text = "Change Target";
            this.ChangePath.UseVisualStyleBackColor = false;
            this.ChangePath.Click += new System.EventHandler(this.ChangePath_Click);
            // 
            // ChangeImagePath
            // 
            this.ChangeImagePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeImagePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.ChangeImagePath.FlatAppearance.BorderSize = 0;
            this.ChangeImagePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeImagePath.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeImagePath.ForeColor = System.Drawing.Color.White;
            this.ChangeImagePath.Location = new System.Drawing.Point(182, 183);
            this.ChangeImagePath.Name = "ChangeImagePath";
            this.ChangeImagePath.Size = new System.Drawing.Size(530, 29);
            this.ChangeImagePath.TabIndex = 13;
            this.ChangeImagePath.Text = "Change background image";
            this.ChangeImagePath.UseVisualStyleBackColor = false;
            this.ChangeImagePath.Click += new System.EventHandler(this.ChangeImagePath_Click);
            // 
            // RemoveImage
            // 
            this.RemoveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.RemoveImage.FlatAppearance.BorderSize = 0;
            this.RemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveImage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveImage.ForeColor = System.Drawing.Color.White;
            this.RemoveImage.Location = new System.Drawing.Point(185, 232);
            this.RemoveImage.Name = "RemoveImage";
            this.RemoveImage.Size = new System.Drawing.Size(527, 29);
            this.RemoveImage.TabIndex = 16;
            this.RemoveImage.Text = "Remove Image";
            this.RemoveImage.UseVisualStyleBackColor = false;
            this.RemoveImage.Click += new System.EventHandler(this.RemoveImage_Click);
            // 
            // ChangeColor
            // 
            this.ChangeColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.ChangeColor.FlatAppearance.BorderSize = 0;
            this.ChangeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeColor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeColor.ForeColor = System.Drawing.Color.White;
            this.ChangeColor.Location = new System.Drawing.Point(185, 281);
            this.ChangeColor.Name = "ChangeColor";
            this.ChangeColor.Size = new System.Drawing.Size(527, 29);
            this.ChangeColor.TabIndex = 17;
            this.ChangeColor.Text = "Change display color";
            this.ChangeColor.UseVisualStyleBackColor = false;
            this.ChangeColor.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // DeleteApp
            // 
            this.DeleteApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.DeleteApp.FlatAppearance.BorderSize = 0;
            this.DeleteApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteApp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DeleteApp.Location = new System.Drawing.Point(185, 330);
            this.DeleteApp.Name = "DeleteApp";
            this.DeleteApp.Size = new System.Drawing.Size(527, 29);
            this.DeleteApp.TabIndex = 18;
            this.DeleteApp.Text = "Delete ";
            this.DeleteApp.UseVisualStyleBackColor = false;
            this.DeleteApp.Click += new System.EventHandler(this.DeleteApp_Click);
            // 
            // AppInfoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.DeleteApp);
            this.Controls.Add(this.ChangeColor);
            this.Controls.Add(this.RemoveImage);
            this.Controls.Add(this.ChangeImagePath);
            this.Controls.Add(this.ChangePath);
            this.Controls.Add(this.DisplayName);
            this.Name = "AppInfoPage";
            this.Size = new System.Drawing.Size(895, 494);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DisplayName;
        private System.Windows.Forms.Button ChangePath;
        private System.Windows.Forms.Button ChangeImagePath;
        private System.Windows.Forms.Button RemoveImage;
        private System.Windows.Forms.Button ChangeColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button DeleteApp;
    }
}
