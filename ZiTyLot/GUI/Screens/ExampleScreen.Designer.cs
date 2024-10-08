using System.Windows.Forms;

namespace ZiTyLot.GUI.Screens
{
    partial class ExampleScreen
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TopPnl = new System.Windows.Forms.Panel();
            this.tabpanePnl = new System.Windows.Forms.Panel();
            this.checkOutBtn = new System.Windows.Forms.RadioButton();
            this.checkInBtn = new System.Windows.Forms.RadioButton();
            this.allBtn = new System.Windows.Forms.RadioButton();
            this.searchPnl = new System.Windows.Forms.Panel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.filterPnl = new Sunny.UI.UIPanel();
            this.filterCb = new Sunny.UI.UIComboBox();
            this.buttonsPnl = new System.Windows.Forms.Panel();
            this.addBtn = new Sunny.UI.UISymbolButton();
            this.separator = new System.Windows.Forms.Panel();
            this.BottomPnl = new System.Windows.Forms.Panel();
            this.table = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailButtonCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.viewAction = new System.Windows.Forms.DataGridViewImageColumn();
            this.editAction = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteAction = new System.Windows.Forms.DataGridViewImageColumn();
            this.TopPnl.SuspendLayout();
            this.tabpanePnl.SuspendLayout();
            this.searchPnl.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.filterPnl.SuspendLayout();
            this.buttonsPnl.SuspendLayout();
            this.BottomPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPnl
            // 
            this.TopPnl.BackColor = System.Drawing.Color.White;
            this.TopPnl.Controls.Add(this.tabpanePnl);
            this.TopPnl.Controls.Add(this.searchPnl);
            this.TopPnl.Controls.Add(this.filterPnl);
            this.TopPnl.Controls.Add(this.buttonsPnl);
            this.TopPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPnl.Location = new System.Drawing.Point(0, 0);
            this.TopPnl.Name = "TopPnl";
            this.TopPnl.Padding = new System.Windows.Forms.Padding(10);
            this.TopPnl.Size = new System.Drawing.Size(1151, 54);
            this.TopPnl.TabIndex = 1;
            this.TopPnl.Resize += new System.EventHandler(this.TopPnl_Resize);
            // 
            // tabpanePnl
            // 
            this.tabpanePnl.Controls.Add(this.checkOutBtn);
            this.tabpanePnl.Controls.Add(this.checkInBtn);
            this.tabpanePnl.Controls.Add(this.allBtn);
            this.tabpanePnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabpanePnl.Location = new System.Drawing.Point(10, 10);
            this.tabpanePnl.Name = "tabpanePnl";
            this.tabpanePnl.Size = new System.Drawing.Size(491, 34);
            this.tabpanePnl.TabIndex = 8;
            // 
            // checkOutBtn
            // 
            this.checkOutBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkOutBtn.AutoSize = true;
            this.checkOutBtn.BackColor = System.Drawing.Color.White;
            this.checkOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkOutBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkOutBtn.FlatAppearance.BorderSize = 0;
            this.checkOutBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.checkOutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.checkOutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.checkOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkOutBtn.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.checkOutBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_CheckOut;
            this.checkOutBtn.Location = new System.Drawing.Point(226, 0);
            this.checkOutBtn.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.checkOutBtn.MinimumSize = new System.Drawing.Size(110, 34);
            this.checkOutBtn.Name = "checkOutBtn";
            this.checkOutBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.checkOutBtn.Size = new System.Drawing.Size(128, 34);
            this.checkOutBtn.TabIndex = 5;
            this.checkOutBtn.TabStop = true;
            this.checkOutBtn.Text = "Check out";
            this.checkOutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkOutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkOutBtn.UseVisualStyleBackColor = false;
            // 
            // checkInBtn
            // 
            this.checkInBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkInBtn.AutoSize = true;
            this.checkInBtn.BackColor = System.Drawing.Color.White;
            this.checkInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkInBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkInBtn.FlatAppearance.BorderSize = 0;
            this.checkInBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.checkInBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.checkInBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.checkInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkInBtn.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.checkInBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_CheckIn;
            this.checkInBtn.Location = new System.Drawing.Point(110, 0);
            this.checkInBtn.Margin = new System.Windows.Forms.Padding(0);
            this.checkInBtn.MinimumSize = new System.Drawing.Size(110, 34);
            this.checkInBtn.Name = "checkInBtn";
            this.checkInBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.checkInBtn.Size = new System.Drawing.Size(116, 34);
            this.checkInBtn.TabIndex = 4;
            this.checkInBtn.TabStop = true;
            this.checkInBtn.Text = "Check in";
            this.checkInBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkInBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkInBtn.UseVisualStyleBackColor = false;
            // 
            // allBtn
            // 
            this.allBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.allBtn.AutoSize = true;
            this.allBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.allBtn.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.allBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.allBtn.FlatAppearance.BorderSize = 0;
            this.allBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.allBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.allBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.allBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allBtn.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allBtn.ForeColor = System.Drawing.Color.White;
            this.allBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_All_Active;
            this.allBtn.Location = new System.Drawing.Point(0, 0);
            this.allBtn.Margin = new System.Windows.Forms.Padding(0);
            this.allBtn.MinimumSize = new System.Drawing.Size(110, 34);
            this.allBtn.Name = "allBtn";
            this.allBtn.Size = new System.Drawing.Size(110, 34);
            this.allBtn.TabIndex = 3;
            this.allBtn.TabStop = true;
            this.allBtn.Text = "  All";
            this.allBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.allBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.allBtn.UseVisualStyleBackColor = false;
            // 
            // searchPnl
            // 
            this.searchPnl.BackColor = System.Drawing.Color.White;
            this.searchPnl.Controls.Add(this.uiPanel1);
            this.searchPnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchPnl.Location = new System.Drawing.Point(491, 10);
            this.searchPnl.Name = "searchPnl";
            this.searchPnl.Size = new System.Drawing.Size(400, 34);
            this.searchPnl.TabIndex = 6;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.pictureBox2);
            this.uiPanel1.Controls.Add(this.uiTextBox1);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.FillColor = System.Drawing.Color.White;
            this.uiPanel1.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Radius = 14;
            this.uiPanel1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.uiPanel1.RectDisableColor = System.Drawing.Color.White;
            this.uiPanel1.RectSize = 2;
            this.uiPanel1.Size = new System.Drawing.Size(400, 34);
            this.uiPanel1.TabIndex = 1;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Magnifying;
            this.pictureBox2.Location = new System.Drawing.Point(360, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.uiTextBox1.IconSize = 18;
            this.uiTextBox1.Location = new System.Drawing.Point(8, 4);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.uiTextBox1.MaximumSize = new System.Drawing.Size(350, 26);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.uiTextBox1.Radius = 14;
            this.uiTextBox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.uiTextBox1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(350, 26);
            this.uiTextBox1.TabIndex = 0;
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "";
            // 
            // filterPnl
            // 
            this.filterPnl.Controls.Add(this.filterCb);
            this.filterPnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.filterPnl.FillColor = System.Drawing.Color.White;
            this.filterPnl.FillColor2 = System.Drawing.Color.White;
            this.filterPnl.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterPnl.Location = new System.Drawing.Point(891, 10);
            this.filterPnl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filterPnl.MinimumSize = new System.Drawing.Size(1, 1);
            this.filterPnl.Name = "filterPnl";
            this.filterPnl.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.filterPnl.Radius = 14;
            this.filterPnl.RectColor = System.Drawing.Color.White;
            this.filterPnl.RectDisableColor = System.Drawing.Color.White;
            this.filterPnl.RectSize = 2;
            this.filterPnl.Size = new System.Drawing.Size(130, 34);
            this.filterPnl.TabIndex = 1;
            this.filterPnl.Text = null;
            this.filterPnl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filterCb
            // 
            this.filterCb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterCb.DataSource = null;
            this.filterCb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterCb.DropDownWidth = 120;
            this.filterCb.FillColor = System.Drawing.Color.White;
            this.filterCb.FillColor2 = System.Drawing.Color.White;
            this.filterCb.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.filterCb.ItemHeight = 24;
            this.filterCb.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            this.filterCb.ItemRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.filterCb.Items.AddRange(new object[] {
            "Hello",
            "Hi",
            "3"});
            this.filterCb.ItemSelectBackColor = System.Drawing.Color.White;
            this.filterCb.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.filterCb.Location = new System.Drawing.Point(10, 0);
            this.filterCb.Margin = new System.Windows.Forms.Padding(0);
            this.filterCb.MinimumSize = new System.Drawing.Size(63, 0);
            this.filterCb.Name = "filterCb";
            this.filterCb.Padding = new System.Windows.Forms.Padding(20, 0, 30, 2);
            this.filterCb.Radius = 2;
            this.filterCb.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.filterCb.RectSize = 2;
            this.filterCb.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.filterCb.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.filterCb.ScrollBarStyleInherited = false;
            this.filterCb.Size = new System.Drawing.Size(120, 34);
            this.filterCb.Style = Sunny.UI.UIStyle.Custom;
            this.filterCb.SymbolDropDown = 560247;
            this.filterCb.SymbolNormal = 557682;
            this.filterCb.SymbolSize = 24;
            this.filterCb.TabIndex = 1;
            this.filterCb.Text = "Filter";
            this.filterCb.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.filterCb.Watermark = "";
            // 
            // buttonsPnl
            // 
            this.buttonsPnl.Controls.Add(this.addBtn);
            this.buttonsPnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonsPnl.Location = new System.Drawing.Point(1021, 10);
            this.buttonsPnl.Name = "buttonsPnl";
            this.buttonsPnl.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonsPnl.Size = new System.Drawing.Size(120, 34);
            this.buttonsPnl.TabIndex = 7;
            // 
            // addBtn
            // 
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.addBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.addBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(91)))), ((int)(((byte)(17)))));
            this.addBtn.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.addBtn.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Plus;
            this.addBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.Location = new System.Drawing.Point(10, 0);
            this.addBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.addBtn.Name = "addBtn";
            this.addBtn.Padding = new System.Windows.Forms.Padding(20, 0, 22, 0);
            this.addBtn.Radius = 14;
            this.addBtn.RectColor = System.Drawing.Color.White;
            this.addBtn.RectDisableColor = System.Drawing.Color.White;
            this.addBtn.RectHoverColor = System.Drawing.Color.White;
            this.addBtn.RectPressColor = System.Drawing.Color.White;
            this.addBtn.RectSelectedColor = System.Drawing.Color.White;
            this.addBtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.addBtn.RectSize = 2;
            this.addBtn.Size = new System.Drawing.Size(110, 34);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "New";
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBtn.TipsFont = new System.Drawing.Font("Helvetica Rounded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // BottomPnl
            // 
            this.BottomPnl.BackColor = System.Drawing.Color.White;
            this.BottomPnl.Controls.Add(this.table);
            this.BottomPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomPnl.Location = new System.Drawing.Point(0, 58);
            this.BottomPnl.Margin = new System.Windows.Forms.Padding(0);
            this.BottomPnl.Name = "BottomPnl";
            this.BottomPnl.Padding = new System.Windows.Forms.Padding(10);
            this.BottomPnl.Size = new System.Drawing.Size(1151, 447);
            this.BottomPnl.TabIndex = 3;
            this.BottomPnl.Resize += new System.EventHandler(this.BottomPnl_Resize);
            // 
            // table
            // 
            this.table.AllowUserToDeleteRows = false;
            this.table.BackgroundColor = System.Drawing.Color.White;
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.type,
            this.plate,
            this.checkIn,
            this.checkOut,
            this.totalTime,
            this.totalPrice,
            this.detailButtonCol,
            this.viewAction,
            this.editAction,
            this.deleteAction});
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(10, 10);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowTemplate.Height = 30;
            this.table.Size = new System.Drawing.Size(1131, 427);
            this.table.TabIndex = 0;
           
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BottomPnl);
            this.panel2.Controls.Add(this.separator);
            this.panel2.Controls.Add(this.TopPnl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1151, 505);
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
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 30;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 80;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // plate
            // 
            this.plate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.plate.HeaderText = "Plate";
            this.plate.Name = "plate";
            this.plate.ReadOnly = true;
            // 
            // checkIn
            // 
            this.checkIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.checkIn.HeaderText = "Check in time";
            this.checkIn.Name = "checkIn";
            this.checkIn.ReadOnly = true;
            // 
            // checkOut
            // 
            this.checkOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.checkOut.HeaderText = "Check out time";
            this.checkOut.Name = "checkOut";
            this.checkOut.ReadOnly = true;
            // 
            // totalTime
            // 
            this.totalTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalTime.HeaderText = "Total time";
            this.totalTime.MinimumWidth = 100;
            this.totalTime.Name = "totalTime";
            this.totalTime.ReadOnly = true;
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalPrice.HeaderText = "Total Price";
            this.totalPrice.MinimumWidth = 100;
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            // 
            // detailButtonCol
            // 
            this.detailButtonCol.HeaderText = "Action";
            this.detailButtonCol.MinimumWidth = 50;
            this.detailButtonCol.Name = "detailButtonCol";
            this.detailButtonCol.ReadOnly = true;
            this.detailButtonCol.Width = 80;
            // 
            // viewAction
            // 
            this.viewAction.HeaderText = "";
            this.viewAction.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_View;
            this.viewAction.Name = "viewAction";
            this.viewAction.ReadOnly = true;
            // 
            // editAction
            // 
            this.editAction.HeaderText = "";
            this.editAction.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Edit;
            this.editAction.Name = "editAction";
            this.editAction.ReadOnly = true;
            // 
            // deleteAction
            // 
            this.deleteAction.HeaderText = "";
            this.deleteAction.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Delete;
            this.deleteAction.Name = "deleteAction";
            this.deleteAction.ReadOnly = true;
            // Assuming your image resources are correctly set
            this.viewAction.ImageLayout = DataGridViewImageCellLayout.Zoom; // Adjusts the image layout
            this.editAction.ImageLayout = DataGridViewImageCellLayout.Zoom; // Adjusts the image layout
            this.deleteAction.ImageLayout = DataGridViewImageCellLayout.Zoom; // Adjusts the image layout

            // If images are still not showing, try this after adding rows to the DataGridView
            this.table.Rows.Add(1, "Type1", "ABC123", "10:00 AM", "2:00 PM", "4 hours", "$20", null, null, null);
            this.table.Rows[0].Cells["viewAction"].Value = global::ZiTyLot.Properties.Resources.Icon_18x18px_View;
            this.table.Rows[0].Cells["editAction"].Value = global::ZiTyLot.Properties.Resources.Icon_18x18px_Edit;
            this.table.Rows[0].Cells["deleteAction"].Value = global::ZiTyLot.Properties.Resources.Icon_18x18px_Delete;
            // 
            // ExampleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.Name = "ExampleScreen";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1171, 525);
            this.Load += new System.EventHandler(this.ExampleScreen_Load);
            this.TopPnl.ResumeLayout(false);
            this.tabpanePnl.ResumeLayout(false);
            this.tabpanePnl.PerformLayout();
            this.searchPnl.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.filterPnl.ResumeLayout(false);
            this.buttonsPnl.ResumeLayout(false);
            this.BottomPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel TopPnl;
        private System.Windows.Forms.Panel tabpanePnl;
        private System.Windows.Forms.RadioButton checkOutBtn;
        private System.Windows.Forms.RadioButton checkInBtn;
        private System.Windows.Forms.RadioButton allBtn;
        private System.Windows.Forms.Panel searchPnl;
        private Sunny.UI.UIPanel uiPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Sunny.UI.UITextBox uiTextBox1;
        private System.Windows.Forms.Panel buttonsPnl;
        private System.Windows.Forms.Panel separator;
        private System.Windows.Forms.Panel BottomPnl;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UISymbolButton addBtn;
        private System.Windows.Forms.Panel panel5;
        private Sunny.UI.UIPanel filterPnl;
        private Sunny.UI.UIComboBox filterCb;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.DataGridViewButtonColumn detailButtonCol;
        private System.Windows.Forms.DataGridViewImageColumn viewAction;
        private System.Windows.Forms.DataGridViewImageColumn editAction;
        private System.Windows.Forms.DataGridViewImageColumn deleteAction;
    }
}
