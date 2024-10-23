// Home.cs
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
        private const int animationDurationInit = 300;
        private const int stepInit = 15;
        private bool isAnimating = false;
        private BufferedGraphics bufferGraphics;
        private BufferedGraphicsContext graphicsContext;
        private Dictionary<string, UserControl> panelMapping;
        private Dictionary<string, Image> menuIcon;
        private Dictionary<string, Image> menuIconActive;

        public Home()
        {
            InitializeComponent();
            InitializeGraphics();
            InitializeFormSettings();
            InitializeMenuIcons();
        }

        private void InitializeGraphics()
        {
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.UserPaint, true);

            graphicsContext = BufferedGraphicsManager.Current;
            bufferGraphics = graphicsContext.Allocate(this.CreateGraphics(),
                this.DisplayRectangle);
        }

        private void InitializeFormSettings()
        {
            this.CenterToScreen();
            pictureBox2.Region = Region.FromHrgn(
                RoundedBorder.CreateRoundRectRgn(0, 0, pictureBox2.Width,
                pictureBox2.Height, 10, 10));
        }

        private void InitializeMenuIcons()
        {
            panelMapping = new Dictionary<string, UserControl>
            {
                { "AccountManagement", new AccountControl() },
                { "BillManagement", new BillControl() },
                { "ResidentManagement", new ResidentControl() },
                { "SessionManagement", new SessionControl() },
                { "RoleManagement", new RoleControl() },
                { "CardManagement", new CardControl() },
                { "PriceManagement", new PriceControl() },
                { "AreaManagement", new AreaControl() },
                { "Scanning", new ScanningControl() },
            };

            menuIcon = new Dictionary<string, Image>
            {
                { "PriceManagement", ZiTyLot.Properties.Resources.Icon_24x24px_Price },
                { "RoleManagement", ZiTyLot.Properties.Resources.Icon_24x24px_Role },
                { "AccountManagement", ZiTyLot.Properties.Resources.Icon_24x24px_Account },
                { "BillManagement", ZiTyLot.Properties.Resources.Icon_24x24px_Bill },
                { "CardManagement", ZiTyLot.Properties.Resources.Icon_24x24px_Card },
                { "ResidentManagement", ZiTyLot.Properties.Resources.Icon_24x24px_Resident },
                { "AreaManagement", ZiTyLot.Properties.Resources.Icon_24x24px_Area },
                { "SessionManagement", ZiTyLot.Properties.Resources.Icon_24x24px_Session },
                { "Scanning", ZiTyLot.Properties.Resources.Icon_24x24px_Scanning },
            };

            menuIconActive = new Dictionary<string, Image>
            {
                { "PriceManagement", ZiTyLot.Properties.Resources.Icon_24x24px_Price_Active },
                { "RoleManagement", ZiTyLot.Properties.Resources.Icon_24x24px_Role_Active },
                { "AccountManagement", ZiTyLot.Properties.Resources.Icon_24x24px_Account_Active },
                { "BillManagement", ZiTyLot.Properties.Resources.Icon_24x24px_Bill_Active },
                { "CardManagement", ZiTyLot.Properties.Resources.Icon_24x24px_Card_Active },
                { "ResidentManagement", ZiTyLot.Properties.Resources.Icon_24x24px_Resident_Active },
                { "AreaManagement", ZiTyLot.Properties.Resources.Icon_24x24px_Area_Active },
                { "SessionManagement", ZiTyLot.Properties.Resources.Icon_24x24px_Session_Active },
                { "Scanning", ZiTyLot.Properties.Resources.Icon_24x24px_Scanning_Active },
            };
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void AddMenuToSidebar()
        {
            var menuItems = new[]
            {
                new { Name = "PriceManagement", Text = "Price" },
                new { Name = "RoleManagement", Text = "Role" },
                new { Name = "AccountManagement", Text = "Account" },
                new { Name = "BillManagement", Text = "Bill" },
                new { Name = "CardManagement", Text = "Card" },
                new { Name = "ResidentManagement", Text = "Resident" },
                new { Name = "AreaManagement", Text = "Area" },
                new { Name = "SessionManagement", Text = "Session" },
                new { Name = "Scanning", Text = "Scanning" },
            };

            foreach (var item in menuItems)
            {
                CreateMenuButton(item.Name, item.Text);
            }
        }

        private void CreateMenuButton(string name, string text)
        {
            Button button = new Button
            {
                Name = name,
                Text = text,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(sidebar.Width - 10, 45),
                Image = menuIcon[name],
                BackColor = Color.White,
                ForeColor = Color.Black,
                Dock = DockStyle.Top,
                Font = new Font("Helvetica", 12F, FontStyle.Bold),
                ImageAlign = ContentAlignment.MiddleLeft,
                TextAlign = ContentAlignment.MiddleCenter,
                Padding = new Padding(20, 0, 0, 0)
            };

            button.FlatAppearance.BorderSize = 0;
            button.Region = Region.FromHrgn(
                RoundedBorder.CreateRoundRectRgn(0, 0, sidebar.Width - 10, 45, 14, 14));

            button.Click += (sender, e) => MenuButton_Click(button);
            sidebarMid.Controls.Add(button);
        }

        private void MenuButton_Click(Button clickedButton)
        {
            if (panelMapping.TryGetValue(clickedButton.Name, out UserControl control))
            {
                LoadForm(control);
                UpdateButtonStyles(clickedButton);
            }
        }

        private void UpdateButtonStyles(Button activeButton)
        {
            foreach (Button btn in sidebarMid.Controls.OfType<Button>())
            {
                if (btn == activeButton)
                {
                    btn.ForeColor = Color.White;
                    btn.BackColor = Color.FromArgb(240, 118, 54);
                    btn.Image = menuIconActive[btn.Name];
                }
                else
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                    btn.Image = menuIcon[btn.Name];
                }
            }
        }

        public void LoadForm(UserControl userControl)
        {
            pnlCardLayout.SuspendLayout();
            if (pnlCardLayout.Controls.Count > 0)
            {
                pnlCardLayout.Controls.RemoveAt(0);
            }

            userControl.Dock = DockStyle.Fill;
            pnlCardLayout.Controls.Add(userControl);
            pnlCardLayout.Tag = userControl;
            userControl.BringToFront();
            pnlCardLayout.ResumeLayout(true);
        }

        public void OpenMenu()
        {
            if (isAnimating) return;
            isAnimating = true;

            // Tạm ẩn panel bên phải trong lúc thực hiện animation
            pnlCardLayout.Visible = false;

            int initialWidth = sidebar.Width;
            int targetWidth = widthBar;
            int animationDuration = animationDurationInit;
            int steps = 5;
            int stepDelay = animationDuration / steps;
            float stepSize = (targetWidth - initialWidth) / (float)steps;

            Timer timer = new Timer();
            timer.Interval = stepDelay;
            int currentStep = 0;

            timer.Tick += (sender, e) =>
            {
                currentStep++;
                if (currentStep >= steps)
                {
                    sidebar.Width = targetWidth;
                    timer.Stop();
                    isAnimating = false;
                    this.Refresh(); // Chỉ refresh phần sidebar

                    // Hiện lại panel bên phải sau khi animation hoàn tất
                    pnlCardLayout.Visible = true;
                }
                else
                {
                    int newWidth = (int)(initialWidth + (stepSize * currentStep));
                    sidebar.SuspendLayout();
                    sidebar.Width = newWidth;
                    sidebar.ResumeLayout(false);
                }

                // Chỉ vẽ lại sidebar
                sidebar.Invalidate();
            };

            timer.Start();
        }

        public void CloseMenu()
        {
            if (isAnimating) return;
            isAnimating = true;

            // Tạm ẩn panel bên phải trong lúc thực hiện animation
            pnlCardLayout.Visible = false;

            int initialWidth = sidebar.Width;
            int targetWidth = 0;
            int animationDuration = animationDurationInit;
            int steps = stepInit;
            int stepDelay = animationDuration / steps;
            float stepSize = (targetWidth - initialWidth) / (float)steps;

            Timer timer = new Timer();
            timer.Interval = stepDelay;
            int currentStep = 0;

            timer.Tick += (sender, e) =>
            {
                currentStep++;
                if (currentStep >= steps)
                {
                    sidebar.Width = targetWidth;
                    timer.Stop();
                    isAnimating = false;
                    this.Refresh(); // Chỉ refresh phần sidebar

                    // Hiện lại panel bên phải sau khi animation hoàn tất
                    pnlCardLayout.Visible = true;
                }
                else
                {
                    int newWidth = (int)(initialWidth + (stepSize * currentStep));
                    sidebar.SuspendLayout();
                    sidebar.Width = newWidth;
                    sidebar.ResumeLayout(false);
                }

                // Chỉ vẽ lại sidebar
                sidebar.Invalidate();
            };

            timer.Start();
        }

        private void btnToggleMenu_Click(object sender, EventArgs e)
        {
            if (isAnimating) return;
            if (sidebar.Width == 0)
            {
                OpenMenu();
            }
            else
            {
                CloseMenu();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (isAnimating)
            {
                using (BufferedGraphics bg = graphicsContext.Allocate(
                    e.Graphics, this.DisplayRectangle))
                {
                    bg.Graphics.Clear(this.BackColor);
                    base.OnPaint(new PaintEventArgs(bg.Graphics, e.ClipRectangle));
                    bg.Render(e.Graphics);
                }
            }
            else
            {
                base.OnPaint(e);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            AddMenuToSidebar();
            LoadForm(new ScanningControl());
            var scanningButton = sidebarMid.Controls.OfType<Button>()
                                    .FirstOrDefault(btn => btn.Name == "Scanning");
            scanningButton?.PerformClick();
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            settingMenu.Show(settingBtn, new Point(35, settingBtn.Height - 55));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (bufferGraphics != null)
                {
                    bufferGraphics.Dispose();
                    bufferGraphics = null;
                }
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
    }
}