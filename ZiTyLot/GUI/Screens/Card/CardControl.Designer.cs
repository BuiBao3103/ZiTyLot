using System.Windows.Forms;

namespace ZiTyLot.GUI.Screens
{
    partial class CardControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.pnlSearch = new Sunny.UI.UIPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbSearch = new Sunny.UI.UITextBox();
            this.filterPnl = new Sunny.UI.UIPanel();
            this.cbFilter = new Sunny.UI.UIComboBox();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnMore = new Sunny.UI.UIButton();
            this.btnAdd = new Sunny.UI.UISymbolButton();
            this.pnlTabpane = new System.Windows.Forms.Panel();
            this.btnLost = new System.Windows.Forms.RadioButton();
            this.btnLocked = new System.Windows.Forms.RadioButton();
            this.btnEmpty = new System.Windows.Forms.RadioButton();
            this.btnActive = new System.Windows.Forms.RadioButton();
            this.btnAll = new System.Windows.Forms.RadioButton();
            this.separator = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlPagination = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.cbNumberofitem = new Sunny.UI.UIComboBox();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlNext = new System.Windows.Forms.Panel();
            this.btnNext = new Sunny.UI.UISymbolButton();
            this.pnlCurrentPage = new System.Windows.Forms.Panel();
            this.lbTotalpage = new System.Windows.Forms.Label();
            this.tbCurrentpage = new Sunny.UI.UITextBox();
            this.pnlPrevious = new System.Windows.Forms.Panel();
            this.btnPrevious = new Sunny.UI.UISymbolButton();
            this.tableCard = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRfid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menuMore = new Sunny.UI.UIContextMenuStrip();
            this.menuItemImport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTop.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.filterPnl.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.pnlTabpane.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlPagination.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlNext.SuspendLayout();
            this.pnlCurrentPage.SuspendLayout();
            this.pnlPrevious.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableCard)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuMore.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.uiPanel1);
            this.pnlTop.Controls.Add(this.pnlTabpane);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTop.Size = new System.Drawing.Size(1093, 54);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.Resize += new System.EventHandler(this.TopPnl_Resize);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.pnlSearch);
            this.uiPanel1.Controls.Add(this.filterPnl);
            this.uiPanel1.Controls.Add(this.pnlButton);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiPanel1.FillColor = System.Drawing.Color.White;
            this.uiPanel1.FillColor2 = System.Drawing.Color.White;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(538, 10);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.White;
            this.uiPanel1.Size = new System.Drawing.Size(545, 34);
            this.uiPanel1.TabIndex = 10;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.pictureBox2);
            this.pnlSearch.Controls.Add(this.tbSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(5);
            this.pnlSearch.Radius = 10;
            this.pnlSearch.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.pnlSearch.RectSize = 2;
            this.pnlSearch.Size = new System.Drawing.Size(250, 34);
            this.pnlSearch.TabIndex = 1;
            this.pnlSearch.Text = null;
            this.pnlSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Magnifying;
            this.pictureBox2.Location = new System.Drawing.Point(217, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.tbSearch.IconSize = 18;
            this.tbSearch.Location = new System.Drawing.Point(5, 5);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tbSearch.MaximumSize = new System.Drawing.Size(350, 26);
            this.tbSearch.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tbSearch.Radius = 14;
            this.tbSearch.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.tbSearch.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.tbSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbSearch.ShowText = false;
            this.tbSearch.Size = new System.Drawing.Size(218, 24);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbSearch.Watermark = "";
            // 
            // filterPnl
            // 
            this.filterPnl.Controls.Add(this.cbFilter);
            this.filterPnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.filterPnl.FillColor = System.Drawing.Color.White;
            this.filterPnl.FillColor2 = System.Drawing.Color.White;
            this.filterPnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterPnl.Location = new System.Drawing.Point(260, 0);
            this.filterPnl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filterPnl.MinimumSize = new System.Drawing.Size(1, 1);
            this.filterPnl.Name = "filterPnl";
            this.filterPnl.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.filterPnl.Radius = 10;
            this.filterPnl.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.filterPnl.RectDisableColor = System.Drawing.Color.White;
            this.filterPnl.RectSize = 2;
            this.filterPnl.Size = new System.Drawing.Size(120, 34);
            this.filterPnl.TabIndex = 1;
            this.filterPnl.Text = null;
            this.filterPnl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbFilter
            // 
            this.cbFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFilter.DataSource = null;
            this.cbFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbFilter.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbFilter.DropDownWidth = 100;
            this.cbFilter.FillColor = System.Drawing.Color.White;
            this.cbFilter.FillColor2 = System.Drawing.Color.White;
            this.cbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.cbFilter.ItemHeight = 24;
            this.cbFilter.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            this.cbFilter.ItemRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.cbFilter.Items.AddRange(new object[] {
            "All",
            "Hello",
            "Hi"});
            this.cbFilter.ItemSelectBackColor = System.Drawing.Color.White;
            this.cbFilter.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.cbFilter.Location = new System.Drawing.Point(10, 0);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(0);
            this.cbFilter.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Padding = new System.Windows.Forms.Padding(4, 0, 30, 2);
            this.cbFilter.Radius = 0;
            this.cbFilter.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.cbFilter.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.cbFilter.RectSize = 2;
            this.cbFilter.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.cbFilter.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.cbFilter.ScrollBarStyleInherited = false;
            this.cbFilter.Size = new System.Drawing.Size(100, 34);
            this.cbFilter.Style = Sunny.UI.UIStyle.Custom;
            this.cbFilter.SymbolDropDown = 560247;
            this.cbFilter.SymbolNormal = 557682;
            this.cbFilter.SymbolSize = 24;
            this.cbFilter.TabIndex = 1;
            this.cbFilter.Text = "Filter";
            this.cbFilter.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbFilter.Watermark = "";
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnMore);
            this.pnlButton.Controls.Add(this.btnAdd);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlButton.Location = new System.Drawing.Point(380, 0);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlButton.Size = new System.Drawing.Size(165, 34);
            this.pnlButton.TabIndex = 7;
            // 
            // btnMore
            // 
            this.btnMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMore.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMore.FillColor = System.Drawing.Color.White;
            this.btnMore.FillColor2 = System.Drawing.Color.White;
            this.btnMore.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnMore.FillPressColor = System.Drawing.Color.White;
            this.btnMore.FillSelectedColor = System.Drawing.Color.White;
            this.btnMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnMore.Location = new System.Drawing.Point(131, 0);
            this.btnMore.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMore.Name = "btnMore";
            this.btnMore.RectColor = System.Drawing.Color.White;
            this.btnMore.RectHoverColor = System.Drawing.Color.White;
            this.btnMore.RectPressColor = System.Drawing.Color.White;
            this.btnMore.RectSelectedColor = System.Drawing.Color.White;
            this.btnMore.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnMore.Size = new System.Drawing.Size(34, 34);
            this.btnMore.TabIndex = 4;
            this.btnMore.Text = "⋮";
            this.btnMore.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnMore.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnAdd.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(91)))), ((int)(((byte)(17)))));
            this.btnAdd.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Plus;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(10, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(8, 0, 6, 0);
            this.btnAdd.Radius = 10;
            this.btnAdd.RectColor = System.Drawing.Color.White;
            this.btnAdd.RectDisableColor = System.Drawing.Color.White;
            this.btnAdd.RectHoverColor = System.Drawing.Color.White;
            this.btnAdd.RectPressColor = System.Drawing.Color.White;
            this.btnAdd.RectSelectedColor = System.Drawing.Color.White;
            this.btnAdd.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnAdd.RectSize = 2;
            this.btnAdd.Size = new System.Drawing.Size(120, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "New card";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pnlTabpane
            // 
            this.pnlTabpane.Controls.Add(this.btnLost);
            this.pnlTabpane.Controls.Add(this.btnLocked);
            this.pnlTabpane.Controls.Add(this.btnEmpty);
            this.pnlTabpane.Controls.Add(this.btnActive);
            this.pnlTabpane.Controls.Add(this.btnAll);
            this.pnlTabpane.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTabpane.Location = new System.Drawing.Point(10, 10);
            this.pnlTabpane.Name = "pnlTabpane";
            this.pnlTabpane.Size = new System.Drawing.Size(560, 34);
            this.pnlTabpane.TabIndex = 8;
            // 
            // btnLost
            // 
            this.btnLost.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnLost.AutoSize = true;
            this.btnLost.BackColor = System.Drawing.Color.White;
            this.btnLost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLost.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLost.FlatAppearance.BorderSize = 0;
            this.btnLost.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnLost.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnLost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnLost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLost.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnLost.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Lost;
            this.btnLost.Location = new System.Drawing.Point(440, 0);
            this.btnLost.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLost.MinimumSize = new System.Drawing.Size(110, 34);
            this.btnLost.Name = "btnLost";
            this.btnLost.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLost.Size = new System.Drawing.Size(110, 34);
            this.btnLost.TabIndex = 6;
            this.btnLost.Text = "Lost";
            this.btnLost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLost.UseVisualStyleBackColor = false;
            this.btnLost.CheckedChanged += new System.EventHandler(this.lostFilter_CheckedChanged);
            // 
            // btnLocked
            // 
            this.btnLocked.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnLocked.AutoSize = true;
            this.btnLocked.BackColor = System.Drawing.Color.White;
            this.btnLocked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocked.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLocked.FlatAppearance.BorderSize = 0;
            this.btnLocked.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnLocked.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnLocked.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnLocked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocked.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnLocked.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Lock;
            this.btnLocked.Location = new System.Drawing.Point(330, 0);
            this.btnLocked.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLocked.MinimumSize = new System.Drawing.Size(110, 34);
            this.btnLocked.Name = "btnLocked";
            this.btnLocked.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLocked.Size = new System.Drawing.Size(110, 34);
            this.btnLocked.TabIndex = 7;
            this.btnLocked.Text = "Locked";
            this.btnLocked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLocked.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLocked.UseVisualStyleBackColor = false;
            this.btnLocked.CheckedChanged += new System.EventHandler(this.lockedFilter_CheckedChanged);
            // 
            // btnEmpty
            // 
            this.btnEmpty.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnEmpty.AutoSize = true;
            this.btnEmpty.BackColor = System.Drawing.Color.White;
            this.btnEmpty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpty.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEmpty.FlatAppearance.BorderSize = 0;
            this.btnEmpty.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnEmpty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnEmpty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnEmpty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpty.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnEmpty.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Empty;
            this.btnEmpty.Location = new System.Drawing.Point(220, 0);
            this.btnEmpty.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmpty.MinimumSize = new System.Drawing.Size(110, 34);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmpty.Size = new System.Drawing.Size(110, 34);
            this.btnEmpty.TabIndex = 5;
            this.btnEmpty.Text = "Empty";
            this.btnEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmpty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpty.UseVisualStyleBackColor = false;
            this.btnEmpty.CheckedChanged += new System.EventHandler(this.emptyFilter_CheckedChanged);
            // 
            // btnActive
            // 
            this.btnActive.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnActive.AutoSize = true;
            this.btnActive.BackColor = System.Drawing.Color.White;
            this.btnActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActive.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnActive.FlatAppearance.BorderSize = 0;
            this.btnActive.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnActive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnActive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActive.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnActive.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Active;
            this.btnActive.Location = new System.Drawing.Point(110, 0);
            this.btnActive.Margin = new System.Windows.Forms.Padding(0);
            this.btnActive.MinimumSize = new System.Drawing.Size(110, 34);
            this.btnActive.Name = "btnActive";
            this.btnActive.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnActive.Size = new System.Drawing.Size(110, 34);
            this.btnActive.TabIndex = 4;
            this.btnActive.Text = "Active";
            this.btnActive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActive.UseVisualStyleBackColor = false;
            this.btnActive.CheckedChanged += new System.EventHandler(this.activeFilter_CheckedChanged);
            // 
            // btnAll
            // 
            this.btnAll.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnAll.AutoSize = true;
            this.btnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnAll.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAll.Checked = true;
            this.btnAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_All_Active;
            this.btnAll.Location = new System.Drawing.Point(0, 0);
            this.btnAll.Margin = new System.Windows.Forms.Padding(0);
            this.btnAll.MinimumSize = new System.Drawing.Size(110, 34);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(110, 34);
            this.btnAll.TabIndex = 3;
            this.btnAll.TabStop = true;
            this.btnAll.Text = "  All";
            this.btnAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.CheckedChanged += new System.EventHandler(this.allFilter_CheckedChanged);
            // 
            // separator
            // 
            this.separator.Dock = System.Windows.Forms.DockStyle.Top;
            this.separator.Location = new System.Drawing.Point(0, 54);
            this.separator.MaximumSize = new System.Drawing.Size(1620, 4);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(1093, 4);
            this.separator.TabIndex = 2;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.Controls.Add(this.pnlPagination);
            this.pnlBottom.Controls.Add(this.tableCard);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 58);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBottom.Size = new System.Drawing.Size(1093, 522);
            this.pnlBottom.TabIndex = 3;
            this.pnlBottom.Resize += new System.EventHandler(this.BottomPnl_Resize);
            // 
            // pnlPagination
            // 
            this.pnlPagination.BackColor = System.Drawing.Color.White;
            this.pnlPagination.Controls.Add(this.pnlLeft);
            this.pnlPagination.Controls.Add(this.pnlRight);
            this.pnlPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPagination.Location = new System.Drawing.Point(10, 462);
            this.pnlPagination.Name = "pnlPagination";
            this.pnlPagination.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pnlPagination.Size = new System.Drawing.Size(1073, 50);
            this.pnlPagination.TabIndex = 3;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.uiPanel2);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 5);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(140, 40);
            this.pnlLeft.TabIndex = 2;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.cbNumberofitem);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.FillColor = System.Drawing.Color.White;
            this.uiPanel2.FillColor2 = System.Drawing.Color.White;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel2.Location = new System.Drawing.Point(0, 0);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.uiPanel2.Radius = 10;
            this.uiPanel2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.uiPanel2.RectDisableColor = System.Drawing.Color.White;
            this.uiPanel2.RectSize = 2;
            this.uiPanel2.Size = new System.Drawing.Size(140, 40);
            this.uiPanel2.TabIndex = 2;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbNumberofitem
            // 
            this.cbNumberofitem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbNumberofitem.DataSource = null;
            this.cbNumberofitem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbNumberofitem.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbNumberofitem.DropDownWidth = 100;
            this.cbNumberofitem.FillColor = System.Drawing.Color.White;
            this.cbNumberofitem.FillColor2 = System.Drawing.Color.White;
            this.cbNumberofitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNumberofitem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.cbNumberofitem.ItemHeight = 24;
            this.cbNumberofitem.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            this.cbNumberofitem.ItemRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.cbNumberofitem.Items.AddRange(new object[] {
            "25 items",
            "50 items",
            "75 items",
            "100 items"});
            this.cbNumberofitem.ItemSelectBackColor = System.Drawing.Color.White;
            this.cbNumberofitem.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.cbNumberofitem.Location = new System.Drawing.Point(10, 0);
            this.cbNumberofitem.Margin = new System.Windows.Forms.Padding(0);
            this.cbNumberofitem.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbNumberofitem.Name = "cbNumberofitem";
            this.cbNumberofitem.Padding = new System.Windows.Forms.Padding(4, 0, 30, 2);
            this.cbNumberofitem.Radius = 0;
            this.cbNumberofitem.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.cbNumberofitem.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.cbNumberofitem.RectSize = 2;
            this.cbNumberofitem.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.cbNumberofitem.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.cbNumberofitem.ScrollBarStyleInherited = false;
            this.cbNumberofitem.Size = new System.Drawing.Size(120, 40);
            this.cbNumberofitem.Style = Sunny.UI.UIStyle.Custom;
            this.cbNumberofitem.SymbolDropDown = 560247;
            this.cbNumberofitem.SymbolNormal = 557682;
            this.cbNumberofitem.SymbolSize = 24;
            this.cbNumberofitem.TabIndex = 1;
            this.cbNumberofitem.Text = "25 items";
            this.cbNumberofitem.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbNumberofitem.Watermark = "";
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlNext);
            this.pnlRight.Controls.Add(this.pnlCurrentPage);
            this.pnlRight.Controls.Add(this.pnlPrevious);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(905, 5);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(168, 40);
            this.pnlRight.TabIndex = 1;
            // 
            // pnlNext
            // 
            this.pnlNext.Controls.Add(this.btnNext);
            this.pnlNext.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNext.Location = new System.Drawing.Point(126, 0);
            this.pnlNext.Name = "pnlNext";
            this.pnlNext.Padding = new System.Windows.Forms.Padding(3);
            this.pnlNext.Size = new System.Drawing.Size(40, 40);
            this.pnlNext.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNext.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnNext.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(91)))), ((int)(((byte)(17)))));
            this.btnNext.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnNext.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Next;
            this.btnNext.Location = new System.Drawing.Point(3, 3);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Padding = new System.Windows.Forms.Padding(20, 0, 22, 0);
            this.btnNext.Radius = 4;
            this.btnNext.RectColor = System.Drawing.Color.White;
            this.btnNext.RectDisableColor = System.Drawing.Color.White;
            this.btnNext.RectHoverColor = System.Drawing.Color.White;
            this.btnNext.RectPressColor = System.Drawing.Color.White;
            this.btnNext.RectSelectedColor = System.Drawing.Color.White;
            this.btnNext.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnNext.RectSize = 2;
            this.btnNext.Size = new System.Drawing.Size(34, 34);
            this.btnNext.TabIndex = 4;
            this.btnNext.TipsFont = new System.Drawing.Font("Helvetica Rounded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pnlCurrentPage
            // 
            this.pnlCurrentPage.Controls.Add(this.lbTotalpage);
            this.pnlCurrentPage.Controls.Add(this.tbCurrentpage);
            this.pnlCurrentPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCurrentPage.Location = new System.Drawing.Point(40, 0);
            this.pnlCurrentPage.Name = "pnlCurrentPage";
            this.pnlCurrentPage.Padding = new System.Windows.Forms.Padding(3);
            this.pnlCurrentPage.Size = new System.Drawing.Size(86, 40);
            this.pnlCurrentPage.TabIndex = 2;
            // 
            // lbTotalpage
            // 
            this.lbTotalpage.AutoSize = true;
            this.lbTotalpage.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTotalpage.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalpage.Location = new System.Drawing.Point(41, 3);
            this.lbTotalpage.Name = "lbTotalpage";
            this.lbTotalpage.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.lbTotalpage.Size = new System.Drawing.Size(42, 33);
            this.lbTotalpage.TabIndex = 3;
            this.lbTotalpage.Text = "/100";
            this.lbTotalpage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCurrentpage
            // 
            this.tbCurrentpage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCurrentpage.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbCurrentpage.DoubleValue = 1D;
            this.tbCurrentpage.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentpage.IntValue = 1;
            this.tbCurrentpage.Location = new System.Drawing.Point(3, 3);
            this.tbCurrentpage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCurrentpage.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbCurrentpage.Name = "tbCurrentpage";
            this.tbCurrentpage.Padding = new System.Windows.Forms.Padding(5);
            this.tbCurrentpage.Radius = 1;
            this.tbCurrentpage.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.tbCurrentpage.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.tbCurrentpage.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.tbCurrentpage.RectSize = 2;
            this.tbCurrentpage.ShowText = false;
            this.tbCurrentpage.Size = new System.Drawing.Size(34, 34);
            this.tbCurrentpage.TabIndex = 0;
            this.tbCurrentpage.Text = "01";
            this.tbCurrentpage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tbCurrentpage.Watermark = "";
            // 
            // pnlPrevious
            // 
            this.pnlPrevious.Controls.Add(this.btnPrevious);
            this.pnlPrevious.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPrevious.Location = new System.Drawing.Point(0, 0);
            this.pnlPrevious.Name = "pnlPrevious";
            this.pnlPrevious.Padding = new System.Windows.Forms.Padding(3);
            this.pnlPrevious.Size = new System.Drawing.Size(40, 40);
            this.pnlPrevious.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrevious.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnPrevious.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(91)))), ((int)(((byte)(17)))));
            this.btnPrevious.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnPrevious.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Previous;
            this.btnPrevious.Location = new System.Drawing.Point(3, 3);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrevious.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Padding = new System.Windows.Forms.Padding(20, 0, 22, 0);
            this.btnPrevious.Radius = 4;
            this.btnPrevious.RectColor = System.Drawing.Color.White;
            this.btnPrevious.RectDisableColor = System.Drawing.Color.White;
            this.btnPrevious.RectHoverColor = System.Drawing.Color.White;
            this.btnPrevious.RectPressColor = System.Drawing.Color.White;
            this.btnPrevious.RectSelectedColor = System.Drawing.Color.White;
            this.btnPrevious.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnPrevious.RectSize = 2;
            this.btnPrevious.Size = new System.Drawing.Size(34, 34);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.TipsFont = new System.Drawing.Font("Helvetica Rounded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tableCard
            // 
            this.tableCard.AllowUserToDeleteRows = false;
            this.tableCard.AllowUserToResizeColumns = false;
            this.tableCard.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(114)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableCard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableCard.BackgroundColor = System.Drawing.Color.White;
            this.tableCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableCard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableCard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableCard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableCard.ColumnHeadersHeight = 34;
            this.tableCard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colRfid,
            this.colType,
            this.colStatus,
            this.colView,
            this.colEdit,
            this.colDelete});
            this.tableCard.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableCard.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableCard.GridColor = System.Drawing.Color.White;
            this.tableCard.Location = new System.Drawing.Point(10, 10);
            this.tableCard.Margin = new System.Windows.Forms.Padding(0);
            this.tableCard.Name = "tableCard";
            this.tableCard.ReadOnly = true;
            this.tableCard.RowHeadersVisible = false;
            this.tableCard.RowHeadersWidth = 30;
            this.tableCard.RowTemplate.Height = 30;
            this.tableCard.Size = new System.Drawing.Size(1073, 502);
            this.tableCard.TabIndex = 1;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colId.Width = 30;
            // 
            // colRfid
            // 
            this.colRfid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRfid.HeaderText = "RFID";
            this.colRfid.MinimumWidth = 80;
            this.colRfid.Name = "colRfid";
            this.colRfid.ReadOnly = true;
            this.colRfid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colType
            // 
            this.colType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colView
            // 
            this.colView.HeaderText = "";
            this.colView.Name = "colView";
            this.colView.ReadOnly = true;
            this.colView.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colView.Text = "View";
            this.colView.Width = 30;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEdit.Text = "Edit";
            this.colEdit.Width = 30;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDelete.Text = "Delete";
            this.colDelete.Width = 30;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlBottom);
            this.panel2.Controls.Add(this.separator);
            this.panel2.Controls.Add(this.pnlTop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1093, 580);
            this.panel2.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(110, 34);
            this.panel5.TabIndex = 0;
            // 
            // menuMore
            // 
            this.menuMore.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.menuMore.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemImport,
            this.menuItemExport,
            this.menuItemDownload});
            this.menuMore.Name = "settingMenu";
            this.menuMore.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuMore.ShowImageMargin = false;
            this.menuMore.Size = new System.Drawing.Size(125, 76);
            // 
            // menuItemImport
            // 
            this.menuItemImport.BackColor = System.Drawing.Color.White;
            this.menuItemImport.Name = "menuItemImport";
            this.menuItemImport.Size = new System.Drawing.Size(124, 24);
            this.menuItemImport.Text = "Import";
            this.menuItemImport.Click += new System.EventHandler(this.logOutMenuItem_Click);
            // 
            // menuItemExport
            // 
            this.menuItemExport.BackColor = System.Drawing.Color.White;
            this.menuItemExport.Name = "menuItemExport";
            this.menuItemExport.Size = new System.Drawing.Size(124, 24);
            this.menuItemExport.Text = "Export";
            // 
            // menuItemDownload
            // 
            this.menuItemDownload.Name = "menuItemDownload";
            this.menuItemDownload.Size = new System.Drawing.Size(124, 24);
            this.menuItemDownload.Text = "Download";
            // 
            // CardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.Name = "CardControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1113, 600);
            this.Load += new System.EventHandler(this.CardScreen_Load);
            this.pnlTop.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.filterPnl.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.pnlTabpane.ResumeLayout(false);
            this.pnlTabpane.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlPagination.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlNext.ResumeLayout(false);
            this.pnlCurrentPage.ResumeLayout(false);
            this.pnlCurrentPage.PerformLayout();
            this.pnlPrevious.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableCard)).EndInit();
            this.panel2.ResumeLayout(false);
            this.menuMore.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlTabpane;
        private System.Windows.Forms.RadioButton btnEmpty;
        private System.Windows.Forms.RadioButton btnActive;
        private System.Windows.Forms.RadioButton btnAll;
        private System.Windows.Forms.Panel separator;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private DataGridView tableCard;
        private RadioButton btnLost;
        private RadioButton btnLocked;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colRfid;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewButtonColumn colView;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel pnlSearch;
        private PictureBox pictureBox2;
        private Sunny.UI.UITextBox tbSearch;
        private Sunny.UI.UIPanel filterPnl;
        private Sunny.UI.UIComboBox cbFilter;
        private Panel pnlButton;
        private Sunny.UI.UISymbolButton btnAdd;
        private Sunny.UI.UIButton btnMore;
        private Sunny.UI.UIContextMenuStrip menuMore;
        private ToolStripMenuItem menuItemImport;
        private ToolStripMenuItem menuItemExport;
        private ToolStripMenuItem menuItemDownload;
        private Panel pnlPagination;
        private Panel pnlLeft;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIComboBox cbNumberofitem;
        private Panel pnlRight;
        private Panel pnlNext;
        private Sunny.UI.UISymbolButton btnNext;
        private Panel pnlCurrentPage;
        private Label lbTotalpage;
        private Sunny.UI.UITextBox tbCurrentpage;
        private Panel pnlPrevious;
        private Sunny.UI.UISymbolButton btnPrevious;
    }
}
