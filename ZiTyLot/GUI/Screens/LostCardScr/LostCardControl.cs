﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.Constants;
using ZiTyLot.Constants.Enum;
using ZiTyLot.DTOS;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Screens.SessionScr;
using ZiTyLot.GUI.Utils;
using ZiTyLot.Helper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZiTyLot.GUI.Screens.LostCardScr
{
    public partial class LostCardControl : UserControl
    {
        private readonly Debouncer _debouncer = new Debouncer();
        private readonly LostHistoryBUS _lostHistoryBUS = new LostHistoryBUS();
        private readonly CardBUS _cardBUS = new CardBUS();
        private readonly Pageable _pageable = new Pageable();
        private readonly List<FilterCondition> _filters = new List<FilterCondition>();
        private Page<LostHistory> _page;
        public LostCardControl()
        {
            InitializeComponent();
            cbNumberofitem.SelectedIndexChanged -= cbNumberofitem_SelectedIndexChanged;
            cbNumberofitem.Items.AddRange(_pageable.PageNumbersInit.Select(pageNumber => pageNumber + " items").ToArray());
            cbNumberofitem.SelectedIndex = 0;
            cbNumberofitem.SelectedIndexChanged += cbNumberofitem_SelectedIndexChanged;

        }

        private void table_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == tableLostCard.Columns["colRestore"].Index && e.RowIndex >= 0)
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
                icon = Properties.Resources.Icon_18x18px_Restore;
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
                int id = (int)tableLostCard.Rows[e.RowIndex].Cells[0].Value;
                if (e.ColumnIndex == tableLostCard.Columns["colRestore"].Index)
                {
                    var confirmResult = System.Windows.Forms.MessageBox.Show("Do you really want restore card?",
                                                 "Confirm restore",
                                                 MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        LostHistory lostHistory = _lostHistoryBUS.GetById(id);
                        if (lostHistory.Is_found == true)
                        {
                            MessageHelper.ShowError("This card has been restored before!");
                            return;
                        }
                        Card card = _lostHistoryBUS.PopulateCard(lostHistory).Card;
                        if (card.Type == CardType.RESIDENT)
                            card.Status = CardStatus.EMPTY;
                        else
                            card.Status = CardStatus.ACTIVE;
                        _cardBUS.Update(card);
                        lostHistory.Is_found = true;
                        _lostHistoryBUS.Update(lostHistory);
                        ChangePage(1);
                        MessageHelper.ShowSuccess("Restore card successfully!");
                    }
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (pnlTop.Height == 54)
            {
                pnlTop.Height = 108;
            }
            else
            {
                pnlTop.Height = 54;
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbFilter.SelectedIndex;
            switch (index)
            {
                case 0:
                    tableSearch.ColumnStyles[2] = new ColumnStyle(SizeType.Absolute, 65);
                    break;
                case 1:
                    tableSearch.ColumnStyles[2] = new ColumnStyle(SizeType.Absolute, 130);
                    break;
                case 2:
                    tableSearch.ColumnStyles[2] = new ColumnStyle(SizeType.Absolute, 130);
                    break;
            }
            Query();
        }

        private void TopPnl_Resize(object sender, EventArgs e)
        {
            pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
        }

        private void BottomPnl_Resize(object sender, EventArgs e)
        {
            pnlBottom.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 10, 10));
        }

        private void LostCardControl_Load(object sender, EventArgs e)
        {
            pnlPagination.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlPagination.Width, pnlPagination.Height, 10, 10));
            this.pnlTop.Height = 54;
            this.pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
            this.pnlBottom.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 10, 10));
        }


        private void btnPrevious_Click(object sender, EventArgs e)
        {
            ChangePage(_pageable.PageNumber - 1);
        }

        private void cbNumberofitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cbNumberofitem.SelectedItem.ToString();
            int pageSize = int.Parse(selectedValue.Split(' ')[0]);
            _pageable.PageSize = pageSize;
            ChangePage(1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ChangePage(_pageable.PageNumber + 1);
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
                    pageNumber = pageNumber > _page.TotalPages ? _page.TotalPages : pageNumber;
                }
                ChangePage(pageNumber);
            }
        }

        private void pnlPagination_Resize(object sender, EventArgs e)
        {
            pnlPagination.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlPagination.Width, pnlPagination.Height, 10, 10));

        }
        private void LoadPageAndPageable()
        {
            if (_page == null || _pageable == null) return;

            tbCurrentpage.Text = _pageable.PageNumber.ToString();
            lbTotalpage.Text = "/" + _page.TotalPages;
            tableLostCard.Rows.Clear();
            foreach (LostHistory lostHistory in _page.Content)
            {
                string status = lostHistory.Is_found ? "Found" : "Lost";
                Card card = _lostHistoryBUS.PopulateCard(lostHistory).Card;
                string type = card.Type.ToString();
                tableLostCard.Rows.Add(lostHistory.Id, card.Rfid, lostHistory.Time_loss.ToString(@"dd/MM/yyyy HH:mm:ss"),lostHistory.Owner_name, lostHistory.Owner_identification_card, type, status);
            }

            btnPrevious.Enabled = _pageable.PageNumber > 1;
            btnNext.Enabled = _pageable.PageNumber < _page.TotalPages;
        }

        public void ChangePage(int pageNumber)
        {
            _pageable.PageNumber = pageNumber;
            _pageable.SortBy = nameof(LostHistory.Created_at);
            _pageable.SortOrder = SortOrderPageable.Descending;
            _page = _lostHistoryBUS.GetAllPagination(_pageable, _filters);
            LoadPageAndPageable();
        }

        private void Query()
        {
            int inputCboxIndex = cbFilter.SelectedIndex;
            String inputSearch = tbSearch.Text.Trim();
            _filters.Clear();
            if (!string.IsNullOrEmpty(inputSearch))
            {
                switch (inputCboxIndex)
                {
                    case 0:
                        _filters.Add(new FilterCondition(nameof(LostHistory.Id), CompOp.Equals, inputSearch));
                        break;
                    case 1:
                        _filters.Add(new FilterCondition(nameof(LostHistory.Owner_name), CompOp.Like, inputSearch));
                        break;
                    case 2:
                        _filters.Add(new FilterCondition(nameof(LostHistory.Owner_identification_card), CompOp.Like, inputSearch));
                        break;
                }
            }
            int statusCbIndex = cbStatus.SelectedIndex;
            if (statusCbIndex == 1)
            {
                _filters.Add(new FilterCondition(nameof(LostHistory.Is_found), CompOp.Equals, "1"));
            }
            else if (statusCbIndex == 2)
            {
                _filters.Add(new FilterCondition(nameof(LostHistory.Is_found), CompOp.Equals, "0"));
            }
            ChangePage(1);
        }

        private async void tbSearch_TextChanged(object sender, EventArgs e)
        {
            await _debouncer.DebounceAsync(() =>
            {
                Query();
                return Task.CompletedTask;
            }, 500);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            cbStatus.SelectedIndex = 0;
            _filters.Clear();
            ChangePage(1);
        }
    }

}
