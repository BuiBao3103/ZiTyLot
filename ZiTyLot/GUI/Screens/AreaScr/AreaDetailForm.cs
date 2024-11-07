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

namespace ZiTyLot.GUI.Screens.AreaScr
{
    public partial class AreaDetailForm : Form
    {
        private readonly ParkingLotBUS parkingLotBUS = new ParkingLotBUS();
        public readonly ParkingLot parkingLot;
        public event EventHandler AreaUpdateEvent;
        public AreaDetailForm(string areaId)
        {
            InitializeComponent();
            this.CenterToScreen();
            parkingLot = parkingLotBUS.GetById(areaId);

            if (parkingLot.User_type == ParkingLotUserType.VISITOR)
            {
                cbUserType.SelectedIndex = 1;
            }

            if (parkingLot.Parking_lot_type == ParkingLotType.FOUR_WHEELER) 
            {
                cbVehicalType.SelectedIndex = 1;
            }

            if (parkingLot.Status == ParkingLotStatus.UNDER_MAINTENANCE)
            {
                rbtnMaintenace.Checked = true;
            }

            if (parkingLot.Status == ParkingLotStatus.CLOSED)
            {
                rbtnClosed.Checked = true;
            }

            tbTotalSlot.Text = parkingLot.Total_slot.ToString();
           

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
