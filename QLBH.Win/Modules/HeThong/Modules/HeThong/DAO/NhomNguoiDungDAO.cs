using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.HeThong.Infors;

namespace QLBanHang.Modules.HeThong.DAO
{
    public class NhomNguoiDungDAO :BaseDAO
    {
        private static NhomNguoiDungDAO instance;
        private NhomNguoiDungDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmNhomNguoiDung;
            //UseCaching = true;
        }
        public static NhomNguoiDungDAO Instance
        {
            get
            {
                if (instance == null) instance = new NhomNguoiDungDAO();
                return instance;
            }
        }


        public List<NhomNguoiDungInfor> LoadAll()
        {
            return GetListAll<NhomNguoiDungInfor>(Declare.StoreProcedureNamespace.spNhomNguoiDungListAll, null);
        }

        public NhomNguoiDungInfor GetInfor(int idNhomNguoiDung)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spNhomNguoiDungGetInfor);
            Parameters.AddWithValue("@p_IdNhomNguoiDung", idNhomNguoiDung);
            return FillToObject<NhomNguoiDungInfor>();
        }

        public List<ChucNangInfor> GetChucNang(int idNhomNguoiDung)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spNhomNguoiDungGetCNang);
            Parameters.AddWithValue("@p_IdNhomNguoiDung", idNhomNguoiDung);
            return FillToList<ChucNangInfor>();
        }

        public List<PhanQuyenHangSanXuatInfor> GetPhanQuyenHangSanXuat(int idNhomNguoiDung)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spNhomNguoiDungGetHang);
            Parameters.AddWithValue("@p_IdNhomNguoiDung", idNhomNguoiDung);
            return FillToList<PhanQuyenHangSanXuatInfor>();
            //return GetListCommand<PhanQuyenNganhHangInfor>(Declare.StoreProcedureNamespace.spNhomNguoiDungGetNganh, idNhomNguoiDung);
        }

        public List<PhanQuyenNganhHangInfor> GetPhanQuyenNganhHang(int idNhomNguoiDung)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spNhomNguoiDungGetNganh);
            Parameters.AddWithValue("@p_IdNhomNguoiDung", idNhomNguoiDung);
            return FillToList<PhanQuyenNganhHangInfor>();
            //return GetListCommand<PhanQuyenNganhHangInfor>(Declare.StoreProcedureNamespace.spNhomNguoiDungGetNganh, idNhomNguoiDung);
        }

        public void Update(NhomNguoiDungInfor nhomNguoiDung)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spNhomNguoiDungUpdate);
            Parameters.AddWithValue("@p_IdNhomNguoiDung", nhomNguoiDung.IdNhomNguoiDung);
            Parameters.AddWithValue("@p_MaNhom", nhomNguoiDung.MaNhom);
            Parameters.AddWithValue("@p_TenNhom", nhomNguoiDung.TenNhom);
            Parameters.AddWithValue("@p_MoTa", nhomNguoiDung.MoTa);
            Parameters.AddWithValue("@p_SuDung", (nhomNguoiDung.SuDung ? 1 : 0));
            Parameters.AddWithValue("@p_XemTon", nhomNguoiDung.XemTon);
            Parameters.AddWithValue("@p_QuanTri", nhomNguoiDung.QuanTri);
            Parameters.AddWithValue("@p_DieuChuyen", nhomNguoiDung.DieuChuyen);
            Parameters.AddWithValue("@p_SuaChungTu", nhomNguoiDung.SuaChungTu);
            Parameters.AddWithValue("@p_SaleAdmin", nhomNguoiDung.SaleAdmin);
            Parameters.AddWithValue("@p_XemBaoCao", nhomNguoiDung.XemBaoCao);
            Parameters.AddWithValue("@p_ShowNotify", nhomNguoiDung.ShowNotify);
            Parameters.AddWithValue("@p_NhomQuyenHan", nhomNguoiDung.NhomQuyenHan);
            Parameters.AddWithValue("@p_ChonTrungTamHienTai", nhomNguoiDung.ChonTrungTamHienTai);
            ExecuteNoneQuery();
        }

        public int Insert(NhomNguoiDungInfor nhomNguoiDung)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spNhomNguoiDungInsert);
            Parameters.AddWithValue("@p_IdNhomNguoiDung", 0).Direction = ParameterDirection.Output;
            Parameters.AddWithValue("@p_MaNhom", nhomNguoiDung.MaNhom);
            Parameters.AddWithValue("@p_TenNhom", nhomNguoiDung.TenNhom);
            Parameters.AddWithValue("@p_MoTa", nhomNguoiDung.MoTa);
            Parameters.AddWithValue("@p_SuDung", (nhomNguoiDung.SuDung ? 1 : 0));
            Parameters.AddWithValue("@p_XemTon", nhomNguoiDung.XemTon);
            Parameters.AddWithValue("@p_QuanTri", nhomNguoiDung.QuanTri);
            Parameters.AddWithValue("@p_DieuChuyen", nhomNguoiDung.DieuChuyen);
            Parameters.AddWithValue("@p_SuaChungTu", nhomNguoiDung.SuaChungTu);
            Parameters.AddWithValue("@p_SaleAdmin", nhomNguoiDung.SaleAdmin);
            Parameters.AddWithValue("@p_XemBaoCao", nhomNguoiDung.XemBaoCao);
            Parameters.AddWithValue("@p_ShowNotify", nhomNguoiDung.ShowNotify);
            Parameters.AddWithValue("@p_NhomQuyenHan", nhomNguoiDung.NhomQuyenHan);
            Parameters.AddWithValue("@p_ChonTrungTamHienTai", nhomNguoiDung.ChonTrungTamHienTai);
            ExecuteNoneQuery();

            return Common.IntValue(Parameters["@p_IdNhomNguoiDung"].Value.ToString());
        }

        public void InsertChucNang(int idNhomNguoiDung, int idChucNang)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spNhomNguoiDungInsertCN);
            Parameters.AddWithValue("@p_IdNhomNguoiDung", idNhomNguoiDung);
            Parameters.AddWithValue("@p_IdChucNang", idChucNang);
            ExecuteNoneQuery();
        }
        public void InsertHangSanXuat(int idNhomNguoiDung, string maHang)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spNhomNguoiDungInsertHSX, idNhomNguoiDung, maHang);
        }
        public void InsertNganhHang(int idNhomNguoiDung, string maNganhHang, string maLoai)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spNhomNguoiDungInsertNH, idNhomNguoiDung, maNganhHang, maLoai);
        }

        public void Delete(NhomNguoiDungInfor nhomNguoiDung)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spNhomNguoiDungDelete);
            Parameters.AddWithValue("@p_IdNhomNguoiDung", nhomNguoiDung.IdNhomNguoiDung);
            ExecuteNoneQuery();
        }

        public void DeleteAllChucNang(NhomNguoiDungInfor nhomNguoiDung)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spNhomNguoiDungDeleteCN);
            Parameters.AddWithValue("@p_IdNhomNguoiDung", nhomNguoiDung.IdNhomNguoiDung);
            ExecuteNoneQuery();
        }

        public bool Exist(string pMaNhom)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spNhomNguoiDungExistNND);
            Parameters.AddWithValue("@p_Count", 0).Direction = ParameterDirection.Output;
            Parameters.AddWithValue("@p_MaNhom", pMaNhom);
            ExecuteNoneQuery();

            return Common.IntValue(Parameters["@p_Count"].Value) == 1;
        }

        public List<NhomNguoiDungInfor> Search(string thamso)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spNhomNguoiDungSearch);
            Parameters.AddWithValue("@p_ThamSo", thamso);
            return FillToList<NhomNguoiDungInfor>();
        }
        public List<BaoCaoPhanQuyenInfor> LoadPhanQuyenChucNang(string nhomND, string chucNang)
        {
            return GetListCommand<BaoCaoPhanQuyenInfor>(Declare.StoreProcedureNamespace.spPhanQuyenChucNang,
                                                       nhomND, chucNang);
        }
        public List<BaoCaoPhanQuyenInfor> LoadPhanQuyenNganhHang(string nhomND, string nganhHang)
        {
            return GetListCommand<BaoCaoPhanQuyenInfor>(Declare.StoreProcedureNamespace.spPhanQuyenNganhHang,
                                                       nhomND, nganhHang);
        }
        public List<BaoCaoPhanQuyenInfor> LoadPhanQuyenNguoiDung(int idTrungTam, string nhomND, string nhanVien)
        {
            return GetListCommand<BaoCaoPhanQuyenInfor>(Declare.StoreProcedureNamespace.spPhanQuyenNguoiDung,
                                                       idTrungTam, nhomND, nhanVien);
        }
        public List<BaoCaoPhanQuyenInfor> LoadPhanQuyenNguoiDungChucNang(int idTrungTam, string nhomND, string nhanVien)
        {
            return GetListCommand<BaoCaoPhanQuyenInfor>(Declare.StoreProcedureNamespace.spPhanQuyenNguoiDungCNang,
                                                       idTrungTam, nhomND, nhanVien);
        }

        public List<NhomNguoiDungInfor> LoadNhomNguoiDungByMaNhanVien(string maNhanVien)
        {
            return GetListCommand<NhomNguoiDungInfor>(Declare.StoreProcedureNamespace.spNhomNguoiDungLoadByMaNV, maNhanVien);
        }
    }
}
