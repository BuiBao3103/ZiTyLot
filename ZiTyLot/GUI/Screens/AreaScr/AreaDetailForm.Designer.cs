namespace ZiTyLot.GUI.Screens.AreaScr
{
    partial class AreaDetailForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaDetailForm));
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiTableLayoutPanel2 = new Sunny.UI.UITableLayoutPanel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.tableSlot = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.pnlInformation = new Sunny.UI.UITableLayoutPanel();
            this.pnlType = new Sunny.UI.UIPanel();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.cbUserType = new Sunny.UI.UIComboBox();
            this.pnlVehical = new Sunny.UI.UIPanel();
            this.uiGroupBox3 = new Sunny.UI.UIGroupBox();
            this.cbVehicalType = new Sunny.UI.UIComboBox();
            this.pnlStatus = new Sunny.UI.UIPanel();
            this.uiGroupBox6 = new Sunny.UI.UIGroupBox();
            this.uiPanel4 = new Sunny.UI.UIPanel();
            this.rbtnMaintenace = new Sunny.UI.UIRadioButton();
            this.rbtnClosed = new Sunny.UI.UIRadioButton();
            this.rbtnAvaliable = new Sunny.UI.UIRadioButton();
            this.pnlTotalSlot = new Sunny.UI.UIPanel();
            this.uiGroupBox4 = new Sunny.UI.UIGroupBox();
            this.tbTotalSlot = new Sunny.UI.UITextBox();
            this.uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            this.uiPanel7 = new Sunny.UI.UIPanel();
            this.uiTableLayoutPanel3 = new Sunny.UI.UITableLayoutPanel();
            this.btnAddSlot = new Sunny.UI.UISymbolButton();
            this.btnSave = new Sunny.UI.UISymbolButton();
            this.btnCancel = new Sunny.UI.UISymbolButton();
            this.uiPanel5 = new Sunny.UI.UIPanel();
            this.uiPanel6 = new Sunny.UI.UIPanel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiPanel1.SuspendLayout();
            this.uiTableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableSlot)).BeginInit();
            this.uiPanel3.SuspendLayout();
            this.pnlInformation.SuspendLayout();
            this.pnlType.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.pnlVehical.SuspendLayout();
            this.uiGroupBox3.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.uiGroupBox6.SuspendLayout();
            this.uiPanel4.SuspendLayout();
            this.pnlTotalSlot.SuspendLayout();
            this.uiGroupBox4.SuspendLayout();
            this.uiTableLayoutPanel1.SuspendLayout();
            this.uiPanel7.SuspendLayout();
            this.uiTableLayoutPanel3.SuspendLayout();
            this.uiPanel5.SuspendLayout();
            this.uiPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiTableLayoutPanel2);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.FillColor = System.Drawing.Color.White;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(4, 59);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.White;
            this.uiPanel1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel1.Size = new System.Drawing.Size(896, 268);
            this.uiPanel1.TabIndex = 5;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTableLayoutPanel2
            // 
            this.uiTableLayoutPanel2.ColumnCount = 3;
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel2.Controls.Add(this.uiPanel2, 1, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.tableSlot, 2, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.uiPanel3, 0, 0);
            this.uiTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.uiTableLayoutPanel2.Name = "uiTableLayoutPanel2";
            this.uiTableLayoutPanel2.RowCount = 1;
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel2.Size = new System.Drawing.Size(896, 268);
            this.uiTableLayoutPanel2.TabIndex = 0;
            this.uiTableLayoutPanel2.TagString = null;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.FillColor = System.Drawing.SystemColors.ControlLight;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(448, 5);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Radius = 0;
            this.uiPanel2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel2.Size = new System.Drawing.Size(1, 258);
            this.uiPanel2.TabIndex = 12;
            this.uiPanel2.Text = "uiPanel2";
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableSlot
            // 
            this.tableSlot.AllowUserToAddRows = false;
            this.tableSlot.AllowUserToDeleteRows = false;
            this.tableSlot.AllowUserToResizeColumns = false;
            this.tableSlot.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(114)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.tableSlot.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableSlot.BackgroundColor = System.Drawing.Color.White;
            this.tableSlot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableSlot.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableSlot.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableSlot.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableSlot.ColumnHeadersHeight = 34;
            this.tableSlot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colStatus,
            this.colAction,
            this.colDelete});
            this.tableSlot.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableSlot.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableSlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSlot.GridColor = System.Drawing.Color.White;
            this.tableSlot.Location = new System.Drawing.Point(452, 0);
            this.tableSlot.Margin = new System.Windows.Forms.Padding(0);
            this.tableSlot.Name = "tableSlot";
            this.tableSlot.ReadOnly = true;
            this.tableSlot.RowHeadersVisible = false;
            this.tableSlot.RowHeadersWidth = 30;
            this.tableSlot.RowTemplate.Height = 40;
            this.tableSlot.Size = new System.Drawing.Size(444, 268);
            this.tableSlot.TabIndex = 3;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colID.Width = 150;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colAction
            // 
            this.colAction.HeaderText = "";
            this.colAction.MinimumWidth = 6;
            this.colAction.Name = "colAction";
            this.colAction.ReadOnly = true;
            this.colAction.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAction.Text = "View";
            this.colAction.Width = 45;
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
            // uiPanel3
            // 
            this.uiPanel3.Controls.Add(this.pnlInformation);
            this.uiPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel3.FillColor = System.Drawing.Color.White;
            this.uiPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel3.Location = new System.Drawing.Point(0, 0);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.RectColor = System.Drawing.Color.White;
            this.uiPanel3.Size = new System.Drawing.Size(444, 268);
            this.uiPanel3.TabIndex = 1;
            this.uiPanel3.Text = null;
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInformation
            // 
            this.pnlInformation.ColumnCount = 3;
            this.pnlInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlInformation.Controls.Add(this.pnlType, 0, 0);
            this.pnlInformation.Controls.Add(this.pnlVehical, 2, 0);
            this.pnlInformation.Controls.Add(this.pnlStatus, 2, 1);
            this.pnlInformation.Controls.Add(this.pnlTotalSlot, 0, 1);
            this.pnlInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInformation.Location = new System.Drawing.Point(0, 0);
            this.pnlInformation.Name = "pnlInformation";
            this.pnlInformation.RowCount = 3;
            this.pnlInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlInformation.Size = new System.Drawing.Size(444, 268);
            this.pnlInformation.TabIndex = 0;
            this.pnlInformation.TagString = null;
            // 
            // pnlType
            // 
            this.pnlInformation.SetColumnSpan(this.pnlType, 3);
            this.pnlType.Controls.Add(this.uiGroupBox2);
            this.pnlType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlType.FillColor = System.Drawing.Color.White;
            this.pnlType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlType.Location = new System.Drawing.Point(4, 5);
            this.pnlType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlType.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlType.Name = "pnlType";
            this.pnlType.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pnlType.Size = new System.Drawing.Size(436, 79);
            this.pnlType.TabIndex = 10;
            this.pnlType.Text = null;
            this.pnlType.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.cbUserType);
            this.uiGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox2.FillColor = System.Drawing.Color.White;
            this.uiGroupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiGroupBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.uiGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(8, 32, 8, 4);
            this.uiGroupBox2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiGroupBox2.Size = new System.Drawing.Size(436, 79);
            this.uiGroupBox2.TabIndex = 1;
            this.uiGroupBox2.Text = "User type";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbUserType
            // 
            this.cbUserType.DataSource = null;
            this.cbUserType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbUserType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbUserType.FillColor = System.Drawing.Color.White;
            this.cbUserType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUserType.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbUserType.ItemRectColor = System.Drawing.Color.White;
            this.cbUserType.Items.AddRange(new object[] {
            "  Resident",
            "  Vistor"});
            this.cbUserType.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbUserType.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbUserType.Location = new System.Drawing.Point(8, 32);
            this.cbUserType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbUserType.MaximumSize = new System.Drawing.Size(0, 34);
            this.cbUserType.MinimumSize = new System.Drawing.Size(0, 34);
            this.cbUserType.Name = "cbUserType";
            this.cbUserType.Padding = new System.Windows.Forms.Padding(10, 0, 30, 2);
            this.cbUserType.RectColor = System.Drawing.SystemColors.ControlDark;
            this.cbUserType.RectSize = 2;
            this.cbUserType.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.cbUserType.ScrollBarStyleInherited = false;
            this.cbUserType.Size = new System.Drawing.Size(420, 34);
            this.cbUserType.SymbolSize = 24;
            this.cbUserType.TabIndex = 1;
            this.cbUserType.Text = "  Resident";
            this.cbUserType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbUserType.TrimFilter = true;
            this.cbUserType.Watermark = "";
            // 
            // pnlVehical
            // 
            this.pnlInformation.SetColumnSpan(this.pnlVehical, 2);
            this.pnlVehical.Controls.Add(this.uiGroupBox3);
            this.pnlVehical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVehical.FillColor = System.Drawing.Color.White;
            this.pnlVehical.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlVehical.Location = new System.Drawing.Point(4, 94);
            this.pnlVehical.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlVehical.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlVehical.Name = "pnlVehical";
            this.pnlVehical.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pnlVehical.Size = new System.Drawing.Size(288, 79);
            this.pnlVehical.TabIndex = 8;
            this.pnlVehical.Text = null;
            this.pnlVehical.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.cbVehicalType);
            this.uiGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox3.FillColor = System.Drawing.Color.White;
            this.uiGroupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiGroupBox3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.uiGroupBox3.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Padding = new System.Windows.Forms.Padding(8, 32, 8, 4);
            this.uiGroupBox3.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiGroupBox3.Size = new System.Drawing.Size(288, 79);
            this.uiGroupBox3.TabIndex = 1;
            this.uiGroupBox3.Text = "Vehical Type";
            this.uiGroupBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbVehicalType
            // 
            this.cbVehicalType.DataSource = null;
            this.cbVehicalType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbVehicalType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbVehicalType.FillColor = System.Drawing.Color.White;
            this.cbVehicalType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVehicalType.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbVehicalType.ItemRectColor = System.Drawing.Color.White;
            this.cbVehicalType.Items.AddRange(new object[] {
            "  Two wheeler",
            "  Four wheeler"});
            this.cbVehicalType.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbVehicalType.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbVehicalType.Location = new System.Drawing.Point(8, 32);
            this.cbVehicalType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbVehicalType.MaximumSize = new System.Drawing.Size(0, 34);
            this.cbVehicalType.MinimumSize = new System.Drawing.Size(0, 34);
            this.cbVehicalType.Name = "cbVehicalType";
            this.cbVehicalType.Padding = new System.Windows.Forms.Padding(10, 0, 30, 2);
            this.cbVehicalType.RectColor = System.Drawing.SystemColors.ControlDark;
            this.cbVehicalType.RectSize = 2;
            this.cbVehicalType.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.cbVehicalType.ScrollBarStyleInherited = false;
            this.cbVehicalType.Size = new System.Drawing.Size(272, 34);
            this.cbVehicalType.SymbolSize = 24;
            this.cbVehicalType.TabIndex = 1;
            this.cbVehicalType.Text = "  Two wheeler";
            this.cbVehicalType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbVehicalType.TrimFilter = true;
            this.cbVehicalType.Watermark = "";
            // 
            // pnlStatus
            // 
            this.pnlInformation.SetColumnSpan(this.pnlStatus, 3);
            this.pnlStatus.Controls.Add(this.uiGroupBox6);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatus.FillColor = System.Drawing.Color.White;
            this.pnlStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlStatus.Location = new System.Drawing.Point(4, 183);
            this.pnlStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlStatus.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pnlStatus.Size = new System.Drawing.Size(436, 80);
            this.pnlStatus.TabIndex = 6;
            this.pnlStatus.Text = null;
            this.pnlStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiGroupBox6
            // 
            this.uiGroupBox6.Controls.Add(this.uiPanel4);
            this.uiGroupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox6.FillColor = System.Drawing.Color.White;
            this.uiGroupBox6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiGroupBox6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.uiGroupBox6.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox6.Name = "uiGroupBox6";
            this.uiGroupBox6.Padding = new System.Windows.Forms.Padding(8, 32, 8, 4);
            this.uiGroupBox6.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiGroupBox6.Size = new System.Drawing.Size(436, 80);
            this.uiGroupBox6.TabIndex = 0;
            this.uiGroupBox6.Text = "Status";
            this.uiGroupBox6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel4
            // 
            this.uiPanel4.Controls.Add(this.rbtnMaintenace);
            this.uiPanel4.Controls.Add(this.rbtnClosed);
            this.uiPanel4.Controls.Add(this.rbtnAvaliable);
            this.uiPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel4.FillColor = System.Drawing.Color.White;
            this.uiPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel4.Location = new System.Drawing.Point(8, 32);
            this.uiPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel4.Name = "uiPanel4";
            this.uiPanel4.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel4.Size = new System.Drawing.Size(420, 44);
            this.uiPanel4.TabIndex = 0;
            this.uiPanel4.Text = null;
            this.uiPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtnMaintenace
            // 
            this.rbtnMaintenace.AutoSize = true;
            this.rbtnMaintenace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnMaintenace.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtnMaintenace.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMaintenace.Location = new System.Drawing.Point(166, 0);
            this.rbtnMaintenace.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbtnMaintenace.Name = "rbtnMaintenace";
            this.rbtnMaintenace.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.rbtnMaintenace.Size = new System.Drawing.Size(182, 44);
            this.rbtnMaintenace.TabIndex = 3;
            this.rbtnMaintenace.Text = "Under maintenance";
            // 
            // rbtnClosed
            // 
            this.rbtnClosed.AutoSize = true;
            this.rbtnClosed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnClosed.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtnClosed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnClosed.Location = new System.Drawing.Point(62, 0);
            this.rbtnClosed.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbtnClosed.Name = "rbtnClosed";
            this.rbtnClosed.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.rbtnClosed.Size = new System.Drawing.Size(104, 44);
            this.rbtnClosed.TabIndex = 2;
            this.rbtnClosed.Text = "Closed";
            // 
            // rbtnAvaliable
            // 
            this.rbtnAvaliable.Checked = true;
            this.rbtnAvaliable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnAvaliable.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtnAvaliable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAvaliable.Location = new System.Drawing.Point(0, 0);
            this.rbtnAvaliable.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbtnAvaliable.Name = "rbtnAvaliable";
            this.rbtnAvaliable.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.rbtnAvaliable.Size = new System.Drawing.Size(62, 44);
            this.rbtnAvaliable.TabIndex = 1;
            this.rbtnAvaliable.Text = "Avaliable";
            // 
            // pnlTotalSlot
            // 
            this.pnlTotalSlot.Controls.Add(this.uiGroupBox4);
            this.pnlTotalSlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalSlot.FillColor = System.Drawing.Color.White;
            this.pnlTotalSlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlTotalSlot.Location = new System.Drawing.Point(300, 94);
            this.pnlTotalSlot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTotalSlot.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlTotalSlot.Name = "pnlTotalSlot";
            this.pnlTotalSlot.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pnlTotalSlot.Size = new System.Drawing.Size(140, 79);
            this.pnlTotalSlot.TabIndex = 4;
            this.pnlTotalSlot.Text = null;
            this.pnlTotalSlot.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.Controls.Add(this.tbTotalSlot);
            this.uiGroupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox4.FillColor = System.Drawing.Color.White;
            this.uiGroupBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiGroupBox4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.uiGroupBox4.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox4.Name = "uiGroupBox4";
            this.uiGroupBox4.Padding = new System.Windows.Forms.Padding(8, 32, 8, 4);
            this.uiGroupBox4.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiGroupBox4.Size = new System.Drawing.Size(140, 79);
            this.uiGroupBox4.TabIndex = 0;
            this.uiGroupBox4.Text = "Total slot";
            this.uiGroupBox4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbTotalSlot
            // 
            this.tbTotalSlot.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTotalSlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTotalSlot.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalSlot.Location = new System.Drawing.Point(8, 32);
            this.tbTotalSlot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTotalSlot.MaximumSize = new System.Drawing.Size(0, 34);
            this.tbTotalSlot.MinimumSize = new System.Drawing.Size(0, 34);
            this.tbTotalSlot.Name = "tbTotalSlot";
            this.tbTotalSlot.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.tbTotalSlot.RectColor = System.Drawing.SystemColors.ControlDark;
            this.tbTotalSlot.RectSize = 2;
            this.tbTotalSlot.ShowText = false;
            this.tbTotalSlot.Size = new System.Drawing.Size(124, 34);
            this.tbTotalSlot.TabIndex = 0;
            this.tbTotalSlot.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbTotalSlot.Watermark = "";
            // 
            // uiTableLayoutPanel1
            // 
            this.uiTableLayoutPanel1.ColumnCount = 1;
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel1.Controls.Add(this.uiPanel7, 0, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.uiPanel5, 0, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.uiPanel1, 0, 1);
            this.uiTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            this.uiTableLayoutPanel1.RowCount = 3;
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.uiTableLayoutPanel1.Size = new System.Drawing.Size(904, 396);
            this.uiTableLayoutPanel1.TabIndex = 1;
            this.uiTableLayoutPanel1.TagString = null;
            // 
            // uiPanel7
            // 
            this.uiPanel7.Controls.Add(this.uiTableLayoutPanel3);
            this.uiPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel7.FillColor = System.Drawing.Color.White;
            this.uiPanel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel7.Location = new System.Drawing.Point(4, 337);
            this.uiPanel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel7.Name = "uiPanel7";
            this.uiPanel7.Padding = new System.Windows.Forms.Padding(0, 13, 0, 3);
            this.uiPanel7.Radius = 0;
            this.uiPanel7.RectColor = System.Drawing.SystemColors.ControlLight;
            this.uiPanel7.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top;
            this.uiPanel7.RectSize = 2;
            this.uiPanel7.Size = new System.Drawing.Size(896, 54);
            this.uiPanel7.TabIndex = 19;
            this.uiPanel7.Text = null;
            this.uiPanel7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTableLayoutPanel3
            // 
            this.uiTableLayoutPanel3.ColumnCount = 4;
            this.uiTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.uiTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.uiTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.uiTableLayoutPanel3.Controls.Add(this.btnAddSlot, 1, 0);
            this.uiTableLayoutPanel3.Controls.Add(this.btnSave, 3, 0);
            this.uiTableLayoutPanel3.Controls.Add(this.btnCancel, 2, 0);
            this.uiTableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel3.Location = new System.Drawing.Point(0, 13);
            this.uiTableLayoutPanel3.Name = "uiTableLayoutPanel3";
            this.uiTableLayoutPanel3.RowCount = 1;
            this.uiTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel3.Size = new System.Drawing.Size(896, 38);
            this.uiTableLayoutPanel3.TabIndex = 0;
            this.uiTableLayoutPanel3.TagString = null;
            // 
            // btnAddSlot
            // 
            this.btnAddSlot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddSlot.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnAddSlot.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(91)))), ((int)(((byte)(17)))));
            this.btnAddSlot.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnAddSlot.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSlot.Location = new System.Drawing.Point(511, 0);
            this.btnAddSlot.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnAddSlot.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddSlot.Name = "btnAddSlot";
            this.btnAddSlot.Radius = 10;
            this.btnAddSlot.RectColor = System.Drawing.Color.White;
            this.btnAddSlot.RectDisableColor = System.Drawing.Color.White;
            this.btnAddSlot.RectHoverColor = System.Drawing.Color.White;
            this.btnAddSlot.RectPressColor = System.Drawing.Color.White;
            this.btnAddSlot.RectSelectedColor = System.Drawing.Color.White;
            this.btnAddSlot.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnAddSlot.Size = new System.Drawing.Size(120, 38);
            this.btnAddSlot.Symbol = 61694;
            this.btnAddSlot.SymbolSize = 20;
            this.btnAddSlot.TabIndex = 7;
            this.btnAddSlot.Text = "New slot";
            this.btnAddSlot.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSlot.Click += new System.EventHandler(this.btnAddSlot_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnSave.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(91)))), ((int)(((byte)(17)))));
            this.btnSave.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(771, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Radius = 10;
            this.btnSave.RectColor = System.Drawing.Color.White;
            this.btnSave.RectDisableColor = System.Drawing.Color.White;
            this.btnSave.RectHoverColor = System.Drawing.Color.White;
            this.btnSave.RectPressColor = System.Drawing.Color.White;
            this.btnSave.RectSelectedColor = System.Drawing.Color.White;
            this.btnSave.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnSave.Size = new System.Drawing.Size(120, 38);
            this.btnSave.Symbol = 557715;
            this.btnSave.SymbolSize = 20;
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.FillColor = System.Drawing.Color.White;
            this.btnCancel.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(91)))), ((int)(((byte)(17)))));
            this.btnCancel.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCancel.Location = new System.Drawing.Point(641, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RectColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancel.RectDisableColor = System.Drawing.Color.White;
            this.btnCancel.RectHoverColor = System.Drawing.Color.White;
            this.btnCancel.RectPressColor = System.Drawing.Color.White;
            this.btnCancel.RectSelectedColor = System.Drawing.Color.White;
            this.btnCancel.RectSize = 2;
            this.btnCancel.Size = new System.Drawing.Size(120, 38);
            this.btnCancel.Symbol = 61453;
            this.btnCancel.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // uiPanel5
            // 
            this.uiPanel5.Controls.Add(this.uiPanel6);
            this.uiPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel5.FillColor = System.Drawing.Color.White;
            this.uiPanel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel5.Location = new System.Drawing.Point(4, 5);
            this.uiPanel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel5.Name = "uiPanel5";
            this.uiPanel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel5.Radius = 0;
            this.uiPanel5.RectColor = System.Drawing.SystemColors.ControlLight;
            this.uiPanel5.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiPanel5.RectSize = 2;
            this.uiPanel5.Size = new System.Drawing.Size(896, 44);
            this.uiPanel5.TabIndex = 17;
            this.uiPanel5.Text = null;
            this.uiPanel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel6
            // 
            this.uiPanel6.Controls.Add(this.uiSymbolLabel1);
            this.uiPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel6.FillColor = System.Drawing.Color.White;
            this.uiPanel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel6.Location = new System.Drawing.Point(0, 0);
            this.uiPanel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiPanel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel6.Name = "uiPanel6";
            this.uiPanel6.Padding = new System.Windows.Forms.Padding(0, 2, 0, 10);
            this.uiPanel6.Radius = 0;
            this.uiPanel6.RectColor = System.Drawing.SystemColors.ControlLight;
            this.uiPanel6.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel6.RectSize = 2;
            this.uiPanel6.Size = new System.Drawing.Size(896, 42);
            this.uiPanel6.TabIndex = 5;
            this.uiPanel6.Text = null;
            this.uiPanel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(0, 2);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Size = new System.Drawing.Size(896, 30);
            this.uiSymbolLabel1.Symbol = 561417;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.uiSymbolLabel1.SymbolSize = 32;
            this.uiSymbolLabel1.TabIndex = 1;
            this.uiSymbolLabel1.Text = "Area details";
            this.uiSymbolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AreaDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(924, 416);
            this.Controls.Add(this.uiTableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(940, 455);
            this.Name = "AreaDetailForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Area Details Form";
            this.Load += new System.EventHandler(this.AreaDetailForm_Load);
            this.uiPanel1.ResumeLayout(false);
            this.uiTableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableSlot)).EndInit();
            this.uiPanel3.ResumeLayout(false);
            this.pnlInformation.ResumeLayout(false);
            this.pnlType.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.pnlVehical.ResumeLayout(false);
            this.uiGroupBox3.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.uiGroupBox6.ResumeLayout(false);
            this.uiPanel4.ResumeLayout(false);
            this.uiPanel4.PerformLayout();
            this.pnlTotalSlot.ResumeLayout(false);
            this.uiGroupBox4.ResumeLayout(false);
            this.uiTableLayoutPanel1.ResumeLayout(false);
            this.uiPanel7.ResumeLayout(false);
            this.uiTableLayoutPanel3.ResumeLayout(false);
            this.uiPanel5.ResumeLayout(false);
            this.uiPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UIPanel uiPanel5;
        private Sunny.UI.UIPanel uiPanel6;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel2;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UITableLayoutPanel pnlInformation;
        private Sunny.UI.UIPanel pnlType;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UIComboBox cbUserType;
        private Sunny.UI.UIPanel pnlVehical;
        private Sunny.UI.UIGroupBox uiGroupBox3;
        private Sunny.UI.UIComboBox cbVehicalType;
        private Sunny.UI.UIPanel pnlStatus;
        private Sunny.UI.UIGroupBox uiGroupBox6;
        private Sunny.UI.UIPanel uiPanel4;
        private Sunny.UI.UIRadioButton rbtnMaintenace;
        private Sunny.UI.UIRadioButton rbtnClosed;
        private Sunny.UI.UIRadioButton rbtnAvaliable;
        private Sunny.UI.UIPanel pnlTotalSlot;
        private Sunny.UI.UIGroupBox uiGroupBox4;
        private Sunny.UI.UITextBox tbTotalSlot;
        private System.Windows.Forms.DataGridView tableSlot;
        private Sunny.UI.UIPanel uiPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colAction;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private Sunny.UI.UIPanel uiPanel7;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel3;
        private Sunny.UI.UISymbolButton btnSave;
        private Sunny.UI.UISymbolButton btnCancel;
        private Sunny.UI.UISymbolButton btnAddSlot;
    }
}