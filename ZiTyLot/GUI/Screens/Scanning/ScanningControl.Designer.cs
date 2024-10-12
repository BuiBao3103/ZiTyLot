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
            this.checkoutBtn = new Sunny.UI.UIHeaderButton();
            this.checkinBtn = new Sunny.UI.UIHeaderButton();
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
            this.uiPanel1.Controls.Add(this.checkoutBtn);
            this.uiPanel1.Controls.Add(this.checkinBtn);
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
            // checkoutBtn
            // 
            this.checkoutBtn.CircleColor = System.Drawing.Color.White;
            this.checkoutBtn.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.checkoutBtn.CircleSize = 100;
            this.checkoutBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkoutBtn.FillColor = System.Drawing.Color.White;
            this.checkoutBtn.FillDisableColor = System.Drawing.Color.White;
            this.checkoutBtn.FillHoverColor = System.Drawing.Color.White;
            this.checkoutBtn.FillPressColor = System.Drawing.Color.White;
            this.checkoutBtn.FillSelectedColor = System.Drawing.Color.White;
            this.checkoutBtn.Font = new System.Drawing.Font("Helvetica Rounded", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.checkoutBtn.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.checkoutBtn.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.checkoutBtn.Location = new System.Drawing.Point(316, 0);
            this.checkoutBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Padding = new System.Windows.Forms.Padding(50);
            this.checkoutBtn.Radius = 14;
            this.checkoutBtn.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.checkoutBtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.checkoutBtn.RectSize = 2;
            this.checkoutBtn.Size = new System.Drawing.Size(250, 250);
            this.checkoutBtn.Symbol = 361579;
            this.checkoutBtn.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.checkoutBtn.SymbolOffset = new System.Drawing.Point(-4, 0);
            this.checkoutBtn.SymbolSize = 72;
            this.checkoutBtn.TabIndex = 1;
            this.checkoutBtn.Text = "Check Out";
            this.checkoutBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.checkoutBtn.TipsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtn_Click);
            // 
            // checkinBtn
            // 
            this.checkinBtn.CircleColor = System.Drawing.Color.White;
            this.checkinBtn.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.checkinBtn.CircleSize = 100;
            this.checkinBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkinBtn.FillColor = System.Drawing.Color.White;
            this.checkinBtn.FillDisableColor = System.Drawing.Color.White;
            this.checkinBtn.FillHoverColor = System.Drawing.Color.White;
            this.checkinBtn.FillPressColor = System.Drawing.Color.White;
            this.checkinBtn.FillSelectedColor = System.Drawing.Color.White;
            this.checkinBtn.Font = new System.Drawing.Font("Helvetica Rounded", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.checkinBtn.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.checkinBtn.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.checkinBtn.Location = new System.Drawing.Point(0, 0);
            this.checkinBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkinBtn.Name = "checkinBtn";
            this.checkinBtn.Padding = new System.Windows.Forms.Padding(50);
            this.checkinBtn.Radius = 14;
            this.checkinBtn.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.checkinBtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.checkinBtn.RectSize = 2;
            this.checkinBtn.Size = new System.Drawing.Size(250, 250);
            this.checkinBtn.Symbol = 361584;
            this.checkinBtn.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.checkinBtn.SymbolOffset = new System.Drawing.Point(-10, 0);
            this.checkinBtn.SymbolSize = 72;
            this.checkinBtn.TabIndex = 0;
            this.checkinBtn.Text = "Check in";
            this.checkinBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.checkinBtn.TipsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.checkinBtn.Click += new System.EventHandler(this.checkinBtn_Click);
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
        private Sunny.UI.UIHeaderButton checkinBtn;
        private Sunny.UI.UIHeaderButton checkoutBtn;
    }
}
