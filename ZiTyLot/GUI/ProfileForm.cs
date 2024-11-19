using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.Constants.Enum;
using ZiTyLot.DTOS;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Utils;

namespace ZiTyLot.GUI
{
    public partial class ProfileForm : Form
    {
        const int AccountId = 1;// TODO: get from session
        private Account _account;
        private readonly AccountBUS _accountBUS = new AccountBUS();

        public ProfileForm()
        {
            InitializeComponent();
            this.CenterToScreen();

            _account = _accountBUS.GetById(AccountId);

            tbFullname.Text = _account.Full_name;
            tbEmail.Text = _account.Email;
            tbPhone.Text = _account.Phone;
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            try
            {
                _account.Full_name = tbFullname.Text.Trim();
                _account.Email = tbEmail.Text.Trim();
                _account.Phone = tbPhone.Text.Trim();
                _account.Updated_at = DateTime.Now;
                _accountBUS.Update(_account);
                MessageHelper.ShowSuccess("Profile updated successfully!");
            }
            catch (ValidationInputException ex)
            {
                MessageHelper.ShowWarning(ex.Message);
            }
            catch (BusinessException ex)
            {
                MessageHelper.ShowWarning(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageHelper.ShowError("An unexpected error occurred. Please try again later.");
            }
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            try
            {
                _accountBUS.ChangePassword(_account, tbCurrentPassword.Text.Trim(), tbNewPassword.Text.Trim(), tbConfirmPassword.Text.Trim());
                
                MessageHelper.ShowSuccess("Change password successfully!");
            }
            catch (Exception ex)
            {
                MessageHelper.ShowWarning(ex.Message);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(tbFullname.Text))
            {
                MessageHelper.ShowWarning("Please enter full name");
                tbFullname.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageHelper.ShowWarning("Please enter email");
                tbEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                MessageHelper.ShowWarning("Please enter phone number");
                tbPhone.Focus();
                return false;
            }

            if (!InputValidator.ValidateEmail(tbEmail.Text))
            {
                MessageHelper.ShowWarning("Invalid email");
                tbEmail.Focus();
                return false;
            }

            if (!InputValidator.ValidatePhoneNumber(tbPhone.Text))
            {
                MessageHelper.ShowWarning("Invalid phone number");
                tbPhone.Focus();
                return false;
            }

            return true;
        }
    }
}
