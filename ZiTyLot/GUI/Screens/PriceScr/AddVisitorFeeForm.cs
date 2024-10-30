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

namespace ZiTyLot.GUI.Screens.PriceScr
{
    public partial class AddVisitorFeeForm : Form
    {
        private readonly VehicleTypeBUS vehicleTypeBUS = new VehicleTypeBUS();
        private readonly VisitorFeeBUS visitorFeeBUS = new VisitorFeeBUS();
        private readonly VehicleType vehicleType;


        public AddVisitorFeeForm(int vehicle_id)
        {
            InitializeComponent();
            this.CenterToScreen();
            vehicleType = vehicleTypeBUS.GetById(vehicle_id);

            this.Text = "Visitor Fee for " + vehicleType.Name;
            lbVehicleType.Text = vehicleType.Name;
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
            try
            {
                if (double.TryParse(tbDayFeePT.Text, out double dayFee) &&
                    double.TryParse(tbNightFeePT.Text, out double nightFee))
                {
                    VisitorFee visitorFee = new VisitorFee()
                    {
                        Fee_type = FeeType.TURN,
                        Day_fee = dayFee,
                        Night_fee = nightFee,
                        Vehicle_type_id = vehicleType.Id
                    };
                    visitorFeeBUS.Add(visitorFee);
                    PricePerTurnInsertion?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid fee input. Please enter a valid number for fees.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while adding visitor fee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnConfirmPHT_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(tbDayFeePHT.Text, out double dayFee) &&
                   double.TryParse(tbNightFeePHT.Text, out double nightFee) &&
                   int.TryParse(tbHourPHT.Text, out int hour))
                {
                    VisitorFee visitorFee = new VisitorFee()
                    {
                        Fee_type = FeeType.HOUR_PER_TURN,
                        Day_fee = dayFee,
                        Night_fee = nightFee,
                        Hours_per_turn = hour,
                        Vehicle_type_id = vehicleType.Id
                    };
                    visitorFeeBUS.Add(visitorFee);
                    PricePerHourTurnInsertion?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid fee input. Please enter a valid number for fees and hours.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while adding visitor fee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmPeriod_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(tbFeeFirstPeriod.Text, out double firstFee) &&
                   double.TryParse(tbFeeNextPeriod.Text, out double nextFee) &&
                   int.TryParse(tbHourFirstPeriod.Text, out int firstHour) &&
                   int.TryParse(tbHourNextPeriod.Text, out int nextHour))
                {
                    Console.WriteLine(firstFee);
                    Console.WriteLine(nextFee);
                    Console.WriteLine(firstHour);
                    Console.WriteLine(nextHour);

                    VisitorFee visitorFee = new VisitorFee()
                    {
                        Fee_type = FeeType.FIRST_N_AND_NEXT_M_HOUR,
                        First_n_hours_fee = firstFee,
                        Additional_m_hours_fee = nextFee,
                        N_hours = firstHour,
                        M_hours = nextHour,
                        Vehicle_type_id = vehicleType.Id
                    };
                    visitorFeeBUS.Add(visitorFee);
                    PricePerPeriodInsertion?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid fee input. Please enter a valid number for fees and hours.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while adding visitor fee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
