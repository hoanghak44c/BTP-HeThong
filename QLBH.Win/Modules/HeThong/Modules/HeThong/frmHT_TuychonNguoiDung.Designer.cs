using QLBH.Core.Form;

namespace QLBanHang.Modules.HeThong
{
    partial class frmHT_TuychonNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHT_TuychonNguoiDung));
            this.label7 = new System.Windows.Forms.Label();
            this.grpThucThi = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new QLBH.Core.Form.GtidButton();
            this.btnClose = new QLBH.Core.Form.GtidButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBrowser = new QLBH.Core.Form.GtidButton();
            this.txtTempDir = new QLBH.Core.Form.GtidTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkChonKho = new System.Windows.Forms.CheckBox();
            this.cboGiaoDienMacDinh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkInPhieuThu = new System.Windows.Forms.CheckBox();
            this.chkInHoaDon = new System.Windows.Forms.CheckBox();
            this.chkInPhieuXuat = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.grpThucThi.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(109, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "TÙY CHỌN NGƯỜI DÙNG";
            // 
            // grpThucThi
            // 
            this.grpThucThi.Controls.Add(this.btnUpdate);
            this.grpThucThi.Controls.Add(this.btnClose);
            this.grpThucThi.ForeColor = System.Drawing.Color.Black;
            this.grpThucThi.Location = new System.Drawing.Point(20, 214);
            this.grpThucThi.Name = "grpThucThi";
            this.grpThucThi.Size = new System.Drawing.Size(419, 50);
            this.grpThucThi.TabIndex = 41;
            this.grpThucThi.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(132, 16);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnUpdate.Size = new System.Drawing.Size(80, 25);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "    &Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(217, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnClose.Size = new System.Drawing.Size(80, 25);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(21, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(418, 162);
            this.tabControl1.TabIndex = 42;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBrowser);
            this.tabPage1.Controls.Add(this.txtTempDir);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.chkChonKho);
            this.tabPage1.Controls.Add(this.cboGiaoDienMacDinh);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(410, 136);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thiết lập chung";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowser.Image")));
            this.btnBrowser.Location = new System.Drawing.Point(358, 97);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnBrowser.Size = new System.Drawing.Size(34, 23);
            this.btnBrowser.TabIndex = 5;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // txtTempDir
            // 
            this.txtTempDir.Location = new System.Drawing.Point(126, 99);
            this.txtTempDir.Name = "txtTempDir";
            this.txtTempDir.Size = new System.Drawing.Size(225, 20);
            this.txtTempDir.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thư mục lưu báo cáo";
            // 
            // chkChonKho
            // 
            this.chkChonKho.AutoSize = true;
            this.chkChonKho.Location = new System.Drawing.Point(126, 70);
            this.chkChonKho.Name = "chkChonKho";
            this.chkChonKho.Size = new System.Drawing.Size(172, 17);
            this.chkChonKho.TabIndex = 2;
            this.chkChonKho.Text = "Chọn kho khi vào chương trình";
            this.chkChonKho.UseVisualStyleBackColor = true;
            // 
            // cboGiaoDienMacDinh
            // 
            this.cboGiaoDienMacDinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGiaoDienMacDinh.FormattingEnabled = true;
            this.cboGiaoDienMacDinh.Location = new System.Drawing.Point(126, 29);
            this.cboGiaoDienMacDinh.Name = "cboGiaoDienMacDinh";
            this.cboGiaoDienMacDinh.Size = new System.Drawing.Size(225, 21);
            this.cboGiaoDienMacDinh.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giao diện mặc định";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkInPhieuThu);
            this.tabPage2.Controls.Add(this.chkInHoaDon);
            this.tabPage2.Controls.Add(this.chkInPhieuXuat);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(410, 136);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "In ấn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chkInPhieuThu
            // 
            this.chkInPhieuThu.AutoSize = true;
            this.chkInPhieuThu.Location = new System.Drawing.Point(87, 94);
            this.chkInPhieuThu.Name = "chkInPhieuThu";
            this.chkInPhieuThu.Size = new System.Drawing.Size(147, 17);
            this.chkInPhieuThu.TabIndex = 26;
            this.chkInPhieuThu.Text = "In phiếu thu khi bán hàng";
            this.chkInPhieuThu.UseVisualStyleBackColor = true;
            // 
            // chkInHoaDon
            // 
            this.chkInHoaDon.AutoSize = true;
            this.chkInHoaDon.Location = new System.Drawing.Point(87, 58);
            this.chkInHoaDon.Name = "chkInHoaDon";
            this.chkInHoaDon.Size = new System.Drawing.Size(143, 17);
            this.chkInHoaDon.TabIndex = 25;
            this.chkInHoaDon.Text = "In hóa đơn khi bán hàng";
            this.chkInHoaDon.UseVisualStyleBackColor = true;
            // 
            // chkInPhieuXuat
            // 
            this.chkInPhieuXuat.AutoSize = true;
            this.chkInPhieuXuat.Location = new System.Drawing.Point(87, 24);
            this.chkInPhieuXuat.Name = "chkInPhieuXuat";
            this.chkInPhieuXuat.Size = new System.Drawing.Size(152, 17);
            this.chkInPhieuXuat.TabIndex = 24;
            this.chkInPhieuXuat.Text = "In phiếu xuất khi bán hàng";
            this.chkInPhieuXuat.UseVisualStyleBackColor = true;
            // 
            // frmHT_TuychonNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 277);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grpThucThi);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHT_TuychonNguoiDung";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập tùy chọn người dùng";
            this.Load += new System.EventHandler(this.frmThongTin_Load);
            this.grpThucThi.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        internal QLBH.Core.Form.GtidButton btnClose;
        internal QLBH.Core.Form.GtidButton btnUpdate;
        private System.Windows.Forms.GroupBox grpThucThi;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chkInPhieuThu;
        private System.Windows.Forms.CheckBox chkInHoaDon;
        private System.Windows.Forms.CheckBox chkInPhieuXuat;
        private System.Windows.Forms.CheckBox chkChonKho;
        private System.Windows.Forms.ComboBox cboGiaoDienMacDinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private QLBH.Core.Form.GtidButton btnBrowser;
        private GtidTextBox txtTempDir;
    }
}