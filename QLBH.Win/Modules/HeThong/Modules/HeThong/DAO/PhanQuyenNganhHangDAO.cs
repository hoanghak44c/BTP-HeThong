using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.HeThong.Infors;

namespace QLBanHang.Modules.HeThong.DAO
{
    public class PhanQuyenNganhHangDAO :BaseDAO
    {
        private static PhanQuyenNganhHangDAO instance;
        private PhanQuyenNganhHangDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmNganh;
            //UseCaching = true;
        }
        public static PhanQuyenNganhHangDAO Instance
        {
            get
            {
                if (instance == null) instance = new PhanQuyenNganhHangDAO();
                return instance;
            }
        }

        public List<PhanQuyenNganhHangInfor> ListAll()
        {
            return GetListCommand<PhanQuyenNganhHangInfor>(Declare.StoreProcedureNamespace.spNganhPQSelectAll);
        }

        public List<PheDuyetNganhHangInfor> ListAllPheDuyetNganh()
        {
            return GetListCommand<PheDuyetNganhHangInfor>(Declare.StoreProcedureNamespace.spNganhPQGetPheDuyet);
        }

        public List<PheDuyetGiaBanInfor> GetPheDuyetGiaBanByNhomND(int IdNhomNguoiDung)
        {
            return GetListCommand<PheDuyetGiaBanInfor>(Declare.StoreProcedureNamespace.spPheDuyetGiaNganhPQGetAll,
                                                       IdNhomNguoiDung);
        }
        public List<PheDuyetGiaBanInfor> GetPheDuyetGiaBanByNganhHang(string maNganhHang)
        {
            return GetListCommand<PheDuyetGiaBanInfor>(Declare.StoreProcedureNamespace.spPheDuyetGiaNhomNDGetAll,
                                                       maNganhHang);
        }
        public void DeletePheDuyetGiaBan(string nganhHang)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spPheDuyetGiaNganhPQDelete, nganhHang);
        }
        public void UpdatePheDuyetGiaBan(PheDuyetGiaBanInfor pdGiaBanInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spPheDuyetGiaNganhPQUpdate, pdGiaBanInfor.IdNhomNguoiDung, pdGiaBanInfor.MaLinhVuc,
                            pdGiaBanInfor.MaNganhHang, pdGiaBanInfor.DungSaiMIN, pdGiaBanInfor.DungSaiMAX, pdGiaBanInfor.DoUuTien);
        }
    }
}
