using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Screens.SessionScr;

namespace ZiTyLot.GUI.Screens.LostCardScr
{
    public partial class LostCardControl : UserControl
    {
        public LostCardControl()
        {
            InitializeComponent();
            this.tableLostCard.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.table_CellPainting);
            this.tableLostCard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
        }

        private void table_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == tableLostCard.Columns["colRestore"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex % 2 == 0)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.WhiteSmoke), e.CellBounds);
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.White), e.CellBounds);
                }
                System.Drawing.Image icon = null;
                icon = Properties.Resources.Icon_18x18px_View ;
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
                if (e.ColumnIndex == tableLostCard.Columns["colRestore"].Index)
                {
                    Console.WriteLine("Restore");
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (pnlTop.Height == 54)
            {
                pnlTop.Height = 108;
            }
            else
            {
                pnlTop.Height = 54;
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbFilter.SelectedIndex;
            switch (index)
            {
                case 0:
                    tableSearch.ColumnStyles[1] = new ColumnStyle(SizeType.Absolute, 65);
                    break;
                case 1:
                    tableSearch.ColumnStyles[1] = new ColumnStyle(SizeType.Absolute, 85);
                    break;
                case 2:
                    tableSearch.ColumnStyles[1] = new ColumnStyle(SizeType.Absolute, 130);
                    break;
                default:
                    tableSearch.ColumnStyles[1] = new ColumnStyle(SizeType.Absolute, 130);
                    break;
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

        private void LostCardControl_Load(object sender, EventArgs e)
        {
            this.pnlTop.Height = 54;
            this.pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
            this.pnlBottom.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 10, 10));
        }

        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            if (pnlTop.Height == 54)
            {
                pnlTop.Height = 108;
            }
            else
            {
                pnlTop.Height = 54;
            }   
        }
    }

}
