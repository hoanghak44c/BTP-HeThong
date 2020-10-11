using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.HeThong.Infors
{
    [Serializable]
    public class PheDuyetNganhHangInfor
    {
        public string MaNganhHang { get; set; }

        public string TenNganhHang { get; set; }

        public string MaLinhVuc { get; set; }

        public string TenLinhVuc { get; set; }
    }
}
