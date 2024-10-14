using System.Windows.Forms;

namespace ZiTyLot.GUI.Screens
{
    partial class AreaControl
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
            this.pnlFilter = new Sunny.UI.UIPanel();
            this.cbFilter = new Sunny.UI.UIComboBox();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnAdd = new Sunny.UI.UISymbolButton();
            this.pnlTabpane = new System.Windows.Forms.Panel();
            this.btnVistor = new System.Windows.Forms.RadioButton();
            this.btnResident = new System.Windows.Forms.RadioButton();
            this.btnAll = new System.Windows.Forms.RadioButton();
            this.separator = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlPagination = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.cbNumberOfItem = new Sunny.UI.UIComboBox();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlNext = new System.Windows.Forms.Panel();
            this.btnNext = new Sunny.UI.UISymbolButton();
            this.pnlCurrentPage = new System.Windows.Forms.Panel();
            this.lbTotalPage = new System.Windows.Forms.Label();
            this.tbCurrentPage = new Sunny.UI.UITextBox();
            this.pnlPrevious = new System.Windows.Forms.Panel();
            this.btnPrevious = new Sunny.UI.UISymbolButton();
            this.tableArea = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalSlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemainSlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlFilter.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.tableArea)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.pnlTop.Size = new System.Drawing.Size(1151, 54);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.Resize += new System.EventHandler(this.TopPnl_Resize);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.pnlSearch);
            this.uiPanel1.Controls.Add(this.pnlFilter);
            this.uiPanel1.Controls.Add(this.pnlButton);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiPanel1.FillColor = System.Drawing.Color.White;
            this.uiPanel1.FillColor2 = System.Drawing.Color.White;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(631, 10);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.White;
            this.uiPanel1.Size = new System.Drawing.Size(510, 34);
            this.uiPanel1.TabIndex = 9;
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
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.cbFilter);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFilter.FillColor = System.Drawing.Color.White;
            this.pnlFilter.FillColor2 = System.Drawing.Color.White;
            this.pnlFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFilter.Location = new System.Drawing.Point(260, 0);
            this.pnlFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlFilter.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pnlFilter.Radius = 10;
            this.pnlFilter.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.pnlFilter.RectDisableColor = System.Drawing.Color.White;
            this.pnlFilter.RectSize = 2;
            this.pnlFilter.Size = new System.Drawing.Size(120, 34);
            this.pnlFilter.TabIndex = 1;
            this.pnlFilter.Text = null;
            this.pnlFilter.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pnlButton.Controls.Add(this.btnAdd);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlButton.Location = new System.Drawing.Point(380, 0);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlButton.Size = new System.Drawing.Size(130, 34);
            this.pnlButton.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.btnAdd.Size = new System.Drawing.Size(120, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "New area";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pnlTabpane
            // 
            this.pnlTabpane.Controls.Add(this.btnVistor);
            this.pnlTabpane.Controls.Add(this.btnResident);
            this.pnlTabpane.Controls.Add(this.btnAll);
            this.pnlTabpane.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTabpane.Location = new System.Drawing.Point(10, 10);
            this.pnlTabpane.Name = "pnlTabpane";
            this.pnlTabpane.Size = new System.Drawing.Size(369, 34);
            this.pnlTabpane.TabIndex = 8;
            // 
            // btnVistor
            // 
            this.btnVistor.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnVistor.AutoSize = true;
            this.btnVistor.BackColor = System.Drawing.Color.White;
            this.btnVistor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVistor.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVistor.FlatAppearance.BorderSize = 0;
            this.btnVistor.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnVistor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnVistor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnVistor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVistor.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVistor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnVistor.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Visitor;
            this.btnVistor.Location = new System.Drawing.Point(228, 0);
            this.btnVistor.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVistor.MinimumSize = new System.Drawing.Size(110, 34);
            this.btnVistor.Name = "btnVistor";
            this.btnVistor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVistor.Size = new System.Drawing.Size(110, 34);
            this.btnVistor.TabIndex = 5;
            this.btnVistor.TabStop = true;
            this.btnVistor.Text = "Vistor";
            this.btnVistor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVistor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVistor.UseVisualStyleBackColor = false;
            // 
            // btnResident
            // 
            this.btnResident.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnResident.AutoSize = true;
            this.btnResident.BackColor = System.Drawing.Color.White;
            this.btnResident.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResident.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnResident.FlatAppearance.BorderSize = 0;
            this.btnResident.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnResident.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnResident.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnResident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResident.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResident.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnResident.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Resident;
            this.btnResident.Location = new System.Drawing.Point(110, 0);
            this.btnResident.Margin = new System.Windows.Forms.Padding(0);
            this.btnResident.MinimumSize = new System.Drawing.Size(110, 34);
            this.btnResident.Name = "btnResident";
            this.btnResident.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnResident.Size = new System.Drawing.Size(118, 34);
            this.btnResident.TabIndex = 4;
            this.btnResident.TabStop = true;
            this.btnResident.Text = "Resident";
            this.btnResident.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResident.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResident.UseVisualStyleBackColor = false;
            // 
            // btnAll
            // 
            this.btnAll.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnAll.AutoSize = true;
            this.btnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnAll.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // 
            // separator
            // 
            this.separator.Dock = System.Windows.Forms.DockStyle.Top;
            this.separator.Location = new System.Drawing.Point(0, 54);
            this.separator.MaximumSize = new System.Drawing.Size(1620, 4);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(1151, 4);
            this.separator.TabIndex = 2;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.Controls.Add(this.pnlPagination);
            this.pnlBottom.Controls.Add(this.tableArea);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 58);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBottom.Size = new System.Drawing.Size(1151, 522);
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
            this.pnlPagination.Size = new System.Drawing.Size(1131, 50);
            this.pnlPagination.TabIndex = 2;
            this.pnlPagination.Tag = "";
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
            this.uiPanel2.Controls.Add(this.cbNumberOfItem);
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
            // cbNumberOfItem
            // 
            this.cbNumberOfItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbNumberOfItem.DataSource = null;
            this.cbNumberOfItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbNumberOfItem.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbNumberOfItem.DropDownWidth = 100;
            this.cbNumberOfItem.FillColor = System.Drawing.Color.White;
            this.cbNumberOfItem.FillColor2 = System.Drawing.Color.White;
            this.cbNumberOfItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNumberOfItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.cbNumberOfItem.ItemHeight = 24;
            this.cbNumberOfItem.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            this.cbNumberOfItem.ItemRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.cbNumberOfItem.Items.AddRange(new object[] {
            "All",
            "Hello",
            "Hi"});
            this.cbNumberOfItem.ItemSelectBackColor = System.Drawing.Color.White;
            this.cbNumberOfItem.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.cbNumberOfItem.Location = new System.Drawing.Point(10, 0);
            this.cbNumberOfItem.Margin = new System.Windows.Forms.Padding(0);
            this.cbNumberOfItem.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbNumberOfItem.Name = "cbNumberOfItem";
            this.cbNumberOfItem.Padding = new System.Windows.Forms.Padding(4, 0, 30, 2);
            this.cbNumberOfItem.Radius = 0;
            this.cbNumberOfItem.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.cbNumberOfItem.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.cbNumberOfItem.RectSize = 2;
            this.cbNumberOfItem.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.cbNumberOfItem.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.cbNumberOfItem.ScrollBarStyleInherited = false;
            this.cbNumberOfItem.Size = new System.Drawing.Size(120, 40);
            this.cbNumberOfItem.Style = Sunny.UI.UIStyle.Custom;
            this.cbNumberOfItem.SymbolDropDown = 560247;
            this.cbNumberOfItem.SymbolNormal = 557682;
            this.cbNumberOfItem.SymbolSize = 24;
            this.cbNumberOfItem.TabIndex = 1;
            this.cbNumberOfItem.Text = "25 items";
            this.cbNumberOfItem.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbNumberOfItem.Watermark = "";
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlNext);
            this.pnlRight.Controls.Add(this.pnlCurrentPage);
            this.pnlRight.Controls.Add(this.pnlPrevious);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(963, 5);
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
            this.pnlCurrentPage.Controls.Add(this.lbTotalPage);
            this.pnlCurrentPage.Controls.Add(this.tbCurrentPage);
            this.pnlCurrentPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCurrentPage.Location = new System.Drawing.Point(40, 0);
            this.pnlCurrentPage.Name = "pnlCurrentPage";
            this.pnlCurrentPage.Padding = new System.Windows.Forms.Padding(3);
            this.pnlCurrentPage.Size = new System.Drawing.Size(86, 40);
            this.pnlCurrentPage.TabIndex = 2;
            // 
            // lbTotalPage
            // 
            this.lbTotalPage.AutoSize = true;
            this.lbTotalPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTotalPage.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPage.Location = new System.Drawing.Point(41, 3);
            this.lbTotalPage.Name = "lbTotalPage";
            this.lbTotalPage.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.lbTotalPage.Size = new System.Drawing.Size(42, 33);
            this.lbTotalPage.TabIndex = 3;
            this.lbTotalPage.Text = "/100";
            this.lbTotalPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCurrentPage
            // 
            this.tbCurrentPage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCurrentPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbCurrentPage.DoubleValue = 1D;
            this.tbCurrentPage.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentPage.IntValue = 1;
            this.tbCurrentPage.Location = new System.Drawing.Point(3, 3);
            this.tbCurrentPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCurrentPage.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbCurrentPage.Name = "tbCurrentPage";
            this.tbCurrentPage.Padding = new System.Windows.Forms.Padding(5);
            this.tbCurrentPage.Radius = 1;
            this.tbCurrentPage.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.tbCurrentPage.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.tbCurrentPage.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.tbCurrentPage.RectSize = 2;
            this.tbCurrentPage.ShowText = false;
            this.tbCurrentPage.Size = new System.Drawing.Size(34, 34);
            this.tbCurrentPage.TabIndex = 0;
            this.tbCurrentPage.Text = "01";
            this.tbCurrentPage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tbCurrentPage.Watermark = "";
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
            // tableArea
            // 
            this.tableArea.AllowUserToDeleteRows = false;
            this.tableArea.AllowUserToResizeColumns = false;
            this.tableArea.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(114)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.tableArea.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableArea.BackgroundColor = System.Drawing.Color.White;
            this.tableArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableArea.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableArea.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableArea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableArea.ColumnHeadersHeight = 34;
            this.tableArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colTotalSlot,
            this.colRemainSlot,
            this.colStatus,
            this.colView,
            this.colEdit,
            this.colDelete});
            this.tableArea.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableArea.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableArea.GridColor = System.Drawing.Color.White;
            this.tableArea.Location = new System.Drawing.Point(10, 10);
            this.tableArea.Margin = new System.Windows.Forms.Padding(0);
            this.tableArea.Name = "tableArea";
            this.tableArea.ReadOnly = true;
            this.tableArea.RowHeadersVisible = false;
            this.tableArea.RowHeadersWidth = 30;
            this.tableArea.RowTemplate.Height = 30;
            this.tableArea.Size = new System.Drawing.Size(1131, 502);
            this.tableArea.TabIndex = 1;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colId.Width = 30;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 80;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colTotalSlot
            // 
            this.colTotalSlot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTotalSlot.HeaderText = "Total slot";
            this.colTotalSlot.Name = "colTotalSlot";
            this.colTotalSlot.ReadOnly = true;
            // 
            // colRemainSlot
            // 
            this.colRemainSlot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRemainSlot.HeaderText = "Remain slot";
            this.colRemainSlot.Name = "colRemainSlot";
            this.colRemainSlot.ReadOnly = true;
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
            this.panel2.Size = new System.Drawing.Size(1151, 580);
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
            // AreaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.Name = "AreaControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1171, 600);
            this.Load += new System.EventHandler(this.AreaScreen_Load);
            this.pnlTop.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlFilter.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.tableArea)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlTabpane;
        private System.Windows.Forms.RadioButton btnVistor;
        private System.Windows.Forms.RadioButton btnResident;
        private System.Windows.Forms.RadioButton btnAll;
        private System.Windows.Forms.Panel separator;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private DataGridView tableArea;
        private Panel pnlPagination;
        private Panel pnlRight;
        private Panel pnlNext;
        private Sunny.UI.UISymbolButton btnNext;
        private Panel pnlCurrentPage;
        private Label lbTotalPage;
        private Sunny.UI.UITextBox tbCurrentPage;
        private Panel pnlPrevious;
        private Sunny.UI.UISymbolButton btnPrevious;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colTotalSlot;
        private DataGridViewTextBoxColumn colRemainSlot;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewButtonColumn colView;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel pnlSearch;
        private PictureBox pictureBox2;
        private Sunny.UI.UITextBox tbSearch;
        private Sunny.UI.UIPanel pnlFilter;
        private Sunny.UI.UIComboBox cbFilter;
        private Panel pnlButton;
        private Sunny.UI.UISymbolButton btnAdd;
        private Panel pnlLeft;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIComboBox cbNumberOfItem;
    }
}
