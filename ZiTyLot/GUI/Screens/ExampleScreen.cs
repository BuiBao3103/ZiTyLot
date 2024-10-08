using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiTyLot.GUI.component_extensions;

namespace ZiTyLot.GUI.Screens
{
    public partial class ExampleScreen : UserControl
    {
        public ExampleScreen()
        {
            InitializeComponent();
        }

     

        private void ExampleScreen_Load(object sender, EventArgs e)
        {
            TopPnl.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, TopPnl.Width, TopPnl.Height,10,10));
            BottomPnl.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, BottomPnl.Width, BottomPnl.Height, 10, 10));

            addBtn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, addBtn.Width, addBtn.Height,10,10));
            allBtn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, allBtn.Width, allBtn.Height, 20,20));
            checkInBtn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, checkInBtn.Width, checkInBtn.Height, 20,20));
            checkOutBtn.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, checkOutBtn.Width, checkOutBtn.Height, 20,20));

            allBtn.Checked = true;
            // Attach CheckedChanged events to radio buttons
            this.allBtn.CheckedChanged += new System.EventHandler(this.allFilter_CheckedChanged);
            this.checkInBtn.CheckedChanged += new System.EventHandler(this.checkInFilter_CheckedChanged);
            this.checkOutBtn.CheckedChanged += new System.EventHandler(this.checkOutFilter_CheckedChanged);
            this.table.Paint += new System.Windows.Forms.PaintEventHandler(this.table_Paint);
        }
        private void table_Paint(object sender, PaintEventArgs e)
        {
            string actionHeaderText = "Action";

            // Get the position of the first column you want to merge
            Rectangle firstCellRect = this.table.GetCellDisplayRectangle(this.table.Columns["viewAction"].Index, -1, true);
            Rectangle lastCellRect = this.table.GetCellDisplayRectangle(this.table.Columns["deleteAction"].Index, -1, true);

            // Create a rectangle that spans all three action columns
            Rectangle mergedHeaderRect = new Rectangle(firstCellRect.X, firstCellRect.Y,
                lastCellRect.X + lastCellRect.Width - firstCellRect.X, firstCellRect.Height);

            // Fill the background
            e.Graphics.FillRectangle(new SolidBrush(this.table.ColumnHeadersDefaultCellStyle.BackColor), mergedHeaderRect);

            // Draw the text
            TextRenderer.DrawText(e.Graphics, actionHeaderText, this.table.ColumnHeadersDefaultCellStyle.Font,
                mergedHeaderRect, this.table.ColumnHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
        private void TopPnl_Resize(object sender, EventArgs e)
        {
            TopPnl.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, TopPnl.Width, TopPnl.Height,10,10));
        }

        // All Filter CheckedChanged event handler
        private void allFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (allBtn.Checked)
            {
                allBtn.BackColor = Color.FromArgb(240, 118, 54);  // Active background color
                allBtn.ForeColor = Color.White;  // Active font color
                allBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_All_Active;  // Active icon
         
            }
            else
            {
                allBtn.BackColor = Color.White;  // Default background color
                allBtn.ForeColor = Color.FromArgb(160, 160, 160);  // Default font color
                allBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_All;  // Default icon
            }
        }

        // CheckIn Filter CheckedChanged event handler
        private void checkInFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkInBtn.Checked)
            {
                checkInBtn.BackColor = Color.FromArgb(240, 118, 54);  // Active background color
                checkInBtn.ForeColor = Color.White;  // Active font color
                checkInBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_CheckIn_Active;  // Active icon
            }
            else
            {
                checkInBtn.BackColor = Color.White;  // Default background color
                checkInBtn.ForeColor = Color.FromArgb(160, 160, 160);  // Default font color
                checkInBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_CheckIn;  // Default icon
            }
        }

        // CheckOut Filter CheckedChanged event handler
        private void checkOutFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOutBtn.Checked)
            {
                checkOutBtn.BackColor = Color.FromArgb(240, 118, 54);  // Active background color
                checkOutBtn.ForeColor = Color.White;  // Active font color
                checkOutBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_CheckOut_Active;  // Active icon
            }
            else
            {
                checkOutBtn.BackColor = Color.White;  // Default background color
                checkOutBtn.ForeColor = Color.FromArgb(160, 160, 160);  // Default font color
                checkOutBtn.Image = global::ZiTyLot.Properties.Resources.Icon_18x18px_CheckOut;  // Default icon
            }
        }

        private void BottomPnl_Resize(object sender, EventArgs e)
        {
            BottomPnl.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, BottomPnl.Width, BottomPnl.Height, 10, 10));
        }
    }
}
