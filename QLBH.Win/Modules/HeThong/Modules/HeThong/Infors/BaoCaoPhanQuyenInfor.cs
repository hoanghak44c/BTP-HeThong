using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.HeThong.Infors
{
    [Serializable]
    public class BaoCaoPhanQuyenInfor
    {
        public int IdNhomNguoiDung { get; set; }
        public string MaNhom { get; set; }
        public string TenNhom { get; set; }
        public string MaChucNang { get; set; }
        public string TenChucNang { get; set; }
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string TenDangNhap { get; set; }
        public string MaTrungTam { get; set; }
        public string TenTrungTam { get; set; }
        public string MaNganhHang { get; set; }
        public string TenNganhHang { get; set; }
        public string MaLoaiHang { get; set; }
        public string TenLoaiHang { get; set; }
        public int SupperUser { get; set; }
        public int QuanTri { get; set; }
        public int SuDung { get; set; }
    }
}
