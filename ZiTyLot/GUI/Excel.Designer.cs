namespace ZiTyLot.GUI
{
    partial class Excel
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDownload = new Sunny.UI.UIButton();
            this.cbTemplate = new Sunny.UI.UIComboBox();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDownload.Location = new System.Drawing.Point(641, 78);
            this.btnDownload.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(100, 35);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download";
            this.btnDownload.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // cbTemplate
            // 
            this.cbTemplate.DataSource = null;
            this.cbTemplate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbTemplate.FillColor = System.Drawing.Color.White;
            this.cbTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbTemplate.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbTemplate.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbTemplate.Location = new System.Drawing.Point(387, 78);
            this.cbTemplate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTemplate.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbTemplate.Name = "cbTemplate";
            this.cbTemplate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbTemplate.Size = new System.Drawing.Size(222, 35);
            this.cbTemplate.SymbolSize = 24;
            this.cbTemplate.TabIndex = 1;
            this.cbTemplate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTemplate.Watermark = "";
            // 
            // Excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbTemplate);
            this.Controls.Add(this.btnDownload);
            this.Name = "Excel";
            this.Text = "Excel";
            this.Load += new System.EventHandler(this.Excel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton btnDownload;
        private Sunny.UI.UIComboBox cbTemplate;
    }
}