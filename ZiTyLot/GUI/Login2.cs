using Sunny.UI;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Drawing;
using ZiTyLot.GUI.Utils;

namespace ZiTyLot.GUI
{
    public partial class Login2 : UIForm
    {
        List<Image> images = new List<Image>();
        string[] location = new string[25];
        string defaultImageLocation = @"..\..\GUI\assets\animation\debut.jpg";
        public Login2()
        {
            InitializeComponent();
            LoadImageLocations();
            LoadImages();

            // Set up event handlers
            txtUsername.TextChanged += TxtUsername_TextChanged;
            txtUsername.Click += TxtUsername_Click;
            txtPassword.Click += TxtPassword_Click;
            btnLogin.Click += BtnLogin_Click;
        }

        private void LoadImageLocations()
        {
            location[0] = @"..\..\GUI\assets\animation\textbox_user_1.jpg";
            location[1] = @"..\..\GUI\assets\animation\textbox_user_2.jpg";
            location[2] = @"..\..\GUI\assets\animation\textbox_user_4.jpg";
            location[3] = @"..\..\GUI\assets\animation\textbox_user_5.jpg";
            location[4] = @"..\..\GUI\assets\animation\textbox_user_6.jpg";
            location[5] = @"..\..\GUI\assets\animation\textbox_user_7.jpg";
            location[6] = @"..\..\GUI\assets\animation\textbox_user_8.jpg";
            location[7] = @"..\..\GUI\assets\animation\textbox_user_9.jpg";
            location[8] = @"..\..\GUI\assets\animation\textbox_user_10.jpg";
            location[9] = @"..\..\GUI\assets\animation\textbox_user_11.jpg";
            location[10] = @"..\..\GUI\assets\animation\textbox_user_12.jpg";
            location[11] = @"..\..\GUI\assets\animation\textbox_user_13.jpg";
            location[12] = @"..\..\GUI\assets\animation\textbox_user_14.jpg";
            location[13] = @"..\..\GUI\assets\animation\textbox_user_15.jpg";
            location[14] = @"..\..\GUI\assets\animation\textbox_user_16.jpg";
            location[15] = @"..\..\GUI\assets\animation\textbox_user_17.jpg";
            location[16] = @"..\..\GUI\assets\animation\textbox_user_18.jpg";
            location[17] = @"..\..\GUI\assets\animation\textbox_user_19.jpg";
            location[18] = @"..\..\GUI\assets\animation\textbox_user_20.jpg";
            location[19] = @"..\..\GUI\assets\animation\textbox_user_21.jpg";
            location[20] = @"..\..\GUI\assets\animation\textbox_user_22.jpg";
            location[21] = @"..\..\GUI\assets\animation\textbox_user_23.jpg";
            location[22] = @"..\..\GUI\assets\animation\textbox_user_24.jpg";
        }

        private void LoadImages()
        {
            for (int i = 0; i < 23; i++)
            {
                try
                {
                    Bitmap bitmap = new Bitmap(location[i]);
                    images.Add(bitmap);
                }
                catch (System.IO.FileNotFoundException)
                {
                    MessageHelper.ShowError($"Could not load image: {location[i]}");
                }
            }
        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 0 && txtUsername.Text.Length <= 15)
            {
                pictureBox1.Image = images[txtUsername.Text.Length - 1];
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (txtUsername.Text.Length <= 0)
            {
                // Set default image when textbox is empty
                pictureBox1.Image = images[0];
            }
            else
            {
                pictureBox1.Image = images[22];
            }
        }

        private void TxtPassword_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap bmpass = new Bitmap(@"..\..\GUI\assets\animation\textbox_password.png");
                pictureBox1.Image = bmpass;
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageHelper.ShowError("Password animation image not found");
            }
        }

        private void TxtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 0)
            {
                pictureBox1.Image = images[txtUsername.Text.Length - 1];
            }
            else
            {
                pictureBox1.Image = images[0];
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Add your login logic here
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageHelper.ShowWarning("Please enter both username and password");
                return;
            }

            // Add authentication logic here
        }
    }
}