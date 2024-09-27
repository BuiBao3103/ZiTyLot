namespace ZiTyLot.GUI
{
    partial class Login
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.inputPasswordLabel = new System.Windows.Forms.Label();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.inputUsernameLabel = new System.Windows.Forms.Label();
            this.inputUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.pnlUsername.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(396, 444);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(376, 67);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.pnlPassword);
            this.panel3.Controls.Add(this.pnlUsername);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(10, 83);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(376, 351);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.checkBox1);
            this.panel5.Controls.Add(this.btnDangNhap);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 227);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(356, 68);
            this.panel5.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(43, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 20);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Show password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(43, 38);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(0);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(269, 30);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Sign in";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.White;
            this.pnlPassword.Controls.Add(this.inputPasswordLabel);
            this.pnlPassword.Controls.Add(this.inputPassword);
            this.pnlPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPassword.Location = new System.Drawing.Point(10, 148);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Padding = new System.Windows.Forms.Padding(40, 5, 40, 5);
            this.pnlPassword.Size = new System.Drawing.Size(356, 79);
            this.pnlPassword.TabIndex = 6;
            // 
            // inputPasswordLabel
            // 
            this.inputPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.inputPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.inputPasswordLabel.Location = new System.Drawing.Point(40, 14);
            this.inputPasswordLabel.Name = "inputPasswordLabel";
            this.inputPasswordLabel.Size = new System.Drawing.Size(276, 23);
            this.inputPasswordLabel.TabIndex = 1;
            this.inputPasswordLabel.Text = "Password";
            // 
            // inputPassword
            // 
            this.inputPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.inputPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPassword.Location = new System.Drawing.Point(40, 44);
            this.inputPassword.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.inputPassword.Multiline = true;
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.PasswordChar = '*';
            this.inputPassword.Size = new System.Drawing.Size(276, 30);
            this.inputPassword.TabIndex = 2;
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.Color.White;
            this.pnlUsername.Controls.Add(this.inputUsernameLabel);
            this.pnlUsername.Controls.Add(this.inputUsername);
            this.pnlUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsername.Location = new System.Drawing.Point(10, 52);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Padding = new System.Windows.Forms.Padding(40, 5, 40, 5);
            this.pnlUsername.Size = new System.Drawing.Size(356, 96);
            this.pnlUsername.TabIndex = 7;
            // 
            // inputUsernameLabel
            // 
            this.inputUsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.inputUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.inputUsernameLabel.Location = new System.Drawing.Point(40, 31);
            this.inputUsernameLabel.Name = "inputUsernameLabel";
            this.inputUsernameLabel.Size = new System.Drawing.Size(276, 23);
            this.inputUsernameLabel.TabIndex = 1;
            this.inputUsernameLabel.Text = "Username";
            // 
            // inputUsername
            // 
            this.inputUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.inputUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputUsername.Location = new System.Drawing.Point(40, 59);
            this.inputUsername.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.inputUsername.Multiline = true;
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.Size = new System.Drawing.Size(276, 30);
            this.inputUsername.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome back";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(405, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(396, 444);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::ZiTyLot.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ZiTyLot.Properties.Resources.hero_image;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(10, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox2.Size = new System.Drawing.Size(376, 424);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Login";
            this.Text = "Login";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label inputPasswordLabel;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Label inputUsernameLabel;
        private System.Windows.Forms.TextBox inputUsername;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}