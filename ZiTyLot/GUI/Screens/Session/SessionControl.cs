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
    public partial class SessionControl : UserControl
    {
        public SessionControl()
        {
            InitializeComponent();
        }

        private void SessionScreen_Load(object sender, EventArgs e)
        {
            pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
            pnlBottom.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 10, 10));
            btnAll.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, btnAll.Width, btnAll.Height, 10,10));
            btnCheckIn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, btnCheckIn.Width, btnCheckIn.Height, 10,10));
            btnCheckOut.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, btnCheckOut.Width, btnCheckOut.Height, 10,10));
            btnAll.Checked = true;
            this.btnAll.CheckedChanged += new System.EventHandler(this.allFilter_CheckedChanged);
            this.btnCheckIn.CheckedChanged += new System.EventHandler(this.checkInFilter_CheckedChanged);
            this.btnCheckOut.CheckedChanged += new System.EventHandler(this.checkOutFilter_CheckedChanged);
            this.tableSession.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.table_CellPainting);
            this.tableSession.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
        }
        // Paint the cell
        private void table_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == tableSession.Columns["colView"].Index && e.RowIndex >= 0)
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
                if (e.ColumnIndex == tableSession.Columns["colView"].Index)
                {
                    MessageBox.Show("View button clicked for row " + e.RowIndex);
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
        private void checkInFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (btnCheckIn.Checked)
            {
                btnCheckIn.BackColor = Color.FromArgb(240, 118, 54); 
                btnCheckIn.ForeColor = Color.White;  
                btnCheckIn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_CheckIn_Active;  
            }
            else
            {
                btnCheckIn.BackColor = Color.White;  
                btnCheckIn.ForeColor = Color.FromArgb(160, 160, 160);  
                btnCheckIn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_CheckIn;  
            }
        }

        // CheckOut Filter CheckedChanged event handler
        private void checkOutFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (btnCheckOut.Checked)
            {
                btnCheckOut.BackColor = Color.FromArgb(240, 118, 54);  
                btnCheckOut.ForeColor = Color.White;  
                btnCheckOut.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_CheckOut_Active; 
            }
            else
            {
                btnCheckOut.BackColor = Color.White;  
                btnCheckOut.ForeColor = Color.FromArgb(160, 160, 160);  
                btnCheckOut.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_CheckOut;  
            }
        }
    }
}