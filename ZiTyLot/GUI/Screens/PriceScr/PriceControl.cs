using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Screens.PriceScr;

namespace ZiTyLot.GUI.Screens
{
    public partial class PriceControl : UserControl
    {
        private readonly ResidentFeeBUS residentFeeBUS = new ResidentFeeBUS();
        private readonly VisitorFeeBUS visitorFeeBUS = new VisitorFeeBUS();
        private const int CAR_ID = 1;
        private const int MOTORBIKE_ID = 2;
        private const int BICYCLE_ID = 3;
        private List<ResidentFee> residentFees;
        public PriceControl()
        {
            InitializeComponent();
            this.tableMotorbike.Paint += new System.Windows.Forms.PaintEventHandler(this.table_PaintMotorbike);
            this.tableMotorbike.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.table_CellPaintingMotorbike);
            this.tableMotorbike.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClickMotorbike);
            this.tableCar.Paint += new System.Windows.Forms.PaintEventHandler(this.table_PaintCar);
            this.tableCar.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.table_CellPaintingCar);
            this.tableCar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClickCar);
            this.tableBicycle.Paint += new System.Windows.Forms.PaintEventHandler(this.table_PaintBicycle);
            this.tableBicycle.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.table_CellPaintingBicycle);
            this.tableBicycle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClickBicycle);
            residentFees = residentFeeBUS.GetAll();
            LoadResidentFee();
        }



        private void pnlTab_Resize(object sender, EventArgs e)
        {
            pnlTab.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTab.Width, pnlTab.Height, 10, 10));
        }
        // UI customization for tableMotorbike
        private void table_PaintMotorbike(object sender, PaintEventArgs e)
        {
            Rectangle firstHeaderCellRect = this.tableMotorbike.GetCellDisplayRectangle(this.tableMotorbike.Columns["colMotorbikeView"].Index, -1, true);
            Rectangle lastHeaderCellRect = this.tableMotorbike.GetCellDisplayRectangle(this.tableMotorbike.Columns["colMotorbikeDelete"].Index, -1, true);
            Rectangle mergedHeaderRect = new Rectangle(firstHeaderCellRect.X, firstHeaderCellRect.Y, lastHeaderCellRect.X + lastHeaderCellRect.Width - firstHeaderCellRect.X, firstHeaderCellRect.Height);
            e.Graphics.FillRectangle(new SolidBrush(Color.White), mergedHeaderRect);
            TextRenderer.DrawText(e.Graphics, "Action", this.tableMotorbike.ColumnHeadersDefaultCellStyle.Font,
                mergedHeaderRect, this.tableMotorbike.ColumnHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
        private void table_CellPaintingMotorbike(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if ((e.ColumnIndex == tableMotorbike.Columns["colMotorbikeView"].Index ||
                 e.ColumnIndex == tableMotorbike.Columns["colMotorbikeDelete"].Index) && e.RowIndex >= 0)
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
                if (e.ColumnIndex == tableMotorbike.Columns["colMotorbikeView"].Index)
                {
                    icon = Properties.Resources.Icon_18x18px_View;
                }
                else if (e.ColumnIndex == tableMotorbike.Columns["colMotorbikeDelete"].Index)
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
        private void table_CellClickMotorbike(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == tableMotorbike.Columns["colMotorbikeView"].Index)
                {
                    MessageBox.Show("View button clicked for row " + e.RowIndex);
                }
                else if (e.ColumnIndex == tableMotorbike.Columns["colMotorbikeDelete"].Index)
                {
                    MessageBox.Show("Delete button clicked for row " + e.RowIndex);
                }
            }
        }

        // UI customization for tableCar
        private void table_PaintCar(object sender, PaintEventArgs e)
        {
            Rectangle firstHeaderCellRect = this.tableCar.GetCellDisplayRectangle(this.tableCar.Columns["colCarView"].Index, -1, true);
            Rectangle lastHeaderCellRect = this.tableCar.GetCellDisplayRectangle(this.tableCar.Columns["colCarDelete"].Index, -1, true);
            Rectangle mergedHeaderRect = new Rectangle(firstHeaderCellRect.X, firstHeaderCellRect.Y, lastHeaderCellRect.X + lastHeaderCellRect.Width - firstHeaderCellRect.X, firstHeaderCellRect.Height);
            e.Graphics.FillRectangle(new SolidBrush(Color.White), mergedHeaderRect);
            TextRenderer.DrawText(e.Graphics, "Action", this.tableCar.ColumnHeadersDefaultCellStyle.Font,
                mergedHeaderRect, this.tableCar.ColumnHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
        private void table_CellPaintingCar(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if ((e.ColumnIndex == tableCar.Columns["colCarView"].Index ||
                 e.ColumnIndex == tableCar.Columns["colCarDelete"].Index) && e.RowIndex >= 0)
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
                if (e.ColumnIndex == tableCar.Columns["colCarView"].Index)
                {
                    icon = Properties.Resources.Icon_18x18px_View;
                }
                else if (e.ColumnIndex == tableCar.Columns["colCarDelete"].Index)
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
        private void table_CellClickCar(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == tableCar.Columns["colCarView"].Index)
                {
                    MessageBox.Show("View button clicked for row " + e.RowIndex);
                }
                else if (e.ColumnIndex == tableCar.Columns["colCarDelete"].Index)
                {
                    MessageBox.Show("Delete button clicked for row " + e.RowIndex);
                }
            }
        }

        // UI customization for tableBicycle
        private void table_PaintBicycle(object sender, PaintEventArgs e)
        {
            Rectangle firstHeaderCellRect = this.tableBicycle.GetCellDisplayRectangle(this.tableBicycle.Columns["colBicycleView"].Index, -1, true);
            Rectangle lastHeaderCellRect = this.tableBicycle.GetCellDisplayRectangle(this.tableBicycle.Columns["colBicycleDelete"].Index, -1, true);
            Rectangle mergedHeaderRect = new Rectangle(firstHeaderCellRect.X, firstHeaderCellRect.Y, lastHeaderCellRect.X + lastHeaderCellRect.Width - firstHeaderCellRect.X, firstHeaderCellRect.Height);
            e.Graphics.FillRectangle(new SolidBrush(Color.White), mergedHeaderRect);
            TextRenderer.DrawText(e.Graphics, "Action", this.tableBicycle.ColumnHeadersDefaultCellStyle.Font,
                mergedHeaderRect, this.tableBicycle.ColumnHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
        private void table_CellPaintingBicycle(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if ((e.ColumnIndex == tableBicycle.Columns["colBicycleView"].Index ||
                 e.ColumnIndex == tableBicycle.Columns["colBicycleDelete"].Index) && e.RowIndex >= 0)
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
                if (e.ColumnIndex == tableBicycle.Columns["colBicycleView"].Index)
                {
                    icon = Properties.Resources.Icon_18x18px_View;
                }
                else if (e.ColumnIndex == tableBicycle.Columns["colBicycleDelete"].Index)
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
        private void table_CellClickBicycle(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == tableBicycle.Columns["colBicycleView"].Index)
                {
                    MessageBox.Show("View button clicked for row " + e.RowIndex);
                }
                else if (e.ColumnIndex == tableBicycle.Columns["colBicycleDelete"].Index)
                {
                    MessageBox.Show("Delete button clicked for row " + e.RowIndex);
                }
            }
        }
        private void ShowPriceDetailForm(Sunny.UI.UIPanel targetPanel)
        {
            PriceVisitorForm priceDetailForm = new PriceVisitorForm();
            priceDetailForm.PricePerTurnInsertion += (sender, e) => AddNewPricePerTurnCard(targetPanel);
            priceDetailForm.PricePerHourTurnInsertion += (sender, e) => AddNewPricePerHourTurnCard(targetPanel);
            priceDetailForm.PricePerPeriodInsertion += (sender, e) => AddNewPricePerPeriodCard(targetPanel);
            priceDetailForm.Show();
        }

        private void AddNewPricePerTurnCard(Sunny.UI.UIPanel targetPanel)
        {
            PricePerTurnCard pricePerTurnCard = new PricePerTurnCard();
            pricePerTurnCard.Dock = DockStyle.Top;
            pricePerTurnCard.EditButtonClicked += (s, e) => ShowPriceDetailForm(targetPanel);
            targetPanel.Controls.Clear();
            targetPanel.Controls.Add(pricePerTurnCard);
        }

        private void AddNewPricePerHourTurnCard(Sunny.UI.UIPanel targetPanel)
        {
            PricePerHourTurnCard pricePerHourTurnCard = new PricePerHourTurnCard();
            pricePerHourTurnCard.Dock = DockStyle.Top;
            pricePerHourTurnCard.EditButtonClicked += (s, e) => ShowPriceDetailForm(targetPanel);
            targetPanel.Controls.Clear();
            targetPanel.Controls.Add(pricePerHourTurnCard);
        }

        private void AddNewPricePerPeriodCard(Sunny.UI.UIPanel targetPanel)
        {
            PricePerPeriodCard pricePerPeriodCard = new PricePerPeriodCard();
            pricePerPeriodCard.Dock = DockStyle.Top;
            pricePerPeriodCard.EditButtonClicked += (s, e) => ShowPriceDetailForm(targetPanel);
            targetPanel.Controls.Clear();
            targetPanel.Controls.Add(pricePerPeriodCard);
        }

        // Button click handlers specify the target panel
        private void btnMotorbikeVisitorFee_Click(object sender, EventArgs e)
        {
            ShowPriceDetailForm(this.pnlMotorbikePrice);
        }

        private void btnCarVisitorFee_Click(object sender, EventArgs e)
        {
            ShowPriceDetailForm(this.pnlCarPrice);
        }

        private void btnBicycleVisitorFee_Click(object sender, EventArgs e)
        {
            ShowPriceDetailForm(this.pnlBicyclePrice);
        }

        // Separate handlers for resident fee buttons
        private void btnMotorbikeResidentFee_Click(object sender, EventArgs e)
        {
            PriceResidentForm priceResidentForm = new PriceResidentForm(MOTORBIKE_ID);
            priceResidentForm.Show();
        }

        private void btnCarResidentFee_Click(object sender, EventArgs e)
        {
            PriceResidentForm priceResidentForm = new PriceResidentForm(CAR_ID);
            priceResidentForm.Show();
        }

        private void btnBicycleResidentFee_Click(object sender, EventArgs e)
        {
            PriceResidentForm priceResidentForm = new PriceResidentForm(BICYCLE_ID);
            priceResidentForm.Show();
        }

        private void LoadResidentFee()
        {
            tableBicycle.Rows.Clear();
            tableCar.Rows.Clear();
            tableMotorbike.Rows.Clear();
            foreach (ResidentFee residentFee in residentFees)
            {
                // Format fee in currency vietnam
                string feeFormat = residentFee.Fee.ToString("C0", new System.Globalization.CultureInfo("vi-VN"));
                string durationFormat = residentFee.Month != 1 ? residentFee.Month + " months" : residentFee.Month + " month";
                switch (residentFee.Vehicle_type_id)
                {
                    case MOTORBIKE_ID:
                        tableMotorbike.Rows.Add(residentFee.Id, feeFormat, durationFormat);
                        break;
                    case CAR_ID:
                        tableCar.Rows.Add(residentFee.Id, feeFormat, durationFormat);
                        break;
                    case BICYCLE_ID:
                        tableBicycle.Rows.Add(residentFee.Id, feeFormat, durationFormat);
                        break;
                }
            }

        }
    }
}
