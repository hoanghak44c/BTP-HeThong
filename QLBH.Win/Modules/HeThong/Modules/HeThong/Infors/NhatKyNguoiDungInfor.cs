using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.HeThong.Infors
{
    [Serializable]
    public class NhatKyNguoiDungInfor
    {
        public int IdNhatKy { get; set; }
        public int IdNhanVien { get; set; }
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public int IdNguoiDung { get; set; }
        public string TenDangNhap { get; set; }
        public string TenMay { get; set; }
        public string ChucNang { get; set; }
        public DateTime ThoiGian_In { get; set; }
        public DateTime ThoiGian_Out { get; set; }
    }
}
