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
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.sidebar = new System.Windows.Forms.Panel();
            this.sidebarBottom = new Sunny.UI.UIPanel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.tableSetting = new Sunny.UI.UITableLayoutPanel();
            this.lbName = new Sunny.UI.UILabel();
            this.btnMore = new Sunny.UI.UISymbolButton();
            this.lbSymbol = new Sunny.UI.UISymbolLabel();
            this.sidebarMid = new System.Windows.Forms.Panel();
            this.sidebarTop = new Sunny.UI.UIPanel();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlCardLayout = new System.Windows.Forms.Panel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btnToggle = new Sunny.UI.UISymbolButton();
            this.menuInfo = new ZiTyLot.GUI.CustomContextMenuStrip();
            this.sidebar.SuspendLayout();
            this.sidebarBottom.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.tableSetting.SuspendLayout();
            this.sidebarTop.SuspendLayout();
            this.uiPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.White;
            this.sidebar.Controls.Add(this.sidebarBottom);
            this.sidebar.Controls.Add(this.sidebarMid);
            this.sidebar.Controls.Add(this.sidebarTop);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(15, 15);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(245, 699);
            this.sidebar.TabIndex = 0;
            // 
            // sidebarBottom
            // 
            this.sidebarBottom.Controls.Add(this.uiPanel2);
            this.sidebarBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidebarBottom.FillColor = System.Drawing.Color.White;
            this.sidebarBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sidebarBottom.Location = new System.Drawing.Point(0, 639);
            this.sidebarBottom.Margin = new System.Windows.Forms.Padding(4);
            this.sidebarBottom.MinimumSize = new System.Drawing.Size(1, 1);
            this.sidebarBottom.Name = "sidebarBottom";
            this.sidebarBottom.Padding = new System.Windows.Forms.Padding(20, 0, 20, 10);
            this.sidebarBottom.RectColor = System.Drawing.Color.White;
            this.sidebarBottom.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.sidebarBottom.Size = new System.Drawing.Size(245, 60);
            this.sidebarBottom.TabIndex = 0;
            this.sidebarBottom.Text = null;
            this.sidebarBottom.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.tableSetting);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.FillColor = System.Drawing.Color.White;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(20, 0);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.uiPanel2.Radius = 0;
            this.uiPanel2.RectColor = System.Drawing.SystemColors.ControlLight;
            this.uiPanel2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top;
            this.uiPanel2.RectSize = 2;
            this.uiPanel2.Size = new System.Drawing.Size(205, 50);
            this.uiPanel2.TabIndex = 0;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableSetting
            // 
            this.tableSetting.ColumnCount = 3;
            this.tableSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSetting.Controls.Add(this.lbName, 1, 0);
            this.tableSetting.Controls.Add(this.btnMore, 2, 0);
            this.tableSetting.Controls.Add(this.lbSymbol, 0, 0);
            this.tableSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSetting.Location = new System.Drawing.Point(0, 10);
            this.tableSetting.Name = "tableSetting";
            this.tableSetting.RowCount = 1;
            this.tableSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSetting.Size = new System.Drawing.Size(205, 40);
            this.tableSetting.TabIndex = 0;
            this.tableSetting.TagString = null;
            // 
            // lbName
            // 
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbName.Location = new System.Drawing.Point(43, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(119, 40);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Administrator";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMore
            // 
            this.btnMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMore.FillColor = System.Drawing.Color.White;
            this.btnMore.FillHoverColor = System.Drawing.Color.White;
            this.btnMore.FillPressColor = System.Drawing.Color.White;
            this.btnMore.FillSelectedColor = System.Drawing.Color.White;
            this.btnMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMore.Location = new System.Drawing.Point(168, 3);
            this.btnMore.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMore.Name = "btnMore";
            this.btnMore.Radius = 0;
            this.btnMore.RectColor = System.Drawing.SystemColors.ControlLight;
            this.btnMore.RectHoverColor = System.Drawing.SystemColors.ControlLight;
            this.btnMore.RectPressColor = System.Drawing.SystemColors.ControlLight;
            this.btnMore.RectSelectedColor = System.Drawing.SystemColors.ControlLight;
            this.btnMore.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnMore.RectSize = 2;
            this.btnMore.Size = new System.Drawing.Size(34, 34);
            this.btnMore.Symbol = 61459;
            this.btnMore.SymbolColor = System.Drawing.SystemColors.ControlDark;
            this.btnMore.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnMore.SymbolOffset = new System.Drawing.Point(0, 1);
            this.btnMore.SymbolPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnMore.SymbolSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnMore.TabIndex = 2;
            this.btnMore.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // lbSymbol
            // 
            this.lbSymbol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbSymbol.Location = new System.Drawing.Point(3, 3);
            this.lbSymbol.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbSymbol.Name = "lbSymbol";
            this.lbSymbol.Size = new System.Drawing.Size(34, 34);
            this.lbSymbol.Symbol = 559389;
            this.lbSymbol.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.lbSymbol.SymbolSize = 32;
            this.lbSymbol.TabIndex = 3;
            // 
            // sidebarMid
            // 
            this.sidebarMid.BackColor = System.Drawing.Color.White;
            this.sidebarMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebarMid.Location = new System.Drawing.Point(0, 120);
            this.sidebarMid.Name = "sidebarMid";
            this.sidebarMid.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.sidebarMid.Size = new System.Drawing.Size(245, 579);
            this.sidebarMid.TabIndex = 1;
            // 
            // sidebarTop
            // 
            this.sidebarTop.Controls.Add(this.uiPanel3);
            this.sidebarTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidebarTop.FillColor = System.Drawing.Color.White;
            this.sidebarTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sidebarTop.Location = new System.Drawing.Point(0, 0);
            this.sidebarTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sidebarTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.sidebarTop.Name = "sidebarTop";
            this.sidebarTop.Padding = new System.Windows.Forms.Padding(20, 10, 20, 0);
            this.sidebarTop.Radius = 0;
            this.sidebarTop.RectColor = System.Drawing.SystemColors.ControlLight;
            this.sidebarTop.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.sidebarTop.RectSize = 2;
            this.sidebarTop.Size = new System.Drawing.Size(245, 120);
            this.sidebarTop.TabIndex = 0;
            this.sidebarTop.Text = null;
            this.sidebarTop.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel3
            // 
            this.uiPanel3.Controls.Add(this.pictureBox1);
            this.uiPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel3.FillColor = System.Drawing.Color.White;
            this.uiPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel3.Location = new System.Drawing.Point(20, 10);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.uiPanel3.Radius = 0;
            this.uiPanel3.RectColor = System.Drawing.SystemColors.ControlLight;
            this.uiPanel3.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiPanel3.RectSize = 2;
            this.uiPanel3.Size = new System.Drawing.Size(205, 110);
            this.uiPanel3.TabIndex = 0;
            this.uiPanel3.Text = null;
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ZiTyLot.Properties.Resources.Zity_logo_256x256px;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pnlCardLayout
            // 
            this.pnlCardLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pnlCardLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardLayout.Location = new System.Drawing.Point(260, 15);
            this.pnlCardLayout.Name = "pnlCardLayout";
            this.pnlCardLayout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.pnlCardLayout.Size = new System.Drawing.Size(1075, 699);
            this.pnlCardLayout.TabIndex = 1;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.btnToggle);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(260, 15);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel1.Size = new System.Drawing.Size(15, 699);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnToggle
            // 
            this.btnToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnToggle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.btnToggle.FillHoverColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnToggle.FillPressColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnToggle.FillSelectedColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnToggle.Location = new System.Drawing.Point(0, 0);
            this.btnToggle.Margin = new System.Windows.Forms.Padding(0);
            this.btnToggle.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Radius = 0;
            this.btnToggle.RectColor = System.Drawing.Color.White;
            this.btnToggle.RectHoverColor = System.Drawing.Color.White;
            this.btnToggle.RectPressColor = System.Drawing.Color.White;
            this.btnToggle.RectSelectedColor = System.Drawing.Color.White;
            this.btnToggle.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnToggle.RectSize = 2;
            this.btnToggle.Size = new System.Drawing.Size(15, 699);
            this.btnToggle.Symbol = 558848;
            this.btnToggle.SymbolColor = System.Drawing.SystemColors.ControlDark;
            this.btnToggle.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnToggle.SymbolOffset = new System.Drawing.Point(4, 0);
            this.btnToggle.SymbolPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnToggle.SymbolSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnToggle.SymbolSize = 20;
            this.btnToggle.TabIndex = 1;
            this.btnToggle.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnToggle.Click += new System.EventHandler(this.btnToggleMenu_Click);
            // 
            // menuInfo
            // 
            this.menuInfo.AutoSize = true;
            this.menuInfo.BackColor = System.Drawing.Color.White;
            this.menuInfo.Location = new System.Drawing.Point(0, 0);
            this.menuInfo.MaximumSize = new System.Drawing.Size(240, 500);
            this.menuInfo.Name = "menuInfo";
            this.menuInfo.Size = new System.Drawing.Size(240, 104);
            this.menuInfo.TabIndex = 0;
            this.menuInfo.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.menuInfo);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.pnlCardLayout);
            this.Controls.Add(this.sidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "Zitylot";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResizeEnd += new System.EventHandler(this.Home_ResizeEnd);
            this.Resize += new System.EventHandler(this.Home_Resize);
            this.sidebar.ResumeLayout(false);
            this.sidebarBottom.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.tableSetting.ResumeLayout(false);
            this.sidebarTop.ResumeLayout(false);
            this.uiPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel sidebarMid;
        private System.Windows.Forms.Panel pnlCardLayout;
        private Sunny.UI.UIPanel sidebarTop;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UISymbolButton btnToggle;
        private Sunny.UI.UIPanel sidebarBottom;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIPanel uiPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UITableLayoutPanel tableSetting;
        private Sunny.UI.UILabel lbName;
        private Sunny.UI.UISymbolButton btnMore;
        private Sunny.UI.UISymbolLabel lbSymbol;
        private CustomContextMenuStrip menuInfo;
    }
}