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
using ZiTyLot.ENTITY;

namespace ZiTyLot.GUI.Screens.PriceScr
{
    public partial class AddVisitorFeeForm : Form
    {
        private readonly VehicleTypeBUS vehicleTypeBUS = new VehicleTypeBUS();
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
            PricePerTurnInsertion?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void btnConfirmPHT_Click(object sender, EventArgs e)
        {
            PricePerHourTurnInsertion?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void btnConfirmPeriod_Click(object sender, EventArgs e)
        {
            PricePerPeriodInsertion?.Invoke(this, EventArgs.Empty);
            this.Close();
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
