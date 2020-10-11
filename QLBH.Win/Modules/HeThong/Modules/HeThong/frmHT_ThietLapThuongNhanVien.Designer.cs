using QLBH.Core.Form;

namespace QLBanHang.Modules.HeThong
{
    partial class frmHT_ThietLapThuongNhanVien
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHT_ThietLapThuongNhanVien));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSaveCN = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnXoaNND = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddNND = new DevExpress.XtraEditors.SimpleButton();
            this.gThangDiem = new DevExpress.XtraGrid.GridControl();
            this.gvThangDiem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDiemTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiemDen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.gCachTinh = new DevExpress.XtraGrid.GridControl();
            this.gvCachTinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLinhVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViDoanhThu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrongSoDoanhThu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViLoiNhuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrongSoLoiNhuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViKhoanTon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrongSoKhoanTon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gThangDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThangDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCachTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCachTinh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnSaveCN);
            this.groupBox3.Controls.Add(this.btnDong);
            this.groupBox3.Location = new System.Drawing.Point(12, 502);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(931, 47);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            // 
            // btnSaveCN
            // 
            this.btnSaveCN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveCN.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveCN.Image")));
            this.btnSaveCN.Location = new System.Drawing.Point(746, 13);
            this.btnSaveCN.Name = "btnSaveCN";
            this.btnSaveCN.Size = new System.Drawing.Size(86, 25);
            this.btnSaveCN.TabIndex = 25;
            this.btnSaveCN.Text = "&Cập nhật";
            this.btnSaveCN.Click += new System.EventHandler(this.btnSaveCN_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(836, 13);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(86, 25);
            this.btnDong.TabIndex = 24;
            this.btnDong.Text = " T&hoát";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnXoaNND);
            this.groupBox4.Controls.Add(this.btnAddNND);
            this.groupBox4.Controls.Add(this.gThangDiem);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(15, 3);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(928, 207);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thang điểm";
            // 
            // btnXoaNND
            // 
            this.btnXoaNND.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNND.Image")));
            this.btnXoaNND.Location = new System.Drawing.Point(127, 175);
            this.btnXoaNND.Name = "btnXoaNND";
            this.btnXoaNND.Size = new System.Drawing.Size(110, 25);
            this.btnXoaNND.TabIndex = 141;
            this.btnXoaNND.Text = "&Xóa thang điểm";
            this.btnXoaNND.Click += new System.EventHandler(this.btnXoaNND_Click);
            // 
            // btnAddNND
            // 
            this.btnAddNND.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNND.Image")));
            this.btnAddNND.Location = new System.Drawing.Point(6, 175);
            this.btnAddNND.Name = "btnAddNND";
            this.btnAddNND.Size = new System.Drawing.Size(115, 25);
            this.btnAddNND.TabIndex = 140;
            this.btnAddNND.Text = "&Thêm thang điểm";
            this.btnAddNND.Click += new System.EventHandler(this.btnAddNND_Click);
            // 
            // gThangDiem
            // 
            this.gThangDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gThangDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gThangDiem.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Arial", 9.75F);
            this.gThangDiem.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gThangDiem.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gThangDiem.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gThangDiem.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gThangDiem.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gThangDiem.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gThangDiem.EmbeddedNavigator.TextStringFormat = "{0} / {1}";
            this.gThangDiem.Font = new System.Drawing.Font("Arial", 9.75F);
            this.gThangDiem.Location = new System.Drawing.Point(6, 21);
            this.gThangDiem.MainView = this.gvThangDiem;
            this.gThangDiem.Name = "gThangDiem";
            this.gThangDiem.Size = new System.Drawing.Size(916, 150);
            this.gThangDiem.TabIndex = 139;
            this.gThangDiem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThangDiem,
            this.gridView2});
            // 
            // gvThangDiem
            // 
            this.gvThangDiem.ColumnPanelRowHeight = 25;
            this.gvThangDiem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDiemTu,
            this.colDiemDen,
            this.colLoai,
            this.colGhiChu});
            this.gvThangDiem.GridControl = this.gThangDiem;
            this.gvThangDiem.Name = "gvThangDiem";
            this.gvThangDiem.OptionsSelection.MultiSelect = true;
            this.gvThangDiem.OptionsView.ShowDetailButtons = false;
            this.gvThangDiem.OptionsView.ShowGroupPanel = false;
            // 
            // colDiemTu
            // 
            this.colDiemTu.AppearanceCell.Font = new System.Drawing.Font("Arial", 9.75F);
            this.colDiemTu.AppearanceCell.Options.UseFont = true;
            this.colDiemTu.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F);
            this.colDiemTu.AppearanceHeader.Options.UseFont = true;
            this.colDiemTu.Caption = "Điểm từ";
            this.colDiemTu.FieldName = "DiemTu";
            this.colDiemTu.Name = "colDiemTu";
            this.colDiemTu.Visible = true;
            this.colDiemTu.VisibleIndex = 0;
            this.colDiemTu.Width = 107;
            // 
            // colDiemDen
            // 
            this.colDiemDen.Caption = "Điểm đến";
            this.colDiemDen.FieldName = "DiemDen";
            this.colDiemDen.Name = "colDiemDen";
            this.colDiemDen.Visible = true;
            this.colDiemDen.VisibleIndex = 1;
            this.colDiemDen.Width = 112;
            // 
            // colLoai
            // 
            this.colLoai.Caption = "Loại";
            this.colLoai.FieldName = "Loai";
            this.colLoai.Name = "colLoai";
            this.colLoai.Visible = true;
            this.colLoai.VisibleIndex = 2;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 3;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gThangDiem;
            this.gridView2.Name = "gridView2";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.gCachTinh);
            this.groupBox5.Location = new System.Drawing.Point(8, 217);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(935, 280);
            this.groupBox5.TabIndex = 49;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cách tính thưởng nhân viên";
            // 
            // gCachTinh
            // 
            this.gCachTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gCachTinh.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gCachTinh.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gCachTinh.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gCachTinh.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gCachTinh.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gCachTinh.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gCachTinh.Location = new System.Drawing.Point(7, 21);
            this.gCachTinh.MainView = this.gvCachTinh;
            this.gCachTinh.Name = "gCachTinh";
            this.gCachTinh.Size = new System.Drawing.Size(922, 253);
            this.gCachTinh.TabIndex = 28;
            this.gCachTinh.UseEmbeddedNavigator = true;
            this.gCachTinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCachTinh});
            // 
            // gvCachTinh
            // 
            this.gvCachTinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLinhVuc,
            this.colMaNganh,
            this.colTenNganh,
            this.colDonViDoanhThu,
            this.colTrongSoDoanhThu,
            this.colDonViLoiNhuan,
            this.colTrongSoLoiNhuan,
            this.colDonViKhoanTon,
            this.colTrongSoKhoanTon});
            this.gvCachTinh.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvCachTinh.GridControl = this.gCachTinh;
            this.gvCachTinh.GroupCount = 1;
            this.gvCachTinh.Name = "gvCachTinh";
            this.gvCachTinh.OptionsView.ShowDetailButtons = false;
            this.gvCachTinh.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colLinhVuc, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colLinhVuc
            // 
            this.colLinhVuc.Caption = "Lĩnh vực";
            this.colLinhVuc.FieldName = "TenLinhVuc";
            this.colLinhVuc.Name = "colLinhVuc";
            this.colLinhVuc.OptionsColumn.AllowEdit = false;
            this.colLinhVuc.OptionsColumn.AllowFocus = false;
            this.colLinhVuc.OptionsColumn.ReadOnly = true;
            // 
            // colMaNganh
            // 
            this.colMaNganh.Caption = "Mã ngành hàng";
            this.colMaNganh.FieldName = "MaNganhHang";
            this.colMaNganh.Name = "colMaNganh";
            this.colMaNganh.OptionsColumn.AllowEdit = false;
            this.colMaNganh.OptionsColumn.AllowFocus = false;
            this.colMaNganh.OptionsColumn.AllowMove = false;
            this.colMaNganh.OptionsColumn.ReadOnly = true;
            this.colMaNganh.Visible = true;
            this.colMaNganh.VisibleIndex = 0;
            this.colMaNganh.Width = 115;
            // 
            // colTenNganh
            // 
            this.colTenNganh.Caption = "Ngành hàng";
            this.colTenNganh.FieldName = "TenNganhHang";
            this.colTenNganh.Name = "colTenNganh";
            this.colTenNganh.OptionsColumn.AllowEdit = false;
            this.colTenNganh.OptionsColumn.AllowFocus = false;
            this.colTenNganh.OptionsColumn.AllowMove = false;
            this.colTenNganh.OptionsColumn.ReadOnly = true;
            this.colTenNganh.Visible = true;
            this.colTenNganh.VisibleIndex = 1;
            this.colTenNganh.Width = 234;
            // 
            // colDonViDoanhThu
            // 
            this.colDonViDoanhThu.Caption = "Đơn vị doanh thu";
            this.colDonViDoanhThu.FieldName = "DonViDoanhThu";
            this.colDonViDoanhThu.Name = "colDonViDoanhThu";
            this.colDonViDoanhThu.Visible = true;
            this.colDonViDoanhThu.VisibleIndex = 2;
            this.colDonViDoanhThu.Width = 89;
            // 
            // colTrongSoDoanhThu
            // 
            this.colTrongSoDoanhThu.Caption = "Trọng số doanh thu";
            this.colTrongSoDoanhThu.FieldName = "TrongSoDoanhThu";
            this.colTrongSoDoanhThu.Name = "colTrongSoDoanhThu";
            this.colTrongSoDoanhThu.Visible = true;
            this.colTrongSoDoanhThu.VisibleIndex = 3;
            this.colTrongSoDoanhThu.Width = 89;
            // 
            // colDonViLoiNhuan
            // 
            this.colDonViLoiNhuan.Caption = "Đơn vị lợi nhuận";
            this.colDonViLoiNhuan.FieldName = "DonViLoiNhuan";
            this.colDonViLoiNhuan.Name = "colDonViLoiNhuan";
            this.colDonViLoiNhuan.Visible = true;
            this.colDonViLoiNhuan.VisibleIndex = 4;
            this.colDonViLoiNhuan.Width = 89;
            // 
            // colTrongSoLoiNhuan
            // 
            this.colTrongSoLoiNhuan.Caption = "Trọng số lợi nhuận";
            this.colTrongSoLoiNhuan.FieldName = "TrongSoLoiNhuan";
            this.colTrongSoLoiNhuan.Name = "colTrongSoLoiNhuan";
            this.colTrongSoLoiNhuan.Visible = true;
            this.colTrongSoLoiNhuan.VisibleIndex = 5;
            this.colTrongSoLoiNhuan.Width = 89;
            // 
            // colDonViKhoanTon
            // 
            this.colDonViKhoanTon.Caption = "Đơn vị khoán tồn";
            this.colDonViKhoanTon.FieldName = "DonViKhoanTon";
            this.colDonViKhoanTon.Name = "colDonViKhoanTon";
            this.colDonViKhoanTon.Visible = true;
            this.colDonViKhoanTon.VisibleIndex = 6;
            this.colDonViKhoanTon.Width = 96;
            // 
            // colTrongSoKhoanTon
            // 
            this.colTrongSoKhoanTon.Caption = "Trọng số khoán tồn";
            this.colTrongSoKhoanTon.FieldName = "TrongSoKhoanTon";
            this.colTrongSoKhoanTon.Name = "colTrongSoKhoanTon";
            this.colTrongSoKhoanTon.Visible = true;
            this.colTrongSoKhoanTon.VisibleIndex = 7;
            this.colTrongSoKhoanTon.Width = 100;
            // 
            // frmHT_ThietLapThuongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 561);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHT_ThietLapThuongNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập chính sách thưởng nhân viên";
            this.Load += new System.EventHandler(this.frmHT_ListNhomNguoiDung_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gThangDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThangDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCachTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCachTinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraGrid.GridControl gThangDiem;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThangDiem;
        private DevExpress.XtraGrid.Columns.GridColumn colDiemTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colDiemDen;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevExpress.XtraGrid.GridControl gCachTinh;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCachTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colLinhVuc;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNganh;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNganh;
        private DevExpress.XtraEditors.SimpleButton btnSaveCN;
        private DevExpress.XtraGrid.Columns.GridColumn colDonViDoanhThu;
        private DevExpress.XtraGrid.Columns.GridColumn colTrongSoDoanhThu;
        private DevExpress.XtraGrid.Columns.GridColumn colDonViLoiNhuan;
        private DevExpress.XtraGrid.Columns.GridColumn colTrongSoLoiNhuan;
        private DevExpress.XtraGrid.Columns.GridColumn colDonViKhoanTon;
        private DevExpress.XtraGrid.Columns.GridColumn colTrongSoKhoanTon;
        private DevExpress.XtraGrid.Columns.GridColumn colLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraEditors.SimpleButton btnXoaNND;
        private DevExpress.XtraEditors.SimpleButton btnAddNND;
    }
}