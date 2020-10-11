using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmThietLapKetNoiWS : Form
    {
        string executablePath = String.Empty;
        public frmThietLapKetNoiWS()
        {
            InitializeComponent();
            executablePath = Application.ExecutablePath;
        }

        public frmThietLapKetNoiWS(string assemblyPath)
        {
            InitializeComponent();
            executablePath = assemblyPath;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try {
                if (String.IsNullOrEmpty(txtUrl.Text)) throw new Exception("Bạn chưa nhập địa chỉ web service");
                string fileConfig = String.Format("{0}.config", executablePath);
                if (File.Exists(fileConfig)) {
                    string content = File.ReadAllText(fileConfig, Encoding.UTF8);
                    content = content.Replace(QLBanHang.Properties.Settings.Default.QLBanHang_WebReference_Main, txtUrl.Text);
                    content = content.Replace(QLBanHang.Properties.Settings.Default.Time.ToString(), dtStartTime.Value.TimeOfDay.ToString());
                    File.WriteAllText(fileConfig, content);
                }
                else {
                    MessageBox.Show(String.Format("Không tìm thấy file {0}.", fileConfig), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Đã cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex) {
#if DEBUG
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
#else
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
#endif
            } 

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmThietLapKetNoiWS_Load(object sender, EventArgs e)
        {
            txtUrl.Text = QLBanHang.Properties.Settings.Default.QLBanHang_WebReference_Main;
            dtStartTime.Value = new System.DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, QLBanHang.Properties.Settings.Default.Time.Hours, QLBanHang.Properties.Settings.Default.Time.Minutes, Properties.Settings.Default.Time.Seconds);
        }
    }
}