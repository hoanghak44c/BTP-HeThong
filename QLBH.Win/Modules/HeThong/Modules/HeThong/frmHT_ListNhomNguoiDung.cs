using System;
using System.Collections;
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
    public partial class frmHT_ListNhomNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        #region Decalre......
        private objGridMarkSelection selectorCN = new objGridMarkSelection();
        private objGridMarkSelection selectorNH = new objGridMarkSelection();
        private objGridMarkSelection selectorSX = new objGridMarkSelection();
        private ArrayList arrChucNang = new ArrayList();// Danh sách mảng chức năng
        private ArrayList arrPhanQuyenNganhHang = new ArrayList();// Danh sách mảng phân quyền ngành hàng
        private ArrayList arrPhanQuyenHangSanXuat = new ArrayList();// Danh sách hãng sản xuất
        #endregion

        public frmHT_ListNhomNguoiDung()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void frmHT_ListNhomNguoiDung_Load(object sender, EventArgs e)
        {
            LoadAllNhomNguoiDung();
        }

        public void LoadAllNhomNguoiDung()
        {
            gNhomNguoiDung.DataSource = NhomNguoiDungDataProvider.LoadAll();
        }

        private void LoadAllChucNang()
        {
            arrChucNang = new ArrayList(ChucNangDataProvider.LoadAll());
            gChucNang.DataSource = arrChucNang;
            gvChucNang.Columns["ParentName"].GroupIndex = 0;
            gvChucNang.ExpandAllGroups();
            selectorCN.View = gvChucNang;
            selectorCN.CheckMarkColumn.VisibleIndex = 0;
        }
        private void LoadAllPhanQuyenHangSanXuat()
        {
            arrPhanQuyenHangSanXuat = new ArrayList(PhanQuyenHangSanXuatDataProvider.ListAll());
            gHangSanXuat.DataSource = arrPhanQuyenHangSanXuat;
            gvHangSanXuat.ExpandAllGroups();
            selectorSX.View = gvHangSanXuat;
            selectorSX.CheckMarkColumn.VisibleIndex = 0;
        }
        private void LoadAllPhanQuyenNganhHang()
        {
            arrPhanQuyenNganhHang = new ArrayList(PhanQuyenNganhHangDataProvider.ListAll());
            gNhomSanPham.DataSource = arrPhanQuyenNganhHang;
            gvNhomSanPham.Columns["TenLinhVuc"].GroupIndex = 0;
            gvNhomSanPham.ExpandAllGroups();
            selectorNH.View = gvNhomSanPham;
            selectorNH.CheckMarkColumn.VisibleIndex = 0;
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            gChucNang.DataSource = ChucNangDataProvider.Search(txtFilterHanhDong.Text);
            gvChucNang.Columns["ParentName"].GroupIndex = 0;
            gvChucNang.ExpandAllGroups();
            selectorCN.View = gvChucNang;
            selectorCN.CheckMarkColumn.VisibleIndex = 0;

            txtFilterHanhDong.Focus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAll.Checked == true)
            {
                selectorCN.SelectAll();
            }
            else
            {
                selectorCN.ClearSelection();
            }
        }

        private void gvNhomNguoiDung_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ShowNTK_ChucNang();
            ShowNTK_HangSanXuat();
            ShowNTK_NganhHang();
        }

        #region Method ShowNTK_ChucNang
        private void ShowNTK_ChucNang()
        {
            try
            {
                if (gvNhomNguoiDung.FocusedRowHandle < 0) return;
                if (arrChucNang.Count == 0)
                    LoadAllChucNang();

                NhomNguoiDungInfor nhomND = (NhomNguoiDungInfor)gvNhomNguoiDung.GetRow(gvNhomNguoiDung.FocusedRowHandle);
                NhomNguoiDungDataProvider.GetChucNang(nhomND);

                //thiet lap chuc nang
                selectorCN.ClearSelection();
                foreach (ChucNangInfor cn in nhomND.ChucNangNguoiDung)
                {
                    for (int i = 0; i < gvChucNang.DataRowCount; i++)
                    {
                        ChucNangInfor gcn = (ChucNangInfor)gvChucNang.GetRow(i);
                        if (gcn.IdChucNang == cn.IdChucNang)
                        {
                            selectorCN.SelectRow(i, true); // dánh dấu trạng thái
                            break;
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region Method ShowNTK_HangSanXuat
        private void ShowNTK_HangSanXuat()
        {
            try
            {
                if (gvNhomNguoiDung.FocusedRowHandle < 0) return;
                if (arrPhanQuyenHangSanXuat.Count == 0)
                    LoadAllPhanQuyenHangSanXuat();

                NhomNguoiDungInfor nhomND = (NhomNguoiDungInfor)gvNhomNguoiDung.GetRow(gvNhomNguoiDung.FocusedRowHandle);
                NhomNguoiDungDataProvider.GetPhanQuyenHangSanXuat(nhomND);

                txtSoTon.Text = Common.Double2Str(nhomND.XemTon);

                //thiet lap chuc nang
                selectorSX.ClearSelection();
                foreach (PhanQuyenHangSanXuatInfor hsx in nhomND.PhanQuyenHangSanXuat)
                {
                    for (int i = 0; i < gvHangSanXuat.DataRowCount; i++)
                    {
                        PhanQuyenHangSanXuatInfor ghsx = (PhanQuyenHangSanXuatInfor)gvHangSanXuat.GetRow(i);
                        if (ghsx.MaHang.Equals(hsx.MaHang))
                        {
                            selectorSX.SelectRow(i, true); // dánh dấu trạng thái
                            break;
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region Method ShowNTK_NganhHang
        private void ShowNTK_NganhHang()
        {
            try
            {
                if (gvNhomNguoiDung.FocusedRowHandle < 0) return;
                if (arrPhanQuyenNganhHang.Count == 0)
                    LoadAllPhanQuyenNganhHang();

                NhomNguoiDungInfor nhomND = (NhomNguoiDungInfor)gvNhomNguoiDung.GetRow(gvNhomNguoiDung.FocusedRowHandle);
                NhomNguoiDungDataProvider.GetPhanQuyenNganhHang(nhomND);

                //thiet lap nganh hang
                selectorNH.ClearSelection();
                foreach (PhanQuyenNganhHangInfor pq in nhomND.PhanQuyenNganhHang)
                {
                    for (int i = 0; i < gvNhomSanPham.DataRowCount; i++)
                    {
                        PhanQuyenNganhHangInfor gpq = (PhanQuyenNganhHangInfor)gvNhomSanPham.GetRow(i);
                        if (gpq.MaLoai.Equals(pq.MaLoai))
                        {
                            selectorNH.SelectRow(i, true); // dánh dấu trạng thái
                            break;
                        }
                    }
                }
                //so ton duoc xem
                txtSoTon.Text = Common.Double2Str(nhomND.XemTon);
            }
            catch { }
        }
        #endregion
        private void gvNhomNguoiDung_DoubleClick(object sender, EventArgs e)
        {
            Point pt = gNhomNguoiDung.PointToClient(MousePosition);
            GridHitInfo hitInfo = gvNhomNguoiDung.CalcHitInfo(pt);
            if (hitInfo.InRow)
                EditOrder(hitInfo.RowHandle);
        }

        #region Method ADD, EDIT Thong tin
        //Add
        private void EditOrder(NhomNguoiDungInfor theOder)
        {
            frmHT_AddNhomNguoiDung frm = new frmHT_AddNhomNguoiDung(theOder, this);
            frm.ShowDialog();
        }
        //Edit
        private void EditOrder(int rowHandle)
        {
            if (rowHandle < 0) return;
            NhomNguoiDungInfor nhomND = (NhomNguoiDungInfor)gvNhomNguoiDung.GetRow(rowHandle);
            EditOrder(nhomND);

        }
        #endregion

        private void btnSuaNND_Click(object sender, EventArgs e)
        {
            try
            {
                EditOrder(gvNhomNguoiDung.FocusedRowHandle);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSaveCN_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvNhomNguoiDung.FocusedRowHandle < 0) return;
                NhomNguoiDungInfor nhomND = (NhomNguoiDungInfor)gvNhomNguoiDung.GetRow(gvNhomNguoiDung.FocusedRowHandle);

                //cap nhat lai chuc nang moi
                nhomND.ChucNangNguoiDung = new ArrayList();
                nhomND.ChucNangNguoiDung.AddRange(selectorCN.selection);
                //cap nhat lai hang san xuat moi
                nhomND.PhanQuyenHangSanXuat = new ArrayList();
                nhomND.PhanQuyenHangSanXuat.AddRange(selectorSX.selection);
                //cap nhat lai nganh hang moi
                nhomND.PhanQuyenNganhHang = new ArrayList();
                nhomND.PhanQuyenNganhHang.AddRange(selectorNH.selection);
                //tham so khac
                nhomND.XemTon = Common.IntValue(txtSoTon.Text);
                NhomNguoiDungDataProvider.Update(nhomND);

                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi dữ liệu: " + ex.Message);
            }
        }

        private void btnAddNND_Click(object sender, EventArgs e)
        {
            new frmHT_AddNhomNguoiDung(this).ShowDialog();
        }

        private void btnXoaNND_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvNhomNguoiDung.FocusedRowHandle < 0) return;
                if (MessageBox.Show("Bạn có chắc chắn xóa nhóm tài khoản này không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int[] indx = gvNhomNguoiDung.GetSelectedRows();
                    for (int i = 0; i < indx.Length; i++)
                    {
                        NhomNguoiDungInfor nhomND = (NhomNguoiDungInfor)gvNhomNguoiDung.GetRow(indx[i]);
                        NhomNguoiDungDataProvider.Delete(nhomND);
                    }
                    LoadAllNhomNguoiDung();
                }
                else { }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void chkAllLSP_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllLSP.Checked == true)
            {
                selectorNH.SelectAll();
            }
            else
            {
                selectorNH.ClearSelection();
            }
        }

        private void chkAllHang_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllHang.Checked == true)
            {
                selectorSX.SelectAll();
            }
            else
            {
                selectorSX.ClearSelection();
            }
        }
    }
}