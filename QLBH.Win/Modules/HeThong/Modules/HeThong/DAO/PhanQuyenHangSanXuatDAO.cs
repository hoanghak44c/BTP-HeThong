using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.HeThong.Infors;

namespace QLBanHang.Modules.HeThong.DAO
{
    public class PhanQuyenHangSanXuatDAO :BaseDAO
    {
        private static PhanQuyenHangSanXuatDAO instance;
        private PhanQuyenHangSanXuatDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmNganh;
            //UseCaching = true;
        }
        public static PhanQuyenHangSanXuatDAO Instance
        {
            get
            {
                if (instance == null) instance = new PhanQuyenHangSanXuatDAO();
                return instance;
            }
        }

        public List<PhanQuyenHangSanXuatInfor> ListAll()
        {
            return GetListCommand<PhanQuyenHangSanXuatInfor>(Declare.StoreProcedureNamespace.spHangPQSelectAll);
        }
    }
}
