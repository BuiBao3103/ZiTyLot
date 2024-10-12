using System.Windows.Forms;

namespace ZiTyLot.GUI.Screens
{
    partial class ScanningScreen
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
            this.uiHeaderButton2 = new Sunny.UI.UIHeaderButton();
            this.uiHeaderButton1 = new Sunny.UI.UIHeaderButton();
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
            this.uiPanel1.Controls.Add(this.uiHeaderButton2);
            this.uiPanel1.Controls.Add(this.uiHeaderButton1);
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
            // uiHeaderButton2
            // 
            this.uiHeaderButton2.CircleColor = System.Drawing.Color.White;
            this.uiHeaderButton2.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.uiHeaderButton2.CircleSize = 100;
            this.uiHeaderButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiHeaderButton2.FillColor = System.Drawing.Color.White;
            this.uiHeaderButton2.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.uiHeaderButton2.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.uiHeaderButton2.FillSelectedColor = System.Drawing.Color.White;
            this.uiHeaderButton2.Font = new System.Drawing.Font("Helvetica Rounded", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiHeaderButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.uiHeaderButton2.Location = new System.Drawing.Point(316, 0);
            this.uiHeaderButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton2.Name = "uiHeaderButton2";
            this.uiHeaderButton2.Padding = new System.Windows.Forms.Padding(50);
            this.uiHeaderButton2.Radius = 14;
            this.uiHeaderButton2.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton2.RectSize = 2;
            this.uiHeaderButton2.Size = new System.Drawing.Size(250, 250);
            this.uiHeaderButton2.Symbol = 361579;
            this.uiHeaderButton2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.uiHeaderButton2.SymbolOffset = new System.Drawing.Point(-4, 0);
            this.uiHeaderButton2.SymbolSize = 72;
            this.uiHeaderButton2.TabIndex = 1;
            this.uiHeaderButton2.Text = "Check Out";
            this.uiHeaderButton2.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiHeaderButton2.TipsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            // 
            // uiHeaderButton1
            // 
            this.uiHeaderButton1.CircleColor = System.Drawing.Color.White;
            this.uiHeaderButton1.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.uiHeaderButton1.CircleSize = 100;
            this.uiHeaderButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiHeaderButton1.FillColor = System.Drawing.Color.White;
            this.uiHeaderButton1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.uiHeaderButton1.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.uiHeaderButton1.FillSelectedColor = System.Drawing.Color.White;
            this.uiHeaderButton1.Font = new System.Drawing.Font("Helvetica Rounded", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiHeaderButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.uiHeaderButton1.Location = new System.Drawing.Point(0, 0);
            this.uiHeaderButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton1.Name = "uiHeaderButton1";
            this.uiHeaderButton1.Padding = new System.Windows.Forms.Padding(50);
            this.uiHeaderButton1.Radius = 14;
            this.uiHeaderButton1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton1.RectSize = 2;
            this.uiHeaderButton1.Size = new System.Drawing.Size(250, 250);
            this.uiHeaderButton1.Symbol = 361584;
            this.uiHeaderButton1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.uiHeaderButton1.SymbolOffset = new System.Drawing.Point(-10, 0);
            this.uiHeaderButton1.SymbolSize = 72;
            this.uiHeaderButton1.TabIndex = 0;
            this.uiHeaderButton1.Text = "Check in";
            this.uiHeaderButton1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiHeaderButton1.TipsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
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
            // ScanningScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(54)))));
            this.Name = "ScanningScreen";
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
        private Sunny.UI.UIHeaderButton uiHeaderButton1;
        private Sunny.UI.UIHeaderButton uiHeaderButton2;
    }
}
