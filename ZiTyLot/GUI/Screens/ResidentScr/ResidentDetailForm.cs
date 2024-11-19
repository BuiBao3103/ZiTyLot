using System;
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
        private readonly LostHistoryBUS _lostHistoryBUS = new LostHistoryBUS();
        public readonly Resident _resident;

        private bool _processLostCard = false;

        public event EventHandler ResidentUpdateEvent;

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
                    tableIssue.Rows.Add(issue.Id, issue.License_plate, vehicleType.Name, issue.Start_date, issue.End_date, issue.Parking_lot_id, issue.Slot_id);
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
            btnLostCard.Enabled = _resident.Card != null && _resident.Card.Status == CardStatus.ACTIVE;
            btnSaveCard.Enabled = _resident.Card == null;
            tbCodeRFID.Enabled = _resident.Card == null;
        }
        private void btnRestoreCard_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageHelper.ShowConfirm("Are you sure you want to restore this card?");
            if (result == DialogResult.Yes)
            {
                try
                {
                    _resident.Card.Status = CardStatus.ACTIVE;
                    _resident.Card.Updated_at = DateTime.Now;
                    _cardBUS.Update(_resident.Card);
                    MessageHelper.ShowSuccess("Card updated successfully!");
                }
                catch (ValidationInputException ex)
                {
                    MessageHelper.ShowWarning(ex.Message);
                }
                catch (BusinessException ex)
                {
                    MessageHelper.ShowWarning(ex.Message);
                }
                catch (Exception)
                {
                    MessageHelper.ShowWarning("An unexpected error occurred. Please try again later.");
                }
                LoadCardUI();
            }
        }

        private void btnLockCard_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageHelper.ShowConfirm("Are you sure you want to lock this card?");
            if (result == DialogResult.Yes)
            {
                try
                {
                    _resident.Card.Status = CardStatus.BLOCKED;
                    _resident.Card.Updated_at = DateTime.Now;
                    _cardBUS.Update(_resident.Card);
                    MessageHelper.ShowSuccess("Card updated successfully!");
                }
                catch (ValidationInputException ex)
                {
                    MessageHelper.ShowWarning(ex.Message);
                }
                catch (BusinessException ex)
                {
                    MessageHelper.ShowWarning(ex.Message);
                }
                catch (Exception)
                {
                    MessageHelper.ShowWarning("An unexpected error occurred. Please try again later.");
                }
                LoadCardUI();
            }
        }

        private void btnLostCard_Click(object sender, EventArgs e)
        {
            _processLostCard = true;
            btnLostCard.Enabled = false;
            btnLockCard.Enabled = false;
            btnCancelLostCard.Visible = true;
            btnSaveCard.Enabled = true;

            tbCodeRFID.Text = "";
            tbCodeRFID.Enabled = true;
            tbCodeRFID.Focus();
        }

        private void btnSaveCard_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCodeRFID.Text))
            {
                MessageHelper.ShowWarning("Please enter RFID code");
                tbCodeRFID.Focus();
                return;
            }
            if (!InputValidator.ValidateRfid(tbCodeRFID.Text))
            {
                MessageHelper.ShowWarning("RFID code is invalid");
                tbCodeRFID.Focus();
                return;
            }
            try
            {
                if (_processLostCard)
                {
                    //update card status to LOST
                    _resident.Card.Status = CardStatus.LOST;
                    _cardBUS.Update(_resident.Card);
                    //create lost history
                    LostHistory lostHistory = new LostHistory
                    {
                        Card_id = _resident.Card.Id,
                        Time_loss = DateTime.Now,
                        Owner_name = _resident.Full_name,
                        License_plate = "",
                        Is_found = false
                    };
                    _lostHistoryBUS.Add(lostHistory);
                    //issue new card
                    Card cardIssue = _cardBUS.IssueCard(tbCodeRFID.Text, _resident.Id);
                    _resident.Card = cardIssue;
                    MessageHelper.ShowInfo("Lost card successfully");


                    LoadCardUI();
                    btnCancelLostCard.Visible = false;
                    _processLostCard = false;
                }
                else
                {
                    Card cardIssue = _cardBUS.IssueCard(tbCodeRFID.Text, _resident.Id);
                    _resident.Card = cardIssue;
                    LoadCardUI();
                    MessageHelper.ShowInfo("Issue card successfully");
                }
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

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            try
            {
                _resident.Full_name = tbFullname.Text;
                _resident.Apartment_id = tbApartmentId.Text;
                _resident.Email = tbEmail.Text;
                _resident.Phone = tbPhone.Text;
                _resident.Updated_at = DateTime.Now;
                _residentBUS.Update(_resident);
                MessageHelper.ShowSuccess("Resident updated successfully!");
                ResidentUpdateEvent?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            catch (ValidationInputException ex)
            {
                MessageHelper.ShowWarning(ex.Message);
            }
            catch (BusinessException ex)
            {
                MessageHelper.ShowWarning(ex.Message);
            }
            catch (Exception)
            {
                MessageHelper.ShowWarning("An unexpected error occurred. Please try again later.");
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(tbFullname.Text))
            {
                MessageHelper.ShowWarning("Please enter fullname");
                return false;
            }

            if (string.IsNullOrEmpty(tbApartmentId.Text))
            {
                MessageHelper.ShowWarning("Please enter apartment");
                return false;
            }

            if (string.IsNullOrEmpty(tbEmail.Text))
            {
                MessageHelper.ShowWarning("Please enter email");
                return false;
            }

            if (string.IsNullOrEmpty(tbPhone.Text))
            {
                MessageHelper.ShowWarning("Please enter phone");
                return false;
            }

            if (!InputValidator.ValidateEmail(tbEmail.Text))
            {
                MessageHelper.ShowWarning("Email invalid");
                return false;
            }

            if (!InputValidator.ValidatePhoneNumber(tbPhone.Text))
            {
                MessageHelper.ShowWarning("Phone invalid");
                return false;
            }

            return true;
        }

        private void btnCancelLostCard_Click(object sender, EventArgs e)
        {
            btnLostCard.Enabled = true;
            btnLockCard.Enabled = true;
            btnCancelLostCard.Visible = false;
            btnSaveCard.Enabled = false;
            tbCodeRFID.Text = _resident.Card.Rfid;
            tbCodeRFID.Enabled = false;
            _processLostCard = false;
        }
    }
}
