using System;
using System.Data;
using System.Windows.Forms;
using QLBH.Common;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmNamHienTai : Form
    {
        public frmNamHienTai()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void frmNamHienTai_Load(object sender, EventArgs e)
        {
            int bgYear=2000, endYear=2050;

            for (int i=bgYear; i<=endYear;i++)
                cboCurrentYear.Items.Add(new ListItem(i,Convert.ToString(i)));
            cboCurrentYear.SelectedValue = DateTime.Today.Year.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboCurrentYear.SelectedIndex > 0)
                {
                    string sql = "Update tbl_ThongTin Set NamHienTai = " + ((ListItem)cboCurrentYear.Items[cboCurrentYear.SelectedIndex]).ItemData.ToString();
                    if (DBTools.ExecuteQuery(sql, CommandType.Text) != null)
                        MessageBox.Show(Declare.msgSavedData, Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(Declare.msgUpdateErr, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}