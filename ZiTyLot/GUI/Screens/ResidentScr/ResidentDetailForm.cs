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

namespace ZiTyLot.GUI.Screens.ResidentScr
{
    public partial class ResidentDetailForm : Form
    {
        private readonly ResidentBUS _residentBUS = new ResidentBUS();
        private readonly IssueBUS _issueBUS = new IssueBUS();
        private readonly BillBUS _billBus = new BillBUS();
        private readonly CardBUS _cardBUS = new CardBUS();
        public readonly Resident _resident;

        public event EventHandler ResidentUpdateEvent;
        private readonly List<Bill> bills;
        private readonly List<Issue> issues;

        public ResidentDetailForm(int residentId)
        {
            InitializeComponent();
            this.CenterToScreen();

            _resident = _residentBUS.GetById(residentId);
            tbFullname.Text = _resident.Full_name;
            tbApartmentId.Text = _resident.Apartment_id;
            tbEmail.Text = _resident.Email;
            tbPhone.Text = _resident.Phone;

            _resident = _residentBUS.PopulateBills(_resident);

            for (int i = 0; i < _resident.Bills.Count; i++)
            {
                _resident.Bills[i] = _billBus.PopulateIssues(_resident.Bills[i]);
                foreach (Issue issue in _resident.Bills[i].Issues)
                {
                    VehicleType vehicleType = _issueBUS.PopulateVehicleType(issue).Vehicle_type;
                    tableIssue.Rows.Add(issue.Id, issue.License_plate
                    , vehicleType.Name
                    , issue.Start_date, issue.End_date);
                }
            }

            _resident = _residentBUS.PopulateCard(_resident);
            
            LoadCardUI();
        }
        private void LoadCardUI()
        {
            if (_resident.Card != null)
            {
                tbCardID.Text = _resident.Card.Id.ToString();
                tbCodeRFID.Text = _resident.Card.Rfid;
                tbStatus.Text = _resident.Card.Status.ToString();
            }
            else
            {
                tbStatus.Text = "Has not been issued";
            }
            btnRestoreCard.Enabled = _resident.Card != null && _resident.Card.Status == CardStatus.BLOCKED;
            btnLockCard.Enabled = _resident.Card != null && _resident.Card.Status == CardStatus.ACTIVE;
            btnLostCard.Enabled = _resident.Card != null && _resident.Card.Status == CardStatus.LOST;
            btnSaveCard.Enabled = _resident.Card == null;
            tbCodeRFID.Enabled = _resident.Card == null;
        }
        private void btnRestoreCard_Click(object sender, EventArgs e)
        {

        }

        private void btnLockCard_Click(object sender, EventArgs e)
        {

        }

        private void btnLostCard_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveCard_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCodeRFID.Text))
            {
                MessageHelper.ShowWarning("Please enter RFID code");
                tbCodeRFID.Focus();
                return;
            }
            if(!InputValidator.ValidateRfid(tbCodeRFID.Text))
            {
                MessageHelper.ShowWarning("RFID code is invalid");
                tbCodeRFID.Focus();
                return;
            }
            try
            {
                Card cardIssue = _cardBUS.IssueCard(tbCodeRFID.Text, _resident.Id);
                _resident.Card = cardIssue;
                LoadCardUI();
                MessageHelper.ShowInfo("Issue card successfully");
            }
            catch (ValidationInputException ex)
            {
                MessageHelper.ShowWarning(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageHelper.ShowError("Save card failed. Please try again later.");
            }
        }


    }
}
