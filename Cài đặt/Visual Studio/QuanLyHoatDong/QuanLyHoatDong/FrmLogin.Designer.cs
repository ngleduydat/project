namespace QuanLyHoatDong
{
    partial class FrmLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdAD = new System.Windows.Forms.RadioButton();
            this.rdDVQL = new System.Windows.Forms.RadioButton();
            this.rdBTC = new System.Windows.Forms.RadioButton();
            this.rdSV = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtuserName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(47, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdAD);
            this.groupBox1.Controls.Add(this.rdDVQL);
            this.groupBox1.Controls.Add(this.rdBTC);
            this.groupBox1.Controls.Add(this.rdSV);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(51, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 117);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Người Dùng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdAD
            // 
            this.rdAD.AutoSize = true;
            this.rdAD.Location = new System.Drawing.Point(35, 77);
            this.rdAD.Name = "rdAD";
            this.rdAD.Size = new System.Drawing.Size(76, 23);
            this.rdAD.TabIndex = 3;
            this.rdAD.TabStop = true;
            this.rdAD.Text = "Admin";
            this.rdAD.UseVisualStyleBackColor = true;
            this.rdAD.CheckedChanged += new System.EventHandler(this.rdAD_CheckedChanged);
            // 
            // rdDVQL
            // 
            this.rdDVQL.AutoSize = true;
            this.rdDVQL.Location = new System.Drawing.Point(179, 77);
            this.rdDVQL.Name = "rdDVQL";
            this.rdDVQL.Size = new System.Drawing.Size(144, 23);
            this.rdDVQL.TabIndex = 2;
            this.rdDVQL.TabStop = true;
            this.rdDVQL.Text = "Đơn Vị Quản Lý";
            this.rdDVQL.UseVisualStyleBackColor = true;
            this.rdDVQL.CheckedChanged += new System.EventHandler(this.rdDVQL_CheckedChanged);
            // 
            // rdBTC
            // 
            this.rdBTC.AutoSize = true;
            this.rdBTC.Location = new System.Drawing.Point(179, 39);
            this.rdBTC.Name = "rdBTC";
            this.rdBTC.Size = new System.Drawing.Size(122, 23);
            this.rdBTC.TabIndex = 1;
            this.rdBTC.TabStop = true;
            this.rdBTC.Text = "Ban Tổ Chức";
            this.rdBTC.UseVisualStyleBackColor = true;
            this.rdBTC.CheckedChanged += new System.EventHandler(this.rdBTC_CheckedChanged);
            // 
            // rdSV
            // 
            this.rdSV.AutoSize = true;
            this.rdSV.Location = new System.Drawing.Point(35, 39);
            this.rdSV.Name = "rdSV";
            this.rdSV.Size = new System.Drawing.Size(95, 23);
            this.rdSV.TabIndex = 0;
            this.rdSV.TabStop = true;
            this.rdSV.Text = "Sinh viên";
            this.rdSV.UseVisualStyleBackColor = true;
            this.rdSV.CheckedChanged += new System.EventHandler(this.rdSV_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(51, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Đăng Nhập";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(51, 505);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(358, 33);
            this.button4.TabIndex = 7;
            this.button4.Text = "Giới Thiệu";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(252, 457);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 33);
            this.button5.TabIndex = 13;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnExit_Login);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(47, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên Đăng Nhập:";
            // 
            // txtPassWord
            // 
            this.txtPassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassWord.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.Location = new System.Drawing.Point(51, 264);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(358, 29);
            this.txtPassWord.TabIndex = 15;
            this.txtPassWord.TextChanged += new System.EventHandler(this.txtPassWord_TextChanged);
            // 
            // txtuserName
            // 
            this.txtuserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtuserName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserName.Location = new System.Drawing.Point(51, 166);
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.Size = new System.Drawing.Size(358, 29);
            this.txtuserName.TabIndex = 17;
            this.txtuserName.TextChanged += new System.EventHandler(this.txtuserName_TextChanged);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 566);
            this.Controls.Add(this.txtuserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdSV;
        private System.Windows.Forms.RadioButton rdAD;
        private System.Windows.Forms.RadioButton rdDVQL;
        private System.Windows.Forms.RadioButton rdBTC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtuserName;
    }
}