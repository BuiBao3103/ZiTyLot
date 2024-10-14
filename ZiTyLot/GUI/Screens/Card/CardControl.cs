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
    public partial class CardControl : UserControl
    {
        public CardControl()
        {
            InitializeComponent();
        }

        private void CardScreen_Load(object sender, EventArgs e)
        {
            pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
            pnlBottom.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 10, 10));

            btnAdd.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, btnAdd.Width, btnAdd.Height, 10, 10));
            btnAll.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, btnAll.Width, btnAll.Height, 10,10));
            btnActive.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, btnActive.Width, btnActive.Height, 10,10));
            btnEmpty.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, btnEmpty.Width, btnEmpty.Height, 10,10));
            btnLocked.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, btnLocked.Width, btnLocked.Height, 10,10));
            btnLost.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, btnLost.Width, btnLost.Height, 10,10));

            btnAll.Checked = true;

            this.tableCard.Paint += new System.Windows.Forms.PaintEventHandler(this.table_Paint);
            this.tableCard.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.table_CellPainting);
            this.tableCard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
        }
        // Paint the header cell
        private void table_Paint(object sender, PaintEventArgs e)
        {
            Rectangle firstHeaderCellRect = this.tableCard.GetCellDisplayRectangle(this.tableCard.Columns["colView"].Index, -1, true);
            Rectangle lastHeaderCellRect = this.tableCard.GetCellDisplayRectangle(this.tableCard.Columns["colDelete"].Index, -1, true);
            Rectangle mergedHeaderRect = new Rectangle(firstHeaderCellRect.X, firstHeaderCellRect.Y,lastHeaderCellRect.X + lastHeaderCellRect.Width - firstHeaderCellRect.X, firstHeaderCellRect.Height);
            e.Graphics.FillRectangle(new SolidBrush(Color.White), mergedHeaderRect);
            TextRenderer.DrawText(e.Graphics, "Action", this.tableCard.ColumnHeadersDefaultCellStyle.Font,
                mergedHeaderRect, this.tableCard.ColumnHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
        // Paint the cell
        private void table_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if ((e.ColumnIndex == tableCard.Columns["colView"].Index ||
                 e.ColumnIndex == tableCard.Columns["colEdit"].Index ||
                 e.ColumnIndex == tableCard.Columns["colDelete"].Index) && e.RowIndex >= 0)
            {
                if (e.RowIndex % 2 == 0)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.WhiteSmoke), e.CellBounds);
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.White), e.CellBounds);
                }
                Image icon = null;
                if (e.ColumnIndex == tableCard.Columns["colView"].Index)
                {
                    icon = Properties.Resources.Icon_18x18px_View;
                }
                else if (e.ColumnIndex == tableCard.Columns["colEdit"].Index)
                {
                    icon = Properties.Resources.Icon_18x18px_Edit;
                }
                else if (e.ColumnIndex == tableCard.Columns["colDelete"].Index)
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
                if (e.ColumnIndex == tableCard.Columns["colView"].Index)
                {
                    MessageBox.Show("View button clicked for row " + e.RowIndex);
                }
                else if (e.ColumnIndex == tableCard.Columns["colEdit"].Index)
                {
                    MessageBox.Show("Edit button clicked for row " + e.RowIndex);
                }
                else if (e.ColumnIndex == tableCard.Columns["colDelete"].Index)
                {
                    MessageBox.Show("Delete button clicked for row " + e.RowIndex);
                }
            }
        }

        private void TopPnl_Resize(object sender, EventArgs e)
        {
            pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
        }

        private void BottomPnl_Resize(object sender, EventArgs e)
        {
            pnlBottom.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 10, 10));
        }

        // All Filter CheckedChanged event handler
        private void allFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (btnAll.Checked)
            {
                btnAll.BackColor = Color.FromArgb(240, 118, 54);  
                btnAll.ForeColor = Color.White;  
                btnAll.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_All_Active;  
            }
            else
            {
                btnAll.BackColor = Color.White;  
                btnAll.ForeColor = Color.FromArgb(160, 160, 160); 
                btnAll.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_All; 
            }
        }
        // CheckIn Filter CheckedChanged event handler
        private void activeFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (btnActive.Checked)
            {
                btnActive.BackColor = Color.FromArgb(240, 118, 54); 
                btnActive.ForeColor = Color.White;  
                btnActive.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Active_Active;  
            }
            else
            {
                btnActive.BackColor = Color.White;  
                btnActive.ForeColor = Color.FromArgb(160, 160, 160);  
                btnActive.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Active;  
            }
        }

        // CheckOut Filter CheckedChanged event handler
        private void emptyFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (btnEmpty.Checked)
            {
                btnEmpty.BackColor = Color.FromArgb(240, 118, 54);  
                btnEmpty.ForeColor = Color.White;  
                btnEmpty.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Empty_Active; 
            }
            else
            {
                btnEmpty.BackColor = Color.White;  
                btnEmpty.ForeColor = Color.FromArgb(160, 160, 160);  
                btnEmpty.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Empty;  
            }
        }
        private void lostFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (btnLost.Checked)
            {
                btnLost.BackColor = Color.FromArgb(240, 118, 54);
                btnLost.ForeColor = Color.White;
                btnLost.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Lost_Active;
            }
            else
            {
                btnLost.BackColor = Color.White;
                btnLost.ForeColor = Color.FromArgb(160, 160, 160);
                btnLost.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Lost;
            }
        }
        private void lockedFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (btnLocked.Checked)
            {
                btnLocked.BackColor = Color.FromArgb(240, 118, 54);
                btnLocked.ForeColor = Color.White;
                btnLocked.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Lock_Active;
            }
            else
            {
                btnLocked.BackColor = Color.White;
                btnLocked.ForeColor = Color.FromArgb(160, 160, 160);
                btnLocked.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Lock;
            }
        }

        private void excelMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            menuMore.Show(btnMore, new Point(-100, btnMore.Height + 10));
        }

        private void downloadTemplateMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}