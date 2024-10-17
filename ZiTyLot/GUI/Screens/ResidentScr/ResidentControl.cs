using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Screens.ResidentScr;
using ZiTyLot.Helper;

namespace ZiTyLot.GUI.Screens
{
    public partial class ResidentControl : UserControl
    {
        private ResidentBUS residentBUS = new ResidentBUS();
        private Pageable pageable = new Pageable();
        private List<FilterCondition> filters = new List<FilterCondition>();
        private Page<Resident> page;

        public ResidentControl()
        {
            InitializeComponent();
            cbNumberofitem.SelectedIndex = 0;
            page = residentBUS.GetAllPagination(pageable, filters);
            tbCurrentpage.Text = "1";
            lbTotalpage.Text = "/" + page.TotalPages;
            LoadPageToTable();
        }

        private void ResidentScreen_Load(object sender, EventArgs e)
        {
            pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
            BottomPnl.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, BottomPnl.Width, BottomPnl.Height, 10, 10));
            btnAdd.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, btnAdd.Width, btnAdd.Height, 10, 10));
            this.tableResident.Paint += new System.Windows.Forms.PaintEventHandler(this.table_Paint);
            this.tableResident.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.table_CellPainting);
            this.tableResident.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
        }

        // Paint the header cell
        private void table_Paint(object sender, PaintEventArgs e)
        {
            Rectangle firstHeaderCellRect = this.tableResident.GetCellDisplayRectangle(this.tableResident.Columns["colView"].Index, -1, true);
            Rectangle lastHeaderCellRect = this.tableResident.GetCellDisplayRectangle(this.tableResident.Columns["colDelete"].Index, -1, true);
            Rectangle mergedHeaderRect = new Rectangle(firstHeaderCellRect.X, firstHeaderCellRect.Y, lastHeaderCellRect.X + lastHeaderCellRect.Width - firstHeaderCellRect.X, firstHeaderCellRect.Height);
            e.Graphics.FillRectangle(new SolidBrush(Color.White), mergedHeaderRect);
            TextRenderer.DrawText(e.Graphics, "Action", this.tableResident.ColumnHeadersDefaultCellStyle.Font,
                mergedHeaderRect, this.tableResident.ColumnHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        // Paint the cell
        private void table_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if ((e.ColumnIndex == tableResident.Columns["colView"].Index ||
                 e.ColumnIndex == tableResident.Columns["colEdit"].Index ||
                 e.ColumnIndex == tableResident.Columns["colDelete"].Index) && e.RowIndex >= 0)
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
                if (e.ColumnIndex == tableResident.Columns["colView"].Index)
                {
                    icon = Properties.Resources.Icon_18x18px_View;
                }
                else if (e.ColumnIndex == tableResident.Columns["colEdit"].Index)
                {
                    icon = Properties.Resources.Icon_18x18px_Edit;
                }
                else if (e.ColumnIndex == tableResident.Columns["colDelete"].Index)
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
                if (e.ColumnIndex == tableResident.Columns["colView"].Index)
                {
                    MessageBox.Show("View button clicked for row " + e.RowIndex);
                }
                else if (e.ColumnIndex == tableResident.Columns["colEdit"].Index)
                {
                    MessageBox.Show("Edit button clicked for row " + e.RowIndex);
                }
                else if (e.ColumnIndex == tableResident.Columns["colDelete"].Index)
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
            BottomPnl.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, BottomPnl.Width, BottomPnl.Height, 10, 10));
        }

        private void LoadPageToTable()
        {
            tableResident.Rows.Clear();
            foreach (Resident resident in page.Content)
            {
                tableResident.Rows.Add(resident.Id, resident.Full_name, resident.Apartment_id, resident.Email);
            }
        }

        private void numberofitemsCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cbNumberofitem.SelectedItem.ToString();
            int pageSize = int.Parse(selectedValue.Split(' ')[0]);
            pageable.PageNumber = 1;
            pageable.PageSize = pageSize;
            page = residentBUS.GetAllPagination(pageable, filters);
            tbCurrentpage.Text = "1";
            lbTotalpage.Text = "/" + page.TotalPages;
            LoadPageToTable();
        }

        private void ChangePage(int pageNumber)
        {
            if (pageNumber < 1 || pageNumber > page.TotalPages)
            {
                return;
            }
            pageable.PageNumber = pageNumber;
            page = residentBUS.GetAllPagination(pageable, filters);
            LoadPageToTable();
            tbCurrentpage.Text = pageNumber.ToString();
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            int currentPage = int.Parse(tbCurrentpage.Text);
            if (currentPage > 1)
            {
                ChangePage(currentPage - 1);
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            int currentPage = int.Parse(tbCurrentpage.Text);
            if (currentPage < page.TotalPages)
            {
                ChangePage(currentPage + 1);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ResidentDetailForm residentDetailForm = new ResidentDetailForm();
            residentDetailForm.Show();
        }
    }
}