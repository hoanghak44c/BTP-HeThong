using System;
using System.Windows.Forms;
using QLBH.Common;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmSerialNumber : Form
    {
        public frmSerialNumber()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }


        private void frmSerialNumber_Load(object sender, EventArgs e)
        {
            txtHDDSerial.Text = Common.GetSerialNumber();
            //string sTemp =  Common.GetSerialNumber();
            //string sHDDSerial = "";
            //if(Microsoft.Win32.Registry.GetValue(Declare.RegistryPath, "HDDSerial", null)!=null)
            //    sHDDSerial = Microsoft.Win32.Registry.GetValue(Declare.RegistryPath, "HDDSerial", null).ToString();
            //string sCDKey = "";
            //if (Microsoft.Win32.Registry.GetValue(Declare.RegistryPath, "CDKey", null)!=null)
            //    sCDKey = Microsoft.Win32.Registry.GetValue(Declare.RegistryPath, "CDKey", null).ToString();
            //if ((sHDDSerial.Trim() != "") && (sHDDSerial.Trim() == sTemp.Trim()) && (sCDKey.Trim() == Password.SetPassword(sTemp.Trim(), "Gt0102280892")))
            //{
            //    Declare.IsRegister = true;
            //    this.Hide();
            //    this.Visible = false;
            //    frmLogin frmTemp = new frmLogin();
            //    frmTemp.Show();
            //}
            //else
            //{
            //    txtHDDSerial.Text = sTemp;
            //    //txtCDKey.Text = Password.SetPassword(txtHDDSerial.Text, "Gt0102280892");
            //}

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string RemainDay = "";
            DateTime dExpireDay;
            string sExpireDay = "";
            DateTime dTemp = DateTime.Now;
            string sCurrentDate = Common.ConvertDate(Common.GetCurrentDate());

            string sTemp = "";
            if (Microsoft.Win32.Registry.GetValue(Declare.RegistryPath, "ExpireDay", null) != null)
                sTemp = Microsoft.Win32.Registry.GetValue(Declare.RegistryPath, "ExpireDay", null).ToString();

            if ((sTemp != "") && (string.Compare(sCurrentDate,sTemp)>0))
            {
                MessageBox.Show("Chương trình đã hết hạn sử dụng. Hãy liên hệ với công ty sản xuất để được cấp bản quyền!", Declare.titleWarning, MessageBoxButtons.OK,MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            if (Microsoft.Win32.Registry.GetValue(Declare.RegistryPath, "ExpireDay", null) == null)
            {
                dExpireDay = dTemp.AddDays(Declare.NumDayExpire);
                sExpireDay = dExpireDay.Day + "/" + dExpireDay.Month + "/" + dExpireDay.Year;
                sExpireDay = Common.ConvertDate(sExpireDay);
                Microsoft.Win32.Registry.SetValue(Declare.RegistryPath, "HDDSerial", txtHDDSerial.Text);
                Microsoft.Win32.Registry.SetValue(Declare.RegistryPath, "CDKey", "");
                Microsoft.Win32.Registry.SetValue(Declare.RegistryPath, "ExpireDay", sExpireDay);
                Microsoft.Win32.Registry.SetValue(Declare.RegistryPath, "RemainDay", Declare.NumDayExpire);

            }

            Declare.IsRegister = false;
            this.Close();

            //else
            //{
            //    Microsoft.Win32.Registry.SetValue(Declare.RegistryPath, "CDKey", "");
            //    Microsoft.Win32.Registry.SetValue(Declare.RegistryPath, "ExpireDay", "60");
            //    Microsoft.Win32.Registry.SetValue(Declare.RegistryPath, "RemainDay", "60");
            //}

            //frmLogin frmTemp = new frmLogin();
            //frmTemp.Show();
            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //txtCDKey.Text = Password.SetPassword(txtHDDSerial.Text, "Gt0102280892");
            //this.Close();
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtHDDSerial.Text == "")
            {
                MessageBox.Show("Nhập mã máy vào!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHDDSerial.Focus();
                return;
            }

            if (txtCDKey.Text == "")
            {
                MessageBox.Show("Nhập CD key vào!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCDKey.Focus();
                return;
            }

            if (txtHDDSerial.Text.Trim() != Common.GetSerialNumber().Trim())
            {
                MessageBox.Show("Mã máy không đúng. Hãy nhập lại!", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaMay.Focus();
                return;
            }
            else if (txtCDKey.Text.Trim() != Password.SetPassword(txtHDDSerial.Text, "Gt0102280892"))
            {
                MessageBox.Show("CD key không đúng. Hãy nhập lại!", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaMay.Focus();
                return;
            }
            else
            {
                Microsoft.Win32.Registry.SetValue(Declare.RegistryPath, "HDDSerial", txtHDDSerial.Text);
                Microsoft.Win32.Registry.SetValue(Declare.RegistryPath, "CDKey", txtCDKey.Text);
                Microsoft.Win32.Registry.SetValue(Declare.RegistryPath, "ExpireDay", "");
                Microsoft.Win32.Registry.SetValue(Declare.RegistryPath, "RemainDay", "");
                Declare.IsRegister = true;
                this.Close();
                //this.Hide();
                //this.WindowState = FormWindowState.Minimized; 
                //frmLogin frmTemp = new frmLogin();
                //frmTemp.Show();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtCDKey.Text = Password.SetPassword(txtHDDSerial.Text, "Gt0102280892");
        }

    }
}