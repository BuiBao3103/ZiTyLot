namespace ZiTyLot.GUI.Screens
{
    partial class ArduinoScreen
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
            this.open = new Sunny.UI.UIButton();
            this.lbRFID = new Sunny.UI.UILabel();
            this.close = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.open.Location = new System.Drawing.Point(54, 79);
            this.open.MinimumSize = new System.Drawing.Size(1, 1);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(189, 35);
            this.open.TabIndex = 0;
            this.open.Text = "open";
            this.open.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.open.Click += new System.EventHandler(this.btnQuet_Click);
            // 
            // lbRFID
            // 
            this.lbRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbRFID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbRFID.Location = new System.Drawing.Point(328, 128);
            this.lbRFID.Name = "lbRFID";
            this.lbRFID.Size = new System.Drawing.Size(194, 23);
            this.lbRFID.TabIndex = 1;
            this.lbRFID.Text = "Đợi quẹt thẻ RFID...";
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.close.Location = new System.Drawing.Point(54, 168);
            this.close.MinimumSize = new System.Drawing.Size(1, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(189, 35);
            this.close.TabIndex = 2;
            this.close.Text = "close";
            this.close.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // ArduinoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.close);
            this.Controls.Add(this.lbRFID);
            this.Controls.Add(this.open);
            this.Name = "ArduinoScreen";
            this.Size = new System.Drawing.Size(633, 366);
            this.Load += new System.EventHandler(this.ArduinoScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton open;
        private Sunny.UI.UILabel lbRFID;
        private Sunny.UI.UIButton close;
    }
}
