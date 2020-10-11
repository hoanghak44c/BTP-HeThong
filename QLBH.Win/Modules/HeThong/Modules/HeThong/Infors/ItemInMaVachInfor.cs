using System;
using System.Collections.Generic;
using System.Text;
using QLBH.Core.Infors;

// Người tạo: Lê Mạnh Tuấn
// Ngày tạo :
// Ngày sửa cuối:

namespace QLBanHang.Modules.HeThong.Infors
{
    [Serializable]
    public class ItemInMaVachInfor : ChungTuChiTietBaseInfo
    {
        public int IdTrungTam { get; set; }
        //public int IdSanPham { get; set; }
        //public string MaSanPham { get; set; }
        //public string TenSanPham { get; set; }
        public string TenVietTat { get; set; }
        //public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public string TenDonViTinh { get; set; }
        public int TrungMaVach { get; set; }
        public string LinhVuc { get; set; }
        public string Nganh { get; set; }
        public string LoaiSanPham { get; set; }
        public int SoHienTai { get; set; }
        //public string Loai { get; set; }
        //public string Chung { get; set; }
        //public string Nhom { get; set; }z
        //public string Hang { get; set; }
        //public string Model { get; set; }
    }

    public class TimKiemItemInfo
    {
        public int Id { get; set; }

        public string Ma { get; set; }

        public string Ten { get; set; }

        public string Nhom { get; set; }

        public int ChietKhau { get; set; }
    }

    public class MaVachInfor
    {
        public string MaVach1 { get; set; }
        public string MaVach2 { get; set; }
        public string MaVach3 { get; set; }
        public string MaVach4 { get; set; }
        public string MaVach5 { get; set; }
        public string MaVach6 { get; set; }
    }
}
