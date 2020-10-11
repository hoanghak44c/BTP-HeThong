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

    public class PhanQuyenNganhHangDataProvider
    {
        public static List<PhanQuyenNganhHangInfor> ListAll()
        {
            return PhanQuyenNganhHangDAO.Instance.ListAll();
        }
        public static List<PheDuyetNganhHangInfor> ListAllPheDuyetNganh()
        {
            return PhanQuyenNganhHangDAO.Instance.ListAllPheDuyetNganh();
        }
        public static List<PheDuyetGiaBanInfor> GetPheDuyetGiaBanByNhomND(int idNhomNguoiDung)
        {
            return PhanQuyenNganhHangDAO.Instance.GetPheDuyetGiaBanByNhomND(idNhomNguoiDung);
        }
        public static List<PheDuyetGiaBanInfor> GetPheDuyetGiaBanByNganhHang(string maNganhHang)
        {
            return PhanQuyenNganhHangDAO.Instance.GetPheDuyetGiaBanByNganhHang(maNganhHang);
        }
        public static void DeletePheDuyetGiaBan(string nganhHang)
        {
            PhanQuyenNganhHangDAO.Instance.DeletePheDuyetGiaBan(nganhHang);
        }
        public static void UpdatePheDuyetGiaBan(PheDuyetGiaBanInfor pheDuyetGiaBanInfor)
        {
            PhanQuyenNganhHangDAO.Instance.UpdatePheDuyetGiaBan(pheDuyetGiaBanInfor);
        }

    }
}
