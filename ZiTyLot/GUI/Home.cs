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
using ZiTyLot.GUI.component_extensions;

namespace ZiTyLot.GUI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        private void AddMenuToSidebar()
        {
            // Create a dictionary to map buttons to their respective panels
            var panelMapping = new Dictionary<string, UserControl>
            {
                { "Home", new SessionScreen() },
                { "EmployeeManagement", new Panel2() },
            };

            // Array of menu items with names and texts
            var menuItems = new[]
            {
    new { Name = "Home", Text = "Trang chủ" },
    new { Name = "EmployeeManagement", Text = "Quản lý nhân viên" },
};

            // Iterate over the menu items
            foreach (var item in menuItems)
            {
                Button button = new Button();
                button.Name = item.Name;
                button.Text = item.Text.ToUpper(); ;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.Size = new Size(sidebar.Width - 10, 45);
                button.Image = ZiTyLot.Properties.Resources.scan;
                button.BackColor = Color.White;
                button.ForeColor = Color.Black;
                button.Dock = DockStyle.Top;
                button.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, sidebar.Width - 10, 45, 5, 5));
                button.Font = new Font("Microsoft Sans Serif", 10, Font.Style & ~FontStyle.Bold);
                button.TextImageRelation = TextImageRelation.ImageBeforeText;
                button.ImageAlign = ContentAlignment.MiddleLeft;
                button.TextAlign = ContentAlignment.MiddleRight;

                // Attach click event
                button.Click += (sender, e) =>
                {
                    LoadForm(panelMapping[item.Name]);
                    button.ForeColor = Color.White;
                    button.BackColor = Color.FromArgb(240, 118, 43);
                    foreach (Button btn in sidebarBottom.Controls)
                    {
                        if (btn != button)
                        {
                            btn.BackColor = Color.White;
                            btn.ForeColor = Color.Black;
                        }
                    }
                };
                // Add the button to the sidebar
                sidebarBottom.Controls.Add(button);
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
        }
    }
}
