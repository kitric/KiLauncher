
namespace AppLauncher.UserControls.Pages
{
    partial class AppPage
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
            this.SortModeLabel = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.CreateApp = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.Grid = new System.Windows.Forms.FlowLayoutPanel();
            this.sortDown_Arrow = new System.Windows.Forms.PictureBox();
            this.SortUp_Arrow = new System.Windows.Forms.PictureBox();
            this.Grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortDown_Arrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SortUp_Arrow)).BeginInit();
            this.SuspendLayout();
            // 
            // SortModeLabel
            // 
            this.SortModeLabel.AutoSize = true;
            this.SortModeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortModeLabel.ForeColor = System.Drawing.Color.White;
            this.SortModeLabel.Location = new System.Drawing.Point(9, 92);
            this.SortModeLabel.Name = "SortModeLabel";
            this.SortModeLabel.Size = new System.Drawing.Size(69, 16);
            this.SortModeLabel.TabIndex = 15;
            this.SortModeLabel.Text = "SortMode";
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(140, 5);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(122, 28);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // CreateApp
            // 
            this.CreateApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.CreateApp.FlatAppearance.BorderSize = 0;
            this.CreateApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateApp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateApp.ForeColor = System.Drawing.Color.White;
            this.CreateApp.Location = new System.Drawing.Point(12, 5);
            this.CreateApp.Name = "CreateApp";
            this.CreateApp.Size = new System.Drawing.Size(122, 28);
            this.CreateApp.TabIndex = 13;
            this.CreateApp.Text = "+ New App";
            this.CreateApp.UseVisualStyleBackColor = false;
            this.CreateApp.Click += new System.EventHandler(this.CreateApp_Click);
            // 
            // Label
            // 
            this.Label.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.Color.White;
            this.Label.Location = new System.Drawing.Point(3, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(798, 423);
            this.Label.TabIndex = 0;
            this.Label.Text = "So empty...";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchBar
            // 
            this.SearchBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.SearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBar.ForeColor = System.Drawing.Color.DarkGray;
            this.SearchBar.Location = new System.Drawing.Point(689, 11);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(200, 16);
            this.SearchBar.TabIndex = 19;
            this.SearchBar.Tag = "";
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // Grid
            // 
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid.AutoScroll = true;
            this.Grid.Controls.Add(this.Label);
            this.Grid.Location = new System.Drawing.Point(88, 58);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(804, 436);
            this.Grid.TabIndex = 12;
            // 
            // sortDown_Arrow
            // 
            this.sortDown_Arrow.Image = global::AppLauncher.Properties.Resources.arrowDown;
            this.sortDown_Arrow.Location = new System.Drawing.Point(34, 114);
            this.sortDown_Arrow.Name = "sortDown_Arrow";
            this.sortDown_Arrow.Size = new System.Drawing.Size(27, 30);
            this.sortDown_Arrow.TabIndex = 20;
            this.sortDown_Arrow.TabStop = false;
            this.sortDown_Arrow.Click += new System.EventHandler(this.SortDownArrow_Click);
            // 
            // SortUp_Arrow
            // 
            this.SortUp_Arrow.Image = global::AppLauncher.Properties.Resources.arrowUp;
            this.SortUp_Arrow.Location = new System.Drawing.Point(34, 64);
            this.SortUp_Arrow.Name = "SortUp_Arrow";
            this.SortUp_Arrow.Size = new System.Drawing.Size(27, 30);
            this.SortUp_Arrow.TabIndex = 17;
            this.SortUp_Arrow.TabStop = false;
            this.SortUp_Arrow.Click += new System.EventHandler(this.SortUpArrow_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.sortDown_Arrow);
            this.Controls.Add(this.SortUp_Arrow);
            this.Controls.Add(this.SortModeLabel);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.CreateApp);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.Grid);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(895, 494);
            this.Grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sortDown_Arrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SortUp_Arrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox SortUp_Arrow;
        private System.Windows.Forms.Label SortModeLabel;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button CreateApp;
        internal System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox SearchBar;
        public System.Windows.Forms.FlowLayoutPanel Grid;
        private System.Windows.Forms.PictureBox sortDown_Arrow;
    }
}
