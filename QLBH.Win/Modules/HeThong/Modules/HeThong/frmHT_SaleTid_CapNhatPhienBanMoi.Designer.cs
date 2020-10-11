namespace QLBanHang.Modules.HeThong
{
    partial class frmHT_SaleTid_CapNhatPhienBanMoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHT_SaleTid_CapNhatPhienBanMoi));
            this.bteUpdatePack = new DevExpress.XtraEditors.ButtonEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.bteUpdatePack.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bteUpdatePack
            // 
            this.bteUpdatePack.Location = new System.Drawing.Point(74, 12);
            this.bteUpdatePack.Name = "bteUpdatePack";
            this.bteUpdatePack.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteUpdatePack.Properties.Appearance.Options.UseFont = true;
            this.bteUpdatePack.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.bteUpdatePack.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White;
            this.bteUpdatePack.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.bteUpdatePack.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteUpdatePack.Properties.ReadOnly = true;
            this.bteUpdatePack.Size = new System.Drawing.Size(206, 22);
            this.bteUpdatePack.TabIndex = 127;
            this.bteUpdatePack.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteUpdatePack_ButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 126;
            this.label2.Text = "Gói mới:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(194, 58);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 25);
            this.btnSave.TabIndex = 138;
            this.btnSave.Text = "&Cập nhật";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmHT_SaleTid_CapNhatPhienBanMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 95);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.bteUpdatePack);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHT_SaleTid_CapNhatPhienBanMoi";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nâng cấp phiên bản mới";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHT_SaleTid_CapNhatPhienBanMoi_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.bteUpdatePack.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ButtonEdit bteUpdatePack;
        internal System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}