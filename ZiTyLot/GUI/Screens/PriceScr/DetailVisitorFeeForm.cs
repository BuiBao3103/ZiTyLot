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
using ZiTyLot.Constants.Enum;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Utils;

namespace ZiTyLot.GUI.Screens.PriceScr
{
    public partial class DetailVisitorFeeForm : Form
    {
        private readonly VehicleTypeBUS vehicleTypeBUS = new VehicleTypeBUS();
        private readonly VisitorFeeBUS visitorFeeBUS = new VisitorFeeBUS();
        private readonly VisitorFee visitorFee;

        public event EventHandler VisitorFeeUpdateEvent;

        public DetailVisitorFeeForm(int visitorFeeId)
        {
            InitializeComponent();
            this.CenterToScreen();
            visitorFee = visitorFeeBUS.GetById(visitorFeeId);
            visitorFee = visitorFeeBUS.PopulateVehicleType(visitorFee);


            switch(visitorFee.Fee_type)
            {
                case FeeType.TURN:
                    pnlTab.SelectedIndex = 0;
                    tbDayFeePT.Text = visitorFee.Day_fee.ToString();
                    tbNightFeePT.Text = visitorFee.Night_fee.ToString();
                    break;
                case FeeType.HOUR_PER_TURN:
                    pnlTab.SelectedIndex = 1;
                    tbDayFeePHT.Text = visitorFee.Day_fee.ToString();
                    tbNightFeePHT.Text = visitorFee.Night_fee.ToString();
                    tbHourPHT.Text = visitorFee.Hours_per_turn.ToString();
                    break;
                case FeeType.FIRST_N_AND_NEXT_M_HOUR:
                    pnlTab.SelectedIndex = 2;
                    tbFeeFirstPeriod.Text = visitorFee.First_n_hours_fee.ToString();
                    tbFeeNextPeriod.Text = visitorFee.Additional_m_hours_fee.ToString();
                    tbHourFirstPeriod.Text = visitorFee.N_hours.ToString();
                    tbHourNextPeriod.Text = visitorFee.M_hours.ToString();
                    break;
            }
            this.Text = "Detailed visitor fee for " + visitorFee.Vehicle_type.Name;
            lbVehicleType.Text = "Detailed visitor fee for " + visitorFee.Vehicle_type.Name;
        }

        private void PriceDetailForm_Load(object sender, EventArgs e)
        {

        }
        // create event to notify parent control about new row insertion
        public event EventHandler PricePerTurnInsertion;
        public event EventHandler PricePerHourTurnInsertion;
        public event EventHandler PricePerPeriodInsertion;

        private void btnConfirmPT_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (double.TryParse(tbDayFeePT.Text, out double dayFee) &&
            //        double.TryParse(tbNightFeePT.Text, out double nightFee))
            //    {
            //        VisitorFee visitorFee = new VisitorFee()
            //        {
            //            Fee_type = FeeType.TURN,
            //            Day_fee = dayFee,
            //            Night_fee = nightFee,
            //            Vehicle_type_id = vehicleType.Id
            //        };
            //        visitorFeeBUS.Add(visitorFee);
            //        PricePerTurnInsertion?.Invoke(this, EventArgs.Empty);
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Invalid fee input. Please enter a valid number for fees.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    MessageBox.Show("An error occurred while adding visitor fee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }


        private void btnConfirmPHT_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (double.TryParse(tbDayFeePHT.Text, out double dayFee) &&
            //       double.TryParse(tbNightFeePHT.Text, out double nightFee) &&
            //       int.TryParse(tbHourPHT.Text, out int hour))
            //    {
            //        VisitorFee visitorFee = new VisitorFee()
            //        {
            //            Fee_type = FeeType.HOUR_PER_TURN,
            //            Day_fee = dayFee,
            //            Night_fee = nightFee,
            //            Hours_per_turn = hour,
            //            Vehicle_type_id = vehicleType.Id
            //        };
            //        visitorFeeBUS.Add(visitorFee);
            //        PricePerHourTurnInsertion?.Invoke(this, EventArgs.Empty);
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Invalid fee input. Please enter a valid number for fees and hours.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    MessageBox.Show("An error occurred while adding visitor fee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnConfirmPeriod_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (double.TryParse(tbFeeFirstPeriod.Text, out double firstFee) &&
            //       double.TryParse(tbFeeNextPeriod.Text, out double nextFee) &&
            //       int.TryParse(tbHourFirstPeriod.Text, out int firstHour) &&
            //       int.TryParse(tbHourNextPeriod.Text, out int nextHour))
            //    {
            //        Console.WriteLine(firstFee);
            //        Console.WriteLine(nextFee);
            //        Console.WriteLine(firstHour);
            //        Console.WriteLine(nextHour);

            //        VisitorFee visitorFee = new VisitorFee()
            //        {
            //            Fee_type = FeeType.FIRST_N_AND_NEXT_M_HOUR,
            //            First_n_hours_fee = firstFee,
            //            Additional_m_hours_fee = nextFee,
            //            N_hours = firstHour,
            //            M_hours = nextHour,
            //            Vehicle_type_id = vehicleType.Id
            //        };
            //        visitorFeeBUS.Add(visitorFee);
            //        PricePerPeriodInsertion?.Invoke(this, EventArgs.Empty);
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Invalid fee input. Please enter a valid number for fees and hours.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    MessageBox.Show("An error occurred while adding visitor fee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnCancelPT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelPHT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelPeriod_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbDayFeePT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputValidator.ValidateNumericKeyPress(tbDayFeePT.Text, e.KeyChar);
        }

        private void tbNightFeePT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputValidator.ValidateNumericKeyPress(tbNightFeePT.Text, e.KeyChar);

        }

        private void tbDayFeePHT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputValidator.ValidateNumericKeyPress(tbDayFeePHT.Text, e.KeyChar);
        }

        private void tbNightFeePHT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputValidator.ValidateNumericKeyPress(tbNightFeePHT.Text, e.KeyChar);

        }

        private void tbHourPHT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputValidator.ValidateNumericKeyPress(tbHourPHT.Text, e.KeyChar);
        }


        private void tbFeeFirstPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputValidator.ValidateNumericKeyPress(tbFeeFirstPeriod.Text, e.KeyChar);
        }


        private void tbHourFirstPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputValidator.ValidateNumericKeyPress(tbHourFirstPeriod.Text, e.KeyChar);
        }

        private void tbFeeNextPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputValidator.ValidateNumericKeyPress(tbFeeNextPeriod.Text, e.KeyChar);

        }

        private void tbHourNextPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputValidator.ValidateNumericKeyPress(tbHourNextPeriod.Text, e.KeyChar);

        }

        private void tbFeeFirstPeriod_TextChanged(object sender, EventArgs e)
        {
            tbFeeFirstPeriod.Text = InputFormatter.FormatNumericText(tbFeeFirstPeriod.Text);
            tbFeeFirstPeriod.SelectionStart = tbFeeFirstPeriod.Text.Length;
        }

        private void tbFeeNextPeriod_TextChanged(object sender, EventArgs e)
        {
            tbFeeNextPeriod.Text = InputFormatter.FormatNumericText(tbFeeNextPeriod.Text);
            tbFeeNextPeriod.SelectionStart = tbFeeNextPeriod.Text.Length;
        }

        private void tbDayFeePHT_TextChanged(object sender, EventArgs e)
        {
            tbDayFeePHT.Text = InputFormatter.FormatNumericText(tbDayFeePHT.Text);
            tbDayFeePHT.SelectionStart = tbDayFeePHT.Text.Length;
        }

        private void tbNightFeePHT_TextChanged(object sender, EventArgs e)
        {
            tbNightFeePHT.Text = InputFormatter.FormatNumericText(tbNightFeePHT.Text);
            tbNightFeePHT.SelectionStart = tbNightFeePHT.Text.Length;
        }

        private void tbDayFeePT_TextChanged(object sender, EventArgs e)
        {
            tbDayFeePT.Text = InputFormatter.FormatNumericText(tbDayFeePT.Text);
            tbDayFeePT.SelectionStart = tbDayFeePT.Text.Length;
        }

        private void tbNightFeePT_TextChanged(object sender, EventArgs e)
        {
            tbNightFeePT.Text = InputFormatter.FormatNumericText(tbNightFeePT.Text);
            tbNightFeePT.SelectionStart = tbNightFeePT.Text.Length;
        }
    }
}
