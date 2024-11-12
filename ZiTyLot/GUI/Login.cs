using System;
using System.Drawing;
using System.Windows.Forms;
using ZiTyLot.BUS;
using System.Diagnostics;
using ZiTyLot.GUI.Utils;
namespace ZiTyLot.GUI
{
    public partial class Login : Form
    {
        AuthManager authManager = new AuthManager();
        public Login()
        {
            this.MaximizeBox = false;
            InitializeComponent();
            this.CenterToScreen();
            this.ActiveControl = inputUsername;
        }

        private void cbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMatKhau.Checked)
            {
                inputPassword.PasswordChar = '\0';  // Show password
            }
            else
            {
                inputPassword.PasswordChar = '*';   // Mask password
            }
        }


        private void btnSignin_Click(object sender, EventArgs e)
        {
            try
            {
                authManager.Login(inputUsername.Text, inputPassword.Text);
                this.Hide();
                new Home().Show();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex.Message);
            }
        }
    }
}
