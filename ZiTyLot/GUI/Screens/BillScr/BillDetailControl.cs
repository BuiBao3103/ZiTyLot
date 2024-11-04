using System;
using System.Windows.Forms;
using System.Drawing;
using ZiTyLot.Helper;
using ZiTyLot.GUI.component_extensions;
using System.Security.Cryptography.X509Certificates;


namespace ZiTyLot.GUI.Screens.BillScr
{
    public partial class BillDetailControl : UserControl
    {
        int rows = 0;
        Home home = new Home();
        private ListBox listBox;
        public BillDetailControl()
        {
            InitializeComponent();
            pnlBillDetail.RowStyles[1] = new RowStyle(SizeType.Absolute, 0);
            listIssue.AutoScroll = true;


        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

            IssueDetailForm issueDetailForm = new IssueDetailForm();
            issueDetailForm.Show();

            IssueDetailRow newRow = new IssueDetailRow();
            newRow.Dock = DockStyle.Top;

            // Listen for the RowDeleted event from the new row
            newRow.RowDeleted += (s, ev) => RemoveRow(newRow);

            listIssue.Controls.Add(newRow);
            rows += 1;
            listIssue_ResizeAutoScrollMinSize(rows);

        }

        private void RemoveRow(IssueDetailRow row)
        {
            listIssue.Controls.Remove(row);  // Remove the row from the panel
            rows -= 1;  // Decrease the row count
            listIssue_ResizeAutoScrollMinSize(rows);  // Adjust scroll area
        }

        private void listIssue_ResizeAutoScrollMinSize(int rows)
        {
            int newHeight = 60 * rows;  // Assuming each row is 60px in height

            // Adjust the scrollable area based on the number of rows
            listIssue.AutoScrollMinSize = new Size(listIssue.AutoScrollMinSize.Width, newHeight);
        }


        private void pnlIssueTable_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in listIssue.Controls)
            {
                control.Width = listIssue.Width - 40;
            }
        }

        private void BillDetailControl_Load(object sender, EventArgs e)
        {
            pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
            pnlBottom.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 10, 10));
            home = this.ParentForm as Home;
        }

        private void pnlTop_Resize(object sender, EventArgs e)
        {
            pnlTop.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlTop.Width, pnlTop.Height, 10, 10));
        }

        private void pnlBottom_Resize(object sender, EventArgs e)
        {
            pnlBottom.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 10, 10));

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (home != null)
            {
                this.Dispose();
                BillControl billControl = new BillControl();
                home.LoadForm(billControl);
            }
            else
            {
                MessageBox.Show("Home form is not assigned.");
            }
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
                    tableSearch.ColumnStyles[1] = new ColumnStyle(SizeType.Absolute, 120);
                    break;
                case 3:
                    tableSearch.ColumnStyles[1] = new ColumnStyle(SizeType.Absolute, 140);
                    break;
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            //if (listBox == null)
            //{
            //    // Khởi tạo ListBox nếu chưa có
            //    listBox = new ListBox
            //    {
            //        Width = tableSearch.Width, // Đặt chiều rộng bằng tbSearch
            //        Visible = true
            //    };
            //    this.Font = new Font("Arial", 12, FontStyle.Regular);

            //    // Thêm ListBox vào form
            //    this.Controls.Add(listBox);
            //}

            //// Lấy vị trí của tbSearch trong màn hình và chuyển đổi nó thành vị trí trong form
            //var textBoxScreenPosition = tableSearch.PointToScreen(System.Drawing.Point.Empty);
            //var textBoxFormPosition = this.PointToClient(textBoxScreenPosition);

            //// Cập nhật vị trí của ListBox để nằm ngay dưới tbSearch
            //listBox.Location = new System.Drawing.Point(textBoxFormPosition.X, textBoxFormPosition.Y + tableSearch.Height + 2);

            //// Hiển thị ListBox và thêm các mục ví dụ
            //listBox.Visible = true;
            //listBox.BringToFront(); // Đảm bảo ListBox nằm trên các control khác
            //listBox.Items.Clear();
            //listBox.Items.Add("Item 1");
            //listBox.Items.Add("Item 2");
            //listBox.Items.Add("Item 3");

            //// Điều chỉnh chiều cao của ListBox dựa trên các mục
            //listBox.Height = Math.Min(100, listBox.PreferredHeight);
        }

       
    }

}
