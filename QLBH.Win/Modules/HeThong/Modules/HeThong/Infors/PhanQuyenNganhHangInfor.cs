using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.HeThong.Infors
{
    [Serializable]
    public class PhanQuyenNganhHangInfor
    {

        public string MaLoai { get; set; }

        public string TenLoai { get; set; }

        public string MaNganhHang { get; set; }

        public string TenNganhHang { get; set; }

        public string MaLinhVuc { get; set; }

        public string TenLinhVuc { get; set; }
    }
}
