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
    public partial class AreaScreen : UserControl
    {
        public AreaScreen()
        {
            InitializeComponent();
        }

        private void AreaScreen_Load(object sender, EventArgs e)
        {
            TopPnl.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, TopPnl.Width, TopPnl.Height, 10, 10));
            BottomPnl.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, BottomPnl.Width, BottomPnl.Height, 10, 10));

            addBtn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, addBtn.Width, addBtn.Height, 10, 10));
            allBtn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, allBtn.Width, allBtn.Height, 24,24));
            residentBtn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, residentBtn.Width, residentBtn.Height, 24,24));
            vistorBtn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, vistorBtn.Width, vistorBtn.Height, 24,24));

            allBtn.Checked = true;
            this.allBtn.CheckedChanged += new System.EventHandler(this.allFilter_CheckedChanged);
            this.residentBtn.CheckedChanged += new System.EventHandler(this.residentFilter_CheckedChanged);
            this.vistorBtn.CheckedChanged += new System.EventHandler(this.visitorFilter_CheckedChanged);
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
        private void residentFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (residentBtn.Checked)
            {
                residentBtn.BackColor = Color.FromArgb(240, 118, 54); 
                residentBtn.ForeColor = Color.White;  
                residentBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Resident_Active;  
            }
            else
            {
                residentBtn.BackColor = Color.White;  
                residentBtn.ForeColor = Color.FromArgb(160, 160, 160);  
                residentBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Resident;  
            }
        }

        // CheckOut Filter CheckedChanged event handler
        private void visitorFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (vistorBtn.Checked)
            {
                vistorBtn.BackColor = Color.FromArgb(240, 118, 54);  
                vistorBtn.ForeColor = Color.White;  
                vistorBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Vistor_Active; 
            }
            else
            {
                vistorBtn.BackColor = Color.White;  
                vistorBtn.ForeColor = Color.FromArgb(160, 160, 160);  
                vistorBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Visitor;  
            }
        }
    }
}