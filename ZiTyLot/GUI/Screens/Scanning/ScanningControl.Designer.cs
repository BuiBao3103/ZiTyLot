using System.Windows.Forms;

namespace ZiTyLot.GUI.Screens
{
    partial class ScanningControl
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btnCheckIn = new Sunny.UI.UIHeaderButton();
            this.btnCheckOut = new Sunny.UI.UIHeaderButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.panel2.Controls.Add(this.uiPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1151, 580);
            this.panel2.TabIndex = 2;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.btnCheckIn);
            this.uiPanel1.Controls.Add(this.btnCheckOut);
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(10, 10);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel1.Size = new System.Drawing.Size(566, 250);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.CircleColor = System.Drawing.Color.White;
            this.btnCheckIn.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCheckIn.CircleSize = 100;
            this.btnCheckIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCheckIn.FillColor = System.Drawing.Color.White;
            this.btnCheckIn.FillDisableColor = System.Drawing.Color.White;
            this.btnCheckIn.FillHoverColor = System.Drawing.Color.White;
            this.btnCheckIn.FillPressColor = System.Drawing.Color.White;
            this.btnCheckIn.FillSelectedColor = System.Drawing.Color.White;
            this.btnCheckIn.Font = new System.Drawing.Font("Helvetica Rounded", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCheckIn.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCheckIn.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCheckIn.Location = new System.Drawing.Point(316, 0);
            this.btnCheckIn.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Padding = new System.Windows.Forms.Padding(50);
            this.btnCheckIn.Radius = 14;
            this.btnCheckIn.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btnCheckIn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnCheckIn.RectSize = 2;
            this.btnCheckIn.Size = new System.Drawing.Size(250, 250);
            this.btnCheckIn.Symbol = 361579;
            this.btnCheckIn.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCheckIn.SymbolOffset = new System.Drawing.Point(-4, 0);
            this.btnCheckIn.SymbolSize = 72;
            this.btnCheckIn.TabIndex = 1;
            this.btnCheckIn.Text = "Check Out";
            this.btnCheckIn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCheckIn.TipsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCheckIn.Click += new System.EventHandler(this.checkoutBtn_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.CircleColor = System.Drawing.Color.White;
            this.btnCheckOut.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCheckOut.CircleSize = 100;
            this.btnCheckOut.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCheckOut.FillColor = System.Drawing.Color.White;
            this.btnCheckOut.FillDisableColor = System.Drawing.Color.White;
            this.btnCheckOut.FillHoverColor = System.Drawing.Color.White;
            this.btnCheckOut.FillPressColor = System.Drawing.Color.White;
            this.btnCheckOut.FillSelectedColor = System.Drawing.Color.White;
            this.btnCheckOut.Font = new System.Drawing.Font("Helvetica Rounded", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCheckOut.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCheckOut.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCheckOut.Location = new System.Drawing.Point(0, 0);
            this.btnCheckOut.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Padding = new System.Windows.Forms.Padding(50);
            this.btnCheckOut.Radius = 14;
            this.btnCheckOut.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btnCheckOut.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnCheckOut.RectSize = 2;
            this.btnCheckOut.Size = new System.Drawing.Size(250, 250);
            this.btnCheckOut.Symbol = 361584;
            this.btnCheckOut.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCheckOut.SymbolOffset = new System.Drawing.Point(-10, 0);
            this.btnCheckOut.SymbolSize = 72;
            this.btnCheckOut.TabIndex = 0;
            this.btnCheckOut.Text = "Check in";
            this.btnCheckOut.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCheckOut.TipsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCheckOut.Click += new System.EventHandler(this.checkinBtn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(110, 34);
            this.panel5.TabIndex = 0;
            // 
            // ScanningControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.Name = "ScanningControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1171, 600);
            this.Load += new System.EventHandler(this.ScanningScreen_Load);
            this.Resize += new System.EventHandler(this.ScanningScreen_Resize);
            this.panel2.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIHeaderButton btnCheckOut;
        private Sunny.UI.UIHeaderButton btnCheckIn;
    }
}
