using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.HeThong.Providers;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmKhoHienTai : DevExpress.XtraEditors.XtraForm
    {
        List<DMTrungTamInfor> liTrungTam = new List<DMTrungTamInfor>();
        List<DMKhoInfo> liKho = new List<DMKhoInfo>();
        List<DmLoaiDoiTuongInfor> liLoaiDT = new List<DmLoaiDoiTuongInfor>();
        List<DMDoiTuongInfo> liDoiTuong = new List<DMDoiTuongInfo>();
        private bool ShowPX = false;
        private Form frmParent = null;

        public frmKhoHienTai()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
        public frmKhoHienTai(bool showPhieuXuat)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.ShowPX = showPhieuXuat;
        }
        public frmKhoHienTai(Form parent)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.frmParent = parent;
        }
        private void frmKhoHienTai_Load(object sender, EventArgs e)
        {
            LoadTrungTam();
            LoadKho();
            cboCurrentWareHouse.SelectedValue = Declare.IdKho;
            LoadLoaiDT();
            cboCurrentDoiTuong.SelectedValue = Declare.IdKHMacDinh;
        }
        private void cboCurrentTrungTam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadKho();
            if (cboCurrentTrungTam.SelectedIndex > -1 && liTrungTam.Count > 0)
                txtMaTrungTam.Text = liTrungTam[cboCurrentTrungTam.SelectedIndex].MaTrungTam;
        }
        private void LoadTrungTam()
        {
            int idNhanVien = ((NguoiDungInfor) Declare.USER_INFOR).IdNhanVien;
            liTrungTam = DMTrungTamDataProvider.GetListTrungTamInfoByIdNhanVien(idNhanVien);
            if (liTrungTam.Count>0)
            {
                cboCurrentTrungTam.DataSource = liTrungTam;
                cboCurrentTrungTam.DisplayMember = "TenTrungTam";
                cboCurrentTrungTam.ValueMember = "IdTrungTam";
                cboCurrentTrungTam.SelectedValue = Declare.IdTrungTam;
            }
            else
            {
                cboCurrentTrungTam.DataSource = null;
            }
        }
        private void LoadKho()
        {
            int idTrungTam = Common.IntValue(cboCurrentTrungTam.SelectedValue);
            int idNhanVien = ((NguoiDungInfor) Declare.USER_INFOR).IdNhanVien;
            liKho = DMKhoDataProvider.GetListKhoInfoByTTamNVien(idTrungTam, idNhanVien);

            if (liKho.Count>0)
            {
                cboCurrentWareHouse.DataSource = liKho;
                cboCurrentWareHouse.DisplayMember = "TenKho";
                cboCurrentWareHouse.ValueMember = "IdKho";
                //cboCurrentWareHouse.SelectedValue = Declare.IdKho;
            }
            else
            {
                cboCurrentWareHouse.DataSource = null;
            }
        }

        private void LoadLoaiDT()
        {
            liLoaiDT = DmLoaiDoiTuongDataProvider.GetListLoaiDoiTuongInfor();

            if (liLoaiDT.Count > 0)
            {
                cboCurrentLoaiDT.DataSource = liLoaiDT;
                cboCurrentLoaiDT.DisplayMember = "TenLoaiDT";
                cboCurrentLoaiDT.ValueMember = "IdLoaiDT";
                cboCurrentLoaiDT.SelectedValue = Declare.IdLoaiKhachHang;
            }
            else
            {
                cboCurrentLoaiDT.DataSource = null;
            }
        }

        private void LoadDoiTuong()
        {
            int idLoaiDT = Common.IntValue(cboCurrentLoaiDT.SelectedValue);
            liDoiTuong = DmDoiTuongProvider.GetDmDoiTuongByLoaiDT(idLoaiDT);

            if (liDoiTuong.Count > 0)
            {
                cboCurrentDoiTuong.DataSource = liDoiTuong;
                cboCurrentDoiTuong.DisplayMember = "TenDoiTuong";
                cboCurrentDoiTuong.ValueMember = "IdDoiTuong";
                //cboCurrentDoiTuong.SelectedValue = Declare.IdKHMacDinh;
            }
            else
            {
                cboCurrentDoiTuong.DataSource = null;
            }
        }
        private void frmKhoHienTai_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowPhieuXuat();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Declare.IdTrungTam = Common.IntValue(cboCurrentTrungTam.SelectedValue);
                Declare.IdKho = Common.IntValue(cboCurrentWareHouse.SelectedValue);
                Declare.IdLoaiKhachHang = Common.IntValue(cboCurrentLoaiDT.SelectedValue);
                Declare.TenKhachHang = cboCurrentDoiTuong.Text.Trim();
                Declare.IdKHMacDinh = Common.IntValue(cboCurrentDoiTuong.SelectedValue);
                Declare.TenKho = cboCurrentWareHouse.Text.Trim();

                DMKhoInfo khoInfo = cboCurrentWareHouse.SelectedIndex > -1
                                               ? liKho[cboCurrentWareHouse.SelectedIndex]
                                               : new DMKhoInfo();
                if (khoInfo.NgayDuDau.CompareTo(DateTime.Now) > 0)
                    Declare.NgayDuDau = khoInfo.NgayDuDau;
                else
                    Declare.NgayDuDau = DateTime.Now;

                NguoiDungDataProvider.SetKhoMacDinh(Declare.IdTrungTam, Declare.IdKho, Declare.IdLoaiKhachHang,
                                                    Declare.IdKHMacDinh,
                                                    ((NguoiDungInfor) Declare.USER_INFOR).IdNguoiDung);

                //DMKhoInfo khoInfo = DMKhoDataProvider.GetKhoByIdInfo(Declare.IdKho);
                //string sql = "Update tbl_DM_NguoiDung Set KhoMacDinh = " + Declare.IdKho + " Where IdNguoiDung = " + Declare.UserId;
                //DBTools.ExecuteQuery(sql, CommandType.Text);
                //object tmp = DBTools.ExecuteScalar(String.Format("select NgayDuDau from tbl_DM_Kho where IdKho={0}", Declare.IdKho));
                //if (khoInfo.NgayDuDau.CompareTo(DateTime.Now) > 0)
                //    Declare.NgayDuDau = khoInfo.NgayDuDau;
                //else
                //    Declare.NgayDuDau = DateTime.Now;
                // DateTime.Parse(SqlDateTime.MinValue.ToString());

                //if (DBTools.ExecuteQuery(sql, CommandType.Text) != null)
                //    MessageBox.Show(Declare.msgSavedKho, Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //else
                //    MessageBox.Show(Declare.msgUpdateErr, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Đổi kho hiện tại thành công. Hệ thống sẽ đóng các form hiện hành để đảm bảo dữ liệu");

                if (frmParent != null)
                {
                    foreach (Form frm in frmParent.MdiChildren)
                    {
                        frm.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboCurrentWareHouse_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnUpdate_Click(sender, e);
            }
        }

        private void ShowPhieuXuat()
        {
            try
            {
                if (Declare.GiaoDienMacDinh.Length > 0 && this.ShowPX)
                {
                    this.Cursor = Cursors.WaitCursor;
                    Form frm = (Form)Activator.CreateInstance(Type.GetType("QLBanHang.Forms." + Declare.GiaoDienMacDinh));
                    if (frm != null)
                    {
                        frm.MdiParent = this.ParentForm;
                        frm.Show();
                    }
                    this.Cursor = Cursors.Default;
                }
            }
            catch (Exception ex) { }
        }

        private void cboCurrentLoaiDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDoiTuong();
            if (cboCurrentLoaiDT.SelectedIndex > -1 && liLoaiDT.Count > 0)
                txtMaLoaiDT.Text = liLoaiDT[cboCurrentLoaiDT.SelectedIndex].MaLoaiDT;
        }

        private void cboCurrentDoiTuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCurrentDoiTuong.SelectedIndex > -1 && liDoiTuong.Count > 0)
                txtMaDoiTuong.Text = liDoiTuong[cboCurrentDoiTuong.SelectedIndex].MaDoiTuong;
        }

        private void cboCurrentWareHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCurrentWareHouse.SelectedIndex > -1 && liKho.Count > 0)
                txtMaKho.Text = liKho[cboCurrentWareHouse.SelectedIndex].MaKho;
        }

        private void txtMaTrungTam_Leave(object sender, EventArgs e)
        {
            bool found = false;
            for (int i = 0; i < liTrungTam.Count; i++)
            {
                if (txtMaTrungTam.Text.Equals(liTrungTam[i].MaTrungTam))
                {
                    //cboKhachHang.SelectedIndex = i;
                    cboCurrentTrungTam.SelectedIndex = i;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                txtMaTrungTam.Text = "";
                cboCurrentTrungTam.SelectedIndex = -1;
            }
        }

        private void txtMaTrungTam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtMaTrungTam_Leave(sender, e);
            }
        }

        private void txtMaKho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtMaKho_Leave(sender, e);
            }
        }

        private void txtMaKho_Leave(object sender, EventArgs e)
        {
            bool found = false;
            for (int i = 0; i < liKho.Count; i++)
            {
                if (txtMaKho.Text.Equals(liKho[i].MaKho))
                {
                    //cboKhachHang.SelectedIndex = i;
                    cboCurrentWareHouse.SelectedIndex = i;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                txtMaKho.Text = "";
                cboCurrentWareHouse.SelectedIndex = -1;
            }
        }

        private void txtMaLoaiDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtMaLoaiDT_Leave(sender, e);
            }
        }

        private void txtMaLoaiDT_Leave(object sender, EventArgs e)
        {
            bool found = false;
            for (int i = 0; i < liLoaiDT.Count; i++)
            {
                if (txtMaLoaiDT.Text.Equals(liLoaiDT[i].MaLoaiDT))
                {
                    //cboKhachHang.SelectedIndex = i;
                    cboCurrentLoaiDT.SelectedIndex = i;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                txtMaLoaiDT.Text = "";
                cboCurrentLoaiDT.SelectedIndex = -1;
            }
        }

        private void txtMaDoiTuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtMaDoiTuong_Leave(sender, e);
            }
        }

        private void txtMaDoiTuong_Leave(object sender, EventArgs e)
        {
            bool found = false;
            for (int i = 0; i < liDoiTuong.Count; i++)
            {
                if (txtMaDoiTuong.Text.Equals(liDoiTuong[i].MaDoiTuong))
                {
                    //cboKhachHang.SelectedIndex = i;
                    cboCurrentDoiTuong.SelectedIndex = i;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                txtMaDoiTuong.Text = "";
                cboCurrentDoiTuong.SelectedIndex = -1;
            }
        }




    }
}