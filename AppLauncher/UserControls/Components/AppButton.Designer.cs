
namespace AppLauncher.UserControls.Components
{
    partial class AppButton
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
            this.BackgroundImage = new System.Windows.Forms.PictureBox();
            this.DisplayName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImage)).BeginInit();
            this.SuspendLayout();
            // 
            // BackgroundImage
            // 
            this.BackgroundImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(80)))));
            this.BackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.BackgroundImage.Name = "BackgroundImage";
            this.BackgroundImage.Size = new System.Drawing.Size(256, 144);
            this.BackgroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BackgroundImage.TabIndex = 0;
            this.BackgroundImage.TabStop = false;
            // 
            // DisplayName
            // 
            this.DisplayName.BackColor = System.Drawing.Color.Transparent;
            this.DisplayName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayName.ForeColor = System.Drawing.Color.White;
            this.DisplayName.Location = new System.Drawing.Point(0, 0);
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.Size = new System.Drawing.Size(256, 144);
            this.DisplayName.TabIndex = 0;
            this.DisplayName.Text = "label1";
            this.DisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DisplayName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DisplayName_MouseDown);
            // 
            // AppButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.DisplayName);
            this.Controls.Add(this.BackgroundImage);
            this.Name = "AppButton";
            this.Size = new System.Drawing.Size(256, 144);
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Label DisplayName;
        internal System.Windows.Forms.PictureBox BackgroundImage;
    }
}
