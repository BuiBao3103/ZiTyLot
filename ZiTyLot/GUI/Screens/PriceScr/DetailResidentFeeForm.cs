using System;
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
    public partial class DetailResidentFeeForm : Form
    {
        private readonly VehicleTypeBUS vehicleTypeBUS = new VehicleTypeBUS();
        private readonly ResidentFeeBUS residentFeeBUS = new ResidentFeeBUS();
        private static readonly List<int> INIT_DURATION = new List<int> { 1, 2, 3, 6, 9, 12 };
        public readonly ResidentFee residentFee;

        public event EventHandler ResidentFeeUpdateEvent;
        public DetailResidentFeeForm(int residentFeeId)
        {
            InitializeComponent();
            this.CenterToScreen();
            residentFee = residentFeeBUS.GetById(residentFeeId);

            tbFee.Text = InputFormatter.FormatNumericText(residentFee.Fee.ToString());

            VehicleType vehicleType = vehicleTypeBUS.GetById(residentFee.Vehicle_type_id);
            vehicleType = vehicleTypeBUS.PopulateResidentFees(vehicleType);

            //initialize duration combobox
            List<int> durationExists = vehicleType.Resident_fees.Select(fee => fee.Month).ToList();
            cbDuration.Items.Add(residentFee.Month == 1 ? residentFee.Month + " month" : residentFee.Month + " months");
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
            this.Text = residentFee.Id + " - Detailed resident fee for " + vehicleType.Name;
            lbVehicleType.Text = residentFee.Id + " - Detailed resident fee for " + vehicleType.Name;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(InputFormatter.GetRawNumericValue(tbFee.Text), out double fee))
                {
                    residentFee.Month = int.Parse(cbDuration.Text.Split(' ')[0]);
                    residentFee.Fee = fee;
                    residentFeeBUS.Update(residentFee);
                    ResidentFeeUpdateEvent?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid fee value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while adding resident fee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
