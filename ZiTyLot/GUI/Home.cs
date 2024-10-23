using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Screens;

namespace ZiTyLot.GUI
{
    public partial class Home : Form
    {
        private const int widthBar = 245;
        public Home()
        {
            InitializeComponent();
            this.CenterToScreen();
            pictureBox2.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pictureBox2.Width, pictureBox2.Height, 10, 10));

        }


        private void AddMenuToSidebar()
        {
            // Create a dictionary to map buttons to their respective panels
            var panelMapping = new Dictionary<string, UserControl>
            { 
                //{ "EmployeeManagement", new Panel2() },
                { "AccountManagement", new AccountControl() },
                { "BillManagement", new BillControl() },
                { "ResidentManagement", new ResidentControl() },
                { "SessionManagement", new SessionControl() },
                { "RoleManagement", new RoleControl() },
                { "CardManagement", new CardControl() },
                { "PriceManagement", new PriceControl() },
                { "AreaManagement", new AreaControl() },
                { "Scanning", new ScanningControl() },
                //{ "BillDetails", new BillDetailControl()},
                //{ "Setting", new SettingScreen() },
            };

            // Array of menu items with names and texts
            var menuItems = new[]
            {
                //new { Name = "Setting", Text = "Setting"},
                new { Name = "PriceManagement", Text = "Price" },
                new { Name = "RoleManagement", Text = "Role" },
                new { Name = "AccountManagement", Text = "Account" },
                new { Name = "BillManagement", Text = "Bill" },
                new { Name = "CardManagement", Text = "Card" },
                new { Name = "ResidentManagement", Text = "Resident" },
                new { Name = "AreaManagement", Text = "Area" },
                new { Name = "SessionManagement", Text = "Session" },
                new { Name = "Scanning", Text = "Scanning" },
                //new { Name = "BillDetails", Text = "Bill Details" },
                //new { Name = "Dashboard", Text = "Dashboard" },
                //new { Name = "Home", Text = "Example" },
                //new { Name = "EmployeeManagement", Text = "Panel2" },
            };
            var menuIcon = new[]
            {   
                //new { Name = "Home", Icon = ZiTyLot.Properties.Resources.Icon_24x24px_Price},
                new { Name = "PriceManagement", Icon = ZiTyLot.Properties.Resources.Icon_24x24px_Price},
                new { Name = "RoleManagement", Icon = ZiTyLot.Properties.Resources.Icon_24x24px_Role},
                new { Name = "AccountManagement", Icon = ZiTyLot.Properties.Resources.Icon_24x24px_Account},
                new { Name = "BillManagement", Icon = ZiTyLot.Properties.Resources.Icon_24x24px_Bill},
                new { Name = "CardManagement", Icon = ZiTyLot.Properties.Resources.Icon_24x24px_Card},
                new { Name = "ResidentManagement", Icon = ZiTyLot.Properties.Resources.Icon_24x24px_Resident},
                new { Name = "AreaManagement", Icon = ZiTyLot.Properties.Resources.Icon_24x24px_Area},
                new { Name = "SessionManagement", Icon = ZiTyLot.Properties.Resources.Icon_24x24px_Session},
                new { Name = "Scanning", Icon = ZiTyLot.Properties.Resources.Icon_24x24px_Scanning},
                //new { Name = "BillDetails", Icon = ZiTyLot.Properties.Resources.Icon_24x24px_Scanning},

                //new { Name = "Setting", Icon = ZiTyLot.Properties.Resources.Icon_24x24px_Setting},
            };

            var menuIconActive = new[]
            {
                //new { Name = "Home", Icon = ZiTyLot.Properties.Resources.Icon_24x24px_Price_Active},
                new { Name = "PriceManagement", Icon = ZiTyLot.Properties.Resources.Icon_24x24px_Price_Active},
                new { Name = "RoleManagement", Icon = ZiTyLot.Properties.Resources.Icon_24x24px_Role_Active},
                new { Name = "AccountManagement", Icon = ZiTyLot.Properties.Resources.Icon_24x24px_Account_Active},
                new { Name = "BillManagement", Icon = ZiTyLot.Properties.Resources.Icon_24x24px_Bill_Active},
                new { Name = "CardManagement", Icon = ZiTyLot.Properties.Resources.Icon_24x24px_Card_Active},
                new { Name = "ResidentManagement", Icon = ZiTyLot.Properties.Resources.Icon_24x24px_Resident_Active},
                new { Name = "AreaManagement", Icon = ZiTyLot.Properties.Resources.Icon_24x24px_Area_Active},
                new { Name = "SessionManagement", Icon = ZiTyLot.Properties.Resources.Icon_24x24px_Session_Active},
                new { Name = "Scanning", Icon = ZiTyLot.Properties.Resources.Icon_24x24px_Scanning_Active},
                //new { Name = "BillDetails", Icon = ZiTyLot.Properties.Resources.Icon_24x24px_Scanning_Active},

                //new { Name = "Setting", Icon = ZiTyLot.Properties.Resources.Icon_24x24px_Setting_Active},
            };

            // Iterate over the menu items
            foreach (var item in menuItems)
            {
                Button button = new Button();
                button.Name = item.Name;
                button.Text = item.Text.ToString();
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.Size = new Size(sidebar.Width - 10, 45);
                button.Image = menuIcon.Where(x => x.Name == item.Name).FirstOrDefault().Icon;
                button.BackColor = Color.White;
                button.ForeColor = Color.Black;
                button.Dock = DockStyle.Top;
                button.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, sidebar.Width - 10, 45, 14, 14));
                button.Font = new Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                // Image on the left, text in the middle
                button.ImageAlign = ContentAlignment.MiddleLeft;
                button.TextAlign = ContentAlignment.MiddleCenter; // Change this to MiddleLeft for better control

                // Use Padding to move text and adjust space between image and text
                button.Padding = new Padding(20, 0, 0, 0); // Move text away from the image with left padding

                // Attach click event
                button.Click += (sender, e) =>
                {
                    LoadForm(panelMapping[item.Name]);
                    button.ForeColor = Color.White;
                    button.BackColor = Color.FromArgb(240, 118, 54);
                    button.Image = menuIconActive.Where(x => x.Name == button.Name).FirstOrDefault().Icon;
                    foreach (Button btn in sidebarMid.Controls)
                    {
                        if (btn != button)
                        {
                            btn.BackColor = Color.White;
                            btn.ForeColor = Color.Black;
                            btn.Image = menuIcon.Where(x => x.Name == btn.Name).FirstOrDefault()?.Icon;
                        }
                    }
                };
                // Add the button to the sidebar
                sidebarMid.Controls.Add(button);
            }

        }
        public void LoadForm(UserControl userControl)
        {
            if (this.pnlCardLayout.Controls.Count > 0)
            {
                this.pnlCardLayout.Controls.RemoveAt(0); // Remove the existing control
            }

            userControl.Dock = DockStyle.Fill; // Set the UserControl to fill the panel
            this.pnlCardLayout.Controls.Add(userControl); // Add the new UserControl to the panel
            this.pnlCardLayout.Tag = userControl; // Optionally set the Tag property for reference
            userControl.BringToFront(); // Bring the control to the front
        }


        private void Home_Load(object sender, EventArgs e)
        {
            AddMenuToSidebar();
            LoadForm(new ScanningControl());
            var scanningButton = sidebarMid.Controls.OfType<Button>()
                                    .FirstOrDefault(btn => btn.Name == "Scanning");
            if (scanningButton != null)
            {
                scanningButton.PerformClick();  // Simulate button click
            }
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            settingMenu.Show(settingBtn, new Point(35, settingBtn.Height - 55));
        }
        public void OpenMenu()
        {
            int initialWidth = sidebar.Width;
            int steps = 100 / 10; // 10 ms interval between each step
            int stepWidth = widthBar / steps;

            Timer timer = new Timer();
            timer.Interval = 20;
            int currentWidth = initialWidth;

            timer.Tick += (sender, e) =>
        {
            currentWidth += stepWidth;
            if (currentWidth >= widthBar)
            {
                currentWidth = widthBar;
                timer.Stop();
            }
            sidebar.Width = currentWidth;
            sidebar.Invalidate(); // To refresh the UI
        };

            timer.Start();
        }
        public void CloseMenu()
        {
            int initialWidth = sidebar.Width;
            int steps = 100 / 10; // 10 ms interval between each step
            int stepWidth = widthBar / steps;

            Timer timer = new Timer();
            timer.Interval = 20;
            int currentWidth = initialWidth;

            timer.Tick += (sender, e) =>
            {
                currentWidth -= stepWidth;
                if (currentWidth <= 0)
                {
                    currentWidth = 0;
                    timer.Stop();
                }
                sidebar.Width = currentWidth;
                sidebar.Invalidate(); // To refresh the UI
            };

            timer.Start();
        }

        private void btnToggleMenu_Click(object sender, EventArgs e)
        {
            if (sidebar.Width == 0)
            {
                OpenMenu();
            }
            else
            {
                CloseMenu();
            }
        }
    }
}
