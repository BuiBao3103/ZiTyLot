﻿using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ZiTyLot.GUI.Screens.ScanningScr
{
    public partial class CheckOutForm : Form
    {
        public CheckOutForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.KeyPreview = true;
        }

        private void pnlInformation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOpen_Resize(object sender, System.EventArgs e)
        {
            if(this.Size.Width > 1800)
            {
                btnOpen.Font = new System.Drawing.Font("Helvetica", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            else
            {
                btnOpen.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }

        private void uiTableLayoutPanel4_Resize(object sender, System.EventArgs e)
        {

            foreach (Label lable in uiTableLayoutPanel4.Controls)
            {
                if (this.Size.Width > 1800)
                {
                    lable.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else
                {
                    lable.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
            
        }

        private void uiTableLayoutPanel5_Resize(object sender, System.EventArgs e)
        {
            foreach (Label lable in uiTableLayoutPanel5.Controls)
            {
                if (this.Size.Width > 1800)
                {
                    lable.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else
                {
                    lable.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void uiTableLayoutPanel3_Resize(object sender, System.EventArgs e)
        {
            foreach (Label lable in uiTableLayoutPanel3.Controls)
            {
                if (this.Size.Width > 1800)
                {
                    lable.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else
                {
                    lable.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void CheckOutForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                SettingForm settingForm = new SettingForm();
                settingForm.Show();
                
            }
        }
        
        private void uiTableLayoutPanel2_Resize(object sender, System.EventArgs e)
        {
            foreach (Label lable in uiTableLayoutPanel2.Controls)
            {
                if (this.Size.Width > 1800)
                {
                    lable.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else
                {
                    lable.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
    }
}
