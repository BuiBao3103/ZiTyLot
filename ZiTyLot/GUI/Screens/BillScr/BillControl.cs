using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.Constants;
using ZiTyLot.DTOS;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Screens.BillScr;
using ZiTyLot.Helper;
namespace ZiTyLot.GUI.Screens
{
    public partial class BillControl : UserControl
    {
        private readonly Debouncer _debouncer = new Debouncer();
        private readonly BillBUS billBUS = new BillBUS();
        private readonly Pageable pageable = new Pageable();
        private readonly List<FilterCondition> filters = new List<FilterCondition>();
        private Page<Bill> page;

        public BillControl()
        {
            InitializeComponent();
            cbNumberofitem.SelectedIndexChanged -= numberofitemsCb_SelectedIndexChanged;
            cbNumberofitem.Items.AddRange(pageable.PageNumbersInit.Select(pageNumber => pageNumber + " items").ToArray());
            cbNumberofitem.SelectedIndex = 0;
            cbNumberofitem.SelectedIndexChanged += numberofitemsCb_SelectedIndexChanged;
            TopPnl_Resize(null, null);
            BottomPnl_Resize(null, null);
        }

        private void BillScreen_Load(object sender, EventArgs e)
        {
            pnlPagination.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlPagination.Width, pnlPagination.Height, 10, 10));

            pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
            pnlBottom.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 10, 10));


            this.tableBill.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.table_CellPainting);
            this.tableBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
        }
        private void table_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == tableBill.Columns["colView"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex % 2 == 0)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.WhiteSmoke), e.CellBounds);
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.White), e.CellBounds);
                }
                System.Drawing.Image icon = null;
                icon = Properties.Resources.Icon_18x18px_View;
                int iconWidth = 16;
                int iconHeight = 16;
                int x = e.CellBounds.Left + (e.CellBounds.Width - iconWidth) / 2;
                int y = e.CellBounds.Top + (e.CellBounds.Height - iconHeight) / 2;
                if (icon != null)
                {
                    e.Graphics.DrawImage(icon, new Rectangle(x, y, iconWidth, iconHeight));
                }
                e.Handled = true;
            }
        }

        // Cell click event handler
        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = (int)tableBill.Rows[e.RowIndex].Cells["colId"].Value;
                if (e.ColumnIndex == tableBill.Columns["colView"].Index)
                {
                    Home home = (Home)ParentForm;
                    BillDetailControl billDetailControl = new BillDetailControl(id);
                    home.LoadForm(billDetailControl);

                }
            }
        }

        private void TopPnl_Resize(object sender, EventArgs e)
        {
            pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
        }

        private void BottomPnl_Resize(object sender, EventArgs e)
        {
            pnlBottom.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 10, 10));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Home home = (Home)ParentForm;
            BillCreateControl billCreateControl = new BillCreateControl();
            billCreateControl.billInsertionEvent += (s, ev) => changePage(1); 
            home.LoadForm(billCreateControl);
        }

        private void LoadPageAndPageable()
        {
            if (page == null || pageable == null) return;
            //update page number
            tbCurrentpage.Text = pageable.PageNumber.ToString();
            lbTotalpage.Text = "/" + page.TotalPages;
            //update table
            tableBill.Rows.Clear();
            foreach (Bill bill in page.Content)
            {

                tableBill.Rows.Add(bill.Id, billBUS.PopulateResident(bill).Resident_id, billBUS.PopulateResident(bill).Resident.Full_name, billBUS.PopulateResident(bill).Resident.Apartment_id, bill.Issue_quantity, bill.Total_fee.ToString());
            }
            //update button
            btnPrevious.Enabled = pageable.PageNumber > 1;
            btnNext.Enabled = pageable.PageNumber < page.TotalPages;
        }

        private void numberofitemsCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cbNumberofitem.SelectedItem.ToString();
            int pageSize = int.Parse(selectedValue.Split(' ')[0]);
            pageable.PageSize = pageSize;
            changePage(1);
        }

        public void changePage(int pageNumber)
        {
            pageable.PageNumber = pageNumber;
            pageable.SortBy = nameof(Bill.Created_at);
            pageable.SortOrder = SortOrderPageable.Descending;
            page = billBUS.GetAllPagination(pageable, filters);
            LoadPageAndPageable();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            changePage(pageable.PageNumber - 1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            changePage(pageable.PageNumber + 1);
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbFilter.SelectedIndex;
            switch (index)
            {
                case 0:
                    tableSearch.ColumnStyles[2].Width = 90;
                    break;
                case 1:
                    tableSearch.ColumnStyles[2].Width = 130;
                    break;
            }
            query();
        }

        private void tbCurrentpage_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers and control characters in textbox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;

            // Allow enter key to change page
            if (e.KeyChar == (char)Keys.Enter)
            {
                string input = tbCurrentpage.Text;
                int pageNumber;

                if (string.IsNullOrEmpty(input))
                    pageNumber = 1;
                else
                {
                    pageNumber = int.Parse(input);
                    pageNumber = pageNumber < 1 ? 1 : pageNumber;
                    pageNumber = pageNumber > page.TotalPages ? page.TotalPages : pageNumber;
                }
                changePage(pageNumber);
            }
        }

        private void query()
        {
            int inputCboxIndex = cbFilter.SelectedIndex;
            string inputSearch = tbSearch.Text.Trim();
            filters.Clear();
            if (!string.IsNullOrEmpty(inputSearch))
            {
                switch (inputCboxIndex)
                {
                    case 0:
                        filters.Add(new FilterCondition("id", CompOp.Like, inputSearch));
                        break;
                    case 1:
                        filters.Add(new FilterCondition("resident_id", CompOp.Like, inputSearch));
                        break;
                }
            }
            changePage(1);
        }

        private async void tbSearch_TextChanged(object sender, EventArgs e)
        {
            await _debouncer.DebounceAsync(() =>
            {
                query();
                return Task.CompletedTask;
            }, 500);
        }

        private void pnlPagination_Resize(object sender, EventArgs e)
        {
            pnlPagination.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlPagination.Width, pnlPagination.Height, 10, 10));
        }
    }
}