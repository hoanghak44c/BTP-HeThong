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

    public class NguoiDungDataProvider
    {
        public static List<NguoiDungInfor> LoadAll()
        {
            return NguoiDungDAO.Instance.LoadAll();
        }

        public static NguoiDungInfor GetInfor(int idNguoiDung)
        {
            return NguoiDungDAO.Instance.GetInfor(idNguoiDung);
        }

        public static void Update(NguoiDungInfor nguoiDung)
        {
            NguoiDungDAO.Instance.Update(nguoiDung);
        }

        public static int Insert(NguoiDungInfor nguoiDung)
        {
            return NguoiDungDAO.Instance.Insert(nguoiDung);
        }

        public static void Delete(NguoiDungInfor nguoiDung)
        {
            NguoiDungDAO.Instance.Delete(nguoiDung);
        }

        public static bool Exist(string pMaNhom)
        {
            return NguoiDungDAO.Instance.Exist(pMaNhom);
        }

        public static void ChangePass(int userId, string matkhau)
        {
            NguoiDungDAO.Instance.ChangePass(userId, matkhau);
        }

        public static void UpdateUserStatus(NguoiDungInfor user)
        {
            NguoiDungDAO.Instance.UpdateUserStatus(user.IdNguoiDung, user.Status);
        }

        public static NguoiDungInfor GetNguoiDungInfo(string userName)
        {
            return NguoiDungDAO.Instance.GetNguoiDungInfo(userName);
        }

        public static void GetChucNangUser(NguoiDungInfor user)
        {
            user.ChucNangNguoiDung = NguoiDungDAO.Instance.GetChucNangUser(user.IdNguoiDung);
        }

        public static List<NguoiDungInfor> Search(string thamso)
        {
            return NguoiDungDAO.Instance.Search(thamso);
        }

        public static void GetKhoUser(NguoiDungInfor user)
        {
            user.KhoNguoiDung = new ArrayList(NguoiDungDAO.Instance.GetKhoUser(user.IdNguoiDung));
        }

        public static void SetKhoMacDinh(int idTrungTam, int idKho, int idLoaiDT, int idDoiTuong, int idTruongCa, int idThuNgan, int idThoiHanTT, int idNguoiDung, string formMacDinh)
        {
            NguoiDungDAO.Instance.SetKhoMacDinh(idTrungTam, idKho, idLoaiDT, idDoiTuong, idTruongCa, idThuNgan, idThoiHanTT, idNguoiDung, formMacDinh);
        }

        public static void GetNganhHangUser(NguoiDungInfor user)
        {
            user.NganhHangNguoiDung = NguoiDungDAO.Instance.GetNganhHangUser(user.IdNguoiDung);
        }

        public static void GetHangSXUser(NguoiDungInfor user)
        {
            user.HangSanXuat = NguoiDungDAO.Instance.GetHangSXUser(user.IdNguoiDung);
        }
    }
}
