using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.Constants.Enum;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Screens.AreaScr;
using ZiTyLot.Helper;

namespace ZiTyLot.GUI.Screens
{
    public partial class AreaControl : UserControl
    {
        private readonly Debouncer _debouncer = new Debouncer();
        private readonly ParkingLotBUS parkingLotBUS = new ParkingLotBUS();
        private readonly Pageable pageable = new Pageable();
        private readonly List<FilterCondition> filters = new List<FilterCondition>();
        private Page<ParkingLot> page;
        public AreaControl()
        {
            InitializeComponent();
            cbNumberofitem.Items.AddRange(pageable.PageNumbersInit.Select(pageNumber => pageNumber + " items").ToArray());
            cbNumberofitem.SelectedIndex = 0;
        }
        private void AreaScreen_Load(object sender, EventArgs e)
        {
            pnlPagination.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlPagination.Width, pnlPagination.Height, 10, 10));
            pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
            pnlBottom.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 10, 10));
            pnlTop.Height = 54;
            
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
            if ((e.ColumnIndex == tableArea.Columns["colView"].Index || e.ColumnIndex == tableArea.Columns["colDelete"].Index) && e.RowIndex >= 0)
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
                    AreaDetailForm areaDetailForm = new AreaDetailForm();
                    areaDetailForm.ShowDialog();
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

        private void tableArea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            AreaCreateForm areaCreateForm = new AreaCreateForm();
            areaCreateForm.Show();
        }

        private void LoadPageAndPageable()
        {
            if (page == null || pageable == null) return;

            tbCurrentpage.Text = pageable.PageNumber.ToString();
            lbTotalpage.Text = "/" + page.TotalPages;

            tableArea.Rows.Clear();
            foreach (ParkingLot parkingLot in page.Content)
            {
                // calculate the remaining number of slots
                tableArea.Rows.Add(parkingLot.Id, parkingLot.Parking_lot_type, parkingLot.User_type, parkingLot.Total_slot, parkingLot.Status);
            }

            btnPrevious.Enabled = pageable.PageNumber > 1;
            btnNext.Enabled = pageable.PageNumber < page.TotalPages;
        }

        private void ChangePage(int pageNumber)
        {
            pageable.PageNumber = pageNumber;
            page = parkingLotBUS.GetAllPagination(pageable, filters);
            LoadPageAndPageable();
        }

        private void Query()
        {
            string inputSearch = tbSearch.Text.Trim();
            filters.Clear();
            if (!string.IsNullOrEmpty(inputSearch)){
                filters.Add(new FilterCondition("Id", CompOp.Equals, inputSearch));
            }
            
            int inputCboxIndexVehicleType = cbVehicalType.SelectedIndex;
            if (inputCboxIndexVehicleType != 0)
            {
                switch (inputCboxIndexVehicleType)
                {
                    case 1:
                        filters.Add(new FilterCondition("parking_lot_type", CompOp.Equals, ParkingLotType.TWO_WHEELER));
                        break;
                    case 2:
                        filters.Add(new FilterCondition("parking_lot_type", CompOp.Equals, ParkingLotType.FOUR_WHEELER));
                        break;
                }
            }

            int inputCboxIndexUserType = cbUserType.SelectedIndex;
            if (inputCboxIndexUserType != 0)
            {
                switch (inputCboxIndexUserType)
                {
                    case 1:
                        filters.Add(new FilterCondition("user_type", CompOp.Equals, ParkingLotUserType.RESIDENT));
                        break;
                    case 2:
                        filters.Add(new FilterCondition("user_type", CompOp.Equals, ParkingLotUserType.VISITOR));
                        break;
                }
            }

            int inputCboxIndexStatus = cbStatus.SelectedIndex;
            if (inputCboxIndexStatus != 0)
            {
                switch (inputCboxIndexStatus)
                {
                    case 1:
                        filters.Add(new FilterCondition("status", CompOp.Equals, ParkingLotStatus.FULL));
                        break;
                    case 2:
                        filters.Add(new FilterCondition("status", CompOp.Equals, ParkingLotStatus.AVAILABLE));
                        break;
                    case 3:
                        filters.Add(new FilterCondition("status", CompOp.Equals, ParkingLotStatus.CLOSED));
                        break;
                    case 4:
                        filters.Add(new FilterCondition("status", CompOp.Equals, ParkingLotStatus.UNDER_MAINTENANCE));
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

        private void btnApply_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbVehicalType.SelectedIndex = 0;
            cbUserType.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
            tbSearch.Text = "";
            filters.Clear();
            ChangePage(1);
        }

        private void tbCurrentPage_KeyPress(object sender, KeyPressEventArgs e)
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

        private async void tbSearch_TextChanged(object sender, EventArgs e)
        {
            await _debouncer.DebounceAsync(() =>
            {
                Query();
                return Task.CompletedTask;
            }, 500);
        }

        private void pnlPagination_Resize(object sender, EventArgs e)
        {
            pnlPagination.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlPagination.Width, pnlPagination.Height, 10, 10));

        }
    }
}