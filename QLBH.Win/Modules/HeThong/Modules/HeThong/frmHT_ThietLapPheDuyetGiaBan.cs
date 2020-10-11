using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBH.Common;
using QLBanHang.Modules.HeThong.Providers;
using DevExpress.XtraBars.Ribbon;
using QLBanHang.Modules.HeThong.Infors;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmHT_ThietLapPheDuyetGiaBan : DevExpress.XtraEditors.XtraForm
    {
        #region Decalre......
        private objGridMarkSelection selectorCN = new objGridMarkSelection();
        private objGridMarkSelection selectorNH = new objGridMarkSelection();
        private ArrayList arrChucNang = new ArrayList();// Danh sách mảng chức năng
        private ArrayList arrPhanQuyenNganhHang = new ArrayList();// Danh sách mảng phân quyền ngành hàng
        #endregion

        public frmHT_ThietLapPheDuyetGiaBan()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void frmHT_ListNhomNguoiDung_Load(object sender, EventArgs e)
        {
            LoadAllPhanQuyenNganhHang();
        }
        public void LoadAllNhomNguoiDung()
        {
            gNhomNguoiDung.DataSource = NhomNguoiDungDataProvider.LoadAll();
        }

        private void LoadAllPhanQuyenNganhHang()
        {
            arrPhanQuyenNganhHang = new ArrayList(PhanQuyenNganhHangDataProvider.ListAllPheDuyetNganh());
            gNhomSanPham.DataSource = arrPhanQuyenNganhHang;
            gvNhomSanPham.Columns["TenLinhVuc"].GroupIndex = 0;
            gvNhomSanPham.ExpandAllGroups();
            //selectorNH.View = gvNhomSanPham;
            //selectorNH.CheckMarkColumn.VisibleIndex = 0;
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            //gChucNang.DataSource = ChucNangDataProvider.Search(txtFilterHanhDong.Text);
            //gvChucNang.Columns["ParentName"].GroupIndex = 0;
            //gvChucNang.ExpandAllGroups();
            //selectorCN.View = gvChucNang;
            //selectorCN.CheckMarkColumn.VisibleIndex = 0;

            txtFilterHanhDong.Focus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNND_Click(object sender, EventArgs e)
        {
            if (gvNhomSanPham.FocusedRowHandle < 0) return;
            PheDuyetNganhHangInfor pqNganhHang = (PheDuyetNganhHangInfor)gvNhomSanPham.GetRow(gvNhomSanPham.FocusedRowHandle);
            PheDuyetGiaBanInfor pheDuyetGiaBanInfor = new PheDuyetGiaBanInfor()
                                                          {
                                                              MaLinhVuc = pqNganhHang.MaLinhVuc,
                                                              TenLinhVuc = pqNganhHang.TenLinhVuc,
                                                              MaNganhHang = pqNganhHang.MaNganhHang,
                                                              TenNganhHang = pqNganhHang.TenNganhHang
                                                          };
            frmHT_AddPheDuyetGiaBan frm = new frmHT_AddPheDuyetGiaBan(pheDuyetGiaBanInfor);
            if (frm.ShowDialog()==DialogResult.OK)
            {               
                ((BindingList<PheDuyetGiaBanInfor>)gNhomNguoiDung.DataSource).Add(frm.PheDuyetGiaBan);
                ((BindingList<PheDuyetGiaBanInfor>)gNhomNguoiDung.DataSource).ResetBindings();
            }

        }

        private void btnXoaNND_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvNhomNguoiDung.FocusedRowHandle < 0) return;
                
                if (MessageBox.Show("Bạn có chắc chắn xóa nhóm tài khoản này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gvNhomNguoiDung.DeleteSelectedRows();
                }
            }
            catch { }
        }

        private void gvNhomSanPham_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvNhomSanPham.FocusedRowHandle < 0) return;

            PheDuyetNganhHangInfor pqNganhHang = (PheDuyetNganhHangInfor)gvNhomSanPham.GetRow(gvNhomSanPham.FocusedRowHandle);
            gNhomNguoiDung.DataSource =
                new BindingList<PheDuyetGiaBanInfor>(PhanQuyenNganhHangDataProvider.GetPheDuyetGiaBanByNganhHang(pqNganhHang.MaNganhHang));
        }

        private void btnSaveCN_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvNhomSanPham.FocusedRowHandle < 0) return;

                PheDuyetNganhHangInfor pqNganhHang = (PheDuyetNganhHangInfor)gvNhomSanPham.GetRow(gvNhomSanPham.FocusedRowHandle);
                PhanQuyenNganhHangDataProvider.DeletePheDuyetGiaBan(pqNganhHang.MaNganhHang);
                foreach (PheDuyetGiaBanInfor bg in (BindingList<PheDuyetGiaBanInfor>)gNhomNguoiDung.DataSource)
                {
                    PhanQuyenNganhHangDataProvider.UpdatePheDuyetGiaBan(bg);
                }
                MessageBox.Show("Cập nhật phê duyệt giá bán thành công!");
            }
            catch
            {
                
            }

        }

        private void gvNhomNguoiDung_DoubleClick(object sender, EventArgs e)
        {
            Point pt = gNhomNguoiDung.PointToClient(MousePosition);
            GridHitInfo hitInfo = gvNhomNguoiDung.CalcHitInfo(pt);
            if (hitInfo.InRow)
            {
                PheDuyetGiaBanInfor bg = (PheDuyetGiaBanInfor)gvNhomNguoiDung.GetRow(hitInfo.RowHandle);
                frmHT_AddPheDuyetGiaBan frm = new frmHT_AddPheDuyetGiaBan(bg);
                frm.ShowDialog();
            }
        }

    }
}