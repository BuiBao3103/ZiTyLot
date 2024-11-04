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
using ZiTyLot.GUI.Utils;

namespace ZiTyLot.GUI.Screens.CardScr
{
    public partial class CardCreateForm : Form
    {
        private readonly CardBUS cardBUS = new CardBUS();

        public event EventHandler CardInsertionEvent;

        public CardCreateForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            try
            {
                Card card = new Card
                {
                    Rfid = tbRFID.Text.Trim(),
                    Status = CardStatus.EMPTY,
                    Type = cbGender.SelectedIndex == 0 ? CardType.RESIDENT : CardType.VISITOR
                };
                cardBUS.Add(card);
                MessageHelper.ShowSuccess("Card added successfully!");
                CardInsertionEvent?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            catch (ValidationException ex)
            {
                MessageHelper.ShowWarning(ex.Message);
            }
            catch (BusinessException ex)
            {
                MessageHelper.ShowWarning(ex.Message);
            }
            catch (Exception)
            {
                MessageHelper.ShowError("RFID already exists.");
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(tbRFID.Text))
            {
                MessageHelper.ShowWarning("Please enter RFID");
                tbRFID.Focus();
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(tbRFID.Text, @"^RFID\d+$"))
            {
                MessageHelper.ShowWarning("Please enter the correct structure (Example: RFID001)");
                tbRFID.Focus();
                return false;
            }

            return true;
        }
    }
}
