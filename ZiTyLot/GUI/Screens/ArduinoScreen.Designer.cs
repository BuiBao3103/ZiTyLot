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
            this.close = new Sunny.UI.UIButton();
            this.cbPort = new Sunny.UI.UIComboBox();
            this.Connect = new Sunny.UI.UIButton();
            this.Port = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.open.Location = new System.Drawing.Point(49, 108);
            this.open.MinimumSize = new System.Drawing.Size(1, 1);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(189, 35);
            this.open.TabIndex = 0;
            this.open.Text = "open";
            this.open.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.open.Click += new System.EventHandler(this.btnQuet_Click);
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.close.Location = new System.Drawing.Point(49, 190);
            this.close.MinimumSize = new System.Drawing.Size(1, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(189, 35);
            this.close.TabIndex = 2;
            this.close.Text = "close";
            this.close.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // cbPort
            // 
            this.cbPort.DataSource = null;
            this.cbPort.FillColor = System.Drawing.Color.White;
            this.cbPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbPort.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbPort.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbPort.Location = new System.Drawing.Point(407, 114);
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
            // Connect
            // 
            this.Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Connect.Location = new System.Drawing.Point(407, 190);
            this.Connect.MinimumSize = new System.Drawing.Size(1, 1);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(150, 35);
            this.Connect.TabIndex = 4;
            this.Connect.Text = "Connect";
            this.Connect.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Port
            // 
            this.Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Port.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Port.Location = new System.Drawing.Point(402, 86);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(100, 23);
            this.Port.TabIndex = 5;
            this.Port.Text = "Port:";
            // 
            // ArduinoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Port);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.cbPort);
            this.Controls.Add(this.close);
            this.Controls.Add(this.open);
            this.Name = "ArduinoScreen";
            this.Size = new System.Drawing.Size(633, 366);
            this.Load += new System.EventHandler(this.ArduinoScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton open;
        private Sunny.UI.UIButton close;
        private Sunny.UI.UIComboBox cbPort;
        private Sunny.UI.UIButton Connect;
        private Sunny.UI.UILabel Port;
    }
}
