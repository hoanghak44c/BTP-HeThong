using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.HeThong.Infors
{
    [Serializable]
    public class ChucNangInfor
    {
        public int IdChucNang { get; set; }

        public string MaChucNang { get; set; }

        public string TenChucNang { get; set; }

        public string ParentName { get; set; }

        public string ParentId { get; set; }
    }
}
