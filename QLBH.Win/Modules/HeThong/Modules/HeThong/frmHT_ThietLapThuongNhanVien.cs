using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBH.Common;
using QLBanHang.Modules.HeThong.Providers;
using DevExpress.XtraBars.Ribbon;
using QLBanHang.Modules.HeThong.Infors;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmHT_ThietLapThuongNhanVien : DevExpress.XtraEditors.XtraForm
    {
        #region Decalre......
        private List<ThangDiemThuongNhanVienInfor> liThangDiem = new List<ThangDiemThuongNhanVienInfor>();
        private List<CachTinhThuongNhanVienInfor> liCachTinh = new List<CachTinhThuongNhanVienInfor>();
        #endregion

        public frmHT_ThietLapThuongNhanVien()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void frmHT_ListNhomNguoiDung_Load(object sender, EventArgs e)
        {
            LoadAllThangDiem();
            LoadAllCachTinh();
        }
        public void LoadAllThangDiem()
        {
            liThangDiem = ThuongNhanVienDataProvider.GetListThangDiemThuongNhanVien();
            gThangDiem.DataSource = new BindingList<ThangDiemThuongNhanVienInfor>(liThangDiem);
        }

        private void LoadAllCachTinh()
        {
            liCachTinh = ThuongNhanVienDataProvider.GetListCachTinhThuongNhanVien();
            if (liCachTinh.Count==0)
            {
                List<PheDuyetNganhHangInfor> liNganhHang = PhanQuyenNganhHangDataProvider.ListAllPheDuyetNganh();
                foreach (PheDuyetNganhHangInfor nh in liNganhHang)
                {
                    liCachTinh.Add(new CachTinhThuongNhanVienInfor()
                                       {
                                           MaLinhVuc = nh.MaLinhVuc,
                                           TenLinhVuc = nh.TenLinhVuc,
                                           MaNganhHang = nh.MaNganhHang,
                                           TenNganhHang = nh.TenNganhHang
                                       });
                }
            }
            gCachTinh.DataSource = new BindingList<CachTinhThuongNhanVienInfor>(liCachTinh);
            gvCachTinh.Columns["TenLinhVuc"].GroupIndex = 0;
            gvCachTinh.ExpandAllGroups();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveCN_Click(object sender, EventArgs e)
        {
            try
            {
                //save thang diem thuong nhan vien
                ThuongNhanVienDataProvider.DeleteThangDiemThuongNhanVien();
                foreach (ThangDiemThuongNhanVienInfor td in (BindingList<ThangDiemThuongNhanVienInfor>)gThangDiem.DataSource)
                {
                    ThuongNhanVienDataProvider.InsertThangDiemThuongNhanVien(td);
                }

                //save cach tinh thuong nhan vien
                ThuongNhanVienDataProvider.DeleteCachTinhThuongNhanVien();
                foreach (CachTinhThuongNhanVienInfor ct in (BindingList<CachTinhThuongNhanVienInfor>)gCachTinh.DataSource)
                {
                    ThuongNhanVienDataProvider.InsertCachTinhThuongNhanVien(ct);
                }
                MessageBox.Show("Cập nhật chính sách thưởng nhân viên thành công!");
            }
            catch 
            {
                
            }

        }

        private void btnXoaNND_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvThangDiem.FocusedRowHandle < 0) return;

                if (MessageBox.Show("Bạn có chắc chắn xóa thang điểm này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gvThangDiem.DeleteSelectedRows();
                }
            }
            catch { }
        }

        private void btnAddNND_Click(object sender, EventArgs e)
        {
            ((BindingList<ThangDiemThuongNhanVienInfor>)gThangDiem.DataSource).Add(new ThangDiemThuongNhanVienInfor());
        }

    }
}