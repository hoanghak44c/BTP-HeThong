using QLBH.Core.Form;

namespace QLBanHang.Modules.HeThong
{
    partial class frmHT_ThietLapPheDuyetGiaBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHT_ThietLapPheDuyetGiaBan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdNhomHang = new System.Windows.Forms.RadioButton();
            this.rdNhomND = new System.Windows.Forms.RadioButton();
            this.btnFilter = new DevExpress.XtraEditors.SimpleButton();
            this.txtFilterHanhDong = new QLBH.Core.Form.GtidTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSaveCN = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaNND = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddNND = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gNhomNguoiDung = new DevExpress.XtraGrid.GridControl();
            this.gvNhomNguoiDung = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdNhomNguoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDungSaiMIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDungSaiMAX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DoUuTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.gNhomSanPham = new DevExpress.XtraGrid.GridControl();
            this.gvNhomSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLinhVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gNhomNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gNhomSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdNhomHang);
            this.groupBox1.Controls.Add(this.rdNhomND);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.txtFilterHanhDong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1031, 43);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // rdNhomHang
            // 
            this.rdNhomHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdNhomHang.AutoSize = true;
            this.rdNhomHang.Location = new System.Drawing.Point(833, 15);
            this.rdNhomHang.Name = "rdNhomHang";
            this.rdNhomHang.Size = new System.Drawing.Size(83, 17);
            this.rdNhomHang.TabIndex = 53;
            this.rdNhomHang.Text = "Ngành hàng";
            this.rdNhomHang.UseVisualStyleBackColor = true;
            // 
            // rdNhomND
            // 
            this.rdNhomND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdNhomND.AutoSize = true;
            this.rdNhomND.Checked = true;
            this.rdNhomND.Location = new System.Drawing.Point(725, 15);
            this.rdNhomND.Name = "rdNhomND";
            this.rdNhomND.Size = new System.Drawing.Size(109, 17);
            this.rdNhomND.TabIndex = 51;
            this.rdNhomND.TabStop = true;
            this.rdNhomND.Text = "Nhóm người dùng";
            this.rdNhomND.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.Location = new System.Drawing.Point(928, 13);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(86, 23);
            this.btnFilter.TabIndex = 50;
            this.btnFilter.Text = "&Lọc";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilterHanhDong
            // 
            this.txtFilterHanhDong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterHanhDong.Location = new System.Drawing.Point(96, 15);
            this.txtFilterHanhDong.Name = "txtFilterHanhDong";
            this.txtFilterHanhDong.Size = new System.Drawing.Size(623, 21);
            this.txtFilterHanhDong.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hoặc tên";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnSaveCN);
            this.groupBox3.Controls.Add(this.btnDong);
            this.groupBox3.Location = new System.Drawing.Point(12, 502);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1027, 47);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            // 
            // btnSaveCN
            // 
            this.btnSaveCN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveCN.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveCN.Image")));
            this.btnSaveCN.Location = new System.Drawing.Point(842, 13);
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
            this.btnDong.Location = new System.Drawing.Point(932, 13);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(86, 25);
            this.btnDong.TabIndex = 24;
            this.btnDong.Text = " T&hoát";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoaNND
            // 
            this.btnXoaNND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoaNND.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNND.Image")));
            this.btnXoaNND.Location = new System.Drawing.Point(99, 413);
            this.btnXoaNND.Name = "btnXoaNND";
            this.btnXoaNND.Size = new System.Drawing.Size(86, 25);
            this.btnXoaNND.TabIndex = 22;
            this.btnXoaNND.Text = "&Xóa nhóm";
            this.btnXoaNND.Click += new System.EventHandler(this.btnXoaNND_Click);
            // 
            // btnAddNND
            // 
            this.btnAddNND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddNND.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNND.Image")));
            this.btnAddNND.Location = new System.Drawing.Point(7, 413);
            this.btnAddNND.Name = "btnAddNND";
            this.btnAddNND.Size = new System.Drawing.Size(86, 25);
            this.btnAddNND.TabIndex = 20;
            this.btnAddNND.Text = "&Thêm nhóm";
            this.btnAddNND.Click += new System.EventHandler(this.btnAddNND_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.gNhomNguoiDung);
            this.groupBox4.Controls.Add(this.btnXoaNND);
            this.groupBox4.Controls.Add(this.btnAddNND);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(512, 53);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(527, 445);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nhóm người dùng";
            // 
            // gNhomNguoiDung
            // 
            this.gNhomNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gNhomNguoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gNhomNguoiDung.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Arial", 9.75F);
            this.gNhomNguoiDung.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gNhomNguoiDung.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gNhomNguoiDung.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gNhomNguoiDung.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gNhomNguoiDung.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gNhomNguoiDung.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gNhomNguoiDung.EmbeddedNavigator.TextStringFormat = "{0} / {1}";
            this.gNhomNguoiDung.Font = new System.Drawing.Font("Arial", 9.75F);
            this.gNhomNguoiDung.Location = new System.Drawing.Point(6, 22);
            this.gNhomNguoiDung.MainView = this.gvNhomNguoiDung;
            this.gNhomNguoiDung.Name = "gNhomNguoiDung";
            this.gNhomNguoiDung.Size = new System.Drawing.Size(515, 385);
            this.gNhomNguoiDung.TabIndex = 139;
            this.gNhomNguoiDung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhomNguoiDung,
            this.gridView2});
            // 
            // gvNhomNguoiDung
            // 
            this.gvNhomNguoiDung.ColumnPanelRowHeight = 25;
            this.gvNhomNguoiDung.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdNhomNguoiDung,
            this.colTenNhom,
            this.colDungSaiMIN,
            this.colDungSaiMAX,
            this.DoUuTien});
            this.gvNhomNguoiDung.GridControl = this.gNhomNguoiDung;
            this.gvNhomNguoiDung.Name = "gvNhomNguoiDung";
            this.gvNhomNguoiDung.OptionsView.ShowDetailButtons = false;
            this.gvNhomNguoiDung.OptionsView.ShowGroupPanel = false;
            this.gvNhomNguoiDung.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTenNhom, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvNhomNguoiDung.DoubleClick += new System.EventHandler(this.gvNhomNguoiDung_DoubleClick);
            // 
            // colIdNhomNguoiDung
            // 
            this.colIdNhomNguoiDung.Caption = "IdNhomNguoiDung";
            this.colIdNhomNguoiDung.FieldName = "IdNhomNguoiDung";
            this.colIdNhomNguoiDung.Name = "colIdNhomNguoiDung";
            this.colIdNhomNguoiDung.OptionsColumn.AllowEdit = false;
            // 
            // colTenNhom
            // 
            this.colTenNhom.AppearanceCell.Font = new System.Drawing.Font("Arial", 9.75F);
            this.colTenNhom.AppearanceCell.Options.UseFont = true;
            this.colTenNhom.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F);
            this.colTenNhom.AppearanceHeader.Options.UseFont = true;
            this.colTenNhom.Caption = "Tên nhóm";
            this.colTenNhom.FieldName = "NhomNguoiDung";
            this.colTenNhom.Name = "colTenNhom";
            this.colTenNhom.OptionsColumn.AllowEdit = false;
            this.colTenNhom.OptionsColumn.AllowFocus = false;
            this.colTenNhom.OptionsColumn.AllowMove = false;
            this.colTenNhom.OptionsColumn.FixedWidth = true;
            this.colTenNhom.OptionsColumn.ReadOnly = true;
            this.colTenNhom.Visible = true;
            this.colTenNhom.VisibleIndex = 0;
            this.colTenNhom.Width = 257;
            // 
            // colDungSaiMIN
            // 
            this.colDungSaiMIN.AppearanceCell.Font = new System.Drawing.Font("Arial", 9.75F);
            this.colDungSaiMIN.AppearanceCell.Options.UseFont = true;
            this.colDungSaiMIN.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F);
            this.colDungSaiMIN.AppearanceHeader.Options.UseFont = true;
            this.colDungSaiMIN.Caption = "Dung sai MIN";
            this.colDungSaiMIN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDungSaiMIN.FieldName = "DungSaiMIN";
            this.colDungSaiMIN.Name = "colDungSaiMIN";
            this.colDungSaiMIN.OptionsColumn.AllowEdit = false;
            this.colDungSaiMIN.Visible = true;
            this.colDungSaiMIN.VisibleIndex = 1;
            this.colDungSaiMIN.Width = 85;
            // 
            // colDungSaiMAX
            // 
            this.colDungSaiMAX.Caption = "Dung sai MAX";
            this.colDungSaiMAX.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDungSaiMAX.FieldName = "DungSaiMAX";
            this.colDungSaiMAX.Name = "colDungSaiMAX";
            this.colDungSaiMAX.OptionsColumn.AllowEdit = false;
            this.colDungSaiMAX.Visible = true;
            this.colDungSaiMAX.VisibleIndex = 2;
            this.colDungSaiMAX.Width = 89;
            // 
            // DoUuTien
            // 
            this.DoUuTien.Caption = "Độ ưu tiên";
            this.DoUuTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DoUuTien.FieldName = "DoUuTien";
            this.DoUuTien.Name = "DoUuTien";
            this.DoUuTien.OptionsColumn.AllowEdit = false;
            this.DoUuTien.Visible = true;
            this.DoUuTien.VisibleIndex = 3;
            this.DoUuTien.Width = 63;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gNhomNguoiDung;
            this.gridView2.Name = "gridView2";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.gNhomSanPham);
            this.groupBox5.Location = new System.Drawing.Point(8, 52);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(498, 445);
            this.groupBox5.TabIndex = 49;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách nhóm sản phẩm";
            // 
            // gNhomSanPham
            // 
            this.gNhomSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gNhomSanPham.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gNhomSanPham.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gNhomSanPham.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gNhomSanPham.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gNhomSanPham.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gNhomSanPham.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gNhomSanPham.Location = new System.Drawing.Point(7, 21);
            this.gNhomSanPham.MainView = this.gvNhomSanPham;
            this.gNhomSanPham.Name = "gNhomSanPham";
            this.gNhomSanPham.Size = new System.Drawing.Size(485, 418);
            this.gNhomSanPham.TabIndex = 28;
            this.gNhomSanPham.UseEmbeddedNavigator = true;
            this.gNhomSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhomSanPham});
            // 
            // gvNhomSanPham
            // 
            this.gvNhomSanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLinhVuc,
            this.colMaNganh,
            this.colTenNganh});
            this.gvNhomSanPham.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvNhomSanPham.GridControl = this.gNhomSanPham;
            this.gvNhomSanPham.GroupCount = 1;
            this.gvNhomSanPham.Name = "gvNhomSanPham";
            this.gvNhomSanPham.OptionsView.ShowAutoFilterRow = true;
            this.gvNhomSanPham.OptionsView.ShowDetailButtons = false;
            this.gvNhomSanPham.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colLinhVuc, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvNhomSanPham.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvNhomSanPham_FocusedRowChanged);
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
            this.colMaNganh.Width = 120;
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
            this.colTenNganh.Width = 246;
            // 
            // frmHT_ThietLapPheDuyetGiaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 561);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHT_ThietLapPheDuyetGiaBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập phê duyệt giá bán";
            this.Load += new System.EventHandler(this.frmHT_ListNhomNguoiDung_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gNhomNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gNhomSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private GtidTextBox txtFilterHanhDong;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraGrid.GridControl gNhomNguoiDung;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhomNguoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNhomNguoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhom;
        private DevExpress.XtraGrid.Columns.GridColumn colDungSaiMIN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colDungSaiMAX;
        private DevExpress.XtraEditors.SimpleButton btnAddNND;
        private DevExpress.XtraEditors.SimpleButton btnXoaNND;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnFilter;
        private System.Windows.Forms.RadioButton rdNhomHang;
        private System.Windows.Forms.RadioButton rdNhomND;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevExpress.XtraGrid.GridControl gNhomSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhomSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colLinhVuc;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNganh;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNganh;
        private DevExpress.XtraEditors.SimpleButton btnSaveCN;
        private DevExpress.XtraGrid.Columns.GridColumn DoUuTien;
    }
}