using System;
using System.Drawing;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI;
using System.Diagnostics;
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

        private void inputUsername_Enter(object sender, EventArgs e)
        {
            if (inputUsername.Text == "Enter username")
            {
                inputUsername.Text = "";
                inputUsername.ForeColor = Color.Black;
            }
        }

        private void inputUsername_Leave(object sender, EventArgs e)
        {
            if (inputUsername.Text == "")
            {
                inputUsername.Text = "Enter username";
                inputUsername.ForeColor = Color.Gray;
            }
        }

        private void inputPassword_Enter(object sender, EventArgs e)
        {
            if (inputPassword.Text == "Enter password")
            {
                inputPassword.Text = "";
                inputPassword.ForeColor = Color.Black;
            }

        }

        private void inputPassword_Leave(object sender, EventArgs e)
        {
            if (inputPassword.Text == "")
            {
                inputPassword.Text = "Enter password";
                inputPassword.ForeColor = Color.Gray;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

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
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
