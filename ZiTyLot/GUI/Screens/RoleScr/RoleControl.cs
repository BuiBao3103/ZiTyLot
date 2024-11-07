using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Screens.CardScr;
using ZiTyLot.GUI.Screens.RoleScr;
using ZiTyLot.Helper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZiTyLot.GUI.Screens
{
    public partial class RoleControl : UserControl
    {
        private readonly Debouncer _debouncer = new Debouncer();
        private readonly RoleBUS roleBUS = new RoleBUS();
        private readonly List<FilterCondition> filters = new List<FilterCondition>();
        private List<Role> roleList;

        public RoleControl()
        {
            InitializeComponent();
            roleList = roleBUS.GetAll(filters);
            LoadDataToTable();
        }

        private void RoleScreen_Load(object sender, EventArgs e)
        {
            pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
            pnlBottom.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 10, 10));
            btnAdd.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, btnAdd.Width, btnAdd.Height, 10, 10));
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
                if (e.ColumnIndex == tableRole.Columns["colView"].Index)
                {
                    MessageBox.Show("View button clicked for row " + e.RowIndex);
                }
                else if (e.ColumnIndex == tableRole.Columns["colDelete"].Index)
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
            RoleDetailForm roleDetailForm = new RoleDetailForm();
            roleDetailForm.Show();
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
            }
            query();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            RoleCreateForm roleCreateForm = new RoleCreateForm();
            roleCreateForm.Show();
            roleCreateForm.RoleCreated += (s, args) =>
            {
                roleList = roleBUS.GetAll();
                LoadDataToTable();
            };
        }

        private void LoadDataToTable()
        {
            if (roleList == null) return;
            //update table
            tableRole.Rows.Clear();
            foreach (Role role in roleList)
            {
                tableRole.Rows.Add(role.Id, role.Name);
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