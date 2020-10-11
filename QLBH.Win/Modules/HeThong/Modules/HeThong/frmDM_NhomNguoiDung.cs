using System;
using System.Windows.Forms;
using QLBanHang.Modules.HeThong.Providers;
using QLBH.Common;
using QLBH.Core;

// <Remarks>
// Tạo frmDM_NhomNguoiDung
// Người tạo: Bùi Ðức Hạnh
// Ngày tạo : 12/03/2012
// Người sửa cuối:
// </remarks>

//todo @Hanh frmDM_NhomNguoiDung
namespace QLBanHang.Modules.HeThong
{
    public partial class frmDM_NhomNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        public frmDM_NhomNguoiDung()
        {
            InitializeComponent();
        }

        private void frmDM_NhomNguoiDung_Load(object sender, EventArgs e)
        {
            try
            {
                dgvList.DataSource = DMNhomNguoiDungDataProvider.GetListNhomInfo();
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
                this.Dispose();
            }
        }

        private DMNhomNguoiDungInfor getinfor()
        {
            DMNhomNguoiDungInfor dmNhomNguoiDungInfor = new DMNhomNguoiDungInfor();
            dmNhomNguoiDungInfor.MaNhom = txtMa.Text;
            dmNhomNguoiDungInfor.TenNhom = txtTen.Text;
            dmNhomNguoiDungInfor.SuDung = Common.IntValue(chkSuDung.Checked);
            return dmNhomNguoiDungInfor;
        }

        private void ucActions1_OnAdd(object obj)
        {
            DMNhomNguoiDungDataProvider.Insert(getinfor());
            MessageBox.Show("Thêm bảng thành công!");
            dgvList.DataSource = DMNhomNguoiDungDataProvider.GetListNhomInfo();
        }

        private void ucActions1_OnClose()
        {
            this.Close();
        }

        private void ucActions1_OnDelete(object obj)
        {
            //DeleteItem();
            DMNhomNguoiDungInfor khaibao = new DMNhomNguoiDungInfor();
            khaibao.MaNhom = Convert.ToString(getValue("clMa"));
            DMNhomNguoiDungDataProvider.Delete(khaibao);
            MessageBox.Show("Xóa Thành Công", "Thông Báo");
            dgvList.DataSource = DMNhomNguoiDungDataProvider.GetListNhomInfo();
        }

        private void ucActions1_OnDisableEditor()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            chkSuDung.Enabled = false;
        }

        private void ucActions1_OnEnableEditor()
        {
            txtMa.Enabled = true;
            txtTen.Enabled = true;
            chkSuDung.Enabled = true;
        }

        private void ucActions1_OnLoadEditor(object obj)
        {
            if (obj != null)
            {
                txtMa.Text = Convert.ToString(getValue("clMa"));
                txtTen.Text = Convert.ToString(getValue("clTen"));
                chkSuDung.Checked = Common.IntValue(getValue("clSuDung")) == 1;
                return;
            }
            txtMa.Text = String.Empty;
            txtTen.Text = String.Empty;
            chkSuDung.Checked = false;
        }

        protected object getValue(string colName)
        {
            if (dgvList.CurrentRow != null && !dgvList.CurrentRow.IsNewRow)
                return dgvList.CurrentRow.Cells[colName].Value;
            return null;
        }

        private void ucActions1_OnUpdate(object obj)
        {
            DMNhomNguoiDungDataProvider.Update(getinfor());
            MessageBox.Show("Sửa bảng thành công!");
            dgvList.DataSource = DMNhomNguoiDungDataProvider.GetListNhomInfo();
        }

        private void ucActions1_OnValidate(object obj, ActionState actionMode)
        {
            switch (actionMode)
            {
                case ActionState.ADD:
                case ActionState.UPDATE:
                    if (txtMa.Text == String.Empty)
                    {
                        throw new Exception("Mã Nhóm không Được Để Trống!");
                    }
                    if (DMNhomNguoiDungDataProvider.Kiemtra(Exist))
                    {
                        throw new Exception("Mã Nhóm Đã Tồn Tại!");
                    }
                    break;
            }
        }

        private bool Exist(DMNhomNguoiDungInfor dmNhomNguoiDungInfor)
        {
            return dmNhomNguoiDungInfor.MaNhom.ToLower() == txtMa.Text.Trim().ToLower();
        }

        protected int getEditId(object obj)
        {
            DataGridViewRow dr = obj as DataGridViewRow;
            if (dr == null) return 0;
            return Common.IntValue(dr.Cells["clId"].Value);
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || dgvList.Rows[e.RowIndex].IsNewRow)
                ucActions1.LoadEditor(null);
            else
                ucActions1.LoadEditor(dgvList.Rows[e.RowIndex]);
        }
    }
}
