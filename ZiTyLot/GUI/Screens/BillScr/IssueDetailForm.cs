using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.Constants.Enum;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.Utils;

namespace ZiTyLot.GUI.Screens.BillScr
{
    public partial class IssueDetailForm : Form
    {
        public Issue _newIssue;
        private readonly ResidentFeeBUS _residentFeeBUS;
        private readonly VehicleTypeBUS _vehicleTypeBUS;
        private readonly ParkingLotBUS _parkingLotBUS;
        private readonly SlotBUS _slotBUS;

        private List<ResidentFee> _residentFees;
        private List<VehicleType> _vehicleTypes;
        private List<ParkingLot> _parkingLots;
        private List<Slot> _slots;

        private VehicleType _selectedVehicleType;

        public event EventHandler IssueInsertionEvent;
        public IssueDetailForm()
        {
            _vehicleTypeBUS = new VehicleTypeBUS();
            _residentFeeBUS = new ResidentFeeBUS();
            _parkingLotBUS = new ParkingLotBUS();
            _slotBUS = new SlotBUS();

            InitializeComponent();
            InitForm();
            this.CenterToScreen();
        }

        private void InitForm()
        {
            _residentFees = _residentFeeBUS.GetAll();
            _vehicleTypes = _vehicleTypeBUS.GetAll();
            List<FilterCondition> filtersParkingLot = new List<FilterCondition>() {
                new FilterCondition(nameof(ParkingLot.Status),CompOp.Equals,ParkingLotStatus.AVAILABLE),
                new FilterCondition(nameof(ParkingLot.User_type),CompOp.Equals,ParkingLotUserType.RESIDENT)
            };
            _parkingLots = _parkingLotBUS.GetAll(filtersParkingLot);
            List<FilterCondition> filterSlots = new List<FilterCondition>() {
                new FilterCondition(nameof(Slot.Status),CompOp.Equals,SlotStatus.EMPTY)
            };
            _slots = _slotBUS.GetAll();
            foreach (var vehicleType in _vehicleTypes)
            {
                cbVehicleType.Items.Add(vehicleType.Name);
            }
            cbVehicleType.SelectedIndex = 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!validateForm()) return;
            string selectedSlotId = cbSlot.SelectedItem?.ToString();
            _newIssue = new Issue()
            {
                Start_date = dtpFromDate.Value,
                End_date = dtpToDate.Value,
                License_plate = tbPlate.Text,
                Fee = double.Parse(tbTotal.Text.Replace("₫", "").Replace(".", "")),
                Vehicle_type_id = _selectedVehicleType.Id,
                Parking_lot_id = cbArea.SelectedItem.ToString(),
                Slot_id = selectedSlotId,
            };

            IssueInsertionEvent?.Invoke(this, EventArgs.Empty);
            this.Dispose();
        }

        private bool validateForm()
        {
          
            if (_selectedVehicleType.Has_vehicle_plate && string.IsNullOrEmpty(tbPlate.Text))
            {
                MessageHelper.ShowWarning("Plate is required");
                tbPlate.Focus();
                return false;
            }
            if(cbMonth.SelectedIndex == -1)
            {
                MessageHelper.ShowWarning("Month is required");
                return false;
            }
            if (_selectedVehicleType.Has_slot && cbSlot.SelectedIndex == -1)
            {
                MessageHelper.ShowWarning("Slot is required");
                return false;
            }
            return true;
        }
        private void cbVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTotal.Text = "";
            string selectedVehicleType = cbVehicleType.SelectedItem.ToString();
            _selectedVehicleType = _vehicleTypes.Find(x => x.Name == selectedVehicleType);
            cbMonth.Items.Clear();
            foreach (ResidentFee residentFee in _residentFees)
            {
                if (residentFee.Vehicle_type_id == _selectedVehicleType.Id)
                {
                    string monthFormat = residentFee.Month == 1 ? residentFee.Month + " month" : residentFee.Month + " months";
                    cbMonth.Items.Add(monthFormat);
                }
            }
            cbMonth.SelectedIndex = 0;

            tbPlate.Enabled = _selectedVehicleType.Has_vehicle_plate;
            if (!_selectedVehicleType.Has_vehicle_plate)
            {
                tbPlate.Text = "";
            }


            cbArea.Items.Clear();
            ParkingLotType parkingLotType = _selectedVehicleType.Has_slot ? ParkingLotType.FOUR_WHEELER : ParkingLotType.TWO_WHEELER;
            foreach (ParkingLot parkingLot in _parkingLots)
            {
                if (parkingLot.Parking_lot_type == parkingLotType)
                {
                    cbArea.Items.Add(parkingLot.Id);
                }
            }
            cbArea.SelectedIndex = 0;

        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMonth.SelectedIndex == -1)
            {
                return;
            }
            string selectedMonth = cbMonth.SelectedItem.ToString();
            int month = int.Parse(selectedMonth.Split(' ')[0]);
            ResidentFee residentFee = _residentFees.Find(x => x.Vehicle_type_id == _selectedVehicleType.Id && x.Month == month);
            tbTotal.Text = residentFee.Fee.ToString("C0", new System.Globalization.CultureInfo("vi-VN"));
            dtpToDate.Value = dtpFromDate.Value.AddMonths(month);
        }

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbArea.SelectedIndex == -1) return;
              
            string selectedParkingLot = cbArea.SelectedItem.ToString();
            cbSlot.Items.Clear();
            ParkingLot parkingLot = _parkingLots.Find(x => x.Id == selectedParkingLot);

            cbSlot.Enabled = parkingLot.Parking_lot_type == ParkingLotType.FOUR_WHEELER;
            if (parkingLot.Parking_lot_type != ParkingLotType.FOUR_WHEELER) return;

            foreach (var slot in _slots)
            {
                if (slot.Parking_lot_id == selectedParkingLot)
                {
                    cbSlot.Items.Add(slot.Id);
                }
            }
            cbSlot.SelectedIndex = 0;
        }

        private void tbPlate_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }
    }
}
