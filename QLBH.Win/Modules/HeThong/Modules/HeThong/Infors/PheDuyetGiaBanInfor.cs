using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.HeThong.Infors
{
    [Serializable]
    public class PheDuyetGiaBanInfor
    {
        public int IdNhomNguoiDung { get; set; }

        public string NhomNguoiDung { get; set; }

        public string MaNganhHang { get; set; }

        public string TenNganhHang { get; set; }

        public string MaLinhVuc { get; set; }

        public string TenLinhVuc { get; set; }

        public double DungSaiMIN { get; set; }

        public double DungSaiMAX { get; set; }

        public int DoUuTien { get; set; }
    }
}
