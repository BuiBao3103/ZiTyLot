using System;
using System.Drawing;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.Constants.Enum;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.Utils;

namespace ZiTyLot.GUI.Screens.AreaScr
{
    public partial class AreaDetail2WForm : Form
    {
        private readonly ParkingLotBUS parkingLotBUS = new ParkingLotBUS();
        public readonly ParkingLot parkingLot;
        public event EventHandler AreaUpdateEvent;
        public AreaDetail2WForm(string areaId)
        {
            InitializeComponent();
            this.CenterToScreen();
            parkingLot = parkingLotBUS.GetById(areaId);
            parkingLot = parkingLotBUS.PopulateSlots(parkingLot);
            switch(parkingLot.Status)
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
