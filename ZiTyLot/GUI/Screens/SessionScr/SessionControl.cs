﻿using MySqlX.XDevAPI.Relational;
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
    public partial class SessionControl : UserControl
    {
        SessionBUS sessionBUS = new SessionBUS();
        Pageable pageable = new Pageable();
        List<FilterCondition> filters = new List<FilterCondition>();
        Page<Session> page;

        public SessionControl()
        {
            InitializeComponent();
            cbNumberofitem.Items.AddRange(pageable.PageNumbersInit.Select(pageNumber => pageNumber + " items").ToArray());
            cbNumberofitem.SelectedIndex = 0;
            page = sessionBUS.GetAllPagination(pageable, filters);
            tbCurrentpage.Text = "1";
            lbTotalpage.Text = "/" + page.TotalPages;
            LoadPageToTable();
            customDateTimePicker.DateTimeConfirmed += CustomDateTimePicker_DateTimeConfirmed_In;
            customDateTimePicker1.DateTimeConfirmed += CustomDateTimePicker_DateTimeConfirmed_Out;

        }
        private void CustomDateTimePicker_DateTimeConfirmed_In(object sender, string combinedDateTime)
        {
            // Set the combined string to the tbTimeIn TextBox
            tbTimeIn.Text = combinedDateTime;
        }
        private void CustomDateTimePicker_DateTimeConfirmed_Out(object sender, string combinedDateTime)
        {
            // Set the combined string to the tbTimeIn TextBox
            tbTimeOut.Text = combinedDateTime;
        }
        private void LoadPageToTable()
        {
            tableSession.Rows.Clear();
            foreach (Session session in page.Content)
            {
                string total_time = "";
                if (session.Checkout_time != null)
                {
                    TimeSpan time = session.Checkout_time - session.Checkin_time;
                    total_time = time.Hours + "h " + time.Minutes + "m";
                }
                tableSession.Rows.Add(session.Id, session.Type,
                    session.License_plate, session.Checkin_time, session.Checkout_time,
                    total_time, session.Fee);
            }
        }
        private void numberofitemsCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cbNumberofitem.SelectedItem.ToString();
            int pageSize = int.Parse(selectedValue.Split(' ')[0]);
            pageable.PageNumber = 1;
            pageable.PageSize = pageSize;
            page = sessionBUS.GetAllPagination(pageable, filters);
            tbCurrentpage.Text = "1";
            lbTotalpage.Text = "/" + page.TotalPages;
            LoadPageToTable();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            int currentPage = int.Parse(tbCurrentpage.Text);
            if (currentPage < page.TotalPages)
            {
                ChangePage(currentPage + 1);
            }
        }

        private void ChangePage(int pageNumber)
        {
            if (pageNumber < 1 || pageNumber > page.TotalPages)
            {
                return;
            }
            pageable.PageNumber = pageNumber;
            page = sessionBUS.GetAllPagination(pageable, filters);
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
        private void SessionScreen_Load(object sender, EventArgs e)
        {
            pnlTop.Height = 54;
            pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
            pnlBottom.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 10, 10));
            this.tableSession.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.table_CellPainting);
            this.tableSession.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
            customDateTimePicker.Visible = false;
            customDateTimePicker1.Visible = false;


        }
        // Paint the cell
        private void table_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == tableSession.Columns["colView"].Index && e.RowIndex >= 0)
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
                if (e.ColumnIndex == tableSession.Columns["colView"].Index)
                {
                    MessageBox.Show("View button clicked for row " + e.RowIndex);
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
            if (customDateTimePicker.Visible || customDateTimePicker1.Visible)
            {
                customDateTimePicker.Visible = false;
                customDateTimePicker1.Visible = false;
            }
        }

        private void btnTimeIn_Click(object sender, EventArgs e)
        {
            if(customDateTimePicker.Visible == false)
            {
                if (customDateTimePicker1.Visible == false)
                {
                    customDateTimePicker.Visible = true;
                }
                else
                {
                    customDateTimePicker1.Visible = false;
                    customDateTimePicker.Visible = true;
                }
            }
            else
            {
                customDateTimePicker.Visible = false;
            }
            
            customDateTimePicker.Location = new Point(uiPanel9.Location.X, btnTimeIn.Location.Y + 110);
        }

        private void btnTimeOut_Click(object sender, EventArgs e)
        {
            if (customDateTimePicker1.Visible == false)
            {
                if (customDateTimePicker.Visible == false)
                {
                    customDateTimePicker1.Visible = true;
                }
                else
                {
                    customDateTimePicker.Visible = false;
                    customDateTimePicker1.Visible = true;
                }
            }
            else
            {
                customDateTimePicker1.Visible = false;
            }

            customDateTimePicker1.Location = new Point(uiPanel8.Location.X, btnTimeIn.Location.Y + 110);
        }

        private void SessionControl_Resize(object sender, EventArgs e)
        {
            if(customDateTimePicker.Visible)
            {
                customDateTimePicker.Location = new Point(uiPanel9.Location.X, btnTimeIn.Location.Y + 110);
            }
            if (customDateTimePicker1.Visible)
            {
                customDateTimePicker1.Location = new Point(uiPanel8.Location.X, btnTimeIn.Location.Y + 110);
            }
        }
    }
}