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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.separator = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.tableArea = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalSlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.tableTop = new Sunny.UI.UITableLayoutPanel();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.pnlSearch = new Sunny.UI.UIPanel();
            this.tableSearch = new System.Windows.Forms.TableLayoutPanel();
            this.tbSearch = new Sunny.UI.UITextBox();
            this.uiPanel4 = new Sunny.UI.UIPanel();
            this.uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            this.uiPanel6 = new Sunny.UI.UIPanel();
            this.uiTableLayoutPanel2 = new Sunny.UI.UITableLayoutPanel();
            this.cbVehicalType = new Sunny.UI.UIComboBox();
            this.uiPanel5 = new Sunny.UI.UIPanel();
            this.uiPanel9 = new Sunny.UI.UIPanel();
            this.uiTableLayoutPanel3 = new Sunny.UI.UITableLayoutPanel();
            this.cbUserType = new Sunny.UI.UIComboBox();
            this.uiPanel7 = new Sunny.UI.UIPanel();
            this.uiPanel10 = new Sunny.UI.UIPanel();
            this.uiTableLayoutPanel4 = new Sunny.UI.UITableLayoutPanel();
            this.cbStatus = new Sunny.UI.UIComboBox();
            this.uiPanel8 = new Sunny.UI.UIPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClear = new Sunny.UI.UISymbolButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnApply = new Sunny.UI.UISymbolButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new Sunny.UI.UISymbolButton();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btnFilter = new Sunny.UI.UISymbolButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableArea)).BeginInit();
            this.pnlPagination.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlNext.SuspendLayout();
            this.pnlCurrentPage.SuspendLayout();
            this.pnlPrevious.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.tableTop.SuspendLayout();
            this.uiPanel3.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.tableSearch.SuspendLayout();
            this.uiPanel4.SuspendLayout();
            this.uiTableLayoutPanel1.SuspendLayout();
            this.uiPanel6.SuspendLayout();
            this.uiTableLayoutPanel2.SuspendLayout();
            this.uiPanel9.SuspendLayout();
            this.uiTableLayoutPanel3.SuspendLayout();
            this.uiPanel10.SuspendLayout();
            this.uiTableLayoutPanel4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // separator
            // 
            this.separator.Dock = System.Windows.Forms.DockStyle.Top;
            this.separator.Location = new System.Drawing.Point(0, 108);
            this.separator.MaximumSize = new System.Drawing.Size(1620, 4);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(1151, 4);
            this.separator.TabIndex = 2;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.Controls.Add(this.tableArea);
            this.pnlBottom.Controls.Add(this.pnlPagination);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 112);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.pnlBottom.Size = new System.Drawing.Size(1151, 468);
            this.pnlBottom.TabIndex = 3;
            this.pnlBottom.Resize += new System.EventHandler(this.BottomPnl_Resize);
            // 
            // tableArea
            // 
            this.tableArea.AllowUserToAddRows = false;
            this.tableArea.AllowUserToDeleteRows = false;
            this.tableArea.AllowUserToResizeColumns = false;
            this.tableArea.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.colUserType,
            this.colTotalSlot,
            this.colStatus,
            this.colView,
            this.colDelete});
            this.tableArea.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
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
            this.tableArea.RowTemplate.Height = 40;
            this.tableArea.Size = new System.Drawing.Size(1131, 398);
            this.tableArea.TabIndex = 1;
            this.tableArea.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableArea_CellContentClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colId.Width = 125;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "Vehical type";
            this.colName.MinimumWidth = 80;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colUserType
            // 
            this.colUserType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUserType.HeaderText = "User type";
            this.colUserType.MinimumWidth = 6;
            this.colUserType.Name = "colUserType";
            this.colUserType.ReadOnly = true;
            // 
            // colTotalSlot
            // 
            this.colTotalSlot.HeaderText = "Total slot";
            this.colTotalSlot.MinimumWidth = 6;
            this.colTotalSlot.Name = "colTotalSlot";
            this.colTotalSlot.ReadOnly = true;
            this.colTotalSlot.Width = 200;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 200;
            // 
            // colView
            // 
            this.colView.HeaderText = "";
            this.colView.MinimumWidth = 6;
            this.colView.Name = "colView";
            this.colView.ReadOnly = true;
            this.colView.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colView.Text = "View";
            this.colView.Width = 45;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "";
            this.colDelete.MinimumWidth = 6;
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDelete.Text = "Delete";
            this.colDelete.Width = 45;
            // 
            // pnlPagination
            // 
            this.pnlPagination.BackColor = System.Drawing.Color.White;
            this.pnlPagination.Controls.Add(this.pnlLeft);
            this.pnlPagination.Controls.Add(this.pnlRight);
            this.pnlPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPagination.Location = new System.Drawing.Point(10, 408);
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
            this.cbNumberOfItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNumberOfItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.cbNumberOfItem.ItemHeight = 24;
            this.cbNumberOfItem.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            this.cbNumberOfItem.ItemRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
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
            this.cbNumberOfItem.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbNumberOfItem.Watermark = "";
            this.cbNumberOfItem.SelectedIndexChanged += new System.EventHandler(this.numberofitemsCb_SelectedIndexChanged);
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
            this.pnlNext.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
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
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnNext.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // pnlCurrentPage
            // 
            this.pnlCurrentPage.Controls.Add(this.lbTotalPage);
            this.pnlCurrentPage.Controls.Add(this.tbCurrentPage);
            this.pnlCurrentPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCurrentPage.Location = new System.Drawing.Point(40, 0);
            this.pnlCurrentPage.Name = "pnlCurrentPage";
            this.pnlCurrentPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.pnlCurrentPage.Size = new System.Drawing.Size(86, 40);
            this.pnlCurrentPage.TabIndex = 2;
            // 
            // lbTotalPage
            // 
            this.lbTotalPage.AutoSize = true;
            this.lbTotalPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTotalPage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPage.Location = new System.Drawing.Point(43, 3);
            this.lbTotalPage.Name = "lbTotalPage";
            this.lbTotalPage.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.lbTotalPage.Size = new System.Drawing.Size(40, 33);
            this.lbTotalPage.TabIndex = 3;
            this.lbTotalPage.Text = "/100";
            this.lbTotalPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCurrentPage
            // 
            this.tbCurrentPage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCurrentPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbCurrentPage.DoubleValue = 1D;
            this.tbCurrentPage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentPage.IntValue = 1;
            this.tbCurrentPage.Location = new System.Drawing.Point(3, 3);
            this.tbCurrentPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCurrentPage.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbCurrentPage.Name = "tbCurrentPage";
            this.tbCurrentPage.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.tbCurrentPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCurrentPage_KeyPress);
            // 
            // pnlPrevious
            // 
            this.pnlPrevious.Controls.Add(this.btnPrevious);
            this.pnlPrevious.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPrevious.Location = new System.Drawing.Point(0, 0);
            this.pnlPrevious.Name = "pnlPrevious";
            this.pnlPrevious.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
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
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnPrevious.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Click += new System.EventHandler(this.previousBtn_Click);
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
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.tableTop);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlTop.Size = new System.Drawing.Size(1151, 108);
            this.pnlTop.TabIndex = 4;
            this.pnlTop.Resize += new System.EventHandler(this.TopPnl_Resize);
            // 
            // tableTop
            // 
            this.tableTop.ColumnCount = 3;
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableTop.Controls.Add(this.uiPanel3, 0, 0);
            this.tableTop.Controls.Add(this.uiPanel4, 0, 1);
            this.tableTop.Controls.Add(this.panel1, 1, 0);
            this.tableTop.Controls.Add(this.uiPanel1, 2, 0);
            this.tableTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableTop.Location = new System.Drawing.Point(5, 5);
            this.tableTop.Name = "tableTop";
            this.tableTop.RowCount = 2;
            this.tableTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableTop.Size = new System.Drawing.Size(1141, 98);
            this.tableTop.TabIndex = 0;
            this.tableTop.TagString = null;
            // 
            // uiPanel3
            // 
            this.uiPanel3.Controls.Add(this.pnlSearch);
            this.uiPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel3.FillColor = System.Drawing.Color.White;
            this.uiPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel3.Location = new System.Drawing.Point(0, 0);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.uiPanel3.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel3.Size = new System.Drawing.Size(947, 44);
            this.uiPanel3.TabIndex = 13;
            this.uiPanel3.Text = null;
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.tableSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSearch.FillColor = System.Drawing.Color.White;
            this.pnlSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSearch.Location = new System.Drawing.Point(3, 3);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(5);
            this.pnlSearch.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.pnlSearch.RectSize = 2;
            this.pnlSearch.Size = new System.Drawing.Size(365, 38);
            this.pnlSearch.TabIndex = 2;
            this.pnlSearch.Text = null;
            this.pnlSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableSearch
            // 
            this.tableSearch.ColumnCount = 1;
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSearch.Controls.Add(this.tbSearch, 0, 0);
            this.tableSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.tableSearch.Location = new System.Drawing.Point(5, 5);
            this.tableSearch.Name = "tableSearch";
            this.tableSearch.RowCount = 1;
            this.tableSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSearch.Size = new System.Drawing.Size(355, 28);
            this.tableSearch.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbSearch.Location = new System.Drawing.Point(0, 0);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tbSearch.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Padding = new System.Windows.Forms.Padding(5);
            this.tbSearch.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.tbSearch.ShowText = false;
            this.tbSearch.Size = new System.Drawing.Size(355, 28);
            this.tbSearch.Symbol = 61442;
            this.tbSearch.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.tbSearch.SymbolSize = 26;
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbSearch.Watermark = "";
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // uiPanel4
            // 
            this.tableTop.SetColumnSpan(this.uiPanel4, 3);
            this.uiPanel4.Controls.Add(this.uiTableLayoutPanel1);
            this.uiPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel4.FillColor = System.Drawing.Color.White;
            this.uiPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel4.Location = new System.Drawing.Point(0, 49);
            this.uiPanel4.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.uiPanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel4.Name = "uiPanel4";
            this.uiPanel4.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel4.Size = new System.Drawing.Size(1141, 44);
            this.uiPanel4.TabIndex = 12;
            this.uiPanel4.Text = null;
            this.uiPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTableLayoutPanel1
            // 
            this.uiTableLayoutPanel1.ColumnCount = 5;
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.uiTableLayoutPanel1.Controls.Add(this.uiPanel6, 0, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.uiPanel9, 1, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.uiPanel10, 2, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.panel4, 3, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.panel3, 4, 0);
            this.uiTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            this.uiTableLayoutPanel1.RowCount = 1;
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel1.Size = new System.Drawing.Size(1141, 44);
            this.uiTableLayoutPanel1.TabIndex = 0;
            this.uiTableLayoutPanel1.TagString = null;
            // 
            // uiPanel6
            // 
            this.uiPanel6.Controls.Add(this.uiTableLayoutPanel2);
            this.uiPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel6.FillColor = System.Drawing.Color.White;
            this.uiPanel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel6.Location = new System.Drawing.Point(4, 5);
            this.uiPanel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel6.Name = "uiPanel6";
            this.uiPanel6.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.uiPanel6.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel6.Size = new System.Drawing.Size(285, 34);
            this.uiPanel6.TabIndex = 31;
            this.uiPanel6.Text = null;
            this.uiPanel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTableLayoutPanel2
            // 
            this.uiTableLayoutPanel2.ColumnCount = 2;
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel2.Controls.Add(this.cbVehicalType, 1, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.uiPanel5, 0, 0);
            this.uiTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.uiTableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.uiTableLayoutPanel2.Name = "uiTableLayoutPanel2";
            this.uiTableLayoutPanel2.RowCount = 1;
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel2.Size = new System.Drawing.Size(280, 34);
            this.uiTableLayoutPanel2.TabIndex = 0;
            this.uiTableLayoutPanel2.TagString = null;
            // 
            // cbVehicalType
            // 
            this.cbVehicalType.DataSource = null;
            this.cbVehicalType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbVehicalType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbVehicalType.FillColor = System.Drawing.Color.White;
            this.cbVehicalType.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.cbVehicalType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVehicalType.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbVehicalType.ItemRectColor = System.Drawing.Color.White;
            this.cbVehicalType.Items.AddRange(new object[] {
            "  All  ",
            "  Two wheeler",
            "  Four wheeler"});
            this.cbVehicalType.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbVehicalType.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbVehicalType.Location = new System.Drawing.Point(110, 0);
            this.cbVehicalType.Margin = new System.Windows.Forms.Padding(0);
            this.cbVehicalType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbVehicalType.Name = "cbVehicalType";
            this.cbVehicalType.Padding = new System.Windows.Forms.Padding(5, 0, 30, 2);
            this.cbVehicalType.RectColor = System.Drawing.SystemColors.ControlDark;
            this.cbVehicalType.RectSize = 2;
            this.cbVehicalType.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.cbVehicalType.ScrollBarStyleInherited = false;
            this.cbVehicalType.Size = new System.Drawing.Size(170, 34);
            this.cbVehicalType.Style = Sunny.UI.UIStyle.Custom;
            this.cbVehicalType.SymbolSize = 24;
            this.cbVehicalType.TabIndex = 4;
            this.cbVehicalType.Text = "  All";
            this.cbVehicalType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbVehicalType.TrimFilter = true;
            this.cbVehicalType.Watermark = "";
            // 
            // uiPanel5
            // 
            this.uiPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel5.FillColor = System.Drawing.Color.White;
            this.uiPanel5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.uiPanel5.Location = new System.Drawing.Point(0, 0);
            this.uiPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel5.Name = "uiPanel5";
            this.uiPanel5.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel5.Size = new System.Drawing.Size(110, 34);
            this.uiPanel5.TabIndex = 0;
            this.uiPanel5.Text = "Vehical type:";
            this.uiPanel5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiPanel9
            // 
            this.uiPanel9.Controls.Add(this.uiTableLayoutPanel3);
            this.uiPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel9.FillColor = System.Drawing.Color.White;
            this.uiPanel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel9.Location = new System.Drawing.Point(297, 5);
            this.uiPanel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel9.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel9.Name = "uiPanel9";
            this.uiPanel9.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uiPanel9.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel9.Size = new System.Drawing.Size(285, 34);
            this.uiPanel9.TabIndex = 29;
            this.uiPanel9.Text = null;
            this.uiPanel9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTableLayoutPanel3
            // 
            this.uiTableLayoutPanel3.ColumnCount = 2;
            this.uiTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.uiTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel3.Controls.Add(this.cbUserType, 1, 0);
            this.uiTableLayoutPanel3.Controls.Add(this.uiPanel7, 0, 0);
            this.uiTableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel3.Location = new System.Drawing.Point(5, 0);
            this.uiTableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.uiTableLayoutPanel3.Name = "uiTableLayoutPanel3";
            this.uiTableLayoutPanel3.RowCount = 1;
            this.uiTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel3.Size = new System.Drawing.Size(275, 34);
            this.uiTableLayoutPanel3.TabIndex = 1;
            this.uiTableLayoutPanel3.TagString = null;
            // 
            // cbUserType
            // 
            this.cbUserType.DataSource = null;
            this.cbUserType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbUserType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbUserType.FillColor = System.Drawing.Color.White;
            this.cbUserType.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.cbUserType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUserType.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbUserType.ItemRectColor = System.Drawing.Color.White;
            this.cbUserType.Items.AddRange(new object[] {
            "  All",
            "  Resident",
            "  Visitor"});
            this.cbUserType.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbUserType.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbUserType.Location = new System.Drawing.Point(85, 0);
            this.cbUserType.Margin = new System.Windows.Forms.Padding(0);
            this.cbUserType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbUserType.Name = "cbUserType";
            this.cbUserType.Padding = new System.Windows.Forms.Padding(5, 0, 30, 2);
            this.cbUserType.RectColor = System.Drawing.SystemColors.ControlDark;
            this.cbUserType.RectSize = 2;
            this.cbUserType.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.cbUserType.ScrollBarStyleInherited = false;
            this.cbUserType.Size = new System.Drawing.Size(190, 34);
            this.cbUserType.Style = Sunny.UI.UIStyle.Custom;
            this.cbUserType.SymbolSize = 24;
            this.cbUserType.TabIndex = 4;
            this.cbUserType.Text = "  All";
            this.cbUserType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbUserType.TrimFilter = true;
            this.cbUserType.Watermark = "";
            // 
            // uiPanel7
            // 
            this.uiPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel7.FillColor = System.Drawing.Color.White;
            this.uiPanel7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.uiPanel7.Location = new System.Drawing.Point(0, 0);
            this.uiPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel7.Name = "uiPanel7";
            this.uiPanel7.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel7.Size = new System.Drawing.Size(85, 34);
            this.uiPanel7.TabIndex = 0;
            this.uiPanel7.Text = "User type:";
            this.uiPanel7.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiPanel10
            // 
            this.uiPanel10.Controls.Add(this.uiTableLayoutPanel4);
            this.uiPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel10.FillColor = System.Drawing.Color.White;
            this.uiPanel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel10.Location = new System.Drawing.Point(590, 5);
            this.uiPanel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel10.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel10.Name = "uiPanel10";
            this.uiPanel10.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uiPanel10.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel10.Size = new System.Drawing.Size(285, 34);
            this.uiPanel10.TabIndex = 27;
            this.uiPanel10.Text = null;
            this.uiPanel10.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTableLayoutPanel4
            // 
            this.uiTableLayoutPanel4.ColumnCount = 2;
            this.uiTableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.uiTableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel4.Controls.Add(this.cbStatus, 1, 0);
            this.uiTableLayoutPanel4.Controls.Add(this.uiPanel8, 0, 0);
            this.uiTableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel4.Location = new System.Drawing.Point(5, 0);
            this.uiTableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.uiTableLayoutPanel4.Name = "uiTableLayoutPanel4";
            this.uiTableLayoutPanel4.RowCount = 1;
            this.uiTableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel4.Size = new System.Drawing.Size(275, 34);
            this.uiTableLayoutPanel4.TabIndex = 1;
            this.uiTableLayoutPanel4.TagString = null;
            // 
            // cbStatus
            // 
            this.cbStatus.DataSource = null;
            this.cbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbStatus.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbStatus.FillColor = System.Drawing.Color.White;
            this.cbStatus.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.cbStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbStatus.ItemRectColor = System.Drawing.Color.White;
            this.cbStatus.Items.AddRange(new object[] {
            "  All",
            "  Full",
            "  Avaliable",
            "  Closed",
            "  Under maintenace"});
            this.cbStatus.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbStatus.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbStatus.Location = new System.Drawing.Point(60, 0);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(0);
            this.cbStatus.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Padding = new System.Windows.Forms.Padding(5, 0, 30, 2);
            this.cbStatus.RectColor = System.Drawing.SystemColors.ControlDark;
            this.cbStatus.RectSize = 2;
            this.cbStatus.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.cbStatus.ScrollBarStyleInherited = false;
            this.cbStatus.Size = new System.Drawing.Size(215, 34);
            this.cbStatus.Style = Sunny.UI.UIStyle.Custom;
            this.cbStatus.SymbolSize = 24;
            this.cbStatus.TabIndex = 4;
            this.cbStatus.Text = "  All";
            this.cbStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbStatus.TrimFilter = true;
            this.cbStatus.Watermark = "";
            // 
            // uiPanel8
            // 
            this.uiPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel8.FillColor = System.Drawing.Color.White;
            this.uiPanel8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.uiPanel8.Location = new System.Drawing.Point(0, 0);
            this.uiPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel8.Name = "uiPanel8";
            this.uiPanel8.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel8.Size = new System.Drawing.Size(60, 34);
            this.uiPanel8.TabIndex = 0;
            this.uiPanel8.Text = "Status:";
            this.uiPanel8.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(882, 3);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panel4.Size = new System.Drawing.Size(124, 38);
            this.panel4.TabIndex = 26;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.FillColor = System.Drawing.Color.White;
            this.btnClear.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnClear.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnClear.FillSelectedColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnClear.Location = new System.Drawing.Point(5, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(14, 0, 12, 0);
            this.btnClear.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnClear.RectDisableColor = System.Drawing.Color.White;
            this.btnClear.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnClear.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnClear.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnClear.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnClear.RectSize = 2;
            this.btnClear.Size = new System.Drawing.Size(114, 38);
            this.btnClear.Symbol = 61453;
            this.btnClear.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnApply);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(1012, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(126, 38);
            this.panel3.TabIndex = 25;
            // 
            // btnApply
            // 
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApply.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnApply.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(91)))), ((int)(((byte)(17)))));
            this.btnApply.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnApply.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(5, 0);
            this.btnApply.Margin = new System.Windows.Forms.Padding(0);
            this.btnApply.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnApply.Name = "btnApply";
            this.btnApply.Padding = new System.Windows.Forms.Padding(14, 0, 12, 0);
            this.btnApply.Radius = 6;
            this.btnApply.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnApply.RectDisableColor = System.Drawing.Color.White;
            this.btnApply.RectHoverColor = System.Drawing.Color.White;
            this.btnApply.RectPressColor = System.Drawing.Color.White;
            this.btnApply.RectSelectedColor = System.Drawing.Color.White;
            this.btnApply.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnApply.Size = new System.Drawing.Size(121, 38);
            this.btnApply.Symbol = 61616;
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(950, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panel1.Size = new System.Drawing.Size(144, 38);
            this.panel1.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnAdd.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(91)))), ((int)(((byte)(17)))));
            this.btnAdd.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(5, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Radius = 10;
            this.btnAdd.RectColor = System.Drawing.Color.White;
            this.btnAdd.RectDisableColor = System.Drawing.Color.White;
            this.btnAdd.RectHoverColor = System.Drawing.Color.White;
            this.btnAdd.RectPressColor = System.Drawing.Color.White;
            this.btnAdd.RectSelectedColor = System.Drawing.Color.White;
            this.btnAdd.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnAdd.Size = new System.Drawing.Size(134, 38);
            this.btnAdd.Symbol = 61694;
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "New area";
            this.btnAdd.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.btnFilter);
            this.uiPanel1.FillColor = System.Drawing.Color.White;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(1101, 5);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.White;
            this.uiPanel1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel1.Size = new System.Drawing.Size(36, 34);
            this.uiPanel1.TabIndex = 10;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFilter
            // 
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilter.FillColor = System.Drawing.Color.White;
            this.btnFilter.FillColor2 = System.Drawing.Color.White;
            this.btnFilter.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnFilter.FillPressColor = System.Drawing.Color.White;
            this.btnFilter.FillSelectedColor = System.Drawing.Color.White;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFilter.Location = new System.Drawing.Point(0, 0);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(0);
            this.btnFilter.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnFilter.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnFilter.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnFilter.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnFilter.RectSize = 2;
            this.btnFilter.Size = new System.Drawing.Size(36, 34);
            this.btnFilter.Symbol = 61616;
            this.btnFilter.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnFilter.SymbolOffset = new System.Drawing.Point(0, 2);
            this.btnFilter.SymbolPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnFilter.SymbolSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnFilter.TabIndex = 0;
            this.btnFilter.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
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
            this.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.Size = new System.Drawing.Size(1171, 600);
            this.Load += new System.EventHandler(this.AreaScreen_Load);
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableArea)).EndInit();
            this.pnlPagination.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlNext.ResumeLayout(false);
            this.pnlCurrentPage.ResumeLayout(false);
            this.pnlCurrentPage.PerformLayout();
            this.pnlPrevious.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.tableTop.ResumeLayout(false);
            this.uiPanel3.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.tableSearch.ResumeLayout(false);
            this.uiPanel4.ResumeLayout(false);
            this.uiTableLayoutPanel1.ResumeLayout(false);
            this.uiPanel6.ResumeLayout(false);
            this.uiTableLayoutPanel2.ResumeLayout(false);
            this.uiPanel9.ResumeLayout(false);
            this.uiTableLayoutPanel3.ResumeLayout(false);
            this.uiPanel10.ResumeLayout(false);
            this.uiTableLayoutPanel4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private Panel pnlLeft;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIComboBox cbNumberOfItem;
        private Panel pnlTop;
        private Sunny.UI.UITableLayoutPanel tableTop;
        private Sunny.UI.UIPanel uiPanel4;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Panel panel1;
        private Sunny.UI.UISymbolButton btnAdd;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UISymbolButton btnFilter;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIPanel pnlSearch;
        private TableLayoutPanel tableSearch;
        private Sunny.UI.UITextBox tbSearch;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colUserType;
        private DataGridViewTextBoxColumn colTotalSlot;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewButtonColumn colView;
        private DataGridViewButtonColumn colDelete;
        private Panel panel3;
        private Sunny.UI.UISymbolButton btnApply;
        private Sunny.UI.UIPanel uiPanel6;
        private Sunny.UI.UIPanel uiPanel9;
        private Sunny.UI.UIPanel uiPanel10;
        private Panel panel4;
        private Sunny.UI.UISymbolButton btnClear;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel2;
        private Sunny.UI.UIComboBox cbVehicalType;
        private Sunny.UI.UIPanel uiPanel5;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel3;
        private Sunny.UI.UIComboBox cbUserType;
        private Sunny.UI.UIPanel uiPanel7;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel4;
        private Sunny.UI.UIComboBox cbStatus;
        private Sunny.UI.UIPanel uiPanel8;
    }
}
