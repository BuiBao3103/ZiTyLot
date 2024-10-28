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
    public partial class PriceResidentForm : Form
    {
        private readonly VehicleTypeBUS vehicleTypeBUS = new VehicleTypeBUS();
        private static readonly List<int> INIT_DURATION = new List<int> { 1, 2, 3, 6, 9, 12 };
        private readonly VehicleType vehicleType;
        public PriceResidentForm(int vehicle_id)
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
            this.Text = "Resident Fee for " + vehicleType.Name;
            lbVehicleType.Text = vehicleType.Name;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
