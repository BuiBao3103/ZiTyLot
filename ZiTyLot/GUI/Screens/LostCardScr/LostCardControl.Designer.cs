﻿namespace ZiTyLot.GUI.Screens.LostCardScr
{
    partial class LostCardControl
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.tableLostCard = new System.Windows.Forms.DataGridView();
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
            this.separator = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.tableTop = new Sunny.UI.UITableLayoutPanel();
            this.btnFilter = new Sunny.UI.UISymbolButton();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.pnlSearch = new Sunny.UI.UIPanel();
            this.tableSearch = new System.Windows.Forms.TableLayoutPanel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.cbFilter = new Sunny.UI.UIComboBox();
            this.tbSearch = new Sunny.UI.UITextBox();
            this.uiPanel4 = new Sunny.UI.UIPanel();
            this.uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            this.btnClear = new Sunny.UI.UISymbolButton();
            this.btnApply = new Sunny.UI.UISymbolButton();
            this.uiPanel10 = new Sunny.UI.UIPanel();
            this.uiTableLayoutPanel4 = new Sunny.UI.UITableLayoutPanel();
            this.cbStatus = new Sunny.UI.UIComboBox();
            this.uiPanel8 = new Sunny.UI.UIPanel();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRFID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNationalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRestore = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLostCard)).BeginInit();
            this.pnlPagination.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlNext.SuspendLayout();
            this.pnlCurrentPage.SuspendLayout();
            this.uiTableLayoutPanel3.SuspendLayout();
            this.pnlPrevious.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.tableTop.SuspendLayout();
            this.uiPanel3.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.tableSearch.SuspendLayout();
            this.uiPanel4.SuspendLayout();
            this.uiTableLayoutPanel1.SuspendLayout();
            this.uiPanel10.SuspendLayout();
            this.uiTableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlBottom);
            this.panel2.Controls.Add(this.separtorBottom);
            this.panel2.Controls.Add(this.pnlPagination);
            this.panel2.Controls.Add(this.separator);
            this.panel2.Controls.Add(this.pnlTop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1633, 938);
            this.panel2.TabIndex = 3;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.Controls.Add(this.tableLostCard);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 138);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pnlBottom.Size = new System.Drawing.Size(1633, 729);
            this.pnlBottom.TabIndex = 3;
            this.pnlBottom.Resize += new System.EventHandler(this.BottomPnl_Resize);
            // 
            // tableLostCard
            // 
            this.tableLostCard.AllowUserToAddRows = false;
            this.tableLostCard.AllowUserToDeleteRows = false;
            this.tableLostCard.AllowUserToResizeColumns = false;
            this.tableLostCard.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(114)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.tableLostCard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableLostCard.BackgroundColor = System.Drawing.Color.White;
            this.tableLostCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLostCard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableLostCard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableLostCard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableLostCard.ColumnHeadersHeight = 34;
            this.tableLostCard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colRFID,
            this.colFullname,
            this.colNationalID,
            this.cardType,
            this.colStatus,
            this.colRestore});
            this.tableLostCard.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableLostCard.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableLostCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLostCard.GridColor = System.Drawing.Color.White;
            this.tableLostCard.Location = new System.Drawing.Point(13, 12);
            this.tableLostCard.Margin = new System.Windows.Forms.Padding(0);
            this.tableLostCard.Name = "tableLostCard";
            this.tableLostCard.ReadOnly = true;
            this.tableLostCard.RowHeadersVisible = false;
            this.tableLostCard.RowHeadersWidth = 30;
            this.tableLostCard.RowTemplate.Height = 40;
            this.tableLostCard.Size = new System.Drawing.Size(1607, 705);
            this.tableLostCard.TabIndex = 4;
            this.tableLostCard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
            this.tableLostCard.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.table_CellPainting);
            // 
            // separtorBottom
            // 
            this.separtorBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separtorBottom.Location = new System.Drawing.Point(0, 867);
            this.separtorBottom.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.separtorBottom.MaximumSize = new System.Drawing.Size(2880, 6);
            this.separtorBottom.Name = "separtorBottom";
            this.separtorBottom.Size = new System.Drawing.Size(1633, 5);
            this.separtorBottom.TabIndex = 10;
            // 
            // pnlPagination
            // 
            this.pnlPagination.BackColor = System.Drawing.Color.White;
            this.pnlPagination.Controls.Add(this.pnlLeft);
            this.pnlPagination.Controls.Add(this.pnlRight);
            this.pnlPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPagination.Location = new System.Drawing.Point(0, 872);
            this.pnlPagination.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPagination.Name = "pnlPagination";
            this.pnlPagination.Padding = new System.Windows.Forms.Padding(13, 6, 13, 6);
            this.pnlPagination.Size = new System.Drawing.Size(1633, 66);
            this.pnlPagination.TabIndex = 9;
            this.pnlPagination.Resize += new System.EventHandler(this.pnlPagination_Resize);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.uiPanel2);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(13, 6);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(187, 54);
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
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.uiPanel2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.uiPanel2.RectDisableColor = System.Drawing.Color.White;
            this.uiPanel2.RectSize = 2;
            this.uiPanel2.Size = new System.Drawing.Size(187, 54);
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
            this.cbNumberofitem.Location = new System.Drawing.Point(13, 0);
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
            this.cbNumberofitem.Size = new System.Drawing.Size(161, 54);
            this.cbNumberofitem.Style = Sunny.UI.UIStyle.Custom;
            this.cbNumberofitem.SymbolDropDown = 560247;
            this.cbNumberofitem.SymbolNormal = 557682;
            this.cbNumberofitem.SymbolSize = 24;
            this.cbNumberofitem.TabIndex = 1;
            this.cbNumberofitem.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbNumberofitem.Watermark = "";
            this.cbNumberofitem.SelectedIndexChanged += new System.EventHandler(this.cbNumberofitem_SelectedIndexChanged);
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlNext);
            this.pnlRight.Controls.Add(this.pnlCurrentPage);
            this.pnlRight.Controls.Add(this.pnlPrevious);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(1396, 6);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(224, 54);
            this.pnlRight.TabIndex = 1;
            // 
            // pnlNext
            // 
            this.pnlNext.Controls.Add(this.btnNext);
            this.pnlNext.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNext.Location = new System.Drawing.Point(168, 0);
            this.pnlNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlNext.Name = "pnlNext";
            this.pnlNext.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlNext.Size = new System.Drawing.Size(53, 54);
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
            this.btnNext.Location = new System.Drawing.Point(4, 4);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Padding = new System.Windows.Forms.Padding(27, 0, 29, 0);
            this.btnNext.Radius = 4;
            this.btnNext.RectColor = System.Drawing.Color.White;
            this.btnNext.RectDisableColor = System.Drawing.Color.White;
            this.btnNext.RectHoverColor = System.Drawing.Color.White;
            this.btnNext.RectPressColor = System.Drawing.Color.White;
            this.btnNext.RectSelectedColor = System.Drawing.Color.White;
            this.btnNext.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnNext.RectSize = 2;
            this.btnNext.Size = new System.Drawing.Size(45, 46);
            this.btnNext.TabIndex = 4;
            this.btnNext.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pnlCurrentPage
            // 
            this.pnlCurrentPage.Controls.Add(this.uiTableLayoutPanel3);
            this.pnlCurrentPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCurrentPage.Location = new System.Drawing.Point(53, 0);
            this.pnlCurrentPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCurrentPage.Name = "pnlCurrentPage";
            this.pnlCurrentPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCurrentPage.Size = new System.Drawing.Size(115, 54);
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
            this.uiTableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.uiTableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiTableLayoutPanel3.Name = "uiTableLayoutPanel3";
            this.uiTableLayoutPanel3.RowCount = 1;
            this.uiTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel3.Size = new System.Drawing.Size(107, 46);
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
            this.tbCurrentpage.MinimumSize = new System.Drawing.Size(1, 20);
            this.tbCurrentpage.Name = "tbCurrentpage";
            this.tbCurrentpage.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tbCurrentpage.Radius = 0;
            this.tbCurrentpage.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.tbCurrentpage.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.tbCurrentpage.RectSize = 2;
            this.tbCurrentpage.ShowText = false;
            this.tbCurrentpage.Size = new System.Drawing.Size(53, 46);
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
            this.lbTotalpage.Location = new System.Drawing.Point(53, 0);
            this.lbTotalpage.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.lbTotalpage.Name = "lbTotalpage";
            this.lbTotalpage.Size = new System.Drawing.Size(54, 44);
            this.lbTotalpage.TabIndex = 1;
            this.lbTotalpage.Text = "/100";
            this.lbTotalpage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPrevious
            // 
            this.pnlPrevious.Controls.Add(this.btnPrevious);
            this.pnlPrevious.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPrevious.Location = new System.Drawing.Point(0, 0);
            this.pnlPrevious.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPrevious.Name = "pnlPrevious";
            this.pnlPrevious.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPrevious.Size = new System.Drawing.Size(53, 54);
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
            this.btnPrevious.Location = new System.Drawing.Point(4, 4);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrevious.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Padding = new System.Windows.Forms.Padding(27, 0, 29, 0);
            this.btnPrevious.Radius = 4;
            this.btnPrevious.RectColor = System.Drawing.Color.White;
            this.btnPrevious.RectDisableColor = System.Drawing.Color.White;
            this.btnPrevious.RectHoverColor = System.Drawing.Color.White;
            this.btnPrevious.RectPressColor = System.Drawing.Color.White;
            this.btnPrevious.RectSelectedColor = System.Drawing.Color.White;
            this.btnPrevious.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnPrevious.RectSize = 2;
            this.btnPrevious.Size = new System.Drawing.Size(45, 46);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // separator
            // 
            this.separator.Dock = System.Windows.Forms.DockStyle.Top;
            this.separator.Location = new System.Drawing.Point(0, 133);
            this.separator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.separator.MaximumSize = new System.Drawing.Size(2160, 5);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(1633, 5);
            this.separator.TabIndex = 2;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.tableTop);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pnlTop.Size = new System.Drawing.Size(1633, 133);
            this.pnlTop.TabIndex = 5;
            this.pnlTop.Resize += new System.EventHandler(this.TopPnl_Resize);
            // 
            // tableTop
            // 
            this.tableTop.ColumnCount = 2;
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableTop.Controls.Add(this.btnFilter, 1, 0);
            this.tableTop.Controls.Add(this.uiPanel3, 0, 0);
            this.tableTop.Controls.Add(this.uiPanel4, 0, 1);
            this.tableTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableTop.Location = new System.Drawing.Point(7, 6);
            this.tableTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableTop.Name = "tableTop";
            this.tableTop.RowCount = 2;
            this.tableTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableTop.Size = new System.Drawing.Size(1619, 121);
            this.tableTop.TabIndex = 0;
            this.tableTop.TagString = null;
            // 
            // btnFilter
            // 
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilter.FillColor = System.Drawing.Color.White;
            this.btnFilter.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnFilter.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnFilter.FillSelectedColor = System.Drawing.Color.White;
            this.btnFilter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnFilter.Location = new System.Drawing.Point(1450, 4);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFilter.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Padding = new System.Windows.Forms.Padding(19, 0, 16, 0);
            this.btnFilter.RectColor = System.Drawing.SystemColors.ControlLight;
            this.btnFilter.RectDisableColor = System.Drawing.Color.White;
            this.btnFilter.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnFilter.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnFilter.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnFilter.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnFilter.RectSize = 2;
            this.btnFilter.Size = new System.Drawing.Size(165, 46);
            this.btnFilter.Symbol = 61616;
            this.btnFilter.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnFilter.TabIndex = 14;
            this.btnFilter.Text = "Filter";
            this.btnFilter.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
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
            this.uiPanel3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiPanel3.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel3.Size = new System.Drawing.Size(1446, 54);
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
            this.pnlSearch.Location = new System.Drawing.Point(4, 4);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(5);
            this.pnlSearch.RectColor = System.Drawing.SystemColors.ControlLight;
            this.pnlSearch.RectSize = 2;
            this.pnlSearch.Size = new System.Drawing.Size(400, 46);
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
            this.tableSearch.Controls.Add(this.uiSymbolLabel1, 0, 0);
            this.tableSearch.Controls.Add(this.cbFilter, 2, 0);
            this.tableSearch.Controls.Add(this.tbSearch, 1, 0);
            this.tableSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.tableSearch.Location = new System.Drawing.Point(5, 5);
            this.tableSearch.Name = "tableSearch";
            this.tableSearch.RowCount = 1;
            this.tableSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSearch.Size = new System.Drawing.Size(390, 36);
            this.tableSearch.TabIndex = 1;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(1, 1);
            this.uiSymbolLabel1.Margin = new System.Windows.Forms.Padding(1);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Size = new System.Drawing.Size(30, 34);
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
            "  National ID"});
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
            this.cbFilter.Size = new System.Drawing.Size(65, 36);
            this.cbFilter.Style = Sunny.UI.UIStyle.Custom;
            this.cbFilter.SymbolSize = 24;
            this.cbFilter.TabIndex = 2;
            this.cbFilter.Text = "  ID";
            this.cbFilter.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbFilter.TrimFilter = true;
            this.cbFilter.Watermark = "";
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
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
            this.tbSearch.Size = new System.Drawing.Size(293, 36);
            this.tbSearch.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.tbSearch.SymbolSize = 26;
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbSearch.Watermark = "Search a lost record by its";
            this.tbSearch.WatermarkActiveColor = System.Drawing.Color.DarkGray;
            this.tbSearch.WatermarkColor = System.Drawing.Color.LightGray;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // uiPanel4
            // 
            this.tableTop.SetColumnSpan(this.uiPanel4, 2);
            this.uiPanel4.Controls.Add(this.uiTableLayoutPanel1);
            this.uiPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel4.FillColor = System.Drawing.Color.White;
            this.uiPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel4.Location = new System.Drawing.Point(0, 60);
            this.uiPanel4.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.uiPanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel4.Name = "uiPanel4";
            this.uiPanel4.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel4.Size = new System.Drawing.Size(1619, 55);
            this.uiPanel4.TabIndex = 12;
            this.uiPanel4.Text = null;
            this.uiPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTableLayoutPanel1
            // 
            this.uiTableLayoutPanel1.ColumnCount = 4;
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.uiTableLayoutPanel1.Controls.Add(this.btnClear, 2, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.btnApply, 3, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.uiPanel10, 0, 0);
            this.uiTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            this.uiTableLayoutPanel1.RowCount = 1;
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel1.Size = new System.Drawing.Size(1619, 55);
            this.uiTableLayoutPanel1.TabIndex = 0;
            this.uiTableLayoutPanel1.TagString = null;
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
            this.btnClear.Location = new System.Drawing.Point(1361, 3);
            this.btnClear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.RectColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.RectDisableColor = System.Drawing.Color.White;
            this.btnClear.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnClear.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnClear.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnClear.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnClear.RectSize = 2;
            this.btnClear.Size = new System.Drawing.Size(124, 49);
            this.btnClear.Symbol = 61453;
            this.btnClear.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Clear";
            this.btnClear.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnApply
            // 
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApply.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnApply.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(91)))), ((int)(((byte)(17)))));
            this.btnApply.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnApply.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(1491, 3);
            this.btnApply.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnApply.Name = "btnApply";
            this.btnApply.Radius = 6;
            this.btnApply.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnApply.RectDisableColor = System.Drawing.Color.White;
            this.btnApply.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnApply.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnApply.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnApply.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnApply.Size = new System.Drawing.Size(125, 49);
            this.btnApply.Symbol = 61616;
            this.btnApply.TabIndex = 32;
            this.btnApply.Text = "Apply";
            this.btnApply.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // uiPanel10
            // 
            this.uiTableLayoutPanel1.SetColumnSpan(this.uiPanel10, 2);
            this.uiPanel10.Controls.Add(this.uiTableLayoutPanel4);
            this.uiPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel10.FillColor = System.Drawing.Color.White;
            this.uiPanel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel10.Location = new System.Drawing.Point(4, 5);
            this.uiPanel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel10.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel10.Name = "uiPanel10";
            this.uiPanel10.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uiPanel10.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel10.Size = new System.Drawing.Size(1350, 45);
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
            this.uiTableLayoutPanel4.Size = new System.Drawing.Size(1340, 45);
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
            "  Found",
            "  Lost"});
            this.cbStatus.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbStatus.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbStatus.Location = new System.Drawing.Point(60, 0);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(0);
            this.cbStatus.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Padding = new System.Windows.Forms.Padding(5, 0, 30, 2);
            this.cbStatus.RectColor = System.Drawing.SystemColors.ControlLight;
            this.cbStatus.RectSize = 2;
            this.cbStatus.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.cbStatus.ScrollBarStyleInherited = false;
            this.cbStatus.Size = new System.Drawing.Size(1280, 45);
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
            this.uiPanel8.Size = new System.Drawing.Size(60, 45);
            this.uiPanel8.TabIndex = 0;
            this.uiPanel8.Text = "Status:";
            this.uiPanel8.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colId.Width = 50;
            // 
            // colRFID
            // 
            this.colRFID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRFID.HeaderText = "RFID";
            this.colRFID.MinimumWidth = 6;
            this.colRFID.Name = "colRFID";
            this.colRFID.ReadOnly = true;
            // 
            // colFullname
            // 
            this.colFullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFullname.HeaderText = "Full name";
            this.colFullname.MinimumWidth = 6;
            this.colFullname.Name = "colFullname";
            this.colFullname.ReadOnly = true;
            // 
            // colNationalID
            // 
            this.colNationalID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNationalID.HeaderText = "National ID";
            this.colNationalID.MinimumWidth = 100;
            this.colNationalID.Name = "colNationalID";
            this.colNationalID.ReadOnly = true;
            // 
            // cardType
            // 
            this.cardType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cardType.HeaderText = "Card Type";
            this.cardType.MinimumWidth = 6;
            this.cardType.Name = "cardType";
            this.cardType.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colRestore
            // 
            this.colRestore.HeaderText = "Action";
            this.colRestore.MinimumWidth = 6;
            this.colRestore.Name = "colRestore";
            this.colRestore.ReadOnly = true;
            this.colRestore.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRestore.Text = "View";
            this.colRestore.Width = 90;
            // 
            // LostCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LostCardControl";
            this.Size = new System.Drawing.Size(1633, 938);
            this.Load += new System.EventHandler(this.LostCardControl_Load);
            this.panel2.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableLostCard)).EndInit();
            this.pnlPagination.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlNext.ResumeLayout(false);
            this.pnlCurrentPage.ResumeLayout(false);
            this.uiTableLayoutPanel3.ResumeLayout(false);
            this.pnlPrevious.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.tableTop.ResumeLayout(false);
            this.uiPanel3.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.tableSearch.ResumeLayout(false);
            this.uiPanel4.ResumeLayout(false);
            this.uiTableLayoutPanel1.ResumeLayout(false);
            this.uiPanel10.ResumeLayout(false);
            this.uiTableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel separator;
        private System.Windows.Forms.Panel pnlTop;
        private Sunny.UI.UITableLayoutPanel tableTop;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIPanel pnlSearch;
        private System.Windows.Forms.TableLayoutPanel tableSearch;
        private Sunny.UI.UIComboBox cbFilter;
        private Sunny.UI.UITextBox tbSearch;
        private Sunny.UI.UIPanel uiPanel4;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UIPanel uiPanel10;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel4;
        private Sunny.UI.UIComboBox cbStatus;
        private Sunny.UI.UIPanel uiPanel8;
        private System.Windows.Forms.DataGridView tableLostCard;
        private System.Windows.Forms.Panel separtorBottom;
        private System.Windows.Forms.Panel pnlPagination;
        private System.Windows.Forms.Panel pnlLeft;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIComboBox cbNumberofitem;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlNext;
        private Sunny.UI.UISymbolButton btnNext;
        private System.Windows.Forms.Panel pnlCurrentPage;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel3;
        private Sunny.UI.UITextBox tbCurrentpage;
        private Sunny.UI.UILabel lbTotalpage;
        private System.Windows.Forms.Panel pnlPrevious;
        private Sunny.UI.UISymbolButton btnPrevious;
        private Sunny.UI.UISymbolButton btnFilter;
        private Sunny.UI.UISymbolButton btnClear;
        private Sunny.UI.UISymbolButton btnApply;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRFID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNationalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colRestore;
    }
}
