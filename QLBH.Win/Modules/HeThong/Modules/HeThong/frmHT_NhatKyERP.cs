using System;
using System.Data;
using System.Windows.Forms;
using QLBH.Common;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmHT_NhatKyERP : Form
    {
        public frmHT_NhatKyERP()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void frmHT_NhatKyERP_Load(object sender, EventArgs e)
        {
            string sql = "Select MaTrungTam, TenTrungTam from tbl_DM_TrungTam where sudung=1";            
            cboFilterTrungTam.DisplayMember = "TenTrungTam";
            cboFilterTrungTam.ValueMember = "MaTrungTam";
            cboFilterTrungTam.DataSource = DBTools.getData("tbl_DM_TrungTam", sql).Tables["tbl_DM_TrungTam"];
            cboFilterTrungTam.Refresh();
        }

        private string getDateValue(DateTime d)
        {
            string result = d.Year.ToString();
            result += d.Month >= 10 ? d.Month.ToString() : "0" + d.Month.ToString();
            result += d.Day >= 10 ? d.Day.ToString() : "0" + d.Day.ToString();
            return result;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string dk = "1=1";
            if (mtbFilterThoiGian.Text.Trim() != "")
            {
                DateTime date = mtbFilterThoiGian.Value;
                dk += String.Format(" and CONVERT(varchar(8), ThoiGian,112) >= {0}", getDateValue(date));
            }

            if (!String.IsNullOrEmpty(txtFilterHanhDong.Text)) {
                dk += String.Format(" and HanhDong like N'{0}'", txtFilterHanhDong.Text);
            }

            if (cboFilterTrungTam.SelectedValue != null) {
                dk += String.Format(" and MaTrungTam like '{0}'", cboFilterTrungTam.SelectedValue);
            }

            if (cboFilterKho.SelectedValue != null) {
                dk += String.Format(" and MaKho='{0}'", cboFilterKho.SelectedValue);
            }

            string sql = "select * from vNhatKyDongBoERP where " + dk;
            dgvList.DataSource = DBTools.getData("Temp", sql).Tables["Temp"];
            dgvList.Refresh();
        }

        private void cboFilterTrungTam_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "Select MaKho, TenKho from tbl_DM_Kho where Sudung=1 and IdTrungTam";
            sql += String.Format(" in (select IdTrungTam from tbl_DM_TrungTam where MaTrungTam='{0}')", cboFilterTrungTam.SelectedValue);

            cboFilterKho.DisplayMember = "TenKho";
            cboFilterKho.ValueMember = "MaKho";
            cboFilterKho.DataSource = DBTools.getData("tbl_DM_Kho", sql).Tables["tbl_DM_Kho"];
            cboFilterKho.Refresh();
            cboFilterKho.SelectedIndex = -1;
        }

        private void dgvList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            mtbBatDau.Text = Common.Date2LongString((DateTime)dgvList.Rows[e.RowIndex].Cells["ThoiGian"].Value);
            if (dgvList.Rows[e.RowIndex].Cells["TenTrungTam"].Value!= null)
            {
                txtTrungTam.Text = dgvList.Rows[e.RowIndex].Cells["TenTrungTam"].Value.ToString();
            }
            if (dgvList.Rows[e.RowIndex].Cells["TenKho"].Value!= null)
            {
                txtKho.Text = dgvList.Rows[e.RowIndex].Cells["TenKho"].Value.ToString();
            }
            if (dgvList.Rows[e.RowIndex].Cells["TenDangNhap"].Value != null)
            {
                txtNguoiDung.Text = dgvList.Rows[e.RowIndex].Cells["TenDangNhap"].Value.ToString();
            }
            if (dgvList.Rows[e.RowIndex].Cells["TenMay"].Value!= null)
            {
                txtTenMay.Text = dgvList.Rows[e.RowIndex].Cells["TenMay"].Value.ToString();
            }
            if (dgvList.Rows[e.RowIndex].Cells["HanhDong"].Value!= null)
            {
                txtHanhDong.Text = dgvList.Rows[e.RowIndex].Cells["HanhDong"].Value.ToString();
            }
            if (dgvList.Rows[e.RowIndex].Cells["GhiChu"].Value != null)
            {
                txtGhiChu.Text = dgvList.Rows[e.RowIndex].Cells["GhiChu"].Value.ToString();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Utils ut = new Utils();
            foreach (DataGridViewRow r in dgvList.Rows)
            {
                if (ut.getBool(r.Cells["Chon"].Value) == true)
                {
                    string sql = String.Format("Delete from tbl_Nhatky_Dongbo_ERP where IdNhatKy={0}", r.Cells["IdNhatKy"].Value);
                    DBTools.ExecuteQuery(sql, CommandType.Text);
                }
            }
            btnFilter_Click(this, null);
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            bool bChon = btnChon.Text == "Chọn tất";
            for (int i = 0; i < dgvList.Rows.Count; i++)
                dgvList.Rows[i].Cells["Chon"].Value = bChon;
            btnChon.Text = (bChon) ? "Bỏ tất" : "Chọn tất";
        }
        
    }
}