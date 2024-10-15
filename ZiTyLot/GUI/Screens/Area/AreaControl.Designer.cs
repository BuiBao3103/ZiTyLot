﻿using System.Windows.Forms;

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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TopPnl = new System.Windows.Forms.Panel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.searchPnl = new Sunny.UI.UIPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.searchTb = new Sunny.UI.UITextBox();
            this.filterPnl = new Sunny.UI.UIPanel();
            this.filterCb = new Sunny.UI.UIComboBox();
            this.buttonsPnl = new System.Windows.Forms.Panel();
            this.addBtn = new Sunny.UI.UISymbolButton();
            this.tabpanePnl = new System.Windows.Forms.Panel();
            this.vistorBtn = new System.Windows.Forms.RadioButton();
            this.residentBtn = new System.Windows.Forms.RadioButton();
            this.allBtn = new System.Windows.Forms.RadioButton();
            this.separator = new System.Windows.Forms.Panel();
            this.BottomPnl = new System.Windows.Forms.Panel();
            this.PaginationPnl = new System.Windows.Forms.Panel();
            this.ItemPerPagePnl = new System.Windows.Forms.Panel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.numberofitemsCb = new Sunny.UI.UIComboBox();
            this.PageNumberPnl = new System.Windows.Forms.Panel();
            this.nextPnl = new System.Windows.Forms.Panel();
            this.nextBtn = new Sunny.UI.UISymbolButton();
            this.currentpagePnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.currentpageTb = new Sunny.UI.UITextBox();
            this.previousPnl = new System.Windows.Forms.Panel();
            this.previousBtn = new Sunny.UI.UISymbolButton();
            this.table = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalslotCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainslotCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TopPnl.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.searchPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.filterPnl.SuspendLayout();
            this.buttonsPnl.SuspendLayout();
            this.tabpanePnl.SuspendLayout();
            this.BottomPnl.SuspendLayout();
            this.PaginationPnl.SuspendLayout();
            this.ItemPerPagePnl.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.PageNumberPnl.SuspendLayout();
            this.nextPnl.SuspendLayout();
            this.currentpagePnl.SuspendLayout();
            this.previousPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPnl
            // 
            this.TopPnl.BackColor = System.Drawing.Color.White;
            this.TopPnl.Controls.Add(this.uiPanel1);
            this.TopPnl.Controls.Add(this.tabpanePnl);
            this.TopPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPnl.Location = new System.Drawing.Point(0, 0);
            this.TopPnl.Margin = new System.Windows.Forms.Padding(4);
            this.TopPnl.Name = "TopPnl";
            this.TopPnl.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TopPnl.Size = new System.Drawing.Size(1535, 66);
            this.TopPnl.TabIndex = 1;
            this.TopPnl.Resize += new System.EventHandler(this.TopPnl_Resize);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.searchPnl);
            this.uiPanel1.Controls.Add(this.filterPnl);
            this.uiPanel1.Controls.Add(this.buttonsPnl);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiPanel1.FillColor = System.Drawing.Color.White;
            this.uiPanel1.FillColor2 = System.Drawing.Color.White;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(842, 12);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.White;
            this.uiPanel1.Size = new System.Drawing.Size(680, 42);
            this.uiPanel1.TabIndex = 9;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchPnl
            // 
            this.searchPnl.Controls.Add(this.pictureBox2);
            this.searchPnl.Controls.Add(this.searchTb);
            this.searchPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchPnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPnl.Location = new System.Drawing.Point(0, 0);
            this.searchPnl.Margin = new System.Windows.Forms.Padding(0);
            this.searchPnl.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchPnl.Name = "searchPnl";
            this.searchPnl.Padding = new System.Windows.Forms.Padding(5);
            this.searchPnl.Radius = 10;
            this.searchPnl.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.searchPnl.RectSize = 2;
            this.searchPnl.Size = new System.Drawing.Size(250, 42);
            this.searchPnl.TabIndex = 1;
            this.searchPnl.Text = null;
            this.searchPnl.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Magnifying;
            this.pictureBox2.Location = new System.Drawing.Point(217, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // searchTb
            // 
            this.searchTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTb.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.searchTb.IconSize = 18;
            this.searchTb.Location = new System.Drawing.Point(5, 5);
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
            this.searchTb.Size = new System.Drawing.Size(218, 26);
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
            this.filterPnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterPnl.Location = new System.Drawing.Point(430, 0);
            this.filterPnl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filterPnl.MinimumSize = new System.Drawing.Size(1, 1);
            this.filterPnl.Name = "filterPnl";
            this.filterPnl.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.filterPnl.Radius = 10;
            this.filterPnl.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.filterPnl.RectDisableColor = System.Drawing.Color.White;
            this.filterPnl.RectSize = 2;
            this.filterPnl.Size = new System.Drawing.Size(120, 42);
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
            this.filterCb.DropDownWidth = 100;
            this.filterCb.FillColor = System.Drawing.Color.White;
            this.filterCb.FillColor2 = System.Drawing.Color.White;
            this.filterCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.filterCb.Radius = 0;
            this.filterCb.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.filterCb.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.filterCb.RectSize = 2;
            this.filterCb.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.filterCb.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.filterCb.ScrollBarStyleInherited = false;
            this.filterCb.Size = new System.Drawing.Size(100, 42);
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
            this.buttonsPnl.Location = new System.Drawing.Point(550, 0);
            this.buttonsPnl.Name = "buttonsPnl";
            this.buttonsPnl.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonsPnl.Size = new System.Drawing.Size(130, 42);
            this.buttonsPnl.TabIndex = 7;
            // 
            // addBtn
            // 
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.addBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(91)))), ((int)(((byte)(17)))));
            this.addBtn.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Plus;
            this.addBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.Location = new System.Drawing.Point(10, 0);
            this.addBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.addBtn.Name = "addBtn";
            this.addBtn.Padding = new System.Windows.Forms.Padding(8, 0, 6, 0);
            this.addBtn.Radius = 10;
            this.addBtn.RectColor = System.Drawing.Color.White;
            this.addBtn.RectDisableColor = System.Drawing.Color.White;
            this.addBtn.RectHoverColor = System.Drawing.Color.White;
            this.addBtn.RectPressColor = System.Drawing.Color.White;
            this.addBtn.RectSelectedColor = System.Drawing.Color.White;
            this.addBtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.addBtn.Size = new System.Drawing.Size(120, 42);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "New area";
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tabpanePnl
            // 
            this.tabpanePnl.Controls.Add(this.vistorBtn);
            this.tabpanePnl.Controls.Add(this.residentBtn);
            this.tabpanePnl.Controls.Add(this.allBtn);
            this.tabpanePnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabpanePnl.Location = new System.Drawing.Point(13, 12);
            this.tabpanePnl.Margin = new System.Windows.Forms.Padding(4);
            this.tabpanePnl.Name = "tabpanePnl";
            this.tabpanePnl.Size = new System.Drawing.Size(492, 42);
            this.tabpanePnl.TabIndex = 8;
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
            this.vistorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistorBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.vistorBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Visitor;
            this.vistorBtn.Location = new System.Drawing.Point(294, 0);
            this.vistorBtn.Margin = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.vistorBtn.MinimumSize = new System.Drawing.Size(147, 42);
            this.vistorBtn.Name = "vistorBtn";
            this.vistorBtn.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.vistorBtn.Size = new System.Drawing.Size(151, 42);
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
            this.residentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.residentBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.residentBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Resident;
            this.residentBtn.Location = new System.Drawing.Point(147, 0);
            this.residentBtn.Margin = new System.Windows.Forms.Padding(0);
            this.residentBtn.MinimumSize = new System.Drawing.Size(147, 42);
            this.residentBtn.Name = "residentBtn";
            this.residentBtn.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.residentBtn.Size = new System.Drawing.Size(147, 42);
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
            this.allBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allBtn.ForeColor = System.Drawing.Color.White;
            this.allBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_All_Active;
            this.allBtn.Location = new System.Drawing.Point(0, 0);
            this.allBtn.Margin = new System.Windows.Forms.Padding(0);
            this.allBtn.MinimumSize = new System.Drawing.Size(147, 42);
            this.allBtn.Name = "allBtn";
            this.allBtn.Size = new System.Drawing.Size(147, 42);
            this.allBtn.TabIndex = 3;
            this.allBtn.TabStop = true;
            this.allBtn.Text = "  All";
            this.allBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.allBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.allBtn.UseVisualStyleBackColor = false;
            // 
            // separator
            // 
            this.separator.Dock = System.Windows.Forms.DockStyle.Top;
            this.separator.Location = new System.Drawing.Point(0, 66);
            this.separator.Margin = new System.Windows.Forms.Padding(4);
            this.separator.MaximumSize = new System.Drawing.Size(2160, 5);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(1535, 5);
            this.separator.TabIndex = 2;
            // 
            // BottomPnl
            // 
            this.BottomPnl.BackColor = System.Drawing.Color.White;
            this.BottomPnl.Controls.Add(this.PaginationPnl);
            this.BottomPnl.Controls.Add(this.table);
            this.BottomPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomPnl.Location = new System.Drawing.Point(0, 71);
            this.BottomPnl.Margin = new System.Windows.Forms.Padding(0);
            this.BottomPnl.Name = "BottomPnl";
            this.BottomPnl.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.BottomPnl.Size = new System.Drawing.Size(1535, 643);
            this.BottomPnl.TabIndex = 3;
            this.BottomPnl.Resize += new System.EventHandler(this.BottomPnl_Resize);
            // 
            // PaginationPnl
            // 
            this.PaginationPnl.BackColor = System.Drawing.Color.White;
            this.PaginationPnl.Controls.Add(this.ItemPerPagePnl);
            this.PaginationPnl.Controls.Add(this.PageNumberPnl);
            this.PaginationPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PaginationPnl.Location = new System.Drawing.Point(13, 569);
            this.PaginationPnl.Margin = new System.Windows.Forms.Padding(4);
            this.PaginationPnl.Name = "PaginationPnl";
            this.PaginationPnl.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.PaginationPnl.Size = new System.Drawing.Size(1509, 62);
            this.PaginationPnl.TabIndex = 2;
            this.PaginationPnl.Tag = "";
            // 
            // ItemPerPagePnl
            // 
            this.ItemPerPagePnl.Controls.Add(this.uiPanel2);
            this.ItemPerPagePnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.ItemPerPagePnl.Location = new System.Drawing.Point(0, 6);
            this.ItemPerPagePnl.Margin = new System.Windows.Forms.Padding(4);
            this.ItemPerPagePnl.Name = "ItemPerPagePnl";
            this.ItemPerPagePnl.Size = new System.Drawing.Size(187, 50);
            this.ItemPerPagePnl.TabIndex = 2;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.numberofitemsCb);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.FillColor = System.Drawing.Color.White;
            this.uiPanel2.FillColor2 = System.Drawing.Color.White;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel2.Location = new System.Drawing.Point(0, 0);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.uiPanel2.Radius = 10;
            this.uiPanel2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.uiPanel2.RectDisableColor = System.Drawing.Color.White;
            this.uiPanel2.RectSize = 2;
            this.uiPanel2.Size = new System.Drawing.Size(187, 50);
            this.uiPanel2.TabIndex = 2;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberofitemsCb
            // 
            this.numberofitemsCb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numberofitemsCb.DataSource = null;
            this.numberofitemsCb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberofitemsCb.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.numberofitemsCb.DropDownWidth = 100;
            this.numberofitemsCb.FillColor = System.Drawing.Color.White;
            this.numberofitemsCb.FillColor2 = System.Drawing.Color.White;
            this.numberofitemsCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberofitemsCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.numberofitemsCb.ItemHeight = 24;
            this.numberofitemsCb.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            this.numberofitemsCb.ItemRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.numberofitemsCb.Items.AddRange(new object[] {
            "10 items",
            "20 items",
            "30 items",
            "40 items"});
            this.numberofitemsCb.ItemSelectBackColor = System.Drawing.Color.White;
            this.numberofitemsCb.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.numberofitemsCb.Location = new System.Drawing.Point(13, 0);
            this.numberofitemsCb.Margin = new System.Windows.Forms.Padding(0);
            this.numberofitemsCb.MinimumSize = new System.Drawing.Size(63, 0);
            this.numberofitemsCb.Name = "numberofitemsCb";
            this.numberofitemsCb.Padding = new System.Windows.Forms.Padding(4, 0, 30, 2);
            this.numberofitemsCb.Radius = 0;
            this.numberofitemsCb.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.numberofitemsCb.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.numberofitemsCb.RectSize = 2;
            this.numberofitemsCb.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.numberofitemsCb.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.numberofitemsCb.ScrollBarStyleInherited = false;
            this.numberofitemsCb.Size = new System.Drawing.Size(161, 50);
            this.numberofitemsCb.Style = Sunny.UI.UIStyle.Custom;
            this.numberofitemsCb.SymbolDropDown = 560247;
            this.numberofitemsCb.SymbolNormal = 557682;
            this.numberofitemsCb.SymbolSize = 24;
            this.numberofitemsCb.TabIndex = 1;
            this.numberofitemsCb.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.numberofitemsCb.Watermark = "";
            this.numberofitemsCb.SelectedIndexChanged += new System.EventHandler(this.numberofitemsCb_SelectedIndexChanged);
            // 
            // PageNumberPnl
            // 
            this.PageNumberPnl.Controls.Add(this.nextPnl);
            this.PageNumberPnl.Controls.Add(this.currentpagePnl);
            this.PageNumberPnl.Controls.Add(this.previousPnl);
            this.PageNumberPnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.PageNumberPnl.Location = new System.Drawing.Point(1285, 6);
            this.PageNumberPnl.Margin = new System.Windows.Forms.Padding(4);
            this.PageNumberPnl.Name = "PageNumberPnl";
            this.PageNumberPnl.Size = new System.Drawing.Size(224, 50);
            this.PageNumberPnl.TabIndex = 1;
            // 
            // nextPnl
            // 
            this.nextPnl.Controls.Add(this.nextBtn);
            this.nextPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.nextPnl.Location = new System.Drawing.Point(168, 0);
            this.nextPnl.Margin = new System.Windows.Forms.Padding(4);
            this.nextPnl.Name = "nextPnl";
            this.nextPnl.Padding = new System.Windows.Forms.Padding(4);
            this.nextPnl.Size = new System.Drawing.Size(53, 50);
            this.nextPnl.TabIndex = 1;
            // 
            // nextBtn
            // 
            this.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextBtn.FillColor = System.Drawing.SystemColors.ControlLight;
            this.nextBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(91)))), ((int)(((byte)(17)))));
            this.nextBtn.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Next;
            this.nextBtn.Location = new System.Drawing.Point(4, 4);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(0);
            this.nextBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Padding = new System.Windows.Forms.Padding(27, 0, 29, 0);
            this.nextBtn.Radius = 4;
            this.nextBtn.RectColor = System.Drawing.Color.White;
            this.nextBtn.RectDisableColor = System.Drawing.Color.White;
            this.nextBtn.RectHoverColor = System.Drawing.Color.White;
            this.nextBtn.RectPressColor = System.Drawing.Color.White;
            this.nextBtn.RectSelectedColor = System.Drawing.Color.White;
            this.nextBtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.nextBtn.RectSize = 2;
            this.nextBtn.Size = new System.Drawing.Size(45, 42);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // currentpagePnl
            // 
            this.currentpagePnl.Controls.Add(this.label1);
            this.currentpagePnl.Controls.Add(this.currentpageTb);
            this.currentpagePnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.currentpagePnl.Location = new System.Drawing.Point(53, 0);
            this.currentpagePnl.Margin = new System.Windows.Forms.Padding(4);
            this.currentpagePnl.Name = "currentpagePnl";
            this.currentpagePnl.Padding = new System.Windows.Forms.Padding(4);
            this.currentpagePnl.Size = new System.Drawing.Size(115, 50);
            this.currentpagePnl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 9, 0, 9);
            this.label1.Size = new System.Drawing.Size(55, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "/100";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentpageTb
            // 
            this.currentpageTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.currentpageTb.Dock = System.Windows.Forms.DockStyle.Left;
            this.currentpageTb.DoubleValue = 1D;
            this.currentpageTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentpageTb.IntValue = 1;
            this.currentpageTb.Location = new System.Drawing.Point(4, 4);
            this.currentpageTb.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.currentpageTb.MinimumSize = new System.Drawing.Size(1, 20);
            this.currentpageTb.Name = "currentpageTb";
            this.currentpageTb.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.currentpageTb.Radius = 1;
            this.currentpageTb.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.currentpageTb.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.currentpageTb.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.currentpageTb.RectSize = 2;
            this.currentpageTb.ShowText = false;
            this.currentpageTb.Size = new System.Drawing.Size(45, 42);
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
            this.previousPnl.Margin = new System.Windows.Forms.Padding(4);
            this.previousPnl.Name = "previousPnl";
            this.previousPnl.Padding = new System.Windows.Forms.Padding(4);
            this.previousPnl.Size = new System.Drawing.Size(53, 50);
            this.previousPnl.TabIndex = 0;
            // 
            // previousBtn
            // 
            this.previousBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previousBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previousBtn.FillColor = System.Drawing.SystemColors.ControlLight;
            this.previousBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(91)))), ((int)(((byte)(17)))));
            this.previousBtn.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Previous;
            this.previousBtn.Location = new System.Drawing.Point(4, 4);
            this.previousBtn.Margin = new System.Windows.Forms.Padding(0);
            this.previousBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Padding = new System.Windows.Forms.Padding(27, 0, 29, 0);
            this.previousBtn.Radius = 4;
            this.previousBtn.RectColor = System.Drawing.Color.White;
            this.previousBtn.RectDisableColor = System.Drawing.Color.White;
            this.previousBtn.RectHoverColor = System.Drawing.Color.White;
            this.previousBtn.RectPressColor = System.Drawing.Color.White;
            this.previousBtn.RectSelectedColor = System.Drawing.Color.White;
            this.previousBtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.previousBtn.RectSize = 2;
            this.previousBtn.Size = new System.Drawing.Size(45, 42);
            this.previousBtn.TabIndex = 4;
            this.previousBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table.DefaultCellStyle = dataGridViewCellStyle2;
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.GridColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(13, 12);
            this.table.Margin = new System.Windows.Forms.Padding(0);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersVisible = false;
            this.table.RowHeadersWidth = 30;
            this.table.RowTemplate.Height = 30;
            this.table.Size = new System.Drawing.Size(1509, 619);
            this.table.TabIndex = 1;
            // 
            // idCol
            // 
            this.idCol.HeaderText = "ID";
            this.idCol.MinimumWidth = 6;
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
            this.totalslotCol.MinimumWidth = 6;
            this.totalslotCol.Name = "totalslotCol";
            this.totalslotCol.ReadOnly = true;
            // 
            // remainslotCol
            // 
            this.remainslotCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remainslotCol.HeaderText = "Remain slot";
            this.remainslotCol.MinimumWidth = 6;
            this.remainslotCol.Name = "remainslotCol";
            this.remainslotCol.ReadOnly = true;
            // 
            // statusCol
            // 
            this.statusCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusCol.HeaderText = "Status";
            this.statusCol.MinimumWidth = 6;
            this.statusCol.Name = "statusCol";
            this.statusCol.ReadOnly = true;
            // 
            // viewCol
            // 
            this.viewCol.HeaderText = "";
            this.viewCol.MinimumWidth = 6;
            this.viewCol.Name = "viewCol";
            this.viewCol.ReadOnly = true;
            this.viewCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.viewCol.Text = "View";
            this.viewCol.Width = 30;
            // 
            // editCol
            // 
            this.editCol.HeaderText = "";
            this.editCol.MinimumWidth = 6;
            this.editCol.Name = "editCol";
            this.editCol.ReadOnly = true;
            this.editCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editCol.Text = "Edit";
            this.editCol.Width = 30;
            // 
            // deleteCol
            // 
            this.deleteCol.HeaderText = "";
            this.deleteCol.MinimumWidth = 6;
            this.deleteCol.Name = "deleteCol";
            this.deleteCol.ReadOnly = true;
            this.deleteCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteCol.Text = "Delete";
            this.deleteCol.Width = 30;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BottomPnl);
            this.panel2.Controls.Add(this.separator);
            this.panel2.Controls.Add(this.TopPnl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(13, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1535, 714);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AreaControl";
            this.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.Size = new System.Drawing.Size(1561, 738);
            this.Load += new System.EventHandler(this.AreaScreen_Load);
            this.TopPnl.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.searchPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.filterPnl.ResumeLayout(false);
            this.buttonsPnl.ResumeLayout(false);
            this.tabpanePnl.ResumeLayout(false);
            this.tabpanePnl.PerformLayout();
            this.BottomPnl.ResumeLayout(false);
            this.PaginationPnl.ResumeLayout(false);
            this.ItemPerPagePnl.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.PageNumberPnl.ResumeLayout(false);
            this.nextPnl.ResumeLayout(false);
            this.currentpagePnl.ResumeLayout(false);
            this.currentpagePnl.PerformLayout();
            this.previousPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel TopPnl;
        private System.Windows.Forms.Panel tabpanePnl;
        private System.Windows.Forms.RadioButton vistorBtn;
        private System.Windows.Forms.RadioButton residentBtn;
        private System.Windows.Forms.RadioButton allBtn;
        private System.Windows.Forms.Panel separator;
        private System.Windows.Forms.Panel BottomPnl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private DataGridView table;
        private Panel PaginationPnl;
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
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel searchPnl;
        private PictureBox pictureBox2;
        private Sunny.UI.UITextBox searchTb;
        private Sunny.UI.UIPanel filterPnl;
        private Sunny.UI.UIComboBox filterCb;
        private Panel buttonsPnl;
        private Sunny.UI.UISymbolButton addBtn;
        private Panel ItemPerPagePnl;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIComboBox numberofitemsCb;
    }
}
