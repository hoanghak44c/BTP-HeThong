using QLBH.Core.Form;

namespace QLBanHang.Modules.HeThong
{
    partial class frmHT_ListNhomNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHT_ListNhomNguoiDung));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdNhomHang = new System.Windows.Forms.RadioButton();
            this.rdChucNang = new System.Windows.Forms.RadioButton();
            this.rdNhomND = new System.Windows.Forms.RadioButton();
            this.btnFilter = new DevExpress.XtraEditors.SimpleButton();
            this.txtFilterHanhDong = new QLBH.Core.Form.GtidTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.gChucNang = new DevExpress.XtraGrid.GridControl();
            this.gvChucNang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colParentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaChucNang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenChucNang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSaveCN = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaNND = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaNND = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddNND = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gNhomNguoiDung = new DevExpress.XtraGrid.GridControl();
            this.gvNhomNguoiDung = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdNhomNguoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.chkAllLSP = new System.Windows.Forms.CheckBox();
            this.gNhomSanPham = new DevExpress.XtraGrid.GridControl();
            this.gvNhomSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLinhVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkAllHang = new System.Windows.Forms.CheckBox();
            this.gHangSanXuat = new DevExpress.XtraGrid.GridControl();
            this.gvHangSanXuat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtabChucNang = new DevExpress.XtraTab.XtraTabPage();
            this.xtabMatHang = new DevExpress.XtraTab.XtraTabPage();
            this.txtSoTon = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.xtabHangSX = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gChucNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChucNang)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gNhomNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gNhomSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gHangSanXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHangSanXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtabChucNang.SuspendLayout();
            this.xtabMatHang.SuspendLayout();
            this.xtabHangSX.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdNhomHang);
            this.groupBox1.Controls.Add(this.rdChucNang);
            this.groupBox1.Controls.Add(this.rdNhomND);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.txtFilterHanhDong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1075, 43);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // rdNhomHang
            // 
            this.rdNhomHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdNhomHang.AutoSize = true;
            this.rdNhomHang.Location = new System.Drawing.Point(881, 15);
            this.rdNhomHang.Name = "rdNhomHang";
            this.rdNhomHang.Size = new System.Drawing.Size(79, 17);
            this.rdNhomHang.TabIndex = 53;
            this.rdNhomHang.Text = "Nhóm hàng";
            this.rdNhomHang.UseVisualStyleBackColor = true;
            // 
            // rdChucNang
            // 
            this.rdChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdChucNang.AutoSize = true;
            this.rdChucNang.Location = new System.Drawing.Point(799, 15);
            this.rdChucNang.Name = "rdChucNang";
            this.rdChucNang.Size = new System.Drawing.Size(77, 17);
            this.rdChucNang.TabIndex = 52;
            this.rdChucNang.Text = "Chức năng";
            this.rdChucNang.UseVisualStyleBackColor = true;
            // 
            // rdNhomND
            // 
            this.rdNhomND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdNhomND.AutoSize = true;
            this.rdNhomND.Checked = true;
            this.rdNhomND.Location = new System.Drawing.Point(686, 15);
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
            this.btnFilter.Location = new System.Drawing.Point(972, 13);
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
            this.txtFilterHanhDong.Size = new System.Drawing.Size(573, 21);
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
            // chkAll
            // 
            this.chkAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(6, 398);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(99, 17);
            this.chkAll.TabIndex = 29;
            this.chkAll.Text = "Chọn / Bỏ chọn";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // gChucNang
            // 
            this.gChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gChucNang.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gChucNang.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gChucNang.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gChucNang.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gChucNang.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gChucNang.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gChucNang.Location = new System.Drawing.Point(3, 3);
            this.gChucNang.MainView = this.gvChucNang;
            this.gChucNang.Name = "gChucNang";
            this.gChucNang.Size = new System.Drawing.Size(682, 392);
            this.gChucNang.TabIndex = 28;
            this.gChucNang.UseEmbeddedNavigator = true;
            this.gChucNang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChucNang});
            // 
            // gvChucNang
            // 
            this.gvChucNang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colParentName,
            this.colMaChucNang,
            this.colTenChucNang});
            this.gvChucNang.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvChucNang.GridControl = this.gChucNang;
            this.gvChucNang.GroupCount = 1;
            this.gvChucNang.Name = "gvChucNang";
            this.gvChucNang.OptionsView.ShowAutoFilterRow = true;
            this.gvChucNang.OptionsView.ShowDetailButtons = false;
            this.gvChucNang.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colParentName, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colParentName
            // 
            this.colParentName.Caption = "Nhóm chức năng";
            this.colParentName.FieldName = "ParentName";
            this.colParentName.Name = "colParentName";
            this.colParentName.OptionsColumn.AllowEdit = false;
            this.colParentName.OptionsColumn.AllowFocus = false;
            this.colParentName.OptionsColumn.ReadOnly = true;
            // 
            // colMaChucNang
            // 
            this.colMaChucNang.Caption = "Mã chức năng";
            this.colMaChucNang.FieldName = "MaChucNang";
            this.colMaChucNang.Name = "colMaChucNang";
            this.colMaChucNang.OptionsColumn.AllowEdit = false;
            this.colMaChucNang.OptionsColumn.AllowFocus = false;
            this.colMaChucNang.OptionsColumn.AllowMove = false;
            this.colMaChucNang.OptionsColumn.ReadOnly = true;
            this.colMaChucNang.Width = 159;
            // 
            // colTenChucNang
            // 
            this.colTenChucNang.Caption = "Tên chức năng";
            this.colTenChucNang.FieldName = "TenChucNang";
            this.colTenChucNang.Name = "colTenChucNang";
            this.colTenChucNang.OptionsColumn.AllowEdit = false;
            this.colTenChucNang.OptionsColumn.AllowFocus = false;
            this.colTenChucNang.OptionsColumn.AllowMove = false;
            this.colTenChucNang.OptionsColumn.ReadOnly = true;
            this.colTenChucNang.Visible = true;
            this.colTenChucNang.VisibleIndex = 0;
            this.colTenChucNang.Width = 440;
            // 
            // btnSaveCN
            // 
            this.btnSaveCN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveCN.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveCN.Image")));
            this.btnSaveCN.Location = new System.Drawing.Point(836, 16);
            this.btnSaveCN.Name = "btnSaveCN";
            this.btnSaveCN.Size = new System.Drawing.Size(134, 25);
            this.btnSaveCN.TabIndex = 23;
            this.btnSaveCN.Text = "&Cập nhật chức năng";
            this.btnSaveCN.Click += new System.EventHandler(this.btnSaveCN_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnDong);
            this.groupBox3.Controls.Add(this.btnSaveCN);
            this.groupBox3.Controls.Add(this.btnXoaNND);
            this.groupBox3.Controls.Add(this.btnSuaNND);
            this.groupBox3.Controls.Add(this.btnAddNND);
            this.groupBox3.Location = new System.Drawing.Point(8, 502);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1075, 47);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(976, 15);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(86, 25);
            this.btnDong.TabIndex = 24;
            this.btnDong.Text = " T&hoát";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoaNND
            // 
            this.btnXoaNND.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNND.Image")));
            this.btnXoaNND.Location = new System.Drawing.Point(196, 15);
            this.btnXoaNND.Name = "btnXoaNND";
            this.btnXoaNND.Size = new System.Drawing.Size(86, 25);
            this.btnXoaNND.TabIndex = 22;
            this.btnXoaNND.Text = "&Xóa nhóm";
            this.btnXoaNND.Click += new System.EventHandler(this.btnXoaNND_Click);
            // 
            // btnSuaNND
            // 
            this.btnSuaNND.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaNND.Image")));
            this.btnSuaNND.Location = new System.Drawing.Point(104, 15);
            this.btnSuaNND.Name = "btnSuaNND";
            this.btnSuaNND.Size = new System.Drawing.Size(86, 25);
            this.btnSuaNND.TabIndex = 21;
            this.btnSuaNND.Text = "&Sửa nhóm";
            this.btnSuaNND.Click += new System.EventHandler(this.btnSuaNND_Click);
            // 
            // btnAddNND
            // 
            this.btnAddNND.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNND.Image")));
            this.btnAddNND.Location = new System.Drawing.Point(12, 15);
            this.btnAddNND.Name = "btnAddNND";
            this.btnAddNND.Size = new System.Drawing.Size(86, 25);
            this.btnAddNND.TabIndex = 20;
            this.btnAddNND.Text = "&Thêm nhóm";
            this.btnAddNND.Click += new System.EventHandler(this.btnAddNND_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.gNhomNguoiDung);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(8, 53);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(382, 445);
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
            this.gNhomNguoiDung.Location = new System.Drawing.Point(4, 22);
            this.gNhomNguoiDung.MainView = this.gvNhomNguoiDung;
            this.gNhomNguoiDung.Name = "gNhomNguoiDung";
            this.gNhomNguoiDung.Size = new System.Drawing.Size(374, 416);
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
            this.colMaNhom,
            this.colTenNhom,
            this.colMoTa,
            this.colSuDung});
            this.gvNhomNguoiDung.GridControl = this.gNhomNguoiDung;
            this.gvNhomNguoiDung.Name = "gvNhomNguoiDung";
            this.gvNhomNguoiDung.OptionsView.ShowAutoFilterRow = true;
            this.gvNhomNguoiDung.OptionsView.ShowDetailButtons = false;
            this.gvNhomNguoiDung.OptionsView.ShowGroupPanel = false;
            this.gvNhomNguoiDung.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTenNhom, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvNhomNguoiDung.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvNhomNguoiDung_FocusedRowChanged);
            this.gvNhomNguoiDung.DoubleClick += new System.EventHandler(this.gvNhomNguoiDung_DoubleClick);
            // 
            // colIdNhomNguoiDung
            // 
            this.colIdNhomNguoiDung.Caption = "IdNhomNguoiDung";
            this.colIdNhomNguoiDung.FieldName = "IdNhomNguoiDung";
            this.colIdNhomNguoiDung.Name = "colIdNhomNguoiDung";
            // 
            // colMaNhom
            // 
            this.colMaNhom.AppearanceCell.Font = new System.Drawing.Font("Arial", 9.75F);
            this.colMaNhom.AppearanceCell.Options.UseFont = true;
            this.colMaNhom.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F);
            this.colMaNhom.AppearanceHeader.Options.UseFont = true;
            this.colMaNhom.Caption = "Mã nhóm";
            this.colMaNhom.FieldName = "MaNhom";
            this.colMaNhom.Name = "colMaNhom";
            this.colMaNhom.OptionsColumn.AllowEdit = false;
            this.colMaNhom.OptionsColumn.AllowFocus = false;
            this.colMaNhom.OptionsColumn.AllowMove = false;
            this.colMaNhom.OptionsColumn.FixedWidth = true;
            this.colMaNhom.OptionsColumn.ReadOnly = true;
            this.colMaNhom.Width = 107;
            // 
            // colTenNhom
            // 
            this.colTenNhom.AppearanceCell.Font = new System.Drawing.Font("Arial", 9.75F);
            this.colTenNhom.AppearanceCell.Options.UseFont = true;
            this.colTenNhom.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F);
            this.colTenNhom.AppearanceHeader.Options.UseFont = true;
            this.colTenNhom.Caption = "Tên nhóm";
            this.colTenNhom.FieldName = "TenNhom";
            this.colTenNhom.Name = "colTenNhom";
            this.colTenNhom.OptionsColumn.AllowEdit = false;
            this.colTenNhom.OptionsColumn.AllowFocus = false;
            this.colTenNhom.OptionsColumn.AllowMove = false;
            this.colTenNhom.OptionsColumn.FixedWidth = true;
            this.colTenNhom.OptionsColumn.ReadOnly = true;
            this.colTenNhom.Visible = true;
            this.colTenNhom.VisibleIndex = 0;
            this.colTenNhom.Width = 202;
            // 
            // colMoTa
            // 
            this.colMoTa.AppearanceCell.Font = new System.Drawing.Font("Arial", 9.75F);
            this.colMoTa.AppearanceCell.Options.UseFont = true;
            this.colMoTa.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F);
            this.colMoTa.AppearanceHeader.Options.UseFont = true;
            this.colMoTa.Caption = "Mô tả";
            this.colMoTa.FieldName = "MoTa";
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.OptionsColumn.AllowEdit = false;
            this.colMoTa.OptionsColumn.AllowFocus = false;
            this.colMoTa.Width = 309;
            // 
            // colSuDung
            // 
            this.colSuDung.Caption = "Sử dụng";
            this.colSuDung.FieldName = "SuDung";
            this.colSuDung.Name = "colSuDung";
            this.colSuDung.Visible = true;
            this.colSuDung.VisibleIndex = 1;
            this.colSuDung.Width = 51;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gNhomNguoiDung;
            this.gridView2.Name = "gridView2";
            // 
            // chkAllLSP
            // 
            this.chkAllLSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAllLSP.AutoSize = true;
            this.chkAllLSP.Location = new System.Drawing.Point(6, 397);
            this.chkAllLSP.Name = "chkAllLSP";
            this.chkAllLSP.Size = new System.Drawing.Size(99, 17);
            this.chkAllLSP.TabIndex = 29;
            this.chkAllLSP.Text = "Chọn / Bỏ chọn";
            this.chkAllLSP.UseVisualStyleBackColor = true;
            this.chkAllLSP.CheckedChanged += new System.EventHandler(this.chkAllLSP_CheckedChanged);
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
            this.gNhomSanPham.Location = new System.Drawing.Point(3, 3);
            this.gNhomSanPham.MainView = this.gvNhomSanPham;
            this.gNhomSanPham.Name = "gNhomSanPham";
            this.gNhomSanPham.Size = new System.Drawing.Size(682, 391);
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
            this.colTenNganh,
            this.colMaLoai,
            this.TenLoai});
            this.gvNhomSanPham.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvNhomSanPham.GridControl = this.gNhomSanPham;
            this.gvNhomSanPham.GroupCount = 2;
            this.gvNhomSanPham.Name = "gvNhomSanPham";
            this.gvNhomSanPham.OptionsView.ShowAutoFilterRow = true;
            this.gvNhomSanPham.OptionsView.ShowDetailButtons = false;
            this.gvNhomSanPham.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colLinhVuc, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTenNganh, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            this.colTenNganh.Width = 246;
            // 
            // colMaLoai
            // 
            this.colMaLoai.Caption = "Mã Loại";
            this.colMaLoai.FieldName = "MaLoai";
            this.colMaLoai.Name = "colMaLoai";
            this.colMaLoai.Visible = true;
            this.colMaLoai.VisibleIndex = 0;
            this.colMaLoai.Width = 314;
            // 
            // TenLoai
            // 
            this.TenLoai.Caption = "Loại sản phẩm";
            this.TenLoai.FieldName = "TenLoai";
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.Visible = true;
            this.TenLoai.VisibleIndex = 1;
            this.TenLoai.Width = 862;
            // 
            // chkAllHang
            // 
            this.chkAllHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAllHang.AutoSize = true;
            this.chkAllHang.Location = new System.Drawing.Point(6, 396);
            this.chkAllHang.Name = "chkAllHang";
            this.chkAllHang.Size = new System.Drawing.Size(99, 17);
            this.chkAllHang.TabIndex = 29;
            this.chkAllHang.Text = "Chọn / Bỏ chọn";
            this.chkAllHang.UseVisualStyleBackColor = true;
            this.chkAllHang.CheckedChanged += new System.EventHandler(this.chkAllHang_CheckedChanged);
            // 
            // gHangSanXuat
            // 
            this.gHangSanXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gHangSanXuat.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gHangSanXuat.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gHangSanXuat.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gHangSanXuat.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gHangSanXuat.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gHangSanXuat.EmbeddedNavigator.TextStringFormat = " {0} / {1}";
            this.gHangSanXuat.Location = new System.Drawing.Point(3, 3);
            this.gHangSanXuat.MainView = this.gvHangSanXuat;
            this.gHangSanXuat.Name = "gHangSanXuat";
            this.gHangSanXuat.Size = new System.Drawing.Size(682, 390);
            this.gHangSanXuat.TabIndex = 28;
            this.gHangSanXuat.UseEmbeddedNavigator = true;
            this.gHangSanXuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHangSanXuat});
            // 
            // gvHangSanXuat
            // 
            this.gvHangSanXuat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaHang,
            this.TenHang});
            this.gvHangSanXuat.CustomizationFormBounds = new System.Drawing.Rectangle(852, 316, 216, 178);
            this.gvHangSanXuat.GridControl = this.gHangSanXuat;
            this.gvHangSanXuat.Name = "gvHangSanXuat";
            this.gvHangSanXuat.OptionsView.ShowAutoFilterRow = true;
            this.gvHangSanXuat.OptionsView.ShowDetailButtons = false;
            this.gvHangSanXuat.OptionsView.ShowGroupPanel = false;
            // 
            // MaHang
            // 
            this.MaHang.Caption = "Mã Hãng SX";
            this.MaHang.FieldName = "MaHang";
            this.MaHang.Name = "MaHang";
            this.MaHang.OptionsColumn.AllowEdit = false;
            this.MaHang.OptionsColumn.AllowFocus = false;
            this.MaHang.OptionsColumn.AllowMove = false;
            this.MaHang.OptionsColumn.ReadOnly = true;
            this.MaHang.Visible = true;
            this.MaHang.VisibleIndex = 0;
            this.MaHang.Width = 159;
            // 
            // TenHang
            // 
            this.TenHang.Caption = "Hãng sản xuất";
            this.TenHang.FieldName = "TenHang";
            this.TenHang.Name = "TenHang";
            this.TenHang.OptionsColumn.AllowEdit = false;
            this.TenHang.OptionsColumn.AllowFocus = false;
            this.TenHang.OptionsColumn.AllowMove = false;
            this.TenHang.OptionsColumn.ReadOnly = true;
            this.TenHang.Visible = true;
            this.TenHang.VisibleIndex = 1;
            this.TenHang.Width = 440;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(396, 53);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.xtraTabControl1.SelectedTabPage = this.xtabChucNang;
            this.xtraTabControl1.Size = new System.Drawing.Size(695, 445);
            this.xtraTabControl1.TabIndex = 50;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtabChucNang,
            this.xtabMatHang,
            this.xtabHangSX});
            // 
            // xtabChucNang
            // 
            this.xtabChucNang.Controls.Add(this.chkAll);
            this.xtabChucNang.Controls.Add(this.gChucNang);
            this.xtabChucNang.Name = "xtabChucNang";
            this.xtabChucNang.Size = new System.Drawing.Size(688, 417);
            this.xtabChucNang.Text = "Phân quyền chức năng";
            // 
            // xtabMatHang
            // 
            this.xtabMatHang.Controls.Add(this.txtSoTon);
            this.xtabMatHang.Controls.Add(this.lblSoLuong);
            this.xtabMatHang.Controls.Add(this.chkAllLSP);
            this.xtabMatHang.Controls.Add(this.gNhomSanPham);
            this.xtabMatHang.Name = "xtabMatHang";
            this.xtabMatHang.Size = new System.Drawing.Size(688, 416);
            this.xtabMatHang.Text = "Phân quyền hàng hóa";
            // 
            // txtSoTon
            // 
            this.txtSoTon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoTon.Location = new System.Drawing.Point(598, 395);
            this.txtSoTon.Name = "txtSoTon";
            this.txtSoTon.Size = new System.Drawing.Size(87, 21);
            this.txtSoTon.TabIndex = 31;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(504, 399);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(88, 13);
            this.lblSoLuong.TabIndex = 30;
            this.lblSoLuong.Text = "Số tồn được xem";
            // 
            // xtabHangSX
            // 
            this.xtabHangSX.Controls.Add(this.chkAllHang);
            this.xtabHangSX.Controls.Add(this.gHangSanXuat);
            this.xtabHangSX.Name = "xtabHangSX";
            this.xtabHangSX.Size = new System.Drawing.Size(688, 416);
            this.xtabHangSX.Text = "Phân quyền hãng sản xuất";
            // 
            // frmHT_ListNhomNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 561);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHT_ListNhomNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách nhóm người dùng";
            this.Load += new System.EventHandler(this.frmHT_ListNhomNguoiDung_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gChucNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChucNang)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gNhomNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gNhomSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gHangSanXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHangSanXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtabChucNang.ResumeLayout(false);
            this.xtabChucNang.PerformLayout();
            this.xtabMatHang.ResumeLayout(false);
            this.xtabMatHang.PerformLayout();
            this.xtabHangSX.ResumeLayout(false);
            this.xtabHangSX.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private GtidTextBox txtFilterHanhDong;
        private DevExpress.XtraGrid.GridControl gChucNang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChucNang;
        private DevExpress.XtraGrid.Columns.GridColumn colParentName;
        private DevExpress.XtraGrid.Columns.GridColumn colTenChucNang;
        private DevExpress.XtraGrid.Columns.GridColumn colMaChucNang;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraGrid.GridControl gNhomNguoiDung;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhomNguoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNhomNguoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhom;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhom;
        private DevExpress.XtraGrid.Columns.GridColumn colMoTa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colSuDung;
        private DevExpress.XtraEditors.SimpleButton btnAddNND;
        private DevExpress.XtraEditors.SimpleButton btnSuaNND;
        private DevExpress.XtraEditors.SimpleButton btnXoaNND;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnSaveCN;
        private DevExpress.XtraEditors.SimpleButton btnFilter;
        private System.Windows.Forms.RadioButton rdNhomHang;
        private System.Windows.Forms.RadioButton rdChucNang;
        private System.Windows.Forms.RadioButton rdNhomND;
        private System.Windows.Forms.CheckBox chkAllLSP;
        private DevExpress.XtraGrid.GridControl gNhomSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhomSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colLinhVuc;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNganh;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNganh;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoai;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoai;
        private System.Windows.Forms.CheckBox chkAllHang;
        private DevExpress.XtraGrid.GridControl gHangSanXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHangSanXuat;
        private DevExpress.XtraGrid.Columns.GridColumn MaHang;
        private DevExpress.XtraGrid.Columns.GridColumn TenHang;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtabChucNang;
        private DevExpress.XtraTab.XtraTabPage xtabMatHang;
        private DevExpress.XtraTab.XtraTabPage xtabHangSX;
        private System.Windows.Forms.TextBox txtSoTon;
        private System.Windows.Forms.Label lblSoLuong;
    }
}