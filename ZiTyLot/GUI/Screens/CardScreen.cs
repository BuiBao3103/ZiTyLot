using System;
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
    public partial class CardScreen : UserControl
    {
        public CardScreen()
        {
            InitializeComponent();
        }

        private void CardScreen_Load(object sender, EventArgs e)
        {
            TopPnl.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, TopPnl.Width, TopPnl.Height, 10, 10));
            BottomPnl.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, BottomPnl.Width, BottomPnl.Height, 10, 10));

            addBtn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, addBtn.Width, addBtn.Height, 10, 10));
            allBtn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, allBtn.Width, allBtn.Height, 24,24));
            activeBtn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, activeBtn.Width, activeBtn.Height, 24,24));
            emptyBtn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, emptyBtn.Width, emptyBtn.Height, 24, 24));
            lockedBtn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, lockedBtn.Width, lockedBtn.Height, 24, 24));
            lostBtn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, lostBtn.Width, lostBtn.Height, 24, 24));

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
        // CheckIn Filter CheckedChanged event handler
        private void activeFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (activeBtn.Checked)
            {
                activeBtn.BackColor = Color.FromArgb(240, 118, 54); 
                activeBtn.ForeColor = Color.White;  
                activeBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Active_Active;  
            }
            else
            {
                activeBtn.BackColor = Color.White;  
                activeBtn.ForeColor = Color.FromArgb(160, 160, 160);  
                activeBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Active;  
            }
        }

        // CheckOut Filter CheckedChanged event handler
        private void emptyFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (emptyBtn.Checked)
            {
                emptyBtn.BackColor = Color.FromArgb(240, 118, 54);  
                emptyBtn.ForeColor = Color.White;  
                emptyBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Empty_Active; 
            }
            else
            {
                emptyBtn.BackColor = Color.White;  
                emptyBtn.ForeColor = Color.FromArgb(160, 160, 160);  
                emptyBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Empty;  
            }
        }
        private void lostFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (lostBtn.Checked)
            {
                lostBtn.BackColor = Color.FromArgb(240, 118, 54);
                lostBtn.ForeColor = Color.White;
                lostBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Lost_Active;
            }
            else
            {
                lostBtn.BackColor = Color.White;
                lostBtn.ForeColor = Color.FromArgb(160, 160, 160);
                lostBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Lost;
            }
        }
        private void lockedFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (lockedBtn.Checked)
            {
                lockedBtn.BackColor = Color.FromArgb(240, 118, 54);
                lockedBtn.ForeColor = Color.White;
                lockedBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Lock_Active;
            }
            else
            {
                lockedBtn.BackColor = Color.White;
                lockedBtn.ForeColor = Color.FromArgb(160, 160, 160);
                lockedBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Lock;
            }
        }
    }
}