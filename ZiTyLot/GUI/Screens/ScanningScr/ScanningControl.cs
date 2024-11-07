using System;
using System.Drawing;
using System.Windows.Forms;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Screens.ScanningScr;
namespace ZiTyLot.GUI.Screens
{
    public partial class ScanningControl : UserControl
    {
        public ScanningControl()
        {
            InitializeComponent();
            

        }

        private void btnCarCheckIn_Click(object sender, EventArgs e)
        {
            CarCheckInForm carCheckInForm = new CarCheckInForm();
            carCheckInForm.Show();
        }

        private void btnCarCheckOut_Click(object sender, EventArgs e)
        {
            CarCheckOutForm carCheckOutForm = new CarCheckOutForm();
            carCheckOutForm.Show();
        }

        private void btnBikeCheckIn_Click(object sender, EventArgs e)
        {
            BikeCheckInForm bikeCheckInForm = new BikeCheckInForm();
            bikeCheckInForm.Show();
        }

        private void btnBikeCheckOut_Click(object sender, EventArgs e)
        {
            BikeCheckOutFrom   bikeCheckOutForm = new BikeCheckOutFrom();
            bikeCheckOutForm.Show();
        }

        private void ScanningControl_Load(object sender, EventArgs e)
        {
            btnBikeCheckIn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, btnBikeCheckIn.Width, btnBikeCheckIn.Height, 10, 10));
            btnBikeCheckOut.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, btnBikeCheckOut.Width, btnBikeCheckOut.Height, 10, 10));
            btnCarCheckIn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, btnCarCheckIn.Width, btnCarCheckIn.Height, 10, 10));
            btnCarCheckOut.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, btnCarCheckOut.Width, btnCarCheckOut.Height, 10, 10));

        }

        private void ScanningControl_Resize(object sender, EventArgs e)
        {
            btnBikeCheckIn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, btnBikeCheckIn.Width, btnBikeCheckIn.Height, 10, 10));
            btnBikeCheckOut.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, btnBikeCheckOut.Width, btnBikeCheckOut.Height, 10, 10));
            btnCarCheckIn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, btnCarCheckIn.Width, btnCarCheckIn.Height, 10, 10));
            btnCarCheckOut.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, btnCarCheckOut.Width, btnCarCheckOut.Height, 10, 10));
        }
    }
}