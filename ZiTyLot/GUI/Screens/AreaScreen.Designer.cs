﻿using System.Windows.Forms;

namespace ZiTyLot.GUI.Screens
{
    partial class AreaScreen
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TopPnl = new System.Windows.Forms.Panel();
            this.tabpanePnl = new System.Windows.Forms.Panel();
            this.searchPnl = new System.Windows.Forms.Panel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.searchTb = new Sunny.UI.UITextBox();
            this.filterPnl = new Sunny.UI.UIPanel();
            this.filterCb = new Sunny.UI.UIComboBox();
            this.buttonsPnl = new System.Windows.Forms.Panel();
            this.separator = new System.Windows.Forms.Panel();
            this.BottomPnl = new System.Windows.Forms.Panel();
            this.PaginationPnl = new System.Windows.Forms.Panel();
            this.ItemPerPagePnl = new System.Windows.Forms.Panel();
            this.numberofitemCb = new Sunny.UI.UIComboBox();
            this.PageNumberPnl = new System.Windows.Forms.Panel();
            this.nextPnl = new System.Windows.Forms.Panel();
            this.currentpagePnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.currentpageTb = new Sunny.UI.UITextBox();
            this.previousPnl = new System.Windows.Forms.Panel();
            this.table = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nextBtn = new Sunny.UI.UISymbolButton();
            this.previousBtn = new Sunny.UI.UISymbolButton();
            this.vistorBtn = new System.Windows.Forms.RadioButton();
            this.residentBtn = new System.Windows.Forms.RadioButton();
            this.allBtn = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.addBtn = new Sunny.UI.UISymbolButton();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalslotCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainslotCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TopPnl.SuspendLayout();
            this.tabpanePnl.SuspendLayout();
            this.searchPnl.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.filterPnl.SuspendLayout();
            this.buttonsPnl.SuspendLayout();
            this.BottomPnl.SuspendLayout();
            this.PaginationPnl.SuspendLayout();
            this.ItemPerPagePnl.SuspendLayout();
            this.PageNumberPnl.SuspendLayout();
            this.nextPnl.SuspendLayout();
            this.currentpagePnl.SuspendLayout();
            this.previousPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.tabpanePnl.Controls.Add(this.vistorBtn);
            this.tabpanePnl.Controls.Add(this.residentBtn);
            this.tabpanePnl.Controls.Add(this.allBtn);
            this.tabpanePnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabpanePnl.Location = new System.Drawing.Point(10, 10);
            this.tabpanePnl.Name = "tabpanePnl";
            this.tabpanePnl.Size = new System.Drawing.Size(491, 34);
            this.tabpanePnl.TabIndex = 8;
            // 
            // searchPnl
            // 
            this.searchPnl.BackColor = System.Drawing.Color.White;
            this.searchPnl.Controls.Add(this.uiPanel1);
            this.searchPnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchPnl.Location = new System.Drawing.Point(501, 10);
            this.searchPnl.Name = "searchPnl";
            this.searchPnl.Size = new System.Drawing.Size(400, 34);
            this.searchPnl.TabIndex = 6;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.pictureBox2);
            this.uiPanel1.Controls.Add(this.searchTb);
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
            // searchTb
            // 
            this.searchTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTb.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.searchTb.IconSize = 18;
            this.searchTb.Location = new System.Drawing.Point(8, 4);
            this.searchTb.Margin = new System.Windows.Forms.Padding(0);
            this.searchTb.MaximumSize = new System.Drawing.Size(350, 26);
            this.searchTb.MinimumSize = new System.Drawing.Size(1, 16);
            this.searchTb.Name = "searchTb";
            this.searchTb.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.searchTb.Radius = 14;
            this.searchTb.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.searchTb.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.searchTb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchTb.ShowText = false;
            this.searchTb.Size = new System.Drawing.Size(350, 26);
            this.searchTb.TabIndex = 0;
            this.searchTb.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchTb.Watermark = "";
            // 
            // filterPnl
            // 
            this.filterPnl.Controls.Add(this.filterCb);
            this.filterPnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.filterPnl.FillColor = System.Drawing.Color.White;
            this.filterPnl.FillColor2 = System.Drawing.Color.White;
            this.filterPnl.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterPnl.Location = new System.Drawing.Point(901, 10);
            this.filterPnl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filterPnl.MinimumSize = new System.Drawing.Size(1, 1);
            this.filterPnl.Name = "filterPnl";
            this.filterPnl.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.filterPnl.Radius = 14;
            this.filterPnl.RectColor = System.Drawing.Color.White;
            this.filterPnl.RectDisableColor = System.Drawing.Color.White;
            this.filterPnl.RectSize = 2;
            this.filterPnl.Size = new System.Drawing.Size(120, 34);
            this.filterPnl.TabIndex = 1;
            this.filterPnl.Text = null;
            this.filterPnl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filterCb
            // 
            this.filterCb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterCb.DataSource = null;
            this.filterCb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterCb.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.filterCb.DropDownWidth = 110;
            this.filterCb.FillColor = System.Drawing.Color.White;
            this.filterCb.FillColor2 = System.Drawing.Color.White;
            this.filterCb.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.filterCb.ItemHeight = 24;
            this.filterCb.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            this.filterCb.ItemRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.filterCb.Items.AddRange(new object[] {
            "All",
            "Hello",
            "Hi"});
            this.filterCb.ItemSelectBackColor = System.Drawing.Color.White;
            this.filterCb.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.filterCb.Location = new System.Drawing.Point(10, 0);
            this.filterCb.Margin = new System.Windows.Forms.Padding(0);
            this.filterCb.MinimumSize = new System.Drawing.Size(63, 0);
            this.filterCb.Name = "filterCb";
            this.filterCb.Padding = new System.Windows.Forms.Padding(4, 0, 30, 2);
            this.filterCb.Radius = 2;
            this.filterCb.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.filterCb.RectSize = 2;
            this.filterCb.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.filterCb.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.filterCb.ScrollBarStyleInherited = false;
            this.filterCb.Size = new System.Drawing.Size(110, 34);
            this.filterCb.Style = Sunny.UI.UIStyle.Custom;
            this.filterCb.SymbolDropDown = 560247;
            this.filterCb.SymbolNormal = 557682;
            this.filterCb.SymbolSize = 24;
            this.filterCb.TabIndex = 1;
            this.filterCb.Text = "Filter";
            this.filterCb.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.BottomPnl.Controls.Add(this.PaginationPnl);
            this.BottomPnl.Controls.Add(this.table);
            this.BottomPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomPnl.Location = new System.Drawing.Point(0, 58);
            this.BottomPnl.Margin = new System.Windows.Forms.Padding(0);
            this.BottomPnl.Name = "BottomPnl";
            this.BottomPnl.Padding = new System.Windows.Forms.Padding(10);
            this.BottomPnl.Size = new System.Drawing.Size(1151, 522);
            this.BottomPnl.TabIndex = 3;
            this.BottomPnl.Resize += new System.EventHandler(this.BottomPnl_Resize);
            // 
            // PaginationPnl
            // 
            this.PaginationPnl.BackColor = System.Drawing.Color.White;
            this.PaginationPnl.Controls.Add(this.ItemPerPagePnl);
            this.PaginationPnl.Controls.Add(this.PageNumberPnl);
            this.PaginationPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PaginationPnl.Location = new System.Drawing.Point(10, 462);
            this.PaginationPnl.Name = "PaginationPnl";
            this.PaginationPnl.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.PaginationPnl.Size = new System.Drawing.Size(1131, 50);
            this.PaginationPnl.TabIndex = 2;
            this.PaginationPnl.Tag = "";
            // 
            // ItemPerPagePnl
            // 
            this.ItemPerPagePnl.Controls.Add(this.numberofitemCb);
            this.ItemPerPagePnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.ItemPerPagePnl.Location = new System.Drawing.Point(0, 5);
            this.ItemPerPagePnl.Name = "ItemPerPagePnl";
            this.ItemPerPagePnl.Size = new System.Drawing.Size(120, 40);
            this.ItemPerPagePnl.TabIndex = 0;
            // 
            // numberofitemCb
            // 
            this.numberofitemCb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numberofitemCb.DataSource = null;
            this.numberofitemCb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberofitemCb.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.numberofitemCb.DropDownWidth = 120;
            this.numberofitemCb.FillColor = System.Drawing.Color.White;
            this.numberofitemCb.FillColor2 = System.Drawing.Color.White;
            this.numberofitemCb.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberofitemCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.numberofitemCb.ItemHeight = 24;
            this.numberofitemCb.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            this.numberofitemCb.ItemRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.numberofitemCb.Items.AddRange(new object[] {
            "25 items",
            "50 items",
            "100 items"});
            this.numberofitemCb.ItemSelectBackColor = System.Drawing.Color.White;
            this.numberofitemCb.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.numberofitemCb.Location = new System.Drawing.Point(0, 0);
            this.numberofitemCb.Margin = new System.Windows.Forms.Padding(0);
            this.numberofitemCb.MinimumSize = new System.Drawing.Size(63, 0);
            this.numberofitemCb.Name = "numberofitemCb";
            this.numberofitemCb.Padding = new System.Windows.Forms.Padding(4, 0, 30, 2);
            this.numberofitemCb.Radius = 2;
            this.numberofitemCb.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.numberofitemCb.RectSize = 2;
            this.numberofitemCb.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.numberofitemCb.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.numberofitemCb.ScrollBarStyleInherited = false;
            this.numberofitemCb.Size = new System.Drawing.Size(120, 40);
            this.numberofitemCb.Style = Sunny.UI.UIStyle.Custom;
            this.numberofitemCb.SymbolDropDown = 560247;
            this.numberofitemCb.SymbolNormal = 557682;
            this.numberofitemCb.SymbolSize = 24;
            this.numberofitemCb.TabIndex = 2;
            this.numberofitemCb.Text = "25 items";
            this.numberofitemCb.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.numberofitemCb.Watermark = "";
            // 
            // PageNumberPnl
            // 
            this.PageNumberPnl.Controls.Add(this.nextPnl);
            this.PageNumberPnl.Controls.Add(this.currentpagePnl);
            this.PageNumberPnl.Controls.Add(this.previousPnl);
            this.PageNumberPnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.PageNumberPnl.Location = new System.Drawing.Point(963, 5);
            this.PageNumberPnl.Name = "PageNumberPnl";
            this.PageNumberPnl.Size = new System.Drawing.Size(168, 40);
            this.PageNumberPnl.TabIndex = 1;
            // 
            // nextPnl
            // 
            this.nextPnl.Controls.Add(this.nextBtn);
            this.nextPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.nextPnl.Location = new System.Drawing.Point(126, 0);
            this.nextPnl.Name = "nextPnl";
            this.nextPnl.Padding = new System.Windows.Forms.Padding(3);
            this.nextPnl.Size = new System.Drawing.Size(40, 40);
            this.nextPnl.TabIndex = 1;
            // 
            // currentpagePnl
            // 
            this.currentpagePnl.Controls.Add(this.label1);
            this.currentpagePnl.Controls.Add(this.currentpageTb);
            this.currentpagePnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.currentpagePnl.Location = new System.Drawing.Point(40, 0);
            this.currentpagePnl.Name = "currentpagePnl";
            this.currentpagePnl.Padding = new System.Windows.Forms.Padding(3);
            this.currentpagePnl.Size = new System.Drawing.Size(86, 40);
            this.currentpagePnl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.label1.Size = new System.Drawing.Size(42, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "/100";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentpageTb
            // 
            this.currentpageTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.currentpageTb.Dock = System.Windows.Forms.DockStyle.Left;
            this.currentpageTb.DoubleValue = 1D;
            this.currentpageTb.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentpageTb.IntValue = 1;
            this.currentpageTb.Location = new System.Drawing.Point(3, 3);
            this.currentpageTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currentpageTb.MinimumSize = new System.Drawing.Size(1, 16);
            this.currentpageTb.Name = "currentpageTb";
            this.currentpageTb.Padding = new System.Windows.Forms.Padding(5);
            this.currentpageTb.Radius = 1;
            this.currentpageTb.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.currentpageTb.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.currentpageTb.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.currentpageTb.RectSize = 2;
            this.currentpageTb.ShowText = false;
            this.currentpageTb.Size = new System.Drawing.Size(34, 34);
            this.currentpageTb.TabIndex = 0;
            this.currentpageTb.Text = "01";
            this.currentpageTb.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.currentpageTb.Watermark = "";
            // 
            // previousPnl
            // 
            this.previousPnl.Controls.Add(this.previousBtn);
            this.previousPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.previousPnl.Location = new System.Drawing.Point(0, 0);
            this.previousPnl.Name = "previousPnl";
            this.previousPnl.Padding = new System.Windows.Forms.Padding(3);
            this.previousPnl.Size = new System.Drawing.Size(40, 40);
            this.previousPnl.TabIndex = 0;
            // 
            // table
            // 
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToResizeColumns = false;
            this.table.AllowUserToResizeRows = false;
            this.table.BackgroundColor = System.Drawing.Color.White;
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table.ColumnHeadersHeight = 34;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.nameCol,
            this.totalslotCol,
            this.remainslotCol,
            this.statusCol,
            this.viewCol,
            this.editCol,
            this.deleteCol});
            this.table.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table.DefaultCellStyle = dataGridViewCellStyle2;
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.GridColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(10, 10);
            this.table.Margin = new System.Windows.Forms.Padding(0);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersVisible = false;
            this.table.RowHeadersWidth = 30;
            this.table.RowTemplate.Height = 30;
            this.table.Size = new System.Drawing.Size(1131, 502);
            this.table.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BottomPnl);
            this.panel2.Controls.Add(this.separator);
            this.panel2.Controls.Add(this.TopPnl);
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
            // nextBtn
            // 
            this.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextBtn.FillColor = System.Drawing.SystemColors.ControlLight;
            this.nextBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(91)))), ((int)(((byte)(17)))));
            this.nextBtn.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.nextBtn.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Next;
            this.nextBtn.Location = new System.Drawing.Point(3, 3);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(0);
            this.nextBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Padding = new System.Windows.Forms.Padding(20, 0, 22, 0);
            this.nextBtn.Radius = 4;
            this.nextBtn.RectColor = System.Drawing.Color.White;
            this.nextBtn.RectDisableColor = System.Drawing.Color.White;
            this.nextBtn.RectHoverColor = System.Drawing.Color.White;
            this.nextBtn.RectPressColor = System.Drawing.Color.White;
            this.nextBtn.RectSelectedColor = System.Drawing.Color.White;
            this.nextBtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.nextBtn.RectSize = 2;
            this.nextBtn.Size = new System.Drawing.Size(34, 34);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.TipsFont = new System.Drawing.Font("Helvetica Rounded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // previousBtn
            // 
            this.previousBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previousBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previousBtn.FillColor = System.Drawing.SystemColors.ControlLight;
            this.previousBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(91)))), ((int)(((byte)(17)))));
            this.previousBtn.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.previousBtn.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Previous;
            this.previousBtn.Location = new System.Drawing.Point(3, 3);
            this.previousBtn.Margin = new System.Windows.Forms.Padding(0);
            this.previousBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Padding = new System.Windows.Forms.Padding(20, 0, 22, 0);
            this.previousBtn.Radius = 4;
            this.previousBtn.RectColor = System.Drawing.Color.White;
            this.previousBtn.RectDisableColor = System.Drawing.Color.White;
            this.previousBtn.RectHoverColor = System.Drawing.Color.White;
            this.previousBtn.RectPressColor = System.Drawing.Color.White;
            this.previousBtn.RectSelectedColor = System.Drawing.Color.White;
            this.previousBtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.previousBtn.RectSize = 2;
            this.previousBtn.Size = new System.Drawing.Size(34, 34);
            this.previousBtn.TabIndex = 4;
            this.previousBtn.TipsFont = new System.Drawing.Font("Helvetica Rounded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // vistorBtn
            // 
            this.vistorBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.vistorBtn.AutoSize = true;
            this.vistorBtn.BackColor = System.Drawing.Color.White;
            this.vistorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vistorBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.vistorBtn.FlatAppearance.BorderSize = 0;
            this.vistorBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.vistorBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.vistorBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.vistorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vistorBtn.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistorBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.vistorBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Visitor;
            this.vistorBtn.Location = new System.Drawing.Point(228, 0);
            this.vistorBtn.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.vistorBtn.MinimumSize = new System.Drawing.Size(110, 34);
            this.vistorBtn.Name = "vistorBtn";
            this.vistorBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.vistorBtn.Size = new System.Drawing.Size(128, 34);
            this.vistorBtn.TabIndex = 5;
            this.vistorBtn.TabStop = true;
            this.vistorBtn.Text = "Check out";
            this.vistorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.vistorBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vistorBtn.UseVisualStyleBackColor = false;
            // 
            // residentBtn
            // 
            this.residentBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.residentBtn.AutoSize = true;
            this.residentBtn.BackColor = System.Drawing.Color.White;
            this.residentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.residentBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.residentBtn.FlatAppearance.BorderSize = 0;
            this.residentBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.residentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.residentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.residentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.residentBtn.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.residentBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.residentBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Resident;
            this.residentBtn.Location = new System.Drawing.Point(110, 0);
            this.residentBtn.Margin = new System.Windows.Forms.Padding(0);
            this.residentBtn.MinimumSize = new System.Drawing.Size(110, 34);
            this.residentBtn.Name = "residentBtn";
            this.residentBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.residentBtn.Size = new System.Drawing.Size(118, 34);
            this.residentBtn.TabIndex = 4;
            this.residentBtn.TabStop = true;
            this.residentBtn.Text = "Resident";
            this.residentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.residentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.residentBtn.UseVisualStyleBackColor = false;
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
            this.addBtn.Radius = 12;
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
            // idCol
            // 
            this.idCol.HeaderText = "ID";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idCol.Width = 30;
            // 
            // nameCol
            // 
            this.nameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameCol.HeaderText = "Name";
            this.nameCol.MinimumWidth = 80;
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            this.nameCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // totalslotCol
            // 
            this.totalslotCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalslotCol.HeaderText = "Total slot";
            this.totalslotCol.Name = "totalslotCol";
            this.totalslotCol.ReadOnly = true;
            // 
            // remainslotCol
            // 
            this.remainslotCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remainslotCol.HeaderText = "Remain slot";
            this.remainslotCol.Name = "remainslotCol";
            this.remainslotCol.ReadOnly = true;
            // 
            // statusCol
            // 
            this.statusCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusCol.HeaderText = "Status";
            this.statusCol.Name = "statusCol";
            this.statusCol.ReadOnly = true;
            // 
            // viewCol
            // 
            this.viewCol.HeaderText = "";
            this.viewCol.Name = "viewCol";
            this.viewCol.ReadOnly = true;
            this.viewCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.viewCol.Text = "View";
            this.viewCol.Width = 30;
            // 
            // editCol
            // 
            this.editCol.HeaderText = "";
            this.editCol.Name = "editCol";
            this.editCol.ReadOnly = true;
            this.editCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editCol.Text = "Edit";
            this.editCol.Width = 30;
            // 
            // deleteCol
            // 
            this.deleteCol.HeaderText = "";
            this.deleteCol.Name = "deleteCol";
            this.deleteCol.ReadOnly = true;
            this.deleteCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteCol.Text = "Delete";
            this.deleteCol.Width = 30;
            // 
            // AreaScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.Name = "AreaScreen";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1171, 600);
            this.Load += new System.EventHandler(this.AreaScreen_Load);
            this.TopPnl.ResumeLayout(false);
            this.tabpanePnl.ResumeLayout(false);
            this.tabpanePnl.PerformLayout();
            this.searchPnl.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.filterPnl.ResumeLayout(false);
            this.buttonsPnl.ResumeLayout(false);
            this.BottomPnl.ResumeLayout(false);
            this.PaginationPnl.ResumeLayout(false);
            this.ItemPerPagePnl.ResumeLayout(false);
            this.PageNumberPnl.ResumeLayout(false);
            this.nextPnl.ResumeLayout(false);
            this.currentpagePnl.ResumeLayout(false);
            this.currentpagePnl.PerformLayout();
            this.previousPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel TopPnl;
        private System.Windows.Forms.Panel tabpanePnl;
        private System.Windows.Forms.RadioButton vistorBtn;
        private System.Windows.Forms.RadioButton residentBtn;
        private System.Windows.Forms.RadioButton allBtn;
        private System.Windows.Forms.Panel searchPnl;
        private Sunny.UI.UIPanel uiPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Sunny.UI.UITextBox searchTb;
        private System.Windows.Forms.Panel buttonsPnl;
        private System.Windows.Forms.Panel separator;
        private System.Windows.Forms.Panel BottomPnl;
        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UISymbolButton addBtn;
        private System.Windows.Forms.Panel panel5;
        private Sunny.UI.UIPanel filterPnl;
        private Sunny.UI.UIComboBox filterCb;
        private DataGridView table;
        private Panel PaginationPnl;
        private Panel ItemPerPagePnl;
        private Sunny.UI.UIComboBox numberofitemCb;
        private Panel PageNumberPnl;
        private Panel nextPnl;
        private Sunny.UI.UISymbolButton nextBtn;
        private Panel currentpagePnl;
        private Label label1;
        private Sunny.UI.UITextBox currentpageTb;
        private Panel previousPnl;
        private Sunny.UI.UISymbolButton previousBtn;
        private DataGridViewTextBoxColumn idCol;
        private DataGridViewTextBoxColumn nameCol;
        private DataGridViewTextBoxColumn totalslotCol;
        private DataGridViewTextBoxColumn remainslotCol;
        private DataGridViewTextBoxColumn statusCol;
        private DataGridViewButtonColumn viewCol;
        private DataGridViewButtonColumn editCol;
        private DataGridViewButtonColumn deleteCol;
    }
}