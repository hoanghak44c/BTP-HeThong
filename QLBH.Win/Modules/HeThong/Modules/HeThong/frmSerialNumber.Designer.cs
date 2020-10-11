using QLBH.Core.Form;

namespace QLBanHang.Modules.HeThong
{
    partial class frmSerialNumber
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaCap = new GtidTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaMay = new GtidTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDangKy = new GtidButton();
            this.btnDong = new GtidButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCDKey = new GtidTextBox();
            this.txtHDDSerial = new GtidTextBox();
            this.btnOver = new GtidButton();
            this.btnRegister = new GtidButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new GtidButton();
            this.button1 = new GtidButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaCap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaMay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtMaCap
            // 
            this.txtMaCap.Location = new System.Drawing.Point(107, 52);
            this.txtMaCap.Multiline = true;
            this.txtMaCap.Name = "txtMaCap";
            this.txtMaCap.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMaCap.Size = new System.Drawing.Size(263, 48);
            this.txtMaCap.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã cấp cho máy";
            // 
            // txtMaMay
            // 
            this.txtMaMay.Location = new System.Drawing.Point(108, 24);
            this.txtMaMay.Name = "txtMaMay";
            this.txtMaMay.Size = new System.Drawing.Size(263, 20);
            this.txtMaMay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã máy sử dụng";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(20, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 42);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đăng ký sử dụng chương trình";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(127, 186);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(78, 25);
            this.btnDangKy.TabIndex = 2;
            this.btnDangKy.Text = "Đăng &ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(205, 186);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(78, 25);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(60, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(291, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Đăng ký sử dụng chương trình";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCDKey
            // 
            this.txtCDKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCDKey.Location = new System.Drawing.Point(101, 90);
            this.txtCDKey.Multiline = true;
            this.txtCDKey.Name = "txtCDKey";
            this.txtCDKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCDKey.Size = new System.Drawing.Size(259, 49);
            this.txtCDKey.TabIndex = 29;
            // 
            // txtHDDSerial
            // 
            this.txtHDDSerial.BackColor = System.Drawing.Color.White;
            this.txtHDDSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHDDSerial.Location = new System.Drawing.Point(101, 63);
            this.txtHDDSerial.Name = "txtHDDSerial";
            this.txtHDDSerial.ReadOnly = true;
            this.txtHDDSerial.Size = new System.Drawing.Size(259, 22);
            this.txtHDDSerial.TabIndex = 28;
            // 
            // btnOver
            // 
            this.btnOver.Location = new System.Drawing.Point(176, 155);
            this.btnOver.Name = "btnOver";
            this.btnOver.Size = new System.Drawing.Size(70, 24);
            this.btnOver.TabIndex = 27;
            this.btnOver.Text = "&Bỏ qua";
            this.btnOver.UseVisualStyleBackColor = true;
            this.btnOver.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(106, 155);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(70, 24);
            this.btnRegister.TabIndex = 26;
            this.btnRegister.Text = "&Đăng ký";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mã máy sử dụng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Mã cấp cho máy";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(248, 155);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 24);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "&Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 24);
            this.button1.TabIndex = 31;
            this.button1.Text = "Tao key";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmSerialNumber
            // 
            this.ClientSize = new System.Drawing.Size(374, 190);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtCDKey);
            this.Controls.Add(this.txtHDDSerial);
            this.Controls.Add(this.btnOver);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.MaximizeBox = false;
            this.Name = "frmSerialNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký sử dụng chương trình";
            this.Load += new System.EventHandler(this.frmSerialNumber_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaCap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaMay;
        private System.Windows.Forms.Label label3;
        private QLBH.Core.Form.GtidButton btnDangKy;
        private QLBH.Core.Form.GtidButton btnDong;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtCDKey;
        internal System.Windows.Forms.TextBox txtHDDSerial;
        internal QLBH.Core.Form.GtidButton btnOver;
        internal QLBH.Core.Form.GtidButton btnRegister;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal QLBH.Core.Form.GtidButton btnClose;
        private QLBH.Core.Form.GtidButton button1;
    }
}