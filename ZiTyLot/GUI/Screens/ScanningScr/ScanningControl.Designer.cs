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
            this.uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            this.btnBikeCheckIn = new Sunny.UI.UIHeaderButton();
            this.btnBikeCheckOut = new Sunny.UI.UIHeaderButton();
            this.btnCarCheckOut = new Sunny.UI.UIHeaderButton();
            this.btnCarCheckIn = new Sunny.UI.UIHeaderButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.uiTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.panel2.Controls.Add(this.uiTableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1365, 882);
            this.panel2.TabIndex = 2;
            // 
            // uiTableLayoutPanel1
            // 
            this.uiTableLayoutPanel1.ColumnCount = 2;
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel1.Controls.Add(this.btnBikeCheckIn, 0, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.btnBikeCheckOut, 1, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.btnCarCheckOut, 1, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.btnCarCheckIn, 0, 0);
            this.uiTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiTableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            this.uiTableLayoutPanel1.RowCount = 2;
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel1.Size = new System.Drawing.Size(1365, 882);
            this.uiTableLayoutPanel1.TabIndex = 0;
            this.uiTableLayoutPanel1.TagString = null;
            // 
            // btnBikeCheckIn
            // 
            this.btnBikeCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBikeCheckIn.CircleColor = System.Drawing.Color.White;
            this.btnBikeCheckIn.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnBikeCheckIn.CircleSize = 100;
            this.btnBikeCheckIn.FillColor = System.Drawing.Color.White;
            this.btnBikeCheckIn.FillDisableColor = System.Drawing.Color.White;
            this.btnBikeCheckIn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnBikeCheckIn.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnBikeCheckIn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnBikeCheckIn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBikeCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnBikeCheckIn.Location = new System.Drawing.Point(322, 466);
            this.btnBikeCheckIn.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.btnBikeCheckIn.MaximumSize = new System.Drawing.Size(333, 308);
            this.btnBikeCheckIn.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnBikeCheckIn.Name = "btnBikeCheckIn";
            this.btnBikeCheckIn.Padding = new System.Windows.Forms.Padding(67, 62, 67, 62);
            this.btnBikeCheckIn.Radius = 14;
            this.btnBikeCheckIn.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btnBikeCheckIn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnBikeCheckIn.RectSize = 2;
            this.btnBikeCheckIn.Size = new System.Drawing.Size(333, 308);
            this.btnBikeCheckIn.Symbol = 560023;
            this.btnBikeCheckIn.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnBikeCheckIn.SymbolOffset = new System.Drawing.Point(-5, 0);
            this.btnBikeCheckIn.SymbolSize = 72;
            this.btnBikeCheckIn.TabIndex = 5;
            this.btnBikeCheckIn.Text = "Check in";
            this.btnBikeCheckIn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBikeCheckIn.TipsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnBikeCheckIn.Click += new System.EventHandler(this.btnBikeCheckIn_Click);
            // 
            // btnBikeCheckOut
            // 
            this.btnBikeCheckOut.CircleColor = System.Drawing.Color.White;
            this.btnBikeCheckOut.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnBikeCheckOut.CircleSize = 100;
            this.btnBikeCheckOut.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBikeCheckOut.FillColor = System.Drawing.Color.White;
            this.btnBikeCheckOut.FillDisableColor = System.Drawing.Color.White;
            this.btnBikeCheckOut.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnBikeCheckOut.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnBikeCheckOut.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnBikeCheckOut.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBikeCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnBikeCheckOut.Location = new System.Drawing.Point(709, 466);
            this.btnBikeCheckOut.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.btnBikeCheckOut.MaximumSize = new System.Drawing.Size(333, 308);
            this.btnBikeCheckOut.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnBikeCheckOut.Name = "btnBikeCheckOut";
            this.btnBikeCheckOut.Padding = new System.Windows.Forms.Padding(67, 62, 67, 62);
            this.btnBikeCheckOut.Radius = 14;
            this.btnBikeCheckOut.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btnBikeCheckOut.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnBikeCheckOut.RectSize = 2;
            this.btnBikeCheckOut.Size = new System.Drawing.Size(333, 308);
            this.btnBikeCheckOut.Symbol = 559834;
            this.btnBikeCheckOut.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnBikeCheckOut.SymbolSize = 72;
            this.btnBikeCheckOut.TabIndex = 4;
            this.btnBikeCheckOut.Text = "Check out";
            this.btnBikeCheckOut.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBikeCheckOut.TipsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnBikeCheckOut.Click += new System.EventHandler(this.btnBikeCheckOut_Click);
            // 
            // btnCarCheckOut
            // 
            this.btnCarCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCarCheckOut.CircleColor = System.Drawing.Color.White;
            this.btnCarCheckOut.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCarCheckOut.CircleSize = 100;
            this.btnCarCheckOut.FillColor = System.Drawing.Color.White;
            this.btnCarCheckOut.FillDisableColor = System.Drawing.Color.White;
            this.btnCarCheckOut.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCarCheckOut.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCarCheckOut.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCarCheckOut.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCarCheckOut.Location = new System.Drawing.Point(709, 108);
            this.btnCarCheckOut.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.btnCarCheckOut.MaximumSize = new System.Drawing.Size(333, 308);
            this.btnCarCheckOut.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCarCheckOut.Name = "btnCarCheckOut";
            this.btnCarCheckOut.Padding = new System.Windows.Forms.Padding(67, 62, 67, 62);
            this.btnCarCheckOut.Radius = 14;
            this.btnCarCheckOut.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btnCarCheckOut.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnCarCheckOut.RectSize = 2;
            this.btnCarCheckOut.Size = new System.Drawing.Size(333, 308);
            this.btnCarCheckOut.Symbol = 361881;
            this.btnCarCheckOut.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCarCheckOut.SymbolOffset = new System.Drawing.Point(-5, 0);
            this.btnCarCheckOut.SymbolSize = 72;
            this.btnCarCheckOut.TabIndex = 3;
            this.btnCarCheckOut.Text = "Check out";
            this.btnCarCheckOut.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCarCheckOut.TipsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCarCheckOut.Click += new System.EventHandler(this.btnCarCheckOut_Click);
            // 
            // btnCarCheckIn
            // 
            this.btnCarCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarCheckIn.CircleColor = System.Drawing.Color.White;
            this.btnCarCheckIn.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCarCheckIn.CircleSize = 100;
            this.btnCarCheckIn.FillColor = System.Drawing.Color.White;
            this.btnCarCheckIn.FillDisableColor = System.Drawing.Color.White;
            this.btnCarCheckIn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCarCheckIn.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCarCheckIn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCarCheckIn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCarCheckIn.Location = new System.Drawing.Point(322, 108);
            this.btnCarCheckIn.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.btnCarCheckIn.MaximumSize = new System.Drawing.Size(333, 308);
            this.btnCarCheckIn.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCarCheckIn.Name = "btnCarCheckIn";
            this.btnCarCheckIn.Padding = new System.Windows.Forms.Padding(67, 62, 67, 62);
            this.btnCarCheckIn.Radius = 14;
            this.btnCarCheckIn.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btnCarCheckIn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnCarCheckIn.RectSize = 2;
            this.btnCarCheckIn.Size = new System.Drawing.Size(333, 308);
            this.btnCarCheckIn.Symbol = 362942;
            this.btnCarCheckIn.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCarCheckIn.SymbolOffset = new System.Drawing.Point(-5, 0);
            this.btnCarCheckIn.SymbolSize = 72;
            this.btnCarCheckIn.TabIndex = 2;
            this.btnCarCheckIn.Text = "Check in";
            this.btnCarCheckIn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCarCheckIn.TipsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.btnCarCheckIn.Click += new System.EventHandler(this.btnCarCheckIn_Click);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ScanningControl";
            this.Size = new System.Drawing.Size(1365, 882);
            this.Load += new System.EventHandler(this.ScanningControl_Load);
            this.Resize += new System.EventHandler(this.ScanningControl_Resize);
            this.panel2.ResumeLayout(false);
            this.uiTableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UIHeaderButton btnBikeCheckIn;
        private Sunny.UI.UIHeaderButton btnBikeCheckOut;
        private Sunny.UI.UIHeaderButton btnCarCheckOut;
        private Sunny.UI.UIHeaderButton btnCarCheckIn;
    }
}
