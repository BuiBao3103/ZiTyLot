using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.Constants.Enum;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.Utils;
using ZiTyLot.Helper;

namespace ZiTyLot.GUI.Screens.BillScr
{
    public partial class IssueDetailForm : Form
    {
        private readonly Debouncer _debouncer = new Debouncer();
        public Issue _newIssue;
        private readonly ResidentFeeBUS _residentFeeBUS = new ResidentFeeBUS();
        private readonly VehicleTypeBUS _vehicleTypeBUS = new VehicleTypeBUS();
        private readonly ParkingLotBUS _parkingLotBUS = new ParkingLotBUS();
        private readonly SlotBUS _slotBUS = new SlotBUS();

        private List<ResidentFee> _residentFees;
        private List<VehicleType> _vehicleTypes;
        private List<ParkingLot> _parkingLots;
        private List<Slot> _slots;
        private List<Issue> _currentIssues;
        private VehicleType _selectedVehicleType;

        public event EventHandler IssueInsertionEvent;
        public IssueDetailForm(List<Issue> currentIssues)
        {
            _currentIssues = currentIssues;
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
            foreach (Issue issue in _currentIssues)
            {
                if (issue.Slot_id != null)
                {
                    Slot slot = _slots.Find(x => x.Id == issue.Slot_id);
                    _slots.Remove(slot);
                }
            }

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
            if (cbMonth.SelectedIndex == -1)
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
            SearchPlate();

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void tbPlate_TextChanged(object sender, EventArgs e)
        {
            await _debouncer.DebounceAsync(() =>
            {
                SearchPlate();
                return Task.CompletedTask;
            }, 500);
        }

        private void SearchPlate()
        {
            List<FilterCondition> filters = new List<FilterCondition>()
            {
                new FilterCondition(nameof(Issue.License_plate), CompOp.Equals, tbPlate.Text),
                new FilterCondition(nameof(Issue.End_date), CompOp.GreaterThan, DateTime.Now),
                new FilterCondition(nameof(Issue.Vehicle_type_id), CompOp.Equals, _selectedVehicleType.Id)
            };
            List<Issue> issues = new IssueBUS().GetAll(filters);
            if (issues.Count == 0)
            {
                cbArea.Enabled = true;
                cbSlot.Enabled = true;
                cbArea.SelectedIndex = 0;
                dtpFromDate.Value = DateTime.Now;
                cbMonth.SelectedIndex = cbMonth.SelectedIndex;
                return;
            }
            Issue issue = issues[0];
            dtpFromDate.Value = issue.End_date;
            cbMonth.SelectedIndex = cbMonth.SelectedIndex;
            cbArea.Text = issue.Parking_lot_id;
            cbArea.Enabled = false;
            cbSlot.Text = issue.Slot_id;
            cbSlot.Enabled = false;
        }
    }
}
