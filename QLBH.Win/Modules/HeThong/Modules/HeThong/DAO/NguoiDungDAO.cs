using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.HeThong.Infors;

namespace QLBanHang.Modules.HeThong.DAO
{
    public class NguoiDungDAO :BaseDAO
    {
        private static NguoiDungDAO instance;
        private NguoiDungDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmNguoiDung;
            //UseCaching = true;
        }
        public static NguoiDungDAO Instance
        {
            get
            {
                if (instance == null) instance = new NguoiDungDAO();
                return instance;
            }
        }

        public List<NguoiDungInfor> LoadAll()
        {
            return GetListAll<NguoiDungInfor>(Declare.StoreProcedureNamespace.spNguoiDungListAll, null);
        }

        public NguoiDungInfor GetInfor(int idNguoiDung)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spNguoiDungGetInfor);
            Parameters.AddWithValue("@p_IdNguoiDung", idNguoiDung);
            return FillToObject<NguoiDungInfor>();
        }

        public void Update(NguoiDungInfor nguoiDung)
        {
            //CreateCommonCommand(Declare.StoreProcedureNamespace.spNguoiDungUpdate);
            //Parameters.AddWithValue("@p_IdNguoiDung", nguoiDung.IdNguoiDung);
            //Parameters.AddWithValue("@p_IdNhanVien", nguoiDung.IdNhanVien);
            //Parameters.AddWithValue("@p_IdNhomNguoiDung", nguoiDung.IdNhomNguoiDung);
            //Parameters.AddWithValue("@p_TenDayDu", nguoiDung.TenDayDu);
            //Parameters.AddWithValue("@p_TenDangNhap", nguoiDung.TenDangNhap);
            //Parameters.AddWithValue("@p_MatKhau", nguoiDung.MatKhau);
            //Parameters.AddWithValue("@p_Salt", nguoiDung.Salt);
            //Parameters.AddWithValue("@p_SuDung", (nguoiDung.SuDung ? 1 : 0));
            //ExecuteNoneQuery();

            ExecuteCommand(Declare.StoreProcedureNamespace.spNguoiDungUpdate, nguoiDung.IdNguoiDung,
                           nguoiDung.IdNhanVien, nguoiDung.IdNhomNguoiDung, nguoiDung.TenDayDu,
                           nguoiDung.TenDangNhap, nguoiDung.MatKhau, nguoiDung.Salt, 
                           (nguoiDung.SuDung ? 1 : 0), nguoiDung.ThoiGianApDung,
                           (nguoiDung.ChangeOnNext ? 1 : 0));
        }

        public int Insert(NguoiDungInfor nguoiDung)
        {
            //CreateCommonCommand(Declare.StoreProcedureNamespace.spNguoiDungInsert);
            //Parameters.AddWithValue("@p_IdNguoiDung", 0).Direction = ParameterDirection.Output;
            //Parameters.AddWithValue("@p_IdNhanVien", nguoiDung.IdNhanVien);
            //Parameters.AddWithValue("@p_IdNhomNguoiDung", nguoiDung.IdNhomNguoiDung);
            //Parameters.AddWithValue("@p_TenDayDu", nguoiDung.TenDayDu);
            //Parameters.AddWithValue("@p_TenDangNhap", nguoiDung.TenDangNhap);
            //Parameters.AddWithValue("@p_MatKhau", nguoiDung.MatKhau);
            //Parameters.AddWithValue("@p_Salt", nguoiDung.Salt);
            //Parameters.AddWithValue("@p_SuDung", (nguoiDung.SuDung ? 1 : 0));
            //ExecuteNoneQuery();

            ExecuteCommand(Declare.StoreProcedureNamespace.spNguoiDungInsert, nguoiDung.IdNhanVien,
                           nguoiDung.IdNhomNguoiDung, nguoiDung.TenDayDu, nguoiDung.TenDangNhap, nguoiDung.MatKhau,
                           nguoiDung.Salt, (nguoiDung.SuDung ? 1 : 0), nguoiDung.ThoiGianApDung,
                           (nguoiDung.ChangeOnNext ? 1 : 0));

            return Common.IntValue(Parameters["p_IdNguoiDung"].Value.ToString());
        }

        public void Delete(NguoiDungInfor nguoiDung)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spNguoiDungDelete);
            Parameters.AddWithValue("@p_IdNguoiDung", nguoiDung.IdNguoiDung);
            ExecuteNoneQuery();
        }

        public bool Exist(string pMaNhom)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spNguoiDungExistND);
            Parameters.AddWithValue("@p_Count", 0).Direction = ParameterDirection.Output;
            Parameters.AddWithValue("@p_MaNhom", pMaNhom);
            ExecuteNoneQuery();

            return Common.IntValue(Parameters["@p_Count"].Value) == 1;
        }

        public void ChangePass(int userId, string matkhau)
        {
            CreateCommand(Declare.StoreProcedureNamespace.spNguoiDungChangePass, userId, matkhau);
            //Parameters.AddWithValue("@p_UserID", userId);
            //Parameters.AddWithValue("@p_MatKhau", matkhau);
            ExecuteNoneQuery();
        }

        public void UpdateUserStatus(int userId, int status)
        {
            //CreateCommonCommand(Declare.StoreProcedureNamespace.spNguoiDungUpdateStatus);
            //Parameters.AddWithValue("@p_UserID", userId);
            //Parameters.AddWithValue("@p_Status", status);
            //ExecuteNoneQuery();

            string sql = "Update tbl_DM_NguoiDung nd Set nd.Status = " + status +
                         " Where nd.IdNguoiDung = " + userId;
            GtidCommand SqlComm = new GtidCommand(sql, ConnectionUtil.Instance.GetConnection());
            SqlComm.CommandType = CommandType.Text;
            SqlComm.ExecuteNonQuery();
        }

        public NguoiDungInfor GetNguoiDungInfo(string userName)
        {
            CreateCommand(Declare.StoreProcedureNamespace.spNguoiDungGetByUserName, userName);
            //Parameters.AddWithValue("@p_UserName", userName);
            return FillToObject<NguoiDungInfor>();
        }

        public List<ChucNangInfor> GetChucNangUser(int userId)
        {
            CreateCommand(Declare.StoreProcedureNamespace.spNguoiDungGetChucNang, userId);
            //Parameters.AddWithValue("@p_UserID", userId);
            return FillToList<ChucNangInfor>();
        }

        public List<NguoiDungInfor> Search(string thamso)
        {
            //CreateGetListCommand(Declare.StoreProcedureNamespace.spNguoiDungSearch);
            //Parameters.AddWithValue("@p_ThamSo", thamso);
            CreateCommand(Declare.StoreProcedureNamespace.spNguoiDungSearch, thamso);
            return FillToList<NguoiDungInfor>();
        }

        public List<DMKhoCBOLoadInfo> GetKhoUser(int userId)
        {
            CreateCommand(Declare.StoreProcedureNamespace.spNguoiDungGetKho, userId);
            //Parameters.AddWithValue("@p_UserID", userId);
            return FillToList<DMKhoCBOLoadInfo>();
        }

        public void SetKhoMacDinh(int idTrungTam, int idKho, int idLoaiDT, int idDoiTuong, int idTruongCa, int idThuNgan, int idThoiHanTT, int idNguoiDung, string formMacDinh)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spNguoiDungUpdateKhoDefault, idTrungTam, idKho, idLoaiDT, idDoiTuong, idTruongCa, idThuNgan, idThoiHanTT, idNguoiDung, formMacDinh);
        }

        public List<PhanQuyenNganhHangInfor> GetNganhHangUser(int userId)
        {
            CreateCommand(Declare.StoreProcedureNamespace.spNguoiDungGetNganhHang, userId);
            //Parameters.AddWithValue("@p_UserID", userId);
            return FillToList<PhanQuyenNganhHangInfor>();
        }
        public List<PhanQuyenHangSanXuatInfor> GetHangSXUser(int userId)
        {
            CreateCommand(Declare.StoreProcedureNamespace.spNguoiDungGetHangSX, userId);
            //Parameters.AddWithValue("@p_UserID", userId);
            return FillToList<PhanQuyenHangSanXuatInfor>();
        }
    }
}
