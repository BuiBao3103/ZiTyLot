using OfficeOpenXml.Utils;
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
        private const int CAR_ID = 1;
        private const int MOTORBIKE_ID = 2;
        private const int BICYCLE_ID = 3;

        private readonly VehicleTypeBUS _vehicleTypeBUS;
        private readonly ResidentFeeBUS _residentFeeBUS;
        private readonly VisitorFeeBUS _visitorFeeBUS;

        private VisitorFee _visitorFeeCar;
        private VisitorFee _visitorFeeMotorbike;
        private VisitorFee _visitorFeeBicycle;
        private List<ResidentFee> _residentFees;

        private AddResidentFeeForm _addResidentFeeForm;
        private AddVisitorFeeForm _addVisitorCarFeeForm;
        private AddVisitorFeeForm _addVisitorMotorbikeFeeForm;
        private AddVisitorFeeForm _addVisitorBicycleFeeForm;
        private DetailResidentFeeForm _detailResidentFeeForm;
        private DetailVisitorFeeForm _detailVisitorFeeForm;
        public PriceControl()
        {
            InitializeComponent();
            _vehicleTypeBUS = new VehicleTypeBUS();
            _residentFeeBUS = new ResidentFeeBUS();
            _visitorFeeBUS = new VisitorFeeBUS();
            LoadInitialData();
        }


        private void LoadInitialData()
        {
            _visitorFeeCar = _visitorFeeBUS.GetVisitorFeeByVehicleTypeId(CAR_ID);
            _visitorFeeMotorbike = _visitorFeeBUS.GetVisitorFeeByVehicleTypeId(MOTORBIKE_ID);
            _visitorFeeBicycle = _visitorFeeBUS.GetVisitorFeeByVehicleTypeId(BICYCLE_ID);
            _residentFees = _residentFeeBUS.GetAll();

            LoadVisitorFee();
            LoadResidentFee();
        }


        private void ShowAddVisitorFeeForm()
        {
            var (addForm, vehicleTypeId) = GetAddFormForTab(pnlTab.SelectedIndex);
            if (addForm == null || addForm.IsDisposed)
            {
                var newForm = new AddVisitorFeeForm(vehicleTypeId);

                newForm.PricePerTurnInsertion += (s, args) => RefreshVisitorFees();
                newForm.PricePerHourTurnInsertion += (s, args) => RefreshVisitorFees();
                newForm.PricePerPeriodInsertion += (s, args) => RefreshVisitorFees();

                switch (pnlTab.SelectedIndex)
                {
                    case 0:
                        _addVisitorMotorbikeFeeForm = newForm;
                        break;
                    case 1:
                        _addVisitorCarFeeForm = newForm;
                        break;
                    case 2:
                        _addVisitorBicycleFeeForm = newForm;
                        break;
                }
                newForm.Show();
            }
            else
            {
                if (addForm.WindowState == FormWindowState.Minimized)
                {
                    addForm.WindowState = FormWindowState.Normal;
                }
                addForm.BringToFront();
            }
        }

        private (AddVisitorFeeForm form, int vehicleTypeId) GetAddFormForTab(int tabIndex)
        {
            switch (tabIndex)
            {
                case 0:
                    return (_addVisitorMotorbikeFeeForm, MOTORBIKE_ID);
                case 1:
                    return (_addVisitorCarFeeForm, CAR_ID);
                case 2:
                    return (_addVisitorBicycleFeeForm, BICYCLE_ID);
                default:
                    return (null, 0);
            }
        }
        private void ShowDetailVisitorFeeForm()
        {
            if (_detailVisitorFeeForm != null && !_detailVisitorFeeForm.IsDisposed)
            {
                _detailVisitorFeeForm.Close();
            }
            if (_detailVisitorFeeForm == null || _detailVisitorFeeForm.IsDisposed)
            {
                VisitorFee visitorFee;
                switch (pnlTab.SelectedIndex)
                {
                    case 0:
                        visitorFee = _visitorFeeMotorbike;
                        break;
                    case 1:
                        visitorFee = _visitorFeeCar;
                        break;
                    case 2:
                        visitorFee = _visitorFeeBicycle;
                        break;
                    default:
                        return;
                }
                _detailVisitorFeeForm = new DetailVisitorFeeForm(visitorFee.Id);
                _detailVisitorFeeForm.VisitorFeeUpdateEvent += (s, args) => RefreshVisitorFees();
                _detailVisitorFeeForm.Show();
            }
            else
            {
                if (_detailVisitorFeeForm.WindowState == FormWindowState.Minimized)
                {
                    _detailVisitorFeeForm.WindowState = FormWindowState.Normal;
                }
                _detailVisitorFeeForm.BringToFront();
            }
        }



        private void RefreshVisitorFees()
        {
            _visitorFeeCar = _visitorFeeBUS.GetVisitorFeeByVehicleTypeId(CAR_ID);
            _visitorFeeMotorbike = _visitorFeeBUS.GetVisitorFeeByVehicleTypeId(MOTORBIKE_ID);
            _visitorFeeBicycle = _visitorFeeBUS.GetVisitorFeeByVehicleTypeId(BICYCLE_ID);
            LoadVisitorFee();
        }

        private void AddPriceCard(Sunny.UI.UIPanel targetPanel, VisitorFee visitorFee)
        {
            switch (visitorFee.Fee_type)
            {
                case FeeType.TURN:
                    AddNewPricePerTurnCard(targetPanel, visitorFee);
                    break;
                case FeeType.HOUR_PER_TURN:
                    AddNewPricePerHourTurnCard(targetPanel, visitorFee);
                    break;
                case FeeType.FIRST_N_AND_NEXT_M_HOUR:
                    AddNewPricePerPeriodCard(targetPanel, visitorFee);
                    break;
            }
        }

        private void AddNewPricePerTurnCard(Sunny.UI.UIPanel targetPanel, VisitorFee visitorFee)
        {
            PricePerTurnCard pricePerTurnCard = new PricePerTurnCard(visitorFee);
            pricePerTurnCard.Dock = DockStyle.Top;
            pricePerTurnCard.EditButtonClicked += (s, e) => ShowDetailVisitorFeeForm();
            targetPanel.Controls.Clear();
            targetPanel.Controls.Add(pricePerTurnCard);
        }

        private void AddNewPricePerHourTurnCard(Sunny.UI.UIPanel targetPanel, VisitorFee visitorFee)
        {
            PricePerHourTurnCard pricePerHourTurnCard = new PricePerHourTurnCard(visitorFee);
            pricePerHourTurnCard.Dock = DockStyle.Top;
            pricePerHourTurnCard.EditButtonClicked += (s, e) => ShowDetailVisitorFeeForm();
            targetPanel.Controls.Clear();
            targetPanel.Controls.Add(pricePerHourTurnCard);
        }

        private void AddNewPricePerPeriodCard(Sunny.UI.UIPanel targetPanel, VisitorFee visitorFee)
        {
            PricePerPeriodCard pricePerPeriodCard = new PricePerPeriodCard(visitorFee);
            pricePerPeriodCard.Dock = DockStyle.Top;
            pricePerPeriodCard.EditButtonClicked += (s, e) => ShowDetailVisitorFeeForm();
            targetPanel.Controls.Clear();
            targetPanel.Controls.Add(pricePerPeriodCard);
        }

        private void LoadVisitorFee()
        {
            if (_visitorFeeCar != null) AddPriceCard(pnlCarPrice, _visitorFeeCar);
            if (_visitorFeeMotorbike != null) AddPriceCard(pnlMotorbikePrice, _visitorFeeMotorbike);
            if (_visitorFeeBicycle != null) AddPriceCard(pnlBicyclePrice, _visitorFeeBicycle);
        }

        private void LoadResidentFee()
        {
            tableBicycle.Rows.Clear();
            tableCar.Rows.Clear();
            tableMotorbike.Rows.Clear();
            foreach (var residentFee in _residentFees)
            {
                var feeFormat = residentFee.Fee.ToString("C0", new System.Globalization.CultureInfo("vi-VN"));
                var durationFormat = $"{residentFee.Month} {(residentFee.Month == 1 ? "month" : "months")}";

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

        private void ShowAddResidentFeeForm(int vehicleId)
        {
            if (_addResidentFeeForm == null || _addResidentFeeForm.IsDisposed)
            {
                _addResidentFeeForm = new AddResidentFeeForm(vehicleId);
                _addResidentFeeForm.ResidentFeeInsertionEvent += (s, args) =>
                {
                    _residentFees = _residentFeeBUS.GetAll();
                    LoadResidentFee();
                };
                _addResidentFeeForm.Show();
            }
            else
            {
                if (_addResidentFeeForm.WindowState == FormWindowState.Minimized)
                    _addResidentFeeForm.WindowState = FormWindowState.Normal;
                _addResidentFeeForm.BringToFront();
            }
        }

        private void ShowDetailResidentFeeForm(int residentFeeId)
        {
            if (_detailResidentFeeForm != null && residentFeeId != _detailResidentFeeForm.residentFee.Id)
            {
                _detailResidentFeeForm.Close();
            }

            if (_detailResidentFeeForm == null || _detailResidentFeeForm.IsDisposed)
            {

                _detailResidentFeeForm = new DetailResidentFeeForm(residentFeeId);
                _detailResidentFeeForm.ResidentFeeUpdateEvent += (s, args) =>
                {
                    _residentFees = _residentFeeBUS.GetAll();
                    LoadResidentFee();
                };
                _detailResidentFeeForm.Show();
            }
            else
            {
                if (_detailResidentFeeForm.WindowState == FormWindowState.Minimized)
                    _detailResidentFeeForm.WindowState = FormWindowState.Normal;
                _detailResidentFeeForm.BringToFront();
            }
        }

        private void DeleteResidentFee(int id)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this resident fee?", "Delete Resident Fee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _residentFeeBUS.Delete(id);
                    _residentFees = _residentFeeBUS.GetAll();
                    LoadResidentFee();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show($"An error occurred while deleting resident fee: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Event Handlers
        private void btnMotorbikeVisitorFee_Click(object sender, EventArgs e) => ShowAddVisitorFeeForm();

        private void btnCarVisitorFee_Click(object sender, EventArgs e) => ShowAddVisitorFeeForm();

        private void btnBicycleVisitorFee_Click(object sender, EventArgs e) => ShowAddVisitorFeeForm();

        private void btnMotorbikeResidentFee_Click(object sender, EventArgs e) =>
            ShowAddResidentFeeForm(MOTORBIKE_ID);

        private void btnCarResidentFee_Click(object sender, EventArgs e) =>
            ShowAddResidentFeeForm(CAR_ID);

        private void btnBicycleResidentFee_Click(object sender, EventArgs e) =>
            ShowAddResidentFeeForm(BICYCLE_ID);
        #endregion

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
                int id = (int)tableMotorbike.Rows[e.RowIndex].Cells[0].Value;
                if (e.ColumnIndex == tableMotorbike.Columns["colMotorbikeView"].Index)
                {
                    ShowDetailResidentFeeForm(id);
                }
                else if (e.ColumnIndex == tableMotorbike.Columns["colMotorbikeDelete"].Index)
                {
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
                int id = (int)tableCar.Rows[e.RowIndex].Cells[0].Value;
                if (e.ColumnIndex == tableCar.Columns["colCarView"].Index)
                {
                    ShowDetailResidentFeeForm(id);
                }
                else if (e.ColumnIndex == tableCar.Columns["colCarDelete"].Index)
                {
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
                int id = (int)tableBicycle.Rows[e.RowIndex].Cells[0].Value;
                if (e.ColumnIndex == tableBicycle.Columns["colBicycleView"].Index)
                {
                    ShowDetailResidentFeeForm(id);
                }
                else if (e.ColumnIndex == tableBicycle.Columns["colBicycleDelete"].Index)
                {
                    DeleteResidentFee(id);
                }
            }
        }
    }
}
