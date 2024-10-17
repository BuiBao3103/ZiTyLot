using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.component_extensions;

namespace ZiTyLot.GUI.Screens
{
    public partial class PriceControl : UserControl
    {
        VehicleTypeBUS vehicleTypeBUS = new VehicleTypeBUS();
        List<FilterCondition> filters = new List<FilterCondition>();
        List<VehicleType> vehicleTypes;
        public PriceControl()
        {
            InitializeComponent();
            LoadPageToTable();
        }
        private void LoadPageToTable()
        {
            vehicleTypes = vehicleTypeBUS.GetAll(filters);
            tableVehicalPrice.Rows.Clear();
            foreach (VehicleType vehicleType in vehicleTypes)
            {
                tableVehicalPrice.Rows.Add(vehicleType.Id, vehicleType.Name, Has(vehicleType.Has_vehicle_plate), Has(vehicleType.Has_slot));
            }
        }
        private string Has(bool has)
        {
            return has ? "Yes" : "No";
        }
        private void PriceScreen_Load(object sender, EventArgs e)
        {
            pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
            pnlBottom.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 10, 10));

            btnAdd.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, btnAdd.Width, btnAdd.Height, 10, 10));

            this.tableVehicalPrice.Paint += new System.Windows.Forms.PaintEventHandler(this.table_Paint);
            this.tableVehicalPrice.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.table_CellPainting);
            this.tableVehicalPrice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
        }
        // Paint the header cell
        private void table_Paint(object sender, PaintEventArgs e)
        {
            Rectangle firstHeaderCellRect = this.tableVehicalPrice.GetCellDisplayRectangle(this.tableVehicalPrice.Columns["colView"].Index, -1, true);
            Rectangle lastHeaderCellRect = this.tableVehicalPrice.GetCellDisplayRectangle(this.tableVehicalPrice.Columns["colDelete"].Index, -1, true);
            Rectangle mergedHeaderRect = new Rectangle(firstHeaderCellRect.X, firstHeaderCellRect.Y, lastHeaderCellRect.X + lastHeaderCellRect.Width - firstHeaderCellRect.X, firstHeaderCellRect.Height);
            e.Graphics.FillRectangle(new SolidBrush(Color.White), mergedHeaderRect);
            TextRenderer.DrawText(e.Graphics, "Action", this.tableVehicalPrice.ColumnHeadersDefaultCellStyle.Font,
                mergedHeaderRect, this.tableVehicalPrice.ColumnHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
        // Paint the cell
        private void table_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if ((e.ColumnIndex == tableVehicalPrice.Columns["colView"].Index ||
                 e.ColumnIndex == tableVehicalPrice.Columns["colEdit"].Index ||
                 e.ColumnIndex == tableVehicalPrice.Columns["colDelete"].Index) && e.RowIndex >= 0)
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
                if (e.ColumnIndex == tableVehicalPrice.Columns["colView"].Index)
                {
                    icon = Properties.Resources.Icon_18x18px_View;
                }
                else if (e.ColumnIndex == tableVehicalPrice.Columns["colEdit"].Index)
                {
                    icon = Properties.Resources.Icon_18x18px_Edit;
                }
                else if (e.ColumnIndex == tableVehicalPrice.Columns["colDelete"].Index)
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
                if (e.ColumnIndex == tableVehicalPrice.Columns["colView"].Index)
                {
                    MessageBox.Show("View button clicked for row " + e.RowIndex);
                }
                else if (e.ColumnIndex == tableVehicalPrice.Columns["colEdit"].Index)
                {
                    MessageBox.Show("Edit button clicked for row " + e.RowIndex);
                }
                else if (e.ColumnIndex == tableVehicalPrice.Columns["colDelete"].Index)
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

    }
}