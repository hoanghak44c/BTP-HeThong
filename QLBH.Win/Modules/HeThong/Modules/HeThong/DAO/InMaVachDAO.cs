using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.HeThong.Infors;

namespace QLBanHang.Modules.HeThong.DAO
{
    public class InMaVachDAO :BaseDAO
    {
        private static InMaVachDAO instance;
        private InMaVachDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmNganh;
            //UseCaching = true;
        }
        public static InMaVachDAO Instance
        {
            get
            {
                if (instance == null) instance = new InMaVachDAO();
                return instance;
            }
        }

        public List<ItemInMaVachInfor> GetListAllByTrungTam(int idTrungTam)
        {
            return GetListCommand<ItemInMaVachInfor>(Declare.StoreProcedureNamespace.spBangGiaInMaVach, idTrungTam);
        }

        public List<ItemInMaVachInfor> GetListAllByTrungTamPg(int idTrungTam, string maSanPham, string nganh, int soBatDau, int soKetThuc)
        {
            return GetListCommand<ItemInMaVachInfor>(Declare.StoreProcedureNamespace.spBangGiaInMaVachPg, idTrungTam, maSanPham, nganh, soBatDau, soKetThuc);
        }

        public List<TimKiemItemInfo> GetAllItemsByType(int idNhomNguoiDung, int type, int chietKhau, int suDung)
        {
            return GetListCommand<TimKiemItemInfo>(Declare.StoreProcedureNamespace.spMatHangGetAllByMaNSD, idNhomNguoiDung, type, chietKhau, suDung);
        }
    }
}
