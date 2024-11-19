using System.Windows.Forms;

namespace ZiTyLot.GUI.Screens
{
    partial class AccountControl
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.tableTop = new Sunny.UI.UITableLayoutPanel();
            this.btnAdd = new Sunny.UI.UISymbolButton();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.pnlSearch = new Sunny.UI.UIPanel();
            this.tableSearch = new System.Windows.Forms.TableLayoutPanel();
            this.tbSearch = new Sunny.UI.UITextBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.cbFilter = new Sunny.UI.UIComboBox();
            this.separatorTop = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.tableAccount = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.separtorBottom = new System.Windows.Forms.Panel();
            this.pnlPagination = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.cbNumberofitem = new Sunny.UI.UIComboBox();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlNext = new System.Windows.Forms.Panel();
            this.btnNext = new Sunny.UI.UISymbolButton();
            this.pnlCurrentPage = new System.Windows.Forms.Panel();
            this.uiTableLayoutPanel3 = new Sunny.UI.UITableLayoutPanel();
            this.tbCurrentpage = new Sunny.UI.UITextBox();
            this.lbTotalpage = new Sunny.UI.UILabel();
            this.pnlPrevious = new System.Windows.Forms.Panel();
            this.btnPrevious = new Sunny.UI.UISymbolButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.uiTextBox3 = new Sunny.UI.UITextBox();
            this.uiTextBox2 = new Sunny.UI.UITextBox();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.pnlTop.SuspendLayout();
            this.tableTop.SuspendLayout();
            this.uiPanel3.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.tableSearch.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableAccount)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlPagination.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlNext.SuspendLayout();
            this.pnlCurrentPage.SuspendLayout();
            this.uiTableLayoutPanel3.SuspendLayout();
            this.pnlPrevious.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlTop.Size = new System.Drawing.Size(1171, 54);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.Resize += new System.EventHandler(this.TopPnl_Resize);
            // 
            // tableTop
            // 
            this.tableTop.ColumnCount = 2;
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableTop.Controls.Add(this.btnAdd, 1, 0);
            this.tableTop.Controls.Add(this.uiPanel3, 0, 0);
            this.tableTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableTop.Location = new System.Drawing.Point(5, 5);
            this.tableTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableTop.Name = "tableTop";
            this.tableTop.RowCount = 1;
            this.tableTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableTop.Size = new System.Drawing.Size(1161, 44);
            this.tableTop.TabIndex = 0;
            this.tableTop.TagString = null;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnAdd.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(91)))), ((int)(((byte)(17)))));
            this.btnAdd.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(984, 3);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Radius = 10;
            this.btnAdd.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnAdd.RectDisableColor = System.Drawing.Color.White;
            this.btnAdd.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnAdd.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnAdd.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnAdd.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnAdd.Size = new System.Drawing.Size(174, 38);
            this.btnAdd.Symbol = 61694;
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "New account";
            this.btnAdd.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.uiPanel3.Size = new System.Drawing.Size(981, 44);
            this.uiPanel3.TabIndex = 11;
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
            this.pnlSearch.RectColor = System.Drawing.SystemColors.ControlLight;
            this.pnlSearch.RectSize = 2;
            this.pnlSearch.Size = new System.Drawing.Size(400, 38);
            this.pnlSearch.TabIndex = 2;
            this.pnlSearch.Text = null;
            this.pnlSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableSearch
            // 
            this.tableSearch.ColumnCount = 3;
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableSearch.Controls.Add(this.tbSearch, 1, 0);
            this.tableSearch.Controls.Add(this.uiSymbolLabel1, 0, 0);
            this.tableSearch.Controls.Add(this.cbFilter, 2, 0);
            this.tableSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.tableSearch.Location = new System.Drawing.Point(5, 5);
            this.tableSearch.Name = "tableSearch";
            this.tableSearch.RowCount = 1;
            this.tableSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSearch.Size = new System.Drawing.Size(390, 28);
            this.tableSearch.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(32, 0);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tbSearch.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Padding = new System.Windows.Forms.Padding(5);
            this.tbSearch.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.tbSearch.ShowText = false;
            this.tbSearch.Size = new System.Drawing.Size(293, 28);
            this.tbSearch.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.tbSearch.SymbolOffset = new System.Drawing.Point(0, -1);
            this.tbSearch.SymbolSize = 26;
            this.tbSearch.TabIndex = 4;
            this.tbSearch.Tag = "";
            this.tbSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbSearch.Watermark = "Search an account by its";
            this.tbSearch.WatermarkActiveColor = System.Drawing.Color.DarkGray;
            this.tbSearch.WatermarkColor = System.Drawing.Color.LightGray;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(1, 1);
            this.uiSymbolLabel1.Margin = new System.Windows.Forms.Padding(1);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Size = new System.Drawing.Size(30, 26);
            this.uiSymbolLabel1.Symbol = 61442;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.uiSymbolLabel1.SymbolSize = 26;
            this.uiSymbolLabel1.TabIndex = 3;
            // 
            // cbFilter
            // 
            this.cbFilter.DataSource = null;
            this.cbFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbFilter.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.cbFilter.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.cbFilter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.ForeColor = System.Drawing.Color.White;
            this.cbFilter.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbFilter.ItemRectColor = System.Drawing.Color.White;
            this.cbFilter.Items.AddRange(new object[] {
            "  ID",
            "  Full name",
            "  Username",
            "  Email"});
            this.cbFilter.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbFilter.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbFilter.Location = new System.Drawing.Point(325, 0);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(0);
            this.cbFilter.MinimumSize = new System.Drawing.Size(50, 0);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Padding = new System.Windows.Forms.Padding(5, 0, 30, 2);
            this.cbFilter.RectColor = System.Drawing.Color.White;
            this.cbFilter.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbFilter.RectSize = 2;
            this.cbFilter.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.cbFilter.ScrollBarStyleInherited = false;
            this.cbFilter.Size = new System.Drawing.Size(65, 28);
            this.cbFilter.Style = Sunny.UI.UIStyle.Custom;
            this.cbFilter.SymbolSize = 24;
            this.cbFilter.TabIndex = 2;
            this.cbFilter.Text = "  ID";
            this.cbFilter.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbFilter.TrimFilter = true;
            this.cbFilter.Watermark = "";
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // separatorTop
            // 
            this.separatorTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.separatorTop.Location = new System.Drawing.Point(0, 54);
            this.separatorTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.separatorTop.MaximumSize = new System.Drawing.Size(2160, 5);
            this.separatorTop.Name = "separatorTop";
            this.separatorTop.Size = new System.Drawing.Size(1171, 4);
            this.separatorTop.TabIndex = 2;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.Controls.Add(this.tableAccount);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 58);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.pnlBottom.Size = new System.Drawing.Size(1171, 436);
            this.pnlBottom.TabIndex = 3;
            this.pnlBottom.Resize += new System.EventHandler(this.BottomPnl_Resize);
            // 
            // tableAccount
            // 
            this.tableAccount.AllowUserToAddRows = false;
            this.tableAccount.AllowUserToDeleteRows = false;
            this.tableAccount.AllowUserToResizeColumns = false;
            this.tableAccount.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(114)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.tableAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableAccount.BackgroundColor = System.Drawing.Color.White;
            this.tableAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableAccount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableAccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableAccount.ColumnHeadersHeight = 40;
            this.tableAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colFullname,
            this.colUsername,
            this.colEmail,
            this.colRole,
            this.colView,
            this.colDelete});
            this.tableAccount.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(114)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableAccount.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableAccount.GridColor = System.Drawing.Color.White;
            this.tableAccount.Location = new System.Drawing.Point(10, 10);
            this.tableAccount.Margin = new System.Windows.Forms.Padding(0);
            this.tableAccount.Name = "tableAccount";
            this.tableAccount.ReadOnly = true;
            this.tableAccount.RowHeadersVisible = false;
            this.tableAccount.RowHeadersWidth = 30;
            this.tableAccount.RowTemplate.Height = 40;
            this.tableAccount.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tableAccount.Size = new System.Drawing.Size(1151, 416);
            this.tableAccount.TabIndex = 1;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colFullname
            // 
            this.colFullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFullname.HeaderText = "Full name";
            this.colFullname.MinimumWidth = 80;
            this.colFullname.Name = "colFullname";
            this.colFullname.ReadOnly = true;
            this.colFullname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colUsername
            // 
            this.colUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUsername.HeaderText = "Username";
            this.colUsername.MinimumWidth = 6;
            this.colUsername.Name = "colUsername";
            this.colUsername.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colRole
            // 
            this.colRole.HeaderText = "Role";
            this.colRole.MinimumWidth = 6;
            this.colRole.Name = "colRole";
            this.colRole.ReadOnly = true;
            this.colRole.Width = 200;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlBottom);
            this.panel2.Controls.Add(this.separtorBottom);
            this.panel2.Controls.Add(this.pnlPagination);
            this.panel2.Controls.Add(this.separatorTop);
            this.panel2.Controls.Add(this.pnlTop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1171, 552);
            this.panel2.TabIndex = 2;
            // 
            // separtorBottom
            // 
            this.separtorBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separtorBottom.Location = new System.Drawing.Point(0, 494);
            this.separtorBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.separtorBottom.MaximumSize = new System.Drawing.Size(2160, 5);
            this.separtorBottom.Name = "separtorBottom";
            this.separtorBottom.Size = new System.Drawing.Size(1171, 4);
            this.separtorBottom.TabIndex = 6;
            // 
            // pnlPagination
            // 
            this.pnlPagination.BackColor = System.Drawing.Color.White;
            this.pnlPagination.Controls.Add(this.pnlLeft);
            this.pnlPagination.Controls.Add(this.pnlRight);
            this.pnlPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPagination.Location = new System.Drawing.Point(0, 498);
            this.pnlPagination.Name = "pnlPagination";
            this.pnlPagination.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.pnlPagination.Size = new System.Drawing.Size(1171, 54);
            this.pnlPagination.TabIndex = 5;
            this.pnlPagination.Resize += new System.EventHandler(this.pnlPagination_Resize);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.uiPanel2);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(10, 5);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(140, 44);
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
            this.uiPanel2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.uiPanel2.RectDisableColor = System.Drawing.Color.White;
            this.uiPanel2.RectSize = 2;
            this.uiPanel2.Size = new System.Drawing.Size(140, 44);
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
            this.cbNumberofitem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNumberofitem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.cbNumberofitem.ItemHeight = 24;
            this.cbNumberofitem.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            this.cbNumberofitem.ItemRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
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
            this.cbNumberofitem.Size = new System.Drawing.Size(120, 44);
            this.cbNumberofitem.Style = Sunny.UI.UIStyle.Custom;
            this.cbNumberofitem.SymbolDropDown = 560247;
            this.cbNumberofitem.SymbolNormal = 557682;
            this.cbNumberofitem.SymbolSize = 24;
            this.cbNumberofitem.TabIndex = 1;
            this.cbNumberofitem.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbNumberofitem.Watermark = "";
            this.cbNumberofitem.SelectedIndexChanged += new System.EventHandler(this.numberofitemsCb_SelectedIndexChanged);
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlNext);
            this.pnlRight.Controls.Add(this.pnlCurrentPage);
            this.pnlRight.Controls.Add(this.pnlPrevious);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(993, 5);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(168, 44);
            this.pnlRight.TabIndex = 1;
            // 
            // pnlNext
            // 
            this.pnlNext.Controls.Add(this.btnNext);
            this.pnlNext.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNext.Location = new System.Drawing.Point(126, 0);
            this.pnlNext.Name = "pnlNext";
            this.pnlNext.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.pnlNext.Size = new System.Drawing.Size(40, 44);
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
            this.btnNext.Size = new System.Drawing.Size(34, 38);
            this.btnNext.TabIndex = 4;
            this.btnNext.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pnlCurrentPage
            // 
            this.pnlCurrentPage.Controls.Add(this.uiTableLayoutPanel3);
            this.pnlCurrentPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCurrentPage.Location = new System.Drawing.Point(40, 0);
            this.pnlCurrentPage.Name = "pnlCurrentPage";
            this.pnlCurrentPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.pnlCurrentPage.Size = new System.Drawing.Size(86, 44);
            this.pnlCurrentPage.TabIndex = 2;
            // 
            // uiTableLayoutPanel3
            // 
            this.uiTableLayoutPanel3.ColumnCount = 2;
            this.uiTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel3.Controls.Add(this.tbCurrentpage, 0, 0);
            this.uiTableLayoutPanel3.Controls.Add(this.lbTotalpage, 1, 0);
            this.uiTableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.uiTableLayoutPanel3.Name = "uiTableLayoutPanel3";
            this.uiTableLayoutPanel3.RowCount = 1;
            this.uiTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel3.Size = new System.Drawing.Size(80, 38);
            this.uiTableLayoutPanel3.TabIndex = 0;
            this.uiTableLayoutPanel3.TagString = null;
            // 
            // tbCurrentpage
            // 
            this.tbCurrentpage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCurrentpage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCurrentpage.DoubleValue = 1D;
            this.tbCurrentpage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentpage.IntValue = 1;
            this.tbCurrentpage.Location = new System.Drawing.Point(0, 0);
            this.tbCurrentpage.Margin = new System.Windows.Forms.Padding(0);
            this.tbCurrentpage.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbCurrentpage.Name = "tbCurrentpage";
            this.tbCurrentpage.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbCurrentpage.Radius = 0;
            this.tbCurrentpage.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.tbCurrentpage.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.tbCurrentpage.RectSize = 2;
            this.tbCurrentpage.ShowText = false;
            this.tbCurrentpage.Size = new System.Drawing.Size(40, 38);
            this.tbCurrentpage.TabIndex = 0;
            this.tbCurrentpage.Text = "1";
            this.tbCurrentpage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tbCurrentpage.Watermark = "";
            this.tbCurrentpage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCurrentpage_KeyPress);
            // 
            // lbTotalpage
            // 
            this.lbTotalpage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTotalpage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalpage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.lbTotalpage.Location = new System.Drawing.Point(40, 0);
            this.lbTotalpage.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.lbTotalpage.Name = "lbTotalpage";
            this.lbTotalpage.Size = new System.Drawing.Size(40, 36);
            this.lbTotalpage.TabIndex = 1;
            this.lbTotalpage.Text = "/100";
            this.lbTotalpage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPrevious
            // 
            this.pnlPrevious.Controls.Add(this.btnPrevious);
            this.pnlPrevious.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPrevious.Location = new System.Drawing.Point(0, 0);
            this.pnlPrevious.Name = "pnlPrevious";
            this.pnlPrevious.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.pnlPrevious.Size = new System.Drawing.Size(40, 44);
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
            this.btnPrevious.Size = new System.Drawing.Size(34, 38);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
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
            // uiTextBox3
            // 
            this.uiTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTextBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiTextBox3.Location = new System.Drawing.Point(8, 32);
            this.uiTextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox3.MaximumSize = new System.Drawing.Size(0, 34);
            this.uiTextBox3.MinimumSize = new System.Drawing.Size(0, 34);
            this.uiTextBox3.Name = "uiTextBox3";
            this.uiTextBox3.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.uiTextBox3.Radius = 10;
            this.uiTextBox3.RectColor = System.Drawing.SystemColors.ControlDark;
            this.uiTextBox3.RectSize = 2;
            this.uiTextBox3.ShowText = false;
            this.uiTextBox3.Size = new System.Drawing.Size(199, 34);
            this.uiTextBox3.TabIndex = 0;
            this.uiTextBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox3.Watermark = "";
            // 
            // uiTextBox2
            // 
            this.uiTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTextBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiTextBox2.Location = new System.Drawing.Point(8, 32);
            this.uiTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox2.MaximumSize = new System.Drawing.Size(0, 34);
            this.uiTextBox2.MinimumSize = new System.Drawing.Size(0, 34);
            this.uiTextBox2.Name = "uiTextBox2";
            this.uiTextBox2.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.uiTextBox2.Radius = 10;
            this.uiTextBox2.RectColor = System.Drawing.SystemColors.ControlDark;
            this.uiTextBox2.RectSize = 2;
            this.uiTextBox2.ShowText = false;
            this.uiTextBox2.Size = new System.Drawing.Size(199, 34);
            this.uiTextBox2.TabIndex = 0;
            this.uiTextBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox2.Watermark = "";
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTextBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiTextBox1.Location = new System.Drawing.Point(8, 32);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MaximumSize = new System.Drawing.Size(0, 34);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(0, 34);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.uiTextBox1.Radius = 10;
            this.uiTextBox1.RectColor = System.Drawing.SystemColors.ControlDark;
            this.uiTextBox1.RectSize = 2;
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(199, 34);
            this.uiTextBox1.TabIndex = 0;
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "";
            // 
            // AccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.Name = "AccountControl";
            this.Size = new System.Drawing.Size(1171, 552);
            this.Load += new System.EventHandler(this.AccountScreen_Load);
            this.pnlTop.ResumeLayout(false);
            this.tableTop.ResumeLayout(false);
            this.uiPanel3.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.tableSearch.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableAccount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlPagination.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlNext.ResumeLayout(false);
            this.pnlCurrentPage.ResumeLayout(false);
            this.uiTableLayoutPanel3.ResumeLayout(false);
            this.pnlPrevious.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel separatorTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private DataGridView tableAccount;
        private Timer timer1;
        private Sunny.UI.UITableLayoutPanel tableTop;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIPanel pnlSearch;
        private Sunny.UI.UITextBox uiTextBox3;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UITextBox uiTextBox1;
        private TableLayoutPanel tableSearch;
        private Sunny.UI.UIComboBox cbFilter;
        private Panel pnlPagination;
        private Panel pnlLeft;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIComboBox cbNumberofitem;
        private Panel pnlRight;
        private Panel pnlNext;
        private Sunny.UI.UISymbolButton btnNext;
        private Panel pnlCurrentPage;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel3;
        private Sunny.UI.UITextBox tbCurrentpage;
        private Sunny.UI.UILabel lbTotalpage;
        private Panel pnlPrevious;
        private Sunny.UI.UISymbolButton btnPrevious;
        private Panel separtorBottom;
        private Sunny.UI.UISymbolButton btnAdd;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UITextBox tbSearch;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colFullname;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colRole;
        private DataGridViewButtonColumn colView;
        private DataGridViewButtonColumn colDelete;
    }
}
