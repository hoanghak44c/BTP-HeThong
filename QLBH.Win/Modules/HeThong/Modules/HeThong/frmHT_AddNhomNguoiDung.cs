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
    public partial class frmHT_AddNhomNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        #region Decalre .....
        // khởi tạo..
        private NhomNguoiDungInfor objNhomNguoiDung = null;
        private frmHT_ListNhomNguoiDung frm = new frmHT_ListNhomNguoiDung();
        #endregion

        public frmHT_AddNhomNguoiDung()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        public frmHT_AddNhomNguoiDung(frmHT_ListNhomNguoiDung frm)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.frm = frm;
        }
        public frmHT_AddNhomNguoiDung(NhomNguoiDungInfor objNhomTaiKhoan, frmHT_ListNhomNguoiDung frm)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.objNhomNguoiDung = objNhomTaiKhoan;
            this.frm = frm;
        }
        private void LoadNhomQuyen()
        {
            List<TrangThaiBH> liLoaiChinhSach = Common.GetListNhomQuyenHan();
            cboNhomQuyen.DataSource = liLoaiChinhSach;
            cboNhomQuyen.DisplayMember = "Name";
            cboNhomQuyen.ValueMember = "Id";

            cboNhomQuyen.SelectedIndex = 0;
        }
        private void frmHT_AddNhomNguoiDung_Load(object sender, EventArgs e)
        {
            LoadNhomQuyen();
            if (objNhomNguoiDung != null)
            {
                txtMaNhom.ReadOnly = true;
                txtMaNhom.Text = objNhomNguoiDung.MaNhom;
                txtTenNhom.Text = objNhomNguoiDung.TenNhom;
                txtMoTa.Text = objNhomNguoiDung.MoTa;
                chkSuDung.Checked = objNhomNguoiDung.SuDung;// (objNhomNguoiDung.SuDung == 1 ? true : false);
                chkQuanTri.Checked = Common.Int2Bool(objNhomNguoiDung.QuanTri);
                chkSuaChungTu.Checked = Common.Int2Bool(objNhomNguoiDung.SuaChungTu);
                chkSaleAdmin.Checked = Common.Int2Bool(objNhomNguoiDung.SaleAdmin);
                chkXemBaoCao.Checked = Common.Int2Bool(objNhomNguoiDung.XemBaoCao);
                chkShowNotify.Checked = Common.Int2Bool(objNhomNguoiDung.ShowNotify);
                chkDieuChuyenKhacTrungTam.Checked = Common.Int2Bool(objNhomNguoiDung.DieuChuyen);
                chkOnlyTon.Checked = Common.Int2Bool(objNhomNguoiDung.ChonTrungTamHienTai);
                cboNhomQuyen.SelectedValue = objNhomNguoiDung.NhomQuyenHan;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaNhom.Text))
                {
                    MessageBox.Show("Bạn chưa nhập mã nhóm người dùng!");
                    txtMaNhom.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtTenNhom.Text))
                {
                    MessageBox.Show("Bạn chưa nhập tên nhóm người dùng!");
                    txtTenNhom.Focus();
                    return;
                }
                if (objNhomNguoiDung == null)
                {
                    if (NhomNguoiDungDataProvider.Exist(txtMaNhom.Text))
                    {
                        MessageBox.Show("Mã nhóm này đã được sử dụng. Hãy chọn mã khác!");
                        txtMaNhom.Focus();
                        return;
                    }
                    objNhomNguoiDung = new NhomNguoiDungInfor();
                    //cap nhat thong tin NND
                    objNhomNguoiDung.MaNhom = txtMaNhom.Text.Trim();
                    objNhomNguoiDung.TenNhom = txtTenNhom.Text.Trim();
                    objNhomNguoiDung.MoTa = txtMoTa.Text.Trim();
                    objNhomNguoiDung.SuDung = chkSuDung.Checked;// (chkSuDung.Checked ? 1 : 0);
                    objNhomNguoiDung.QuanTri = Common.Bool2Int(chkQuanTri.Checked);
                    objNhomNguoiDung.DieuChuyen = Common.Bool2Int(chkDieuChuyenKhacTrungTam.Checked);
                    objNhomNguoiDung.SuaChungTu = Common.Bool2Int(chkSuaChungTu.Checked);
                    objNhomNguoiDung.SaleAdmin = Common.Bool2Int(chkSaleAdmin.Checked);
                    objNhomNguoiDung.XemBaoCao = Common.Bool2Int(chkXemBaoCao.Checked);
                    objNhomNguoiDung.ShowNotify = Common.Bool2Int(chkShowNotify.Checked);
                    objNhomNguoiDung.NhomQuyenHan = Common.IntValue(cboNhomQuyen.SelectedValue);
                    objNhomNguoiDung.ChonTrungTamHienTai = Common.Bool2Int(chkOnlyTon.Checked);
                    NhomNguoiDungDataProvider.Insert(objNhomNguoiDung);
                    MessageBox.Show("Thêm mới thông tin nhóm người dùng thành công!");
                }
                else
                {
                    objNhomNguoiDung.MaNhom = txtMaNhom.Text.Trim();
                    objNhomNguoiDung.TenNhom = txtTenNhom.Text.Trim();
                    objNhomNguoiDung.MoTa = txtMoTa.Text.Trim();
                    objNhomNguoiDung.SuDung = chkSuDung.Checked;// (chkSuDung.Checked ? 1 : 0);
                    objNhomNguoiDung.QuanTri = Common.Bool2Int(chkQuanTri.Checked);
                    objNhomNguoiDung.DieuChuyen = Common.Bool2Int(chkDieuChuyenKhacTrungTam.Checked);
                    objNhomNguoiDung.SuaChungTu = Common.Bool2Int(chkSuaChungTu.Checked);
                    objNhomNguoiDung.SaleAdmin = Common.Bool2Int(chkSaleAdmin.Checked);
                    objNhomNguoiDung.XemBaoCao = Common.Bool2Int(chkXemBaoCao.Checked);
                    objNhomNguoiDung.ShowNotify = Common.Bool2Int(chkShowNotify.Checked);
                    objNhomNguoiDung.NhomQuyenHan = Common.IntValue(cboNhomQuyen.SelectedValue);
                    objNhomNguoiDung.ChonTrungTamHienTai = Common.Bool2Int(chkOnlyTon.Checked);
                    NhomNguoiDungDataProvider.Update(objNhomNguoiDung);
                    MessageBox.Show("Cập nhật thông tin nhóm người dùng thành công!");
                }
                this.frm.LoadAllNhomNguoiDung();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (objNhomNguoiDung!=null)
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa nhóm tài khoản này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    NhomNguoiDungDataProvider.Delete(objNhomNguoiDung);
                    MessageBox.Show("Cập nhật thông tin nhóm người dùng thành công!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Nhóm chưa được tạo. Không thể xóa");
            }                
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}