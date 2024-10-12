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
            this.sidebarMid = new System.Windows.Forms.Panel();
            this.sidebarTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlCardLayout = new System.Windows.Forms.Panel();
            this.sidebarBottom = new Sunny.UI.UIPanel();
            this.accountPnl = new Sunny.UI.UIPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.settingBtn = new Sunny.UI.UIButton();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.nameLb = new Sunny.UI.UILabel();
            this.roleLb = new Sunny.UI.UILabel();
            this.settingMenu = new Sunny.UI.UIContextMenuStrip();
            this.logOutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sidebar.SuspendLayout();
            this.sidebarTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidebarBottom.SuspendLayout();
            this.accountPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.settingMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.White;
            this.sidebar.Controls.Add(this.sidebarBottom);
            this.sidebar.Controls.Add(this.sidebarMid);
            this.sidebar.Controls.Add(this.sidebarTop);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.sidebar.Size = new System.Drawing.Size(245, 861);
            this.sidebar.TabIndex = 0;
            // 
            // sidebarMid
            // 
            this.sidebarMid.BackColor = System.Drawing.Color.White;
            this.sidebarMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebarMid.Location = new System.Drawing.Point(0, 149);
            this.sidebarMid.Name = "sidebarMid";
            this.sidebarMid.Padding = new System.Windows.Forms.Padding(5);
            this.sidebarMid.Size = new System.Drawing.Size(245, 702);
            this.sidebarMid.TabIndex = 1;
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
            this.pnlCardLayout.BackColor = System.Drawing.Color.Transparent;
            this.pnlCardLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardLayout.Location = new System.Drawing.Point(245, 0);
            this.pnlCardLayout.Name = "pnlCardLayout";
            this.pnlCardLayout.Size = new System.Drawing.Size(1339, 861);
            this.pnlCardLayout.TabIndex = 1;
            // 
            // sidebarBottom
            // 
            this.sidebarBottom.Controls.Add(this.accountPnl);
            this.sidebarBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidebarBottom.FillColor = System.Drawing.Color.White;
            this.sidebarBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sidebarBottom.Location = new System.Drawing.Point(0, 791);
            this.sidebarBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sidebarBottom.MinimumSize = new System.Drawing.Size(1, 1);
            this.sidebarBottom.Name = "sidebarBottom";
            this.sidebarBottom.Padding = new System.Windows.Forms.Padding(5);
            this.sidebarBottom.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.sidebarBottom.Size = new System.Drawing.Size(245, 60);
            this.sidebarBottom.TabIndex = 0;
            this.sidebarBottom.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountPnl
            // 
            this.accountPnl.Controls.Add(this.uiPanel1);
            this.accountPnl.Controls.Add(this.settingBtn);
            this.accountPnl.Controls.Add(this.pictureBox2);
            this.accountPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountPnl.FillColor = System.Drawing.Color.White;
            this.accountPnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.accountPnl.Location = new System.Drawing.Point(5, 5);
            this.accountPnl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accountPnl.MinimumSize = new System.Drawing.Size(1, 1);
            this.accountPnl.Name = "accountPnl";
            this.accountPnl.Padding = new System.Windows.Forms.Padding(8, 5, 15, 5);
            this.accountPnl.Radius = 10;
            this.accountPnl.RectColor = System.Drawing.SystemColors.ControlLight;
            this.accountPnl.RectSize = 2;
            this.accountPnl.Size = new System.Drawing.Size(235, 50);
            this.accountPnl.TabIndex = 0;
            this.accountPnl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::ZiTyLot.Properties.Resources.Icon_24x24px_Account_Active;
            this.pictureBox2.Location = new System.Drawing.Point(8, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // settingBtn
            // 
            this.settingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingBtn.FillColor = System.Drawing.Color.White;
            this.settingBtn.FillColor2 = System.Drawing.Color.White;
            this.settingBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.settingBtn.FillPressColor = System.Drawing.Color.White;
            this.settingBtn.FillSelectedColor = System.Drawing.Color.White;
            this.settingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.settingBtn.Location = new System.Drawing.Point(207, 5);
            this.settingBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.RectColor = System.Drawing.Color.White;
            this.settingBtn.RectHoverColor = System.Drawing.Color.White;
            this.settingBtn.RectPressColor = System.Drawing.Color.White;
            this.settingBtn.RectSelectedColor = System.Drawing.Color.White;
            this.settingBtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.settingBtn.Size = new System.Drawing.Size(13, 40);
            this.settingBtn.TabIndex = 5;
            this.settingBtn.Text = "⋮";
            this.settingBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.roleLb);
            this.uiPanel1.Controls.Add(this.nameLb);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.FillColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(48, 5);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uiPanel1.Radius = 0;
            this.uiPanel1.RectColor = System.Drawing.Color.White;
            this.uiPanel1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel1.Size = new System.Drawing.Size(159, 40);
            this.uiPanel1.TabIndex = 6;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLb
            // 
            this.nameLb.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.nameLb.Location = new System.Drawing.Point(5, 0);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(149, 23);
            this.nameLb.TabIndex = 0;
            this.nameLb.Text = "Admin";
            // 
            // roleLb
            // 
            this.roleLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roleLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.roleLb.Location = new System.Drawing.Point(5, 23);
            this.roleLb.Name = "roleLb";
            this.roleLb.Size = new System.Drawing.Size(149, 17);
            this.roleLb.TabIndex = 1;
            this.roleLb.Text = "Administrator";
            // 
            // settingMenu
            // 
            this.settingMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.settingMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.settingMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutMenuItem,
            this.changePasswordMenuItem});
            this.settingMenu.Name = "settingMenu";
            this.settingMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.settingMenu.ShowImageMargin = false;
            this.settingMenu.Size = new System.Drawing.Size(182, 74);
            // 
            // logOutMenuItem
            // 
            this.logOutMenuItem.BackColor = System.Drawing.Color.White;
            this.logOutMenuItem.Name = "logOutMenuItem";
            this.logOutMenuItem.Size = new System.Drawing.Size(181, 24);
            this.logOutMenuItem.Text = "Log out";
            // 
            // changePasswordMenuItem
            // 
            this.changePasswordMenuItem.BackColor = System.Drawing.Color.White;
            this.changePasswordMenuItem.Name = "changePasswordMenuItem";
            this.changePasswordMenuItem.Size = new System.Drawing.Size(181, 24);
            this.changePasswordMenuItem.Text = "Change password";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.pnlCardLayout);
            this.Controls.Add(this.sidebar);
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.sidebar.ResumeLayout(false);
            this.sidebarTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidebarBottom.ResumeLayout(false);
            this.accountPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.settingMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel sidebarTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel sidebarMid;
        private System.Windows.Forms.Panel pnlCardLayout;
        private Sunny.UI.UIPanel sidebarBottom;
        private Sunny.UI.UIPanel accountPnl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Sunny.UI.UIButton settingBtn;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel roleLb;
        private Sunny.UI.UILabel nameLb;
        private Sunny.UI.UIContextMenuStrip settingMenu;
        private System.Windows.Forms.ToolStripMenuItem logOutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordMenuItem;
    }
}