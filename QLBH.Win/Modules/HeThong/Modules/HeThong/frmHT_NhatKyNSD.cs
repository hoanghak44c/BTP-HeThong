using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.HeThong.Providers;
using QLBH.Common;
using QLBH.Core.Form;
using QLBanHang.Modules.BanHang;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmHT_NhatKyNSD : DevExpress.XtraEditors.XtraForm
    {
        private List<NhatKyNguoiDungInfor> liChungTuBanHang = new List<NhatKyNguoiDungInfor>();
        private List<NhatKyNguoiDungInfor> liTimKiem = new List<NhatKyNguoiDungInfor>();

        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;
        private string err = "";

        public frmHT_NhatKyNSD()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void frmHT_NhatKyNSD_Load(object sender, EventArgs e)
        {
            CommonFuns.Instance.LoadComboBoxPages(cboPage);
        }

        private void bteThuongVien_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteNhanVien_ButtonClick(sender, e, bteThuongVien, -1, -1);
        }

        private void bteThuongVien_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteNhanVien_KeyDown(sender, e, bteThuongVien, -1, -1);
        }

        private void bteThuongVien_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteThuongVien);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            SoLuongHienTai = 0;
            SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            liChungTuBanHang = new List<NhatKyNguoiDungInfor>();

            TimKiemChungTu();

        }
        private void LoadDuLieu()
        {
            DateTime tuNgay = Convert.ToDateTime(dteStart.EditValue);
            DateTime denNgay = Convert.ToDateTime(dteEnd.EditValue);
            int  idNhanVien = bteThuongVien.Tag != null ? ((DMNhanVienInfo)bteThuongVien.Tag).IdNhanVien : -1;
            string chucNang = txtChucNang.Text.Trim();
            string tenDangNhap = txtNguoiDung.Text.Trim();
            int soBatDau = SoLuongHienTai;
            int soKetThuc = SoLuongTimKiem != -1 ? SoLuongHienTai + SoLuongTimKiem : -1;

            liTimKiem = NhatKyNguoiDungDataProvider.Instance.TimKiemNhatKyNguoiDungPg(idNhanVien, tenDangNhap, chucNang,
                                                                                      tuNgay, denNgay, soBatDau,
                                                                                      soKetThuc);
            liChungTuBanHang.AddRange(liTimKiem);

            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = "Đã xong";
        }

        private void TimKiemChungTu()
        {
            try
            {
                frmProgress.Instance.Description = Common.MsgProgress(SoLuongTimKiem);
                frmProgress.Instance.MaxValue = SoLuongTimKiem;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(LoadDuLieu);
                gListChungTu.DataSource = new BindingList<NhatKyNguoiDungInfor>(liChungTuBanHang);

                //gvListChungTu.Columns["ParentName"].GroupIndex = 0;
                gvListChungTu.ExpandAllGroups();
                selector.View = gvListChungTu;
                selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                selector.CheckMarkColumn.VisibleIndex = 0;
                ((BindingList<NhatKyNguoiDungInfor>)gListChungTu.DataSource).ResetBindings();
                SoLuongHienTai = liChungTuBanHang.Count;
                selector.ClearSelection();

                this.grpKetQuaTimKiem.Text = "Kết quả tìm kiếm (" + liChungTuBanHang.Count + " giao dịch)";
                //if (gvListChungTu.RowCount == 0)
                //{
                //    MessageBox.Show("Không có chứng từ nào thỏa mãn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SoLuongTimKiem = Common.IntValue(cboPage.SelectedItem);
            if (SoLuongTimKiem == 0)
                SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            if (cboPage.SelectedItem.Equals("Tất cả"))
            {
                if (MessageBox.Show(Declare.msgLoadDataWrn, "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SoLuongTimKiem = -1;
                }
                else
                {
                    return;
                }
            }

            TimKiemChungTu();
        }

        private void cmdExport_Click(object sender, EventArgs e)
        {
            Common.Export2ExcelFromDevGrid<NhatKyNguoiDungInfor>(gvListChungTu, "NhatKyNguoiDung");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoaDL_Click(object sender, EventArgs e)
        {
            try
            {
                if (selector.selection.Count > 0)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa các dữ liệu này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        frmProgress.Instance.Description = "Đang xoa dữ liệu ....";
                        frmProgress.Instance.MaxValue = selector.selection.Count;
                        frmProgress.Instance.DoWork(XoaChungTu);

                        selector.View = gvListChungTu;
                        selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                        selector.CheckMarkColumn.VisibleIndex = 0;
                        ((BindingList<NhatKyNguoiDungInfor>)gListChungTu.DataSource).ResetBindings();

                        if (!String.IsNullOrEmpty(err))
                            MessageBox.Show(err);
                        else
                        {
                            MessageBox.Show("Đã xóa xong các nhật ký");
                            btnTim_Click(sender, e);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa nhật ký:\n" + ex.ToString());
            }
        }
        private void XoaChungTu()
        {
            err = "";
            foreach (NhatKyNguoiDungInfor ctu in selector.selection)
            {
                frmProgress.Instance.Description = String.Format("Đang xóa nhật ký {0} ....", ctu.IdNhatKy);
                try
                {
                    NhatKyNguoiDungDataProvider.Instance.XoaNhatKyNguoiDung(ctu.IdNhatKy);
                    frmProgress.Instance.Description = String.Format("Đã xóa xong nhật ký [{0}] ....", ctu.IdNhatKy);
                    //liChungTuBanHang.Remove(ctu);
                }
                catch (Exception e)
                {
                    err += String.Format("Lỗi xóa nhật ký [{0}]\n{1}\n", ctu.IdNhatKy, e.ToString());
                }
                frmProgress.Instance.Value += 1;
            }
            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = String.Format("Đã xóa xong {0} nhật ký", selector.selection.Count);
        }
    }
}