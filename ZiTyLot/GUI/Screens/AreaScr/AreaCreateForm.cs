using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.Constants.Enum;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Utils;

namespace ZiTyLot.GUI.Screens.AreaScr
{
    public partial class AreaCreateForm : Form
    {
        private readonly ParkingLotBUS parkingLotBUS = new ParkingLotBUS();
        public event EventHandler AreaInsertionEvent;

        public AreaCreateForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbTotalSlot_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputValidator.ValidateNumericKeyPress(tbTotalSlot.Text, e.KeyChar);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            try
            {
                int userTypeIndex = cbUserType.SelectedIndex;
                ParkingLotUserType parkingUserType = userTypeIndex == 0 ? ParkingLotUserType.RESIDENT : ParkingLotUserType.VISITOR;

                int vehicleTypeIndex = cbVehicalType.SelectedIndex;
                ParkingLotType parkingLotType = vehicleTypeIndex == 0 ? ParkingLotType.TWO_WHEELER : ParkingLotType.FOUR_WHEELER;


                ParkingLot parkingLot = new ParkingLot
                {
                    Id = tbID.Text,
                    Total_slot = int.Parse(tbTotalSlot.Text),
                    Parking_lot_type = parkingLotType,
                    User_type = parkingUserType,
                    Status = ParkingLotStatus.AVAILABLE,
                };
                parkingLotBUS.Create(parkingLot);
                MessageHelper.ShowSuccess("Parking lot added successfully!");
                AreaInsertionEvent?.Invoke(this, EventArgs.Empty);
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
            if (string.IsNullOrEmpty(tbID.Text))
            {
                MessageHelper.ShowWarning("Please enter ID");
                tbID.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbTotalSlot.Text))
            {
                MessageHelper.ShowWarning("Please enter total slot");
                tbTotalSlot.Focus();
                return false;
            }

            return true;
        }

        private void UpdatePreID()
        {
            string preID = "";

            int userTypeIndex = cbUserType.SelectedIndex;
            ParkingLotUserType parkingUserType = userTypeIndex == 0 ? ParkingLotUserType.RESIDENT : ParkingLotUserType.VISITOR;
            preID += parkingUserType == ParkingLotUserType.RESIDENT ? "R\\L" : "V\\L";

            int vehicleTypeIndex = cbVehicalType.SelectedIndex;
            ParkingLotType parkingLotType = vehicleTypeIndex == 0 ? ParkingLotType.TWO_WHEELER : ParkingLotType.FOUR_WHEELER;
            preID += parkingLotType == ParkingLotType.TWO_WHEELER ? "2W" : "4W";

            tbID.Mask = $"{preID}-00";
        }

        private void cbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePreID();
        }

        private void cbVehicalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePreID();
        }

        private void AreaCreateForm_Load(object sender, EventArgs e)
        {
            this.tbID.Mask = "R\\L2W-00";
        }
    }
}
