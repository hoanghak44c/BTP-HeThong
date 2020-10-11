using System;
using System.Data;
using System.Windows.Forms;
using QLBH.Common;
//using QLBanHang.Class;
//using QLBanHang.Class.Objects;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmNgayDuDau : Form
    {
        public frmNgayDuDau()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void frmMoSo_Load(object sender, EventArgs e)
        {
            LoadTrungTam();
            LoadKho();
            LoadNgayDuDau();
        }
        private void LoadTrungTam()
        {
            string str = @"SELECT  IdTrungTam, MaTrungTam || ' - ' || TenTrungTam TrungTam FROM tbl_DM_TrungTam where SuDung=1 and (IdTrungTam in
                    (Select IdTrungTam From tbl_DM_Kho Where IdKho in
                    (Select IdKho From tbl_Kho_NhanVien Where IdNhanVien in
                    (Select IdNhanVien From tbl_DM_NguoiDung Where IdNguoiDung=" + Declare.UserId + "))) or ('admin'='" + Declare.UserName.ToLower() + "'))";

            DataTable dtTrungTam = DBTools.getData("tbl_DM_TrungTam", str).Tables["tbl_DM_TrungTam"];
            if (dtTrungTam != null && dtTrungTam.Rows.Count > 0)
            {
                this.cboTrungTam.DataSource = dtTrungTam;
                this.cboTrungTam.DisplayMember = "TrungTam";
                this.cboTrungTam.ValueMember = "IdTrungTam";
                this.cboTrungTam.SelectedIndex = 0;
            }
        }
        private void LoadKho()
        {
            string str = "Select IdKho, MaKho || ' - ' || TenKho Kho " +
                  " From tbl_DM_Kho " +
                  " Where SuDung=1 and IdTrungTam=" + cboTrungTam.SelectedValue + " order by MaKho ASC";

            DataTable dtKho = DBTools.getData("tbl_DM_Kho", str).Tables["tbl_DM_Kho"];
            if (dtKho != null)
            {
                this.cboKho.DataSource = dtKho;
                this.cboKho.DisplayMember = "Kho";
                this.cboKho.ValueMember = "IdKho";
            }
        }
        private void cboTrungTam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadKho();
        }

        private void cboKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNgayDuDau();
        }
        private void LoadNgayDuDau()
        {
            string str = "Select NgayDuDau From tbl_DM_Kho Where IdKho=" + cboKho.SelectedValue;
            try
            {
                DataTable dtKho = DBTools.getData("tbl_DM_Kho", str).Tables["tbl_DM_Kho"];
                if (dtKho != null)
                {
                    this.dtNgayKhoaSo.Text = ((DateTime)dtKho.Rows[0]["NgayDuDau"]).ToString("dd/MM/yyyy");
                }
            }
            catch (Exception ex) {
                this.dtNgayKhoaSo.Value = DateTime.Now;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (!Common.IsValidDate(dtNgayKhoaSo.Text.Trim()))
            //{
            //    MessageBox.Show(Declare.msgDateTimeValid, Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    this.dtNgayKhoaSo.Focus();
            //    return;
            //}

            try
            {
                Utils ut = new Utils();
                string sql = "Update tbl_DM_Kho Set NgayDuDau = to_date(N'" + ut.DateToString(this.dtNgayKhoaSo.Value) + "', 'MM/dd/yyyy')" +
                             " Where IdKho= " + cboKho.SelectedValue;
                DBTools.ExecuteQuery(sql, CommandType.Text);
                MessageBox.Show("Cập nhật ngày dư đầu thành công", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Common.LogAction("Thiết lập ngày dư đầu kỳ", "Ngày dư đầu mới là " + this.dtNgayKhoaSo.Text, Declare.IdKho);
            }
            catch (Exception ex)
            {
                Common.LogAction("Lỗi cập nhật ngày dư đầu kỳ", "Ngày dư đầu mới là " + this.dtNgayKhoaSo.Text, Declare.IdKho);
                MessageBox.Show("Lỗi khi cập nhật dữ liệu", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}