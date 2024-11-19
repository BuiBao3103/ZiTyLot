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
using ZiTyLot.DTOS;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Utils;

namespace ZiTyLot.GUI.Screens.SessionScr
{
    public partial class LostCardCreateForm : Form
    {
        private readonly CardBUS _cardBus = new CardBUS();
        private readonly LostHistoryBUS _historyBus = new LostHistoryBUS();
        private readonly Card _card;
        private readonly string _license;
        private readonly int _cardId;
        public LostCardCreateForm(int cardId, string license)
        {
            InitializeComponent();
            this.CenterToScreen();
            _card = _cardBus.GetById(cardId);
            _license = license;
            _cardId = cardId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!validate()) return;
            try
            {
                string ownerName = tbFullname.Text;
                DateTime selectedDate = dtpTimeOfLoss.Value;

                LostHistory history = new LostHistory
                {
                    Time_loss = selectedDate,
                    License_plate = _license,
                    Owner_name = ownerName,
                    Owner_identification_card = _card.Rfid,
                    Is_found = false,
                    Created_at = DateTime.Now,
                    Card_id = _cardId
                };
                _historyBus.Add(history);
                _card.Status = Constants.Enum.CardStatus.LOST;
                _cardBus.Update(_card);
                MessageHelper.ShowSuccess("Lost history added successfully!");
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

        private bool validate()
        {
            if (string.IsNullOrEmpty(tbFullname.Text))
            {
                MessageHelper.ShowWarning("Please enter fullname");
                tbFullname.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(tbNationalID.Text))
            {
                MessageHelper.ShowWarning("Please enter national id");
                tbNationalID.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(tbPhone.Text))
            {
                MessageHelper.ShowWarning("Please enter phone number");
                tbPhone.Focus();
                return false;
            }

            if (!InputValidator.ValidateNationalId(tbNationalID.Text))
            {
                MessageHelper.ShowWarning("National id invalid");
                return false;
            }

            if (!InputValidator.ValidatePhoneNumber(tbPhone.Text))
            {
                MessageHelper.ShowWarning("Phone number invalid");
                return false;
            }

            return true;
        }

        private void tbFullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
