using System;
using System.Data;
using System.Windows.Forms;
using QLBH.Common;
//using QLBanHang.Class;
//using QLBanHang.Class.Objects;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmMoSo : Form
    {
        public frmMoSo()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void frmMoSo_Load(object sender, EventArgs e)
        {
            LoadTrungTam();
            LoadKho();
            LoadNgayKhoaSo();
            dtNgayKhoaSo.MinDate = Declare.NgayDuDau;
        }

        private void LoadTrungTam()
        {
            string str = "Select IdTrungTam, MaTrungTam + ' - ' + TenTrungTam TrungTam " +
                  " From tbl_DM_TrungTam " +
                  " Where IdTrungTam = " + Declare.IdTrungTam;

            DataTable dtTrungTam = DBTools.getData("tbl_DM_TrungTam", str).Tables["tbl_DM_TrungTam"];
            if (dtTrungTam != null)
            {
                this.cboTrungTam.DataSource = dtTrungTam;
                this.cboTrungTam.DisplayMember = "TrungTam";
                this.cboTrungTam.ValueMember = "IdTrungTam";
                this.cboTrungTam.SelectedIndex = 0;
            }
        }

        private void LoadKho()
        {
            string str = "Select IdKho, MaKho + ' - ' + TenKho Kho " +
                  " From tbl_DM_Kho " +
                  " Where IdKho=" + Declare.IdKho;

            DataTable dtKho = DBTools.getData("tbl_DM_Kho", str).Tables["tbl_DM_Kho"];
            if (dtKho != null)
            {
                this.cboKho.DataSource = dtKho;
                this.cboKho.DisplayMember = "Kho";
                this.cboKho.ValueMember = "IdKho";
            }
        }

        //private void cboTrungTam_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    LoadKho();
        //}

        //private void cboKho_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    LoadNgayKhoaSo();
        //}
        private void LoadNgayKhoaSo()
        {
            this.dtNgayKhoaSo.Value = Declare.NgayKhoaSo;
            //string str = "Select NgayKhoaSo From tbl_DM_Kho Where IdKho=" + cboKho.SelectedValue;
            //try
            //{
            //    DataTable dtKho = DBTools.getData("tbl_DM_Kho", str).Tables["tbl_DM_Kho"];
            //    if (dtKho != null)
            //    {
            //        this.dtNgayKhoaSo.Value = ((DateTime)dtKho.Rows[0]["NgayKhoaSo"]);//.ToString("dd/MM/yyyy");
            //    }
            //}
            //catch (Exception ex) {
            //    this.dtNgayKhoaSo.Value = DateTime.Now;
            //}
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
                //Utils ut = new Utils();
                //string sql = "Update tbl_DM_Kho Set NgayKhoaSo = N'" + Common.Date2LongString(this.dtNgayKhoaSo.Value) + "'" +
                //             " Where IdKho= " + cboKho.SelectedValue;
                //DBTools.ExecuteQuery(sql, CommandType.Text);
                //LoadNgayKhoaSoKho();
                Declare.NgayKhoaSo = this.dtNgayKhoaSo.Value;
                MessageBox.Show("Cập nhật mở sổ thành công. Ngày khóa sổ mới là " + this.dtNgayKhoaSo.Text, Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Common.LogAction("Cập nhật ngày mở sổ thành công", "Ngày mở sổ mới là " + this.dtNgayKhoaSo.Text, Declare.IdKho);
                this.Close();
            }
            catch (Exception ex)
            {
                Common.LogAction("Cập nhật ngày mở sổ thất bại", "Ngày mở sổ mới là " + this.dtNgayKhoaSo.Text, Declare.IdKho);
                MessageBox.Show("Lỗi khi cập nhật dữ liệu", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void LoadNgayKhoaSoKho()
        //{
        //    try
        //    {
        //        string str = "Select NgayKhoaSo From tbl_DM_Kho Where IdKho = " + Declare.IdKho;
        //        DataTable dt = DBTools.getData("tmp", str).Tables["tmp"];
        //        if (dt != null)
        //        {
        //            Declare.NgayKhoaSo = dt.Rows[0]["NgayKhoaSo"] != null ? (DateTime)dt.Rows[0]["NgayKhoaSo"] : System.DateTime.Now.AddDays(-1);
        //        }
        //    }
        //    catch { }
        //}
    }
}