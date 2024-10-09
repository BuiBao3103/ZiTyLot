namespace ZiTyLot.GUI.Screens
{
    partial class ArduinoRFIDReader
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
            this.cbPort = new Sunny.UI.UIComboBox();
            this.btnConnect = new Sunny.UI.UIButton();
            this.Port = new Sunny.UI.UILabel();
            this.btnDisconnect = new Sunny.UI.UIButton();
            this.lbRFID = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // cbPort
            // 
            this.cbPort.DataSource = null;
            this.cbPort.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbPort.FillColor = System.Drawing.Color.White;
            this.cbPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbPort.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbPort.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbPort.Location = new System.Drawing.Point(38, 67);
            this.cbPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPort.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbPort.Name = "cbPort";
            this.cbPort.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbPort.Size = new System.Drawing.Size(150, 29);
            this.cbPort.SymbolSize = 24;
            this.cbPort.TabIndex = 3;
            this.cbPort.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbPort.Watermark = "";
            // 
            // btnConnect
            // 
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConnect.Location = new System.Drawing.Point(38, 143);
            this.btnConnect.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(150, 35);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnConnect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Port
            // 
            this.Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Port.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Port.Location = new System.Drawing.Point(33, 39);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(100, 23);
            this.Port.TabIndex = 5;
            this.Port.Text = "Port:";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDisconnect.Location = new System.Drawing.Point(38, 205);
            this.btnDisconnect.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(150, 35);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lbRFID
            // 
            this.lbRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbRFID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbRFID.Location = new System.Drawing.Point(295, 128);
            this.lbRFID.Name = "lbRFID";
            this.lbRFID.Size = new System.Drawing.Size(189, 23);
            this.lbRFID.TabIndex = 7;
            this.lbRFID.Text = "RFID: ";
            // 
            // ArduinoRFIDReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(615, 319);
            this.Controls.Add(this.lbRFID);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cbPort);
            this.Name = "ArduinoRFIDReader";
            this.Load += new System.EventHandler(this.ArduinoScreen_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ArduinoRFIDReader_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIComboBox cbPort;
        private Sunny.UI.UIButton btnConnect;
        private Sunny.UI.UILabel Port;
        private Sunny.UI.UIButton btnDisconnect;
        private Sunny.UI.UILabel lbRFID;
    }
}
