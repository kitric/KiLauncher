
namespace AppLauncher.UserControls.Pages
{
    partial class HomePage
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
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.crxssedBtn = new System.Windows.Forms.Button();
            this.NordicBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(105, 47);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(283, 56);
            this.Title.TabIndex = 0;
            this.Title.Text = "KiLauncher";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(236, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "\"A simple app launcher\"";
            // 
            // crxssedBtn
            // 
            this.crxssedBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.crxssedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.crxssedBtn.FlatAppearance.BorderSize = 0;
            this.crxssedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crxssedBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crxssedBtn.ForeColor = System.Drawing.Color.White;
            this.crxssedBtn.Image = global::AppLauncher.Properties.Resources.crxssed;
            this.crxssedBtn.Location = new System.Drawing.Point(466, 227);
            this.crxssedBtn.Name = "crxssedBtn";
            this.crxssedBtn.Size = new System.Drawing.Size(125, 161);
            this.crxssedBtn.TabIndex = 3;
            this.crxssedBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.crxssedBtn.UseVisualStyleBackColor = false;
            this.crxssedBtn.Click += new System.EventHandler(this.crxssedBtn_Click);
            // 
            // NordicBtn
            // 
            this.NordicBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NordicBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.NordicBtn.FlatAppearance.BorderSize = 0;
            this.NordicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NordicBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NordicBtn.ForeColor = System.Drawing.Color.White;
            this.NordicBtn.Image = global::AppLauncher.Properties.Resources.nordic;
            this.NordicBtn.Location = new System.Drawing.Point(12, 227);
            this.NordicBtn.Name = "NordicBtn";
            this.NordicBtn.Size = new System.Drawing.Size(125, 161);
            this.NordicBtn.TabIndex = 2;
            this.NordicBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NordicBtn.UseVisualStyleBackColor = false;
            this.NordicBtn.Click += new System.EventHandler(this.NordicBtn_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.crxssedBtn);
            this.Controls.Add(this.NordicBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(604, 535);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NordicBtn;
        private System.Windows.Forms.Button crxssedBtn;
    }
}
