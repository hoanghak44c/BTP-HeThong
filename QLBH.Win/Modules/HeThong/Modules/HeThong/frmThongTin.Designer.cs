using QLBH.Core.Form;

namespace QLBanHang.Modules.HeThong
{
    partial class frmThongTin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTin));
            this.label7 = new System.Windows.Forms.Label();
            this.grpThucThi = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new QLBH.Core.Form.GtidButton();
            this.btnClose = new QLBH.Core.Form.GtidButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cboChuanMaVach = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLoaiTien = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtTyleGia = new QLBH.Core.Form.GtidTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtVPGiaoDich = new QLBH.Core.Form.GtidTextBox();
            this.txtMota = new QLBH.Core.Form.GtidTextBox();
            this.txtNganHang = new QLBH.Core.Form.GtidTextBox();
            this.txtSoTaiKhoan = new QLBH.Core.Form.GtidTextBox();
            this.txtFax = new QLBH.Core.Form.GtidTextBox();
            this.txtMaSoThue = new QLBH.Core.Form.GtidTextBox();
            this.txtWebsite = new QLBH.Core.Form.GtidTextBox();
            this.txtEmail = new QLBH.Core.Form.GtidTextBox();
            this.txtDienThoai = new QLBH.Core.Form.GtidTextBox();
            this.txtDiaChi = new QLBH.Core.Form.GtidTextBox();
            this.txtTenDoanhNghiep = new QLBH.Core.Form.GtidTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.grpThucThi.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(128, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "THAM SỐ HỆ THỐNG";
            // 
            // grpThucThi
            // 
            this.grpThucThi.Controls.Add(this.btnUpdate);
            this.grpThucThi.Controls.Add(this.btnClose);
            this.grpThucThi.ForeColor = System.Drawing.Color.Black;
            this.grpThucThi.Location = new System.Drawing.Point(13, 388);
            this.grpThucThi.Name = "grpThucThi";
            this.grpThucThi.Size = new System.Drawing.Size(463, 50);
            this.grpThucThi.TabIndex = 41;
            this.grpThucThi.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(153, 16);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnUpdate.Size = new System.Drawing.Size(80, 25);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "    &Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(237, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnClose.Size = new System.Drawing.Size(80, 25);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cboChuanMaVach);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cboLoaiTien);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.txtTyleGia);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(460, 316);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thông tin hệ thống";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "(%)";
            // 
            // cboChuanMaVach
            // 
            this.cboChuanMaVach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuanMaVach.FormattingEnabled = true;
            this.cboChuanMaVach.Items.AddRange(new object[] {
            "Code 13",
            "Code 128"});
            this.cboChuanMaVach.Location = new System.Drawing.Point(171, 201);
            this.cboChuanMaVach.Name = "cboChuanMaVach";
            this.cboChuanMaVach.Size = new System.Drawing.Size(143, 21);
            this.cboChuanMaVach.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Chuẩn mã vạch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Chênh lệch giá bán so với giá nhập (bằng 0 là không ràng buộc)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboLoaiTien
            // 
            this.cboLoaiTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiTien.FormattingEnabled = true;
            this.cboLoaiTien.Location = new System.Drawing.Point(172, 44);
            this.cboLoaiTien.Name = "cboLoaiTien";
            this.cboLoaiTien.Size = new System.Drawing.Size(143, 21);
            this.cboLoaiTien.TabIndex = 12;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(50, 47);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(117, 13);
            this.label24.TabIndex = 25;
            this.label24.Text = "Đơn vị tiền tệ mặc định";
            // 
            // txtTyleGia
            // 
            this.txtTyleGia.Location = new System.Drawing.Point(171, 140);
            this.txtTyleGia.Name = "txtTyleGia";
            this.txtTyleGia.Size = new System.Drawing.Size(84, 20);
            this.txtTyleGia.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtVPGiaoDich);
            this.tabPage1.Controls.Add(this.txtMota);
            this.tabPage1.Controls.Add(this.txtNganHang);
            this.tabPage1.Controls.Add(this.txtSoTaiKhoan);
            this.tabPage1.Controls.Add(this.txtFax);
            this.tabPage1.Controls.Add(this.txtMaSoThue);
            this.tabPage1.Controls.Add(this.txtWebsite);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.txtDienThoai);
            this.tabPage1.Controls.Add(this.txtDiaChi);
            this.tabPage1.Controls.Add(this.txtTenDoanhNghiep);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(460, 316);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin doanh nghiệp";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtVPGiaoDich
            // 
            this.txtVPGiaoDich.Location = new System.Drawing.Point(110, 70);
            this.txtVPGiaoDich.Name = "txtVPGiaoDich";
            this.txtVPGiaoDich.Size = new System.Drawing.Size(335, 20);
            this.txtVPGiaoDich.TabIndex = 3;
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(110, 255);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(336, 45);
            this.txtMota.TabIndex = 11;
            // 
            // txtNganHang
            // 
            this.txtNganHang.Location = new System.Drawing.Point(110, 228);
            this.txtNganHang.Name = "txtNganHang";
            this.txtNganHang.Size = new System.Drawing.Size(336, 20);
            this.txtNganHang.TabIndex = 10;
            // 
            // txtSoTaiKhoan
            // 
            this.txtSoTaiKhoan.Location = new System.Drawing.Point(110, 201);
            this.txtSoTaiKhoan.Name = "txtSoTaiKhoan";
            this.txtSoTaiKhoan.Size = new System.Drawing.Size(336, 20);
            this.txtSoTaiKhoan.TabIndex = 9;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(333, 97);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(113, 20);
            this.txtFax.TabIndex = 5;
            // 
            // txtMaSoThue
            // 
            this.txtMaSoThue.Location = new System.Drawing.Point(110, 175);
            this.txtMaSoThue.Name = "txtMaSoThue";
            this.txtMaSoThue.Size = new System.Drawing.Size(336, 20);
            this.txtMaSoThue.TabIndex = 8;
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(110, 149);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(336, 20);
            this.txtWebsite.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(110, 123);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(336, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(110, 97);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(174, 20);
            this.txtDienThoai.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(110, 44);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(336, 20);
            this.txtDiaChi.TabIndex = 2;
            // 
            // txtTenDoanhNghiep
            // 
            this.txtTenDoanhNghiep.Location = new System.Drawing.Point(110, 18);
            this.txtTenDoanhNghiep.Name = "txtTenDoanhNghiep";
            this.txtTenDoanhNghiep.Size = new System.Drawing.Size(336, 20);
            this.txtTenDoanhNghiep.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "VP Giao dịch";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 257);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 42;
            this.label14.Text = "Mô tả";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 230);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Ngân hàng";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 204);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Số tài khoản";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(290, 100);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "Fax";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 180);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "Mã số thuế";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 154);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 13);
            this.label19.TabIndex = 28;
            this.label19.Text = "Website";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 130);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 13);
            this.label20.TabIndex = 27;
            this.label20.Text = "Email";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 101);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 13);
            this.label21.TabIndex = 26;
            this.label21.Text = "Điện thoại";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 21);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 13);
            this.label22.TabIndex = 25;
            this.label22.Text = "Tên doanh nghiệp";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 48);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(40, 13);
            this.label23.TabIndex = 24;
            this.label23.Text = "Địa chỉ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(468, 342);
            this.tabControl1.TabIndex = 0;
            // 
            // frmThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 444);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grpThucThi);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThongTin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập tham số hệ thống";
            this.Load += new System.EventHandler(this.frmThongTin_Load);
            this.grpThucThi.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        internal QLBH.Core.Form.GtidButton btnClose;
        internal QLBH.Core.Form.GtidButton btnUpdate;
        private System.Windows.Forms.GroupBox grpThucThi;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cboLoaiTien;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboChuanMaVach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private GtidTextBox txtVPGiaoDich;
        private GtidTextBox txtMota;
        private GtidTextBox txtNganHang;
        private GtidTextBox txtSoTaiKhoan;
        private GtidTextBox txtFax;
        private GtidTextBox txtMaSoThue;
        private GtidTextBox txtWebsite;
        private GtidTextBox txtEmail;
        private GtidTextBox txtDienThoai;
        private GtidTextBox txtDiaChi;
        private GtidTextBox txtTenDoanhNghiep;
        private GtidTextBox txtTyleGia;
    }
}