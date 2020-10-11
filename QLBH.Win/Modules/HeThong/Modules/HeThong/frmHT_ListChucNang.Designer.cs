using QLBH.Core.Form;

namespace QLBanHang.Modules.HeThong
{
    partial class frmHT_ListChucNang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHT_ListChucNang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFilter = new DevExpress.XtraEditors.SimpleButton();
            this.txtFilterHanhDong = new QLBH.Core.Form.GtidTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.gChucNang = new DevExpress.XtraGrid.GridControl();
            this.gvChucNang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colParentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaChucNang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenChucNang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnNapDL = new DevExpress.XtraEditors.SimpleButton();
            this.gtidButton1 = new QLBH.Core.Form.GtidButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gChucNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChucNang)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.txtFilterHanhDong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.Location = new System.Drawing.Point(732, 19);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(86, 23);
            this.btnFilter.TabIndex = 52;
            this.btnFilter.Text = "&Lọc";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilterHanhDong
            // 
            this.txtFilterHanhDong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterHanhDong.Location = new System.Drawing.Point(134, 20);
            this.txtFilterHanhDong.Name = "txtFilterHanhDong";
            this.txtFilterHanhDong.Size = new System.Drawing.Size(588, 21);
            this.txtFilterHanhDong.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã/Tên chức năng";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkAll);
            this.groupBox2.Controls.Add(this.gChucNang);
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(835, 424);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách chức năng";
            // 
            // chkAll
            // 
            this.chkAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(29, 401);
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
            this.gChucNang.Location = new System.Drawing.Point(7, 21);
            this.gChucNang.MainView = this.gvChucNang;
            this.gChucNang.Name = "gChucNang";
            this.gChucNang.Size = new System.Drawing.Size(811, 374);
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
            this.colParentName.OptionsColumn.AllowFocus = false;
            this.colParentName.OptionsColumn.AllowMove = false;
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
            this.colMaChucNang.Visible = true;
            this.colMaChucNang.VisibleIndex = 0;
            this.colMaChucNang.Width = 221;
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
            this.colTenChucNang.VisibleIndex = 1;
            this.colTenChucNang.Width = 378;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnDong);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnNapDL);
            this.groupBox3.Controls.Add(this.gtidButton1);
            this.groupBox3.Location = new System.Drawing.Point(12, 502);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(835, 47);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(732, 14);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(86, 25);
            this.btnDong.TabIndex = 56;
            this.btnDong.Text = " T&hoát";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(110, 14);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 25);
            this.btnXoa.TabIndex = 55;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnNapDL
            // 
            this.btnNapDL.Image = ((System.Drawing.Image)(resources.GetObject("btnNapDL.Image")));
            this.btnNapDL.Location = new System.Drawing.Point(18, 14);
            this.btnNapDL.Name = "btnNapDL";
            this.btnNapDL.Size = new System.Drawing.Size(86, 25);
            this.btnNapDL.TabIndex = 54;
            this.btnNapDL.Text = "&Nạp dữ liệu";
            this.btnNapDL.Click += new System.EventHandler(this.btnNapDL_Click);
            // 
            // gtidButton1
            // 
            this.gtidButton1.Image = ((System.Drawing.Image)(resources.GetObject("gtidButton1.Image")));
            this.gtidButton1.Location = new System.Drawing.Point(559, 13);
            this.gtidButton1.Name = "gtidButton1";
            this.gtidButton1.ShortCutKey = System.Windows.Forms.Keys.None;
            this.gtidButton1.Size = new System.Drawing.Size(80, 25);
            this.gtidButton1.TabIndex = 18;
            this.gtidButton1.Text = "   T&hoát";
            this.gtidButton1.Click += new System.EventHandler(this.gtidButton1_Click);
            // 
            // frmHT_ListChucNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHT_ListChucNang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách chức năng";
            this.Load += new System.EventHandler(this.frmHT_ListChucNang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gChucNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChucNang)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private GtidTextBox txtFilterHanhDong;
        private DevExpress.XtraGrid.GridControl gChucNang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChucNang;
        private DevExpress.XtraGrid.Columns.GridColumn colParentName;
        private DevExpress.XtraGrid.Columns.GridColumn colTenChucNang;
        private DevExpress.XtraGrid.Columns.GridColumn colMaChucNang;
        private System.Windows.Forms.CheckBox chkAll;
        internal GtidButton gtidButton1;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnNapDL;
        private DevExpress.XtraEditors.SimpleButton btnFilter;
    }
}