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

    public class PhanQuyenHangSanXuatDataProvider
    {
        public static List<PhanQuyenHangSanXuatInfor> ListAll()
        {
            return PhanQuyenHangSanXuatDAO.Instance.ListAll();
        }
    }
}
