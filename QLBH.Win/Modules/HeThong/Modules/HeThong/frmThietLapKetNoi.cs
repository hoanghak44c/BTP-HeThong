using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
//using Microsoft.SqlServer.Management.Common;
//using Microsoft.SqlServer.Management.Smo;
using System.Text;
using System.Windows.Forms;
using System.Security.Principal;
using QLBH.Common;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmThietLapKetNoi : Form
    {
//        readonly string WinAuth = "Windows Authentication";
//        string executablePath = String.Empty;
//        bool isNotSet = false;
//        public frmThietLapKetNoi()
//        {
//            InitializeComponent();
//            Common.LoadStyle(this);
//            executablePath = Application.ExecutablePath;
//        }

//        public frmThietLapKetNoi(string assemblyPath)
//        {
//            InitializeComponent();
//            Common.LoadStyle(this);
//            executablePath = assemblyPath;
//        }

//        private void frmThietLapKetNoi_Load(object sender, EventArgs e)
//        {
//            try {
//                cboHinhThucKetNoi.SelectedIndex = 0;
//                DataTable dt = SmoApplication.EnumAvailableSqlServers(false);
//                foreach (DataRow dr in dt.Rows) {
//                    cboListServers.Items.Add(dr["Name"]);
//                }
//            }
//            catch (System.Exception ex) {
//#if DEBUG
//                MessageBox.Show(ex.ToString());
//#else
//                MessageBox.Show(ex.Message);
//#endif
//            }
//        }

//        private void btnTest_Click(object sender, EventArgs e)
//        {
//            try {
//                SqlConnection testConnection = new SqlConnection(GetConnectionString());
//                testConnection.Open();
//                if (testConnection.State == ConnectionState.Open)
//                    MessageBox.Show("Kết nối thành công!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                if ((testConnection.State == ConnectionState.Open)) {
//                    testConnection.Close();
//                }
//            }
//            catch (SqlException) {
//                MessageBox.Show("Lỗi kết nối. Hãy kiểm tra lại!", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//            catch (Exception ex) {
//#if DEBUG
//                MessageBox.Show(ex.ToString());
//#else
//                MessageBox.Show(ex.Message);
//#endif
//            }
//        }

//        private string GetConnectionString(){
//            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
//            builder.DataSource = cboListServers.Text;
//            if (!String.IsNullOrEmpty(cboListDB.Text)) {
//                builder.InitialCatalog = cboListDB.Text;
//            }
//            builder.IntegratedSecurity = String.Equals(cboHinhThucKetNoi.Text, WinAuth);
//            if (!builder.IntegratedSecurity) {
//                if (String.IsNullOrEmpty(txtUsername.Text)) {
//                    txtUsername.Focus();
//                    txtUsername.Select(0, txtUsername.Text.Length);
//                    throw new Exception("Bạn chưa nhập tên truy cập");
//                }
//                builder.UserID = txtUsername.Text;
//                builder.Password = txtPassword.Text;
//            }
//            builder.PersistSecurityInfo = true;
//            return builder.ConnectionString;
//        }

//        private void btnUpdate_Click(object sender, EventArgs e)
//        {
//            try {
//                if (String.IsNullOrEmpty(cboListDB.Text)) throw new Exception("Bạn chưa nhập tên cơ sở dữ liệu");
//                SqlConnection test = new SqlConnection(GetConnectionString());
//                test.Open();
//                string fileConfig = String.Format("{0}.config", executablePath);
//                if (File.Exists(fileConfig)) {
//                    string content = File.ReadAllText(fileConfig, Encoding.UTF8);
//                    content = content.Replace(Properties.Settings.Default.QLBanHangConnectionString, GetConnectionString());
//                    File.WriteAllText(fileConfig, content);
//                }
//                test.Close();
//                MessageBox.Show(Declare.msgSavedData, Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                this.DialogResult = DialogResult.OK;
//            }
//            catch (SqlException) {
//                MessageBox.Show("Lỗi kết nối. Hãy kiểm tra lại!", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//            catch (Exception ex) {
//#if DEBUG
//                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Information);
//#else
//                MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Information);
//#endif
//            } 

//        }

//        private void btnDong_Click(object sender, EventArgs e)
//        {
//            this.DialogResult = DialogResult.Cancel;
//        }

//        private void cboHinhThucKetNoi_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            if (cboHinhThucKetNoi.Text == WinAuth) {
//                txtUsername.Text = WindowsIdentity.GetCurrent().Name;
//                txtUsername.Enabled = false;
//                txtPassword.Text = String.Empty;
//                txtPassword.Enabled = false;
//            }
//            else {
//                txtUsername.Text = "sa";
//                txtUsername.Select(0, txtUsername.Text.Length);
//                txtUsername.Focus();

//                txtUsername.Enabled = true;
//                txtPassword.Text = String.Empty;
//                txtPassword.Enabled = true;
//            }
//            cboListDB.Items.Clear();
//            isNotSet = true;
//        }

//        private void cboListServers_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            cboListDB.Items.Clear();
//            isNotSet = true;
//        }

//        private void cboListDB_DropDown(object sender, EventArgs e)
//        {
//            try {
//                if (isNotSet) {
//                    ServerConnection cn = new ServerConnection(new SqlConnection(GetConnectionString()));
//                    Server svr = new Server(cn);
//                    foreach (Database db in svr.Databases) {
//                        cboListDB.Items.Add(db.Name);
//                    }
//                    isNotSet = false;
//                }
//            }
//            catch (System.Exception ex) {
//#if DEBUG
//                MessageBox.Show(ex.ToString());
//#else
//                MessageBox.Show(ex.Message);
//#endif
//            }
//        }
    }
}