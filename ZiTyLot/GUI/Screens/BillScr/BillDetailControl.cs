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


namespace ZiTyLot.GUI.Screens.BillScr
{
    public partial class BillDetailControl : UserControl
    {
        private readonly Debouncer _debouncer = new Debouncer();
        private readonly ResidentBUS _residentBUS = new ResidentBUS();
        private readonly Pageable _pageable = new Pageable();
        private readonly List<FilterCondition> _filters = new List<FilterCondition>();
        private Page<Resident> _page;
        private Resident _residentSelected;

        int rows = 0;
        //Home home = new Home();
        private ListBox listBox;
        public BillDetailControl()
        {
            _residentBUS = new ResidentBUS();
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
                _residentSelected = _page.Content.Where(x => x.Id == residentId).FirstOrDefault();
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

        private void ListBox_MouseEnter(object sender, EventArgs e)
        {
            if (sender is ListBox lb)
            {
                lb.BackColor = Color.LightGray;
            }
        }

        private void ListBox_MouseLeave(object sender, EventArgs e)
        {
            if (sender is ListBox lb)
            {
                lb.BackColor = SystemColors.Window; // Reset the color to the default
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

            IssueDetailForm issueDetailForm = new IssueDetailForm();
            issueDetailForm.Show();

            IssueDetailRow newRow = new IssueDetailRow();
            newRow.Dock = DockStyle.Top;

            // Listen for the RowDeleted event from the new row
            newRow.RowDeleted += (s, ev) => RemoveRow(newRow);

            listIssue.Controls.Add(newRow);
            rows += 1;
            listIssue_ResizeAutoScrollMinSize(rows);

        }

        private void RemoveRow(IssueDetailRow row)
        {
            listIssue.Controls.Remove(row);  // Remove the row from the panel
            rows -= 1;  // Decrease the row count
            listIssue_ResizeAutoScrollMinSize(rows);  // Adjust scroll area
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            //if (home != null)
            //{
            //    this.Dispose();
            //    BillControl billControl = new BillControl();
            //    home.LoadForm(billControl);
            //}
            //else
            //{
            //    MessageBox.Show("Home form is not assigned.");
            //}
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
            ChangePage(1);
        }
        private void ChangePage(int pageNumber)
        {
            _pageable.PageNumber = pageNumber;
            _page = _residentBUS.GetAllPagination(_pageable, _filters);
            LoadResidentSearch();
        }
        private void LoadResidentSearch()
        {
            var textBoxScreenPosition = tbSearch.PointToScreen(System.Drawing.Point.Empty);
            var textBoxFormPosition = this.PointToClient(textBoxScreenPosition);
            listBox.Location = new System.Drawing.Point(textBoxFormPosition.X, textBoxFormPosition.Y + tbSearch.Height + 2);
            listBox.Items.Clear();
            foreach (var resident in _page.Content)
            {
                string content = $"{resident.Id} - {resident.Full_name} - {resident.Apartment_id} - {resident.Phone}";
                listBox.Items.Add(content);
            }
            listBox.BringToFront();
            listBox.Height = 250;
            listBox.Visible = true;
        }

    }
}
