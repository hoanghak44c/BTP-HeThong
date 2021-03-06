using QLBH.Core.Form;

namespace QLBanHang.Modules.HeThong
{
    partial class frmBackupRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackupRestore));
            this.saveBackupDialog = new System.Windows.Forms.SaveFileDialog();
            this.openBackupDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new GtidButton();
            this.btnCreate = new GtidButton();
            this.btnRestore = new GtidButton();
            this.btnConnect = new GtidButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new GtidTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.txtUsername = new GtidTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveBackupDialog
            // 
            this.saveBackupDialog.FileName = "Backup.bak";
            this.saveBackupDialog.Filter = "Backup File|*.bak";
            // 
            // openBackupDialog
            // 
            this.openBackupDialog.FileName = "Backup.bak";
            this.openBackupDialog.Filter = "Backup File|*.bak";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbDatabase);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.btnCreate);
            this.groupBox3.Controls.Add(this.btnRestore);
            this.groupBox3.Location = new System.Drawing.Point(11, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 88);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Location = new System.Drawing.Point(88, 19);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(185, 21);
            this.cmbDatabase.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cơ sở dữ liệu";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(203, 53);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 24);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "   &Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            //this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(52, 53);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(73, 24);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "&Sao lưu ";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseVisualStyleBackColor = true;
            //this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.Image")));
            this.btnRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestore.Location = new System.Drawing.Point(128, 53);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(72, 24);
            this.btnRestore.TabIndex = 6;
            this.btnRestore.Text = "&Phục hồi";
            this.btnRestore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestore.UseVisualStyleBackColor = true;
            //this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(240, 77);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(59, 24);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.UseVisualStyleBackColor = true;
            //this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnConnect);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtPassword);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cmbServer);
            this.groupBox4.Controls.Add(this.txtUsername);
            this.groupBox4.Location = new System.Drawing.Point(11, 49);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(306, 109);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên truy cập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(88, 79);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(148, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên máy chủ";
            // 
            // cmbServer
            // 
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(88, 22);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(148, 21);
            this.cmbServer.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(88, 51);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(148, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(36, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sao lưu và phục hồi dữ liệu";
            // 
            // frmBackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 258);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBackupRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sao lưu và phục hồi dữ liệu";
            //this.Load += new System.EventHandler(this.frmBackupRestore_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveBackupDialog;
        private System.Windows.Forms.OpenFileDialog openBackupDialog;
        private System.Windows.Forms.GroupBox groupBox3;
        private QLBH.Core.Form.GtidButton btnConnect;
        private QLBH.Core.Form.GtidButton btnCreate;
        private QLBH.Core.Form.GtidButton btnRestore;
        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbServer;
        private System.Windows.Forms.TextBox txtUsername;
        internal System.Windows.Forms.Label label3;
        private QLBH.Core.Form.GtidButton btnClose;
        private System.Windows.Forms.ComboBox cmbDatabase;
        private System.Windows.Forms.Label label6;
    }
}