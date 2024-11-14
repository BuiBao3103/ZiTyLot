using Mysqlx.Crud;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.Constants.Enum;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.Utils;
using static Sunny.UI.SnowFlakeId;

namespace ZiTyLot.GUI.Screens.AreaScr
{
    public partial class AreaDetail4WForm : Form
    {
        private readonly ParkingLotBUS parkingLotBUS = new ParkingLotBUS();
        private readonly SlotBUS slotBUS = new SlotBUS();
        public readonly ParkingLot parkingLot;
        public event EventHandler AreaUpdateEvent;
        public AreaDetail4WForm(string areaId)
        {
            InitializeComponent();
            this.CenterToScreen();
            parkingLot = parkingLotBUS.GetById(areaId);
            parkingLot = parkingLotBUS.PopulateSlots(parkingLot);
            switch (parkingLot.Status)
            {
                case ParkingLotStatus.AVAILABLE:
                    rbtnAvaliable.Checked = true;
                    break;
                case ParkingLotStatus.CLOSED:
                    rbtnClosed.Checked = true;
                    break;
                case ParkingLotStatus.UNDER_MAINTENANCE:
                    rbtnMaintenace.Checked = true;
                    break;
            }

            lbPreID.Text = parkingLot.Id;
            lbUserType.Text = parkingLot.User_type.ToString();
            lbVehicleType.Text = parkingLot.Parking_lot_type.ToString();
            tbTotalSlot.Text = parkingLot.Total_slot.ToString();
            btnDelSlot.Enabled = parkingLot.Total_slot > 0;
            LoadSlots();


        }

        private void LoadSlots()
        {
            tableSlot.Rows.Clear();
            foreach (Slot slot in parkingLot.Slots)
            {
                tableSlot.Rows.Add(slot.Id, slot.Status);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            try
            {
                ParkingLotStatus status = ParkingLotStatus.AVAILABLE;
                if (rbtnClosed.Checked) status = ParkingLotStatus.CLOSED;
                if (rbtnMaintenace.Checked) status = ParkingLotStatus.UNDER_MAINTENANCE;
                parkingLot.Total_slot = int.Parse(tbTotalSlot.Text);
                parkingLot.Status = status;
                parkingLot.Updated_at = DateTime.Now;
                parkingLotBUS.Update(parkingLot);
                MessageHelper.ShowSuccess("Parking lot updated successfully!");
                AreaUpdateEvent?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            catch (ValidationInputException ex)
            {
                MessageHelper.ShowWarning(ex.Message);
            }
            catch (BusinessException ex)
            {
                MessageHelper.ShowWarning(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageHelper.ShowWarning("An unexpected error occurred. Please try again later.");
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(tbTotalSlot.Text))
            {
                MessageHelper.ShowWarning("Please enter total slot");
                tbTotalSlot.Focus();
                return false;
            }

            return true;
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
                    icon = Properties.Resources.Icon_18x18px_Wrench;
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
                    string slotId = tableSlot.Rows[e.RowIndex].Cells[0].Value.ToString();
                    UpdateStatusSlot(slotId);

                }
                else if (e.ColumnIndex == tableSlot.Columns["colDelete"].Index)
                {
                    MessageBox.Show("Delete button clicked for row " + e.RowIndex);
                }
            }
        }

        private void btnAddSlot_Click(object sender, EventArgs e)
        {
            try
            {
                //update database
                parkingLot.Total_slot += 1;
                parkingLotBUS.Update(parkingLot);
                Slot newSlot = new Slot()
                {
                    Parking_lot_id = parkingLot.Id,
                    Status = SlotStatus.EMPTY,
                    Id = $"{parkingLot.Id}-S{parkingLot.Total_slot}",
                };
                slotBUS.Add(newSlot);
                parkingLot.Slots.Add(newSlot);
                //update UI

                LoadSlots();
                tbTotalSlot.Text = parkingLot.Total_slot.ToString();
                btnDelSlot.Enabled = parkingLot.Total_slot > 0;

                MessageHelper.ShowSuccess("Add slot successfully!");
                AreaUpdateEvent?.Invoke(this, EventArgs.Empty);
            }
            catch (ValidationInputException ex)
            {
                MessageHelper.ShowWarning(ex.Message);
            }
            catch (BusinessException ex)
            {
                MessageHelper.ShowWarning(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageHelper.ShowWarning("An unexpected error occurred. Please try again later.");
            }
        }

        private void UpdateStatusSlot(string slotId)
        {
            try
            {
                Slot slot = parkingLot.Slots.Find(s => s.Id == slotId);
                if (slot.Status == SlotStatus.IN_USE)
                {
                    throw new ValidationInputException("Cannot change status of slot in use");
                }
                if (slot.Status == SlotStatus.EMPTY)
                {
                    slot.Status = SlotStatus.MAINTENANCE;
                }
                else
                {
                    slot.Status = SlotStatus.EMPTY;
                }
                slotBUS.Update(slot);
                parkingLot.Slots[parkingLot.Slots.FindIndex(s => s.Id == slotId)] = slot;
                LoadSlots();
                MessageHelper.ShowSuccess("Update slot status successfully!");
                AreaUpdateEvent?.Invoke(this, EventArgs.Empty);
            }
            catch (ValidationInputException ex)
            {
                MessageHelper.ShowWarning(ex.Message);
            }
            catch (BusinessException ex)
            {
                MessageHelper.ShowWarning(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageHelper.ShowWarning("An unexpected error occurred. Please try again later.");
            }
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Slot slot = parkingLot.Slots.Last();
                if (slot.Status == SlotStatus.IN_USE)
                {
                    throw new ValidationInputException("Cannot delete slot in use");
                }
                slotBUS.Delete(slot.Id);
                parkingLot.Total_slot -= 1;
                parkingLotBUS.Update(parkingLot);

                parkingLot.Slots.Remove(slot);
                LoadSlots();
                tbTotalSlot.Text = parkingLot.Total_slot.ToString();
                btnDelSlot.Enabled = parkingLot.Total_slot > 0;

                MessageHelper.ShowSuccess("Delete slot successfully!");
                AreaUpdateEvent?.Invoke(this, EventArgs.Empty);
            }
            catch (ValidationInputException ex)
            {
                MessageHelper.ShowWarning(ex.Message);
            }
            catch (BusinessException ex)
            {
                MessageHelper.ShowWarning(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageHelper.ShowWarning("An unexpected error occurred. Please try again later.");
            }
        }
    }
}
