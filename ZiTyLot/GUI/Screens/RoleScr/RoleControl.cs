﻿using Sprache;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.DTOS;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Screens.RoleScr;
using ZiTyLot.GUI.Utils;
using ZiTyLot.Helper;

namespace ZiTyLot.GUI.Screens
{
    public partial class RoleControl : UserControl
    {
        private readonly Debouncer _debouncer = new Debouncer();
        private readonly RoleBUS roleBUS = new RoleBUS();
        private readonly List<FilterCondition> filters = new List<FilterCondition>();
        private List<Role> roleList;

        private RoleCreateForm _roleCreateForm;
        private RoleDetailForm _roleDetailForm;
        public RoleControl()
        {
            InitializeComponent();
        }

        private void RoleScreen_Load(object sender, EventArgs e)
        {
            pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
            pnlBottom.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 10, 10));
            this.tableRole.Paint += new System.Windows.Forms.PaintEventHandler(this.table_Paint);
            this.tableRole.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.table_CellPainting);
            this.tableRole.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
        }

        // Paint the header cell
        private void table_Paint(object sender, PaintEventArgs e)
        {
            Rectangle firstHeaderCellRect = this.tableRole.GetCellDisplayRectangle(this.tableRole.Columns["colView"].Index, -1, true);
            Rectangle lastHeaderCellRect = this.tableRole.GetCellDisplayRectangle(this.tableRole.Columns["colDelete"].Index, -1, true);
            Rectangle mergedHeaderRect = new Rectangle(firstHeaderCellRect.X, firstHeaderCellRect.Y, lastHeaderCellRect.X + lastHeaderCellRect.Width - firstHeaderCellRect.X, firstHeaderCellRect.Height);
            e.Graphics.FillRectangle(new SolidBrush(Color.White), mergedHeaderRect);
            TextRenderer.DrawText(e.Graphics, "Action", this.tableRole.ColumnHeadersDefaultCellStyle.Font,
                mergedHeaderRect, this.tableRole.ColumnHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        // Paint the cell
        private void table_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if ((e.ColumnIndex == tableRole.Columns["colView"].Index ||
                 e.ColumnIndex == tableRole.Columns["colDelete"].Index) && e.RowIndex >= 0)
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
                if (e.ColumnIndex == tableRole.Columns["colView"].Index)
                {
                    icon = Properties.Resources.Icon_18x18px_View;
                }
                else if (e.ColumnIndex == tableRole.Columns["colDelete"].Index)
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
                int roleId = (int) tableRole.Rows[e.RowIndex].Cells[0].Value;
                if (e.ColumnIndex == tableRole.Columns["colView"].Index)
                {
                    ShowRoleDetailForm(roleId);
                }
                else if (e.ColumnIndex == tableRole.Columns["colDelete"].Index)
                {
                    DeleteRole(roleId);
                }
            }
        }

        private void DeleteRole(int roleId)
        {
            DialogResult result = MessageHelper.ShowConfirm("Are you sure you want to delete this role?");
            if (result == DialogResult.Yes)
            {
                try
                {
                    Role role = roleBUS.GetById(roleId);
                    role = roleBUS.PopulateAccounts(role);
                    if (role.Accounts != null && role.Accounts.Count != 0)
                    {
                        string str = "This role is used by the accounts:";
                        foreach (Account account in role.Accounts)
                        {
                            str += $" {account.Username},";
                        }
                        str = str.Remove(str.Length - 1);
                        MessageHelper.ShowWarning(str);
                        return;
                    }
                    role.Name = "-1";
                    roleBUS.Update(role);
                    roleBUS.Delete(roleId);
                    filters.Clear();
                    roleList = roleBUS.GetAll(filters);
                    LoadDataToTable();
                }
                catch (Exception ex)
                {
                    MessageHelper.ShowWarning("An unexpected error occurred. Please try again later.");
                }
            }
        }

        private void ShowRoleDetailForm(int roleId)
        {
            if (_roleDetailForm != null && roleId != _roleDetailForm.role.Id)
            {
                _roleDetailForm.Close();
            }
            if (_roleDetailForm == null || _roleDetailForm.IsDisposed)
            {

                _roleDetailForm = new RoleDetailForm(roleId);
                _roleDetailForm.RoleUpdateEvent += (s, args) =>
                {
                    roleList = roleBUS.GetAll();
                    LoadDataToTable();
                };
                _roleDetailForm.Show();
            }
            else
            {
                if (_roleDetailForm.WindowState == FormWindowState.Minimized)
                    _roleDetailForm.WindowState = FormWindowState.Normal;
                _roleDetailForm.BringToFront();
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
                    tableSearch.ColumnStyles[2] = new ColumnStyle(SizeType.Absolute, 65);
                    break;
                case 1:
                    tableSearch.ColumnStyles[2] = new ColumnStyle(SizeType.Absolute, 95);
                    break;
            }
            query();
        }

        private void btnAdd_Click_1(object sender, EventArgs e) => ShowRoleCreateForm();

        private void ShowRoleCreateForm()
        {
            if (_roleCreateForm == null || _roleCreateForm.IsDisposed)
            {
                _roleCreateForm = new RoleCreateForm();
                _roleCreateForm.RoleCreated += (s, args) =>
                {
                    filters.Clear();
                    roleList = roleBUS.GetAll();
                    LoadDataToTable();
                };
                _roleCreateForm.Show();
            }
            else
            {
                if (_roleCreateForm.WindowState == FormWindowState.Minimized)
                    _roleCreateForm.WindowState = FormWindowState.Normal;
                _roleCreateForm.BringToFront();
            }
        }

        private void LoadDataToTable()
        {
            tableRole.Rows.Clear();
            foreach (Role role in roleList)
            {
                tableRole.Rows.Add(role.Id, role.Name);
            }
        }

        public void query()
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
                        filters.Add(new FilterCondition("name", CompOp.Like, inputSearch));
                        break;
                }
            }
            roleList = roleBUS.GetAll(filters);
            LoadDataToTable();
        }

        private async void tbSearch_TextChanged(object sender, EventArgs e)
        {
            await _debouncer.DebounceAsync(() =>
            {
                query();
                return Task.CompletedTask;
            }, 500);
        }
    }
}