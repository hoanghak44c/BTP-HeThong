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

    public class NhomNguoiDungDataProvider
    {
        public static List<NhomNguoiDungInfor> LoadAll()
        {
            return NhomNguoiDungDAO.Instance.LoadAll();
        }

        public static NhomNguoiDungInfor GetInfor(int idNhomNguoiDung)
        {
            return NhomNguoiDungDAO.Instance.GetInfor(idNhomNguoiDung);
        }

        public static void GetChucNang(NhomNguoiDungInfor nhomNguoiDung)
        {
            nhomNguoiDung.ChucNangNguoiDung = new ArrayList(NhomNguoiDungDAO.Instance.GetChucNang(nhomNguoiDung.IdNhomNguoiDung));
        }

        public static void GetPhanQuyenHangSanXuat(NhomNguoiDungInfor nhomNguoiDung)
        {
            nhomNguoiDung.PhanQuyenHangSanXuat = new ArrayList(NhomNguoiDungDAO.Instance.GetPhanQuyenHangSanXuat(nhomNguoiDung.IdNhomNguoiDung));
        }

        public static void GetPhanQuyenNganhHang(NhomNguoiDungInfor nhomNguoiDung)
        {
            nhomNguoiDung.PhanQuyenNganhHang = new ArrayList(NhomNguoiDungDAO.Instance.GetPhanQuyenNganhHang(nhomNguoiDung.IdNhomNguoiDung));
        }

        public static void Update(NhomNguoiDungInfor nhomNguoiDung)
        {
            NhomNguoiDungDAO.Instance.Update(nhomNguoiDung);
            NhomNguoiDungDAO.Instance.DeleteAllChucNang(nhomNguoiDung);

            if (nhomNguoiDung.ChucNangNguoiDung!= null)
            {
                foreach (ChucNangInfor cn in nhomNguoiDung.ChucNangNguoiDung)
                {
                    NhomNguoiDungDAO.Instance.InsertChucNang(nhomNguoiDung.IdNhomNguoiDung, cn.IdChucNang);
                }              
            }
            if (nhomNguoiDung.PhanQuyenHangSanXuat != null)
            {
                foreach (PhanQuyenHangSanXuatInfor hn in nhomNguoiDung.PhanQuyenHangSanXuat)
                {
                    NhomNguoiDungDAO.Instance.InsertHangSanXuat(nhomNguoiDung.IdNhomNguoiDung, hn.MaHang);
                }
            }
            if (nhomNguoiDung.PhanQuyenNganhHang != null)
            {
                foreach (PhanQuyenNganhHangInfor pq in nhomNguoiDung.PhanQuyenNganhHang)
                {
                    NhomNguoiDungDAO.Instance.InsertNganhHang(nhomNguoiDung.IdNhomNguoiDung, pq.MaNganhHang, pq.MaLoai);
                }
            }
        }

        public static int Insert(NhomNguoiDungInfor nhomNguoiDung)
        {
            int idNhomNguoiDung = NhomNguoiDungDAO.Instance.Insert(nhomNguoiDung);
            //try
            //{
            //    foreach (ChucNangInfor cn in nhomNguoiDung.ChucNangNguoiDung)
            //    {
            //        NhomNguoiDungDAO.Instance.InsertChucNang(idNhomNguoiDung, cn.IdChucNang);
            //    }
            //    foreach (PhanQuyenHangSanXuatInfor hn in nhomNguoiDung.PhanQuyenHangSanXuat)
            //    {
            //        NhomNguoiDungDAO.Instance.InsertHangSanXuat(nhomNguoiDung.IdNhomNguoiDung, hn.MaHang);
            //    }
            //    foreach (PhanQuyenNganhHangInfor pq in nhomNguoiDung.PhanQuyenNganhHang)
            //    {
            //        NhomNguoiDungDAO.Instance.InsertNganhHang(idNhomNguoiDung, pq.MaNganhHang, pq.MaLoai);
            //    }
            //}
            //catch 
            //{
            //}

            return idNhomNguoiDung;
        }

        public static void Delete(NhomNguoiDungInfor nhomNguoiDung)
        {
            NhomNguoiDungDAO.Instance.Delete(nhomNguoiDung);
        }

        public static bool Exist(string pMaNhom)
        {
            return NhomNguoiDungDAO.Instance.Exist(pMaNhom);
        }

        public static List<NhomNguoiDungInfor> Search(string thamso)
        {
            return NhomNguoiDungDAO.Instance.Search(thamso);
        }
        public static List<BaoCaoPhanQuyenInfor> LoadPhanQuyenChucNang(string nhomND, string chucNang)
        {
            return NhomNguoiDungDAO.Instance.LoadPhanQuyenChucNang(nhomND, chucNang);
        }
        public static List<BaoCaoPhanQuyenInfor> LoadPhanQuyenNganhHang(string nhomND, string nganhHang)
        {
            return NhomNguoiDungDAO.Instance.LoadPhanQuyenNganhHang(nhomND, nganhHang);
        }
        public static List<BaoCaoPhanQuyenInfor> LoadPhanQuyenNguoiDung(int idTrungTam, string nhomND, string nhanVien)
        {
            return NhomNguoiDungDAO.Instance.LoadPhanQuyenNguoiDung(idTrungTam, nhomND, nhanVien);
        }
        public static List<BaoCaoPhanQuyenInfor> LoadPhanQuyenNguoiDungChucNang(int idTrungTam, string nhomND, string nhanVien)
        {
            return NhomNguoiDungDAO.Instance.LoadPhanQuyenNguoiDungChucNang(idTrungTam, nhomND, nhanVien);
        }
        public static List<NhomNguoiDungInfor> LoadNhomNguoiDungByMaNhanVien(string maNhanVien)
        {
            return NhomNguoiDungDAO.Instance.LoadNhomNguoiDungByMaNhanVien(maNhanVien);
        }
    }
}
