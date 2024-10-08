namespace ZiTyLot.GUI
{
    partial class SessionScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sessionTopPnl = new System.Windows.Forms.Panel();
            this.searchPnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inputSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.filterRadio = new System.Windows.Forms.Panel();
            this.checkOutFilter = new System.Windows.Forms.RadioButton();
            this.checkInFilter = new System.Windows.Forms.RadioButton();
            this.allFilter = new System.Windows.Forms.RadioButton();
            this.separator = new System.Windows.Forms.Panel();
            this.main = new System.Windows.Forms.Panel();
            this.sessionBottomPnl = new System.Windows.Forms.Panel();
            this.table = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailButtonCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.sessionTopPnl.SuspendLayout();
            this.searchPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.filterRadio.SuspendLayout();
            this.main.SuspendLayout();
            this.sessionBottomPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // sessionTopPnl
            // 
            this.sessionTopPnl.BackColor = System.Drawing.Color.White;
            this.sessionTopPnl.Controls.Add(this.searchPnl);
            this.sessionTopPnl.Controls.Add(this.filterRadio);
            this.sessionTopPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sessionTopPnl.Location = new System.Drawing.Point(0, 0);
            this.sessionTopPnl.Name = "sessionTopPnl";
            this.sessionTopPnl.Padding = new System.Windows.Forms.Padding(10);
            this.sessionTopPnl.Size = new System.Drawing.Size(962, 54);
            this.sessionTopPnl.TabIndex = 0;
            this.sessionTopPnl.Resize += new System.EventHandler(this.sessionTopPnl_Resize);
            // 
            // searchPnl
            // 
            this.searchPnl.BackColor = System.Drawing.Color.White;
            this.searchPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPnl.Controls.Add(this.panel1);
            this.searchPnl.Controls.Add(this.pictureBox1);
            this.searchPnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchPnl.Location = new System.Drawing.Point(724, 10);
            this.searchPnl.Name = "searchPnl";
            this.searchPnl.Size = new System.Drawing.Size(228, 34);
            this.searchPnl.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.inputSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 8, 5, 5);
            this.panel1.Size = new System.Drawing.Size(186, 32);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // inputSearch
            // 
            this.inputSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSearch.Location = new System.Drawing.Point(5, 8);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(176, 17);
            this.inputSearch.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::ZiTyLot.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(192, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // filterRadio
            // 
            this.filterRadio.Controls.Add(this.checkOutFilter);
            this.filterRadio.Controls.Add(this.checkInFilter);
            this.filterRadio.Controls.Add(this.allFilter);
            this.filterRadio.Dock = System.Windows.Forms.DockStyle.Left;
            this.filterRadio.Location = new System.Drawing.Point(10, 10);
            this.filterRadio.Name = "filterRadio";
            this.filterRadio.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.filterRadio.Size = new System.Drawing.Size(268, 34);
            this.filterRadio.TabIndex = 7;
            // 
            // checkOutFilter
            // 
            this.checkOutFilter.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkOutFilter.AutoSize = true;
            this.checkOutFilter.BackColor = System.Drawing.Color.White;
            this.checkOutFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkOutFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutFilter.Image = global::ZiTyLot.Properties.Resources.scan;
            this.checkOutFilter.Location = new System.Drawing.Point(157, 0);
            this.checkOutFilter.Margin = new System.Windows.Forms.Padding(10);
            this.checkOutFilter.Name = "checkOutFilter";
            this.checkOutFilter.Size = new System.Drawing.Size(110, 34);
            this.checkOutFilter.TabIndex = 5;
            this.checkOutFilter.TabStop = true;
            this.checkOutFilter.Text = "Check out";
            this.checkOutFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkOutFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkOutFilter.UseVisualStyleBackColor = false;
            // 
            // checkInFilter
            // 
            this.checkInFilter.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkInFilter.AutoSize = true;
            this.checkInFilter.BackColor = System.Drawing.Color.White;
            this.checkInFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkInFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInFilter.Image = global::ZiTyLot.Properties.Resources.scan;
            this.checkInFilter.Location = new System.Drawing.Point(57, 0);
            this.checkInFilter.Margin = new System.Windows.Forms.Padding(10);
            this.checkInFilter.Name = "checkInFilter";
            this.checkInFilter.Size = new System.Drawing.Size(100, 34);
            this.checkInFilter.TabIndex = 4;
            this.checkInFilter.TabStop = true;
            this.checkInFilter.Text = "Check in";
            this.checkInFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkInFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkInFilter.UseVisualStyleBackColor = false;
            // 
            // allFilter
            // 
            this.allFilter.Appearance = System.Windows.Forms.Appearance.Button;
            this.allFilter.AutoSize = true;
            this.allFilter.BackColor = System.Drawing.Color.White;
            this.allFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.allFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allFilter.Image = global::ZiTyLot.Properties.Resources.scan;
            this.allFilter.Location = new System.Drawing.Point(0, 0);
            this.allFilter.Margin = new System.Windows.Forms.Padding(10);
            this.allFilter.Name = "allFilter";
            this.allFilter.Size = new System.Drawing.Size(57, 34);
            this.allFilter.TabIndex = 3;
            this.allFilter.TabStop = true;
            this.allFilter.Text = "All";
            this.allFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.allFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.allFilter.UseVisualStyleBackColor = false;
            // 
            // separator
            // 
            this.separator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.separator.Dock = System.Windows.Forms.DockStyle.Top;
            this.separator.Location = new System.Drawing.Point(0, 54);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(962, 5);
            this.separator.TabIndex = 1;
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.Color.White;
            this.main.Controls.Add(this.sessionBottomPnl);
            this.main.Controls.Add(this.separator);
            this.main.Controls.Add(this.sessionTopPnl);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(15, 15);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(962, 636);
            this.main.TabIndex = 0;
            this.main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sessionBottomPnl
            // 
            this.sessionBottomPnl.BackColor = System.Drawing.Color.White;
            this.sessionBottomPnl.Controls.Add(this.table);
            this.sessionBottomPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sessionBottomPnl.Location = new System.Drawing.Point(0, 59);
            this.sessionBottomPnl.Name = "sessionBottomPnl";
            this.sessionBottomPnl.Padding = new System.Windows.Forms.Padding(10);
            this.sessionBottomPnl.Size = new System.Drawing.Size(962, 577);
            this.sessionBottomPnl.TabIndex = 2;
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.BackgroundColor = System.Drawing.Color.White;
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.type,
            this.plate,
            this.checkIn,
            this.checkOut,
            this.totalTime,
            this.totalPrice,
            this.detailButtonCol});
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(10, 10);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowTemplate.Height = 30;
            this.table.Size = new System.Drawing.Size(942, 557);
            this.table.TabIndex = 0;
            this.table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 30;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 80;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // plate
            // 
            this.plate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.plate.HeaderText = "Plate";
            this.plate.Name = "plate";
            this.plate.ReadOnly = true;
            // 
            // checkIn
            // 
            this.checkIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.checkIn.HeaderText = "Check in time";
            this.checkIn.Name = "checkIn";
            this.checkIn.ReadOnly = true;
            // 
            // checkOut
            // 
            this.checkOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.checkOut.HeaderText = "Check out time";
            this.checkOut.Name = "checkOut";
            this.checkOut.ReadOnly = true;
            // 
            // totalTime
            // 
            this.totalTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalTime.HeaderText = "Total time";
            this.totalTime.MinimumWidth = 100;
            this.totalTime.Name = "totalTime";
            this.totalTime.ReadOnly = true;
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalPrice.HeaderText = "Total Price";
            this.totalPrice.MinimumWidth = 100;
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            // 
            // detailButtonCol
            // 
            this.detailButtonCol.HeaderText = "Action";
            this.detailButtonCol.MinimumWidth = 50;
            this.detailButtonCol.Name = "detailButtonCol";
            this.detailButtonCol.ReadOnly = true;
            this.detailButtonCol.Width = 80;
            // 
            // SessionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.main);
            this.Name = "SessionScreen";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Size = new System.Drawing.Size(992, 666);
            this.Load += new System.EventHandler(this.SessionScreen_Load);
            this.sessionTopPnl.ResumeLayout(false);
            this.searchPnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.filterRadio.ResumeLayout(false);
            this.filterRadio.PerformLayout();
            this.main.ResumeLayout(false);
            this.sessionBottomPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sessionTopPnl;
        private System.Windows.Forms.RadioButton allFilter;
        private System.Windows.Forms.RadioButton checkOutFilter;
        private System.Windows.Forms.RadioButton checkInFilter;
        private System.Windows.Forms.Panel searchPnl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox inputSearch;
        private System.Windows.Forms.Panel separator;
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.Panel sessionBottomPnl;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.DataGridViewButtonColumn detailButtonCol;
        private System.Windows.Forms.Panel filterRadio;
    }
}
