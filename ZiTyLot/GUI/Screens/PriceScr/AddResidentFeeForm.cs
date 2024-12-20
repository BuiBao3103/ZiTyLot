﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.DTOS;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Utils;

namespace ZiTyLot.GUI.Screens.PriceScr
{
    public partial class AddResidentFeeForm : Form
    {
        private readonly VehicleTypeBUS vehicleTypeBUS = new VehicleTypeBUS();
        private readonly ResidentFeeBUS residentFeeBUS = new ResidentFeeBUS();
        private static readonly List<int> INIT_DURATION = new List<int> { 1, 2, 3, 6, 9, 12 };
        private readonly VehicleType vehicleType;


        public event EventHandler ResidentFeeInsertionEvent;
        public AddResidentFeeForm(int vehicle_id)
        {
            InitializeComponent();
            this.CenterToScreen();
            vehicleType = vehicleTypeBUS.GetById(vehicle_id);
            vehicleType = vehicleTypeBUS.PopulateResidentFees(vehicleType);

            //initialize duration combobox
            List<int> durationExists = vehicleType.Resident_fees.Select(fee => fee.Month).ToList();
            foreach (int duration in INIT_DURATION)
            {
                if (!durationExists.Contains(duration))
                {
                    string durationFormat = duration == 1 ? duration + " month" : duration + " months";
                    cbDuration.Items.Add(durationFormat);
                }
            }
            cbDuration.SelectedIndex = 0;
            //initialize fee title
            this.Text = "Add Resident Fee for " + vehicleType.Name;
            lbVehicleType.Text = "Add Resident Fee for " + vehicleType.Name;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            try
            {
                ResidentFee residentFee = new ResidentFee
                {
                    Month = int.Parse(cbDuration.Text.Split(' ')[0]),
                    Fee = double.Parse(InputFormatter.GetRawNumericValue(tbFee.Text)),
                    Vehicle_type_id = vehicleType.Id,
                };
                residentFeeBUS.Add(residentFee);
                MessageHelper.ShowSuccess(" Resident Fee added successfully!");
                ResidentFeeInsertionEvent?.Invoke(this, EventArgs.Empty);
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
            catch (Exception)
            {
                MessageHelper.ShowError("An unexpected error occurred. Please try again later.");
            }
        }

        private void tbFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputValidator.ValidateNumericKeyPress(tbFee.Text, e.KeyChar);
        }

        private void tbFee_TextChanged(object sender, EventArgs e)
        {
            tbFee.Text = InputFormatter.FormatNumericText(tbFee.Text);
            tbFee.SelectionStart = tbFee.Text.Length;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(tbFee.Text))
            {
                MessageHelper.ShowWarning("Please enter fee amount");
                tbFee.Focus();
                return false;
            }

            if (!double.TryParse(InputFormatter.GetRawNumericValue(tbFee.Text), out double fee))
            {
                MessageHelper.ShowWarning("Please enter a valid fee amount");
                tbFee.Focus();
                return false;
            }

            return true;
        }


    }
}
