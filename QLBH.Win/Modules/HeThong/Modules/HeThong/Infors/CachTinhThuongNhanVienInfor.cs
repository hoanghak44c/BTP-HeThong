using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.HeThong.Infors
{
    [Serializable]
    public class CachTinhThuongNhanVienInfor
    {
        public string MaNganhHang { get; set; }

        public string TenNganhHang { get; set; }

        public string MaLinhVuc { get; set; }

        public string TenLinhVuc { get; set; }

        public double DonViDoanhThu { get; set; }

        public double TrongSoDoanhThu { get; set; }
        
        public double DonViLoiNhuan { get; set; }

        public double TrongSoLoiNhuan { get; set; }

        public double DonViKhoanTon { get; set; }

        public double TrongSoKhoanTon { get; set; }
    }
}
