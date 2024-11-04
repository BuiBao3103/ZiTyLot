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
                string id = string.Empty;
                string idTmp = string.Empty;
                ParkingLotStatus status = ParkingLotStatus.AVAILABLE;
                if (rbtnClosed.Checked) status = ParkingLotStatus.CLOSED;
                if (rbtnMaintenace.Checked) status = ParkingLotStatus.UNDER_MAINTENANCE;

                int userTypeIndex = cbUserType.SelectedIndex;
                ParkingLotUserType parkingUserType = userTypeIndex == 0 ? ParkingLotUserType.RESIDENT : ParkingLotUserType.VISITOR;

                int vehicleTypeIndex = cbVehicalType.SelectedIndex;
                ParkingLotType parkingLotType = vehicleTypeIndex == 0 ? ParkingLotType.TWO_WHEELER : ParkingLotType.FOUR_WHEELER;

               
                if (parkingUserType.Equals(ParkingLotUserType.RESIDENT))
                {
                    if (parkingLotType.Equals(ParkingLotType.TWO_WHEELER))
                    {
                        idTmp = "RL2W-";
                        id = generationId(idTmp);
                    }
                    else
                    {
                        idTmp = "RL4W-";
                        id = generationId(idTmp);
                    }
                }
                if (parkingUserType.Equals(ParkingLotUserType.VISITOR))
                {
                    if (parkingLotType.Equals(ParkingLotType.TWO_WHEELER))
                    {
                        idTmp = "VL2W-";
                        id = generationId(idTmp);
                    }
                    else
                    {
                        idTmp = "VL4W-";
                        id = generationId(idTmp);
                    }
                }

                ParkingLot parkingLot = new ParkingLot
                {
                   Id = id,
                   Total_slot = int.Parse(tbTotalSlot.Text),
                   Parking_lot_type = parkingLotType,
                   User_type = parkingUserType,
                   Status = status,
                   Created_at = DateTime.Now
                };
                parkingLotBUS.Add(parkingLot);
                MessageHelper.ShowSuccess("Parking lot added successfully!");
                AreaInsertionEvent?.Invoke(this,EventArgs.Empty);
                this.Close();
            }
            catch (ValidationException ex) 
            {
                MessageHelper.ShowWarning(ex.Message);
            }
            catch (BusinessException ex)
            {
                MessageHelper.ShowWarning(ex.Message);
            }
            catch (Exception)
            {
                MessageHelper.ShowWarning("An unexpected error occurred. Please try again later.");
            }
        }

        private string generationId(string id) 
        {
            string idIdentity = string.Empty;
            List<FilterCondition> filters = new List<FilterCondition>();
            filters.Add(new FilterCondition("Id", CompOp.Like, id));
            List<ParkingLot> lists = parkingLotBUS.GetAll(filters);
            string[] tmp = lists.Last().Id.Split("-");
            string generate = tmp[1];
            int generateId = int.Parse(generate[1].ToString()) + 1;
            idIdentity = id + generate[0].ToString() + generateId.ToString();
            return idIdentity;
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
