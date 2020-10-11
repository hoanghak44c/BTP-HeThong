using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.HeThong.Infors;

namespace QLBanHang.Modules.HeThong.DAO
{
    public class ThuongNhanVienDAO :BaseDAO
    {
        private static ThuongNhanVienDAO instance;
        private ThuongNhanVienDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmNganh;
            //UseCaching = true;
        }
        public static ThuongNhanVienDAO Instance
        {
            get
            {
                if (instance == null) instance = new ThuongNhanVienDAO();
                return instance;
            }
        }
        //load
        public List<ThangDiemThuongNhanVienInfor> GetListThangDiemThuongNhanVien()
        {
            return GetListCommand<ThangDiemThuongNhanVienInfor>(Declare.StoreProcedureNamespace.spThangDiemThuongNhanVienLoad);
        }
        public List<CachTinhThuongNhanVienInfor> GetListCachTinhThuongNhanVien()
        {
            return GetListCommand<CachTinhThuongNhanVienInfor>(Declare.StoreProcedureNamespace.spCachTinhThuongNhanVienLoad);
        }
        public CachTinhThuongNhanVienInfor GetThuongNhanVienBySanPham(string maSanPham)
        {
            return GetObjectCommand<CachTinhThuongNhanVienInfor>(Declare.StoreProcedureNamespace.spGetThuongNhanVienBySanPham, maSanPham);
        }
        //insert
        public void InsertThangDiemThuongNhanVien(ThangDiemThuongNhanVienInfor td)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spThangDiemThuongNhanVienInsert, td.DiemTu, td.DiemDen, td.Loai, td.GhiChu);
        }
        public void InsertCachTinhThuongNhanVien(CachTinhThuongNhanVienInfor ct)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spCachTinhThuongNhanVienInsert, ct.MaNganhHang,
                           ct.DonViDoanhThu, ct.TrongSoDoanhThu, ct.DonViLoiNhuan, ct.TrongSoLoiNhuan,
                           ct.DonViKhoanTon, ct.TrongSoKhoanTon);
        }
        //delete
        public void DeleteThangDiemThuongNhanVien()
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spThangDiemThuongNhanVienDelete);
        }
        public void DeleteCachTinhThuongNhanVien()
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spCachTinhThuongNhanVienDelete);
        }

    }
}
