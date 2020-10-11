using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBH.Core.Data;


namespace QLBanHang.Modules.HeThong
{
    public class UtilFunctions
    {
        #region common items
        public static bool bteItem_TextChanged(object sender, EventArgs e, DevExpress.XtraEditors.ButtonEdit bteItem)
        {
            if (bteItem.Text == String.Empty)
            {
                bteItem.Tag = null;
                return true;
            }
            return false;
        }
        #endregion

        #region bteTrungTam
        public static bool bteTrungTam_KeyDown(object sender, KeyEventArgs e, DevExpress.XtraEditors.ButtonEdit bteTrungTam, int idNhanVien)
        {
            return  bteTrungTam_KeyDown(sender, e, bteTrungTam, idNhanVien, -1);
        }
        public static bool bteTrungTam_KeyDown(object sender, KeyEventArgs e, DevExpress.XtraEditors.ButtonEdit bteTrungTam, int idNhanVien, int baoHanh)
        {
            if (bteTrungTam.Properties.ReadOnly) return false;
            if (e.KeyCode == Keys.Enter)
            {
                DMTrungTamInfor ttam = DMTrungTamDataProvider.GetTrungTamByText(bteTrungTam.Text);
                if (ttam != null)
                {
                    bteTrungTam.Text = ttam.TenTrungTam;
                    bteTrungTam.Tag = ttam;
                    return true;                    
                }
                else
                {
                    frmLookUp_TrungTam frmLookUp = new frmLookUp_TrungTam(false, String.Format("%{0}%", bteTrungTam.Text), idNhanVien, baoHanh);
                    if (frmLookUp.ShowDialog() == DialogResult.OK)
                    {
                        bteTrungTam.Text = frmLookUp.SelectedItem.TenTrungTam;
                        bteTrungTam.Tag = frmLookUp.SelectedItem;
                        return true;
                    }                   
                } 
            }
            return false;
        }
        public static bool bteTrungTam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e, DevExpress.XtraEditors.ButtonEdit bteTrungTam, int idNhanVien)
        {
            return bteTrungTam_ButtonClick(sender, e, bteTrungTam, idNhanVien, -1);
        }
        public static bool bteTrungTam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e, DevExpress.XtraEditors.ButtonEdit bteTrungTam, int idNhanVien, int baoHanh)
        {
            if (bteTrungTam.Properties.ReadOnly) return false;
            //DMTrungTamInfor ttam = DMTrungTamDataProvider.GetTrungTamByText(bteTrungTam.Text);
            //if (ttam != null)
            //{
            //    bteTrungTam.Text = ttam.TenTrungTam;
            //    bteTrungTam.Tag = ttam;
            //    return true;
            //}
            //else
            //{
            frmLookUp_TrungTam frmLookUp = new frmLookUp_TrungTam(false, String.Format("%{0}%", bteTrungTam.Text), idNhanVien, baoHanh);
            if (frmLookUp.ShowDialog() == DialogResult.OK)
            {
                bteTrungTam.Text = frmLookUp.SelectedItem.TenTrungTam;
                bteTrungTam.Tag = frmLookUp.SelectedItem;
                return true;
            }
            //}

            return false;
        }
        #endregion

        #region bteKho
        public static bool bteKhoXuat_KeyDown(object sender, KeyEventArgs e, DevExpress.XtraEditors.ButtonEdit bteKhoXuat, int idTrungTam, int idNhanVien)
        {
            return bteKhoXuat_KeyDown(sender, e, bteKhoXuat, idTrungTam, idNhanVien, -1);
        }
        /// <summary>
        /// Dùng cho trường hợp nhập lại hàng mua.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="bteKhoXuat"></param>
        /// <param name="idTrungTam"></param>
        /// <param name="idNhanVien"></param>
        /// <param name="baoHanh"></param>
        /// <returns></returns>
        public static bool bteKhoXuatNhapLai_KeyDown(object sender, KeyEventArgs e, DevExpress.XtraEditors.ButtonEdit bteKhoXuat, int idTrungTam, int idNhanVien)
        {
            if (bteKhoXuat.Properties.ReadOnly) return false;
            if (e.KeyCode == Keys.Enter)
            {
                DMKhoInfo kho = DMKhoDataProvider.Instance.GetKhoByText(bteKhoXuat.Text);
                if (kho != null)
                {
                    bteKhoXuat.Text = kho.TenKho;
                    bteKhoXuat.Tag = kho;
                    return true;
                }
                else
                {
                    var frmLookUp = new frmLookUp_KhoNhapLai(false, String.Format("%{0}%", bteKhoXuat.Text), idTrungTam, idNhanVien, -1);
                    if (frmLookUp.ShowDialog() == DialogResult.OK)
                    {
                        bteKhoXuat.Text = frmLookUp.SelectedItem.TenKho;
                        bteKhoXuat.Tag = frmLookUp.SelectedItem;
                    }
                }
            }
            return false;
        }

        public static bool bteKhoXuat_KeyDown(object sender, KeyEventArgs e, DevExpress.XtraEditors.ButtonEdit bteKhoXuat, int idTrungTam, int idNhanVien, int baoHanh)
        {
            if (bteKhoXuat.Properties.ReadOnly) return false;
            if (e.KeyCode == Keys.Enter)
            {
                DMKhoInfo kho = DMKhoDataProvider.Instance.GetKhoByText(bteKhoXuat.Text);
                if (kho != null)
                {
                    bteKhoXuat.Text = kho.TenKho;
                    bteKhoXuat.Tag = kho;
                    return true;
                }
                else
                {
                    frmLookUp_Kho frmLookUp = new frmLookUp_Kho(false, String.Format("%{0}%", bteKhoXuat.Text), idTrungTam, idNhanVien, baoHanh);
                    if (frmLookUp.ShowDialog() == DialogResult.OK)
                    {
                        bteKhoXuat.Text = frmLookUp.SelectedItem.TenKho;
                        bteKhoXuat.Tag = frmLookUp.SelectedItem;
                    }
                } 
            }
            return false;
        }

        public static bool bteKhoXuat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e, DevExpress.XtraEditors.ButtonEdit bteKhoXuat, int idTrungTam, int idNhanVien)
        {
            return bteKhoXuat_ButtonClick(sender, e, bteKhoXuat, idTrungTam, idNhanVien, -1);
        }
        /// <summary>
        /// Dùng cho chức năng nhập lại hàng mua.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="bteKhoXuat"></param>
        /// <param name="idTrungTam"></param>
        /// <param name="idNhanVien"></param>
        /// <param name="baoHanh"></param>
        /// <returns></returns>
        public static bool bteKhoXuatNhapLai_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e, DevExpress.XtraEditors.ButtonEdit bteKhoXuat, int idTrungTam, int idNhanVien)
        {
            if (bteKhoXuat.Properties.ReadOnly) return false;
            //DMKhoInfo kho = DMKhoDataProvider.Instance.GetKhoByText(bteKhoXuat.Text);
            //if (kho != null)
            //{
            //    bteKhoXuat.Text = kho.TenKho;
            //    bteKhoXuat.Tag = kho;
            //    return true;
            //}
            //else
            //{
            frmLookUp_KhoNhapLai frmLookUp = new frmLookUp_KhoNhapLai(false, String.Format("%{0}%", bteKhoXuat.Text), idTrungTam, idNhanVien, -1);

            if (frmLookUp.ShowDialog() == DialogResult.OK)
            {
                bteKhoXuat.Text = frmLookUp.SelectedItem.TenKho;
                bteKhoXuat.Tag = frmLookUp.SelectedItem;
                return true;
            }
            //} 

            return false;
            
        }
        public static bool bteKhoXuat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e, DevExpress.XtraEditors.ButtonEdit bteKhoXuat, int idTrungTam, int idNhanVien, int baoHanh)
        {
            if (bteKhoXuat.Properties.ReadOnly) return false;
            //DMKhoInfo kho = DMKhoDataProvider.Instance.GetKhoByText(bteKhoXuat.Text);
            //if (kho != null)
            //{
            //    bteKhoXuat.Text = kho.TenKho;
            //    bteKhoXuat.Tag = kho;
            //    return true;
            //}
            //else
            //{
            frmLookUp_Kho frmLookUp = new frmLookUp_Kho(false, String.Format("%{0}%", bteKhoXuat.Text), idTrungTam, idNhanVien, baoHanh);

            if (frmLookUp.ShowDialog() == DialogResult.OK)
            {
                bteKhoXuat.Text = frmLookUp.SelectedItem.TenKho;
                bteKhoXuat.Tag = frmLookUp.SelectedItem;
                return true;
            }
            //} 

            return false;
        }
        #endregion

        #region bteNhanVien
        public static bool bteNhanVien_KeyDown(object sender, KeyEventArgs e, DevExpress.XtraEditors.ButtonEdit bteNhanVien, int idKho)
        {
            if (bteNhanVien.Properties.ReadOnly) return false;
            if (e.KeyCode == Keys.Enter)
            {
                DMNhanVienInfo nhanvien = DmNhanVienDataProvider.GetNhanVienByText(bteNhanVien.Text);
                if (nhanvien != null)
                {
                    bteNhanVien.Text = nhanvien.HoTen;
                    bteNhanVien.Tag = nhanvien;
                    return true;
                }
                else
                {
                    frmLookUp_NhanVien frmLookUp = new frmLookUp_NhanVien(false, String.Format("%{0}%", bteNhanVien.Text), idKho);
                    if (frmLookUp.ShowDialog() == DialogResult.OK)
                    {
                        bteNhanVien.Text = frmLookUp.SelectedItem.HoTen;
                        bteNhanVien.Tag = frmLookUp.SelectedItem;
                        return true;
                    }
                } 
            }
            return false;
        }
        public static bool bteNhanVien_KeyDown(object sender, KeyEventArgs e, DevExpress.XtraEditors.ButtonEdit bteNhanVien, int idKho, int userId)
        {
            if (bteNhanVien.Properties.ReadOnly) return false;
            if (e.KeyCode == Keys.Enter)
            {
                DMNhanVienInfo nhanvien = DmNhanVienDataProvider.GetNhanVienByText(bteNhanVien.Text);
                if (nhanvien != null)
                {
                    bteNhanVien.Text = nhanvien.HoTen;
                    bteNhanVien.Tag = nhanvien;
                    return true;
                }
                else
                {
                    frmLookUp_NhanVien frmLookUp = new frmLookUp_NhanVien(false, String.Format("%{0}%", bteNhanVien.Text), idKho, userId);
                    if (frmLookUp.ShowDialog() == DialogResult.OK)
                    {
                        bteNhanVien.Text = frmLookUp.SelectedItem.HoTen;
                        bteNhanVien.Tag = frmLookUp.SelectedItem;
                        return true;
                    }
                } 
            }
            return false;
        }
        public static bool bteNhanVien_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e, DevExpress.XtraEditors.ButtonEdit bteNhanVien, int idKho, int userId)
        {
            if (bteNhanVien.Properties.ReadOnly) return false;
            //DMNhanVienInfo nhanvien = DmNhanVienDataProvider.GetNhanVienByText(bteNhanVien.Text);
            //if (nhanvien != null)
            //{
            //    bteNhanVien.Text = nhanvien.HoTen;
            //    bteNhanVien.Tag = nhanvien;
            //    return true;
            //}
            //else
            //{
                frmLookUp_NhanVien frmLookUp = new frmLookUp_NhanVien(false, String.Format("%{0}%", bteNhanVien.Text), idKho, userId);
                if (frmLookUp.ShowDialog() == DialogResult.OK)
                {
                    bteNhanVien.Text = frmLookUp.SelectedItem.HoTen;
                    bteNhanVien.Tag = frmLookUp.SelectedItem;
                    return true;
                }
            //} 

            return false;
        }
        public static bool bteNhanVien_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e, DevExpress.XtraEditors.ButtonEdit bteNhanVien, int idKho)
        {
            if (bteNhanVien.Properties.ReadOnly) return false;
            //DMNhanVienInfo nhanvien = DmNhanVienDataProvider.GetNhanVienByText(bteNhanVien.Text);
            //if (nhanvien != null)
            //{
            //    bteNhanVien.Text = nhanvien.HoTen;
            //    bteNhanVien.Tag = nhanvien;
            //    return true;
            //}
            //else
            //{
                frmLookUp_NhanVien frmLookUp = new frmLookUp_NhanVien(false, String.Format("%{0}%", bteNhanVien.Text), idKho);
                if (frmLookUp.ShowDialog() == DialogResult.OK)
                {
                    bteNhanVien.Text = frmLookUp.SelectedItem.HoTen;
                    bteNhanVien.Tag = frmLookUp.SelectedItem;
                    return true;
                }
            //} 

            return false;
        }
        #endregion

        #region bteTruongCa
        public static bool bteTruongCa_KeyDown(object sender, KeyEventArgs e, DevExpress.XtraEditors.ButtonEdit bteTruongCa, int idKho)
        {
            if (bteTruongCa.Properties.ReadOnly) return false;
            if (e.KeyCode == Keys.Enter)
            {
                frmLookUp_NhanVien frmLookUp = new frmLookUp_NhanVien(false, String.Format("%{0}%", bteTruongCa.Text), idKho, true);
                if (frmLookUp.ShowDialog() == DialogResult.OK)
                {
                    bteTruongCa.Text = frmLookUp.SelectedItem.HoTen;
                    bteTruongCa.Tag = frmLookUp.SelectedItem;
                    return true;
                }
            }
            return false;
        }
        public static bool bteTruongCa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e, DevExpress.XtraEditors.ButtonEdit bteTruongCa, int idKho)
        {
            if (bteTruongCa.Properties.ReadOnly) return false;
            frmLookUp_NhanVien frmLookUp = new frmLookUp_NhanVien(false, String.Format("%{0}%", bteTruongCa.Text), idKho, true);
            if (frmLookUp.ShowDialog() == DialogResult.OK)
            {
                bteTruongCa.Text = frmLookUp.SelectedItem.HoTen;
                bteTruongCa.Tag = frmLookUp.SelectedItem;
                return true;
            }
            return false;
        }
        #endregion

        #region bteNhaCungCap
        public static bool bteNhaCungCap_KeyDown(object sender, KeyEventArgs e, DevExpress.XtraEditors.ButtonEdit bteNhaCungCap, bool giaoVan)
        {
            if (bteNhaCungCap.Properties.ReadOnly) return false;
            if (e.KeyCode == Keys.Enter)
            {
                //DMDoiTuongInfo doituong = DmDoiTuongProvider.Instance.GetDoiTuongByText(bteNhaCungCap.Text);
                //if (doituong != null)
                //{
                //    bteNhaCungCap.Text = doituong.TenDoiTuong;
                //    bteNhaCungCap.Tag = doituong;
                //    return true;
                //}
                //else
                //{
                    frmLookUp_NhaCungCap frmLookUp = new frmLookUp_NhaCungCap(false, String.Format("%{0}%", bteNhaCungCap.Text), giaoVan);
                    if (frmLookUp.ShowDialog() == DialogResult.OK)
                    {
                        bteNhaCungCap.Text = frmLookUp.SelectedItem.TenDoiTuong;
                        bteNhaCungCap.Tag = frmLookUp.SelectedItem;
                        return true;
                    }
                //}
            }
            return false;
        }
        public static bool bteNhaCungCap_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e, DevExpress.XtraEditors.ButtonEdit bteNhaCungCap, bool giaoVan)
        {
            if (bteNhaCungCap.Properties.ReadOnly) return false;
            //DMDoiTuongInfo doituong = DmDoiTuongProvider.Instance.GetDoiTuongByText(bteNhaCungCap.Text);
            //if (doituong != null)
            //{
            //    bteNhaCungCap.Text = doituong.TenDoiTuong;
            //    bteNhaCungCap.Tag = doituong;
            //    return true;
            //}
            //else
            //{
            frmLookUp_NhaCungCap frmLookUp = new frmLookUp_NhaCungCap(false, String.Format("%{0}%", bteNhaCungCap.Text), giaoVan);
                if (frmLookUp.ShowDialog() == DialogResult.OK)
                {
                    bteNhaCungCap.Text = frmLookUp.SelectedItem.TenDoiTuong;
                    bteNhaCungCap.Tag = frmLookUp.SelectedItem;
                    return true;
                }
            //}

            return false;
        }
        #endregion

        #region bteKhachHang
        public static bool bteKhachHang_KeyDown(object sender, KeyEventArgs e, DevExpress.XtraEditors.ButtonEdit bteKhachHang, int idLoaiDT)
        {
            if (bteKhachHang.Properties.ReadOnly) return false;
            if (e.KeyCode == Keys.Enter)
            {
                DMDoiTuongInfo doituong = DmDoiTuongProvider.Instance.GetDoiTuongByText(bteKhachHang.Text);
                if (doituong != null)
                {
                    bteKhachHang.Text = doituong.TenDoiTuong;
                    bteKhachHang.Tag = doituong;
                    return true;
                }
                else
                {
                    frmLookUp_KhachHang frmLookUp = new frmLookUp_KhachHang(false, String.Format("%{0}%", bteKhachHang.Text), idLoaiDT);
                    if (frmLookUp.ShowDialog() == DialogResult.OK)
                    {
                        bteKhachHang.Text = frmLookUp.SelectedItem.TenDoiTuong;
                        bteKhachHang.Tag = frmLookUp.SelectedItem;
                        return true;
                    }
                } 
            }
            return false;
        }
        public static bool bteKhachHang_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e, DevExpress.XtraEditors.ButtonEdit bteKhachHang, int idLoaiDT)
        {
            if (bteKhachHang.Properties.ReadOnly) return false;
            //DMDoiTuongInfo doituong = DmDoiTuongProvider.Instance.GetDoiTuongByText(bteKhachHang.Text);
            //if (doituong != null)
            //{
            //    bteKhachHang.Text = doituong.TenDoiTuong;
            //    bteKhachHang.Tag = doituong;
            //    return true;
            //}
            //else
            //{
                frmLookUp_KhachHang frmLookUp = new frmLookUp_KhachHang(false, String.Format("%{0}%", bteKhachHang.Text), idLoaiDT);
                if (frmLookUp.ShowDialog() == DialogResult.OK)
                {
                    bteKhachHang.Text = frmLookUp.SelectedItem.TenDoiTuong;
                    bteKhachHang.Tag = frmLookUp.SelectedItem;
                    return true;
                }
            //} 

            return false;
        }
        #endregion

        #region bteKhachLe
        public static bool bteKhachLe_KeyDown(object sender, KeyEventArgs e, DevExpress.XtraEditors.ButtonEdit bteKhachLe, int idDoiTuongCha)
        {
            if (bteKhachLe.Properties.ReadOnly) return false;
            if (e.KeyCode == Keys.Enter)
            {
                DMDoiTuongInfo doituong = DmDoiTuongProvider.Instance.GetDoiTuongKLByText(bteKhachLe.Text);
                if (doituong != null)
                {
                    bteKhachLe.Text = doituong.TenDoiTuong;
                    bteKhachLe.Tag = doituong;
                    return true;
                }
                else
                {
                    frmLookUp_KhachHangLe frmLookUp = new frmLookUp_KhachHangLe(false, String.Format("%{0}%", bteKhachLe.Text), idDoiTuongCha);
                    if (frmLookUp.ShowDialog() == DialogResult.OK)
                    {
                        bteKhachLe.Text = frmLookUp.SelectedItem.TenDoiTuong;
                        bteKhachLe.Tag = frmLookUp.SelectedItem;
                        return true;
                    }
                } 
            }
            return false;
        }
        public static bool bteKhachLe_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e, DevExpress.XtraEditors.ButtonEdit bteKhachLe, int idDoiTuongCha)
        {
            if (bteKhachLe.Properties.ReadOnly) return false;
            //DMDoiTuongInfo doituong = DmDoiTuongProvider.Instance.GetDoiTuongKLByText(bteKhachLe.Text);
            //if (doituong != null)
            //{
            //    bteKhachLe.Text = doituong.TenDoiTuong;
            //    bteKhachLe.Tag = doituong;
            //    return true;
            //}
            //else
            //{
                frmLookUp_KhachHangLe frmLookUp = new frmLookUp_KhachHangLe(false, String.Format("%{0}%", bteKhachLe.Text), idDoiTuongCha);
                if (frmLookUp.ShowDialog() == DialogResult.OK)
                {
                    bteKhachLe.Text = frmLookUp.SelectedItem.TenDoiTuong;
                    bteKhachLe.Tag = frmLookUp.SelectedItem;
                    return true;
                }
            //} 

            return false;
        }
        #endregion
        #region bteSanPham
        public static void bteItemSegment_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e, DevExpress.XtraEditors.ButtonEdit bteItemSegment, int itemType)
        {
            if (bteItemSegment.Properties.ReadOnly) return;
            NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
            int idNND = Common.Int2Bool(nguoiDung.SupperUser) ? -1 : nguoiDung.IdNhomNguoiDung;
            frmLookUp_ItemSegment frm = new frmLookUp_ItemSegment(false, idNND, itemType, 1, -1, String.Format("%{0}%", bteItemSegment.Text));

            if (frm.ShowDialog() == DialogResult.OK)
            {
                bteItemSegment.Tag = frm.SelectedItem;
                bteItemSegment.Text = frm.SelectedItem.Ma;
            }
        }

        public static void bteItemSegment_KeyDown(object sender, KeyEventArgs e, DevExpress.XtraEditors.ButtonEdit bteItemSegment, int itemType)
        {
            if (bteItemSegment.Properties.ReadOnly) return;
            NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
            int idNND = Common.Int2Bool(nguoiDung.SupperUser) ? -1 : nguoiDung.IdNhomNguoiDung;

            if (e.KeyCode == Keys.Enter)
            {
                ItemSegmentInfo item = ItemSegmentDataProvider.Instance.GetAllItemsByTypeandText(idNND, itemType, -1, 1,
                                                                                                 bteItemSegment.Text);
                if (item != null)
                {
                    bteItemSegment.Text = item.Ma;
                    bteItemSegment.Tag = item;
                }
                else
                {
                    frmLookUp_ItemSegment frm = new frmLookUp_ItemSegment(false, idNND, itemType, 1, -1, String.Format("%{0}%", bteItemSegment.Text));

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        bteItemSegment.Tag = frm.SelectedItem;
                        bteItemSegment.Text = frm.SelectedItem.Ma;
                    }
                }
            }
        }
        #endregion
        #region bteThoiHanThanhToan
        public static bool bteThoiHanThanhToan_KeyDown(object sender, KeyEventArgs e, DevExpress.XtraEditors.ButtonEdit bteThoiHanThanhToan)
        {
            if (bteThoiHanThanhToan.Properties.ReadOnly) return false;
            if (e.KeyCode == Keys.Enter)
            {
                DMLoaiThuChiInfor thuchi = DMLoaiThuChiDataProvider.GetDmThuChiInfoByText(bteThoiHanThanhToan.Text);
                if (thuchi != null)
                {
                    bteThoiHanThanhToan.Text = thuchi.Ten;
                    bteThoiHanThanhToan.Tag = thuchi;
                    return true;
                }
                else
                {
                    frmLookUp_ThoiHanThanhToan frmLookUp = new frmLookUp_ThoiHanThanhToan(false, String.Format("%{0}%", bteThoiHanThanhToan.Text));
                    if (frmLookUp.ShowDialog() == DialogResult.OK)
                    {
                        bteThoiHanThanhToan.Text = frmLookUp.SelectedItem.Ten;
                        bteThoiHanThanhToan.Tag = frmLookUp.SelectedItem;
                        return true;
                    }
                } 
            }
            return false;
        }
        public static bool bteThoiHanThanhToan_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e, DevExpress.XtraEditors.ButtonEdit bteThoiHanThanhToan)
        {
            if (bteThoiHanThanhToan.Properties.ReadOnly) return false;
            //DMLoaiThuChiInfor thuchi = DMLoaiThuChiDataProvider.GetDmThuChiInfoByText(bteThoiHanThanhToan.Text);
            //if (thuchi != null)
            //{
            //    bteThoiHanThanhToan.Text = thuchi.Ten;
            //    bteThoiHanThanhToan.Tag = thuchi;
            //    return true;
            //}
            //else
            //{
                frmLookUp_ThoiHanThanhToan frmLookUp = new frmLookUp_ThoiHanThanhToan(false, String.Format("%{0}%", bteThoiHanThanhToan.Text));
                if (frmLookUp.ShowDialog() == DialogResult.OK)
                {
                    bteThoiHanThanhToan.Text = frmLookUp.SelectedItem.Ten;
                    bteThoiHanThanhToan.Tag = frmLookUp.SelectedItem;
                    return true;
                }
            //} 

            return false;
        }
        #endregion

        #region bteSanPham
        public static void bteSanPham_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e, DevExpress.XtraEditors.ButtonEdit bteSanPham)
        {
            if (bteSanPham.Properties.ReadOnly) return;
            //DMSanPhamInfo sanpham = DmSanPhamProvider.GetSanPhamByText(bteSanPham.Text);
            //if (sanpham != null)
            //{
            //    bteSanPham.Text = sanpham.TenSanPham;
            //    bteSanPham.Tag = sanpham;
            //}
            //else
            //{
                frmLookUp_SanPham frmLookUp = new frmLookUp_SanPham(String.Format("%{0}%", bteSanPham.Text));
                if (frmLookUp.ShowDialog() == DialogResult.OK)
                {
                    bteSanPham.Text = frmLookUp.SelectedItem.TenSanPham;
                    bteSanPham.Tag = frmLookUp.SelectedItem;
                }
            //} 
        }

        public static void bteSanPham_KeyDown(object sender, KeyEventArgs e, DevExpress.XtraEditors.ButtonEdit bteSanPham)
        {
            if (bteSanPham.Properties.ReadOnly) return;
            if (e.KeyCode == Keys.Enter)
            {
                DMSanPhamInfo sanpham = DmSanPhamProvider.GetSanPhamByText(bteSanPham.Text);
                if (sanpham != null)
                {
                    bteSanPham.Text = sanpham.TenSanPham;
                    bteSanPham.Tag = sanpham;
                }
                else
                {
                    frmLookUp_SanPham frmLookUp = new frmLookUp_SanPham(String.Format("%{0}%", bteSanPham.Text));
                    if (frmLookUp.ShowDialog() == DialogResult.OK)
                    {
                        bteSanPham.Text = frmLookUp.SelectedItem.TenSanPham;
                        bteSanPham.Tag = frmLookUp.SelectedItem;
                    }
                } 
            }
        }
        #endregion

        #region bteLoaiSanPham
        public static void bteLoaiSanPham_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e, DevExpress.XtraEditors.ButtonEdit bteLoaiSanPham)
        {
            if (bteLoaiSanPham.Properties.ReadOnly) return;
            //DMLoaiSanPhamInfo loaisp = DMLoaiSanPhamDataProvider.Instance.GetLoaiSanPhamByText(bteLoaiSanPham.Text);
            //if (loaisp != null)
            //{
            //    bteLoaiSanPham.Text = loaisp.TenLoaiSP;
            //    bteLoaiSanPham.Tag = loaisp;
            //}
            //else
            //{
                frmLookUp_LoaiSanPham frmLookUp = new frmLookUp_LoaiSanPham(String.Format("%{0}%", bteLoaiSanPham.Text));
                if (frmLookUp.ShowDialog() == DialogResult.OK)
                {
                    bteLoaiSanPham.Text = frmLookUp.SelectedItem.TenLoaiSP;
                    bteLoaiSanPham.Tag = frmLookUp.SelectedItem;
                }
            //} 
        }

        public static void bteLoaiSanPham_KeyDown(object sender, KeyEventArgs e, DevExpress.XtraEditors.ButtonEdit bteLoaiSanPham)
        {
            if (bteLoaiSanPham.Properties.ReadOnly) return;
            if (e.KeyCode == Keys.Enter)
            {
                DMLoaiSanPhamInfo loaisp = DMLoaiSanPhamDataProvider.Instance.GetLoaiSanPhamByText(bteLoaiSanPham.Text);
                if (loaisp != null)
                {
                    bteLoaiSanPham.Text = loaisp.TenLoaiSP;
                    bteLoaiSanPham.Tag = loaisp;
                }
                else
                {
                    frmLookUp_LoaiSanPham frmLookUp = new frmLookUp_LoaiSanPham(String.Format("%{0}%", bteLoaiSanPham.Text));
                    if (frmLookUp.ShowDialog() == DialogResult.OK)
                    {
                        bteLoaiSanPham.Text = frmLookUp.SelectedItem.TenLoaiSP;
                        bteLoaiSanPham.Tag = frmLookUp.SelectedItem;
                    }
                } 
            }
        }
        #endregion

        #region bteTaiKhoanQuy
        public static bool bteTaiKhoanQuy_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e, DevExpress.XtraEditors.ButtonEdit bteTaiKhoanQuy, int idTrungTam)
        {
            if (bteTaiKhoanQuy.Properties.ReadOnly) return false;
            frmLookUp_TaiKhoanQuy frmLookUp = new frmLookUp_TaiKhoanQuy(String.Format("%{0}%", bteTaiKhoanQuy.Text), idTrungTam);
            if (frmLookUp.ShowDialog() == DialogResult.OK)
            {
                bteTaiKhoanQuy.Text = frmLookUp.SelectedItem.TaiKhoanQuy;
                bteTaiKhoanQuy.Tag = frmLookUp.SelectedItem;
                return true;
            }
            return false;
        }

        public static bool bteTaiKhoanQuy_KeyDown(object sender, KeyEventArgs e, DevExpress.XtraEditors.ButtonEdit bteTaiKhoanQuy, int idTrungTam)
        {
            if (bteTaiKhoanQuy.Properties.ReadOnly) return false;
            if (e.KeyCode == Keys.Enter)
            {
                DMTaiKhoanQuyInfo tkquy = DMTaiKhoanQuyDataProvider.Instance.GetTaiKhoanQuyByText(bteTaiKhoanQuy.Text);
                if (tkquy != null)
                {
                    bteTaiKhoanQuy.Text = tkquy.TaiKhoanQuy;
                    bteTaiKhoanQuy.Tag = tkquy;
                    return true;
                }
                else
                {
                    frmLookUp_TaiKhoanQuy frmLookUp = new frmLookUp_TaiKhoanQuy(String.Format("%{0}%", bteTaiKhoanQuy.Text), idTrungTam);
                    if (frmLookUp.ShowDialog() == DialogResult.OK)
                    {
                        bteTaiKhoanQuy.Text = frmLookUp.SelectedItem.TaiKhoanQuy;
                        bteTaiKhoanQuy.Tag = frmLookUp.SelectedItem;
                        return true;
                    }
                }
            }
            return false;
        }
        #endregion

        #region bteNganHang
        public static void bteNganHang_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e, DevExpress.XtraEditors.ButtonEdit bteNganHang)
        {
            if (bteNganHang.Properties.ReadOnly) return;
            frmLookUp_NganHang frmLookUp = new frmLookUp_NganHang(String.Format("%{0}%", bteNganHang.Text));
            if (frmLookUp.ShowDialog() == DialogResult.OK)
            {
                bteNganHang.Text = frmLookUp.SelectedItem.TenNganHang;
                bteNganHang.Tag = frmLookUp.SelectedItem;
            }
        }

        public static void bteNganHang_KeyDown(object sender, KeyEventArgs e, DevExpress.XtraEditors.ButtonEdit bteNganHang)
        {
            if (bteNganHang.Properties.ReadOnly) return;
            if (e.KeyCode == Keys.Enter)
            {
                DMNganHangInfor nganHang = DMNganHangDataProvider.Instance.GetNganHangByText(bteNganHang.Text);
                if (nganHang != null)
                {
                    bteNganHang.Text = nganHang.TenNganHang;
                    bteNganHang.Tag = nganHang;
                }
                else
                {
                    frmLookUp_NganHang frmLookUp = new frmLookUp_NganHang(String.Format("%{0}%", bteNganHang.Text));
                    if (frmLookUp.ShowDialog() == DialogResult.OK)
                    {
                        bteNganHang.Text = frmLookUp.SelectedItem.TenNganHang;
                        bteNganHang.Tag = frmLookUp.SelectedItem;
                    }
                }
            }
        }
        #endregion

        #region bteHangSanXuat
        public static bool bteHangSanXuat_KeyDown(object sender, KeyEventArgs e, DevExpress.XtraEditors.ButtonEdit bteHangSanXuat)
        {
            if (bteHangSanXuat.Properties.ReadOnly) return false;
            if (e.KeyCode == Keys.Enter)
            {
                frmLookUp_Hang frmLookUp = new frmLookUp_Hang(false, String.Format("%{0}%", bteHangSanXuat.Text));
                if (frmLookUp.ShowDialog() == DialogResult.OK)
                {
                    bteHangSanXuat.Text = frmLookUp.SelectedItem.Ten;
                    bteHangSanXuat.Tag = frmLookUp.SelectedItem;
                    return true;
                }
            }
            return false;
        }
        public static bool bteHangSanXuat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e, DevExpress.XtraEditors.ButtonEdit bteHangSanXuat)
        {
            if (bteHangSanXuat.Properties.ReadOnly) return false;
            frmLookUp_Hang frmLookUp = new frmLookUp_Hang(false, String.Format("%{0}%", bteHangSanXuat.Text));
            if (frmLookUp.ShowDialog() == DialogResult.OK)
            {
                bteHangSanXuat.Text = frmLookUp.SelectedItem.Ten;
                bteHangSanXuat.Tag = frmLookUp.SelectedItem;
                return true;
            }
            return false;
        }
        #endregion

        #region bteTinhThanh
        public static void bteTinhThanh_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e, DevExpress.XtraEditors.ButtonEdit bteTinhThanh, DevExpress.XtraEditors.ButtonEdit bteQuanHuyen)
        {
            if (bteTinhThanh.Properties.ReadOnly) return;
            DMTinhInfor old = (DMTinhInfor)bteTinhThanh.Tag;
            bteTinhThanh_ButtonClick(sender, e, bteTinhThanh);
            if (old == null && bteTinhThanh.Tag != null || old != null && bteTinhThanh.Tag == null ||
                old != null && bteTinhThanh.Tag != null && old.IdTinh == ((DMTinhInfor)bteTinhThanh.Tag).IdTinh)
            {
                bteQuanHuyen.Tag = null;
                bteQuanHuyen.Text = "";
            }
        }

        public static void bteTinhThanh_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e, DevExpress.XtraEditors.ButtonEdit bteTinhThanh)
        {
            if (bteTinhThanh.Properties.ReadOnly) return;
            //DMHuyenInfor huyen = DMHuyenDataProvider.Instance.GetQuanHuyenByText(bteQuanHuyen.Text);
            //if (huyen != null)
            //{
            //    bteQuanHuyen.Text = huyen.TenHuyen;
            //    bteQuanHuyen.Tag = huyen;
            //}
            //else
            //{
            frmLookUp_TinhThanh frmLookUp = new frmLookUp_TinhThanh(String.Format("%{0}%", bteTinhThanh.Text));
            if (frmLookUp.ShowDialog() == DialogResult.OK)
            {
                bteTinhThanh.Text = frmLookUp.SelectedItem.TenTinh;
                bteTinhThanh.Tag = frmLookUp.SelectedItem;
            }
            //} 
        }

        public static void bteTinhThanh_KeyDown(object sender, KeyEventArgs e, DevExpress.XtraEditors.ButtonEdit bteTinhThanh, DevExpress.XtraEditors.ButtonEdit bteQuanHuyen)
        {
            if (bteTinhThanh.Properties.ReadOnly) return;
            DMTinhInfor old = (DMTinhInfor)bteTinhThanh.Tag;
            bteTinhThanh_KeyDown(sender, e, bteTinhThanh);
            if (old == null && bteTinhThanh.Tag != null || old != null && bteTinhThanh.Tag == null ||
                old != null && bteTinhThanh.Tag != null && old.IdTinh == ((DMTinhInfor)bteTinhThanh.Tag).IdTinh)
            {
                bteQuanHuyen.Tag = null;
                bteQuanHuyen.Text = "";
            }
        }

        public static void bteTinhThanh_KeyDown(object sender, KeyEventArgs e, DevExpress.XtraEditors.ButtonEdit bteTinhThanh)
        {
            if (bteTinhThanh.Properties.ReadOnly) return;
            if (e.KeyCode == Keys.Enter)
            {
                DMTinhInfor tinh = DMTinhDataProvider.Instance.GetTinhThanhByText(bteTinhThanh.Text);
                if (tinh != null)
                {
                    bteTinhThanh.Text = tinh.TenTinh;
                    bteTinhThanh.Tag = tinh;
                }
                else
                {
                    frmLookUp_TinhThanh frmLookUp = new frmLookUp_TinhThanh(String.Format("%{0}%", bteTinhThanh.Text));
                    if (frmLookUp.ShowDialog() == DialogResult.OK)
                    {
                        bteTinhThanh.Text = frmLookUp.SelectedItem.TenTinh;
                        bteTinhThanh.Tag = frmLookUp.SelectedItem;
                    }
                }
            }
        }

        public static void bteTinhThanh_TextChanged(object sender, EventArgs e, DevExpress.XtraEditors.ButtonEdit bteTinhThanh, DevExpress.XtraEditors.ButtonEdit bteQuanHuyen)
        {
            if (bteTinhThanh.Text == String.Empty)
            {
                bteTinhThanh.Tag = null;
                bteTinhThanh.Text = "";

                bteQuanHuyen.Tag = null;
                bteQuanHuyen.Text = "";
            }
        }

        public static void LoadTinhThanh(DevExpress.XtraEditors.ButtonEdit bteTinhThanh, int idTinh)
        {
            if (idTinh < 0)
            {
                bteTinhThanh.Tag = null;
                bteTinhThanh.Text = "";
            }
            else
            {
                DMTinhInfor tinh = DMTinhDataProvider.Instance.GetTinhThanhById(idTinh);
                bteTinhThanh.Tag = tinh;
                bteTinhThanh.Text = tinh != null ? tinh.TenTinh : "";
            }
        }
        #endregion

        #region bteQuanHuyen
        public static void bteQuanHuyen_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e, DevExpress.XtraEditors.ButtonEdit bteQuanHuyen)
        {
            bteQuanHuyen_ButtonClick(sender, e, bteQuanHuyen, -1);
        }

        public static void bteQuanHuyen_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e, DevExpress.XtraEditors.ButtonEdit bteQuanHuyen, int idTinh)
        {
            if (bteQuanHuyen.Properties.ReadOnly) return;
            //DMHuyenInfor huyen = DMHuyenDataProvider.Instance.GetQuanHuyenByText(bteQuanHuyen.Text, idTinh);
            //if (huyen != null)
            //{
            //    bteQuanHuyen.Text = huyen.TenHuyen;
            //    bteQuanHuyen.Tag = huyen;
            //}
            //else
            //{
            frmLookUp_QuanHuyen frmLookUp = new frmLookUp_QuanHuyen(String.Format("%{0}%", bteQuanHuyen.Text), idTinh);
            if (frmLookUp.ShowDialog() == DialogResult.OK)
            {
                bteQuanHuyen.Text = frmLookUp.SelectedItem.TenHuyen;
                bteQuanHuyen.Tag = frmLookUp.SelectedItem;
            }
            //} 
        }

        public static void bteQuanHuyen_KeyDown(object sender, KeyEventArgs e, DevExpress.XtraEditors.ButtonEdit bteQuanHuyen)
        {
            bteQuanHuyen_KeyDown(sender, e, bteQuanHuyen, -1);
        }

        public static void bteQuanHuyen_KeyDown(object sender, KeyEventArgs e, DevExpress.XtraEditors.ButtonEdit bteQuanHuyen, int idTinh)
        {
            if (bteQuanHuyen.Properties.ReadOnly) return;
            if (e.KeyCode == Keys.Enter)
            {
                DMHuyenInfor huyen = DMHuyenDataProvider.Instance.GetQuanHuyenByText(bteQuanHuyen.Text, idTinh);
                if (huyen != null)
                {
                    bteQuanHuyen.Text = huyen.TenHuyen;
                    bteQuanHuyen.Tag = huyen;
                }
                else
                {
                    frmLookUp_QuanHuyen frmLookUp = new frmLookUp_QuanHuyen(String.Format("%{0}%", bteQuanHuyen.Text), idTinh);
                    if (frmLookUp.ShowDialog() == DialogResult.OK)
                    {
                        bteQuanHuyen.Text = frmLookUp.SelectedItem.TenHuyen;
                        bteQuanHuyen.Tag = frmLookUp.SelectedItem;
                    }
                }
            }
        }

        public static void LoadQuanHuyen(DevExpress.XtraEditors.ButtonEdit bteQuanHuyen, int idHuyen)
        {
            if (idHuyen < 0)
            {
                bteQuanHuyen.Tag = null;
                bteQuanHuyen.Text = "";
            }
            else
            {
                DMHuyenInfor huyen = DMHuyenDataProvider.Instance.GetQuanHuyenById(idHuyen);
                bteQuanHuyen.Tag = huyen;
                bteQuanHuyen.Text = huyen != null ? huyen.TenHuyen : "";
            }
        }
        #endregion

        #region mavach
        public static List<MaVachInfor> GenTrungMaVach(ItemInMaVachInfor sanpham)
        {
            string maVIP =
                DBTools.getValue(String.Format("select MAVIP from tbl_Map_SanPham where MaMoi = '{0}' and rownum=1", sanpham.MaSanPham));
            if (maVIP.Equals("")) maVIP = sanpham.MaSanPham;
            string maTrungTam =
                DBTools.getValue(String.Format("select MaTrungTam from tbl_DM_TrungTam where IdTrungTam = {0} and rownum=1", sanpham.IdTrungTam));
            maTrungTam = maTrungTam.Substring(0, 2);
            maVIP = maVIP.Replace(".", "");
            List<MaVachInfor> liMaVach = new List<MaVachInfor>();
            DateTime now = CommonProvider.Instance.GetSysDate();
            string sDate = "";
            sDate = now.Month < 10 ? String.Format("0{0}", now.Month) : now.Month.ToString();
            sDate = sDate + now.Year.ToString().Substring(2);

            int i = 0;
            MaVachInfor mv = new MaVachInfor();
            while (i < sanpham.SoLuong)
            {
                i++;
                if ((i % 6) == 1)
                {
                    mv = new MaVachInfor();
                    mv.MaVach1 = String.Format("{0}{1}{2}", maVIP, maTrungTam, sDate);
                    liMaVach.Add(mv);
                }
                else if ((i % 6) == 2)
                {
                    mv.MaVach2 = String.Format("{0}{1}{2}", maVIP, maTrungTam, sDate);
                }
                else if ((i % 6) == 3)
                {
                    mv.MaVach3 = String.Format("{0}{1}{2}", maVIP, maTrungTam, sDate);
                }
                else if ((i % 6) == 4)
                {
                    mv.MaVach4 = String.Format("{0}{1}{2}", maVIP, maTrungTam, sDate);
                }
                else if ((i % 6) == 5)
                {
                    mv.MaVach5 = String.Format("{0}{1}{2}", maVIP, maTrungTam, sDate);
                }
                else if ((i % 6) == 0)
                {
                    mv.MaVach6 = String.Format("{0}{1}{2}", maVIP, maTrungTam, sDate);
                }
            }
            return liMaVach;
        }
        
        public static List<MaVachInfor> GenTrungMaVach2(ItemInMaVachInfor sanpham)
        {
            var segment = sanpham.MaSanPham.Split(new[] {'.'});

            string maVIP = segment[segment.Length - 1];

            string maTrungTam =
                DBTools.getValue(String.Format("select MaTrungTam from tbl_DM_TrungTam where IdTrungTam = {0} and rownum=1", sanpham.IdTrungTam));
            maTrungTam = maTrungTam.Substring(0, 2);
            maVIP = maVIP.Replace(".", "");
            List<MaVachInfor> liMaVach = new List<MaVachInfor>();
            DateTime now = CommonProvider.Instance.GetSysDate();
            string sDate = now.ToString("yyMMdd");

            int i = 0;
            MaVachInfor mv = new MaVachInfor();
            while (i < sanpham.SoLuong)
            {
                i++;
                if ((i%6) == 1)
                {
                    mv = new MaVachInfor();
                    mv.MaVach1 = String.Format("{0}{1}{2}", maVIP, maTrungTam, sDate);
                    liMaVach.Add(mv);
                }
                else if ((i%6) == 2)
                {
                    mv.MaVach2 = String.Format("{0}{1}{2}", maVIP, maTrungTam, sDate);
                }
                else if ((i%6) == 3)
                {
                    mv.MaVach3 = String.Format("{0}{1}{2}", maVIP, maTrungTam, sDate);
                }
                else if ((i%6) == 4)
                {
                    mv.MaVach4 = String.Format("{0}{1}{2}", maVIP, maTrungTam, sDate);
                }
                else if ((i%6) == 5)
                {
                    mv.MaVach5 = String.Format("{0}{1}{2}", maVIP, maTrungTam, sDate);
                }
                else if ((i%6) == 0)
                {
                    mv.MaVach6 = String.Format("{0}{1}{2}", maVIP, maTrungTam, sDate);
                }
            }
            return liMaVach;
        }

        public static List<MaVachInfor> GenKhongTrungMaVach(ItemInMaVachInfor sanpham)
        {
            string maVIP =
                DBTools.getValue(String.Format("select MAVIP from tbl_Map_SanPham where MaMoi = '{0}' and rownum=1", sanpham.MaSanPham));
            if (maVIP.Equals("")) maVIP = sanpham.MaSanPham;
            string maTrungTam =
                DBTools.getValue(String.Format("select MaTrungTam from tbl_DM_TrungTam where IdTrungTam = {0} and rownum=1", sanpham.IdTrungTam));

            string strSoHienTai = DBTools.getValue(String.Format("select SoHienTai from tbl_DM_MaVach where MaTrungTam='{0}' and MaSanPham='{1}' and extract(year from ThoiGian) = extract(year from sysdate) and extract(month from ThoiGian) = extract(month from sysdate)", maTrungTam, sanpham.MaSanPham));
            sanpham.SoHienTai = Common.IntValue(strSoHienTai);

            maTrungTam = maTrungTam.Substring(0, 2);
            maVIP = maVIP.Replace(".", "");


            List<MaVachInfor> liMaVach = new List<MaVachInfor>();
            DateTime now = CommonProvider.Instance.GetSysDate();
            string sDate = "";
            sDate = now.Month < 10 ? String.Format("0{0}", now.Month) : now.Month.ToString();
            sDate = sDate + now.Year.ToString().Substring(2);

            int i = 0;
            MaVachInfor mv = new MaVachInfor();
            while (i < sanpham.SoLuong)
            {
                i++;
                sanpham.SoHienTai++;
                string sTT = "";
                if (sanpham.SoHienTai < 10) sTT = String.Format("00{0}", sanpham.SoHienTai);
                else if (sanpham.SoHienTai < 100) sTT = String.Format("0{0}", sanpham.SoHienTai);
                else sTT = String.Format("{0}", sanpham.SoHienTai);
                if ((i % 6) == 1)
                {
                    mv = new MaVachInfor();
                    mv.MaVach1 = String.Format("{0}{1}{2}{3}", maVIP, maTrungTam, sDate, sTT);
                    liMaVach.Add(mv);
                }
                else if ((i % 6) == 2)
                {
                    mv.MaVach2 = String.Format("{0}{1}{2}{3}", maVIP, maTrungTam, sDate, sTT);
                }
                else if ((i % 6) == 3)
                {
                    mv.MaVach3 = String.Format("{0}{1}{2}{3}", maVIP, maTrungTam, sDate, sTT);
                }
                else if ((i % 6) == 4)
                {
                    mv.MaVach4 = String.Format("{0}{1}{2}{3}", maVIP, maTrungTam, sDate, sTT);
                }
                else if ((i % 6) == 5)
                {
                    mv.MaVach5 = String.Format("{0}{1}{2}{3}", maVIP, maTrungTam, sDate, sTT);
                }
                else if ((i % 6) == 0)
                {
                    mv.MaVach6 = String.Format("{0}{1}{2}{3}", maVIP, maTrungTam, sDate, sTT);
                }
            }
            return liMaVach;
        }
        #endregion mavach

        #region trung tam - kho - doi tuong - nhan vien
        public static void LoadTrungTam(DevExpress.XtraEditors.ButtonEdit bteTrungTam, int idTrungTam)
        {
            if (idTrungTam <= 0)
            {
                bteTrungTam.Tag = null;
                bteTrungTam.Text = "";
            }
            else
            {
                DMTrungTamInfor tt = DMTrungTamDataProvider.GetTrungTamByIdInfo(idTrungTam);
                bteTrungTam.Tag = tt;
                bteTrungTam.Text = tt != null ? tt.TenTrungTam : "";
            }
        }

        public static void LoadKhoXuat(DevExpress.XtraEditors.ButtonEdit bteKho, int idKho)
        {
            if (idKho <= 0)
            {
                bteKho.Tag = null;
                bteKho.Text = "";
            }
            else
            {
                DMKhoInfo kho = DMKhoDataProvider.GetKhoByIdInfo(idKho);
                bteKho.Tag = kho;
                bteKho.Text = kho != null ? kho.TenKho : "";
            }
        }

        public static void LoadDoiTuong(DevExpress.XtraEditors.ButtonEdit bteDoiTuong, int idDoiTuong)
        {
            if (idDoiTuong <= 0)
            {
                bteDoiTuong.Tag = null;
                bteDoiTuong.Text = "";
            }
            else
            {
                DMDoiTuongInfo dt = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(idDoiTuong);
                bteDoiTuong.Tag = dt;
                bteDoiTuong.Text = dt != null ? dt.TenDoiTuong : "";
            }
        }

        public static void LoadNhanVien(DevExpress.XtraEditors.ButtonEdit bteNhanVien, int idNhanVien)
        {
            if (idNhanVien <= 0)
            {
                bteNhanVien.Tag = null;
                bteNhanVien.Text = "";
            }
            else
            {
                DMNhanVienInfo nv = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(idNhanVien);
                bteNhanVien.Tag = nv;
                bteNhanVien.Text = nv != null ? nv.HoTen : "";
            }
        }
        #endregion
    }
}
