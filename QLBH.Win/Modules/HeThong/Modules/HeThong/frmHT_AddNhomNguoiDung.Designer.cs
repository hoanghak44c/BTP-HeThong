namespace QLBanHang.Modules.HeThong
{
    partial class frmHT_AddNhomNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHT_AddNhomNguoiDung));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboNhomQuyen = new System.Windows.Forms.ComboBox();
            this.chkDieuChuyenKhacTrungTam = new System.Windows.Forms.CheckBox();
            this.chkOnlyTon = new System.Windows.Forms.CheckBox();
            this.chkShowNotify = new System.Windows.Forms.CheckBox();
            this.chkXemBaoCao = new System.Windows.Forms.CheckBox();
            this.chkSaleAdmin = new System.Windows.Forms.CheckBox();
            this.chkSuaChungTu = new System.Windows.Forms.CheckBox();
            this.chkQuanTri = new System.Windows.Forms.CheckBox();
            this.chkSuDung = new System.Windows.Forms.CheckBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.txtMaNhom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cboNhomQuyen);
            this.groupBox3.Controls.Add(this.chkDieuChuyenKhacTrungTam);
            this.groupBox3.Controls.Add(this.chkOnlyTon);
            this.groupBox3.Controls.Add(this.chkShowNotify);
            this.groupBox3.Controls.Add(this.chkXemBaoCao);
            this.groupBox3.Controls.Add(this.chkSaleAdmin);
            this.groupBox3.Controls.Add(this.chkSuaChungTu);
            this.groupBox3.Controls.Add(this.chkQuanTri);
            this.groupBox3.Controls.Add(this.chkSuDung);
            this.groupBox3.Controls.Add(this.txtMoTa);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtTenNhom);
            this.groupBox3.Controls.Add(this.txtMaNhom);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 6);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBox3.Size = new System.Drawing.Size(471, 352);
            this.groupBox3.TabIndex = 132;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 145;
            this.label1.Text = "Nhóm quyền";
            // 
            // cboNhomQuyen
            // 
            this.cboNhomQuyen.FormattingEnabled = true;
            this.cboNhomQuyen.Items.AddRange(new object[] {
            "Tất cả",
            "Không hoạt động",
            "Đang hoạt động"});
            this.cboNhomQuyen.Location = new System.Drawing.Point(93, 74);
            this.cboNhomQuyen.Name = "cboNhomQuyen";
            this.cboNhomQuyen.Size = new System.Drawing.Size(372, 24);
            this.cboNhomQuyen.TabIndex = 144;
            // 
            // chkDieuChuyenKhacTrungTam
            // 
            this.chkDieuChuyenKhacTrungTam.AutoSize = true;
            this.chkDieuChuyenKhacTrungTam.Location = new System.Drawing.Point(95, 326);
            this.chkDieuChuyenKhacTrungTam.Name = "chkDieuChuyenKhacTrungTam";
            this.chkDieuChuyenKhacTrungTam.Size = new System.Drawing.Size(190, 20);
            this.chkDieuChuyenKhacTrungTam.TabIndex = 13;
            this.chkDieuChuyenKhacTrungTam.Text = "Điều chuyển khác trung tâm";
            this.chkDieuChuyenKhacTrungTam.UseVisualStyleBackColor = true;
            // 
            // chkOnlyTon
            // 
            this.chkOnlyTon.AutoSize = true;
            this.chkOnlyTon.Location = new System.Drawing.Point(95, 277);
            this.chkOnlyTon.Name = "chkOnlyTon";
            this.chkOnlyTon.Size = new System.Drawing.Size(202, 20);
            this.chkOnlyTon.TabIndex = 12;
            this.chkOnlyTon.Text = "Chỉ xem tồn trung tâm hiện tại";
            this.chkOnlyTon.UseVisualStyleBackColor = true;
            // 
            // chkShowNotify
            // 
            this.chkShowNotify.AutoSize = true;
            this.chkShowNotify.Location = new System.Drawing.Point(95, 300);
            this.chkShowNotify.Name = "chkShowNotify";
            this.chkShowNotify.Size = new System.Drawing.Size(203, 20);
            this.chkShowNotify.TabIndex = 11;
            this.chkShowNotify.Text = "Hiển thị cảnh báo trên Taskbar";
            this.chkShowNotify.UseVisualStyleBackColor = true;
            // 
            // chkXemBaoCao
            // 
            this.chkXemBaoCao.AutoSize = true;
            this.chkXemBaoCao.Location = new System.Drawing.Point(95, 255);
            this.chkXemBaoCao.Name = "chkXemBaoCao";
            this.chkXemBaoCao.Size = new System.Drawing.Size(369, 20);
            this.chkXemBaoCao.TabIndex = 10;
            this.chkXemBaoCao.Text = "Xem báo cáo chung (xem báo cáo của các trung tâm khác)";
            this.chkXemBaoCao.UseVisualStyleBackColor = true;
            // 
            // chkSaleAdmin
            // 
            this.chkSaleAdmin.AutoSize = true;
            this.chkSaleAdmin.Location = new System.Drawing.Point(95, 233);
            this.chkSaleAdmin.Name = "chkSaleAdmin";
            this.chkSaleAdmin.Size = new System.Drawing.Size(300, 20);
            this.chkSaleAdmin.TabIndex = 9;
            this.chkSaleAdmin.Text = "Sale Admin (được chọn toàn bộ các trung tâm)";
            this.chkSaleAdmin.UseVisualStyleBackColor = true;
            // 
            // chkSuaChungTu
            // 
            this.chkSuaChungTu.AutoSize = true;
            this.chkSuaChungTu.Location = new System.Drawing.Point(95, 211);
            this.chkSuaChungTu.Name = "chkSuaChungTu";
            this.chkSuaChungTu.Size = new System.Drawing.Size(164, 20);
            this.chkSuaChungTu.TabIndex = 8;
            this.chkSuaChungTu.Text = "Sửa thông tin chứng từ";
            this.chkSuaChungTu.UseVisualStyleBackColor = true;
            // 
            // chkQuanTri
            // 
            this.chkQuanTri.AutoSize = true;
            this.chkQuanTri.Location = new System.Drawing.Point(95, 189);
            this.chkQuanTri.Name = "chkQuanTri";
            this.chkQuanTri.Size = new System.Drawing.Size(363, 20);
            this.chkQuanTri.TabIndex = 7;
            this.chkQuanTri.Text = "Làm việc với nhiều trung tâm (được chọn nhiều trung tâm)";
            this.chkQuanTri.UseVisualStyleBackColor = true;
            // 
            // chkSuDung
            // 
            this.chkSuDung.AutoSize = true;
            this.chkSuDung.Location = new System.Drawing.Point(257, 17);
            this.chkSuDung.Name = "chkSuDung";
            this.chkSuDung.Size = new System.Drawing.Size(77, 20);
            this.chkSuDung.TabIndex = 6;
            this.chkSuDung.Text = "Sử dụng";
            this.chkSuDung.UseVisualStyleBackColor = true;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(93, 106);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(372, 76);
            this.txtMoTa.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mô tả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên nhóm";
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Location = new System.Drawing.Point(93, 44);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(372, 22);
            this.txtTenNhom.TabIndex = 2;
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.Location = new System.Drawing.Point(93, 16);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.Size = new System.Drawing.Size(149, 22);
            this.txtMaNhom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhóm";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(203, 367);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 25);
            this.btnDelete.TabIndex = 140;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(293, 367);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 25);
            this.btnClose.TabIndex = 141;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(113, 367);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 25);
            this.btnSave.TabIndex = 139;
            this.btnSave.Text = "&Cập nhật";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmHT_AddNhomNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 398);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHT_AddNhomNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật nhóm người dùng";
            this.Load += new System.EventHandler(this.frmHT_AddNhomNguoiDung_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.TextBox txtMaNhom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkSuDung;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.CheckBox chkQuanTri;
        private System.Windows.Forms.CheckBox chkSuaChungTu;
        private System.Windows.Forms.CheckBox chkSaleAdmin;
        private System.Windows.Forms.CheckBox chkXemBaoCao;
        private System.Windows.Forms.CheckBox chkShowNotify;
        private System.Windows.Forms.CheckBox chkOnlyTon;
        private System.Windows.Forms.CheckBox chkDieuChuyenKhacTrungTam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNhomQuyen;
    }
}