using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace QLBanHang.Modules.HeThong.Infors
{
    [Serializable]
    public class NguoiDungInfor
    {
        public int IdNguoiDung { get; set; }

        public string TenDangNhap { get; set; }

        public string MatKhau { get; set; }

        public string TenDayDu { get; set; }

        public string Salt { get; set; }

        public int IdNhanVien { get; set; }

        public string MaNhanVien { get; set; }

        public string TenNhanVien { get; set; }

        public string MaPhongBan { get; set; }

        public string TenPhongBan { get; set; }

        public string MaChucVu { get; set; }

        public string TenChucVu { get; set; }

        public int IdNhomNguoiDung { get; set; }

        public string NhomNguoiDung { get; set; }

        public bool SuDung { get; set; }

        public int Status { get; set; }

        public int SupperUser { get; set; }

        public int XemTon { get; set; }

        public int QuanTri { get; set; }

        public int DieuChuyen { get; set; }

        public int SuaChungTu { get; set; }

        public int SaleAdmin { get; set; }

        public int XemBaoCao { get; set; }

        public int ChonTrungTamHienTai { get; set; }

        public int ShowNotify { get; set; }

        public int NhomQuyenHan { get; set; }

        public DateTime NgayCap { get; set; }

        public int IdTrungTamHachToan { get; set; }

        public List<ChucNangInfor> ChucNangNguoiDung { get; set; }

        public ArrayList KhoNguoiDung { get; set; }

        public List<PhanQuyenNganhHangInfor> NganhHangNguoiDung { get; set; }

        public List<PhanQuyenHangSanXuatInfor> HangSanXuat { get; set; }

        public bool IsOnline { get; set; }

        public bool IsKinhDoanhThiTruong { get; set; }

        public DateTime NgayTaoMatKhau { get; set; }

        public int ThoiGianApDung { get; set; }

        public bool ChangeOnNext { get; set; }
    }
}
