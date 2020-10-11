using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.HeThong.Infors
{
    [Serializable]
    public class ThangDiemThuongNhanVienInfor
    {
        public double DiemTu { get; set; }

        public double DiemDen { get; set; }
        
        public string Loai { get; set; }

        public string GhiChu { get; set; }
    }
}
