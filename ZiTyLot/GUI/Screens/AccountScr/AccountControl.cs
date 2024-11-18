using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.Helper;
using ZiTyLot.GUI.Screens.AccountScr;
using System.Threading.Tasks;
using System.Linq;
using ZiTyLot.Constants;
using ZiTyLot.GUI.Screens.PriceScr;
using ZiTyLot.GUI.Utils;

namespace ZiTyLot.GUI.Screens
{
    public partial class AccountControl : UserControl
    {
        private readonly Debouncer _debouncer = new Debouncer();
        private readonly AccountBUS accountBUS = new AccountBUS();
        private readonly Pageable pageable = new Pageable();
        private readonly List<FilterCondition> filters = new List<FilterCondition>();
        private Page<Account> page;

        private AccountCreateForm _accountCreateForm;
        private AccountDetailForm _accountDetailForm;
        public AccountControl()
        {
            InitializeComponent();
            cbNumberofitem.SelectedIndexChanged -= numberofitemsCb_SelectedIndexChanged;
            cbNumberofitem.Items.AddRange(pageable.PageNumbersInit.Select(pageNumber => pageNumber + " items").ToArray());
            cbNumberofitem.SelectedIndex = 0;
            cbNumberofitem.SelectedIndexChanged += numberofitemsCb_SelectedIndexChanged;
        }

        private void AccountScreen_Load(object sender, EventArgs e)
        {
            pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
            pnlBottom.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 10, 10));
            pnlPagination.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlPagination.Width, pnlPagination.Height, 10, 10));
            this.tableAccount.Paint += new System.Windows.Forms.PaintEventHandler(this.table_Paint);
            this.tableAccount.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.table_CellPainting);
            this.tableAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
            pnlBottom.AutoScrollMinSize = new Size(0, pnlBottom.Height - 40);
        }
        // Paint the header cell
        private void table_Paint(object sender, PaintEventArgs e)
        {
            Rectangle firstHeaderCellRect = this.tableAccount.GetCellDisplayRectangle(this.tableAccount.Columns["colView"].Index, -1, true);
            Rectangle lastHeaderCellRect = this.tableAccount.GetCellDisplayRectangle(this.tableAccount.Columns["colDelete"].Index, -1, true);
            Rectangle mergedHeaderRect = new Rectangle(firstHeaderCellRect.X, firstHeaderCellRect.Y, lastHeaderCellRect.X + lastHeaderCellRect.Width - firstHeaderCellRect.X, firstHeaderCellRect.Height);
            e.Graphics.FillRectangle(new SolidBrush(Color.White), mergedHeaderRect);
            TextRenderer.DrawText(e.Graphics, "Action", this.tableAccount.ColumnHeadersDefaultCellStyle.Font,
                mergedHeaderRect, this.tableAccount.ColumnHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
        // Paint the cell
        private void table_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if ((e.ColumnIndex == tableAccount.Columns["colView"].Index || e.ColumnIndex == tableAccount.Columns["colDelete"].Index) && e.RowIndex >= 0)
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
                if (e.ColumnIndex == tableAccount.Columns["colView"].Index)
                {
                    icon = Properties.Resources.Icon_18x18px_View;
                }
                else if (e.ColumnIndex == tableAccount.Columns["colDelete"].Index)
                {
                    icon = Properties.Resources.Icon_18x18px_Remove;
                }
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
                int accountId = (int)tableAccount.Rows[e.RowIndex].Cells[0].Value;
                if (e.ColumnIndex == tableAccount.Columns["colView"].Index)
                {
                    ShowAccountDetailForm(accountId);
                }
                else if (e.ColumnIndex == tableAccount.Columns["colDelete"].Index)
                {
                    DeleteAccount(accountId);
                }
            }
        }

        private void DeleteAccount(int accountId)
        {
            DialogResult result = MessageHelper.ShowConfirm("Are you sure you want to delete this account?");
            if (result == DialogResult.Yes)
            {
                try
                {
                    accountBUS.Delete(accountId);
                    filters.Clear();
                    ChangePage(1);
                }
                catch (Exception ex)
                {
                    MessageHelper.ShowWarning("An unexpected error occurred. Please try again later.");
                }
            }
        }

        private void ShowAccountDetailForm(int accountId)
        {
            if (_accountDetailForm != null && accountId != _accountDetailForm.account.Id)
            {
                _accountDetailForm.Close();
            }
            if (_accountDetailForm == null || _accountDetailForm.IsDisposed)
            {

                _accountDetailForm = new AccountDetailForm(accountId);
                _accountDetailForm.AccountUpdateEvent += (s, args) =>
                {
                    filters.Clear();
                    ChangePage(1);
                };
                _accountDetailForm.Show();
            }
            else
            {
                if (_accountDetailForm.WindowState == FormWindowState.Minimized)
                    _accountDetailForm.WindowState = FormWindowState.Normal;
                _accountDetailForm.BringToFront();
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

        private void btnAdd_Click(object sender, EventArgs e) => ShowAccountCreateForm();

        private void ShowAccountCreateForm()
        {
            if (_accountCreateForm == null || _accountCreateForm.IsDisposed)
            {
                _accountCreateForm = new AccountCreateForm();
                _accountCreateForm.Show();
                _accountCreateForm.AccountCreated += (s, args) =>
                {
                    filters.Clear();
                    ChangePage(1);
                };
            }
            else
            {
                if (_accountCreateForm.WindowState == FormWindowState.Minimized)
                    _accountCreateForm.WindowState = FormWindowState.Normal;
                _accountCreateForm.BringToFront();
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbFilter.SelectedIndex;
            switch (index)
            {
                case 0:
                    tableSearch.ColumnStyles[2] = new ColumnStyle(SizeType.Absolute, 65);
                    break;
                case 1:
                    tableSearch.ColumnStyles[2] = new ColumnStyle(SizeType.Absolute, 120);
                    break;
                case 2:
                    tableSearch.ColumnStyles[2] = new ColumnStyle(SizeType.Absolute, 120);
                    break;
                case 3:
                    tableSearch.ColumnStyles[2] = new ColumnStyle(SizeType.Absolute, 90);
                    break;
            }
            query();
        }

        private void LoadPageAndPageable()
        {

            if (page == null || pageable == null) return;
            //update page number
            tbCurrentpage.Text = pageable.PageNumber.ToString();
            lbTotalpage.Text = "/" + page.TotalPages;
            //update table
            tableAccount.Rows.Clear();
            foreach (Account account in page.Content)
            {
                tableAccount.Rows.Add(account.Id, account.Full_name, account.Username, account.Email, account.Role);
            }
            //update button
            btnPrevious.Enabled = pageable.PageNumber > 1;
            btnNext.Enabled = pageable.PageNumber < page.TotalPages;
        }
        public void ChangePage(int pageNumber)
        {
            pageable.PageNumber = pageNumber;
            pageable.SortBy = nameof(Account.Created_at);
            pageable.SortOrder = SortOrderPageable.Descending;
            page = accountBUS.GetAllPagination(pageable, filters);
            LoadPageAndPageable();
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
                        filters.Add(new FilterCondition("Id", CompOp.Like, inputSearch));
                        break;
                    case 1:
                        filters.Add(new FilterCondition("Full_name", CompOp.Like, inputSearch));

                        break;
                    case 2:
                        filters.Add(new FilterCondition("Username", CompOp.Like, inputSearch));
                        break;
                    case 3:
                        filters.Add(new FilterCondition("Email", CompOp.Like, inputSearch));
                        break;
                }
            }
            ChangePage(1);
        }

        private void numberofitemsCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cbNumberofitem.SelectedItem.ToString();
            int pageSize = int.Parse(selectedValue.Split(' ')[0]);
            pageable.PageSize = pageSize;
            ChangePage(1);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            ChangePage(pageable.PageNumber - 1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ChangePage(pageable.PageNumber + 1);
        }

        private async void tbSearch_TextChanged(object sender, EventArgs e)
        {
            await _debouncer.DebounceAsync(() =>
            {
                query();
                return Task.CompletedTask;
            }, 500);
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
                ChangePage(pageNumber);
            }
        }

        private void pnlPagination_Resize(object sender, EventArgs e)
        {
            pnlPagination.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlPagination.Width, pnlPagination.Height, 10, 10));
        }
    }
}