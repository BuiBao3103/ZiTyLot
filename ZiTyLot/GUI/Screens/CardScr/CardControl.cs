using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.Constants.Enum;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Screens.CardScr;
using ZiTyLot.Helper;

namespace ZiTyLot.GUI.Screens
{
    public partial class CardControl : UserControl
    {
        private readonly Debouncer _debouncer = new Debouncer();
        private readonly CardBUS cardBUS = new CardBUS();
        private readonly Pageable pageable = new Pageable();
        private readonly List<FilterCondition> filters = new List<FilterCondition>();
        private Page<Card> page;

        public CardControl()
        {
            InitializeComponent();
            cbNumberofitem.Items.AddRange(pageable.PageNumbersInit.Select(pageNumber => pageNumber + " items").ToArray());
            cbNumberofitem.SelectedIndex = 0;

        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void CardScreen_Load(object sender, EventArgs e)
        {
            pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
            pnlBottom.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 10, 10));
            this.tableCard.Paint += new System.Windows.Forms.PaintEventHandler(this.table_Paint);
            this.tableCard.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.table_CellPainting);
            this.tableCard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
            pnlTop.Height = 54;

        }

        // Paint the header cell
        private void table_Paint(object sender, PaintEventArgs e)
        {
            Rectangle firstHeaderCellRect = this.tableCard.GetCellDisplayRectangle(this.tableCard.Columns["colView"].Index, -1, true);
            Rectangle lastHeaderCellRect = this.tableCard.GetCellDisplayRectangle(this.tableCard.Columns["colDelete"].Index, -1, true);
            Rectangle mergedHeaderRect = new Rectangle(firstHeaderCellRect.X, firstHeaderCellRect.Y, lastHeaderCellRect.X + lastHeaderCellRect.Width - firstHeaderCellRect.X, firstHeaderCellRect.Height);
            e.Graphics.FillRectangle(new SolidBrush(Color.White), mergedHeaderRect);
            TextRenderer.DrawText(e.Graphics, "Action", this.tableCard.ColumnHeadersDefaultCellStyle.Font,
                mergedHeaderRect, this.tableCard.ColumnHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        // Paint the cell
        private void table_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if ((e.ColumnIndex == tableCard.Columns["colView"].Index ||
                 e.ColumnIndex == tableCard.Columns["colDelete"].Index) && e.RowIndex >= 0)
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
                if (e.ColumnIndex == tableCard.Columns["colView"].Index)
                {
                    icon = Properties.Resources.Icon_18x18px_View;
                }
                else if (e.ColumnIndex == tableCard.Columns["colDelete"].Index)
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
                if (e.ColumnIndex == tableCard.Columns["colView"].Index)
                {
                    MessageBox.Show("View button clicked for row " + e.RowIndex);
                }
                else if (e.ColumnIndex == tableCard.Columns["colDelete"].Index)
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

        private void excelMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void downloadTemplateMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LoadPageAndPageable()
        {
            if (page == null || pageable == null) return;
            //update page number
            tbCurrentpage.Text = pageable.PageNumber.ToString();
            lbTotalpage.Text = "/" + page.TotalPages;
            //update table
            tableCard.Rows.Clear();
            foreach (Card card in page.Content)
            {
                tableCard.Rows.Add(card.Id, card.Rfid, card.Type, card.Status);
            }
            //update button
            btnPrevious.Enabled = pageable.PageNumber > 1;
            btnNext.Enabled = pageable.PageNumber < page.TotalPages;
        }

        private void cbNumberofitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedValue = cbNumberofitem.SelectedItem.ToString();
            int pageSize = int.Parse(selectedValue.Split(' ')[0]);
            pageable.PageSize = pageSize;
            changePage(1);
        }

        private void changePage(int pageNumber)
        {
            pageable.PageNumber = pageNumber;
            page = cardBUS.GetAllPagination(pageable, filters);
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
                    tableSearch.ColumnStyles[1] = new ColumnStyle(SizeType.Absolute, 65);
                    break;
                case 1:
                    tableSearch.ColumnStyles[1] = new ColumnStyle(SizeType.Absolute, 85);
                    break;
            }
            query();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (pnlTop.Height == 108)
            {
                pnlTop.Height = 54;
            }
            else
            {
                pnlTop.Height = 108;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CardCreateForm cardCreateForm = new CardCreateForm();
            cardCreateForm.Show();
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
                        filters.Add(new FilterCondition("id", CompOp.Equals, inputSearch));
                        break;
                    case 1:
                        filters.Add(new FilterCondition("rfid", CompOp.Like, inputSearch));
                        break;
                }
            }
            int inputCboxUserType = cbUserType.SelectedIndex;
            if (inputCboxUserType != 0)
            {
                switch (inputCboxUserType)
                {
                    case 1:
                        filters.Add(new FilterCondition("type", CompOp.Equals, CardType.RESIDENT));
                        break;
                    case 2:
                        filters.Add(new FilterCondition("Type", CompOp.Equals, CardType.VISITOR));
                        break;
                }
            }
            int inputCboxStatus = cbStatus.SelectedIndex;
            if (inputCboxStatus != 0)
            {
                switch (inputCboxStatus)
                {
                    case 1:
                        filters.Add(new FilterCondition("status", CompOp.Equals, CardStatus.EMPTY));
                        break;
                    case 2:
                        filters.Add(new FilterCondition("status", CompOp.Equals, CardStatus.ACTIVE));
                        break;
                    case 3:
                        filters.Add(new FilterCondition("status", CompOp.Equals, CardStatus.BLOCKED));
                        break;
                    case 4:
                        filters.Add(new FilterCondition("status", CompOp.Equals, CardStatus.LOST));
                        break;

                }
            }
            Console.WriteLine(filters.Count);
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

        private void btnApply_Click(object sender, EventArgs e)
        {
            query();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbUserType.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
            pageable.PageNumber = 1;
            tbSearch.Text = "";
            filters.Clear();
            changePage(1);
        }
    }
}