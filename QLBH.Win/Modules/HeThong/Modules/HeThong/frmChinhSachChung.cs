using System;
using System.Data;
using System.Windows.Forms;
using QLBH.Common;
using QLBH.Core.Data;

//using QLBanHang.Class;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmChinhSachChung : Form
    {
        public frmChinhSachChung()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void frmThongTin_Load(object sender, EventArgs e)
        {
            //Connection objConn = new Connection();
            IDataReader DataReader = null;
            //SqlConnection SqlConn = Connection.Instance.GetSqlConnection();
            //using (SqlConnection SqlConn = objConn.GetSqlConnection())
            //{
                try
                {
                    GtidCommand SqlComm = new GtidCommand("Select * From tbl_ThongTin", ConnectionUtil.Instance.GetConnection());
                    SqlComm.CommandType = CommandType.Text;
                    //if (!(SqlConn.State == ConnectionState.Open)) SqlConn.Open();
                    DataReader = SqlComm.ExecuteReader();
                    if (DataReader.Read())
                    {
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

                string sql = "Delete From tbl_ThongTin";
                if (DBTools.ExecuteQuery(sql, CommandType.Text) != null)
                {
                    sql = "Insert Into tbl_ThongTin(TenDoanhNghiep, DiaChi, VPGiaoDich, DienThoai, Fax, Email, Website, MaSoThue, SoTaiKhoan, NganHang, Mota) Values(N'" +
                            txtTenDoanhNghiep.Text + "', N'" + txtDiaChi.Text + "', N'" + txtVPGiaoDich.Text + "', '" + txtDienThoai.Text + "', '" + txtFax.Text + "', '" +
                            txtEmail.Text + "', '" + txtWebsite.Text + "', '" + txtMaSoThue.Text + "', '" + txtSoTaiKhoan.Text + "', N'" +
                            txtNganHang.Text + "', N'" + txtMota.Text + "')";
                    if (DBTools.ExecuteQuery(sql, CommandType.Text) != null)
                    {
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
            else
            {
                MessageBox.Show(Declare.msgInputData, Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDoanhNghiep.Focus();
                return;
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {

        }


    }
}