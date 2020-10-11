using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmHT_QuanTriNSD : Form
    {
        bool flgUpdate = false;

        public frmHT_QuanTriNSD()
        {
            InitializeComponent();
            _self = this;
            Common.LoadStyle(this);
        }

        private void frmQuanLyNguoiDung_Load(object sender, EventArgs e)
        {

            dgvUser.ReadOnly = true;
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgvUser.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dgvUser.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvUser.GridColor = SystemColors.ActiveBorder;
            dgvUser.RowHeadersVisible = false;
            dgvUser.RowHeadersVisible = false;

            dgvUser.Rows.Clear();
            dgvUser.Columns.Clear();
            dgvUser.Columns.Add("STT", "STT");
            dgvUser.Columns.Add("UserId", "UserId");
            dgvUser.Columns.Add("UserName", "Tên đăng nhập");
            dgvUser.Columns.Add("FullName", "Tên đầy đủ");
            dgvUser.Columns.Add("UserGroup", "Nhóm");
            dgvUser.Columns.Add("NhanVien", "Nhân viên");

            dgvUser.Columns[0].Width = 30;
            dgvUser.Columns["UserId"].Visible = false;
            dgvUser.Columns["NhanVien"].Visible = false;
            dgvUser.Columns[2].Width = 105;
            dgvUser.Columns[3].Width = 135;
            dgvUser.Columns[4].Width = 161;

            dgvUser.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUser.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUser.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUser.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUser.MultiSelect = false;
            dgvUser.RowTemplate.Height = 35;
            dgvUser.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);

            DBTools.List_LoadData(cboGroup, "Select IdNhomNguoiDung, TenNhom From tbl_DM_NhomNguoiDung order by TenNhom", "IdNhomNguoiDung", "TenNhom", "", 0);
            DBTools.List_LoadData(cboNhanVien, "Select IdNhanVien, HoTen From tbl_DM_NhanVien order by HoTen", "IdNhanVien", "HoTen", " ", 0);
            RefreshGrid(); 
        }

        public void RefreshGrid()
        {
            string sql = "";
            sql = "SELECT tbl_DM_NguoiDung.IdNguoiDung, tbl_DM_NguoiDung.TenDangNhap, tbl_DM_NguoiDung.TenDayDu, tbl_DM_NhomNguoiDung.TenNhom, tbl_DM_NhanVien.HoTen " +
                    "FROM tbl_DM_NhomNguoiDung INNER JOIN tbl_DM_NguoiDung ON tbl_DM_NhomNguoiDung.IdNhomNguoiDung = tbl_DM_NguoiDung.IdNhomNguoiDung " +
                    "LEFT OUTER JOIN tbl_DM_NhanVien ON tbl_DM_NguoiDung.IdNhanVien = tbl_DM_NhanVien.IdNhanVien order by tbl_DM_NhomNguoiDung.TenNhom, tbl_DM_NguoiDung.TenDayDu";

            DBTools.GridView_LoadData(dgvUser, sql, true);
        }

        private GtidCommand ChecIsDelete_NguoiDung(int IdNguoiDung)
        {
            GtidCommand sql = new GtidCommand("sp_DM_NguoiDung_CheckIsDelete");
            sql.Parameters.AddWithValue("@IdNguoiDung", IdNguoiDung).Direction = ParameterDirection.Input;
            sql.Parameters.AddWithValue("@IsCheck", 0).Direction = ParameterDirection.Output;
            sql.CommandType = CommandType.StoredProcedure;
            return sql;
        }
        private void dgvUser_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvUser.CurrentCell.RowIndex != -1)
            {
                flgUpdate = false;
                txtUserName.Enabled = false;
                txtPassword.Enabled = false;
                txtRetypePassword.Enabled = false;
                txtPassword.Text = "";
                txtRetypePassword.Text = "";
                txtFullName.Text = dgvUser.Rows[dgvUser.CurrentCell.RowIndex].Cells["FullName"].Value.ToString();
                txtUserName.Text = dgvUser.Rows[dgvUser.CurrentCell.RowIndex].Cells["UserName"].Value.ToString();
                cboGroup.Text = dgvUser.Rows[dgvUser.CurrentCell.RowIndex].Cells["UserGroup"].Value.ToString();
                cboNhanVien.Text = dgvUser.Rows[dgvUser.CurrentCell.RowIndex].Cells["NhanVien"].Value.ToString();
                if (String.IsNullOrEmpty(dgvUser.Rows[dgvUser.CurrentCell.RowIndex].Cells["NhanVien"].Value.ToString())) {
                    cboNhanVien.SelectedIndex = -1;
                }
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            flgUpdate = true;
            txtFullName.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtRetypePassword.Text = "";
            cboGroup.SelectedIndex = -1;
            cboNhanVien.SelectedIndex = -1;
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
            txtRetypePassword.Enabled = true;
            txtFullName.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try {
                if (txtUserName.Text.Trim().Equals("")) {
                    MessageBox.Show(Declare.msgInputData, Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Focus();
                    return;
                }

                if (txtPassword.Text.Trim() != txtRetypePassword.Text.Trim()) {
                    MessageBox.Show("Xác nhận lại mật khẩu!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRetypePassword.Focus();
                    return;
                }

                string mySalt = Password.CreateSalt();
                string myPass = Password.SetPassword(txtPassword.Text.Trim(), mySalt);
                ListItem selectedItem = new ListItem();
                selectedItem = (ListItem)cboGroup.SelectedItem;
                string sql = "";
                if (flgUpdate || dgvUser.RowCount == 0) {
                    if (!DBTools.ExistData("tbl_DM_NguoiDung", "TenDangNhap", typeof(string), txtUserName.Text.Trim())) {
                        sql = "Insert Into tbl_DM_NguoiDung(TenDayDu, TenDangNhap, MatKhau, IdNhanVien, IdNhomNguoiDung, Salt, SuDung) " +
                            "Values(N'" + txtFullName.Text + "','" + txtUserName.Text + "','" + myPass + "', " +
                            Common.IntValue((cboNhanVien.SelectedItem as ListItem).ItemData.ToString()) + ", " +
                            Common.IntValue(selectedItem.ItemData.ToString()) + ",'" + mySalt + "', 1)";
                        if (DBTools.ExecuteQuery(sql, CommandType.Text) != null) {
                            this.RefreshGrid();
                            if (dgvUser.Rows.Count > 0) {
                                dgvUser.Rows[dgvUser.Rows.Count - 1].Selected = true;
                                txtUserName.Text = dgvUser.Rows[dgvUser.Rows.Count - 1].Cells[2].Value.ToString();
                                txtFullName.Text = dgvUser.Rows[dgvUser.Rows.Count - 1].Cells[3].Value.ToString();
                                cboGroup.Text = dgvUser.Rows[dgvUser.Rows.Count - 1].Cells[4].Value.ToString();
                            }
                        }
                        else {
                            MessageBox.Show(Declare.msgUpdateErr, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        //sql = "SELECT HT_NGUOI_SU_DUNG.MaNSD, HT_NGUOI_SU_DUNG.Username, HT_NGUOI_SU_DUNG.Hoten, HT_NHOM_NGUOI_SU_DUNG.TenNhom " +
                        //        "FROM HT_NHOM_NGUOI_SU_DUNG INNER JOIN HT_NGUOI_SU_DUNG ON HT_NHOM_NGUOI_SU_DUNG.MaNhom = HT_NGUOI_SU_DUNG.ThuocNhom;";
                    }
                    else {
                        MessageBox.Show(Declare.msgExistData, Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    Common.LogAction("Thêm mới người dùng", "UserName " + txtUserName.Text, -1);
                }
                else {
                    if (txtPassword.Text.Trim().Length > 0)
                    {
                        sql = "Update tbl_DM_NguoiDung Set TenDayDu = N'" + txtFullName.Text.Trim() + "', " +
                                        " MatKhau = '" + myPass + "', " +
                                        " IdNhanVien = " + Common.IntValue((cboNhanVien.SelectedItem as ListItem).ItemData.ToString()) + ", " +
                                        " IdNhomNguoiDung = " + Common.IntValue(selectedItem.ItemData.ToString()) + ", " +
                                        " Salt = '" + mySalt + "' " +
                               " Where IdNguoiDung = " + Common.IntValue(dgvUser.Rows[dgvUser.CurrentCell.RowIndex].Cells[1].Value.ToString());
                    }
                    else
                    {
                        sql = "Update tbl_DM_NguoiDung Set TenDayDu = N'" + txtFullName.Text.Trim() + "', " +
                                        " IdNhanVien = " + Common.IntValue((cboNhanVien.SelectedItem as ListItem).ItemData.ToString()) + ", " +
                                        " IdNhomNguoiDung = " + Common.IntValue(selectedItem.ItemData.ToString()) + 
                               " Where IdNguoiDung = " + Common.IntValue(dgvUser.Rows[dgvUser.CurrentCell.RowIndex].Cells[1].Value.ToString());
                    }
                    if (DBTools.ExecuteQuery(sql, CommandType.Text) != null) {
                        dgvUser.CurrentRow.Cells[3].Value = txtFullName.Text;
                        dgvUser.CurrentRow.Cells[4].Value = selectedItem.Name;
                        dgvUser.Rows[dgvUser.CurrentCell.RowIndex].Selected = true;
                        //MessageBox.Show("Cập nhật thông tin thành công!");
                        Common.LogAction("Cập nhật người dùng", "UserName " + txtUserName.Text, -1);
                    }
                    else {
                        MessageBox.Show(Declare.msgUpdateErr, Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex) {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try {
                if (this.dgvUser.RowCount > 0) {
                    int IdUser = int.Parse(this.dgvUser.CurrentRow.Cells["UserId"].Value.ToString());
                    DBTools._IsCheck IsCheck;
                    IsCheck = DBTools.CheckExistsRecord(this.ChecIsDelete_NguoiDung(IdUser));
                    if (IsCheck == DBTools._IsCheck._TRUE) {
                        MessageBox.Show("Thông tin người dùng này đã được sử dụng. Nên không thể xóa được", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (IsCheck == DBTools._IsCheck._EXCEPTION) {
                        MessageBox.Show("Lỗi kiểm tra dữ liệu: " + DBTools._LastError.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (dgvUser.Rows.Count > 0) {
                        if (MessageBox.Show(Declare.msgRemoveData, Declare.titleNotice, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                            object obj = DBTools.ExecuteQuery("Delete From tbl_DM_NguoiDung Where IdNguoiDung = " + Common.IntValue(dgvUser.Rows[dgvUser.CurrentCell.RowIndex].Cells[1].Value.ToString()), CommandType.Text);
                            if (obj == null)
                                MessageBox.Show(Declare.msgDeleteErr, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                                this.RefreshGrid();
                        }
                    }
                    Common.LogAction("Xóa người dùng", "UserId " + IdUser, -1);
                    MessageBox.Show("Đã xóa người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Exception ex) {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            txtPassword.Enabled = true;
            txtRetypePassword.Enabled = true;
            txtPassword.Text = "";
            txtRetypePassword.Text = "";
        }

    }
}