﻿using System.Windows.Forms;

namespace ZiTyLot.GUI.Screens
{
    partial class RoleScreen
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
            this.searchPnl = new System.Windows.Forms.Panel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.searchTb = new Sunny.UI.UITextBox();
            this.buttonsPnl = new System.Windows.Forms.Panel();
            this.separator = new System.Windows.Forms.Panel();
            this.BottomPnl = new System.Windows.Forms.Panel();
            this.table = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.addBtn = new Sunny.UI.UISymbolButton();
            this.TopPnl.SuspendLayout();
            this.searchPnl.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.buttonsPnl.SuspendLayout();
            this.BottomPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPnl
            // 
            this.TopPnl.BackColor = System.Drawing.Color.White;
            this.TopPnl.Controls.Add(this.searchPnl);
            this.TopPnl.Controls.Add(this.buttonsPnl);
            this.TopPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPnl.Location = new System.Drawing.Point(0, 0);
            this.TopPnl.Name = "TopPnl";
            this.TopPnl.Padding = new System.Windows.Forms.Padding(10);
            this.TopPnl.Size = new System.Drawing.Size(1151, 54);
            this.TopPnl.TabIndex = 1;
            this.TopPnl.Resize += new System.EventHandler(this.TopPnl_Resize);
            // 
            // searchPnl
            // 
            this.searchPnl.BackColor = System.Drawing.Color.White;
            this.searchPnl.Controls.Add(this.uiPanel1);
            this.searchPnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchPnl.Location = new System.Drawing.Point(611, 10);
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
            // buttonsPnl
            // 
            this.buttonsPnl.Controls.Add(this.addBtn);
            this.buttonsPnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonsPnl.Location = new System.Drawing.Point(1011, 10);
            this.buttonsPnl.Name = "buttonsPnl";
            this.buttonsPnl.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonsPnl.Size = new System.Drawing.Size(130, 34);
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
            this.descriptionCol,
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
            // descriptionCol
            // 
            this.descriptionCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionCol.HeaderText = "Description";
            this.descriptionCol.Name = "descriptionCol";
            this.descriptionCol.ReadOnly = true;
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
            this.editCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.addBtn.Padding = new System.Windows.Forms.Padding(12, 0, 8, 0);
            this.addBtn.Radius = 12;
            this.addBtn.RectColor = System.Drawing.Color.White;
            this.addBtn.RectDisableColor = System.Drawing.Color.White;
            this.addBtn.RectHoverColor = System.Drawing.Color.White;
            this.addBtn.RectPressColor = System.Drawing.Color.White;
            this.addBtn.RectSelectedColor = System.Drawing.Color.White;
            this.addBtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.addBtn.RectSize = 2;
            this.addBtn.Size = new System.Drawing.Size(120, 34);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "New role";
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBtn.TipsFont = new System.Drawing.Font("Helvetica Rounded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // RoleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.Name = "RoleScreen";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1171, 600);
            this.Load += new System.EventHandler(this.RoleScreen_Load);
            this.TopPnl.ResumeLayout(false);
            this.searchPnl.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.buttonsPnl.ResumeLayout(false);
            this.BottomPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel TopPnl;
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
        private DataGridView table;
        private DataGridViewTextBoxColumn idCol;
        private DataGridViewTextBoxColumn nameCol;
        private DataGridViewTextBoxColumn descriptionCol;
        private DataGridViewButtonColumn viewCol;
        private DataGridViewButtonColumn editCol;
        private DataGridViewButtonColumn deleteCol;
    }
}