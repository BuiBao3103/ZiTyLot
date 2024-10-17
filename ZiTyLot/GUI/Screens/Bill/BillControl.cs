﻿using System;
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
using ZiTyLot.GUI.Screens.Bill;

namespace ZiTyLot.GUI.Screens
{
    public partial class BillControl : UserControl
    {
        BillBUS billBUS = new BillBUS();
        Pageable pageable = new Pageable();
        List<FilterCondition> filterCondition;
        Page<Bill> page;
        public BillControl()
        {
            InitializeComponent();
            numberofitemsCb.SelectedIndex = 0;
            page = billBUS.GetAllPagination(pageable,filterCondition);
            currentpageTb.Text = "1";
            label1.Text = "/" + page.TotalPages;
            loadPageToTable();
        }

        private void BillScreen_Load(object sender, EventArgs e)
        {
            pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
            pnlBottom.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 10, 10));

            btnAdd.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, btnAdd.Width, btnAdd.Height, 10, 10));

            this.tableBill.Paint += new System.Windows.Forms.PaintEventHandler(this.table_Paint);
            this.tableBill.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.table_CellPainting);
            this.tableBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
        }
        // Paint the header cell
        private void table_Paint(object sender, PaintEventArgs e)
        {
            Rectangle firstHeaderCellRect = this.tableBill.GetCellDisplayRectangle(this.tableBill.Columns["colView"].Index, -1, true);
            Rectangle lastHeaderCellRect = this.tableBill.GetCellDisplayRectangle(this.tableBill.Columns["colDelete"].Index, -1, true);
            Rectangle mergedHeaderRect = new Rectangle(firstHeaderCellRect.X, firstHeaderCellRect.Y, lastHeaderCellRect.X + lastHeaderCellRect.Width - firstHeaderCellRect.X, firstHeaderCellRect.Height);
            e.Graphics.FillRectangle(new SolidBrush(Color.White), mergedHeaderRect);
            TextRenderer.DrawText(e.Graphics, "Action", this.tableBill.ColumnHeadersDefaultCellStyle.Font,
                mergedHeaderRect, this.tableBill.ColumnHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
       private void table_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if ((e.ColumnIndex == tableBill.Columns["colView"].Index ||
                 e.ColumnIndex == tableBill.Columns["colDelete"].Index) && e.RowIndex >= 0)
            {
                if (e.RowIndex % 2 == 0)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.WhiteSmoke), e.CellBounds);
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.White), e.CellBounds);
                }
                Image icon = null;
                if (e.ColumnIndex == tableBill.Columns["colView"].Index)
                {
                    icon = Properties.Resources.Icon_18x18px_View;
                }
                else if (e.ColumnIndex == tableBill.Columns["colDelete"].Index)
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
                if (e.ColumnIndex == tableBill.Columns["colView"].Index)
                {
                    MessageBox.Show("View button clicked for row " + e.RowIndex);
                }
                else if (e.ColumnIndex == tableBill.Columns["colDelete"].Index)
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
            //this.Parent.Controls.Clear();
            //BillDetailControl billDetailControl = new BillDetailControl();
            //this.Parent.Controls.Add(billDetailControl);
            //billDetailControl.BringToFront();
        }

        private void loadPageToTable()
        {
            table.Rows.Clear();

            foreach(Bill bill in page.Content)
            {
           
                table.Rows.Add(bill.Id, billBUS.PopulateResident(bill).Resident.Full_name, billBUS.PopulateResident(bill).Resident.Apartment_id, bill.Issue_quantity, bill.Total_fee.ToString());
            }
        }

        private void numberofitemsCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedValue = numberofitemsCb.SelectedItem.ToString();
            int pageSize = int.Parse(selectedValue.Split(' ')[0]);
            pageable.PageNumber = 1;
            pageable.PageSize = pageSize;
            page = billBUS.GetAllPagination(pageable,filterCondition);
            currentpageTb.Text = "1";
            label1.Text = "/" + page.TotalPages;
            loadPageToTable();
        }

        private void changePage(int pageNumber)
        {
            if (pageNumber < 1 || pageNumber > page.TotalPages)
            {
                return;
            }
            pageable.PageNumber = pageNumber;
            page = billBUS.GetAllPagination(pageable,filterCondition);
            loadPageToTable();
            currentpageTb.Text = pageNumber.ToString();
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            int currentPage = int.Parse(currentpageTb.Text);
            changePage(currentPage-1);
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            int currentPage = int.Parse(currentpageTb.Text);
            changePage(currentPage + 1);
        }
    }
}