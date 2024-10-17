using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.Helper;

namespace ZiTyLot.GUI.Screens
{
    public partial class AreaControl : UserControl
    {
        ParkingLotBUS parkingLotBUS = new ParkingLotBUS();
        Pageable pageable = new Pageable();
        List<FilterCondition> filters = new List<FilterCondition>();
        Page<ParkingLot> page;
        public AreaControl()
        {
            InitializeComponent();
            cbNumberOfItem.SelectedIndex = 0;
            page = parkingLotBUS.GetAllPagination(pageable, filters);
            tbCurrentPage.Text = "1";
            lbTotalPage.Text = "/" + page.TotalPages;
            LoadPageToTable();

        }
        private void LoadPageToTable()
        {
            tableArea.Rows.Clear();
            foreach (ParkingLot parkingLot in page.Content)
            {
                // calculate the remaining number of slots
                tableArea.Rows.Add(parkingLot.Id, parkingLot.Parking_lot_type, parkingLot.Total_slot, parkingLot.Status);
            }
        }
        private void numberofitemsCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cbNumberOfItem.SelectedItem.ToString();
            int pageSize = int.Parse(selectedValue.Split(' ')[0]);
            pageable.PageNumber = 1;
            pageable.PageSize = pageSize;
            page = parkingLotBUS.GetAllPagination(pageable, filters);
            tbCurrentPage.Text = "1";
            lbTotalPage.Text = "/" + page.TotalPages;
            LoadPageToTable();
        }

        private void ChangePage(int pageNumber)
        {
            if (pageNumber < 1 || pageNumber > page.TotalPages)
            {
                return;
            }
            pageable.PageNumber = pageNumber;
            page = parkingLotBUS.GetAllPagination(pageable, filters);
            LoadPageToTable();
            tbCurrentPage.Text = pageNumber.ToString();
        }
        private void nextBtn_Click(object sender, EventArgs e)
        {
            int currentPage = int.Parse(tbCurrentPage.Text);
            if (currentPage < page.TotalPages)
            {
                ChangePage(currentPage + 1);
            }
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            int currentPage = int.Parse(tbCurrentPage.Text);
            if (currentPage > 1)
            {
                ChangePage(currentPage - 1);
            }
        }
        private void AreaScreen_Load(object sender, EventArgs e)
        {
            pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
            pnlBottom.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 10, 10));

            btnAdd.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, btnAdd.Width, btnAdd.Height, 10, 10));
            btnAll.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, btnAll.Width, btnAll.Height, 10, 10));
            btnResident.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, btnResident.Width, btnResident.Height, 10, 10));
            btnVistor.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, btnVistor.Width, btnVistor.Height, 10, 10));

            btnAll.Checked = true;
            this.btnAll.CheckedChanged += new System.EventHandler(this.allFilter_CheckedChanged);
            this.btnResident.CheckedChanged += new System.EventHandler(this.residentFilter_CheckedChanged);
            this.btnVistor.CheckedChanged += new System.EventHandler(this.visitorFilter_CheckedChanged);
            this.tableArea.Paint += new System.Windows.Forms.PaintEventHandler(this.table_Paint);
            this.tableArea.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.table_CellPainting);
            this.tableArea.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
        }
        // Paint the header cell
        private void table_Paint(object sender, PaintEventArgs e)
        {
            Rectangle firstHeaderCellRect = this.tableArea.GetCellDisplayRectangle(this.tableArea.Columns["colView"].Index, -1, true);
            Rectangle lastHeaderCellRect = this.tableArea.GetCellDisplayRectangle(this.tableArea.Columns["colDelete"].Index, -1, true);
            Rectangle mergedHeaderRect = new Rectangle(firstHeaderCellRect.X, firstHeaderCellRect.Y, lastHeaderCellRect.X + lastHeaderCellRect.Width - firstHeaderCellRect.X, firstHeaderCellRect.Height);
            e.Graphics.FillRectangle(new SolidBrush(Color.White), mergedHeaderRect);
            TextRenderer.DrawText(e.Graphics, "Action", this.tableArea.ColumnHeadersDefaultCellStyle.Font,
                mergedHeaderRect, this.tableArea.ColumnHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
        private void table_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if ((e.ColumnIndex == tableArea.Columns["colView"].Index ||
                 e.ColumnIndex == tableArea.Columns["colEdit"].Index ||
                 e.ColumnIndex == tableArea.Columns["colDelete"].Index) && e.RowIndex >= 0)
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
                if (e.ColumnIndex == tableArea.Columns["colView"].Index)
                {
                    icon = Properties.Resources.Icon_18x18px_View;
                }
                else if (e.ColumnIndex == tableArea.Columns["colEdit"].Index)
                {
                    icon = Properties.Resources.Icon_18x18px_Edit;
                }
                else if (e.ColumnIndex == tableArea.Columns["colDelete"].Index)
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
                if (e.ColumnIndex == tableArea.Columns["colView"].Index)
                {
                    MessageBox.Show("View button clicked for row " + e.RowIndex);
                }
                else if (e.ColumnIndex == tableArea.Columns["colEdit"].Index)
                {
                    MessageBox.Show("Edit button clicked for row " + e.RowIndex);
                }
                else if (e.ColumnIndex == tableArea.Columns["colDelete"].Index)
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

        // All Filter CheckedChanged event handler
        private void allFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (btnAll.Checked)
            {
                btnAll.BackColor = Color.FromArgb(240, 118, 54);
                btnAll.ForeColor = Color.White;
                btnAll.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_All_Active;
            }
            else
            {
                btnAll.BackColor = Color.White;
                btnAll.ForeColor = Color.FromArgb(160, 160, 160);
                btnAll.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_All;
            }
        }
        // CheckIn Filter CheckedChanged event handler
        private void residentFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (btnResident.Checked)
            {
                btnResident.BackColor = Color.FromArgb(240, 118, 54);
                btnResident.ForeColor = Color.White;
                btnResident.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Resident_Active;
            }
            else
            {
                btnResident.BackColor = Color.White;
                btnResident.ForeColor = Color.FromArgb(160, 160, 160);
                btnResident.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Resident;
            }
        }

        // CheckOut Filter CheckedChanged event handler
        private void visitorFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (btnVistor.Checked)
            {
                btnVistor.BackColor = Color.FromArgb(240, 118, 54);
                btnVistor.ForeColor = Color.White;
                btnVistor.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Vistor_Active;
            }
            else
            {
                btnVistor.BackColor = Color.White;
                btnVistor.ForeColor = Color.FromArgb(160, 160, 160);
                btnVistor.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_Visitor;
            }
        }
    }
}