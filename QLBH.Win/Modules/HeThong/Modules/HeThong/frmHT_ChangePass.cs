// <summary>
// Mô tả class: Lớp đối tượng thực hiện việc thay đổi mật khẩu người dùng
// </summary>
// <remarks>
// Người tạo: Nguyen Gia Dang
// Ngày tạo: 09/10/2007
// </remarks>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using QLBH.Common;
using QLBanHang.Modules.HeThong.Providers;
using QLBanHang.Modules.HeThong.Infors;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmHT_ChangePass : DevExpress.XtraEditors.XtraForm
    {
        private NguoiDungInfor objUser = (NguoiDungInfor)Declare.USER_INFOR;
        private bool ResetPW = false;
        public frmHT_ChangePass()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        public frmHT_ChangePass(NguoiDungInfor user)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.objUser = user;
        }

        public frmHT_ChangePass(NguoiDungInfor user, bool resetPW)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.objUser = user;
            this.ResetPW = resetPW;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "")
            {
                if (!ResetPW && !Common.Int2Bool(((NguoiDungInfor)Declare.USER_INFOR).SupperUser))
                {
                    string oldPass = Password.SetPassword(txtOldPass.Text, objUser.Salt);
                    if (oldPass != objUser.MatKhau)
                    {
                        MessageBox.Show(Declare.msgChangePass_WrongPassword, Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtOldPass.Focus();
                        return;
                    }

                    if (txtNewPass.Text == txtOldPass.Text)
                    {
                        MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNewPass.Focus();
                        return;
                    }
                }
                if (txtNewPass.Text != txtRetypePass.Text)
                { 
                    MessageBox.Show(Declare.msgChangePass_RetypePass,Declare.titleWarning,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    txtRetypePass.Focus();
                    return;
                }
                try
                {
                    string mySalt = Password.CreateSalt();
                    string newPass = Password.SetPassword(txtNewPass.Text, mySalt);
                    objUser.MatKhau = newPass;
                    objUser.Salt = mySalt;

                    objUser.ChangeOnNext = chkForceChangeAtFirst.Enabled;

                    if (chkForceChangeAtFirst.Enabled)
                        objUser.ChangeOnNext = chkForceChangeAtFirst.Checked;

                    NguoiDungDataProvider.Update(objUser);
                    
                    NguoiDungDataProvider.ChangePass(objUser.IdNguoiDung, newPass);                                    
                    
                    MessageBox.Show(Declare.msgChangePass_PassHasChanged, Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Declare.msgUpdateErr, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void frmChangePass_Load(object sender, EventArgs e)
        {
            txtUserName.Text = objUser.TenDangNhap + "(" + objUser.TenDayDu + ")";
            txtOldPass.ReadOnly = ResetPW;
            txtOldPass.Focus();
            chkForceChangeAtFirst.Enabled = ResetPW;
            chkForceChangeAtFirst.Checked = ResetPW;
        }

        private void txtOldPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnUpdate_Click(sender, e);
            }
        }

        private void txtNewPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnUpdate_Click(sender, e);
            }
        }

        private void txtRetypePass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnUpdate_Click(sender, e);
            }
        }
    }
}