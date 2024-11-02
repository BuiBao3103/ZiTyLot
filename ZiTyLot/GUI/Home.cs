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
using ZiTyLot.GUI.Screens.LostCardScr;
using Sunny.UI.Win32;

namespace ZiTyLot.GUI
{
    public partial class Home : Form
    {
        #region Constants
        private static readonly List<int> SIDEBAR_WIDTH = new List<int> { 80, 245 };
        private static readonly List<int> SIDEBAR_TOP_HEIGHT = new List<int> { 60, 120 };
        private const int ANIMATION_DURATION = 100;
        private const int ANIMATION_STEPS = 20;
        private const string LOGO_PATH = @"../../GUI/assets/Zity-logo-256x256px.png";
        private const string LOGO_MINI_PATH = @"../../GUI/assets/logo_mini.png";
        private readonly dynamic[] menuItems = new[]
        {
            new { Name = "LostCardManagement", Text = "Lost Card" ,Icon=61553, X = -50,X_Collapsed=0, Y_Collapsed=2},
            new { Name = "PriceManagement", Text = "Price" ,Icon=362778 , X = -53,X_Collapsed=-3 , Y_Collapsed=1},
            new { Name = "RoleManagement", Text = "Role", Icon = 61459, X = -50, X_Collapsed = 0, Y_Collapsed = 2 },
            new { Name = "AccountManagement", Text = "Account", Icon = 559389, X = -50, X_Collapsed = 0, Y_Collapsed = 2 },
            new { Name = "BillManagement", Text = "Bill", Icon = 362833, X = -49, X_Collapsed = 1, Y_Collapsed = 1 },
            new { Name = "CardManagement", Text = "Card", Icon = 559504, X = -50, X_Collapsed = 0, Y_Collapsed = 2 },
            new { Name = "ResidentManagement", Text = "Resident", Icon = 358675, X = -53, X_Collapsed = -3, Y_Collapsed = 1 },
            new { Name = "AreaManagement", Text = "Area", Icon = 559505, X = -50, X_Collapsed = 0, Y_Collapsed = 1 },
            new { Name = "SessionManagement", Text = "Session", Icon = 361914, X = -50, X_Collapsed = -1, Y_Collapsed = 0 },
            new { Name = "Scanning", Text = "Scanning", Icon = 61767, X = -48 ,X_Collapsed=1, Y_Collapsed=2}
        };
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
        }

        private void InitializeMenuIcons()
        {
            InitializePanelMapping();
        }

        private void InitializePanelMapping()
        {
            panelMapping = new Dictionary<string, UserControl>
            {
                { "LostCardManagement", new LostCardControl()},
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
        private void AddMenuToSidebar()
        {
            foreach (var item in menuItems)
            {
                CreateMenuButton(item.Name, item.Icon, item.Text, item.X);
            }
        }

        private void CreateMenuButton(string name,int icon, string text, int xOffset)
        {
            // Create a panel white fill, no rect and radius 0 and padding bottom 10 with sunny ui
            Sunny.UI.UIPanel panel = new Sunny.UI.UIPanel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                FillColor = Color.White,
                Radius = 0,
                RectSize = 1,
                RectColor = Color.White,
                Padding = new Padding(0, 5, 0, 5)
            };
            Sunny.UI.UISymbolButton button = new Sunny.UI.UISymbolButton
            {
                Name = name,
                Size = new Size(sidebar.Width - 20, 40),
                Symbol = icon,
                SymbolColor = Color.Black,
                SymbolHoverColor = Color.White,
                SymbolSize = 28,
                SymbolPressColor = Color.White,
                SymbolSelectedColor = Color.White,
                BackColor = Color.White,
                Dock = DockStyle.Top,
                Font = new Font("Helvetica", 12F, FontStyle.Bold),
                ImageAlign = ContentAlignment.MiddleLeft,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(70, 3, 3, 3),
                SymbolOffset = new Point(xOffset, 1),
                RectSize = 2,
                Radius = 10,
                RectColor = Color.FromArgb(255,255,255),
                RectHoverColor = Color.FromArgb(240, 118, 54),
                RectSelectedColor = Color.FromArgb(240, 118, 54),
                RectPressColor = Color.FromArgb(240, 118, 54),
                FillColor = Color.FromArgb(255,255,255),
                FillHoverColor = Color.FromArgb(240,118,54),
                FillSelectedColor = Color.FromArgb(240, 118, 54),
                FillPressColor = Color.FromArgb(240, 118, 54),
                ForeColor = Color.Black,
                ForeHoverColor = Color.White,
                ForeSelectedColor = Color.White,
                ForePressColor = Color.White,
                Text = text
            };
            button.Click += (sender, e) => MenuButton_Click(button);
            panel.Controls.Add(button);
            sidebarMid.Controls.Add(panel);
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
                foreach (Sunny.UI.UIPanel panel in sidebarMid.Controls.OfType<Sunny.UI.UIPanel>())
                {
                    foreach (Sunny.UI.UISymbolButton btn in panel.Controls.OfType<Sunny.UI.UISymbolButton>())
                    {
                        btn.Width = sidebar.Width - 10;
                    }
                }
            }
            if (isOpening && currentStep >= ANIMATION_STEPS / 2)
            {
                foreach (Sunny.UI.UIPanel panel in sidebarMid.Controls.OfType<Sunny.UI.UIPanel>())
                {
                    foreach (Sunny.UI.UISymbolButton btn in panel.Controls.OfType<Sunny.UI.UISymbolButton>())
                    {
                        // Find the corresponding menu item by button name
                        var menuItem = Array.Find(menuItems, item => item.Name == btn.Name);

                        if (menuItem != null)
                        {
                            // Use menuItem.X_Collapsed as the X_Collapsed value for this button
                            UpdateButtonsForExpandedState(btn, menuItem.X);
                        }
                    }
                }

            }
            if (!isOpening && currentStep >= ANIMATION_STEPS / 2)
            {
                foreach (Sunny.UI.UIPanel panel in sidebarMid.Controls.OfType<Sunny.UI.UIPanel>())
                {
                    foreach (Sunny.UI.UISymbolButton btn in panel.Controls.OfType<Sunny.UI.UISymbolButton>())
                    {
                        // Find the corresponding menu item by button name
                        var menuItem = Array.Find(menuItems, item => item.Name == btn.Name);

                        if (menuItem != null)
                        {
                            // Use menuItem.X_Collapsed as the X_Collapsed value for this button
                            ResetButtonForCollapsedState(btn, menuItem.X_Collapsed, menuItem.Y_Collapsed);
                        }
                    }
                }
            }

            sidebar.Invalidate();
        }

        private void UpdateButtonsAfterAnimation(bool isOpening)
        {
            foreach (Sunny.UI.UIPanel panel in sidebarMid.Controls.OfType<Sunny.UI.UIPanel>())
            {
                foreach (Sunny.UI.UISymbolButton btn in panel.Controls.OfType<Sunny.UI.UISymbolButton>())
                {
                    btn.Width = sidebar.Width - 10;
                }
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
            SetupExpandedProfileSection();
        }

        private void ApplyCollapsedState()
        {
            pictureBox1.Image = Image.FromFile(LOGO_MINI_PATH);
            sidebarTop.Height = SIDEBAR_TOP_HEIGHT[0];
            SetupCollapsedProfileSection();
        }

        private void SetupExpandedProfileSection()
        {
            lbName.Visible = true;
            sidebarBottom.Height = 60;

            // Reset tableSetting to 3 columns and 1 row
            tableSetting.ColumnCount = 3;
            tableSetting.ColumnStyles.Clear();
            tableSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));  // First column for pictureBox2
            tableSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));   // Second column for lbName
            tableSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));  // Third column for btnMore

            tableSetting.RowCount = 1;
            tableSetting.RowStyles.Clear();
            tableSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));

            // Update control positions within tableSetting
            tableSetting.Controls.Clear();
            tableSetting.Controls.Add(pictureBox2, 0, 0);  // pictureBox2 in the first column
            tableSetting.Controls.Add(lbName, 1, 0);       // lbName in the second column
            tableSetting.Controls.Add(btnMore, 2, 0);      // btnMore in the third column

            // Dock tableSetting to fill the parent container
            tableSetting.Dock = System.Windows.Forms.DockStyle.Fill;
        }


        private void SetupCollapsedProfileSection()
        {
            lbName.Visible = false;
            sidebarBottom.Height = 120;

            // Update tableSetting to be 1 column and 3 rows, with lbName hidden in a 0-height row
            tableSetting.ColumnCount = 1;
            tableSetting.ColumnStyles.Clear();
            tableSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));

            tableSetting.RowCount = 3;
            tableSetting.RowStyles.Clear();
            tableSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));  // First row for btnMore
            tableSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));   // Second row for lbName with height 0
            tableSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F)); // Last row for pictureBox2

            // Update control positions within tableSetting
            tableSetting.Controls.Clear();
            tableSetting.Controls.Add(btnMore, 0, 0);          // Add btnMore to first row
            tableSetting.Controls.Add(lbName, 0, 1);           // Add lbName to second row with height 0
            tableSetting.Controls.Add(pictureBox2, 0, 2);      // Add pictureBox2 to last row

            // Ensure table layout is docked to fill the parent container
            tableSetting.Dock = System.Windows.Forms.DockStyle.Fill;
        }



        private void ResetButtonForCollapsedState(Sunny.UI.UISymbolButton btn, int x_collapsed, int y_collapsed)
        {
            btn.Text = string.Empty;
            btn.ImageAlign = ContentAlignment.MiddleCenter;
            btn.Padding = new Padding(0);
            btn.SymbolOffset = new Point(x_collapsed, y_collapsed);
        }

        private void UpdateButtonsForExpandedState(Sunny.UI.UISymbolButton btn, int x_offset)
        {
            btn.Text = btn.Name.Replace("Management", "");
            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(70, 3, 3, 3);
            btn.SymbolOffset = new Point(x_offset, 1);       
        }
        #endregion

        #region Event Handlers
        private void MenuButton_Click(Sunny.UI.UISymbolButton clickedButton)
        {
            if (panelMapping.TryGetValue(clickedButton.Name, out UserControl control))
            {
                LoadForm(control);
                UpdateButtonStyles(clickedButton);
            }
        }

        private void UpdateButtonStyles(Sunny.UI.UISymbolButton activeButton)
        {
            // Update the style of the clicked button
            foreach (Sunny.UI.UIPanel panel in sidebarMid.Controls.OfType<Sunny.UI.UIPanel>())
            {
                foreach (Sunny.UI.UISymbolButton btn in panel.Controls.OfType<Sunny.UI.UISymbolButton>())
                {
                    UpdateButtonStyle(btn, btn == activeButton);
                }
            }
        }

        private void UpdateButtonStyle(Sunny.UI.UISymbolButton button, bool isActive)
        {
            button.ForeColor = isActive ? Color.White : Color.Black;
            button.FillColor = isActive ? Color.FromArgb(240, 118, 54) : Color.White;
            button.RectColor = isActive ? Color.FromArgb(240, 118, 54) : Color.White;
            button.RectHoverColor = isActive ? Color.FromArgb(240, 118, 54) : Color.White;
            button.Radius = 10;
            button.RectSize = 2;
            button.RectSelectedColor = isActive ? Color.FromArgb(240, 118, 54) : Color.White;
            button.RectPressColor = isActive ? Color.FromArgb(240, 118, 54) : Color.White;
            button.SymbolColor = isActive ? Color.White : Color.Black;
            button.Padding = new Padding(70, 3, 3, 3);
            
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
        private void btnMore_Click(object sender, EventArgs e)
        {
            this.menuSetting.Show(btnMore, new Point(btnMore.Width + 25, btnMore.Height - 60));
        }

        private void Home_Load(object sender, EventArgs e)
        {
            AddMenuToSidebar();
            LoadForm(new ScanningControl());
            UpdateButtonStyle(sidebarMid.Controls.OfType<Sunny.UI.UIPanel>().Last().Controls.OfType<Sunny.UI.UISymbolButton>().First(), true);
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