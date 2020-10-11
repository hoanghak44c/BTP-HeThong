using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.HeThong.Infors
{
    [Serializable]
    public class NhomNguoiDungInfor
    {
        public int IdNhomNguoiDung { get; set; }

        public string MaNhom { get; set; }

        public string TenNhom { get; set; }

        public string MoTa { get; set; }

        public int XemTon { get; set; }

        public int QuanTri { get; set; }

        public int DieuChuyen { get; set; }

        public int SuaChungTu { get; set; }

        public int SaleAdmin { get; set; }

        public int XemBaoCao { get; set; }

        public int ChonTrungTamHienTai { get; set; }

        public int ShowNotify { get; set; }

        public int NhomQuyenHan { get; set; }

        public bool SuDung { get; set; }

        public ArrayList ChucNangNguoiDung { get; set; }

        public ArrayList PhanQuyenNganhHang { get; set; }

        public ArrayList PhanQuyenHangSanXuat { get; set; }
    }
}
