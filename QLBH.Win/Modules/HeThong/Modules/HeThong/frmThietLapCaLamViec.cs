using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.HeThong.Providers;
using QLBH.Common.Objects;
using QLBH.Common.Providers;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmThietLapCaLamViec : DevExpress.XtraEditors.XtraForm
    {
        List <DmLoaiDoiTuongInfor> liLoaiDT = new List<DmLoaiDoiTuongInfor>();
        public DMTrungTamInfor TTamSelected = null;
        public DMKhoInfo KhoSelected = null;
        public DmLoaiDoiTuongInfor LoaiDTSelected = null;
        public DMDoiTuongInfo KHangSelected = null;
        public DMNhanVienInfo TruongCaSelected = null;
        public DMNhanVienInfo ThuNganSelected = null;
        public DMLoaiThuChiInfor ThoiHanTTSelected = null;
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

        private int TypeReset = 0;//0-mac dinh: reset all trong 1 page, 1-reset trong 1 session (luu vao static), 2-resset all session (luu vao CSDL)
        private Form frmParent = null;
        private bool choseForm = false;

        public frmThietLapCaLamViec()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
        public frmThietLapCaLamViec(int typeReset)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.TypeReset = typeReset;
        }
        public frmThietLapCaLamViec(int typeReset, Form parent)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.TypeReset = typeReset;
            this.frmParent = parent;
        }

        public frmThietLapCaLamViec(int typeReset, Form parent, bool choseForm)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.TypeReset = typeReset;
            this.frmParent = parent;
            this.choseForm = choseForm;
        }

        private void frmKhoHienTai_Load(object sender, EventArgs e)
        {
            LoadTrungTam();
            LoadKho();
            LoadLoaiDT();
            LoadDoiTuong();
            LoadThuNgan();
            LoadTruongCa();
            LoadThoiHanThanhToan();
            if (choseForm)
            {
                lueFormMacDinh.Enabled = true;
                LoadListForm();
            }
            else
            {
                lueFormMacDinh.Enabled = false;
            }
            dtNgayLamViec.Value = Declare.NgayLamViec;
        }
        
        private void LoadListForm()
        {
            if (this.frmParent != null)
            {
                lueFormMacDinh.Properties.DataSource = nguoiDung.ChucNangNguoiDung;
                lueFormMacDinh.Properties.DisplayMember = "TenChucNang";
                lueFormMacDinh.Properties.ValueMember = "MaChucNang";

                lueFormMacDinh.EditValue = Declare.GiaoDienMacDinh;
            }
        }

        private void LoadTrungTam()
        {
            TTamSelected = DMTrungTamDataProvider.GetTrungTamByIdInfo(Declare.IdTrungTam);
            if (TTamSelected != null)
            {
                bteTrungTam.Text = TTamSelected.TenTrungTam;
                bteTrungTam.Tag = TTamSelected;
            }
        }
        private void LoadKho()
        {
            KhoSelected = DMKhoDataProvider.GetKhoByIdInfo(Declare.IdKho);
            if (KhoSelected != null)
            {
                bteKhoXuat.Tag = KhoSelected;
                bteKhoXuat.Text = KhoSelected.TenKho;
                bteKhoXuat.Enabled = !String.IsNullOrEmpty(KhoSelected.MaKho) && !KhoSelected.MaKho.StartsWith("OL");
            }
        }

        private void LoadLoaiDT()
        {
            liLoaiDT = DmLoaiDoiTuongDataProvider.GetListLoaiDoiTuongInfor();

            if (liLoaiDT.Count > 0)
            {
                cboCurrentLoaiDT.DataSource = liLoaiDT;
                cboCurrentLoaiDT.DisplayMember = "TenLoaiDT";
                cboCurrentLoaiDT.ValueMember = "IdLoaiDT";
                cboCurrentLoaiDT.SelectedValue = Declare.IdLoaiKhachHang;
                if (cboCurrentLoaiDT.SelectedIndex >= 0)
                    LoaiDTSelected = liLoaiDT[cboCurrentLoaiDT.SelectedIndex];
            }
            else
            {
                cboCurrentLoaiDT.DataSource = null;
            }
        }

        private void LoadDoiTuong()
        {
            KHangSelected = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(Declare.IdKHMacDinh);
            if (KHangSelected != null)
            {
                bteKhachHang.Text = KHangSelected.TenDoiTuong;
                bteKhachHang.Tag = KHangSelected;
            }
        }
        private void LoadThuNgan()
        {
            ThuNganSelected = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(Declare.IdThuNgan);
            if (ThuNganSelected != null)
            {
                bteThuNgan.Text = ThuNganSelected.HoTen;
                bteThuNgan.Tag = ThuNganSelected;
            }
        }
        private void LoadTruongCa()
        {
            TruongCaSelected = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(Declare.IdTruongCa);
            if (TruongCaSelected != null)
            {
                bteTruongCa.Text = TruongCaSelected.HoTen;
                bteTruongCa.Tag = TruongCaSelected;
            }
        }
        private void LoadThoiHanThanhToan()
        {
            ThoiHanTTSelected = DMLoaiThuChiDataProvider.GetListDmThuChiInfoFromOid(Declare.IdThoiHanThanhToan);
            if (ThoiHanTTSelected != null)
            {
                bteThoiHanThanhToan.Text = ThoiHanTTSelected.Ten;
                bteThoiHanThanhToan.Tag = ThoiHanTTSelected;
            }
        }
        private void frmKhoHienTai_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ShowPhieuXuat();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                if (bteTrungTam.Tag != null)
                    TTamSelected = (DMTrungTamInfor) bteTrungTam.Tag;
                if (bteKhoXuat.Tag != null)
                    KhoSelected = (DMKhoInfo) bteKhoXuat.Tag;
                if (cboCurrentLoaiDT.SelectedIndex != -1)
                    LoaiDTSelected = liLoaiDT[cboCurrentLoaiDT.SelectedIndex];
                if (bteKhachHang.Tag != null)
                    KHangSelected = (DMDoiTuongInfo) bteKhachHang.Tag;
                if (bteTruongCa.Tag != null)
                    TruongCaSelected = (DMNhanVienInfo) bteTruongCa.Tag;
                if (bteThuNgan.Tag != null)
                    ThuNganSelected = (DMNhanVienInfo) bteThuNgan.Tag;
                if (bteThoiHanThanhToan.Tag != null)
                    ThoiHanTTSelected = (DMLoaiThuChiInfor) bteThoiHanThanhToan.Tag;

                if (TypeReset == 1 || TypeReset == 2)
                {
                    if (TTamSelected != null)
                    {
                        Declare.IdTrungTam = TTamSelected.IdTrungTam;
                        Declare.TenTrungTam = TTamSelected.TenTrungTam;
                    }
                    if (KhoSelected != null)
                    {
                        Declare.IdKho = KhoSelected.IdKho;
                        Declare.TenKho = KhoSelected.TenKho;
                    }
                    if (LoaiDTSelected != null)
                    {
                        Declare.IdLoaiKhachHang = LoaiDTSelected.IdLoaiDT;                        
                    }
                    if (KHangSelected != null)
                    {
                        Declare.IdKHMacDinh = KHangSelected.IdDoiTuong;
                        Declare.TenKhachHang = KHangSelected.TenDoiTuong;
                    }
                    Declare.IdThuNgan = ThuNganSelected != null ? ThuNganSelected.IdNhanVien : 0;
                    Declare.IdTruongCa = TruongCaSelected != null ? TruongCaSelected.IdNhanVien : 0;
                    Declare.IdThoiHanThanhToan = ThoiHanTTSelected != null ? ThoiHanTTSelected.IdThuChi : 0;
                    Declare.NgayLamViec = dtNgayLamViec.Value;

                    DateTime now = CommonProvider.Instance.GetSysDate();
                    if (KhoSelected.NgayDuDau.CompareTo(now) > 0)
                        Declare.NgayDuDau = KhoSelected.NgayDuDau;
                    else
                        Declare.NgayDuDau = now;
                }
                if (TypeReset == 2)
                {
                    string formMacDinh = "";
                    if (choseForm && lueFormMacDinh.EditValue != null)
                        formMacDinh = lueFormMacDinh.EditValue.ToString();

                    NguoiDungDataProvider.SetKhoMacDinh(Declare.IdTrungTam, Declare.IdKho, Declare.IdLoaiKhachHang,
                                                        Declare.IdKHMacDinh, Declare.IdTruongCa,
                                                        Declare.IdThuNgan, Declare.IdThoiHanThanhToan,
                                                        nguoiDung.IdNguoiDung, formMacDinh);
                }
                if (this.frmParent != null)
                {
                    foreach (Form frm in frmParent.MdiChildren)
                    {
                        frm.Close();
                    }
                }
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool ValidData()
        {
            if (bteTrungTam.Tag == null && TTamSelected == null)
            {
                MessageBox.Show("Phải chọn trung tâm!");
                bteTrungTam.Focus();
                return false;
            }
            if (bteKhoXuat.Tag == null && KhoSelected == null)
            {
                MessageBox.Show("Phải chọn kho!");
                bteKhoXuat.Focus();
                return false;
            }
            if (cboCurrentLoaiDT.SelectedIndex < 0 && LoaiDTSelected == null)
            {
                MessageBox.Show("Phải chọn loại đối tượng!");
                cboCurrentLoaiDT.Focus();
                return false;
            }
            if (bteKhachHang.Tag == null && KHangSelected == null)
            {
                MessageBox.Show("Phải chọn đối tượng!");
                bteKhachHang.Focus();
                return false;
            }
            //if (TypeReset!=2)
            //{
            //    if (bteTruongCa.Tag == null)
            //    {
            //        MessageBox.Show("Phải chọn trưởng ca!");
            //        bteTruongCa.Focus();
            //        return false;
            //    }
            //    if (bteThuNgan.Tag == null)
            //    {
            //        MessageBox.Show("Phải chọn thu ngân!");
            //        bteThuNgan.Focus();
            //        return false;
            //    }
            //    if (bteThoiHanThanhToan.Tag == null)
            //    {
            //        MessageBox.Show("Phải chọn thời hạn thanh toán!");
            //        bteThoiHanThanhToan.Focus();
            //        return false;
            //    }                
            //}

            return true;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cboCurrentLoaiDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            bteKhachHang.ResetText();
            bteKhachHang.Tag = null;
        }
        private void ResetTrungTam()
        {
            bteKhoXuat.ResetText();
            bteKhoXuat.Tag = null;
            bteKhoXuat.Properties.ReadOnly = false;
            bteKhoXuat.Enabled = true;
            KhoSelected = null;
        }
        private void bteTrungTam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (UtilFunctions.bteTrungTam_ButtonClick(sender, e, bteTrungTam, nguoiDung.IdNhanVien))
            {
                ResetTrungTam();
                
                var lstKho =
                    DMKhoDataProvider.Instance.GetListAllKhoByTrungTam(((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam);

                if (lstKho.Count == 1)
                {
                    bteKhoXuat.Text = lstKho[0].TenKho;
                    bteKhoXuat.Text = lstKho[0].TenKho;
                    bteKhoXuat.Tag = new DMKhoInfo
                    {
                        IdKho = lstKho[0].IdKho,
                        IdTrungTam = lstKho[0].IdTrungTam,
                        MaKho = lstKho[0].MaKho,
                        TenKho = lstKho[0].TenKho
                    };

                    bteKhoXuat.Properties.ReadOnly = true;
                    bteKhoXuat.Enabled = false;
                    //bteKhachHang.ResetText();
                    //bteKhachHang.Tag = null;
                    //KHangSelected = null;
                    //cboCurrentLoaiDT.SelectedIndex = -1;
                    //LoaiDTSelected = null;
                }
            }
        }

        private void bteTrungTam_KeyDown(object sender, KeyEventArgs e)
        {
            if (UtilFunctions.bteTrungTam_KeyDown(sender, e, bteTrungTam, nguoiDung.IdNhanVien))
            {
                ResetTrungTam();

                var lstKho =
                    DMKhoDataProvider.Instance.GetListAllKhoByTrungTam(((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam);

                if (lstKho.Count == 1)
                {
                    bteKhoXuat.Text = lstKho[0].TenKho;
                    bteKhoXuat.Text = lstKho[0].TenKho;
                    bteKhoXuat.Tag = new DMKhoInfo
                    {
                        IdKho = lstKho[0].IdKho,
                        IdTrungTam = lstKho[0].IdTrungTam,
                        MaKho = lstKho[0].MaKho,
                        TenKho = lstKho[0].TenKho
                    };
                    bteKhoXuat.Properties.ReadOnly = true;
                    bteKhoXuat.Enabled = false;
                    //bteKhachHang.ResetText();
                    //bteKhachHang.Tag = null;
                    //KHangSelected = null;
                    //cboCurrentLoaiDT.SelectedIndex = -1;
                    //LoaiDTSelected = null;
                }
            } 
        }

        private void bteTrungTam_TextChanged(object sender, EventArgs e)
        {
            if (UtilFunctions.bteItem_TextChanged(sender, e, bteTrungTam))
                ResetTrungTam();
        }

        private void bteKhoXuat_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteKhoXuat);

            KhoSelected = bteKhoXuat.Tag as DMKhoInfo;
        }

        private void bteKhoXuat_KeyDown(object sender, KeyEventArgs e)
        {
            int idTrungTam = bteTrungTam.Tag != null ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam : -1;
            UtilFunctions.bteKhoXuat_KeyDown(sender, e, bteKhoXuat, idTrungTam, nguoiDung.IdNhanVien);
        }

        private void bteKhoXuat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int idTrungTam = bteTrungTam.Tag != null ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam : -1;
            UtilFunctions.bteKhoXuat_ButtonClick(sender, e, bteKhoXuat, idTrungTam, nguoiDung.IdNhanVien);
        }

        private void bteKhachHang_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteKhachHang_ButtonClick(sender, e, bteKhachHang, Common.IntValue(cboCurrentLoaiDT.SelectedValue));
        }

        private void bteKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteKhachHang_KeyDown(sender, e, bteKhachHang, Common.IntValue(cboCurrentLoaiDT.SelectedValue));
        }

        private void bteKhachHang_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteKhachHang);
        }

        private void bteTruongCa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int idKho = bteKhoXuat.Tag != null ? ((DMKhoInfo) bteKhoXuat.Tag).IdKho : -1;
            UtilFunctions.bteNhanVien_ButtonClick(sender, e, bteTruongCa, idKho);
        }

        private void bteTruongCa_KeyDown(object sender, KeyEventArgs e)
        {
            int idKho = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : -1;
            UtilFunctions.bteNhanVien_KeyDown(sender, e, bteTruongCa, idKho);
        }

        private void bteTruongCa_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteTruongCa);
        }

        private void bteThuNgan_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int idKho = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : -1;
            UtilFunctions.bteNhanVien_ButtonClick(sender, e, bteThuNgan, idKho);
        }

        private void bteThuNgan_KeyDown(object sender, KeyEventArgs e)
        {
            int idKho = bteKhoXuat.Tag != null ? ((DMKhoInfo)bteKhoXuat.Tag).IdKho : -1;
            UtilFunctions.bteNhanVien_KeyDown(sender, e, bteThuNgan, idKho);
        }

        private void bteThuNgan_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteThuNgan);
        }

        private void bteThoiHanThanhToan_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteThoiHanThanhToan_ButtonClick(sender, e, bteThoiHanThanhToan);
        }

        private void bteThoiHanThanhToan_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteThoiHanThanhToan_KeyDown(sender, e, bteThoiHanThanhToan);
        }

        private void bteThoiHanThanhToan_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteThoiHanThanhToan);
        }
    }
}