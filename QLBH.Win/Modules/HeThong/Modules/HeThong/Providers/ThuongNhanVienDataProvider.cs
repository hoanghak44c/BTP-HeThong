using System;
using System.Collections;
using System.Collections.Generic;
using QLBH.Core.Data;
using QLBH.Common;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.HeThong.DAO;

// <Remarks>
// Tạo NguoiDungDataProvider
// Người tạo: Lê Mạnh Tuấn
// Ngày tạo : 12/05/2012
// Người sửa cuối:
// </remarks>

namespace QLBanHang.Modules.HeThong.Providers
{

    public class ThuongNhanVienDataProvider
    {
        public static List<ThangDiemThuongNhanVienInfor> GetListThangDiemThuongNhanVien()
        {
            return ThuongNhanVienDAO.Instance.GetListThangDiemThuongNhanVien();
        }
        public static List<CachTinhThuongNhanVienInfor> GetListCachTinhThuongNhanVien()
        {
            return ThuongNhanVienDAO.Instance.GetListCachTinhThuongNhanVien();
        }
        public CachTinhThuongNhanVienInfor GetThuongNhanVienBySanPham(string maSanPham)
        {
            return ThuongNhanVienDAO.Instance.GetThuongNhanVienBySanPham(maSanPham);
        }
        //insert
        public static void InsertThangDiemThuongNhanVien(ThangDiemThuongNhanVienInfor td)
        {
            ThuongNhanVienDAO.Instance.InsertThangDiemThuongNhanVien(td);
        }
        public static void InsertCachTinhThuongNhanVien(CachTinhThuongNhanVienInfor ct)
        {
            ThuongNhanVienDAO.Instance.InsertCachTinhThuongNhanVien(ct);
        }
        //delete
        public static void DeleteThangDiemThuongNhanVien()
        {
            ThuongNhanVienDAO.Instance.DeleteThangDiemThuongNhanVien();
        }
        public static void DeleteCachTinhThuongNhanVien()
        {
            ThuongNhanVienDAO.Instance.DeleteCachTinhThuongNhanVien();
        }
    }
}
