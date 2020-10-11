namespace QLBanHang.Modules.HeThong
{
    partial class frmHT_AddNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHT_AddNguoiDung));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtExpiredIn = new QLBH.Core.Form.GtidTextBox();
            this.chkForceChangeOnExpired = new System.Windows.Forms.CheckBox();
            this.chkForceChangeAtFirst = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkNeverExpired = new System.Windows.Forms.CheckBox();
            this.lblNgaySuDung = new System.Windows.Forms.Label();
            this.chkSuperUser = new System.Windows.Forms.CheckBox();
            this.bteThuongVien = new DevExpress.XtraEditors.ButtonEdit();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.bteTrungTam = new DevExpress.XtraEditors.ButtonEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.chkSuDung = new System.Windows.Forms.CheckBox();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.txtRetypePassword = new QLBH.Core.Form.GtidTextBox();
            this.txtPassword = new QLBH.Core.Form.GtidTextBox();
            this.txtUserName = new QLBH.Core.Form.GtidTextBox();
            this.txtFullName = new QLBH.Core.Form.GtidTextBox();
            this.lblThuocNhom = new System.Windows.Forms.Label();
            this.lblXacNhapMatKhau = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblTenDayDu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteThuongVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtExpiredIn);
            this.groupBox3.Controls.Add(this.chkForceChangeOnExpired);
            this.groupBox3.Controls.Add(this.chkForceChangeAtFirst);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.chkNeverExpired);
            this.groupBox3.Controls.Add(this.lblNgaySuDung);
            this.groupBox3.Controls.Add(this.chkSuperUser);
            this.groupBox3.Controls.Add(this.bteThuongVien);
            this.groupBox3.Controls.Add(this.lblNhanVien);
            this.groupBox3.Controls.Add(this.bteTrungTam);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.chkSuDung);
            this.groupBox3.Controls.Add(this.cboGroup);
            this.groupBox3.Controls.Add(this.txtRetypePassword);
            this.groupBox3.Controls.Add(this.txtPassword);
            this.groupBox3.Controls.Add(this.txtUserName);
            this.groupBox3.Controls.Add(this.txtFullName);
            this.groupBox3.Controls.Add(this.lblThuocNhom);
            this.groupBox3.Controls.Add(this.lblXacNhapMatKhau);
            this.groupBox3.Controls.Add(this.lblMatKhau);
            this.groupBox3.Controls.Add(this.lblTenDangNhap);
            this.groupBox3.Controls.Add(this.lblTenDayDu);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 36);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBox3.Size = new System.Drawing.Size(404, 361);
            this.groupBox3.TabIndex = 132;
            this.groupBox3.TabStop = false;
            // 
            // txtExpiredIn
            // 
            this.txtExpiredIn.Location = new System.Drawing.Point(179, 256);
            this.txtExpiredIn.Name = "txtExpiredIn";
            this.txtExpiredIn.Size = new System.Drawing.Size(34, 22);
            this.txtExpiredIn.TabIndex = 130;
            this.txtExpiredIn.Text = "30";
            this.txtExpiredIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkForceChangeOnExpired
            // 
            this.chkForceChangeOnExpired.Location = new System.Drawing.Point(26, 256);
            this.chkForceChangeOnExpired.Name = "chkForceChangeOnExpired";
            this.chkForceChangeOnExpired.Size = new System.Drawing.Size(150, 20);
            this.chkForceChangeOnExpired.TabIndex = 136;
            this.chkForceChangeOnExpired.Text = "Hết hạn sử dụng sau";
            this.chkForceChangeOnExpired.UseVisualStyleBackColor = true;
            this.chkForceChangeOnExpired.CheckedChanged += new System.EventHandler(this.chkForceChangeOnExpired_CheckedChanged);
            // 
            // chkForceChangeAtFirst
            // 
            this.chkForceChangeAtFirst.Location = new System.Drawing.Point(26, 310);
            this.chkForceChangeAtFirst.Name = "chkForceChangeAtFirst";
            this.chkForceChangeAtFirst.Size = new System.Drawing.Size(329, 20);
            this.chkForceChangeAtFirst.TabIndex = 135;
            this.chkForceChangeAtFirst.Text = "Thay đổi ngay sau lần đăng nhập tới";
            this.chkForceChangeAtFirst.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 16);
            this.label3.TabIndex = 133;
            this.label3.Text = "Chính sách sử dụng mật khẩu:";
            // 
            // chkNeverExpired
            // 
            this.chkNeverExpired.Checked = true;
            this.chkNeverExpired.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNeverExpired.Location = new System.Drawing.Point(26, 284);
            this.chkNeverExpired.Name = "chkNeverExpired";
            this.chkNeverExpired.Size = new System.Drawing.Size(225, 20);
            this.chkNeverExpired.TabIndex = 132;
            this.chkNeverExpired.Text = "Sử dụng vô thời hạn";
            this.chkNeverExpired.UseVisualStyleBackColor = true;
            this.chkNeverExpired.CheckedChanged += new System.EventHandler(this.chkNeverExpired_CheckedChanged);
            // 
            // lblNgaySuDung
            // 
            this.lblNgaySuDung.AutoSize = true;
            this.lblNgaySuDung.Location = new System.Drawing.Point(219, 257);
            this.lblNgaySuDung.Name = "lblNgaySuDung";
            this.lblNgaySuDung.Size = new System.Drawing.Size(36, 16);
            this.lblNgaySuDung.TabIndex = 131;
            this.lblNgaySuDung.Text = "ngày";
            // 
            // chkSuperUser
            // 
            this.chkSuperUser.AutoSize = true;
            this.chkSuperUser.Enabled = false;
            this.chkSuperUser.Location = new System.Drawing.Point(212, 210);
            this.chkSuperUser.Name = "chkSuperUser";
            this.chkSuperUser.Size = new System.Drawing.Size(92, 20);
            this.chkSuperUser.TabIndex = 128;
            this.chkSuperUser.Text = "Super User";
            this.chkSuperUser.UseVisualStyleBackColor = true;
            // 
            // bteThuongVien
            // 
            this.bteThuongVien.Location = new System.Drawing.Point(106, 154);
            this.bteThuongVien.Name = "bteThuongVien";
            this.bteThuongVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteThuongVien.Size = new System.Drawing.Size(277, 20);
            this.bteThuongVien.TabIndex = 127;
            this.bteThuongVien.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteThuongVien_ButtonClick);
            this.bteThuongVien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteThuongVien_KeyDown);
            this.bteThuongVien.TextChanged += new System.EventHandler(this.bteThuongVien_TextChanged);
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNhanVien.Location = new System.Drawing.Point(10, 155);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(62, 15);
            this.lblNhanVien.TabIndex = 126;
            this.lblNhanVien.Text = "Nhân viên";
            // 
            // bteTrungTam
            // 
            this.bteTrungTam.Location = new System.Drawing.Point(106, 127);
            this.bteTrungTam.Name = "bteTrungTam";
            this.bteTrungTam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteTrungTam.Properties.Appearance.Options.UseFont = true;
            this.bteTrungTam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteTrungTam.Size = new System.Drawing.Size(277, 22);
            this.bteTrungTam.TabIndex = 125;
            this.bteTrungTam.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteTrungTam_ButtonClick);
            this.bteTrungTam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteTrungTam_KeyDown);
            this.bteTrungTam.TextChanged += new System.EventHandler(this.bteTrungTam_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 124;
            this.label2.Text = "Trung tâm";
            // 
            // chkSuDung
            // 
            this.chkSuDung.AutoSize = true;
            this.chkSuDung.Location = new System.Drawing.Point(106, 210);
            this.chkSuDung.Name = "chkSuDung";
            this.chkSuDung.Size = new System.Drawing.Size(77, 20);
            this.chkSuDung.TabIndex = 42;
            this.chkSuDung.Text = "Sử dụng";
            this.chkSuDung.UseVisualStyleBackColor = true;
            // 
            // cboGroup
            // 
            this.cboGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Location = new System.Drawing.Point(106, 180);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(277, 24);
            this.cboGroup.TabIndex = 41;
            // 
            // txtRetypePassword
            // 
            this.txtRetypePassword.Location = new System.Drawing.Point(106, 100);
            this.txtRetypePassword.Name = "txtRetypePassword";
            this.txtRetypePassword.PasswordChar = '*';
            this.txtRetypePassword.Size = new System.Drawing.Size(277, 22);
            this.txtRetypePassword.TabIndex = 39;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(106, 75);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(277, 22);
            this.txtPassword.TabIndex = 38;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(106, 50);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(277, 22);
            this.txtUserName.TabIndex = 37;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(106, 24);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(277, 22);
            this.txtFullName.TabIndex = 36;
            // 
            // lblThuocNhom
            // 
            this.lblThuocNhom.AutoSize = true;
            this.lblThuocNhom.Location = new System.Drawing.Point(10, 183);
            this.lblThuocNhom.Name = "lblThuocNhom";
            this.lblThuocNhom.Size = new System.Drawing.Size(79, 16);
            this.lblThuocNhom.TabIndex = 34;
            this.lblThuocNhom.Text = "Thuộc nhóm";
            // 
            // lblXacNhapMatKhau
            // 
            this.lblXacNhapMatKhau.AutoSize = true;
            this.lblXacNhapMatKhau.Location = new System.Drawing.Point(10, 103);
            this.lblXacNhapMatKhau.Name = "lblXacNhapMatKhau";
            this.lblXacNhapMatKhau.Size = new System.Drawing.Size(89, 16);
            this.lblXacNhapMatKhau.TabIndex = 33;
            this.lblXacNhapMatKhau.Text = "Xác nhận MK ";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(10, 78);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(62, 16);
            this.lblMatKhau.TabIndex = 32;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(10, 52);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(93, 16);
            this.lblTenDangNhap.TabIndex = 31;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lblTenDayDu
            // 
            this.lblTenDayDu.AutoSize = true;
            this.lblTenDayDu.Location = new System.Drawing.Point(10, 27);
            this.lblTenDayDu.Name = "lblTenDayDu";
            this.lblTenDayDu.Size = new System.Drawing.Size(72, 16);
            this.lblTenDayDu.TabIndex = 30;
            this.lblTenDayDu.Text = "Tên đầy đủ";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(15, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(368, 97);
            this.label4.TabIndex = 134;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTieuDe.Location = new System.Drawing.Point(50, 6);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(318, 24);
            this.lblTieuDe.TabIndex = 133;
            this.lblTieuDe.Text = "CHI TIẾT TÀI KHOẢN NGƯỜI DÙNG";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(82, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 25);
            this.btnSave.TabIndex = 137;
            this.btnSave.Text = "&Cập nhật";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(266, 406);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 25);
            this.btnClose.TabIndex = 138;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(174, 406);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 25);
            this.btnDelete.TabIndex = 137;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmHT_AddNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 455);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHT_AddNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật tài khoản người dùng";
            this.Load += new System.EventHandler(this.frmHT_AddNguoiDung_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteThuongVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.ComboBox cboGroup;
        private QLBH.Core.Form.GtidTextBox txtRetypePassword;
        private QLBH.Core.Form.GtidTextBox txtPassword;
        private QLBH.Core.Form.GtidTextBox txtUserName;
        private QLBH.Core.Form.GtidTextBox txtFullName;
        private System.Windows.Forms.Label lblThuocNhom;
        private System.Windows.Forms.Label lblXacNhapMatKhau;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblTenDayDu;
        private System.Windows.Forms.CheckBox chkSuDung;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        internal System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ButtonEdit bteThuongVien;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.CheckBox chkSuperUser;
        private System.Windows.Forms.CheckBox chkNeverExpired;
        private System.Windows.Forms.Label lblNgaySuDung;
        private QLBH.Core.Form.GtidTextBox txtExpiredIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkForceChangeAtFirst;
        private System.Windows.Forms.CheckBox chkForceChangeOnExpired;
    }
}