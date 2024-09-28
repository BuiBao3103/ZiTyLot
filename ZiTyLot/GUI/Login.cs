using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZiTyLot.GUI
{
    public partial class Login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeft,
        int nTop,
        int nRight,
        int nBottom,
        int nWidth,
        int nHeight
    );
        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.ActiveControl = inputUsername;
            this.pnlInputUsername.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlInputUsername.Width, pnlInputUsername.Height, 5, 5));
            this.pnlInputPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlInputPassword.Width, pnlInputPassword.Height, 5, 5));
            this.btnDangNhap.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDangNhap.Width, btnDangNhap.Height, 5, 5));
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

        private void pictureBox2_Resize(object sender, EventArgs e)
        {
            this.rightImage.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, rightImage.Width, rightImage.Height, 5, 5));
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            this.rightImage.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, rightImage.Width, rightImage.Height, 5, 5));
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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
