using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.Constants.Enum;
using ZiTyLot.DTOS;
using ZiTyLot.Helper;

namespace ZiTyLot.GUI.Screens.SessionScr
{
    public partial class SessionDetailForm : Form
    {
        private readonly SessionBUS _sessionBUS = new SessionBUS();
        private readonly CardBUS _cardBUS = new CardBUS();

        public int _sessionId;
        private Session _session;
        private int _cardId;
        private string  _license;

        public SessionDetailForm(int sessionId)
        {
            _sessionId = sessionId;
           
            _session = _sessionBUS.GetById(sessionId);
            _session = _sessionBUS.PopulateImages(_session);
            _session = _sessionBUS.PopulateCard(_session);
            _session.Card = _cardBUS.PopulateVehicleType(_session.Card);
            _cardId = _session.Card.Id;
            _license = _session.License_plate;
            InitializeComponent();
            this.CenterToScreen();

            btnLostCard.Visible = _session.Card.Type == CardType.VISITOR;

            gbInfomation.Text += " - " + sessionId;
            lbCheckInTime.Text = _session.Checkin_time?.ToString();
            lbCheckOutTime.Text = _session.Checkout_time?.ToString();
            lbPlate.Text = _session.License_plate;
            lbRfid.Text = _session.Card?.Rfid;
            lbSessionType.Text = _session.Type.ToString();
            lbTotalPrice.Text = _session.Fee?.ToString();
            lbVehicalType.Text = _session.Card.Vehicle_type != null ? _session.Card.Vehicle_type.Name.ToString() : "";
            lbTotalTime.Text = _session.Checkout_time != null ? _session.Checkout_time?.Subtract(_session.Checkin_time.Value).ToString("hh\\:mm\\:ss") : "";

            this.pbCheckInFront.SizeMode = PictureBoxSizeMode.Zoom;
            this.pnCheckInBack.SizeMode = PictureBoxSizeMode.Zoom;
            this.pbCheckOutFront.SizeMode = PictureBoxSizeMode.Zoom;
            this.pbCheckOutBack.SizeMode = PictureBoxSizeMode.Zoom;
            this.pbCheckInPlate.SizeMode = PictureBoxSizeMode.Zoom;
            this.pbCheckOutPlate.SizeMode = PictureBoxSizeMode.Zoom;

            if (_session.Images.Count > 0)
            {
                foreach (var image in _session.Images)
                {
                    if (image.Type == ImageType.BEFORE_CHECKIN)
                    {
                        pbCheckInFront.Image = ImageHelper.LoadImage(image.Url);
                    }
                    else if (image.Type == ImageType.AFTER_CHECKIN)
                    {
                        pnCheckInBack.Image = ImageHelper.LoadImage(image.Url);
                    }
                    else if (image.Type == ImageType.BEFORE_CHECKOUT)
                    {
                        pbCheckOutFront.Image = ImageHelper.LoadImage(image.Url);
                    }
                    else if (image.Type == ImageType.AFTER_CHECKOUT)
                    {
                        pbCheckOutBack.Image = ImageHelper.LoadImage(image.Url);
                    }
                    else if (image.Type == ImageType.LICENSE_PLATE_CHECKIN)
                    {
                        pbCheckInPlate.Image = ImageHelper.LoadImage(image.Url);
                    }
                    else if (image.Type == ImageType.LICENSE_PLATE_CHECKOUT)
                    {
                        pbCheckOutPlate.Image = ImageHelper.LoadImage(image.Url);
                    }
                }
            }
        }

        private void btnLostCard_Click(object sender, System.EventArgs e)
        {
            this.Close();
            LostCardCreateForm lostCardCreateForm = new LostCardCreateForm(_cardId, _license);
            lostCardCreateForm.ShowDialog();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
