using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.component_extensions;

namespace ZiTyLot.GUI.Screens
{
    public partial class PriceControl : UserControl
    {
        VehicleTypeBUS vehicleTypeBUS = new VehicleTypeBUS();
        List<FilterCondition> filters = new List<FilterCondition>();
        List<VehicleType> vehicleTypes;
        public PriceControl()
        {
            InitializeComponent();
        }

        private void pnlTab_Resize(object sender, EventArgs e)
        {
            pnlTab.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTab.Width, pnlTab.Height, 10, 10));
        }




    }
}