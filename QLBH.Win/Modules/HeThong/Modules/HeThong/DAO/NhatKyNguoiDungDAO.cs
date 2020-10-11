using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.HeThong.Infors;

namespace QLBanHang.Modules.HeThong.DAO
{
    public class NhatKyNguoiDungDAO :BaseDAO
    {
        private static NhatKyNguoiDungDAO instance;
        private NhatKyNguoiDungDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmChucNang;
            //UseCaching = true;
        }
        public static NhatKyNguoiDungDAO Instance
        {
            get
            {
                if (instance == null) instance = new NhatKyNguoiDungDAO();
                return instance;
            }
        }

        public List<NhatKyNguoiDungInfor> TimKiemNhatKyNguoiDungPg(int nhanVien, string tenDangNhap, string chucNang, DateTime tuNgay, DateTime denNgay, int soBatDau, int soKetThuc)
        {
            return GetListCommand<NhatKyNguoiDungInfor>(Declare.StoreProcedureNamespace.spNhatKyNguoiDungSearch, nhanVien, tenDangNhap, chucNang,
                                                       clsUtils.DateValue(tuNgay), clsUtils.DateValue(denNgay), soBatDau, soKetThuc);
        }
        public void XoaNhatKyNguoiDung(int nhatKy)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spNhatKyNguoiDungDelete, nhatKy);
        }

        public string GetCurrentInfo(string terminal, string process, DateTime currentDate)
        {
            return
                GetObjectCommand<string>(
                    @"select nd.tendangnhap || ' - ' || nd.chucnang || ' - ' || cl.version
	                                                from tbl_nhatky_nguoidung nd
                                                left join tbl_clients cl on nd.processid = cl.processid 
                                                    and nd.terminal = cl.computername
                                                 where nd.terminal = :terminal
	                                                 and nd.processid = :process
	                                                 and thoigian_in = (select max(thoigian_in)
												                from tbl_nhatky_nguoidung
											                 where terminal = :terminal
												                 and processid = :process
                                                                 and thoigian_in <= to_date(:currentDate, 'dd/mm/yyyy HH24:mi:ss'))",
                    terminal, process, currentDate.ToString("dd/MM/yyyy HH:mm:ss"));
        }
    }
}
