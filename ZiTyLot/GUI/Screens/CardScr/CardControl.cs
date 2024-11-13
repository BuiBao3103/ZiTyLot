using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.Constants;
using ZiTyLot.Constants.Enum;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Screens.CardScr;
using ZiTyLot.GUI.Screens.SessionScr;
using ZiTyLot.GUI.Utils;
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

        private CardCreateForm _CardCreateForm;
        public CardControl()
        {
            InitializeComponent();
            cbNumberofitem.SelectedIndexChanged -= cbNumberofitem_SelectedIndexChanged;
            cbNumberofitem.Items.AddRange(pageable.PageNumbersInit.Select(pageNumber => pageNumber + " items").ToArray());
            cbNumberofitem.SelectedIndex = 0;
            cbNumberofitem.SelectedIndexChanged += cbNumberofitem_SelectedIndexChanged; 
            menuFunction.ExportClick += menuBtnExport_Click;
            menuFunction.ImportClick += menuBtnImport_Click;

        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void CardScreen_Load(object sender, EventArgs e)
        {
            pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
            pnlBottom.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 10, 10));
            this.tableCard.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.table_CellPainting);
            this.tableCard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
            pnlTop.Height = 54;
            pnlPagination.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlPagination.Width, pnlPagination.Height, 10, 10));
            menuFunction.Visible = false;

        }


        // Paint the cell
        private void table_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == tableCard.Columns["colDelete"].Index && e.RowIndex >= 0)
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
                icon = Properties.Resources.Icon_18x18px_Remove;
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
                if (e.ColumnIndex == tableCard.Columns["colDelete"].Index)
                {
                    MessageBox.Show("Delete button clicked");
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
                tableCard.Rows.Add(card.Id, card.Rfid, card.Type, card.Vehicle_type, card.Status);
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

        public void changePage(int pageNumber)
        {
            pageable.PageNumber = pageNumber;
            pageable.SortBy = nameof(Card.Created_at);
            pageable.SortOrder = SortOrderPageable.Descending;
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

        private void btnAdd_Click(object sender, EventArgs e) => ShowCardCreateForm();

        private void ShowCardCreateForm()
        {
            if (_CardCreateForm == null || _CardCreateForm.IsDisposed)
            {
                _CardCreateForm = new CardCreateForm();
                _CardCreateForm.CardInsertionEvent += (s, args) =>
                {
                    filters.Clear();
                    changePage(1);
                };
                _CardCreateForm.Show();
            }
            else
            {
                if (_CardCreateForm.WindowState == FormWindowState.Minimized) 
                    _CardCreateForm.WindowState = FormWindowState.Normal;
                _CardCreateForm.BringToFront();
            }
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

        private void btnMore_Click(object sender, EventArgs e)
        {
            menuFunction.SetMode(1);
            menuFunction.BringToFront();
            menuFunction.Visible = !menuFunction.Visible;
            menuFunction.Location = new Point(pnlTop.Width - menuFunction.Width - 8, btnMore.Height + 10);
        }

        private void pnlPagination_Resize(object sender, EventArgs e)
        {
            pnlPagination.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlPagination.Width, pnlPagination.Height, 10, 10));

        }

        private void menuBtnDownload_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                saveFileDialog.FileName = "Card-template";

                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string selectedFileName = saveFileDialog.FileName;
                    string sourceFilePath = @"../../Resource/Excel-templates/Card-template.xlsx";

                    try
                    {
                        File.Copy(sourceFilePath, selectedFileName, true);
                        DialogResult result = MessageHelper.ShowConfirm("Download successful: " + selectedFileName + "\nDo you want to open the file?");

                        if (result == DialogResult.Yes)
                        {
                           Process.Start(selectedFileName);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        MessageHelper.ShowError("Something went wrong during download. Please try again.");
                    }
                }
            }
        }

        private void menuBtnImport_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|Excel Files (*.xls)|*.xls";
                    openFileDialog.Title = "Select an Excel File";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;
                        cardBUS.ImportCardsFromExcel(filePath);
                        MessageHelper.ShowSuccess("Import successful.");
                    }
                    changePage(1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageHelper.ShowError("Something went wrong during import. Please try again.");
            }
        }

        private void menuBtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                        saveFileDialog.Title = "Save an Excel File";

                        saveFileDialog.FileName = "Card-data-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
                 
                        if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;
                            cardBUS.ExportCardsToExcel(filePath);
                            DialogResult result = MessageHelper.ShowConfirm("Export successful: " + filePath + "\nDo you want to open the file?");

                            if (result == DialogResult.Yes)
                            {
                                Process.Start(filePath);
                            }
                        }
                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageHelper.ShowError("Something went wrong during export. Please try again.");
            }
        }

        private void btnMore_LocationChanged(object sender, EventArgs e)
        {
            menuFunction.Visible = false;
        }
    }
}