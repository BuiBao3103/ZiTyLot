﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiTyLot.GUI.component_extensions;

namespace ZiTyLot.GUI.Screens
{
    public partial class ResidentScreen : UserControl
    {
        public ResidentScreen()
        {
            InitializeComponent();
        }

        private void ResidentScreen_Load(object sender, EventArgs e)
        {
            TopPnl.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, TopPnl.Width, TopPnl.Height, 10, 10));
            BottomPnl.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, BottomPnl.Width, BottomPnl.Height, 10, 10));

            addBtn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, addBtn.Width, addBtn.Height, 10, 10));
            allBtn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, allBtn.Width, allBtn.Height, 24,24));
            maleBtn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, maleBtn.Width, maleBtn.Height, 24,24));
            femaleBtn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, femaleBtn.Width, femaleBtn.Height, 24,24));

            allBtn.Checked = true;
            this.table.Paint += new System.Windows.Forms.PaintEventHandler(this.table_Paint);
            this.table.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.table_CellPainting);
            this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
        }
        // Paint the header cell
        private void table_Paint(object sender, PaintEventArgs e)
        {
            Rectangle firstHeaderCellRect = this.table.GetCellDisplayRectangle(this.table.Columns["viewCol"].Index, -1, true);
            Rectangle lastHeaderCellRect = this.table.GetCellDisplayRectangle(this.table.Columns["deleteCol"].Index, -1, true);
            Rectangle mergedHeaderRect = new Rectangle(firstHeaderCellRect.X, firstHeaderCellRect.Y,lastHeaderCellRect.X + lastHeaderCellRect.Width - firstHeaderCellRect.X, firstHeaderCellRect.Height);
            e.Graphics.FillRectangle(new SolidBrush(Color.White), mergedHeaderRect);
            TextRenderer.DrawText(e.Graphics, "Action", this.table.ColumnHeadersDefaultCellStyle.Font,
                mergedHeaderRect, this.table.ColumnHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
        // Paint the cell
        private void table_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if ((e.ColumnIndex == table.Columns["viewCol"].Index ||
                 e.ColumnIndex == table.Columns["editCol"].Index ||
                 e.ColumnIndex == table.Columns["deleteCol"].Index) && e.RowIndex >= 0)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.White), e.CellBounds);
                Image icon = null;
                if (e.ColumnIndex == table.Columns["viewCol"].Index)
                {
                    icon = Properties.Resources.Icon_18x18px_View;  
                }
                else if (e.ColumnIndex == table.Columns["editCol"].Index)
                {
                    icon = Properties.Resources.Icon_18x18px_Edit;  
                }
                else if (e.ColumnIndex == table.Columns["deleteCol"].Index)
                {
                    icon = Properties.Resources.Icon_18x18px_Delete;  
                }
                int iconWidth = 16;  
                int iconHeight = 16; 
                int x = e.CellBounds.Left + (e.CellBounds.Width - iconWidth) / 2;
                int y = e.CellBounds.Top + (e.CellBounds.Height - iconHeight) / 2;
                if (icon != null)
                {
                    e.Graphics.DrawImage(icon, new Rectangle(x, y, iconWidth, iconHeight));
                }
                e.Handled = true;
            }
        }
        // Cell click event handler
        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == table.Columns["viewCol"].Index)
                {
                    MessageBox.Show("View button clicked for row " + e.RowIndex);
                }
                else if (e.ColumnIndex == table.Columns["editCol"].Index)
                {
                    MessageBox.Show("Edit button clicked for row " + e.RowIndex);
                }
                else if (e.ColumnIndex == table.Columns["deleteCol"].Index)
                {
                    MessageBox.Show("Delete button clicked for row " + e.RowIndex);
                }
            }
        }

        private void TopPnl_Resize(object sender, EventArgs e)
        {
            TopPnl.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, TopPnl.Width, TopPnl.Height, 10, 10));
        }

        private void BottomPnl_Resize(object sender, EventArgs e)
        {
            BottomPnl.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, BottomPnl.Width, BottomPnl.Height, 10, 10));
        }

        // All Filter CheckedChanged event handler
        private void allFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (allBtn.Checked)
            {
                allBtn.BackColor = Color.FromArgb(240, 118, 54);  
                allBtn.ForeColor = Color.White;  
                allBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_All_Active;  
            }
            else
            {
                allBtn.BackColor = Color.White;  
                allBtn.ForeColor = Color.FromArgb(160, 160, 160); 
                allBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_All; 
            }
        }

        // male Filter CheckedChanged event handler
        private void maleFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (maleBtn.Checked)
            {
                maleBtn.BackColor = Color.FromArgb(240, 118, 54); 
                maleBtn.ForeColor = Color.White;  
                maleBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Male_Active;  
            }
            else
            {
                maleBtn.BackColor = Color.White;  
                maleBtn.ForeColor = Color.FromArgb(160, 160, 160);  
                maleBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Male;  
            }
        }

        // female Filter CheckedChanged event handler
        private void femaleFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (femaleBtn.Checked)
            {
                femaleBtn.BackColor = Color.FromArgb(240, 118, 54);  
                femaleBtn.ForeColor = Color.White;  
                femaleBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Female_Active; 
            }
            else
            {
                femaleBtn.BackColor = Color.White;  
                femaleBtn.ForeColor = Color.FromArgb(160, 160, 160);  
                femaleBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Female;  
            }
        }
    }
}