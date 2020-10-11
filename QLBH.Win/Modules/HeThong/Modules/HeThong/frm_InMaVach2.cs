using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBH.Core.Exceptions;
using QLBH.Core.Form;
using QLBH.Core.Infors;
using QLBH.Core.Printers.Godex;
using QLBH.Core.Providers;

namespace QLBanHang.Modules.HeThong
{
    public partial class frm_InMaVach2 : frmBCBase
    {
        private List<ItemInMaVachInfor> liSanPham = new List<ItemInMaVachInfor>();
        private List<ChungTuChiTietHangHoaBaseInfo> lstMaVach = new List<ChungTuChiTietHangHoaBaseInfo>();
        private AutoGenSerialFree autoGenSerialFree;
        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

        public frm_InMaVach2()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            gSanPham.DataSource = liSanPham;
            selector.View = gvSanPham;
            selector.CheckMarkColumn.Fixed = FixedStyle.Left;
            selector.CheckMarkColumn.VisibleIndex = 0;
        }
        private void frm_InMaVach2_Load(object sender, EventArgs e)
        {
            try
            {
                var tt = DMTrungTamDataProvider.GetTrungTamByIdInfo(Declare.IdTrungTam);

                if (tt != null)
                {
                    bteTrungTam.Text = tt.TenTrungTam;
                    bteTrungTam.Tag = tt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tlsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tlsPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if(autoGenSerialFree == null)
                {
                    throw new ManagedException("Bạn chưa sinh mã vạch");
                }

                autoGenSerialFree.PrintSerial();

                foreach (var chungTuChiTietHangHoaBaseInfo in lstMaVach)
                {
                    AutoGenSerialProvider.Instance.UseSerial(chungTuChiTietHangHoaBaseInfo.MaVach);
                }

                lstMaVach.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_InMaVach_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F9 && tlsPrint.Enabled)
                    this.tlsPrint_Click(sender, e);
                else if (e.KeyCode == Keys.F12 && tlsClose.Enabled)
                    this.tlsClose_Click(sender, e);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bteTrungTam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteTrungTam_ButtonClick(sender, e, bteTrungTam, nguoiDung.IdNhanVien);
        }

        private void bteTrungTam_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteTrungTam_KeyDown(sender, e, bteTrungTam, nguoiDung.IdNhanVien);
        }

        private void bteTrungTam_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteTrungTam);
        }

        private void tsbSinhMaVach_Click(object sender, EventArgs e)
        {
            if (liSanPham.Count <= 0) return;

            autoGenSerialFree = new AutoGenSerialFree(((DMTrungTamInfor)bteTrungTam.Tag).MaTrungTam, Declare.IdNhanVien);

            lstMaVach.Clear();

            frmProgress.Instance.Caption = "Sinh serial";

            frmProgress.Instance.Description = "Đang sinh serial ...";

            frmProgress.Instance.Value = 0;

            frmProgress.Instance.MaxValue = 0;

            foreach (var sp in liSanPham)
            {
                if (sp.TrungMaVach == 1)

                    frmProgress.Instance.MaxValue += 1;

                else

                    frmProgress.Instance.MaxValue += sp.SoLuong;
            }

            frmProgress.Instance.DoWork(delegate
            {
                foreach (var sp in liSanPham)
                {
                    autoGenSerialFree.GenSerial(sp, lstMaVach);
                }

                frmProgress.Instance.Value = frmProgress.Instance.MaxValue;

                frmProgress.Instance.Description = "Đã xong";

                frmProgress.Instance.IsCompleted = true;
            });
        }

        private void bteSanPham_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var frmLookUp = new frmLookUp_SanPham(true, String.Format("%{0}%", bteSanPham.Text));

            if (frmLookUp.ShowDialog() != DialogResult.OK) return;

            foreach (var dmSanPhamInfo in frmLookUp.SelectedItems)
            {
                liSanPham.Add(new ItemInMaVachInfor
                                  {
                                      IdSanPham = dmSanPhamInfo.IdSanPham,
                                      MaSanPham = dmSanPhamInfo.MaSanPham,
                                      TenSanPham = dmSanPhamInfo.TenSanPham,
                                      LoaiSanPham = dmSanPhamInfo.TenLoaiSP,
                                      SoLuong = 1,
                                      Nganh = dmSanPhamInfo.Nganh,
                                      TrungMaVach = dmSanPhamInfo.TrungMaVach
                                  });
            }
                
            gSanPham.RefreshDataSource();

            this.groupBox4.Text = "Danh sách sản phẩm (" + liSanPham.Count + " sản phẩm)";
        }

        private void bteSanPham_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(bteSanPham.Text)) bteSanPham.Tag = null;
        }

        private void bteSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            var frmLookUp = new frmLookUp_SanPham(true, String.Format("%{0}%", bteSanPham.Text));

            if (frmLookUp.ShowDialog() != DialogResult.OK) return;

            foreach (var dmSanPhamInfo in frmLookUp.SelectedItems)
            {
                liSanPham.Add(new ItemInMaVachInfor
                {
                    IdSanPham = dmSanPhamInfo.IdSanPham,
                    MaSanPham = dmSanPhamInfo.MaSanPham,
                    TenSanPham = dmSanPhamInfo.TenSanPham,
                    LoaiSanPham = dmSanPhamInfo.TenLoaiSP,
                    SoLuong = 1,
                    Nganh = dmSanPhamInfo.Nganh,
                    TrungMaVach = dmSanPhamInfo.TrungMaVach
                });
            }

            gSanPham.RefreshDataSource();

            this.groupBox4.Text = "Danh sách sản phẩm (" + liSanPham.Count + " sản phẩm)";
        }

        private void bteNganh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            var frmLookUp = new frmLookUp_Nganh(String.Format("%{0}%", bteNganh.Text));

            if (frmLookUp.ShowDialog() != DialogResult.OK) return;

            bteNganh.Text = frmLookUp.SelectedItem.Ten;
            
            bteNganh.Tag = frmLookUp.SelectedItem;
        }

        private void bteNganh_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var frmLookUp = new frmLookUp_Nganh(String.Format("%{0}%", bteNganh.Text));

            if (frmLookUp.ShowDialog() != DialogResult.OK) return;

            bteNganh.Text = frmLookUp.SelectedItem.Ten;
            
            bteNganh.Tag = frmLookUp.SelectedItem;
        }

        private void bteNganh_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(bteNganh.Text)) bteNganh.Tag = null;
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (selector.selection.Count <= 0) return;

            foreach (ItemInMaVachInfor sp in selector.selection)
            {
                lstMaVach.RemoveAll(delegate(ChungTuChiTietHangHoaBaseInfo match)

                                        { return match.IdSanPham == sp.IdSanPham; });

                liSanPham.RemoveAll(delegate(ItemInMaVachInfor match) { return match.IdSanPham == sp.IdSanPham; });
            }

            gSanPham.RefreshDataSource();
        }
    }

    public class AutoGenSerialFree : AutoGenSerial<ItemInMaVachInfor, ChungTuChiTietHangHoaBaseInfo>
    {
        public AutoGenSerialFree(string maTrungTam, int idNhanVien) : base(maTrungTam, idNhanVien) { }
    }
}