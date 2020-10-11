using System;
using System.Data;
using System.Windows.Forms;
using QLBH.Common;
//using QLBanHang.Class;
//using QLBanHang.Class.Objects;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmNgayLamViec : Form
    {
        public frmNgayLamViec()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void frmMoSo_Load(object sender, EventArgs e)
        {
            LoadKho();
            LoadNgayKhoaSo();
            dtNgayKhoaSo.MinDate = Declare.NgayDuDau;
        }

        private void LoadKho()
        {
            string str = "Select IdKho, MaKho || ' - ' || TenKho Kho " +
                  " From tbl_DM_Kho " +
                  " Where IdKho=" + Declare.IdKho;

            DataTable dtKho = DBTools.getData("tbl_DM_Kho", str).Tables["tbl_DM_Kho"];
            if (dtKho != null)
            {
                this.cboKho.DataSource = dtKho;
                this.cboKho.DisplayMember = "Kho";
                this.cboKho.ValueMember = "IdKho";
            }

            lblNhanVien.Text = Declare.MaNhanVien + " - " + Declare.TenNhanVien;
        }

        private void LoadNgayKhoaSo()
        {
            this.dtNgayKhoaSo.Value = Declare.NgayLamViec;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (!Common.IsValidDate(dtNgayKhoaSo.Text.Trim()))
            //{
            //    MessageBox.Show(Declare.msgDateTimeValid, Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    this.dtNgayKhoaSo.Focus();
            //    return;
            //}

            Declare.NgayLamViec = this.dtNgayKhoaSo.Value;
            MessageBox.Show("Ngày làm việc mới là " + this.dtNgayKhoaSo.Text, Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Common.LogAction("Thiết lập ngày làm việc thành công", "Ngày làm việc mới là " + this.dtNgayKhoaSo.Text, Declare.IdKho);
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}