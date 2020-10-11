using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using QLBanHang.Modules.DanhMuc;
using QLBH.Common;
using QLBanHang.Modules.HeThong.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common.Providers;
using QLBH.Core.Exceptions;
using QLBH.Core.Providers;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmHT_AddNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        #region Decalre .....
        // khởi tạo..
        private NguoiDungInfor objNguoiDung = null;
        private frmHT_ListNguoiDung frm = new frmHT_ListNguoiDung();
        #endregion

        public frmHT_AddNguoiDung()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        public frmHT_AddNguoiDung(frmHT_ListNguoiDung frm)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.frm = frm;
        }

        public frmHT_AddNguoiDung(NguoiDungInfor objNguoiDung, frmHT_ListNguoiDung frm)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.objNguoiDung = objNguoiDung;
            this.frm = frm;
        }

        private void frmHT_AddNguoiDung_Load(object sender, EventArgs e)
        {
            LoadNhomNguoiDung();
            if (objNguoiDung != null)
            {
                txtUserName.ReadOnly = true;
                txtPassword.ReadOnly = true;
                txtRetypePassword.ReadOnly = true;

                txtFullName.Text = objNguoiDung.TenDayDu;
                txtUserName.Text = objNguoiDung.TenDangNhap;
                txtPassword.Text = objNguoiDung.MatKhau;
                txtRetypePassword.Text = objNguoiDung.MatKhau;
                chkSuDung.Checked = objNguoiDung.SuDung;// (objNguoiDung.SuDung == 1 ? true : false);
                chkSuperUser.Checked = Common.Int2Bool(objNguoiDung.SupperUser);
                DMNhanVienInfo nv = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(objNguoiDung.IdNhanVien);
                bteThuongVien.Text = nv.HoTen;
                bteThuongVien.Tag = nv;
                cboGroup.SelectedValue = objNguoiDung.IdNhomNguoiDung;
                
                if(objNguoiDung.ThoiGianApDung == -1)
                {
                    chkNeverExpired.Checked = true;
                    chkForceChangeOnExpired.Checked = false;
                    chkForceChangeOnExpired.Enabled = false;
                    txtExpiredIn.Enabled = false;
                    txtExpiredIn.Text = "30";
                } 
                else
                {
                    chkNeverExpired.Checked = false;
                    chkNeverExpired.Enabled = false;
                    chkForceChangeOnExpired.Checked = true;
                    txtExpiredIn.Enabled = true;
                    txtExpiredIn.Text = objNguoiDung.ThoiGianApDung == -1 ? "30" :
                        objNguoiDung.ThoiGianApDung.ToString();
                }

                chkForceChangeAtFirst.Checked = objNguoiDung.ChangeOnNext;
            }
        }

        private void LoadNhomNguoiDung()
        {
            cboGroup.DataSource = NhomNguoiDungDataProvider.LoadAll();
            cboGroup.DisplayMember = "TenNhom";
            cboGroup.ValueMember = "IdNhomNguoiDung";
            cboGroup.SelectedIndex = -1; 

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text.Trim().Equals(""))
                {
                    MessageBox.Show(Declare.msgInputData, Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Focus();
                    return;
                }

                if (txtPassword.Text.Trim() != txtRetypePassword.Text.Trim())
                {
                    MessageBox.Show("Xác nhận lại mật khẩu!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRetypePassword.Focus();
                    return;
                }

                if (bteThuongVien.Tag == null)
                {
                    MessageBox.Show("Phải chọn nhân viên!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    bteThuongVien.Focus();
                    return;
                }

                if (!String.IsNullOrEmpty(txtExpiredIn.Text) && !Common.IsNumeric4(txtExpiredIn.Text))
                {
                    txtExpiredIn.Focus();

                    throw new ManagedException("Thời gian áp dụng không đúng định dạng.");
                }

                if (Convert.ToInt32(txtExpiredIn.Text) < 0)
                {
                    throw new ManagedException("Thời gian áp dụng phải lớn hơn hoặc bằng 0.");
                }

                if (objNguoiDung == null)
                {
                    if (NguoiDungDataProvider.Exist(txtUserName.Text.Trim()))
                    {
                        MessageBox.Show("Tên đăng nhập này đã được sử dụng. Hãy chọn tên đăng nhập khác!");
                        txtUserName.Focus();
                        return;
                    }
                    objNguoiDung = new NguoiDungInfor();
                    //cap nhat thong tin NND
                    string mySalt = Password.CreateSalt();
                    string myPass = Password.SetPassword(txtPassword.Text.Trim(), mySalt);

                    objNguoiDung.TenDayDu = txtFullName.Text.Trim();
                    objNguoiDung.TenDangNhap = txtUserName.Text.Trim();
                    objNguoiDung.MatKhau = myPass;
                    objNguoiDung.Salt = mySalt;
                    objNguoiDung.IdNhanVien = ((DMNhanVienInfo)bteThuongVien.Tag).IdNhanVien;
                    objNguoiDung.IdNhomNguoiDung = Common.IntValue(cboGroup.SelectedValue);
                    objNguoiDung.SuDung = chkSuDung.Checked;// (chkSuDung.Checked ? 1 : 0);

                    if (chkNeverExpired.Checked)
                        objNguoiDung.ThoiGianApDung = -1;
                    else
                    {
                        objNguoiDung.ThoiGianApDung = Convert.ToInt32(txtExpiredIn.Text);
                    }

                    objNguoiDung.ChangeOnNext = chkForceChangeAtFirst.Checked;

                    NguoiDungDataProvider.Insert(objNguoiDung);
                    
                    MessageBox.Show("Thêm mới thông tin người dùng thành công!");
                }
                else
                {
                    objNguoiDung.TenDayDu = txtFullName.Text.Trim();
                    objNguoiDung.IdNhanVien = ((DMNhanVienInfo)bteThuongVien.Tag).IdNhanVien;
                    objNguoiDung.IdNhomNguoiDung = Common.IntValue(cboGroup.SelectedValue);
                    objNguoiDung.SuDung = chkSuDung.Checked;// (chkSuDung.Checked ? 1 : 0);

                    if (chkNeverExpired.Checked)
                        objNguoiDung.ThoiGianApDung = -1;
                    else
                    {
                        objNguoiDung.ThoiGianApDung = Convert.ToInt32(txtExpiredIn.Text);
                    }

                    objNguoiDung.ChangeOnNext = chkForceChangeAtFirst.Checked;

                    NguoiDungDataProvider.Update(objNguoiDung);

                    MessageBox.Show("Cập nhật thông tin người dùng thành công!");
                }
                this.frm.LoadAllNguoiDung();
            }
            catch (ManagedException ex)
            {
                MessageBox.Show(ex.ToString());                
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
                EventLogProvider.Instance.WriteOfflineLog(ex.ToString(), "");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (objNguoiDung!=null)
            {
                if (objNguoiDung.TenDangNhap.Equals(((NguoiDungInfor)Declare.USER_INFOR).TenDangNhap))
                {
                    MessageBox.Show("Không thể xóa người dùng đang đăng nhập!");
                    return;
                }
                if (!Common.Int2Bool(((NguoiDungInfor)Declare.USER_INFOR).SupperUser) && Common.Int2Bool(objNguoiDung.SupperUser))
                {
                    MessageBox.Show("Không thể xóa Super User!");
                    return;
                }
                if (MessageBox.Show("Bạn có chắc chắn xóa người dùng này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    NguoiDungDataProvider.Delete(objNguoiDung);
                    MessageBox.Show("Cập nhật thông tin người dùng thành công!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Người dùng chưa được tạo. Không thể xóa");
            }                
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bteTrungTam_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteTrungTam);
        }

        private void bteTrungTam_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteTrungTam_KeyDown(sender, e, bteTrungTam, -1);
        }

        private void bteTrungTam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteTrungTam_ButtonClick(sender, e, bteTrungTam, -1);
        }

        private void bteThuongVien_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteThuongVien);
        }

        private void bteThuongVien_KeyDown(object sender, KeyEventArgs e)
        {
            int idTrungTam = bteTrungTam.Tag != null ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam : 0;

            if (e.KeyCode == Keys.Enter)
            {
                frmLookUp_NhanVien frmLookUp = new frmLookUp_NhanVien(idTrungTam, false, String.Format("%{0}%", bteTrungTam.Text));
                if (frmLookUp.ShowDialog() == DialogResult.OK)
                {
                    bteThuongVien.Text = frmLookUp.SelectedItem.HoTen;
                    bteThuongVien.Tag = frmLookUp.SelectedItem;
                }
            }
        }

        private void bteThuongVien_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int idTrungTam = bteTrungTam.Tag != null ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam : 0;
            frmLookUp_NhanVien frmLookUp = new frmLookUp_NhanVien(idTrungTam, false, String.Format("%{0}%", bteTrungTam.Text));
            if (frmLookUp.ShowDialog() == DialogResult.OK)
            {
                bteThuongVien.Text = frmLookUp.SelectedItem.HoTen;
                bteThuongVien.Tag = frmLookUp.SelectedItem;
            }
        }

        private void chkForceChangeOnExpired_CheckedChanged(object sender, EventArgs e)
        {
            if(!chkForceChangeOnExpired.Checked)
            {
                chkNeverExpired.Checked = true;
                chkNeverExpired.Enabled = true;
                chkForceChangeOnExpired.Enabled = chkForceChangeOnExpired.Checked;
                lblNgaySuDung.Enabled = false;
                txtExpiredIn.Enabled = false;
            } 
        }

        private void chkNeverExpired_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkNeverExpired.Checked)
            {
                chkForceChangeOnExpired.Checked = true;
                chkForceChangeOnExpired.Enabled = true;
                lblNgaySuDung.Enabled = true;
                chkNeverExpired.Enabled = chkNeverExpired.Checked;
                txtExpiredIn.Enabled = true;
            } 
        }
    }
}