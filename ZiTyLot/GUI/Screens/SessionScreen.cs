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
    public partial class SessionScreen : UserControl
    {
        public SessionScreen()
        {
            InitializeComponent();
        }

        private void SessionScreen_Load(object sender, EventArgs e)
        {
            TopPnl.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, TopPnl.Width, TopPnl.Height, 10, 10));
            BottomPnl.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, BottomPnl.Width, BottomPnl.Height, 10, 10));
            allBtn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, allBtn.Width, allBtn.Height, 24,24));
            checkInBtn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, checkInBtn.Width, checkInBtn.Height, 24,24));
            checkOutBtn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, checkOutBtn.Width, checkOutBtn.Height, 24,24));
            allBtn.Checked = true;
            this.allBtn.CheckedChanged += new System.EventHandler(this.allFilter_CheckedChanged);
            this.checkInBtn.CheckedChanged += new System.EventHandler(this.checkInFilter_CheckedChanged);
            this.checkOutBtn.CheckedChanged += new System.EventHandler(this.checkOutFilter_CheckedChanged);
            this.table.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.table_CellPainting);
            this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
        }
        // Paint the cell
        private void table_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == table.Columns["actionCol"].Index && e.RowIndex >= 0)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.White), e.CellBounds);
                Image icon = null;
                icon = Properties.Resources.Icon_18x18px_View;
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
                if (e.ColumnIndex == table.Columns["actionCol"].Index)
                {
                    MessageBox.Show("View button clicked for row " + e.RowIndex);
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
        private void checkInFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkInBtn.Checked)
            {
                checkInBtn.BackColor = Color.FromArgb(240, 118, 54); 
                checkInBtn.ForeColor = Color.White;  
                checkInBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_CheckIn_Active;  
            }
            else
            {
                checkInBtn.BackColor = Color.White;  
                checkInBtn.ForeColor = Color.FromArgb(160, 160, 160);  
                checkInBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_CheckIn;  
            }
        }

        // CheckOut Filter CheckedChanged event handler
        private void checkOutFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOutBtn.Checked)
            {
                checkOutBtn.BackColor = Color.FromArgb(240, 118, 54);  
                checkOutBtn.ForeColor = Color.White;  
                checkOutBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_CheckOut_Active; 
            }
            else
            {
                checkOutBtn.BackColor = Color.White;  
                checkOutBtn.ForeColor = Color.FromArgb(160, 160, 160);  
                checkOutBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_CheckOut;  
            }
        }
    }
}