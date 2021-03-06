using System;
using System.Data;
using System.Windows.Forms;
using QLBH.Common;
using QLBH.Common.Objects;
//using QLBanHang.Class;
//using QLBanHang.Class.Objects;

//

namespace QLBanHang.Modules.HeThong
{
    public partial class frmHT_ChamCong : Form
    {
        Utils ut = new Utils();
        ChamCong g1ChamCong = new ChamCong();
        int g1IdChamCong,g1TT;
        bool g1Sua;
        public frmHT_ChamCong()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void frmHT_ChamCong_Load(object sender, EventArgs e)
        {
            string sql;
            sql = @"SELECT DISTINCT 
                      dbo.tbl_DM_NhanVien.IdNhanVien, dbo.tbl_DM_NhanVien.MaNhanVien, dbo.tbl_DM_NhanVien.HoTen, dbo.tbl_DM_NhanVien.NgaySinh, 
                      dbo.tbl_DM_NhanVien.GioiTinh, dbo.tbl_DM_NhanVien.IdPhongBan, dbo.tbl_DM_NhanVien.IdChucVu, dbo.tbl_DM_NhanVien.DiaChi, 
                      dbo.tbl_DM_NhanVien.DienThoai, dbo.tbl_DM_NhanVien.SuDung, dbo.tbl_DM_NhanVien.Email, dbo.tbl_DM_NhanVien.GhiChu, 
                      dbo.tbl_DM_ChucNang.MaChucNang
            FROM         dbo.tbl_Kho_NhanVien INNER JOIN
                      dbo.tbl_DM_NhanVien ON dbo.tbl_Kho_NhanVien.IdNhanVien = dbo.tbl_DM_NhanVien.IdNhanVien INNER JOIN
                      dbo.tbl_DM_NguoiDung ON dbo.tbl_DM_NhanVien.IdNhanVien = dbo.tbl_DM_NguoiDung.IdNhanVien INNER JOIN
                      dbo.tbl_DM_ChucNang INNER JOIN
                      dbo.tbl_NhomND_ChucNang ON dbo.tbl_DM_ChucNang.IdChucNang = dbo.tbl_NhomND_ChucNang.IdChucNang ON 
                      dbo.tbl_DM_NguoiDung.IdNhomNguoiDung = dbo.tbl_NhomND_ChucNang.IdNhomNguoiDung
            WHERE     (dbo.tbl_DM_ChucNang.MaChucNang = N'10')";
                //WHERE     dbo.tbl_Kho_NhanVien.IdKho = " + Declare.IdKho.ToString();
            DataTable dt = ut.getDataTable(sql);
            foreach (DataRow r in dt.Rows)
            {
                chkLstNguoiCham.Items.Add(r["MaNhanVien"].ToString()+ "-" + r["HoTen"].ToString());
            }
            ut.LoadComboBox(cboKho, "SELECT IdKho, TenKho FROM dbo.tbl_DM_Kho");
            //Load bang cham cong cuoi cung
            Common.LogAction("Mở form", "Mở form " + this.Name, Declare.IdKho);
            g1TT = 0;
            LoadChamCongByTT(0);
            SetEnableTruoc_Sau();
            g1Sua = true;
            HienCapNhat(false);
        }
        private void LoadChamCong(int IdChamCong)
        {
            if (g1ChamCong.getChamCong(IdChamCong,0))
            {
                setDsIdNguoiCham(g1ChamCong.IdNguoiCham);
                ut.SetValueForComboBox(cboKho, g1ChamCong.IdKho.ToString());
                dtNgayCham.Value = g1ChamCong.NgayLamViec;
                gv.DataSource = g1ChamCong.LstChamCong;
                SetEnableTruoc_Sau();
                g1IdChamCong = IdChamCong;
            }
        }

        
        private void LoadChamCongByTT(int TT)
        {
            DataTable dt = ut.getDataTable("SELECT  * FROM tbl_ChamCong ORDER BY IdChamCong DESC");
            int Id = 0;
            if (dt.Rows.Count > g1TT)
                Id = ut.getInt(dt.Rows[g1TT]["IdChamCong"]);
            LoadChamCong(Id);
            SetEnableTruoc_Sau();
        }
        private void SetEnableTruoc_Sau()
        {
            btnSau.Enabled = (g1TT > 0);
            DataTable dt = ut.getDataTable("SELECT  * FROM tbl_ChamCong ORDER BY IdChamCong DESC");
            btnTruoc.Enabled = (g1TT < dt.Rows.Count - 1);
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            int tl = -1;
            if (btnCapNhat.Enabled)
            {
                tl = (int)MessageBox.Show("Bạn có lưu thay đổi này không?", "Thông báo", MessageBoxButtons.YesNoCancel);
                if (tl == (int)DialogResult.Yes)
                    CapNhatDuLieu();
            }
            if (tl == (int)DialogResult.Cancel) return;
            if (g1TT <= 0) return;
            g1TT--;
            LoadChamCongByTT(g1TT);
            g1Sua = true;
            HienCapNhat(false);


        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            int tl = -1;
            if (btnCapNhat.Enabled)
            {
                tl = (int)MessageBox.Show("Bạn có lưu thay đổi này không?", "Thông báo", MessageBoxButtons.YesNoCancel);
                if (tl == (int)DialogResult.Yes)
                    CapNhatDuLieu();
            }
            if (tl == (int)DialogResult.Cancel) return;
            g1TT++;
            LoadChamCongByTT(g1TT);
            g1Sua = true;
            HienCapNhat(false);
        }
        private void KhoiTao()
        {
            if (g1Sua)
            {
                //Load thong tin
                //LoadChamCong(g1IdBangGia);
            }
            else
            {
                LoadChamCong(0);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            g1TT = 0;
            g1Sua = false;
            KhoiTao();
            HienCapNhat(true);
        }
        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            g1TT = 0;
            g1Sua = false;
            HienCapNhat(true);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            g1Sua = true;
            KhoiTao();
            HienCapNhat(true);
        }
        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (g1IdChamCong > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa chấm công này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    g1ChamCong.Delete(g1IdChamCong);
                    MessageBox.Show("Chấm công đã được xóa");
                    Common.LogAction("Xóa Chấm công", "IdChamCong=" + g1IdChamCong.ToString(), Declare.IdKho);
                    LoadChamCongByTT(g1TT);
                }

            }
        }
        private int CapNhatDuLieu()
        {
            //Kiem tra thong tin day du
            if (chkLstNguoiCham.CheckedItems.Count < 1)
            {
                MessageBox.Show("Thông tin về người chấm công chưa đủ. Xin mời nhập!");
                return 0;
            }
            if (ut.getInt(cboKho.SelectedValue)<1)
                {
                    MessageBox.Show("Chưa chọn kho. Xin mời chọn!");
                    return 0;
                }
            //Kiem tra co nhan vien de cham
            if (gv.Rows.Count < 1)
            {
                MessageBox.Show("Kho này không có nhân viên!");
                return 0;
            }
            //Cap nhat
            if (g1Sua)
            {
                g1ChamCong.IdChamCong = g1IdChamCong;
                g1ChamCong.IdKho = ut.getInt(cboKho.SelectedValue);
                g1ChamCong.IdNguoiCham = getDSIdNguoiCham();
                g1ChamCong.NgayLamViec = dtNgayCham.Value;
                g1ChamCong.Update();
            }
            else
            {
                //Kiem tra ngayLamViec da cham
                int id = ut.fGetID_sql(string.Format("SELECT IdChamCong FROM tbl_ChamCong WHERE NgayLamViec='{0}' and IdKho={1}", ut.DateToString(dtNgayCham.Value), ut.getInt(cboKho.SelectedValue)));
                if (id > 0)
                {
                    MessageBox.Show("Ngày này đã chấm công. Bạn hãy chọn chức năng sửa!");
                    return 0;
                }
                g1ChamCong.IdKho = ut.getInt(cboKho.SelectedValue);
                g1ChamCong.IdNguoiCham = getDSIdNguoiCham();
                g1ChamCong.NgayLamViec = dtNgayCham.Value;
                g1ChamCong.AddNew();
            }

            return 1;

        }
        private void setDsIdNguoiCham(string pDSIdNguoiCham)
        {
            if (pDSIdNguoiCham == "")
                pDSIdNguoiCham = "0";
            string sql = string.Format("SELECT MaNhanVien + '-' + HoTen AS GiaTri FROM tbl_DM_NhanVien WHERE IdNhanVien IN ({0})", pDSIdNguoiCham);
            DataTable dt = ut.getDataTable(sql);
            for (int i = 0; i < chkLstNguoiCham.Items.Count; i++)
                chkLstNguoiCham.SetItemChecked(i, false);
            foreach (DataRow r in dt.Rows)
            {
                for (int i = 0; i < chkLstNguoiCham.Items.Count; i++)
                    if (chkLstNguoiCham.Items[i].ToString() == r["GiaTri"].ToString())
                    {
                        chkLstNguoiCham.SetItemChecked(i, true);
                        break;
                    }
            }
        }
        private string getDSIdNguoiCham()
        {
            string DsIdNguoiCham = "";
            int Id;
            foreach (object o in chkLstNguoiCham.CheckedItems)
            {
                Id=ut.fGetID_sql(string.Format("SELECT IdNhanVien FROM tbl_DM_NhanVien WHERE MaNhanVien + '-' + HoTen=N'{0}'",o.ToString()));
                if (Id>0)
                    DsIdNguoiCham+=Id.ToString() + ",";
            }
            return DsIdNguoiCham.Trim(',');
        }
        private void cmdCapNhat_Click(object sender, EventArgs e)
        {
            chkLstNguoiCham.Focus();
            if (CapNhatDuLieu() == 1)
            {
                if (g1Sua)
                {
                    Common.LogAction("Sửa chấm công", "IdChamCong " + g1IdChamCong.ToString() + " thành công", Declare.IdKho);
                    MessageBox.Show("Dữ liệu đã được sửa");
                }
                else
                {
                    g1IdChamCong = g1ChamCong.IdChamCong;
                    LoadChamCong(g1IdChamCong);
                    g1TT = 0;
                    Common.LogAction("Tạo mới chấm công", "IdChamCong " + g1IdChamCong.ToString() + " thành công", Declare.IdKho);
                    MessageBox.Show("Dữ liệu đã được thêm");
                }
                HienCapNhat(false);
            }
            else
            {
                if (g1Sua)
                    Common.LogAction("Sửa chấm công", "IdChamCong " + g1IdChamCong.ToString() + " lỗi", Declare.IdKho);
                else
                    Common.LogAction("Tạo mới chấm công", "Lỗi", Declare.IdKho);
            }
        }
        private void gv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = gv.Rows[e.RowIndex];
            if (!ut.isStringNotEmpty(r.Cells[e.ColumnIndex].Value)) return;
            //Gan lai dong trong g1ChamCong.LstChamCong
            int idNhanVien = ut.getInt(r.Cells["colIdNhanVien"].Value);
            ChiTietChamCong ct = g1ChamCong.FindChamCongChiTietByNhanVien(idNhanVien);
            ct.DiLam = ut.getBool(r.Cells["colDiLam"].Value);
            ct.ThoiGian = ut.getDate(r.Cells["colThoiGian"].Value);
            ct.GhiChu = ut.getString(r.Cells["colGhiChu"].Value);
            ct.ThayDoi = 2;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboKho_Click(object sender, EventArgs e)
        {
            
        }
        private void HienCapNhat(bool pHien)
        {
            btnCapNhat.Enabled = pHien;
            btnThem.Enabled = !pHien;
            btnSua.Enabled = !pHien;
            btnSaoChep.Enabled = !pHien;
            btnXoa.Enabled = !pHien;
            cboKho.Enabled = pHien && !g1Sua;
            colDiLam.ReadOnly = !pHien;
            colThoiGian.ReadOnly = !pHien;
        }

        private void cboKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ut.getInt(cboKho.SelectedValue) > 0 && g1Sua == false)
            {
                g1ChamCong.getChamCong(0, ut.getInt(cboKho.SelectedValue));
                gv.DataSource = g1ChamCong.LstChamCong;
            }
        }

        private void gv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel=true;
        }

        private void frmHT_ChamCong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3 && btnTruoc.Enabled)
                this.btnTruoc_Click(sender, e);
            else if (e.KeyCode == Keys.F4 && btnSau.Enabled)
                this.btnSau_Click(sender, e);
            else if (e.KeyCode == Keys.F5 && btnThem.Enabled)
                this.btnThem_Click(sender, e);
            else if (e.KeyCode == Keys.F6 && btnSua.Enabled)
                this.btnSua_Click(sender, e);
            else if (e.KeyCode == Keys.F7 && btnCapNhat.Enabled)
            {
                this.cmdCapNhat_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F8 && btnXoa.Enabled)
                this.cmdXoa_Click(sender, e);
            else if (e.KeyCode == Keys.F12 && btnDong.Enabled)
                this.btnDong_Click(sender, e);
        }
        
    }
}