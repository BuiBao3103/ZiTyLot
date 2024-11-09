using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.Constants;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Screens.AreaScr;
using ZiTyLot.GUI.Screens.PriceScr;
using ZiTyLot.GUI.Screens.ResidentScr;
using ZiTyLot.Helper;

namespace ZiTyLot.GUI.Screens
{
    public partial class ResidentControl : UserControl
    {
        private readonly Debouncer _debouncer = new Debouncer();
        private readonly ResidentBUS residentBUS = new ResidentBUS();
        private readonly Pageable pageable = new Pageable();
        private readonly List<FilterCondition> filters = new List<FilterCondition>();
        private Page<Resident> page;

        private ResidentCreateForm _residentCreateForm;
        private ResidentDetailForm _residentDetailForm;
        public ResidentControl()
        {
            InitializeComponent();
            cbNumberofitem.Items.AddRange(pageable.PageNumbersInit.Select(pageNumber => pageNumber + " items").ToArray());
            cbNumberofitem.SelectedIndex = 0;
        }

        private void ResidentScreen_Load(object sender, EventArgs e)
        {
            pnlPagination.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlPagination.Width, pnlPagination.Height, 10, 10));
            pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
            pnlBottom.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 10, 10));
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
                else if (e.ColumnIndex == tableResident.Columns["colDelete"].Index)
                {
                    icon = Properties.Resources.Icon_18x18px_Remove;
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
                int residentId = (int)tableResident.Rows[e.RowIndex].Cells[0].Value;
                if (e.ColumnIndex == tableResident.Columns["colView"].Index)
                {
                    ShowResidentDetailForm(residentId);
                }
                else if (e.ColumnIndex == tableResident.Columns["colDelete"].Index)
                {
                    MessageBox.Show("Delete button clicked for row " + e.RowIndex);
                }
            }
        }

        private void ShowResidentDetailForm(int residentId)
        {
            if (_residentDetailForm != null && residentId != _residentDetailForm.resident.Id)
            {
                _residentDetailForm.Close();
            }
            if (_residentDetailForm == null || _residentDetailForm.IsDisposed)
            {

                _residentDetailForm = new ResidentDetailForm(residentId);
                _residentDetailForm.ResidentUpdateEvent += (s, args) =>
                {
                   filters.Clear();
                    ChangePage(1);
                };
                _residentDetailForm.Show();
            }
            else
            {
                if (_residentDetailForm.WindowState == FormWindowState.Minimized)
                    _residentDetailForm.WindowState = FormWindowState.Normal;
                _residentDetailForm.BringToFront();
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
                    tableSearch.ColumnStyles[1] = new ColumnStyle(SizeType.Absolute, 95);
                    break;
                case 2:
                    tableSearch.ColumnStyles[1] = new ColumnStyle(SizeType.Absolute, 95);
                    break;
                case 3:
                    tableSearch.ColumnStyles[1] = new ColumnStyle(SizeType.Absolute, 120);
                    break;
                case 4:
                    tableSearch.ColumnStyles[1] = new ColumnStyle(SizeType.Absolute, 140);
                    break;
            }
            Query();
        }

        private void btnAdd_Click(object sender, EventArgs e) =>  showResidentCreateForm();

        private void showResidentCreateForm()
        {
            if (_residentCreateForm == null || _residentCreateForm.IsDisposed)
            {
                _residentCreateForm = new ResidentCreateForm();
                _residentCreateForm.ResidentInsertionEvent += (s, args) =>
                {
                    filters.Clear();
                    ChangePage(1);
                };
                _residentCreateForm.Show();
            }
            else
            {
                if (_residentCreateForm.WindowState == FormWindowState.Minimized)
                    _residentCreateForm.WindowState = FormWindowState.Normal;
                _residentCreateForm.BringToFront();
            }
        }

        private void LoadPageAndPageable()
        {
            if (page == null || pageable == null) return;

            tbCurrentpage.Text = pageable.PageNumber.ToString();
            lbTotalpage.Text = "/" + page.TotalPages;

            tableResident.Rows.Clear();
            foreach (Resident resident in page.Content)
            {
                tableResident.Rows.Add(resident.Id, resident.Full_name, resident.Apartment_id, resident.Email, resident.Phone);
            }

            btnPrevious.Enabled = pageable.PageNumber > 1;
            btnNext.Enabled = pageable.PageNumber < page.TotalPages;
        }

        private void ChangePage(int pageNumber)
        {
            pageable.PageNumber = pageNumber;
            pageable.SortBy = nameof(Resident.Created_at);
            pageable.SortOrder = SortOrderPageable.Descending;
            page = residentBUS.GetAllPagination(pageable, filters);
            LoadPageAndPageable();
        }

        private void Query()
        {
            int inputCboxIndex = cbFilter.SelectedIndex;
            String inputSearch = tbSearch.Text.Trim();
            filters.Clear();
            if (!string.IsNullOrEmpty(inputSearch))
            {
                switch (inputCboxIndex)
                {
                    case 0:
                        filters.Add(new FilterCondition("Id", CompOp.Equals, inputSearch));
                        break;
                    case 1:
                        filters.Add(new FilterCondition("email", CompOp.Like, inputSearch));
                        break;
                    case 2:
                        filters.Add(new FilterCondition("phone", CompOp.Like, inputSearch));
                        break;
                    case 3:
                        filters.Add(new FilterCondition("full_name", CompOp.Like, inputSearch));
                        break;
                    case 4:
                        filters.Add(new FilterCondition("apartment_id", CompOp.Like, inputSearch));
                        break;
                }
            }
            ChangePage(1);
        }


        private void cbNumberofitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cbNumberofitem.SelectedItem.ToString();
            int pageSize = int.Parse(selectedValue.Split(' ')[0]);
            pageable.PageSize = pageSize;
            ChangePage(1);

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            ChangePage(pageable.PageNumber - 1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ChangePage(pageable.PageNumber + 1);
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