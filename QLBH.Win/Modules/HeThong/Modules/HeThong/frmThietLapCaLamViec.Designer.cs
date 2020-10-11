using QLBH.Core.Form;

namespace QLBanHang.Modules.HeThong
{
    partial class frmThietLapCaLamViec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThietLapCaLamViec));
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtNgayLamViec = new System.Windows.Forms.DateTimePicker();
            this.lueFormMacDinh = new DevExpress.XtraEditors.LookUpEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bteThoiHanThanhToan = new DevExpress.XtraEditors.ButtonEdit();
            this.bteThuNgan = new DevExpress.XtraEditors.ButtonEdit();
            this.bteTruongCa = new DevExpress.XtraEditors.ButtonEdit();
            this.label39 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.bteKhachHang = new DevExpress.XtraEditors.ButtonEdit();
            this.bteKhoXuat = new DevExpress.XtraEditors.ButtonEdit();
            this.bteTrungTam = new DevExpress.XtraEditors.ButtonEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCurrentLoaiDT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new QLBH.Core.Form.GtidButton();
            this.btnClose = new QLBH.Core.Form.GtidButton();
            this.grpThucThi = new System.Windows.Forms.GroupBox();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueFormMacDinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteThoiHanThanhToan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteThuNgan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTruongCa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
            this.grpThucThi.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Label1.Location = new System.Drawing.Point(69, 53);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(51, 15);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Tên kho";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.label7);
            this.GroupBox1.Controls.Add(this.dtNgayLamViec);
            this.GroupBox1.Controls.Add(this.lueFormMacDinh);
            this.GroupBox1.Controls.Add(this.label6);
            this.GroupBox1.Controls.Add(this.label5);
            this.GroupBox1.Controls.Add(this.bteThoiHanThanhToan);
            this.GroupBox1.Controls.Add(this.bteThuNgan);
            this.GroupBox1.Controls.Add(this.bteTruongCa);
            this.GroupBox1.Controls.Add(this.label39);
            this.GroupBox1.Controls.Add(this.label30);
            this.GroupBox1.Controls.Add(this.bteKhachHang);
            this.GroupBox1.Controls.Add(this.bteKhoXuat);
            this.GroupBox1.Controls.Add(this.bteTrungTam);
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.cboCurrentLoaiDT);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(8, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(445, 265);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Thông tin ca làm việc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(37, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 137;
            this.label7.Text = "Ngày làm việc";
            // 
            // dtNgayLamViec
            // 
            this.dtNgayLamViec.CustomFormat = "dd/MM/yyyy";
            this.dtNgayLamViec.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtNgayLamViec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayLamViec.Location = new System.Drawing.Point(128, 238);
            this.dtNgayLamViec.Name = "dtNgayLamViec";
            this.dtNgayLamViec.Size = new System.Drawing.Size(91, 21);
            this.dtNgayLamViec.TabIndex = 136;
            // 
            // lueFormMacDinh
            // 
            this.lueFormMacDinh.Location = new System.Drawing.Point(128, 212);
            this.lueFormMacDinh.Name = "lueFormMacDinh";
            this.lueFormMacDinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueFormMacDinh.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaChucNang", 80, "Mã chức năng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenChucNang", 120, "Tên chức năng")});
            this.lueFormMacDinh.Properties.NullText = "";
            this.lueFormMacDinh.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lueFormMacDinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueFormMacDinh.Properties.UseCtrlScroll = true;
            this.lueFormMacDinh.Size = new System.Drawing.Size(300, 20);
            this.lueFormMacDinh.TabIndex = 135;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(6, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 134;
            this.label6.Text = "Giao diện mặc định";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(4, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 132;
            this.label5.Text = "Thời hạn thanh toán";
            // 
            // bteThoiHanThanhToan
            // 
            this.bteThoiHanThanhToan.Location = new System.Drawing.Point(128, 186);
            this.bteThoiHanThanhToan.Name = "bteThoiHanThanhToan";
            this.bteThoiHanThanhToan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteThoiHanThanhToan.Size = new System.Drawing.Size(301, 20);
            this.bteThoiHanThanhToan.TabIndex = 131;
            this.bteThoiHanThanhToan.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteThoiHanThanhToan_ButtonClick);
            this.bteThoiHanThanhToan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteThoiHanThanhToan_KeyDown);
            this.bteThoiHanThanhToan.TextChanged += new System.EventHandler(this.bteThoiHanThanhToan_TextChanged);
            // 
            // bteThuNgan
            // 
            this.bteThuNgan.Location = new System.Drawing.Point(128, 158);
            this.bteThuNgan.Name = "bteThuNgan";
            this.bteThuNgan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteThuNgan.Size = new System.Drawing.Size(301, 20);
            this.bteThuNgan.TabIndex = 127;
            this.bteThuNgan.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteThuNgan_ButtonClick);
            this.bteThuNgan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteThuNgan_KeyDown);
            this.bteThuNgan.TextChanged += new System.EventHandler(this.bteThuNgan_TextChanged);
            // 
            // bteTruongCa
            // 
            this.bteTruongCa.Location = new System.Drawing.Point(128, 133);
            this.bteTruongCa.Name = "bteTruongCa";
            this.bteTruongCa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteTruongCa.Size = new System.Drawing.Size(301, 20);
            this.bteTruongCa.TabIndex = 126;
            this.bteTruongCa.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteTruongCa_ButtonClick);
            this.bteTruongCa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteTruongCa_KeyDown);
            this.bteTruongCa.TextChanged += new System.EventHandler(this.bteTruongCa_TextChanged);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label39.Location = new System.Drawing.Point(61, 161);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(59, 15);
            this.label39.TabIndex = 129;
            this.label39.Text = "Thu ngân";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label30.Location = new System.Drawing.Point(58, 136);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(62, 15);
            this.label30.TabIndex = 128;
            this.label30.Text = "Trưởng ca";
            // 
            // bteKhachHang
            // 
            this.bteKhachHang.Location = new System.Drawing.Point(128, 105);
            this.bteKhachHang.Name = "bteKhachHang";
            this.bteKhachHang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteKhachHang.Properties.Appearance.Options.UseFont = true;
            this.bteKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteKhachHang.Size = new System.Drawing.Size(301, 22);
            this.bteKhachHang.TabIndex = 125;
            this.bteKhachHang.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteKhachHang_ButtonClick);
            this.bteKhachHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteKhachHang_KeyDown);
            this.bteKhachHang.TextChanged += new System.EventHandler(this.bteKhachHang_TextChanged);
            // 
            // bteKhoXuat
            // 
            this.bteKhoXuat.Location = new System.Drawing.Point(128, 49);
            this.bteKhoXuat.Name = "bteKhoXuat";
            this.bteKhoXuat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteKhoXuat.Properties.Appearance.Options.UseFont = true;
            this.bteKhoXuat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteKhoXuat.Size = new System.Drawing.Size(301, 22);
            this.bteKhoXuat.TabIndex = 124;
            this.bteKhoXuat.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteKhoXuat_ButtonClick);
            this.bteKhoXuat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteKhoXuat_KeyDown);
            this.bteKhoXuat.TextChanged += new System.EventHandler(this.bteKhoXuat_TextChanged);
            // 
            // bteTrungTam
            // 
            this.bteTrungTam.Location = new System.Drawing.Point(128, 22);
            this.bteTrungTam.Name = "bteTrungTam";
            this.bteTrungTam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteTrungTam.Properties.Appearance.Options.UseFont = true;
            this.bteTrungTam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteTrungTam.Size = new System.Drawing.Size(301, 22);
            this.bteTrungTam.TabIndex = 123;
            this.bteTrungTam.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteTrungTam_ButtonClick);
            this.bteTrungTam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteTrungTam_KeyDown);
            this.bteTrungTam.TextChanged += new System.EventHandler(this.bteTrungTam_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(47, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Khách hàng";
            // 
            // cboCurrentLoaiDT
            // 
            this.cboCurrentLoaiDT.FormattingEnabled = true;
            this.cboCurrentLoaiDT.Location = new System.Drawing.Point(128, 78);
            this.cboCurrentLoaiDT.Name = "cboCurrentLoaiDT";
            this.cboCurrentLoaiDT.Size = new System.Drawing.Size(301, 21);
            this.cboCurrentLoaiDT.TabIndex = 2;
            this.cboCurrentLoaiDT.SelectedIndexChanged += new System.EventHandler(this.cboCurrentLoaiDT_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(22, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Loại khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(57, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Trung tâm";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(139, 15);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnUpdate.Size = new System.Drawing.Size(80, 25);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Xác nhận";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(223, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnClose.Size = new System.Drawing.Size(80, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpThucThi
            // 
            this.grpThucThi.Controls.Add(this.btnClose);
            this.grpThucThi.Controls.Add(this.btnUpdate);
            this.grpThucThi.ForeColor = System.Drawing.Color.Black;
            this.grpThucThi.Location = new System.Drawing.Point(8, 280);
            this.grpThucThi.Name = "grpThucThi";
            this.grpThucThi.Size = new System.Drawing.Size(445, 50);
            this.grpThucThi.TabIndex = 43;
            this.grpThucThi.TabStop = false;
            // 
            // frmThietLapCaLamViec
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(461, 332);
            this.Controls.Add(this.grpThucThi);
            this.Controls.Add(this.GroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThietLapCaLamViec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khai báo ca làm việc";
            this.Load += new System.EventHandler(this.frmKhoHienTai_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKhoHienTai_FormClosed);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueFormMacDinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteThoiHanThanhToan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteThuNgan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTruongCa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteKhoXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).EndInit();
            this.grpThucThi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal GtidButton btnUpdate;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ComboBox cboCurrentLoaiDT;
        internal System.Windows.Forms.Label label3;
        internal GtidButton btnClose;
        private DevExpress.XtraEditors.ButtonEdit bteKhoXuat;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private DevExpress.XtraEditors.ButtonEdit bteKhachHang;
        private DevExpress.XtraEditors.ButtonEdit bteThuNgan;
        private DevExpress.XtraEditors.ButtonEdit bteTruongCa;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label30;
        private DevExpress.XtraEditors.ButtonEdit bteThoiHanThanhToan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpThucThi;
        internal System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.LookUpEdit lueFormMacDinh;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtNgayLamViec;
    }
}