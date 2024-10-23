using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.Helper;

namespace ZiTyLot.GUI.Screens
{
    public partial class CardControl : UserControl
    {
        private readonly CardBUS cardBUS = new CardBUS();
        private readonly Pageable pageable = new Pageable();
        private readonly List<FilterCondition> filterConditions = new List<FilterCondition>();
        Page<Card> page;
        public CardControl()
        {
            InitializeComponent();
            cbNumberofitem.Items.AddRange(pageable.PageNumbersInit.Select(pageNumber => pageNumber + " items").ToArray());
            cbNumberofitem.SelectedIndex = 0;
            page = cardBUS.GetAllPagination(pageable, filterConditions);
            tbCurrentpage.Text = "1";
            lbTotalpage.Text = "/" + page.TotalPages;
            LoadPageToTable();
        }
        private void LoadPageToTable()
        {
            tableCard.Rows.Clear();
            foreach (Card card in page.Content)
            {
                tableCard.Rows.Add(card.Id, card.Rfid, card.Type, card.Status);
            }
        }
        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        
        private void CardScreen_Load(object sender, EventArgs e)
        {
            pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
            pnlBottom.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 10, 10));
            btnAdd.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, btnAdd.Width, btnAdd.Height, 10, 10));
            this.tableCard.Paint += new System.Windows.Forms.PaintEventHandler(this.table_Paint);
            this.tableCard.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.table_CellPainting);
            this.tableCard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
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
                 e.ColumnIndex == tableCard.Columns["colEdit"].Index ||
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
                else if (e.ColumnIndex == tableCard.Columns["colEdit"].Index)
                {
                    icon = Properties.Resources.Icon_18x18px_Edit;
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
                else if (e.ColumnIndex == tableCard.Columns["colEdit"].Index)
                {
                    MessageBox.Show("Edit button clicked for row " + e.RowIndex);
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

        private void uiButton1_Click(object sender, EventArgs e)
        {
            menuMore.Show(btnMore, new Point(-100, btnMore.Height + 10));
        }

        private void downloadTemplateMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cbNumberofitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedValue = cbNumberofitem.SelectedItem.ToString();
            int pageSize = int.Parse(selectedValue.Split(' ')[0]);
            pageable.PageSize = pageSize;
            pageable.PageNumber = 1;
            page = cardBUS.GetAllPagination(pageable, filterConditions);
            tbCurrentpage.Text = "1";
            lbTotalpage.Text = "/" + page.TotalPages;
            LoadPageToTable();
        }
        private void changePage(int pageNumber)
        {
            if (pageNumber < 1 || pageNumber > page.TotalPages)
            {
                return;
            }
            pageable.PageNumber = pageNumber;
            page = cardBUS.GetAllPagination(pageable, filterConditions);
            tbCurrentpage.Text = pageNumber.ToString();
            LoadPageToTable();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int currentPage = int.Parse(tbCurrentpage.Text);
            changePage(currentPage - 1);
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            int currentPage = int.Parse(tbCurrentpage.Text);
            changePage((currentPage + 1));
        }
    }
}