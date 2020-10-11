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
    public class InMaVachDataProvider
    {
        public static List<ItemInMaVachInfor> GetListAllByTrungTam(int idTrungTam)
        {
            return InMaVachDAO.Instance.GetListAllByTrungTam(idTrungTam);
        }
        public static List<ItemInMaVachInfor> GetListAllByTrungTamPg(int idTrungTam, string maSanPham, string nganh, int soBatDau, int soKetThuc)
        {
            return InMaVachDAO.Instance.GetListAllByTrungTamPg(idTrungTam, maSanPham, nganh, soBatDau, soKetThuc);
        }
        public static List<TimKiemItemInfo> GetAllItemsByType(int idNhomNguoiDung, int type, int chietKhau, int suDung)
        {
            return InMaVachDAO.Instance.GetAllItemsByType(idNhomNguoiDung, type, chietKhau, suDung);
        }
    }
}
