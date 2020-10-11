using System;
using System.Data;
using System.Windows.Forms;
using QLBH.Common;
using QLBH.Common.Objects;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmHT_TuychonNguoiDung : Form
    {
        string[] arrDisplay = { "", "Xuất bán hàng", "Phiếu xuất kho", "Nhắc sự kiện sinh nhât", "In phiếu bảo hành" };
        string[] arrValues = { "", "frmPhieuXuatBanHangHoa", "frmPhieuXuatKho", "frm_Nhac_SinhNhat", "frmIn_PhieuBaoHanh" };
        public frmHT_TuychonNguoiDung()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void frmThongTin_Load(object sender, EventArgs e)
        {
            LoadFormGiaoDien();
            string str = "Select InBill, InHoaDon, InPhieuThu, ChonKho, FormMacDinh " +
                          " From tbl_DM_NguoiDung " +
                          " Where IdNguoiDung = " + Declare.UserId;
            DataTable dtUser = DBTools.getData("tmp", str).Tables["tmp"];
            if (dtUser != null)
            {
                for (int i=0; i< arrValues.Length; i++)
                    if (arrValues[i].Equals(dtUser.Rows[0]["FormMacDinh"].ToString()))
                    {
                        cboGiaoDienMacDinh.SelectedIndex = i;
                        break;
                    }
                chkInPhieuXuat.Checked = Common.BoolValue(dtUser.Rows[0]["InBill"]);
                chkInHoaDon.Checked = Common.BoolValue(dtUser.Rows[0]["InHoaDon"]);
                chkInPhieuThu.Checked = Common.BoolValue(dtUser.Rows[0]["InPhieuThu"]);
                chkChonKho.Checked = Common.BoolValue(dtUser.Rows[0]["ChonKho"]);
                txtTempDir.Text = Declare.TempDirectory;

                Declare.InHoaDon = chkInHoaDon.Checked;
                Declare.InBill = chkInPhieuXuat.Checked;
                Declare.InPhieuThu = chkInPhieuThu.Checked;
                Declare.HienThiChonKho = chkChonKho.Checked;
                if (cboGiaoDienMacDinh.SelectedValue != null)
                    Declare.GiaoDienMacDinh = cboGiaoDienMacDinh.SelectedValue.ToString();
            }
        }


        private void LoadFormGiaoDien()
        {
            for (int i = 0; i < arrDisplay.Length; i++)
            {
                FormItem item = new FormItem(arrValues[i], arrDisplay[i]);
                cboGiaoDienMacDinh.Items.Add(item);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //update information
                Declare.InHoaDon = chkInHoaDon.Checked;
                Declare.InBill = chkInPhieuXuat.Checked;
                Declare.InPhieuThu = chkInPhieuThu.Checked;
                Declare.HienThiChonKho = chkChonKho.Checked;
                Declare.GiaoDienMacDinh = arrValues[cboGiaoDienMacDinh.SelectedIndex];
                Declare.TempDirectory = txtTempDir.Text.Trim();
                //update config file

                string sql = "Update tbl_DM_NguoiDung Set InBill = " + (chkInPhieuXuat.Checked ? 1 : 0) +
                            " , InHoaDon = " + (chkInHoaDon.Checked ? 1 : 0) +
                            " , InPhieuThu = " + (chkInPhieuThu.Checked ? 1 : 0) +
                            " , ChonKho = " + (chkChonKho.Checked ? 1 : 0) +
                            " , FormMacDinh = N'" + Declare.GiaoDienMacDinh + "'" +
                            " Where IdNguoiDung = " + Declare.UserId;
                DBTools.ExecuteQuery(sql, CommandType.Text);

                //Common.SetValue("IN_BILL", (chkInPhieuXuat.Checked ? "1" : "0"));
                //Common.SetValue("IN_HOADON", (chkInHoaDon.Checked ? "1" : "0"));
                //Common.SetValue("IN_PHIEUTHU", (chkInPhieuThu.Checked ? "1" : "0"));
                //Common.SetValue("HIENTHI_CHONKHO", (chkChonKho.Checked ? "1" : "0"));
                //Common.SetValue("GIAODIEN_MACDINH", cboGiaoDienMacDinh.SelectedValue.ToString());
                Common.SetValue("TEMP_DIRECTORY", Declare.TempDirectory);

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
            this.Dispose();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowserDialog1.SelectedPath;
                txtTempDir.Text = path;
            }
        }

    }
}