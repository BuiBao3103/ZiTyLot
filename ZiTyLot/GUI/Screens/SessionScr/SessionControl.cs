using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.Constants.Enum;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Screens.SessionScr;
using ZiTyLot.Helper;



namespace ZiTyLot.GUI.Screens
{
    public partial class SessionControl : UserControl
    {
        private readonly Debouncer _debouncer = new Debouncer();
        private readonly SessionBUS  sessionBUS = new SessionBUS();
        private readonly Pageable pageable = new Pageable();
        private readonly List<FilterCondition> filters = new List<FilterCondition>();
        private Page<Session> page;

        public SessionControl()
        {
            InitializeComponent();
            cbNumberofitem.Items.AddRange(pageable.PageNumbersInit.Select(pageNumber => pageNumber + " items").ToArray());
            cbNumberofitem.SelectedIndex = 0;
            tbSearch.TextChanged += tbSearch_TextChanged;
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
        private void SessionScreen_Load(object sender, EventArgs e)
        {
            pnlTop.Height = 54;
            pnlPagination.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlPagination.Width, pnlPagination.Height, 10, 10));
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
                    SessionDetailForm sessionDetailForm = new SessionDetailForm();
                    sessionDetailForm.Show();
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
            Query();
        }

        private void LoadPageAndPageable()
        {
            if (page == null || pageable == null) return;

            tbCurrentpage.Text = pageable.PageNumber.ToString();
            lbTotalpage.Text = "/" + page.TotalPages;

            tableSession.Rows.Clear();
            foreach (Session session in page.Content)
            {
                tableSession.Rows.Add(session.Id, session.Type, session.License_plate, session.Checkin_time, session.Checkout_time, "", session.Fee);
            }
            btnPrevious.Enabled = pageable.PageNumber > 1;
            btnNext.Enabled = pageable.PageNumber < page.TotalPages;
        }

        private void ChangePage(int pageNumber)
        {
            pageable.PageNumber = pageNumber;
            page = sessionBUS.GetAllPagination(pageable, filters);
            LoadPageAndPageable();
        }

        private void Query()
        {
            int inputCboxIndex = cbFilter.SelectedIndex;
            string inputSearch = tbSearch.Text.Trim();
            filters.Clear();
            if (!string.IsNullOrEmpty(inputSearch))
            {
                switch (inputCboxIndex) 
                { 
                    case 0:
                        filters.Add(new FilterCondition("Id", CompOp.Equals, inputSearch));
                        break;
                    case 1:
                        filters.Add(new FilterCondition("license_plate", CompOp.Like, inputSearch));
                        break;
                }
            }
            int inputCboxIndexType = cbVehicalType.SelectedIndex;
            if (inputCboxIndexType != 0)
            {
                switch (inputCboxIndexType)
                {
                    case 1:
                        filters.Add(new FilterCondition("type", CompOp.Like, SessionType.RESIDENT));
                        break;
                    case 2:
                        filters.Add(new FilterCondition("type", CompOp.Like, SessionType.VISITOR));
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

        private void nextBtn_Click(object sender, EventArgs e)
        {
            ChangePage(pageable.PageNumber + 1);
        }

        
        private void previousBtn_Click(object sender, EventArgs e)
        {
            ChangePage(pageable.PageNumber - 1);
        }

        private async void tbSearch_TextChanged(object sender, EventArgs e)
        {
            await _debouncer.DebounceAsync(() =>
            {
                Query();
                return Task.CompletedTask;
            }, 500);
        }

        private void tbCurrentpage_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void btnApply_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            cbVehicalType.SelectedIndex = 0;
            tbSearch.Text = string.Empty;
            filters.Clear();
            ChangePage(1);
        }

        private void pnlPagination_Resize(object sender, EventArgs e)
        {
            pnlPagination.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlPagination.Width, pnlPagination.Height, 10, 10));

        }
    }
}