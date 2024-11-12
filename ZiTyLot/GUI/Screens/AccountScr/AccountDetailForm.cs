using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.Constants.Enum;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Utils;

namespace ZiTyLot.GUI.Screens.AccountScr
{
    public partial class AccountDetailForm : Form
    {
        private readonly AccountBUS accountBUS = new AccountBUS();
        public readonly Account account;

        public event EventHandler AccountUpdateEvent;

        private readonly RoleBUS roleBUS = new RoleBUS();
        private readonly FunctionBUS functionBUS = new FunctionBUS();
        private readonly List<Function> functions;
        public AccountDetailForm(int accountId)
        {
            InitializeComponent();
            this.CenterToScreen();

            account = accountBUS.GetById(accountId);
            tbFullname.Text = account.Full_name;
            tbEmail.Text = account.Email;
            tbNationalId.Text = account.National_id;
            tbPhone.Text = account.Phone;
            tbUsername.Text = account.Username;
            if (account.Gender == AccountGender.FEMALE)
            {
                cbGender.SelectedIndex = 1;
            }
            
            List<Role> roles = roleBUS.GetAll();
            cbRole.DataSource = roles;
            cbRole.DisplayMember = nameof(Role.Name);
            cbRole.ValueMember = nameof(Role.Id);
            cbRole.SelectedValue = account.Role_id;
        }

        private void AccountDetailForm_Load(object sender, System.EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRole.SelectedItem != null)
            {
                Role role = roleBUS.PopulateFunctions((Role)cbRole.SelectedItem);
                listAccess.DataSource = null;
                listAccess.DataSource = role.Functions;
                listAccess.DisplayMember = nameof(Function.Name);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            try
            {
                account.Full_name = tbFullname.Text.Trim();
                account.National_id = tbNationalId.Text.Trim();
                account.Email = tbEmail.Text.Trim();
                account.Phone = tbPhone.Text.Trim();
                account.Username = tbUsername.Text.Trim();
                account.Gender = cbGender.SelectedIndex == 0 ? AccountGender.MALE : AccountGender.FEMALE;
                account.Role_id = (int)cbRole.SelectedValue;
                account.Updated_at = DateTime.Now;
                accountBUS.Update(account);
                MessageHelper.ShowSuccess("Account updated successfully!");
                AccountUpdateEvent?.Invoke(this, EventArgs.Empty);
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageHelper.ShowError("An unexpected error occurred. Please try again later.");
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

            if (string.IsNullOrWhiteSpace(tbNationalId.Text))
            {
                MessageHelper.ShowWarning("Please enter national id");
                tbNationalId.Focus();
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

            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                MessageHelper.ShowWarning("Please enter username");
                tbUsername.Focus();
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

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageHelper.ShowConfirm("Are you sure you want to reset password?");
            if (result == DialogResult.Yes)
            {
                try
                {
                    account.Password = "1";
                    accountBUS.Update(account);
                    MessageHelper.ShowSuccess("Reset password successfully!");
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
        }
    }
}
