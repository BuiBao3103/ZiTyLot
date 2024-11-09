using System;
using System.Drawing;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Utils;

namespace ZiTyLot.GUI.Screens.BillScr
{
    public partial class BillDetailControl : UserControl
    {
        private readonly BillBUS _billBUS = new BillBUS();
        private Bill _bill;
        public BillDetailControl(int billId)
        {
            InitializeComponent();
            _bill = _billBUS.GetById(billId);
            _bill = _billBUS.PopulateIssues(_bill);
            _bill = _billBUS.PopulateResident(_bill);

            lbBillDetail.Text += $" - {_bill.Id}";
            tbTotalBill.Text = _bill.Total_fee.ToString("C0", new System.Globalization.CultureInfo("vi-VN"));


            tbID.Text = _bill.Resident.Id.ToString();
            tbFullname.Text = _bill.Resident.Full_name;
            tbApartment.Text = _bill.Resident.Apartment_id;
            tbPhone.Text = _bill.Resident.Phone;
            tbEmail.Text = _bill.Resident.Email;

            foreach(Issue issue in _bill.Issues)
            {
                IssueDetailRow newRow = new IssueDetailRow(issue, true);
                listIssue.Controls.Add(newRow);
            }
        }

        private void pnlBottom_Resize(object sender, EventArgs e)
        {
            pnlBottom.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 10, 10));
        }

        private void pnlTop_Resize(object sender, EventArgs e)
        {
            pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
        }

        private void BillDetailControl_Load(object sender, EventArgs e)
        {
            pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
            pnlBottom.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 10, 10));

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home home = (Home)ParentForm;
            if (home.panelMapping.TryGetValue("BillManagement", out UserControl control))
            {
                home.LoadForm(control);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (.pdf)|*.pdf",
                FilterIndex = 1,
                RestoreDirectory = true,
                FileName = $"Bill_{_bill.Id}.pdf"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string logoPath = @"../../GUI/assets/Zity-logo-256x256px.png";
                    PdfHelper.ExportBillToPdf(_bill, saveFileDialog.FileName, logoPath);
                    MessageHelper.ShowSuccess("Bill exported to PDF successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageHelper.ShowError("Some error occurred while exporting bill to PDF. Please try again later.");
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PdfHelper.PrintBill(_bill);
        }
    }
}
