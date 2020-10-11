using System;
using System.Data;
using System.Windows.Forms;
using QLBH.Common;
using QLBH.Core.Data;
//using QLBanHang.Class;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmThongTin : Form
    {
        String[] mavach = { "Code 13", "Code 128" };
        public frmThongTin()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void frmThongTin_Load(object sender, EventArgs e)
        {
            LoadCommboTienTe();
            LoadThongTin();            
        }
        private void LoadThongTin()
        {
            //Connection objConn = new Connection();
            IDataReader DataReader = null;
            //SqlConnection SqlConn = Connection.Instance.GetSqlConnection();
            //using (SqlConnection SqlConn = objConn.GetSqlConnection())
            //{
                try
                {
                    IDbCommand SqlComm = new GtidCommand("Select * From tbl_ThongTin", ConnectionUtil.Instance.GetConnection());
                    SqlComm.CommandType = CommandType.Text;
                    //if (!(SqlConn.State == ConnectionState.Open)) SqlConn.Open();
                    DataReader = SqlComm.ExecuteReader();
                    if (DataReader.Read())
                    {
                        //while (DataReader.Read())
                        //{
                            txtTenDoanhNghiep.Text = DataReader["TenDoanhNghiep"].ToString();
                            txtDiaChi.Text = DataReader["DiaChi"].ToString();
                            txtVPGiaoDich.Text = DataReader["VPGiaoDich"].ToString();
                            txtDienThoai.Text = DataReader["DienThoai"].ToString();
                            txtFax.Text = DataReader["Fax"].ToString();
                            txtEmail.Text = DataReader["Email"].ToString();
                            txtWebsite.Text = DataReader["Website"].ToString();
                            txtMaSoThue.Text = DataReader["MaSoThue"].ToString();
                            txtSoTaiKhoan.Text = DataReader["SoTaiKhoan"].ToString();
                            txtNganHang.Text = DataReader["NganHang"].ToString();
                            txtMota.Text = DataReader["MoTa"].ToString();
                            this.cboLoaiTien.SelectedValue = Common.IntValue(DataReader["IdTienTe"].ToString());
                            txtTyleGia.Text = DataReader["TyLeGia"].ToString();
                            string str=DataReader["ChuanMaVach"].ToString();
                            if (str != "")
                                for (int i=0; i< mavach.Length; i++)
                                    if (mavach[i].Equals(str))
                                    {
                                        cboChuanMaVach.SelectedIndex = i;
                                        break;
                                    }
                        //}
                    }
                    else
                    {
                        txtTenDoanhNghiep.Text = "";
                        txtDiaChi.Text = "";
                        txtVPGiaoDich.Text = "";
                        txtDienThoai.Text = "";
                        txtFax.Text = "";
                        txtEmail.Text = "";
                        txtWebsite.Text = "";
                        txtMaSoThue.Text = "";
                        txtSoTaiKhoan.Text = "";
                        txtNganHang.Text = "";
                        txtMota.Text = "";
                        txtTyleGia.Text = "0";
                        cboChuanMaVach.SelectedText = "Code 128";
                    }
                }
                catch
                {

                }
                finally
                {
                    DataReader.Close();
                    //if (!(SqlConn.State == ConnectionState.Closed)) SqlConn.Close();
                }
            //}
        }
        private void LoadCommboTienTe()
        {
            DataTable dtTienTe = DBTools.getData("tbl_DM_TienTe", " Select IdTienTe, TenTienTe From tbl_DM_TienTe Where SuDung = 1 ").Tables["tbl_DM_TienTe"];
            if (dtTienTe != null)
            {
                this.cboLoaiTien.DataSource = dtTienTe;
                this.cboLoaiTien.DisplayMember = "TenTienTe";
                this.cboLoaiTien.ValueMember = "IdTienTe";
                this.cboLoaiTien.SelectedValue = Declare.IdTienTe;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTenDoanhNghiep.Text != "")
            {
                //TuanLM modified 29/03/08
                if (!Common.ValidEmail(txtEmail.Text.Trim()))
                {
                    MessageBox.Show(Declare.msgValidateEmail, Declare.titleWarning, MessageBoxButtons.OK);
                    txtEmail.Focus();
                    return;
                }
                if (!Common.ValidWebsite(txtWebsite.Text.Trim()))
                {
                    MessageBox.Show(Declare.msgValidateWebsite, Declare.titleWarning, MessageBoxButtons.OK);
                    txtWebsite.Focus();
                    return;
                }

            }
            //else
            //{
            //    MessageBox.Show(Declare.msgInputData, Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtTenDoanhNghiep.Focus();
            //    return;
            //}
            string sql = "Delete From tbl_ThongTin";
            if (DBTools.ExecuteQuery(sql, CommandType.Text) != null)
            {
                sql = "Insert Into tbl_ThongTin(TenDoanhNghiep, DiaChi, VPGiaoDich, DienThoai, Fax, Email, Website, MaSoThue, SoTaiKhoan, NganHang, Mota, IdTienTe,TyLeGia,ChuanMaVach) Values(N'" +
                        txtTenDoanhNghiep.Text + "', N'" + txtDiaChi.Text + "', N'" + txtVPGiaoDich.Text + "', '" + txtDienThoai.Text + "', '" + txtFax.Text + "', '" +
                        txtEmail.Text + "', '" + txtWebsite.Text + "', '" + txtMaSoThue.Text + "', '" + txtSoTaiKhoan.Text + "', N'" +
                        txtNganHang.Text + "', N'" + txtMota.Text + "', " + this.cboLoaiTien.SelectedValue + ", " + txtTyleGia.Text + ", N'" + mavach[cboChuanMaVach.SelectedIndex] + "') ";
                if (DBTools.ExecuteQuery(sql, CommandType.Text) != null)
                {
                    Declare.IdTienTe = Common.IntValue(this.cboLoaiTien.SelectedValue.ToString());
                    Declare.TyLeChenhGiaNhap_Xuat = Common.IntValue(txtTyleGia.Text);
                    Declare.CHUAN_MAVACH = cboChuanMaVach.SelectedText;
                    MessageBox.Show(Declare.msgSavedData, Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show(Declare.msgUpdateErr, Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}