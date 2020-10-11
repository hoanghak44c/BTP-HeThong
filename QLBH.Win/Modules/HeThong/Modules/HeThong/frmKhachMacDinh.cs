using System;
using System.Data;
using System.Windows.Forms;
using QLBH.Common;
//using QLBanHang.Class;
//using QLBanHang.Class.Objects;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmKhachMacDinh : Form
    {
        DataTable dtKhachHang = null;
        public frmKhachMacDinh()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void frmMoSo_Load(object sender, EventArgs e)
        {
            LoadKho();
            LoadKhachHang();
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
        }

        private void LoadKhachHang()
        {
            try
            {
                string str = "Select IdDoiTuong, MaDoiTuong, TenDoiTuong, DiaChi, DienThoai, MaSoThue, IdOrderType " +
                      "from tbl_DM_DoiTuong " +
                      "where SuDung = 1 and Type <> 2 " +
                      "order by TenDoiTuong ASC";
                this.dtKhachHang = DBTools.getData("tbl_DM_DoiTuong", str).Tables["tbl_DM_DoiTuong"];
                if (this.dtKhachHang != null)
                {
                    //this.dtKhachHang.Constraints.Add("fg_KhachHang", dtKhachHang.Columns["IdKhachHang"], true);
                    this.cboKhachHang.DataSource = this.dtKhachHang;
                    this.cboKhachHang.DisplayMember = "TenDoiTuong";
                    this.cboKhachHang.ValueMember = "IdDoiTuong";
                    this.cboKhachHang.SelectedValue = Declare.IdKHMacDinh;

                    // AutoCompleteStringCollection 
                    AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                    AutoCompleteStringCollection data1 = new AutoCompleteStringCollection();
                    for (int i = 0; i < dtKhachHang.Rows.Count; i++)
                    {
                        data.Add(dtKhachHang.Rows[i]["TenDoiTuong"].ToString());
                        data1.Add(dtKhachHang.Rows[i]["MaDoiTuong"].ToString());
                    }

                    cboKhachHang.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    cboKhachHang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cboKhachHang.AutoCompleteCustomSource = data;

                    txtMaKhachHang.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txtMaKhachHang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txtMaKhachHang.AutoCompleteCustomSource = data1;

                }
            }
            catch (System.Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (!Common.IsValidDate(dtNgayKhoaSo.Text.Trim()))
            //{
            //    MessageBox.Show(Declare.msgDateTimeValid, Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    this.dtNgayKhoaSo.Focus();
            //    return;
            //}

            Declare.IdKHMacDinh = Common.IntValue(cboKhachHang.SelectedValue);
            Utils ut = new Utils();
            string sql = "Update tbl_DM_Kho Set IdKhachMacDinh = " + Declare.IdKHMacDinh + 
                         " Where IdKho= " + cboKho.SelectedValue;
            DBTools.ExecuteQuery(sql, CommandType.Text);

            MessageBox.Show("Khách hàng mặc định " + this.cboKhachHang.SelectedValue + " - " + this.cboKhachHang.Text, Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Common.LogAction("Thiết lập khách hàng mặc định thành công", "Khách hàng mặc định mới là " + this.cboKhachHang.SelectedValue + " - " + this.cboKhachHang.Text, Declare.IdKho);
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaKhachHang_TextChanged(object sender, EventArgs e)
        {
            bool found = false;
            for (int i = 0; i < dtKhachHang.Rows.Count; i++)
            {
                if (txtMaKhachHang.Text.Equals(dtKhachHang.Rows[i]["MaDoiTuong"].ToString()))
                {
                    cboKhachHang.SelectedIndex = i;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                cboKhachHang.Text = "";
            }
        }

        private void cboKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = this.cboKhachHang.SelectedIndex;
                txtMaKhachHang.Text = this.dtKhachHang.Rows[index]["MaDoiTuong"].ToString();
            }
            catch (System.Exception ex)
            {
#if DEBUG
                //MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                //MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void cboKhachHang_TextUpdate(object sender, EventArgs e)
        {
            if (cboKhachHang.Text.Trim().Length == 0)
            {
                txtMaKhachHang.Text = "";
            }
        }

        private void cboKhachHang_Leave(object sender, EventArgs e)
        {
            if (cboKhachHang.Text.Trim().Length > 0)
            {
                bool found = false;
                for (int i = 0; i < dtKhachHang.Rows.Count; i++)
                {
                    if (dtKhachHang.Rows[i]["TenDoiTuong"].ToString().ToLower().Equals(cboKhachHang.Text.Trim().ToLower()))
                    {
                        cboKhachHang.SelectedIndex = i;
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    MessageBox.Show("Khách hàng này không có trong danh sách, chọn khách hàng khác");
                    cboKhachHang.Text = "";
                }
            }
        }
    }
}