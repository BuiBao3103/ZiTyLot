using Sunny.UI;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Screens;

namespace ZiTyLot.GUI
{
    public partial class Home : Form
    {
        #region Constants
        private static readonly List<int> SIDEBAR_WIDTH = new List<int> { 60, 245 };
        private static readonly List<int> SIDEBAR_TOP_HEIGHT = new List<int> { 125, 180 };
        private const int ANIMATION_DURATION = 400;
        private const int ANIMATION_STEPS = 10;
        private const string LOGO_PATH = @"../../GUI/assets/logo.jpg";
        private const string LOGO_MINI_PATH = @"../../GUI/assets/logo_mini.png";
        #endregion

        #region Private Fields
        private bool isAnimating;
        private BufferedGraphics bufferGraphics;
        private BufferedGraphicsContext graphicsContext;
        private Dictionary<string, UserControl> panelMapping;
        private Dictionary<string, Image> menuIcon;
        private Dictionary<string, Image> menuIconActive;
        #endregion

        #region Constructor and Initialization
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
            InitializePanelMapping();
            InitializeMenuIconDictionaries();
        }

        private void InitializePanelMapping()
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
                { "Scanning", new ScanningControl() }
            };
        }

        private void InitializeMenuIconDictionaries()
        {
            menuIcon = CreateMenuIconDictionary(false);
            menuIconActive = CreateMenuIconDictionary(true);
        }

        private Dictionary<string, Image> CreateMenuIconDictionary(bool isActive)
        {
            var iconDictionary = new Dictionary<string, Image>
    {
        { "PriceManagement", isActive ? ZiTyLot.Properties.Resources.Icon_24x24px_Price_Active : ZiTyLot.Properties.Resources.Icon_24x24px_Price },
        { "RoleManagement", isActive ? ZiTyLot.Properties.Resources.Icon_24x24px_Role_Active : ZiTyLot.Properties.Resources.Icon_24x24px_Role },
        { "AccountManagement", isActive ? ZiTyLot.Properties.Resources.Icon_24x24px_Account_Active : ZiTyLot.Properties.Resources.Icon_24x24px_Account },
        { "BillManagement", isActive ? ZiTyLot.Properties.Resources.Icon_24x24px_Bill_Active : ZiTyLot.Properties.Resources.Icon_24x24px_Bill },
        { "CardManagement", isActive ? ZiTyLot.Properties.Resources.Icon_24x24px_Card_Active : ZiTyLot.Properties.Resources.Icon_24x24px_Card },
        { "ResidentManagement", isActive ? ZiTyLot.Properties.Resources.Icon_24x24px_Resident_Active : ZiTyLot.Properties.Resources.Icon_24x24px_Resident },
        { "AreaManagement", isActive ? ZiTyLot.Properties.Resources.Icon_24x24px_Area_Active : ZiTyLot.Properties.Resources.Icon_24x24px_Area },
        { "SessionManagement", isActive ? ZiTyLot.Properties.Resources.Icon_24x24px_Session_Active : ZiTyLot.Properties.Resources.Icon_24x24px_Session },
        { "Scanning", isActive ? ZiTyLot.Properties.Resources.Icon_24x24px_Scanning_Active : ZiTyLot.Properties.Resources.Icon_24x24px_Scanning }
    };

            return iconDictionary;
        }
        #endregion

        #region Menu Creation and Management
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
                new { Name = "Scanning", Text = "Scanning" }
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
                FlatStyle = FlatStyle.Flat,
                Size = new Size(sidebar.Width - 10, 45),
                Image = menuIcon[name],
                BackColor = Color.White,
                ForeColor = Color.Black,
                Dock = DockStyle.Top,
                Font = new Font("Helvetica", 12F, FontStyle.Bold),
                ImageAlign = ContentAlignment.MiddleLeft,
                TextAlign = ContentAlignment.MiddleCenter,
                Padding = new Padding(20, 0, 0, 0),
                Text = text
            };

            button.FlatAppearance.BorderSize = 0;
            button.Region = CreateButtonRegion(button.Width, button.Height);
            button.Click += (sender, e) => MenuButton_Click(button);
            sidebarMid.Controls.Add(button);
        }

        private Region CreateButtonRegion(int width, int height)
        {
            return Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, width, height, 14, 14));
        }
        #endregion

        #region Menu Animation and State Management
        private void OpenMenu()
        {
            if (isAnimating) return;
            isAnimating = true;
            
            AnimateMenu(
                initialWidth: sidebar.Width,
                targetWidth: SIDEBAR_WIDTH[1],
                isOpening: true
            );
        }

        private void CloseMenu()
        {
            if (isAnimating) return;
            isAnimating = true;
            AnimateMenu(
                initialWidth: sidebar.Width,
                targetWidth: SIDEBAR_WIDTH[0],
                isOpening: false
            );
        }

        private void AnimateMenu(int initialWidth, int targetWidth, bool isOpening)
        {
            pnlCardLayout.Visible = false;

            float stepSizeSideBar = (targetWidth - initialWidth) / (float)ANIMATION_STEPS;
            float stepSizeTopBar = CalculateTopBarStepSize(isOpening);

            Timer animationTimer = CreateAnimationTimer(
                initialWidth,
                stepSizeSideBar,
                stepSizeTopBar,
                isOpening
            );

            animationTimer.Start();
        }

        private float CalculateTopBarStepSize(bool isOpening)
        {
            return isOpening
                ? (SIDEBAR_TOP_HEIGHT[1] - SIDEBAR_TOP_HEIGHT[0]) / (float)ANIMATION_STEPS
                : (SIDEBAR_TOP_HEIGHT[0] - SIDEBAR_TOP_HEIGHT[1]) / (float)ANIMATION_STEPS;
        }

        private Timer CreateAnimationTimer(int initialWidth, float stepSizeSideBar, float stepSizeTopBar, bool isOpening)
        {
            int currentStep = 0;
            Timer timer = new Timer
            {
                Interval = ANIMATION_DURATION / ANIMATION_STEPS
            };

            timer.Tick += (sender, e) =>
            {
                currentStep++;
                if (currentStep >= ANIMATION_STEPS)
                {
                    CompleteAnimation(timer, isOpening);
                }
                else
                {
                    UpdateAnimationStep(
                        initialWidth,
                        currentStep,
                        stepSizeSideBar,
                        stepSizeTopBar,
                        isOpening
                    );
                }
            };

            return timer;
        }

        private void CompleteAnimation(Timer timer, bool isOpening)
        {
            sidebar.Width = isOpening ? SIDEBAR_WIDTH[1] : SIDEBAR_WIDTH[0];
            UpdateButtonsAfterAnimation(isOpening);

            timer.Stop();
            isAnimating = false;
            pnlCardLayout.Visible = true;

            UpdateUIAfterAnimation(isOpening);
        }

        private void UpdateAnimationStep(
            int initialWidth,
            int currentStep,
            float stepSizeSideBar,
            float stepSizeTopBar,
            bool isOpening)
        {
            sidebar.Width = (int)(initialWidth + (stepSizeSideBar * currentStep));
            sidebarTop.Height = (int)(
                (isOpening ? SIDEBAR_TOP_HEIGHT[0] : SIDEBAR_TOP_HEIGHT[1]) +
                (stepSizeTopBar * currentStep)
            );
            if (isOpening)
            {

               foreach (Button btn in sidebarMid.Controls.OfType<Button>())
                {
                    btn.Width = sidebar.Width - 10;
                    btn.Region = CreateButtonRegion(btn.Width, 45);
                }
            }
            if (isOpening && currentStep >= ANIMATION_STEPS / 2)
            {
                UpdateButtonsForExpandedState();
            }
            if (!isOpening && currentStep >= ANIMATION_STEPS / 2)
            {
                foreach (Button btn in sidebarMid.Controls.OfType<Button>())
                {
                    ResetButtonForCollapsedState(btn);
                }
            }

            sidebar.Invalidate();
        }

        private void UpdateButtonsAfterAnimation(bool isOpening)
        {
            foreach (Button btn in sidebarMid.Controls.OfType<Button>())
            {
                btn.Width = sidebar.Width - 10;
                btn.Region = CreateButtonRegion(btn.Width, 45);
            }
        }

        private void UpdateUIAfterAnimation(bool isOpening)
        {
            if (isOpening)
            {
                ApplyExpandedState();
            }
            else
            {
                ApplyCollapsedState();
            }
        }

        private void ApplyExpandedState()
        {
            pictureBox1.Image = Image.FromFile(LOGO_PATH);
            sidebarTop.Height = SIDEBAR_TOP_HEIGHT[1];
            sidebarTop.Padding = new Padding(25, 25, 25, 27);
            SetupExpandedProfileSection();
        }

        private void ApplyCollapsedState()
        {
            pictureBox1.Image = Image.FromFile(LOGO_MINI_PATH);
            sidebarTop.Height = SIDEBAR_TOP_HEIGHT[0];
            sidebarTop.Padding = new Padding(10);
            SetupCollapsedProfileSection();
        }

        private void SetupExpandedProfileSection()
        {
            pictureBox2.Visible = true;
            nameLb.Visible = true;
            roleLb.Visible = true;
            pictureBox2.Dock = DockStyle.Left;
            nameLb.Dock = DockStyle.Top;
            roleLb.Dock = DockStyle.Fill;
            settingBtn.Dock = DockStyle.Right;
        }

        private void SetupCollapsedProfileSection()
        {
            pictureBox2.Visible = false;
            nameLb.Visible = false;
            roleLb.Visible = false;
            ResetProfileControlsDocking();
            settingBtn.Dock = DockStyle.Fill;
            settingBtn.BringToFront();
            settingBtn.SetToTheCenterOfParent();
        }

        private void ResetProfileControlsDocking()
        {
            pictureBox2.Dock = DockStyle.None;
            nameLb.Dock = DockStyle.None;
            roleLb.Dock = DockStyle.None;
        }

        private void ResetButtonForCollapsedState(Button btn)
        {
            btn.Text = string.Empty;
            btn.ImageAlign = ContentAlignment.MiddleCenter;
            btn.Padding = new Padding(0);
        }

        private void UpdateButtonsForExpandedState()
        {
            foreach (Button btn in sidebarMid.Controls.OfType<Button>())
            {
                btn.Text = btn.Name.Replace("Management", "");
                btn.ImageAlign = ContentAlignment.MiddleLeft;
                btn.Padding = new Padding(20, 0, 0, 0);
            }
        }
        #endregion

        #region Event Handlers
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
                UpdateButtonStyle(btn, btn == activeButton);
            }
        }

        private void UpdateButtonStyle(Button button, bool isActive)
        {
            button.ForeColor = isActive ? Color.White : Color.Black;
            button.BackColor = isActive ? Color.FromArgb(240, 118, 54) : Color.White;
            button.Image = isActive ? menuIconActive[button.Name] : menuIcon[button.Name];
        }

        private void btnToggleMenu_Click(object sender, EventArgs e)
        {
            if (isAnimating) return;
            if (sidebar.Width == SIDEBAR_WIDTH[0])
            {
                OpenMenu();
            }
            else
            {
                CloseMenu();
            }
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            settingMenu.Show(settingBtn, new Point(35, settingBtn.Height - 55));
        }

        private void Home_Load(object sender, EventArgs e)
        {
            AddMenuToSidebar();
            LoadForm(new ScanningControl());
            var scanningButton = sidebarMid.Controls.OfType<Button>()
                                    .FirstOrDefault(btn => btn.Name == "Scanning");
            scanningButton?.PerformClick();
        }
        #endregion

        #region Form Overrides
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
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

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                CleanupResources();
            }
            base.Dispose(disposing);
        }
        #endregion

        #region Form Controls Management
        public void LoadForm(UserControl userControl)
        {
            pnlCardLayout.SuspendLayout();
            try
            {
                ClearCurrentControl();
                AddNewControl(userControl);
            }
            finally
            {
                pnlCardLayout.ResumeLayout(true);
            }
        }

        private void ClearCurrentControl()
        {
            if (pnlCardLayout.Controls.Count > 0)
            {
                pnlCardLayout.Controls.RemoveAt(0);
            }
        }

        private void AddNewControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlCardLayout.Controls.Add(userControl);
            pnlCardLayout.Tag = userControl;
            userControl.BringToFront();
        }
        #endregion

        #region Resource Management
        private void CleanupResources()
        {
            DisposeSafelyBufferGraphics();
            DisposeSafelyComponents();
        }

        private void DisposeSafelyBufferGraphics()
        {
            if (bufferGraphics != null)
            {
                bufferGraphics.Dispose();
                bufferGraphics = null;
            }
        }

        private void DisposeSafelyComponents()
        {
            if (components != null)
            {
                components.Dispose();
            }
        }
        #endregion
    }
}