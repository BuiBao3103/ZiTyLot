using System;
using System.Drawing;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.Constants.Enum;
using ZiTyLot.ENTITY;

namespace ZiTyLot.GUI.Screens.AreaScr
{
    public partial class AreaDetailForm : Form
    {
        private readonly ParkingLotBUS parkingLotBUS = new ParkingLotBUS();
        public readonly ParkingLot parkingLot;
        public event EventHandler AreaUpdateEvent;
        public AreaDetailForm(string areaId)
        {
            InitializeComponent();
            this.CenterToScreen();
            parkingLot = parkingLotBUS.GetById(areaId);

            if (parkingLot.User_type == ParkingLotUserType.VISITOR)
            {
                cbUserType.SelectedIndex = 1;
            }

            if (parkingLot.Parking_lot_type == ParkingLotType.FOUR_WHEELER) 
            {
                cbVehicalType.SelectedIndex = 1;
            }

            if (parkingLot.Status == ParkingLotStatus.UNDER_MAINTENANCE)
            {
                rbtnMaintenace.Checked = true;
            }

            if (parkingLot.Status == ParkingLotStatus.CLOSED)
            {
                rbtnClosed.Checked = true;
            }

            tbTotalSlot.Text = parkingLot.Total_slot.ToString();
           

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           

        }

        private void AreaDetailForm_Load(object sender, EventArgs e)
        {
            this.tableSlot.Paint += new System.Windows.Forms.PaintEventHandler(this.table_Paint);
            this.tableSlot.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.table_CellPainting);
            this.tableSlot.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
        }

        private void table_Paint(object sender, PaintEventArgs e)
        {
            Rectangle firstHeaderCellRect = this.tableSlot.GetCellDisplayRectangle(this.tableSlot.Columns["colAction"].Index, -1, true);
            Rectangle lastHeaderCellRect = this.tableSlot.GetCellDisplayRectangle(this.tableSlot.Columns["colDelete"].Index, -1, true);
            Rectangle mergedHeaderRect = new Rectangle(firstHeaderCellRect.X, firstHeaderCellRect.Y, lastHeaderCellRect.X + lastHeaderCellRect.Width - firstHeaderCellRect.X, firstHeaderCellRect.Height);
            e.Graphics.FillRectangle(new SolidBrush(Color.White), mergedHeaderRect);
            TextRenderer.DrawText(e.Graphics, "Action", this.tableSlot.ColumnHeadersDefaultCellStyle.Font,
                mergedHeaderRect, this.tableSlot.ColumnHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
        private void table_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if ((e.ColumnIndex == tableSlot.Columns["colAction"].Index || e.ColumnIndex == tableSlot.Columns["colDelete"].Index) && e.RowIndex >= 0)
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
                if (e.ColumnIndex == tableSlot.Columns["colAction"].Index)
                {
                    icon = Properties.Resources.Icon_18x18px_View;
                }
                else if (e.ColumnIndex == tableSlot.Columns["colDelete"].Index)
                {
                    icon = Properties.Resources.Icon_18x18px_Remove;
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
                if (e.ColumnIndex == tableSlot.Columns["colAction"].Index)
                {
                    MessageBox.Show("View button clicked for row " + e.RowIndex);
                }
                else if (e.ColumnIndex == tableSlot.Columns["colDelete"].Index)
                {
                    MessageBox.Show("Delete button clicked for row " + e.RowIndex);
                }
            }
        }

        private void btnAddSlot_Click(object sender, EventArgs e)
        {

        }
    }
}
