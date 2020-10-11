using System;
using System.Collections;
using System.Collections.Generic;
using QLBH.Core.Data;
using QLBH.Common;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.HeThong.DAO;
using QLBH.Core.Exceptions;

// <Remarks>
// Tạo NguoiDungDataProvider
// Người tạo: Lê Mạnh Tuấn
// Ngày tạo : 12/05/2012
// Người sửa cuối:
// </remarks>

namespace QLBanHang.Modules.HeThong.Providers
{

    public class NhatKyNguoiDungDataProvider
    {
        private static NhatKyNguoiDungDataProvider instance;
        public static NhatKyNguoiDungDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new NhatKyNguoiDungDataProvider();
                return instance;
            }
        }
        public List<NhatKyNguoiDungInfor> TimKiemNhatKyNguoiDungPg(int nhanVien, string tenDangNhap, string chucNang, DateTime tuNgay, DateTime denNgay, int soBatDau, int soKetThuc)
        {
            return NhatKyNguoiDungDAO.Instance.TimKiemNhatKyNguoiDungPg(nhanVien, tenDangNhap, chucNang, tuNgay, denNgay,
                                                                        soBatDau, soKetThuc);
        }
        public void XoaNhatKyNguoiDung(int nhatKy)
        {
            NhatKyNguoiDungDAO.Instance.XoaNhatKyNguoiDung(nhatKy);
        }
        public string GetCurrentInfo(string terminal, string process, DateTime currentDate)
        {
            return NhatKyNguoiDungDAO.Instance.GetCurrentInfo(terminal, process, currentDate);
        }
    }
}
