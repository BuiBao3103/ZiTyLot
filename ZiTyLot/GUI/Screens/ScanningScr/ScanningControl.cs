using System;
using System.Drawing;
using System.Windows.Forms;
using ZiTyLot.Constants.Enum;
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
            CheckInForm CheckInForm = new CheckInForm(ParkingLotType.FOUR_WHEELER);
            this.Hide();
            CheckInForm.Closed += (s, args) => this.Show();
            CheckInForm.Show();
        }

        private void btnCarCheckOut_Click(object sender, EventArgs e)
        {
            CheckOutFrom CheckOutForm = new CheckOutFrom(ParkingLotType.FOUR_WHEELER);
            this.Hide();
            CheckOutForm.Closed += (s, args) => this.Show();
            CheckOutForm.Show();
        }

        private void btnBikeCheckIn_Click(object sender, EventArgs e)
        {
            CheckInForm CheckInForm = new CheckInForm(ParkingLotType.TWO_WHEELER);
            this.Hide();
            CheckInForm.Closed += (s, args) => this.Show();
            CheckInForm.Show();
        }

        private void btnBikeCheckOut_Click(object sender, EventArgs e)
        {
            CheckOutFrom CheckOutForm = new CheckOutFrom(ParkingLotType.TWO_WHEELER);
            this.Hide();
            CheckOutForm.Closed += (s, args) => this.Show();
            CheckOutForm.Show();
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