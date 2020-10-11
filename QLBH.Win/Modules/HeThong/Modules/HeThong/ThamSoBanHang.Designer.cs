using QLBH.Core.Form;

namespace QLBanHang.Modules.HeThong
{
    partial class ThamSoBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThamSoBanHang));
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btnUpdate = new QLBH.Core.Form.GtidButton();
            this.txtlstsuackhaukolenodt = new QLBH.Core.Form.GtidTextBox();
            this.btnClose = new QLBH.Core.Form.GtidButton();
            this.txtlstsuagiaban = new QLBH.Core.Form.GtidTextBox();
            this.txtlstkmduocbanod = new QLBH.Core.Form.GtidTextBox();
            this.txtlstsuackhaukolenod = new QLBH.Core.Form.GtidTextBox();
            this.txtlstnotinhoadon = new QLBH.Core.Form.GtidTextBox();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "Mã Ckhấu sửa giá bán không lên ODT";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(4, 316);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(192, 13);
            this.label19.TabIndex = 28;
            this.label19.Text = "Mã Khuyến mại được lập đơn hàng bán";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 259);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(181, 13);
            this.label20.TabIndex = 27;
            this.label20.Text = "Mã CKhấu sửa giá bán không lên OD";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(51, 28);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(145, 13);
            this.label22.TabIndex = 25;
            this.label22.Text = "Mã có tồn không lên hóa đơn";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(62, 91);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(134, 13);
            this.label23.TabIndex = 24;
            this.label23.Text = "Mã hàng được sửa giá bán";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(201, 373);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnUpdate.Size = new System.Drawing.Size(102, 25);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "&Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtlstsuackhaukolenodt
            // 
            this.txtlstsuackhaukolenodt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlstsuackhaukolenodt.Location = new System.Drawing.Point(201, 187);
            this.txtlstsuackhaukolenodt.Multiline = true;
            this.txtlstsuackhaukolenodt.Name = "txtlstsuackhaukolenodt";
            this.txtlstsuackhaukolenodt.Size = new System.Drawing.Size(440, 63);
            this.txtlstsuackhaukolenodt.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(309, 373);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnClose.Size = new System.Drawing.Size(105, 25);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtlstsuagiaban
            // 
            this.txtlstsuagiaban.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlstsuagiaban.Location = new System.Drawing.Point(201, 88);
            this.txtlstsuagiaban.Multiline = true;
            this.txtlstsuagiaban.Name = "txtlstsuagiaban";
            this.txtlstsuagiaban.Size = new System.Drawing.Size(440, 93);
            this.txtlstsuagiaban.TabIndex = 2;
            // 
            // txtlstkmduocbanod
            // 
            this.txtlstkmduocbanod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlstkmduocbanod.Location = new System.Drawing.Point(201, 312);
            this.txtlstkmduocbanod.Multiline = true;
            this.txtlstkmduocbanod.Name = "txtlstkmduocbanod";
            this.txtlstkmduocbanod.Size = new System.Drawing.Size(440, 49);
            this.txtlstkmduocbanod.TabIndex = 7;
            // 
            // txtlstsuackhaukolenod
            // 
            this.txtlstsuackhaukolenod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlstsuackhaukolenod.Location = new System.Drawing.Point(201, 256);
            this.txtlstsuackhaukolenod.Multiline = true;
            this.txtlstsuackhaukolenod.Name = "txtlstsuackhaukolenod";
            this.txtlstsuackhaukolenod.Size = new System.Drawing.Size(440, 50);
            this.txtlstsuackhaukolenod.TabIndex = 6;
            // 
            // txtlstnotinhoadon
            // 
            this.txtlstnotinhoadon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlstnotinhoadon.Location = new System.Drawing.Point(201, 25);
            this.txtlstnotinhoadon.Multiline = true;
            this.txtlstnotinhoadon.Name = "txtlstnotinhoadon";
            this.txtlstnotinhoadon.Size = new System.Drawing.Size(440, 57);
            this.txtlstnotinhoadon.TabIndex = 1;
            // 
            // ThamSoBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 411);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtlstsuackhaukolenodt);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtlstsuagiaban);
            this.Controls.Add(this.txtlstkmduocbanod);
            this.Controls.Add(this.txtlstsuackhaukolenod);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtlstnotinhoadon);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThamSoBanHang";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập tham số bán hàng";
            this.Load += new System.EventHandler(this.frmThongTin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal QLBH.Core.Form.GtidButton btnClose;
        internal QLBH.Core.Form.GtidButton btnUpdate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private GtidTextBox txtlstsuackhaukolenodt;
        private GtidTextBox txtlstkmduocbanod;
        private GtidTextBox txtlstsuackhaukolenod;
        private GtidTextBox txtlstsuagiaban;
        private GtidTextBox txtlstnotinhoadon;
    }
}