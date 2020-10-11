using QLBH.Core.Form;

namespace QLBanHang.Modules.HeThong
{
    partial class frmHT_ThemNhomNSD
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
            _self = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHT_ThemNhomNSD));
            this.grpNhomNguoiDung = new System.Windows.Forms.GroupBox();
            this.chkSuDung = new System.Windows.Forms.CheckBox();
            this.lblOther = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvGroupList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDanhSachNhomQuyen = new System.Windows.Forms.GroupBox();
            this.chklstRightOfGroup = new System.Windows.Forms.CheckedListBox();
            this.lblCaption = new System.Windows.Forms.Label();
            this.grpThucThi = new System.Windows.Forms.GroupBox();
            this.btnAddNew = new QLBH.Core.Form.GtidButton();
            this.btnDelete = new QLBH.Core.Form.GtidButton();
            this.btnClose = new QLBH.Core.Form.GtidButton();
            this.btnUpdate = new QLBH.Core.Form.GtidButton();
            this.txtId = new QLBH.Core.Form.GtidTextBox();
            this.txtGroupId = new QLBH.Core.Form.GtidTextBox();
            this.txtGroupName = new QLBH.Core.Form.GtidTextBox();
            this.grpNhomNguoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupList)).BeginInit();
            this.grpDanhSachNhomQuyen.SuspendLayout();
            this.grpThucThi.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNhomNguoiDung
            // 
            this.grpNhomNguoiDung.Controls.Add(this.chkSuDung);
            this.grpNhomNguoiDung.Controls.Add(this.lblOther);
            this.grpNhomNguoiDung.Controls.Add(this.txtId);
            this.grpNhomNguoiDung.Controls.Add(this.txtGroupId);
            this.grpNhomNguoiDung.Controls.Add(this.label2);
            this.grpNhomNguoiDung.Controls.Add(this.dgvGroupList);
            this.grpNhomNguoiDung.Controls.Add(this.txtGroupName);
            this.grpNhomNguoiDung.Controls.Add(this.label1);
            this.grpNhomNguoiDung.Location = new System.Drawing.Point(10, 40);
            this.grpNhomNguoiDung.Name = "grpNhomNguoiDung";
            this.grpNhomNguoiDung.Size = new System.Drawing.Size(459, 242);
            this.grpNhomNguoiDung.TabIndex = 0;
            this.grpNhomNguoiDung.TabStop = false;
            // 
            // chkSuDung
            // 
            this.chkSuDung.AutoSize = true;
            this.chkSuDung.Location = new System.Drawing.Point(65, 219);
            this.chkSuDung.Name = "chkSuDung";
            this.chkSuDung.Size = new System.Drawing.Size(15, 14);
            this.chkSuDung.TabIndex = 9;
            this.chkSuDung.UseVisualStyleBackColor = true;
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.ForeColor = System.Drawing.Color.Black;
            this.lblOther.Location = new System.Drawing.Point(7, 221);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(47, 13);
            this.lblOther.TabIndex = 8;
            this.lblOther.Text = "Sử dụng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã nhóm";
            // 
            // dgvGroupList
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGroupList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGroupList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGroupList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGroupList.Location = new System.Drawing.Point(8, 14);
            this.dgvGroupList.Name = "dgvGroupList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGroupList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGroupList.Size = new System.Drawing.Size(441, 144);
            this.dgvGroupList.TabIndex = 1;
            this.dgvGroupList.SelectionChanged += new System.EventHandler(this.dgvGroupList_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhóm";
            // 
            // grpDanhSachNhomQuyen
            // 
            this.grpDanhSachNhomQuyen.Controls.Add(this.chklstRightOfGroup);
            this.grpDanhSachNhomQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhSachNhomQuyen.ForeColor = System.Drawing.Color.Black;
            this.grpDanhSachNhomQuyen.Location = new System.Drawing.Point(10, 287);
            this.grpDanhSachNhomQuyen.Name = "grpDanhSachNhomQuyen";
            this.grpDanhSachNhomQuyen.Size = new System.Drawing.Size(350, 136);
            this.grpDanhSachNhomQuyen.TabIndex = 1;
            this.grpDanhSachNhomQuyen.TabStop = false;
            this.grpDanhSachNhomQuyen.Text = "Danh sách quyền của nhóm";
            // 
            // chklstRightOfGroup
            // 
            this.chklstRightOfGroup.CheckOnClick = true;
            this.chklstRightOfGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklstRightOfGroup.FormattingEnabled = true;
            this.chklstRightOfGroup.Location = new System.Drawing.Point(10, 18);
            this.chklstRightOfGroup.Name = "chklstRightOfGroup";
            this.chklstRightOfGroup.Size = new System.Drawing.Size(332, 109);
            this.chklstRightOfGroup.TabIndex = 4;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCaption.Location = new System.Drawing.Point(146, 7);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(193, 24);
            this.lblCaption.TabIndex = 5;
            this.lblCaption.Text = "NHÓM NGƯỜI DÙNG";
            // 
            // grpThucThi
            // 
            this.grpThucThi.Controls.Add(this.btnAddNew);
            this.grpThucThi.Controls.Add(this.btnDelete);
            this.grpThucThi.Controls.Add(this.btnClose);
            this.grpThucThi.Controls.Add(this.btnUpdate);
            this.grpThucThi.Location = new System.Drawing.Point(371, 287);
            this.grpThucThi.Name = "grpThucThi";
            this.grpThucThi.Size = new System.Drawing.Size(98, 136);
            this.grpThucThi.TabIndex = 43;
            this.grpThucThi.TabStop = false;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Enabled = false;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(8, 15);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnAddNew.Size = new System.Drawing.Size(80, 26);
            this.btnAddNew.TabIndex = 39;
            this.btnAddNew.Text = "    &Thêm mới";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(8, 73);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDelete.Size = new System.Drawing.Size(80, 26);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "&Xóa ";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(8, 102);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnClose.Size = new System.Drawing.Size(80, 26);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(8, 44);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnUpdate.Size = new System.Drawing.Size(80, 26);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "    &Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(257, 217);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(83, 20);
            this.txtId.TabIndex = 4;
            this.txtId.Visible = false;
            // 
            // txtGroupId
            // 
            this.txtGroupId.Location = new System.Drawing.Point(65, 167);
            this.txtGroupId.MaxLength = 5;
            this.txtGroupId.Name = "txtGroupId";
            this.txtGroupId.Size = new System.Drawing.Size(136, 20);
            this.txtGroupId.TabIndex = 2;
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(65, 193);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(384, 20);
            this.txtGroupName.TabIndex = 3;
            // 
            // frmHT_ThemNhomNSD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 421);
            this.Controls.Add(this.grpThucThi);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.grpDanhSachNhomQuyen);
            this.Controls.Add(this.grpNhomNguoiDung);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(489, 459);
            this.MinimumSize = new System.Drawing.Size(489, 459);
            this.Name = "frmHT_ThemNhomNSD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật nhóm người dùng";
            this.Load += new System.EventHandler(this.frmHT_ThemNhomNSD_Load);
            this.grpNhomNguoiDung.ResumeLayout(false);
            this.grpNhomNguoiDung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupList)).EndInit();
            this.grpDanhSachNhomQuyen.ResumeLayout(false);
            this.grpThucThi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public static frmHT_ThemNhomNSD _self = null;
        private System.Windows.Forms.GroupBox grpNhomNguoiDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDanhSachNhomQuyen;
        private System.Windows.Forms.CheckedListBox chklstRightOfGroup;
        private System.Windows.Forms.DataGridView dgvGroupList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.GroupBox grpThucThi;
        internal QLBH.Core.Form.GtidButton btnAddNew;
        internal QLBH.Core.Form.GtidButton btnDelete;
        internal QLBH.Core.Form.GtidButton btnClose;
        internal QLBH.Core.Form.GtidButton btnUpdate;
        private System.Windows.Forms.CheckBox chkSuDung;
        private System.Windows.Forms.Label lblOther;
        private GtidTextBox txtGroupName;
        private GtidTextBox txtGroupId;
        private GtidTextBox txtId;
    }
}