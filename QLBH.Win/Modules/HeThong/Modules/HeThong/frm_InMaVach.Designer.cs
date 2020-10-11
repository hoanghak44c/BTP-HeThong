﻿using QLBH.Core.Form;
namespace QLBanHang.Modules.HeThong
{
    partial class frm_InMaVach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_InMaVach));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsClose = new System.Windows.Forms.ToolStripButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnNext = new QLBH.Core.Form.GtidButton();
            this.cboPage = new System.Windows.Forms.ComboBox();
            this.gSanPham = new DevExpress.XtraGrid.GridControl();
            this.gvSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenVietTat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGiaCoVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrungMaVach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTrungMV = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.LinhVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSanPham = new QLBH.Core.Form.GtidTextBox();
            this.lblThuocXuat = new System.Windows.Forms.Label();
            this.lueNganhHang = new DevExpress.XtraEditors.LookUpEdit();
            this.lblLyDo = new DevExpress.XtraEditors.LabelControl();
            this.bteTrungTam = new DevExpress.XtraEditors.ButtonEdit();
            this.btnTim = new QLBH.Core.Form.GtidButton();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrungMV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueNganhHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExport,
            this.toolStripSeparator2,
            this.tlsPrint,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.tlsClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(941, 25);
            this.toolStrip1.TabIndex = 63;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbExport
            // 
            this.tsbExport.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport.Image")));
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(83, 22);
            this.tsbExport.Text = "&Export (F2)";
            this.tsbExport.Click += new System.EventHandler(this.tsbExport_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tlsPrint
            // 
            this.tlsPrint.Image = ((System.Drawing.Image)(resources.GetObject("tlsPrint.Image")));
            this.tlsPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsPrint.Name = "tlsPrint";
            this.tlsPrint.Size = new System.Drawing.Size(108, 22);
            this.tlsPrint.Text = "In mã vạch (F9)";
            this.tlsPrint.Visible = false;
            this.tlsPrint.Click += new System.EventHandler(this.tlsPrint_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(203, 22);
            this.toolStripLabel1.Text = "IN MÃ VẠCH SẢN PHẨM";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator1.Visible = false;
            // 
            // tlsClose
            // 
            this.tlsClose.Image = ((System.Drawing.Image)(resources.GetObject("tlsClose.Image")));
            this.tlsClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsClose.Name = "tlsClose";
            this.tlsClose.Size = new System.Drawing.Size(87, 22);
            this.tlsClose.Text = "Thoát (F12)";
            this.tlsClose.Click += new System.EventHandler(this.tlsClose_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnNext);
            this.groupBox4.Controls.Add(this.cboPage);
            this.groupBox4.Controls.Add(this.gSanPham);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(0, 96);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(941, 388);
            this.groupBox4.TabIndex = 64;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách sản phẩm";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(781, 32);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnNext.Size = new System.Drawing.Size(121, 22);
            this.btnNext.TabIndex = 154;
            this.btnNext.Text = "Kết quả tiếp theo";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cboPage
            // 
            this.cboPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPage.AutoCompleteCustomSource.AddRange(new string[] {
            "Nhận hàng tại siêu thị",
            "Giao hàng tại nhà"});
            this.cboPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPage.FormattingEnabled = true;
            this.cboPage.Items.AddRange(new object[] {
            "50",
            "100",
            "200",
            "500",
            "1000",
            "Tất cả"});
            this.cboPage.Location = new System.Drawing.Point(729, 32);
            this.cboPage.Name = "cboPage";
            this.cboPage.Size = new System.Drawing.Size(50, 21);
            this.cboPage.TabIndex = 153;
            // 
            // gSanPham
            // 
            this.gSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gSanPham.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Arial", 9.75F);
            this.gSanPham.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gSanPham.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gSanPham.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gSanPham.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gSanPham.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gSanPham.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gSanPham.EmbeddedNavigator.TextStringFormat = "{0} / {1}";
            this.gSanPham.Font = new System.Drawing.Font("Arial", 9.75F);
            this.gSanPham.Location = new System.Drawing.Point(6, 22);
            this.gSanPham.MainView = this.gvSanPham;
            this.gSanPham.Name = "gSanPham";
            this.gSanPham.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repTrungMV});
            this.gSanPham.Size = new System.Drawing.Size(929, 359);
            this.gSanPham.TabIndex = 139;
            this.gSanPham.UseEmbeddedNavigator = true;
            this.gSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSanPham,
            this.gridView2});
            // 
            // gvSanPham
            // 
            this.gvSanPham.ColumnPanelRowHeight = 25;
            this.gvSanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdSanPham,
            this.MaSanPham,
            this.TenSanPham,
            this.TenVietTat,
            this.DonViTinh,
            this.DonGiaCoVAT,
            this.TrungMaVach,
            this.LinhVuc,
            this.Nganh,
            this.LoaiSanPham,
            this.SoLuong});
            this.gvSanPham.GridControl = this.gSanPham;
            this.gvSanPham.Name = "gvSanPham";
            this.gvSanPham.OptionsView.ShowAutoFilterRow = true;
            this.gvSanPham.OptionsView.ShowDetailButtons = false;
            // 
            // IdSanPham
            // 
            this.IdSanPham.Caption = "IdSanPham";
            this.IdSanPham.FieldName = "IdSanPham";
            this.IdSanPham.Name = "IdSanPham";
            this.IdSanPham.OptionsColumn.ReadOnly = true;
            this.IdSanPham.Width = 69;
            // 
            // MaSanPham
            // 
            this.MaSanPham.Caption = "Mã sản phẩm";
            this.MaSanPham.FieldName = "MaSanPham";
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.MaSanPham.Visible = true;
            this.MaSanPham.VisibleIndex = 0;
            // 
            // TenSanPham
            // 
            this.TenSanPham.Caption = "Tên sản phẩm";
            this.TenSanPham.FieldName = "TenSanPham";
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TenSanPham.OptionsColumn.ReadOnly = true;
            this.TenSanPham.Visible = true;
            this.TenSanPham.VisibleIndex = 1;
            this.TenSanPham.Width = 229;
            // 
            // TenVietTat
            // 
            this.TenVietTat.Caption = "Tên rút gọn";
            this.TenVietTat.FieldName = "TenVietTat";
            this.TenVietTat.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.TenVietTat.Name = "TenVietTat";
            this.TenVietTat.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TenVietTat.OptionsColumn.ReadOnly = true;
            this.TenVietTat.Width = 160;
            // 
            // DonViTinh
            // 
            this.DonViTinh.Caption = "Đơn vị tính";
            this.DonViTinh.FieldName = "TenDonViTinh";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.DonViTinh.OptionsColumn.ReadOnly = true;
            this.DonViTinh.Visible = true;
            this.DonViTinh.VisibleIndex = 2;
            this.DonViTinh.Width = 79;
            // 
            // DonGiaCoVAT
            // 
            this.DonGiaCoVAT.Caption = "Đơn giá có VAT";
            this.DonGiaCoVAT.FieldName = "DonGiaCoVAT";
            this.DonGiaCoVAT.Name = "DonGiaCoVAT";
            this.DonGiaCoVAT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.DonGiaCoVAT.OptionsColumn.ReadOnly = true;
            this.DonGiaCoVAT.Width = 114;
            // 
            // TrungMaVach
            // 
            this.TrungMaVach.Caption = "Trùng mã vạch";
            this.TrungMaVach.ColumnEdit = this.repTrungMV;
            this.TrungMaVach.FieldName = "TrungMaVach";
            this.TrungMaVach.Name = "TrungMaVach";
            this.TrungMaVach.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TrungMaVach.OptionsColumn.ReadOnly = true;
            this.TrungMaVach.Visible = true;
            this.TrungMaVach.VisibleIndex = 3;
            this.TrungMaVach.Width = 84;
            // 
            // repTrungMV
            // 
            this.repTrungMV.AutoHeight = false;
            this.repTrungMV.Name = "repTrungMV";
            this.repTrungMV.ValueChecked = 1;
            this.repTrungMV.ValueUnchecked = 0;
            // 
            // LinhVuc
            // 
            this.LinhVuc.Caption = "Lĩnh vực";
            this.LinhVuc.FieldName = "LinhVuc";
            this.LinhVuc.Name = "LinhVuc";
            this.LinhVuc.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.LinhVuc.OptionsColumn.ReadOnly = true;
            this.LinhVuc.Visible = true;
            this.LinhVuc.VisibleIndex = 4;
            this.LinhVuc.Width = 77;
            // 
            // Nganh
            // 
            this.Nganh.Caption = "Ngành";
            this.Nganh.FieldName = "Nganh";
            this.Nganh.Name = "Nganh";
            this.Nganh.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Nganh.OptionsColumn.ReadOnly = true;
            this.Nganh.Visible = true;
            this.Nganh.VisibleIndex = 5;
            this.Nganh.Width = 131;
            // 
            // LoaiSanPham
            // 
            this.LoaiSanPham.Caption = "Loại sản phẩm";
            this.LoaiSanPham.FieldName = "LoaiSanPham";
            this.LoaiSanPham.Name = "LoaiSanPham";
            this.LoaiSanPham.Visible = true;
            this.LoaiSanPham.VisibleIndex = 6;
            this.LoaiSanPham.Width = 156;
            // 
            // SoLuong
            // 
            this.SoLuong.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.SoLuong.AppearanceCell.Options.UseBackColor = true;
            this.SoLuong.Caption = "Số lượng in";
            this.SoLuong.DisplayFormat.FormatString = "N0";
            this.SoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 7;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gSanPham;
            this.gridView2.Name = "gridView2";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtSanPham);
            this.groupBox1.Controls.Add(this.lblThuocXuat);
            this.groupBox1.Controls.Add(this.lueNganhHang);
            this.groupBox1.Controls.Add(this.lblLyDo);
            this.groupBox1.Controls.Add(this.bteTrungTam);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 65);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            // 
            // txtSanPham
            // 
            this.txtSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSanPham.Location = new System.Drawing.Point(78, 38);
            this.txtSanPham.Name = "txtSanPham";
            this.txtSanPham.Size = new System.Drawing.Size(352, 20);
            this.txtSanPham.TabIndex = 129;
            // 
            // lblThuocXuat
            // 
            this.lblThuocXuat.AutoSize = true;
            this.lblThuocXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuocXuat.Location = new System.Drawing.Point(14, 41);
            this.lblThuocXuat.Name = "lblThuocXuat";
            this.lblThuocXuat.Size = new System.Drawing.Size(55, 13);
            this.lblThuocXuat.TabIndex = 128;
            this.lblThuocXuat.Text = "Sản phẩm";
            // 
            // lueNganhHang
            // 
            this.lueNganhHang.Location = new System.Drawing.Point(552, 13);
            this.lueNganhHang.Name = "lueNganhHang";
            this.lueNganhHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueNganhHang.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Ten")});
            this.lueNganhHang.Properties.DisplayMember = "Ten";
            this.lueNganhHang.Properties.NullText = "";
            this.lueNganhHang.Properties.ShowFooter = false;
            this.lueNganhHang.Properties.ShowHeader = false;
            this.lueNganhHang.Properties.ValueMember = "IdLyDoTH";
            this.lueNganhHang.Size = new System.Drawing.Size(322, 20);
            this.lueNganhHang.TabIndex = 126;
            // 
            // lblLyDo
            // 
            this.lblLyDo.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLyDo.Appearance.Options.UseFont = true;
            this.lblLyDo.Location = new System.Drawing.Point(491, 18);
            this.lblLyDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.Size = new System.Drawing.Size(58, 13);
            this.lblLyDo.TabIndex = 127;
            this.lblLyDo.Text = "Ngành hàng";
            // 
            // bteTrungTam
            // 
            this.bteTrungTam.Location = new System.Drawing.Point(78, 13);
            this.bteTrungTam.Name = "bteTrungTam";
            this.bteTrungTam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteTrungTam.Properties.Appearance.Options.UseFont = true;
            this.bteTrungTam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteTrungTam.Size = new System.Drawing.Size(352, 22);
            this.bteTrungTam.TabIndex = 117;
            this.bteTrungTam.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteTrungTam_ButtonClick);
            this.bteTrungTam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteTrungTam_KeyDown);
            this.bteTrungTam.TextChanged += new System.EventHandler(this.bteTrungTam_TextChanged);
            // 
            // btnTim
            // 
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.Location = new System.Drawing.Point(552, 36);
            this.btnTim.Name = "btnTim";
            this.btnTim.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnTim.Size = new System.Drawing.Size(132, 24);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "&Nap dữ liệu (F5)";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "Trung tâm";
            // 
            // frm_InMaVach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 484);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.Name = "frm_InMaVach";
            this.Text = "In mã vạch sản phẩm";
            this.Load += new System.EventHandler(this.frm_BangGiaHienTai_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_InMaVach_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrungMV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueNganhHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteTrungTam.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlsPrint;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tlsClose;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraGrid.GridControl gSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn IdSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenVietTat;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn DonGiaCoVAT;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn TrungMaVach;
        private DevExpress.XtraGrid.Columns.GridColumn LinhVuc;
        private DevExpress.XtraGrid.Columns.GridColumn Nganh;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.ButtonEdit bteTrungTam;
        private GtidButton btnTim;
        private System.Windows.Forms.Label label7;
        private GtidButton btnNext;
        private System.Windows.Forms.ComboBox cboPage;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiSanPham;
        private GtidTextBox txtSanPham;
        private System.Windows.Forms.Label lblThuocXuat;
        private DevExpress.XtraEditors.LookUpEdit lueNganhHang;
        private DevExpress.XtraEditors.LabelControl lblLyDo;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repTrungMV;

    }
}