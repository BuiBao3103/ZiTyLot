namespace ZiTyLot.GUI
{
    partial class Home
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
            this.sidebar = new System.Windows.Forms.Panel();
            this.sidebarBottom = new System.Windows.Forms.Panel();
            this.sidebarTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlCardLayout = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.sidebarTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.Controls.Add(this.sidebarBottom);
            this.sidebar.Controls.Add(this.sidebarTop);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(245, 633);
            this.sidebar.TabIndex = 0;
            // 
            // sidebarBottom
            // 
            this.sidebarBottom.BackColor = System.Drawing.Color.White;
            this.sidebarBottom.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarBottom.Location = new System.Drawing.Point(0, 149);
            this.sidebarBottom.Name = "sidebarBottom";
            this.sidebarBottom.Padding = new System.Windows.Forms.Padding(5);
            this.sidebarBottom.Size = new System.Drawing.Size(245, 484);
            this.sidebarBottom.TabIndex = 1;
            // 
            // sidebarTop
            // 
            this.sidebarTop.BackColor = System.Drawing.Color.White;
            this.sidebarTop.Controls.Add(this.pictureBox1);
            this.sidebarTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidebarTop.Location = new System.Drawing.Point(0, 0);
            this.sidebarTop.Name = "sidebarTop";
            this.sidebarTop.Padding = new System.Windows.Forms.Padding(20);
            this.sidebarTop.Size = new System.Drawing.Size(245, 149);
            this.sidebarTop.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ZiTyLot.Properties.Resources.ZityLot_Logo_120x60px;
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlCardLayout
            // 
            this.pnlCardLayout.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlCardLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardLayout.Location = new System.Drawing.Point(245, 0);
            this.pnlCardLayout.Name = "pnlCardLayout";
            this.pnlCardLayout.Size = new System.Drawing.Size(854, 633);
            this.pnlCardLayout.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 633);
            this.Controls.Add(this.pnlCardLayout);
            this.Controls.Add(this.sidebar);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.sidebar.ResumeLayout(false);
            this.sidebarTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel sidebarTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel sidebarBottom;
        private System.Windows.Forms.Panel pnlCardLayout;
    }
}