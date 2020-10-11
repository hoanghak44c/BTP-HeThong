using System;
using System.Data;
using System.Windows.Forms;
using QLBanHang.Properties;
using System.Drawing;
using QLBanHang.Properties;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmHT_ThemNhomNSD : Form
    {
        bool flgUpdate = false;
        DataTable dtUserGroup;

        public frmHT_ThemNhomNSD()
        {
            InitializeComponent();
            _self = this;
            Common.LoadStyle(this);
        }


        private void frmHT_ThemNhomNSD_Load(object sender, EventArgs e)
        {
            dgvGroupList.ReadOnly = true;
            dgvGroupList.AllowUserToAddRows = false;

            dgvGroupList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgvGroupList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dgvGroupList.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvGroupList.GridColor = SystemColors.ActiveBorder;
            dgvGroupList.RowHeadersVisible = false;
            dgvGroupList.RowHeadersVisible = false;

            dgvGroupList.Rows.Clear();
            dgvGroupList.Columns.Clear();

            DataGridViewTextBoxColumn colSTT = new DataGridViewTextBoxColumn();
            colSTT.Name = "STT";
            colSTT.HeaderText = "STT";
            colSTT.SortMode = DataGridViewColumnSortMode.NotSortable;
            colSTT.Width = 50;
            colSTT.ReadOnly = true;
            colSTT.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colSTT.DataPropertyName = "STT";
            dgvGroupList.Columns.Add(colSTT);

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "Id";
            colId.HeaderText = "Id";
            colId.SortMode = DataGridViewColumnSortMode.NotSortable;
            colId.Width = 40;
            colId.ReadOnly = true;
            colId.Visible = false;
            colId.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colId.DataPropertyName = "IdNhomNguoiDung";
            dgvGroupList.Columns.Add(colId);

            DataGridViewTextBoxColumn colMaNhom = new DataGridViewTextBoxColumn();
            colMaNhom.Name = "MaNhom";
            colMaNhom.HeaderText = "Mã nhóm";
            colMaNhom.ValueType = typeof(string);
            colMaNhom.SortMode = DataGridViewColumnSortMode.Automatic;
            colMaNhom.Width = 100;
            colMaNhom.ReadOnly = true;
            colMaNhom.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colMaNhom.DataPropertyName = "MaNhom";
            dgvGroupList.Columns.Add(colMaNhom);

            DataGridViewTextBoxColumn colTenNhom = new DataGridViewTextBoxColumn();
            colTenNhom.Name = "TenNhom";
            colTenNhom.HeaderText = "Tên nhóm";
            colTenNhom.ValueType = typeof(string);
            colTenNhom.SortMode = DataGridViewColumnSortMode.Automatic;
            colTenNhom.Width = 208;
            colTenNhom.ReadOnly = true;
            colTenNhom.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colTenNhom.DataPropertyName = "TenNhom";
            dgvGroupList.Columns.Add(colTenNhom);

            DataGridViewCheckBoxColumn colSuDung = new DataGridViewCheckBoxColumn();
            colSuDung.Name = "SuDung";
            colSuDung.HeaderText = "Sử dụng";
            colSuDung.Width = 80;
            colSuDung.ReadOnly = true;
            colSuDung.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colSuDung.DataPropertyName = "SuDung";
            dgvGroupList.Columns.Add(colSuDung);

            dgvGroupList.Columns[1].Visible = false;
            dgvGroupList.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGroupList.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvGroupList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvGroupList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGroupList.MultiSelect = false;

            dgvGroupList.RowTemplate.Height = 35;
            dgvGroupList.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);


            this.RefreshGrid();
            
            string sql = "SELECT tbl_DM_ChucNang.IdChucNang, tbl_DM_ChucNang.TenChucNang " +
                         "FROM tbl_DM_ChucNang;";
            GtidCommand SqlComm = null;
            IDataReader DataReader = null;

            //Connection objConn = new Connection();
            //SqlConnection SqlConn = Connection.Instance.GetSqlConnection();
            //using (SqlConnection SqlConn = objConn.GetSqlConnection())
            //{
                try
                {
                    //if (!(SqlConn.State == ConnectionState.Open)) SqlConn.Open();
                    SqlComm = ConnectionUtil.Instance.GetConnection().CreateCommand();
                    SqlComm.CommandType = CommandType.Text;
                    SqlComm.CommandText = sql;
                    DataReader = SqlComm.ExecuteReader();

                    while (DataReader.Read())
                    {
                        chklstRightOfGroup.Items.Add(new ListItem(Common.IntValue(DataReader[0].ToString()), DataReader[1].ToString()), false);
                    }
                    DataReader.Close();
                }

                catch
                {
                }
                finally
                {
                    //if (!(SqlConn.State == ConnectionState.Closed)) SqlConn.Close();
                }
                this.dgvGroupList_SelectionChanged(null,EventArgs.Empty);
            //}

            this.SetButtomStatus(Declare.GroupCode);
        }

        public void SetButtomStatus(string GroupCode)
        {
            if (GroupCode == "Admin" || Declare.UserName.ToLower().Equals("admin"))
            {
                btnAddNew.Enabled = true;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                btnAddNew.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            flgUpdate = true;
            txtGroupId.Text = "";
            txtGroupName.Text = "";
            txtId.Text = String.Empty;
            txtGroupId.Focus();
            for (int i = 0; i < chklstRightOfGroup.Items.Count; i++)
            {
                chklstRightOfGroup.SetItemChecked(i, false);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try {
                string sql;
                bool InUse;
                int index;
                CurrencyManager cm;
                if (String.IsNullOrEmpty(txtGroupId.Text)) {
                    MessageBox.Show(Declare.msgInputData, Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGroupId.Focus();
                    return;
                }
                else {
                    sql = "select * from tbl_DM_NhomNguoiDung where MaNhom like N'" + txtGroupId.Text + "'";
                    if (!String.IsNullOrEmpty(txtId.Text))
                        sql += " and IdNhomNguoiDung <> " + txtId.Text;
                    if (DBTools.ExecuteScalar(sql) != null) {
                        MessageBox.Show(Resources.MaDaDung, Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtGroupId.Focus();
                        return;
                    }
                }
                if (String.IsNullOrEmpty(txtGroupName.Text)) {
                    MessageBox.Show(Declare.msgInputData, Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGroupName.Focus();
                    return;
                }
                else {
                    sql = "select * from tbl_DM_NhomNguoiDung where TenNhom like N'" + txtGroupName.Text + "'";
                    if (!String.IsNullOrEmpty(txtId.Text))
                        sql += " and IdNhomNguoiDung <> " + txtId.Text;
                    if (DBTools.ExecuteScalar(sql) != null) {
                        MessageBox.Show(Resources.TenDaDung, Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtGroupName.Focus();
                        return;
                    }
                }

                if (chkSuDung.Checked)
                    InUse = true;
                else
                    InUse = false;
                if (flgUpdate || dgvGroupList.RowCount == 0) {
                    if (!DBTools.ExistData("tbl_DM_NhomNguoiDung", "MaNhom", typeof(string), txtGroupId.Text.Trim())) {
                        //sql = "Insert Into tbl_DM_NhomNguoiDung(MaNhom, TenNhom, SuDung) Values(?,?,?)";
                        sql = "Insert Into tbl_DM_NhomNguoiDung Values(@MaNhom, @TenNhom, @SuDung)";

                        //SqlConnection SqlConn = Connection.Instance.GetSqlConnection();
                        //if (!(SqlConn.State == ConnectionState.Open)) SqlConn.Open();

                        GtidCommand SqlCmd = ConnectionUtil.Instance.GetConnection().CreateCommand();
                        SqlCmd.CommandText = "sp_DM_NhomNguoiDung_Insert";

                        SqlCmd.Parameters.AddWithValue("@IdNhomNguoiDung", 0).Direction = ParameterDirection.Output;
                        SqlCmd.Parameters.AddWithValue("@MaNhom", txtGroupId.Text).Direction = ParameterDirection.Input;
                        SqlCmd.Parameters.AddWithValue("@TenNhom", txtGroupName.Text).Direction = ParameterDirection.Input;
                        SqlCmd.Parameters.AddWithValue("@SuDung", InUse).Direction = ParameterDirection.Input;
                        SqlCmd.CommandType = CommandType.StoredProcedure;

                        SqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thành công nhóm người dùng", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Common.LogAction("Thêm mới nhóm người dùng", "Tên nhóm " + txtGroupName.Text, -1);

                        object[] arrMang ={ SqlCmd.Parameters[0].Value, this.txtGroupId.Text.Trim(), this.txtGroupName.Text, InUse };
                        dtUserGroup.Rows.Add(arrMang);

                        txtId.Text = SqlCmd.Parameters[0].Value.ToString();
                        //this.UpdateAutoColumn("STT", this.dtUserGroup.Rows.Count - 1);
                        index = this.dtUserGroup.Rows.Count - 1;

                        //sql = "Insert Into tbl_DM_NhomNguoiDung(MaNhom, TenNhom, SuDung) Values(N'" + txtGroupId.Text + "', N'" + txtGroupName.Text + "', " +InUse + ")";
                        //if (DBTools.ExecuteQuery(sql, CommandType.Text)!= null)
                        //{
                        //    this.RefreshGrid();

                        //    DataTable dtDanhSach = (DataTable)DBTools.getData("tbl_DM_NhomNguoiDung").Tables["tbl_DM_NhomNguoiDung"];
                        //    CurrencyManager cm = (CurrencyManager)this.BindingContext[dtDanhSach];
                        //    cm.Position = dtDanhSach.Rows.Count - 1;

                        //    dgvGroupList.Rows[dgvGroupList.Rows.Count - 1].Selected = true;
                        //    txtId.Text = dgvGroupList.Rows[dgvGroupList.Rows.Count - 1].Cells[1].Value.ToString();
                        //    txtGroupId.Text = dgvGroupList.Rows[dgvGroupList.Rows.Count - 1].Cells[2].Value.ToString();
                        //    txtGroupName.Text = dgvGroupList.Rows[dgvGroupList.Rows.Count - 1].Cells[3].Value.ToString();
                        //}
                        //else
                        //{
                        //    MessageBox.Show(Declare.msgUpdateErr, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    return;
                        //}
                    }
                    else {
                        MessageBox.Show(Declare.msgExistData, Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else {
                    sql = "Update tbl_DM_NhomNguoiDung Set MaNhom = N'" + txtGroupId.Text + "', TenNhom = N'" + txtGroupName.Text + "', SuDung = " + (InUse ? 1 : 0) + " Where IdNhomNguoiDung = " + Common.IntValue(txtId.Text);
                    if (DBTools.ExecuteQuery(sql, CommandType.Text) != null) {
                        dgvGroupList.CurrentRow.Cells["MaNhom"].Value = txtGroupId.Text;
                        dgvGroupList.CurrentRow.Cells["TenNhom"].Value = txtGroupName.Text;
                        dgvGroupList.Rows[dgvGroupList.CurrentCell.RowIndex].Selected = true;

                        sql = "Delete From tbl_NhomND_ChucNang Where IdNhomNguoiDung = " + Common.IntValue(txtId.Text);
                        if (DBTools.ExecuteQuery(sql, CommandType.Text) == null) {
                            MessageBox.Show(Declare.msgUpdateErr, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        index = dgvGroupList.Rows.IndexOf(dgvGroupList.CurrentRow);
                        
                        Common.LogAction("Thêm mới nhóm người dùng", "GroupId " + txtId.Text, -1);
                    }
                    else {
                        MessageBox.Show(Declare.msgUpdateErr, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                //MessageBox.Show("Cập nhật thông tin thành công!");
                for (int i = 0; i < chklstRightOfGroup.Items.Count; i++) {
                    if (chklstRightOfGroup.GetItemCheckState(i) == CheckState.Checked) {
                        ListItem itemChecked = (ListItem)chklstRightOfGroup.Items[i];
                        sql = "Insert Into tbl_NhomND_ChucNang(IdNhomNguoiDung, IdChucNang) Values(" + Common.IntValue(txtId.Text) + ", " + Common.IntValue(itemChecked.ItemData.ToString()) + ")";
                        if (DBTools.ExecuteQuery(sql, CommandType.Text) == null) {
                            MessageBox.Show(Declare.msgUpdateErr, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                MessageBox.Show("Cập nhật thông tin thành công!");
                RefreshGrid();
                cm = (CurrencyManager)this.BindingContext[this.dtUserGroup];
                cm.Position = index;
            }
            catch (System.Exception ex) {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
            finally {
                //this.dgvGroupList_SelectionChanged(null, EventArgs.Empty);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGroupList.Rows.Count > 0)
            {
                if (MessageBox.Show(Declare.msgRemoveData, Declare.titleNotice, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    object obj = DBTools.ExecuteQuery("Delete From tbl_DM_NhomNguoiDung Where IdNhomNguoiDung = " + Common.IntValue(txtId.Text), CommandType.Text);
                    if (obj == null)
                        MessageBox.Show(Declare.msgDeleteErr, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        RefreshGrid();
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshGrid()
        {
            this.dtUserGroup = (DataTable)DBTools.getData("tbl_DM_NhomNguoiDung").Tables["tbl_DM_NhomNguoiDung"];
            this.dtUserGroup.Columns.Add("STT", System.Type.GetType("System.Int16"));
            this.UpdateAutoColumn("STT",0);
            this.dgvGroupList.DataSource = this.dtUserGroup;
            dgvGroupList.Refresh();

            //DBTools.GridView_LoadData(dgvGroupList, "Select IdNhomNguoiDung, MaNhom, TenNhom, SuDung From tbl_DM_NhomNguoiDung", true);
            //if (dgvGroupList.Rows.Count > 0)
            //{
            //    txtId.Text = dgvGroupList[1, dgvGroupList.CurrentRow.Index].Value.ToString();
            //    txtGroupId.Text = dgvGroupList[2, dgvGroupList.CurrentRow.Index].Value.ToString();
            //    txtGroupName.Text = dgvGroupList[3, dgvGroupList.CurrentRow.Index].Value.ToString();
            //    chkSuDung.Checked = Common.BoolValue(dgvGroupList[3, dgvGroupList.CurrentRow.Index].Value.ToString());
            //}
            //else
            //{
            //    txtId.Text = "0";
            //    txtGroupId.Text = "";
            //    txtGroupName.Text = "";
            //    chkSuDung.Checked = false;
            //}
        }

        private void dgvGroupList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGroupList.Rows.Count > 0)
            {
                flgUpdate = false;
                string sql;
                //this.dgvList.CurrentRow.Cells[this.TenTruong2].Value.ToString();

                txtId.Text = dgvGroupList.CurrentRow.Cells["Id"].Value.ToString();
                //txtId.Text = dgvGroupList.Rows[dgvGroupList.CurrentCell.RowIndex].Cells[1].Value.ToString();
                txtGroupId.Text = dgvGroupList.CurrentRow.Cells["MaNhom"].Value.ToString();
                txtGroupName.Text = dgvGroupList.CurrentRow.Cells["TenNhom"].Value.ToString();
                chkSuDung.Checked = Equals(this.dgvGroupList.CurrentRow.Cells["SuDung"].Value, (decimal)1);
                for (int index = 0; index < chklstRightOfGroup.Items.Count; index++)
                {
                    ListItem item = new ListItem();
                    item = (ListItem)chklstRightOfGroup.Items[index];

                    sql = "Select * From tbl_NhomND_ChucNang Where IdNhomNguoiDung = " + Common.IntValue(txtId.Text) + " and IdChucNang = " + Common.IntValue(item.ItemData.ToString());
                    if (DBTools.ExistData(sql))
                        chklstRightOfGroup.SetItemChecked(index, true);
                    else
                        chklstRightOfGroup.SetItemChecked(index, false);
                    item = null;
                }
            }
        }

        private void UpdateAutoColumn(string sColName, int iStartValue)
        {
            for (int i = iStartValue; i <= dtUserGroup.Rows.Count - 1; i++)
            {
                dtUserGroup.Rows[i][sColName] = i+1;
            }
        }

    }
}