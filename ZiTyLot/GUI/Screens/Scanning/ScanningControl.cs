﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Screens.Scanning;

namespace ZiTyLot.GUI.Screens
{
    public partial class ScanningControl : UserControl
    {
        public ScanningControl()
        {
            InitializeComponent();
            AdjustPanelPosition();
            checkinBtn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, checkinBtn.Width, checkinBtn.Height, 10, 10));
            checkoutBtn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, checkoutBtn.Width, checkoutBtn.Height, 10, 10));

        }
        private void AdjustPanelPosition()
        {
            var screenBounds = Screen.FromControl(this).WorkingArea;

            if (screenBounds.Width <= 1600)
            {
                // For smaller screens, position uiPanel1 accordingly
                uiPanel1.Location = new System.Drawing.Point(this.panel2.Width / 4, 0);
            }
            else
            {
                uiPanel1.Location = new System.Drawing.Point(this.panel2.Width / 2 - uiPanel1.Width / 2, this.panel2.Height / 2 - uiPanel1.Height / 2);
            }
        }
        private void ScanningScreen_Resize(object sender, EventArgs e)
        {
            AdjustPanelPosition();
        }

        private void ScanningScreen_Load(object sender, EventArgs e)
        {
            //TopPnl.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, TopPnl.Width, TopPnl.Height, 10, 10
        }

        private void checkinBtn_Click(object sender, EventArgs e)
        {
            CheckInForm checkInForm = new CheckInForm();
            checkInForm.WindowState = FormWindowState.Maximized;
            checkInForm.MaximizeBox = false;
            checkInForm.Show();
        }


        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            CheckOutForm checkOutForm = new CheckOutForm();
            //checkOutForm.WindowState = FormWindowState.Maximized;
            //checkOutForm.MaximizeBox = false;
            checkOutForm.Show();
        }

    }
}