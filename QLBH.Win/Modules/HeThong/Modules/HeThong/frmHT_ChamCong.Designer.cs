namespace QLBanHang.Modules.HeThong
{
    partial class frmHT_ChamCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHT_ChamCong));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnTruoc = new System.Windows.Forms.ToolStripButton();
            this.btnSau = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSaoChep = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDong = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dtNgayCham = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboKho = new System.Windows.Forms.ComboBox();
            this.gv = new System.Windows.Forms.DataGridView();
            this.colIdChiTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiLam = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkLstNguoiCham = new System.Windows.Forms.CheckedListBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTruoc,
            this.btnSau,
            this.toolStripSeparator1,
            this.btnThem,
            this.btnSaoChep,
            this.btnSua,
            this.btnCapNhat,
            this.btnXoa,
            this.toolStripSeparator2,
            this.btnDong,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(681, 25);
            this.toolStrip1.TabIndex = 48;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnTruoc
            // 
            this.btnTruoc.Image = ((System.Drawing.Image)(resources.GetObject("btnTruoc.Image")));
            this.btnTruoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(78, 22);
            this.btnTruoc.Text = "Trước (F3)";
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnSau
            // 
            this.btnSau.Image = ((System.Drawing.Image)(resources.GetObject("btnSau.Image")));
            this.btnSau.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(68, 22);
            this.btnSau.Text = "Sau (F4)";
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(76, 22);
            this.btnThem.Text = "Thêm (F5)";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSaoChep
            // 
            this.btnSaoChep.Image = ((System.Drawing.Image)(resources.GetObject("btnSaoChep.Image")));
            this.btnSaoChep.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaoChep.Name = "btnSaoChep";
            this.btnSaoChep.Size = new System.Drawing.Size(71, 22);
            this.btnSaoChep.Text = "Sao chép";
            this.btnSaoChep.Visible = false;
            this.btnSaoChep.Click += new System.EventHandler(this.btnSaoChep_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(69, 22);
            this.btnSua.Text = "Sửa (F6)";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(94, 22);
            this.btnCapNhat.Text = "Cập nhật (F7)";
            this.btnCapNhat.Click += new System.EventHandler(this.cmdCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(68, 22);
            this.btnXoa.Text = "Xóa (F8)";
            this.btnXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(82, 22);
            this.btnDong.Text = "Đóng (F12)";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(110, 22);
            this.toolStripLabel1.Text = "CHẤM CÔNG";
            // 
            // dtNgayCham
            // 
            this.dtNgayCham.CustomFormat = "dd/MM/yyyy";
            this.dtNgayCham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayCham.Location = new System.Drawing.Point(319, 56);
            this.dtNgayCham.Name = "dtNgayCham";
            this.dtNgayCham.Size = new System.Drawing.Size(98, 20);
            this.dtNgayCham.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Ngày chấm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Người chấm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Cửa hàng";
            // 
            // cboKho
            // 
            this.cboKho.FormattingEnabled = true;
            this.cboKho.Location = new System.Drawing.Point(319, 114);
            this.cboKho.Name = "cboKho";
            this.cboKho.Size = new System.Drawing.Size(352, 21);
            this.cboKho.TabIndex = 66;
            this.cboKho.SelectedIndexChanged += new System.EventHandler(this.cboKho_SelectedIndexChanged);
            this.cboKho.Click += new System.EventHandler(this.cboKho_Click);
            // 
            // gv
            // 
            this.gv.AllowUserToAddRows = false;
            this.gv.AllowUserToDeleteRows = false;
            this.gv.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.gv.AutoGenerateColumns = global::QLBanHang.Properties.Settings.Default.F;
            this.gv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdChiTiet,
            this.colIdNhanVien,
            this.colMaNhanVien,
            this.colTenNhanVien,
            this.colDiLam,
            this.colThoiGian,
            this.colGhiChu});
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv.DefaultCellStyle = dataGridViewCellStyle25;
            this.gv.Location = new System.Drawing.Point(13, 152);
            this.gv.Name = "gv";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.gv.RowHeadersVisible = false;
            this.gv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gv.Size = new System.Drawing.Size(658, 347);
            this.gv.TabIndex = 68;
            this.gv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellEndEdit);
            this.gv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gv_DataError);
            // 
            // colIdChiTiet
            // 
            this.colIdChiTiet.DataPropertyName = "IdChiTiet";
            this.colIdChiTiet.HeaderText = "IdChiTiet";
            this.colIdChiTiet.Name = "colIdChiTiet";
            this.colIdChiTiet.Visible = false;
            // 
            // colIdNhanVien
            // 
            this.colIdNhanVien.DataPropertyName = "IdNhanVien";
            dataGridViewCellStyle23.NullValue = "0";
            this.colIdNhanVien.DefaultCellStyle = dataGridViewCellStyle23;
            this.colIdNhanVien.HeaderText = "IdNhanVien";
            this.colIdNhanVien.Name = "colIdNhanVien";
            this.colIdNhanVien.Visible = false;
            this.colIdNhanVien.Width = 80;
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.DataPropertyName = "MaNhanVien";
            this.colMaNhanVien.HeaderText = "Mã nhân viên";
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colMaNhanVien.Width = 120;
            // 
            // colTenNhanVien
            // 
            this.colTenNhanVien.DataPropertyName = "TenNhanVien";
            this.colTenNhanVien.HeaderText = "Tên nhân viên";
            this.colTenNhanVien.Name = "colTenNhanVien";
            this.colTenNhanVien.ReadOnly = true;
            this.colTenNhanVien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTenNhanVien.Width = 150;
            // 
            // colDiLam
            // 
            this.colDiLam.DataPropertyName = "DiLam";
            this.colDiLam.HeaderText = "Đi làm";
            this.colDiLam.IndeterminateValue = "true";
            this.colDiLam.Name = "colDiLam";
            this.colDiLam.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDiLam.Width = 80;
            // 
            // colThoiGian
            // 
            this.colThoiGian.DataPropertyName = "ThoiGian";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.Format = "t";
            dataGridViewCellStyle24.NullValue = null;
            this.colThoiGian.DefaultCellStyle = dataGridViewCellStyle24;
            this.colThoiGian.HeaderText = "Thời gian";
            this.colThoiGian.Name = "colThoiGian";
            this.colThoiGian.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colThoiGian.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colThoiGian.Width = 90;
            // 
            // colGhiChu
            // 
            this.colGhiChu.DataPropertyName = "GhiChu";
            this.colGhiChu.HeaderText = "Ghi chú";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colGhiChu.Width = 200;
            // 
            // chkLstNguoiCham
            // 
            this.chkLstNguoiCham.CheckOnClick = true;
            this.chkLstNguoiCham.FormattingEnabled = true;
            this.chkLstNguoiCham.Location = new System.Drawing.Point(12, 56);
            this.chkLstNguoiCham.Name = "chkLstNguoiCham";
            this.chkLstNguoiCham.Size = new System.Drawing.Size(298, 79);
            this.chkLstNguoiCham.TabIndex = 69;
            // 
            // frmHT_ChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 511);
            this.Controls.Add(this.chkLstNguoiCham);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.cboKho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtNgayCham);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.Name = "frmHT_ChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chấm công nhân viên";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHT_ChamCong_KeyDown);
            this.Load += new System.EventHandler(this.frmHT_ChamCong_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnTruoc;
        private System.Windows.Forms.ToolStripButton btnSau;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnCapNhat;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnDong;
        private System.Windows.Forms.DateTimePicker dtNgayCham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboKho;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.ToolStripButton btnSaoChep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhanVien;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDiLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.CheckedListBox chkLstNguoiCham;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}