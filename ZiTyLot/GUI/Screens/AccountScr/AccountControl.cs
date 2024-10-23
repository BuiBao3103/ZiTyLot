using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.Helper;
using ZiTyLot.GUI.Screens.AccountScr;
using System.Drawing.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ZiTyLot.GUI.Screens
{
    public partial class AccountControl : UserControl
    {
        //Debouncer _debouncer = new Debouncer();
        AccountBUS accountBUS = new AccountBUS();
        Pageable pageable = new Pageable();
        List<FilterCondition> filters = new List<FilterCondition>();
        Page<Account> page;
        public AccountControl()
        {
            InitializeComponent();
            cbNumberofitem.Items.AddRange(pageable.PageNumbersInit.Select(pageNumber => pageNumber + " items").ToArray());
            cbNumberofitem.SelectedIndex = 0;
            page = accountBUS.GetAllPagination(pageable, filters);
            tbCurrentpage.Text = "1";
            lbTotalpage.Text = "/" + page.TotalPages;
            LoadPageToTable();
        }
       
       

        private void AccountScreen_Load(object sender, EventArgs e)
        {
            pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
            pnlBottom.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 10, 10));
            this.tableAccount.Paint += new System.Windows.Forms.PaintEventHandler(this.table_Paint);
            this.tableAccount.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.table_CellPainting);
            this.tableAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
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
                    icon = Properties.Resources.Icon_18x18px_Delete;
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
                if (e.ColumnIndex == tableAccount.Columns["colView"].Index)
                {
                    MessageBox.Show("View button clicked for row " + e.RowIndex);
                }
                else if (e.ColumnIndex == tableAccount.Columns["colDelete"].Index)
                {
                    MessageBox.Show("Delete button clicked for row " + e.RowIndex);
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
            AccountDetailForm accountDetailForm = new AccountDetailForm();
            accountDetailForm.Show();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            String inputCboxSelected = cbFilter.GetItemText(cbFilter.SelectedItem);
            Console.WriteLine(inputCboxSelected);
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
                    tableSearch.ColumnStyles[1] = new ColumnStyle(SizeType.Absolute, 90);
                    break;
                default:
                    tableSearch.ColumnStyles[1] = new ColumnStyle(SizeType.Absolute, 120);
                    break;
            }

        }

        //private async void tbSearch_TextChanged(object sender, EventArgs e)
        //{
        //    String inputCboxSelected = cbFilter.GetItemText(cbFilter.SelectedItem);
        //    // Use the debouncer with a 0.5-second delay
        //    await _debouncer.DebounceAsync(async () =>
        //    {
        //        if (tbSearch.Text.Trim() == "")
        //        {
        //            filters = new List<FilterCondition>();
        //        }
        //        else
        //        {
        //            if (inputCboxSelected == "Full name")
        //            {
        //                filters = new List<FilterCondition> { new FilterCondition("Full_name", ComparisonOperator.Like, tbSearch.Text) };
        //            }
        //            else if (inputCboxSelected == "Username")
        //            {
        //                filters = new List<FilterCondition> { new FilterCondition("Username", ComparisonOperator.Like, tbSearch.Text) };
        //            }
        //            else if (inputCboxSelected == "ID")
        //            {
        //                filters = new List<FilterCondition> { new FilterCondition("Id", ComparisonOperator.Equals, tbSearch.Text) };
        //            }
        //        }

        //        LoadPageToTable("1");
        //        // This will only trigger if the user stops typing for at least 0.5 second
        //    }, 500); // Debounce delay of 500 ms (0.5 second)
        //}
        private void LoadPageToTable()
        {
            tableAccount.Rows.Clear();
            foreach (Account account in page.Content)
            {
                tableAccount.Rows.Add(account.Id, account.Full_name, account.Username, account.Email);
            }

        }
        private void numberofitemsCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cbNumberofitem.SelectedItem.ToString();
            int pageSize = int.Parse(selectedValue.Split(' ')[0]);
            pageable.PageNumber = 1;
            pageable.PageSize = pageSize;
            page = accountBUS.GetAllPagination(pageable, filters);
            tbCurrentpage.Text = "1";
            lbTotalpage.Text = "/" + page.TotalPages;
            LoadPageToTable();
        }
    
        private void ChangePage(int pageNumber)
        {
            if (pageNumber >= 1 && pageNumber <= page.TotalPages)
            {
                pageable.PageNumber = pageNumber;
                LoadPageToTable();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int currentPage = int.Parse(tbCurrentpage.Text);
            ChangePage(currentPage - 1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int currentPage = int.Parse(tbCurrentpage.Text);
            ChangePage(currentPage + 1);
        }
    }
}