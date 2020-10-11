using QLBH.Core.Form;

namespace QLBanHang.Modules.HeThong
{
    partial class frmHT_ThamSo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHT_ThamSo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new GtidButton();
            this.btnUpdate = new GtidButton();
            this.grpThucThi = new System.Windows.Forms.GroupBox();
            this.chkInPhieuXuat = new System.Windows.Forms.CheckBox();
            this.chkInHoaDon = new System.Windows.Forms.CheckBox();
            this.cboLoaiTien = new System.Windows.Forms.ComboBox();
            this.cboTrungTam = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.grpThucThi.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTrungTam);
            this.groupBox1.Controls.Add(this.cboLoaiTien);
            this.groupBox1.Controls.Add(this.chkInHoaDon);
            this.groupBox1.Controls.Add(this.chkInPhieuXuat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trung tâm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn vị tiền tệ mặc định";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(126, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "THAM SỐ HỆ THỐNG";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(219, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 25);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "&Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(135, 16);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 25);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "    &Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpThucThi
            // 
            this.grpThucThi.Controls.Add(this.btnUpdate);
            this.grpThucThi.Controls.Add(this.btnClose);
            this.grpThucThi.ForeColor = System.Drawing.Color.Black;
            this.grpThucThi.Location = new System.Drawing.Point(10, 158);
            this.grpThucThi.Name = "grpThucThi";
            this.grpThucThi.Size = new System.Drawing.Size(422, 50);
            this.grpThucThi.TabIndex = 41;
            this.grpThucThi.TabStop = false;
            // 
            // chkInPhieuXuat
            // 
            this.chkInPhieuXuat.AutoSize = true;
            this.chkInPhieuXuat.Location = new System.Drawing.Point(125, 76);
            this.chkInPhieuXuat.Name = "chkInPhieuXuat";
            this.chkInPhieuXuat.Size = new System.Drawing.Size(152, 17);
            this.chkInPhieuXuat.TabIndex = 22;
            this.chkInPhieuXuat.Text = "In phiếu xuất khi bán hàng";
            this.chkInPhieuXuat.UseVisualStyleBackColor = true;
            // 
            // chkInHoaDon
            // 
            this.chkInHoaDon.AutoSize = true;
            this.chkInHoaDon.Location = new System.Drawing.Point(125, 99);
            this.chkInHoaDon.Name = "chkInHoaDon";
            this.chkInHoaDon.Size = new System.Drawing.Size(143, 17);
            this.chkInHoaDon.TabIndex = 23;
            this.chkInHoaDon.Text = "In hóa đơn khi bán hàng";
            this.chkInHoaDon.UseVisualStyleBackColor = true;
            // 
            // cboLoaiTien
            // 
            this.cboLoaiTien.FormattingEnabled = true;
            this.cboLoaiTien.Location = new System.Drawing.Point(125, 47);
            this.cboLoaiTien.Name = "cboLoaiTien";
            this.cboLoaiTien.Size = new System.Drawing.Size(143, 21);
            this.cboLoaiTien.TabIndex = 24;
            // 
            // cboTrungTam
            // 
            this.cboTrungTam.FormattingEnabled = true;
            this.cboTrungTam.Location = new System.Drawing.Point(125, 20);
            this.cboTrungTam.Name = "cboTrungTam";
            this.cboTrungTam.Size = new System.Drawing.Size(283, 21);
            this.cboTrungTam.TabIndex = 25;
            // 
            // frmHT_ThamSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 217);
            this.Controls.Add(this.grpThucThi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmHT_ThamSo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập tham số hệ thống";
            this.Load += new System.EventHandler(this.frmThongTin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpThucThi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        internal QLBH.Core.Form.GtidButton btnClose;
        internal QLBH.Core.Form.GtidButton btnUpdate;
        private System.Windows.Forms.GroupBox grpThucThi;
        private System.Windows.Forms.ComboBox cboTrungTam;
        private System.Windows.Forms.ComboBox cboLoaiTien;
        private System.Windows.Forms.CheckBox chkInHoaDon;
        private System.Windows.Forms.CheckBox chkInPhieuXuat;
    }
}