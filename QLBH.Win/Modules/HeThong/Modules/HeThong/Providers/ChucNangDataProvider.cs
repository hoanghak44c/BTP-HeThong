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

    public class ChucNangDataProvider
    {
        public static List<ChucNangInfor> LoadAll()
        {
            return ChucNangDAO.Instance.ListAll();
        }

        public static void InsertIfNotExist(ChucNangInfor objChucNang)
        {
            ChucNangDAO.Instance.InsertIfNotExist(objChucNang);
        }

        public static void Delete(ChucNangInfor objChucNang)
        {
            ChucNangDAO.Instance.Delete(objChucNang.IdChucNang);
        }

        public static List<ChucNangInfor> Search(string thamso)
        {
            return ChucNangDAO.Instance.Search(thamso);
        }
    }
}
