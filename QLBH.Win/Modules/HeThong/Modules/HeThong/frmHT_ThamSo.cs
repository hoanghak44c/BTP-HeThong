using System;
using System.Data;
using System.Windows.Forms;
using QLBH.Common;
//using QLBanHang.Class;


namespace QLBanHang.Modules.HeThong
{
    public partial class frmHT_ThamSo : Form
    {

        public frmHT_ThamSo()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void frmThongTin_Load(object sender, EventArgs e)
        {
            LoadCommboTrungTam();
            LoadCommboTienTe();
            chkInPhieuXuat.Checked = Declare.InBill;
            chkInHoaDon.Checked = Declare.InHoaDon;
        }


        private void LoadCommboTrungTam()
        {
            DataTable dtTrungTam = DBTools.getData("tbl_DM_TrungTam", " Select MaTrungTam, MaTrungTam+' - '+TenTrungTam TrungTam From tbl_DM_TrungTam Where SuDung = 1 ").Tables["tbl_DM_TrungTam"];
            if (dtTrungTam != null)
            {
                this.cboTrungTam.DataSource = dtTrungTam;
                this.cboTrungTam.DisplayMember = "TrungTam";
                this.cboTrungTam.ValueMember = "MaTrungTam";
                this.cboTrungTam.SelectedIndex = -1;
            }
            string maTrungTam = Common.GetValue("ORG_CODE", "-1");
            if (!Declare.ORG_CODE.Equals("-1"))
                this.cboTrungTam.SelectedValue = maTrungTam;
        }

        private void LoadCommboTienTe()
        {
            DataTable dtTienTe = DBTools.getData("tbl_DM_TienTe", " Select KyHieu, TenTienTe From tbl_DM_TienTe Where SuDung = 1 ").Tables["tbl_DM_TienTe"];
            if (dtTienTe != null)
            {
                this.cboLoaiTien.DataSource = dtTienTe;
                this.cboLoaiTien.DisplayMember = "TenTienTe";
                this.cboLoaiTien.ValueMember = "KyHieu";
                this.cboLoaiTien.SelectedIndex = -1;
            }
            string tienTe = Common.GetValue("MONEY_TYPE", "-1");
            if (!Declare.MONEY_TYPE.Equals("-1"))
                this.cboLoaiTien.SelectedValue = tienTe;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //update information
                Declare.ORG_CODE = cboTrungTam.SelectedValue.ToString();
                Declare.MONEY_TYPE = cboLoaiTien.SelectedValue.ToString();
                Declare.InHoaDon = chkInHoaDon.Checked;
                Declare.InBill = chkInPhieuXuat.Checked;
                //update config file
                Common.SetValue("ORG_CODE", cboTrungTam.SelectedValue.ToString());
                Common.SetValue("MONEY_TYPE", cboLoaiTien.SelectedValue.ToString());
                Common.SetValue("IN_BILL", (chkInPhieuXuat.Checked ? "1" : "0"));
                Common.SetValue("IN_HOADON", (chkInHoaDon.Checked ? "1" : "0"));
                MessageBox.Show("Cập nhật tham số thành công!");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Error: " + ex.ToString());
                MessageBox.Show("Lỗi cập nhật tham số!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}