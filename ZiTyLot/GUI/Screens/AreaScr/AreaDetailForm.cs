using System;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.Constants.Enum;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.Utils;

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
            if (!ValidateInput()) return;
            try
            {
                ParkingLotStatus status = ParkingLotStatus.AVAILABLE;
                if (rbtnClosed.Checked) status = ParkingLotStatus.CLOSED;
                if (rbtnMaintenace.Checked) status = ParkingLotStatus.UNDER_MAINTENANCE;

                int userTypeIndex = cbUserType.SelectedIndex;
                ParkingLotUserType parkingUserType = userTypeIndex == 0 ? ParkingLotUserType.RESIDENT : ParkingLotUserType.VISITOR;

                int vehicleTypeIndex = cbVehicalType.SelectedIndex;
                ParkingLotType parkingLotType = vehicleTypeIndex == 0 ? ParkingLotType.TWO_WHEELER : ParkingLotType.FOUR_WHEELER;

                parkingLot.Total_slot = int.Parse(tbTotalSlot.Text);
                parkingLot.Parking_lot_type = parkingLotType;
                parkingLot.User_type = parkingUserType;
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
    }
}
