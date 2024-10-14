using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.Helper;

namespace ZiTyLot.GUI.Screens
{
    public partial class AccountControl : UserControl
    {
        AccountBUS accountBUS = new AccountBUS();
        Pageable pageable = new Pageable();
        List<FilterCondition> filters = new List<FilterCondition>();
        Page<Account> page;

        public AccountControl()
        {
            InitializeComponent();
            numberofitemsCb.SelectedIndex = 0;
            LoadPageToTable("1");
        }

        private void AccountScreen_Load(object sender, EventArgs e)
        {
            TopPnl.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, TopPnl.Width, TopPnl.Height, 10, 10));
            BottomPnl.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, BottomPnl.Width, BottomPnl.Height, 10, 10));

            addBtn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, addBtn.Width, addBtn.Height, 10, 10));
            
            this.table.Paint += new System.Windows.Forms.PaintEventHandler(this.table_Paint);
            this.table.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.table_CellPainting);
            this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
        }
        // Paint the header cell
        private void table_Paint(object sender, PaintEventArgs e)
        {
            Rectangle firstHeaderCellRect = this.table.GetCellDisplayRectangle(this.table.Columns["viewCol"].Index, -1, true);
            Rectangle lastHeaderCellRect = this.table.GetCellDisplayRectangle(this.table.Columns["deleteCol"].Index, -1, true);
            Rectangle mergedHeaderRect = new Rectangle(firstHeaderCellRect.X, firstHeaderCellRect.Y,lastHeaderCellRect.X + lastHeaderCellRect.Width - firstHeaderCellRect.X, firstHeaderCellRect.Height);
            e.Graphics.FillRectangle(new SolidBrush(Color.White), mergedHeaderRect);
            TextRenderer.DrawText(e.Graphics, "Action", this.table.ColumnHeadersDefaultCellStyle.Font,
                mergedHeaderRect, this.table.ColumnHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
        // Paint the cell
        private void table_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if ((e.ColumnIndex == table.Columns["viewCol"].Index ||
                 e.ColumnIndex == table.Columns["editCol"].Index ||
                 e.ColumnIndex == table.Columns["deleteCol"].Index) && e.RowIndex >= 0)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.White), e.CellBounds);
                System.Drawing.Image icon = null;
                if (e.ColumnIndex == table.Columns["viewCol"].Index)
                {
                    icon = Properties.Resources.Icon_18x18px_View;  
                }
                else if (e.ColumnIndex == table.Columns["editCol"].Index)
                {
                    icon = Properties.Resources.Icon_18x18px_Edit;  
                }
                else if (e.ColumnIndex == table.Columns["deleteCol"].Index)
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
                if (e.ColumnIndex == table.Columns["viewCol"].Index)
                {
                    MessageBox.Show("View button clicked for row " + e.RowIndex);
                }
                else if (e.ColumnIndex == table.Columns["editCol"].Index)
                {
                    MessageBox.Show("Edit button clicked for row " + e.RowIndex);
                }
                else if (e.ColumnIndex == table.Columns["deleteCol"].Index)
                {
                    MessageBox.Show("Delete button clicked for row " + e.RowIndex);
                }
            }
        }

        private void TopPnl_Resize(object sender, EventArgs e)
        {
            TopPnl.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, TopPnl.Width, TopPnl.Height, 10, 10));
        }

        private void BottomPnl_Resize(object sender, EventArgs e)
        {
            BottomPnl.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, BottomPnl.Width, BottomPnl.Height, 10, 10));
        }

        private void LoadPageToTable(string currentPage)
        {
            page = accountBUS.GetAllPagination(pageable, filters);
            currentpageTb.Text = currentPage;
            label1.Text = "/" + page.TotalPages;
            table.Rows.Clear();
            foreach (Account account in page.Content)
            {
                table.Rows.Add(account.Id, account.Full_name, account.Username, accountBUS.PopulateRole(account).Role.Name);
            }
        }

        private void numberofitemsCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = numberofitemsCb.SelectedText;
            int pageSize = int.Parse(selectedValue.Split(' ')[0]);
            pageable.PageNumber = 1;
            pageable.PageSize = pageSize;
            LoadPageToTable("1");
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            int currentPage = int.Parse(currentpageTb.Text);
            ChangePage(currentPage + 1);
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            int currentPage = int.Parse(currentpageTb.Text);
            ChangePage(currentPage - 1);
        }

        private void ChangePage(int pageNumber)
        {
            if (pageNumber >= 1 && pageNumber <= page.TotalPages)
            {
                pageable.PageNumber = pageNumber;
                LoadPageToTable(pageNumber.ToString());
            }
        }
    }
}