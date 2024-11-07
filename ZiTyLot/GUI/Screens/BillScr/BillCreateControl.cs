using System;
using System.Windows.Forms;
using System.Drawing;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.BUS;
using ZiTyLot.ENTITY;
using System.Collections.Generic;
using ZiTyLot.Helper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading.Tasks;
using System.Linq;
using ZiTyLot.GUI.Utils;


namespace ZiTyLot.GUI.Screens.BillScr
{
    public partial class BillCreateControl : UserControl
    {
        private readonly Debouncer _debouncer = new Debouncer();
        private readonly ResidentBUS _residentBUS = new ResidentBUS();
        private readonly BillBUS _billBUS = new BillBUS();
        private readonly List<FilterCondition> _filters = new List<FilterCondition>();
        private List<Resident> _residents;
        private Resident _residentSelected;

        private IssueDetailForm _AddIssueForm;
        private readonly List<Issue> _issues;

        int rows = 0;
        private ListBox listBox;

        public event EventHandler billInsertionEvent;
        public BillCreateControl()
        {
            _residentBUS = new ResidentBUS();
            _issues = new List<Issue>();
            InitializeComponent();
            pnlBillDetail.RowStyles[1] = new RowStyle(SizeType.Absolute, 0);
            listIssue.AutoScroll = true;
            InitListBox();

        }
        private void InitListBox()
        {
            listBox = new ListBox
            {
                Width = tableSearch.Width,
                Visible = false,
                Height = 250,
                Font = new Font("Arial", 12)
            };

            //listBox.MouseEnter += ListBox_MouseEnter;
            //listBox.MouseLeave += ListBox_MouseLeave;

            listBox.Click += (s, ev) =>
            {
                tbSearch.Text = "";
                listBox.Visible = false;
                if (listBox.SelectedItem == null)
                {
                    return;
                }
                int residentId = int.Parse(listBox.SelectedItem.ToString().Split('-')[0]);
                _residentSelected = _residents.Where(x => x.Id == residentId).FirstOrDefault();
                tbID.Text = _residentSelected.Id.ToString();
                tbFullname.Text = _residentSelected.Full_name;
                tbApartment.Text = _residentSelected.Apartment_id;
                tbPhone.Text = _residentSelected.Phone;
                tbEmail.Text = _residentSelected.Email;
            };

            listBox.Height = listBox.PreferredHeight;
            listBox.BringToFront();
            this.Controls.Add(listBox);
        }

        //private void ListBox_MouseEnter(object sender, EventArgs e)
        //{
        //    if (sender is ListBox lb)
        //    {
        //        lb.BackColor = Color.LightGray;
        //    }
        //}

        //private void ListBox_MouseLeave(object sender, EventArgs e)
        //{
        //    if (sender is ListBox lb)
        //    {
        //        lb.BackColor = SystemColors.Window; // Reset the color to the default
        //    }
        //}

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (_AddIssueForm == null || _AddIssueForm.IsDisposed)
            {
                _AddIssueForm = new IssueDetailForm();
                _AddIssueForm.IssueInsertionEvent += (s, ev) => AddRow(_AddIssueForm._newIssue);
                _AddIssueForm.Show();
            }
            else
            {
                if (_AddIssueForm.WindowState == FormWindowState.Minimized)
                    _AddIssueForm.WindowState = FormWindowState.Normal;
                _AddIssueForm.BringToFront();
            }
        }
        private void AddRow(Issue newIssue)
        {
            IssueDetailRow newRow = new IssueDetailRow(newIssue);
            _issues.Add(newIssue);
            newRow.RowDeleted += (s, ev) => RemoveRow(newRow);
            listIssue.Controls.Add(newRow);
            rows += 1;
            listIssue_ResizeAutoScrollMinSize(rows);
            updateTotalBill();
        }
        private void RemoveRow(IssueDetailRow issueDetailRow)
        {
            _issues.RemoveAt(_issues.FindIndex(x => x.Id == issueDetailRow._issue.Id));
            listIssue.Controls.Remove(issueDetailRow);
            rows -= 1;
            listIssue_ResizeAutoScrollMinSize(rows);
            updateTotalBill();
        }
        private void updateTotalBill()
        {
            double total = 0;
            foreach (Issue issue in _issues)
            {
                total += issue.Fee;
            }
            tbTotalBill.Text = total.ToString("C0", new System.Globalization.CultureInfo("vi-VN"));
        }

        private void listIssue_ResizeAutoScrollMinSize(int rows)
        {
            int newHeight = 60 * rows;  // Assuming each row is 60px in height

            // Adjust the scrollable area based on the number of rows
            listIssue.AutoScrollMinSize = new Size(listIssue.AutoScrollMinSize.Width, newHeight);
        }


        private void pnlIssueTable_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in listIssue.Controls)
            {
                control.Width = listIssue.Width - 40;
            }
        }

        private void BillDetailControl_Load(object sender, EventArgs e)
        {
            pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
            pnlBottom.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 10, 10));
            //home = this.ParentForm as Home;
        }

        private void pnlTop_Resize(object sender, EventArgs e)
        {
            pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
        }

        private void pnlBottom_Resize(object sender, EventArgs e)
        {
            pnlBottom.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 10, 10));

        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbFilter.SelectedIndex;
            switch (index)
            {
                case 0:
                    tableSearch.ColumnStyles[1] = new ColumnStyle(SizeType.Absolute, 65);
                    break;
                case 1:
                    tableSearch.ColumnStyles[1] = new ColumnStyle(SizeType.Absolute, 120);
                    break;
                case 2:
                    tableSearch.ColumnStyles[1] = new ColumnStyle(SizeType.Absolute, 140);
                    break;
                case 3:
                    tableSearch.ColumnStyles[1] = new ColumnStyle(SizeType.Absolute, 95);
                    break;
            }
            Query();
        }
        private async void tbSearch_TextChanged(object sender, EventArgs e)
        {
            await _debouncer.DebounceAsync(() =>
            {
                Query();
                return Task.CompletedTask;
            }, 500);
        }
        private void Query()
        {
            int inputCboxIndex = cbFilter.SelectedIndex;
            string inputSearch = tbSearch.Text.Trim();
            if (string.IsNullOrEmpty(inputSearch))
            {
                _filters.Clear();
                return;
            }
            _filters.Clear();
            if (!string.IsNullOrEmpty(inputSearch))
            {
                switch (inputCboxIndex)
                {
                    case 0:
                        _filters.Add(new FilterCondition(nameof(Resident.Id), CompOp.Equals, inputSearch));
                        break;
                    case 1:
                        _filters.Add(new FilterCondition(nameof(Resident.Full_name), CompOp.Like, inputSearch));
                        break;
                    case 2:
                        _filters.Add(new FilterCondition(nameof(Resident.Apartment_id), CompOp.Like, inputSearch));
                        break;
                    case 3:
                        _filters.Add(new FilterCondition(nameof(Resident.Phone), CompOp.Like, inputSearch));
                        break;
                }
            }
            _residents = _residentBUS.GetAll(_filters);
            LoadResidentSearch();
        }

        private void LoadResidentSearch()
        {
            var textBoxScreenPosition = tbSearch.PointToScreen(System.Drawing.Point.Empty);
            var textBoxFormPosition = this.PointToClient(textBoxScreenPosition);
            listBox.Location = new System.Drawing.Point(textBoxFormPosition.X, textBoxFormPosition.Y + tbSearch.Height + 2);
            listBox.Items.Clear();
            foreach (var resident in _residents)
            {
                string content = $"{resident.Id} - {resident.Full_name} - {resident.Apartment_id} - {resident.Phone}";
                listBox.Items.Add(content);
            }
            listBox.BringToFront();
            listBox.Height = 250;
            listBox.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Home home = (Home)ParentForm;
            if (home.panelMapping.TryGetValue("BillManagement", out UserControl control))
            {
                home.LoadForm(control);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!validate()) return;
            try
            {
                Bill newBill = new Bill
                {
                    Issue_quantity = _issues.Count,
                    Total_fee = _issues.Sum(x => x.Fee),
                    Resident_id = _residentSelected.Id,
                    Account_id = 1,
                };

                newBill = _billBUS.Create(newBill, _issues);
                newBill.Resident = _residentSelected;
                newBill.Issues = _issues;
                MessageHelper.ShowSuccess("Bill created successfully!");
                DialogResult resultSaveBill = MessageHelper.ShowConfirm("Do you want save this bill?");
                if (resultSaveBill == DialogResult.Yes)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "PDF files (.pdf)|*.pdf",
                        FilterIndex = 1,
                        RestoreDirectory = true
                    };
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            string logoPath = @"../../GUI/assets/Zity-logo-256x256px.png";
                            PdfHelper.ExportBillToPdf(newBill, saveFileDialog.FileName, logoPath);
                            MessageHelper.ShowSuccess("Bill exported to PDF successfully!");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            MessageHelper.ShowError("Some error occurred while exporting bill to PDF. Please try again later.");
                        }
                    }
                }
                DialogResult result = MessageHelper.ShowConfirm("Do you want to print this bill?");
                if (result == DialogResult.Yes)
                {
                    PdfHelper.PrintBill(newBill);
                    MessageHelper.ShowSuccess("Bill sent to printer successfully!");
                }
                Home home = (Home)ParentForm;
                billInsertionEvent?.Invoke(this, EventArgs.Empty);
                if (home.panelMapping.TryGetValue("BillManagement", out UserControl control))
                {
                    home.LoadForm(control);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageHelper.ShowError("Some error occurred while creating bill. Please try again later.");
            }
           
        }

        private bool validate()
        {
            if (_residentSelected == null)
            {
                MessageHelper.ShowWarning("Please select a resident to create bill.");
                return false;
            }
            if (_issues.Count == 0)
            {
                MessageHelper.ShowWarning("Please add at least one issue to create bill.");
                return false;
            }
            return true;
        }

    }
}
