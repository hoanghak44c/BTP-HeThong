using QLBH.Core.Form;

namespace QLBanHang.Modules.HeThong
{
    partial class frmKhoHienTai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoHienTai));
            this.Label5 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboCurrentWareHouse = new System.Windows.Forms.ComboBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaDoiTuong = new QLBH.Core.Form.GtidTextBox();
            this.txtMaLoaiDT = new QLBH.Core.Form.GtidTextBox();
            this.txtMaKho = new QLBH.Core.Form.GtidTextBox();
            this.txtMaTrungTam = new QLBH.Core.Form.GtidTextBox();
            this.cboCurrentDoiTuong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCurrentLoaiDT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCurrentTrungTam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new QLBH.Core.Form.GtidButton();
            this.btnUpdate = new QLBH.Core.Form.GtidButton();
            this.grpThucThi = new System.Windows.Forms.GroupBox();
            this.GroupBox1.SuspendLayout();
            this.grpThucThi.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Label5.Location = new System.Drawing.Point(145, 9);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(227, 24);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "KHO LÀM VIỆC HIỆN TẠI";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(7, 45);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(47, 13);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Tên kho";
            // 
            // cboCurrentWareHouse
            // 
            this.cboCurrentWareHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurrentWareHouse.FormattingEnabled = true;
            this.cboCurrentWareHouse.Location = new System.Drawing.Point(235, 42);
            this.cboCurrentWareHouse.Name = "cboCurrentWareHouse";
            this.cboCurrentWareHouse.Size = new System.Drawing.Size(283, 21);
            this.cboCurrentWareHouse.TabIndex = 19;
            this.cboCurrentWareHouse.SelectedIndexChanged += new System.EventHandler(this.cboCurrentWareHouse_SelectedIndexChanged);
            this.cboCurrentWareHouse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboCurrentWareHouse_Enter);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtMaDoiTuong);
            this.GroupBox1.Controls.Add(this.txtMaLoaiDT);
            this.GroupBox1.Controls.Add(this.txtMaKho);
            this.GroupBox1.Controls.Add(this.txtMaTrungTam);
            this.GroupBox1.Controls.Add(this.cboCurrentDoiTuong);
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.cboCurrentLoaiDT);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.cboCurrentTrungTam);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.cboCurrentWareHouse);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(8, 38);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(526, 127);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            // 
            // txtMaDoiTuong
            // 
            this.txtMaDoiTuong.Location = new System.Drawing.Point(101, 96);
            this.txtMaDoiTuong.Name = "txtMaDoiTuong";
            this.txtMaDoiTuong.Size = new System.Drawing.Size(128, 20);
            this.txtMaDoiTuong.TabIndex = 47;
            this.txtMaDoiTuong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaDoiTuong_KeyDown);
            this.txtMaDoiTuong.Leave += new System.EventHandler(this.txtMaDoiTuong_Leave);
            // 
            // txtMaLoaiDT
            // 
            this.txtMaLoaiDT.Location = new System.Drawing.Point(101, 69);
            this.txtMaLoaiDT.Name = "txtMaLoaiDT";
            this.txtMaLoaiDT.Size = new System.Drawing.Size(128, 20);
            this.txtMaLoaiDT.TabIndex = 46;
            this.txtMaLoaiDT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaLoaiDT_KeyDown);
            this.txtMaLoaiDT.Leave += new System.EventHandler(this.txtMaLoaiDT_Leave);
            // 
            // txtMaKho
            // 
            this.txtMaKho.Location = new System.Drawing.Point(101, 42);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(128, 20);
            this.txtMaKho.TabIndex = 45;
            this.txtMaKho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaKho_KeyDown);
            this.txtMaKho.Leave += new System.EventHandler(this.txtMaKho_Leave);
            // 
            // txtMaTrungTam
            // 
            this.txtMaTrungTam.Location = new System.Drawing.Point(101, 15);
            this.txtMaTrungTam.Name = "txtMaTrungTam";
            this.txtMaTrungTam.Size = new System.Drawing.Size(128, 20);
            this.txtMaTrungTam.TabIndex = 44;
            this.txtMaTrungTam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaTrungTam_KeyDown);
            this.txtMaTrungTam.Leave += new System.EventHandler(this.txtMaTrungTam_Leave);
            // 
            // cboCurrentDoiTuong
            // 
            this.cboCurrentDoiTuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurrentDoiTuong.FormattingEnabled = true;
            this.cboCurrentDoiTuong.Location = new System.Drawing.Point(235, 96);
            this.cboCurrentDoiTuong.Name = "cboCurrentDoiTuong";
            this.cboCurrentDoiTuong.Size = new System.Drawing.Size(283, 21);
            this.cboCurrentDoiTuong.TabIndex = 25;
            this.cboCurrentDoiTuong.SelectedIndexChanged += new System.EventHandler(this.cboCurrentDoiTuong_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Khách hàng";
            // 
            // cboCurrentLoaiDT
            // 
            this.cboCurrentLoaiDT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurrentLoaiDT.FormattingEnabled = true;
            this.cboCurrentLoaiDT.Location = new System.Drawing.Point(235, 69);
            this.cboCurrentLoaiDT.Name = "cboCurrentLoaiDT";
            this.cboCurrentLoaiDT.Size = new System.Drawing.Size(283, 21);
            this.cboCurrentLoaiDT.TabIndex = 23;
            this.cboCurrentLoaiDT.SelectedIndexChanged += new System.EventHandler(this.cboCurrentLoaiDT_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Loại khách hàng";
            // 
            // cboCurrentTrungTam
            // 
            this.cboCurrentTrungTam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurrentTrungTam.FormattingEnabled = true;
            this.cboCurrentTrungTam.Location = new System.Drawing.Point(235, 15);
            this.cboCurrentTrungTam.Name = "cboCurrentTrungTam";
            this.cboCurrentTrungTam.Size = new System.Drawing.Size(283, 21);
            this.cboCurrentTrungTam.TabIndex = 21;
            this.cboCurrentTrungTam.SelectedIndexChanged += new System.EventHandler(this.cboCurrentTrungTam_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Trung tâm";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(264, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnClose.Size = new System.Drawing.Size(80, 25);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(180, 15);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnUpdate.Size = new System.Drawing.Size(80, 25);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "&Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpThucThi
            // 
            this.grpThucThi.Controls.Add(this.btnClose);
            this.grpThucThi.Controls.Add(this.btnUpdate);
            this.grpThucThi.ForeColor = System.Drawing.Color.Black;
            this.grpThucThi.Location = new System.Drawing.Point(8, 171);
            this.grpThucThi.Name = "grpThucThi";
            this.grpThucThi.Size = new System.Drawing.Size(526, 50);
            this.grpThucThi.TabIndex = 43;
            this.grpThucThi.TabStop = false;
            // 
            // frmKhoHienTai
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(543, 227);
            this.Controls.Add(this.grpThucThi);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKhoHienTai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho hiện tại";
            this.Load += new System.EventHandler(this.frmKhoHienTai_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKhoHienTai_FormClosed);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.grpThucThi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cboCurrentWareHouse;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.GroupBox grpThucThi;
        internal GtidButton btnClose;
        internal GtidButton btnUpdate;
        internal System.Windows.Forms.ComboBox cboCurrentTrungTam;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox cboCurrentDoiTuong;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ComboBox cboCurrentLoaiDT;
        internal System.Windows.Forms.Label label3;
        private GtidTextBox txtMaDoiTuong;
        private GtidTextBox txtMaLoaiDT;
        private GtidTextBox txtMaKho;
        private GtidTextBox txtMaTrungTam;
    }
}