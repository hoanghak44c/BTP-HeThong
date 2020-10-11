namespace QLBanHang.Modules.HeThong
{
    partial class frmHT_LockChungTuManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHT_LockChungTuManager));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNapDuLieu = new System.Windows.Forms.ToolStripButton();
            this.tsbUnLock = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslInfor = new System.Windows.Forms.ToolStripLabel();
            this.dgvList = new DevExpress.XtraGrid.GridControl();
            this.grvChiTiet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSoChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLockAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLockMachine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProcessId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastUpdateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTrangThai = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repdtngaylap = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repdtNgayNhap = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repdtThoiGian = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repdtNgayNhapMa = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repdtngaylap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repdtngaylap.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repdtNgayNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repdtNgayNhap.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repdtThoiGian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repdtThoiGian.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repdtNgayNhapMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repdtNgayNhapMa.VistaTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNapDuLieu,
            this.tsbUnLock,
            this.toolStripSeparator3,
            this.tsbExport,
            this.toolStripSeparator4,
            this.tsbClose,
            this.toolStripSeparator1,
            this.tslInfor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(878, 25);
            this.toolStrip1.TabIndex = 91;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNapDuLieu
            // 
            this.tsbNapDuLieu.Image = ((System.Drawing.Image)(resources.GetObject("tsbNapDuLieu.Image")));
            this.tsbNapDuLieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNapDuLieu.Name = "tsbNapDuLieu";
            this.tsbNapDuLieu.Size = new System.Drawing.Size(121, 22);
            this.tsbNapDuLieu.Text = "Nạp dữ liệu (F5)";
            this.tsbNapDuLieu.ToolTipText = "Nạp dữ liệu (F5)";
            this.tsbNapDuLieu.Click += new System.EventHandler(this.tsbNapDuLieu_Click);
            // 
            // tsbUnLock
            // 
            this.tsbUnLock.Image = ((System.Drawing.Image)(resources.GetObject("tsbUnLock.Image")));
            this.tsbUnLock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUnLock.Name = "tsbUnLock";
            this.tsbUnLock.Size = new System.Drawing.Size(77, 22);
            this.tsbUnLock.Text = "&Hủy (F8)";
            this.tsbUnLock.ToolTipText = "Gỡ khóa chứng từ";
            this.tsbUnLock.Click += new System.EventHandler(this.tsbUnLock_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator3.Visible = false;
            // 
            // tsbExport
            // 
            this.tsbExport.Enabled = false;
            this.tsbExport.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport.Image")));
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(107, 22);
            this.tsbExport.Text = "Export dữ liệu";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbClose
            // 
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(93, 22);
            this.tsbClose.Text = "Đ&óng (F12)";
            this.tsbClose.ToolTipText = "Đóng (F12)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslInfor
            // 
            this.tslInfor.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslInfor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslInfor.Name = "tslInfor";
            this.tslInfor.Size = new System.Drawing.Size(136, 22);
            this.tslInfor.Text = "Quản lý khóa chứng từ";
            // 
            // dgvList
            // 
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.Location = new System.Drawing.Point(12, 28);
            this.dgvList.MainView = this.grvChiTiet;
            this.dgvList.Name = "dgvList";
            this.dgvList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repTrangThai,
            this.repdtngaylap,
            this.repdtNgayNhap,
            this.repdtThoiGian,
            this.repositoryItemDateEdit1,
            this.repdtNgayNhapMa});
            this.dgvList.Size = new System.Drawing.Size(854, 414);
            this.dgvList.TabIndex = 93;
            this.dgvList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvChiTiet});
            // 
            // grvChiTiet
            // 
            this.grvChiTiet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSoChungTu,
            this.colLockAccount,
            this.colLockMachine,
            this.colProcessId,
            this.colLastUpdateDate});
            this.grvChiTiet.GridControl = this.dgvList;
            this.grvChiTiet.Name = "grvChiTiet";
            this.grvChiTiet.OptionsView.ShowAutoFilterRow = true;
            // 
            // colSoChungTu
            // 
            this.colSoChungTu.Caption = "Số chứng từ";
            this.colSoChungTu.FieldName = "SoChungTu";
            this.colSoChungTu.Name = "colSoChungTu";
            this.colSoChungTu.Visible = true;
            this.colSoChungTu.VisibleIndex = 0;
            // 
            // colLockAccount
            // 
            this.colLockAccount.Caption = "Bị khóa bởi";
            this.colLockAccount.FieldName = "LockAccount";
            this.colLockAccount.Name = "colLockAccount";
            this.colLockAccount.Visible = true;
            this.colLockAccount.VisibleIndex = 1;
            // 
            // colLockMachine
            // 
            this.colLockMachine.Caption = "Tại máy";
            this.colLockMachine.FieldName = "LockMachine";
            this.colLockMachine.Name = "colLockMachine";
            this.colLockMachine.Visible = true;
            this.colLockMachine.VisibleIndex = 2;
            // 
            // colProcessId
            // 
            this.colProcessId.Caption = "Tiến trình";
            this.colProcessId.FieldName = "ProcessId";
            this.colProcessId.Name = "colProcessId";
            this.colProcessId.Visible = true;
            this.colProcessId.VisibleIndex = 3;
            // 
            // colLastUpdateDate
            // 
            this.colLastUpdateDate.Caption = "Vào lúc";
            this.colLastUpdateDate.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colLastUpdateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastUpdateDate.FieldName = "Last_Update_Date";
            this.colLastUpdateDate.Name = "colLastUpdateDate";
            this.colLastUpdateDate.Visible = true;
            this.colLastUpdateDate.VisibleIndex = 4;
            // 
            // repTrangThai
            // 
            this.repTrangThai.AutoHeight = false;
            this.repTrangThai.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repTrangThai.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.repTrangThai.DisplayMember = "Name";
            this.repTrangThai.Name = "repTrangThai";
            this.repTrangThai.NullText = "";
            this.repTrangThai.ShowFooter = false;
            this.repTrangThai.ShowHeader = false;
            this.repTrangThai.ValueMember = "Id";
            // 
            // repdtngaylap
            // 
            this.repdtngaylap.AutoHeight = false;
            this.repdtngaylap.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repdtngaylap.Name = "repdtngaylap";
            this.repdtngaylap.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // repdtNgayNhap
            // 
            this.repdtNgayNhap.AutoHeight = false;
            this.repdtNgayNhap.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repdtNgayNhap.Name = "repdtNgayNhap";
            this.repdtNgayNhap.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // repdtThoiGian
            // 
            this.repdtThoiGian.AutoHeight = false;
            this.repdtThoiGian.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repdtThoiGian.Name = "repdtThoiGian";
            this.repdtThoiGian.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // repdtNgayNhapMa
            // 
            this.repdtNgayNhapMa.AutoHeight = false;
            this.repdtNgayNhapMa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repdtNgayNhapMa.Name = "repdtNgayNhapMa";
            this.repdtNgayNhapMa.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // frmHT_LockChungTuManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 454);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmHT_LockChungTuManager";
            this.Text = "Quản lý khóa chứng từ";
            this.Load += new System.EventHandler(this.frmHT_LockChungTuManager_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repdtngaylap.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repdtngaylap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repdtNgayNhap.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repdtNgayNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repdtThoiGian.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repdtThoiGian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repdtNgayNhapMa.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repdtNgayNhapMa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton tsbNapDuLieu;
        public System.Windows.Forms.ToolStripButton tsbUnLock;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslInfor;
        private DevExpress.XtraGrid.GridControl dgvList;
        private DevExpress.XtraGrid.Views.Grid.GridView grvChiTiet;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repdtNgayNhap;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repdtThoiGian;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repdtNgayNhapMa;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repTrangThai;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repdtngaylap;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colSoChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn colLockAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colLockMachine;
        private DevExpress.XtraGrid.Columns.GridColumn colProcessId;
        private DevExpress.XtraGrid.Columns.GridColumn colLastUpdateDate;
    }
}