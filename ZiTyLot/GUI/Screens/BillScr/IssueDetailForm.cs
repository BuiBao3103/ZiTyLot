﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.Constants.Enum;
using ZiTyLot.ENTITY;

namespace ZiTyLot.GUI.Screens.BillScr
{
    public partial class IssueDetailForm : Form
    {
        private readonly ResidentFeeBUS _residentFeeBUS;
        private readonly VehicleTypeBUS _vehicleTypeBUS;
        private readonly ParkingLotBUS _parkingLotBUS;
        private readonly SlotBUS _slotBUS;

        private List<ResidentFee> _residentFees;
        private List<VehicleType> _vehicleTypes;
        private List<ParkingLot> _parkingLots;
        private List<Slot> _slots;

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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            IssueInsertionEvent?.Invoke(this, EventArgs.Empty);
            this.Dispose();
        }

        private void cbVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedVehicleType = cbVehicleType.SelectedItem.ToString();
            VehicleType vehicleType = _vehicleTypes.Find(x => x.Name == selectedVehicleType);
            cbMonth.Items.Clear();
            foreach (ResidentFee residentFee in _residentFees)
            {
                if (residentFee.Vehicle_type_id == vehicleType.Id)
                {
                    string monthFormat = residentFee.Month == 1 ? residentFee.Month + " month" : residentFee.Month + " months";
                    cbMonth.Items.Add(monthFormat);
                }
            }
            cbMonth.SelectedIndex = 0;


            cbArea.Items.Clear();
            ParkingLotType parkingLotType = vehicleType.Has_slot ? ParkingLotType.FOUR_WHEELER : ParkingLotType.TWO_WHEELER;
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
            string selectedVehicleType = cbVehicleType.SelectedItem.ToString();
            int selectedVehicleTypeId = _vehicleTypes.Find(x => x.Name == selectedVehicleType).Id;
            string selectedMonth = cbMonth.SelectedItem.ToString();
            int month = int.Parse(selectedMonth.Split(' ')[0]);
            ResidentFee residentFee = _residentFees.Find(x => x.Vehicle_type_id == selectedVehicleTypeId && x.Month == month);
            tbTotal.Text = residentFee.Fee.ToString("C0", new System.Globalization.CultureInfo("vi-VN"));
            dtpToDate.Value = dtpFromDate.Value.AddMonths(month);
        }

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbArea.SelectedIndex == -1)
            {
                return;
            }
            string selectedParkingLot = cbArea.SelectedItem.ToString();
            cbSlot.Items.Clear();
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
