﻿using OfficeOpenXml.Utils;
using Org.BouncyCastle.Tls.Crypto;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.Constants.Enum;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Screens.PriceScr;

namespace ZiTyLot.GUI.Screens
{
    public partial class PriceControl : UserControl
    {
        private readonly VehicleTypeBUS vehicleTypeBUS = new VehicleTypeBUS();
        private readonly ResidentFeeBUS residentFeeBUS = new ResidentFeeBUS();
        private readonly VisitorFeeBUS visitorFeeBUS = new VisitorFeeBUS();
        private const int CAR_ID = 1;
        private const int MOTORBIKE_ID = 2;
        private const int BICYCLE_ID = 3;
        private VisitorFee visitorFeeCar = null;
        private VisitorFee visitorFeeMotorbike = null;
        private VisitorFee visitorFeeBicycle = null;
        private List<ResidentFee> residentFees;

        private AddResidentFeeForm addResidentFeeForm = null;
        private AddVisitorFeeForm addVisitorCarFeeForm = null;
        private AddVisitorFeeForm addVisitorMotorbikeFeeForm = null;
        private AddVisitorFeeForm addVisitorBicycleFeeForm = null;
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

            visitorFeeCar = visitorFeeBUS
                .GetAll(
                new List<FilterCondition> {
                    new FilterCondition("vehicle_type_id", CompOp.Equals, CAR_ID)
                }).FirstOrDefault() ?? null;
            visitorFeeMotorbike = visitorFeeBUS
                .GetAll(
                new List<FilterCondition> {
                    new FilterCondition("vehicle_type_id", CompOp.Equals, MOTORBIKE_ID)
                }).FirstOrDefault() ?? null;
            visitorFeeBicycle = visitorFeeBUS
                .GetAll(
                new List<FilterCondition> {
                    new FilterCondition("vehicle_type_id", CompOp.Equals, BICYCLE_ID)
                }).FirstOrDefault() ?? null;
            residentFees = residentFeeBUS.GetAll();
            LoadVisitorFee();
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
                    int id = (int)tableMotorbike.Rows[e.RowIndex].Cells[0].Value;
                    DeleteResidentFee(id);
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
                    int id = (int)tableCar.Rows[e.RowIndex].Cells[0].Value;
                    DeleteResidentFee(id);
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
                    int id = (int)tableBicycle.Rows[e.RowIndex].Cells[0].Value;
                    DeleteResidentFee(id);
                }
            }
        }
        private void ShowAddVisitorFeeForm(Sunny.UI.UIPanel targetPanel)
        {
            int tabControlIndex = pnlTab.SelectedIndex;
            AddVisitorFeeForm currentForm;
            VisitorFee visitorFee;
            int vehicleTypeId;

            switch (tabControlIndex)
            {
                case 0: //Motorbike
                    currentForm = addVisitorMotorbikeFeeForm;
                    vehicleTypeId = MOTORBIKE_ID;
                    visitorFee = visitorFeeMotorbike;
                    break;
                case 1: //Car
                    currentForm = addVisitorCarFeeForm;
                    vehicleTypeId = CAR_ID;
                    visitorFee = visitorFeeCar;
                    break;
                case 2: //Bicycle
                    currentForm = addVisitorBicycleFeeForm;
                    vehicleTypeId = BICYCLE_ID;
                    visitorFee = visitorFeeBicycle;
                    break;
                default:
                    return;
            }

            ShowOrCreateForm(currentForm, vehicleTypeId, targetPanel, tabControlIndex, visitorFee);
        }

        private void ShowOrCreateForm(AddVisitorFeeForm form, int vehicleTypeId, Sunny.UI.UIPanel targetPanel, int tabIndex, VisitorFee visitorFee)
        {
            if (form == null || form.IsDisposed)
            {
                var newForm = new AddVisitorFeeForm(vehicleTypeId);
                newForm.PricePerTurnInsertion += (sender, e) => AddNewPricePerTurnCard(targetPanel, visitorFee);
                newForm.PricePerHourTurnInsertion += (sender, e) => AddNewPricePerHourTurnCard(targetPanel, visitorFee);
                newForm.PricePerPeriodInsertion += (sender, e) => AddNewPricePerPeriodCard(targetPanel,visitorFee);
                newForm.Show();

                switch (tabIndex)
                {
                    case 0:
                        addVisitorMotorbikeFeeForm = newForm;
                        break;
                    case 1:
                        addVisitorCarFeeForm = newForm;
                        break;
                    case 2:
                        addVisitorBicycleFeeForm = newForm;
                        break;
                }
            }
            else
            {
                if (form.WindowState == FormWindowState.Minimized)
                {
                    form.WindowState = FormWindowState.Normal;
                }
                form.BringToFront();
            }
        }
        private void AddNewPricePerTurnCard(Sunny.UI.UIPanel targetPanel, VisitorFee visitorFee)
        {
            PricePerTurnCard pricePerTurnCard = new PricePerTurnCard(visitorFee);
            pricePerTurnCard.Dock = DockStyle.Top;
            pricePerTurnCard.EditButtonClicked += (s, e) => ShowAddVisitorFeeForm(targetPanel);
            targetPanel.Controls.Clear();
            targetPanel.Controls.Add(pricePerTurnCard);
        }

        private void AddNewPricePerHourTurnCard(Sunny.UI.UIPanel targetPanel, VisitorFee visitorFee)
        {
            PricePerHourTurnCard pricePerHourTurnCard = new PricePerHourTurnCard(visitorFee);
            pricePerHourTurnCard.Dock = DockStyle.Top;
            pricePerHourTurnCard.EditButtonClicked += (s, e) => ShowAddVisitorFeeForm(targetPanel);
            targetPanel.Controls.Clear();
            targetPanel.Controls.Add(pricePerHourTurnCard);
        }

        private void AddNewPricePerPeriodCard(Sunny.UI.UIPanel targetPanel, VisitorFee visitorFee)
        {
            PricePerPeriodCard pricePerPeriodCard = new PricePerPeriodCard(visitorFee);
            pricePerPeriodCard.Dock = DockStyle.Top;
            pricePerPeriodCard.EditButtonClicked += (s, e) => ShowAddVisitorFeeForm(targetPanel);
            targetPanel.Controls.Clear();
            targetPanel.Controls.Add(pricePerPeriodCard);
        }

        // Button click handlers specify the target panel
        private void btnMotorbikeVisitorFee_Click(object sender, EventArgs e)
        {
            ShowAddVisitorFeeForm(this.pnlMotorbikePrice);
        }

        private void btnCarVisitorFee_Click(object sender, EventArgs e)
        {
            ShowAddVisitorFeeForm(this.pnlCarPrice);
        }

        private void btnBicycleVisitorFee_Click(object sender, EventArgs e)
        {
            ShowAddVisitorFeeForm(this.pnlBicyclePrice);
        }

        // Separate handlers for resident fee buttons
        private void btnMotorbikeResidentFee_Click(object sender, EventArgs e)
        {
            ShowAddResidentFeeForm(MOTORBIKE_ID);
        }

        private void btnCarResidentFee_Click(object sender, EventArgs e)
        {
            ShowAddResidentFeeForm(CAR_ID);
        }

        private void btnBicycleResidentFee_Click(object sender, EventArgs e)
        {
            ShowAddResidentFeeForm(BICYCLE_ID);
        }

        private void ShowAddResidentFeeForm(int vehicleId)
        {
            if (addResidentFeeForm == null || addResidentFeeForm.IsDisposed)
            {
                addResidentFeeForm = new AddResidentFeeForm(vehicleId);
                addResidentFeeForm.ResidentFeeInsertionEvent += new EventHandler((s, args) =>
                {
                    residentFees = residentFeeBUS.GetAll();
                    LoadResidentFee();
                });
                addResidentFeeForm.Show();
            }
            else
            {
                addResidentFeeForm.BringToFront();
            }
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
        private void LoadVisitorFee()
        {
            if (visitorFeeCar != null)
            {
                switch (visitorFeeCar.Fee_type)
                {
                    case FeeType.TURN:
                        AddNewPricePerTurnCard(pnlCarPrice, visitorFeeCar);
                        break;
                    case FeeType.HOUR_PER_TURN:
                        AddNewPricePerHourTurnCard(pnlCarPrice, visitorFeeCar);
                        break;
                    case FeeType.FIRST_N_AND_NEXT_M_HOUR:
                        AddNewPricePerPeriodCard(pnlCarPrice, visitorFeeCar);
                        break;
                }
            }
            if (visitorFeeMotorbike != null)
            {
                switch (visitorFeeMotorbike.Fee_type)
                {
                    case FeeType.TURN:
                        AddNewPricePerTurnCard(pnlMotorbikePrice, visitorFeeMotorbike);
                        break;
                    case FeeType.HOUR_PER_TURN:
                        AddNewPricePerHourTurnCard(pnlMotorbikePrice, visitorFeeMotorbike);
                        break;
                    case FeeType.FIRST_N_AND_NEXT_M_HOUR:
                        AddNewPricePerPeriodCard(pnlMotorbikePrice, visitorFeeMotorbike);
                        break;
                }
            }
            if (visitorFeeBicycle != null)
            {
                switch (visitorFeeBicycle.Fee_type)
                {
                    case FeeType.TURN:
                        AddNewPricePerTurnCard(pnlBicyclePrice, visitorFeeBicycle);
                        break;
                    case FeeType.HOUR_PER_TURN:
                        AddNewPricePerHourTurnCard(pnlBicyclePrice, visitorFeeBicycle);
                        break;
                    case FeeType.FIRST_N_AND_NEXT_M_HOUR:
                        AddNewPricePerPeriodCard(pnlBicyclePrice, visitorFeeBicycle);
                        break;
                }
            }
        }
        private void DeleteResidentFee(int id)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this resident fee?", "Delete Resident Fee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    residentFeeBUS.Delete(id);
                    residentFees = residentFeeBUS.GetAll();
                    LoadResidentFee();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show($"An error occurred while deleting resident fee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
