using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QLBH.Common;
using QLBanHang.Modules.HeThong.Providers;
using DevExpress.XtraBars.Ribbon;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Core.Form;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmHT_ListNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        private objGridMarkSelection selector = new objGridMarkSelection();

        public frmHT_ListNguoiDung()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        public frmHT_ListNguoiDung(RibbonControl ribbon)
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void frmHT_ListChucNang_Load(object sender, EventArgs e)
        {
            LoadAllNguoiDung();
        }
        public void LoadAllNguoiDung()
        {
            gNguoiDung.DataSource = NguoiDungDataProvider.LoadAll(); ;
            gvNguoiDung.Columns["NhomNguoiDung"].GroupIndex = 0;
            gvNguoiDung.ExpandAllGroups();
            selector.View = gvNguoiDung;
            selector.CheckMarkColumn.VisibleIndex = 0;
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            gNguoiDung.DataSource = NguoiDungDataProvider.Search(txtFilterHanhDong.Text);
            gvNguoiDung.Columns["NhomNguoiDung"].GroupIndex = 0;
            gvNguoiDung.ExpandAllGroups();
            selector.View = gvNguoiDung;
            selector.CheckMarkColumn.VisibleIndex = 0;
            txtFilterHanhDong.Focus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAll.Checked == true)
            {
                selector.SelectAll();
            }
            else
            {
                selector.ClearSelection();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmHT_AddNguoiDung(this).ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditOrder(gvNguoiDung.FocusedRowHandle);
        }
        private void EditOrder(int rowHandle)
        {
            if (rowHandle < 0) return;
            NguoiDungInfor nd = (NguoiDungInfor)gvNguoiDung.GetRow(rowHandle);
            frmHT_AddNguoiDung frm = new frmHT_AddNguoiDung(nd, this);
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selector.SelectedCount == 0)
                {
                    MessageBox.Show("Phải chọn ít nhất một người dùng để xóa!");
                    return;
                }
                if (MessageBox.Show("Bạn có chắc chắn xóa người dùng này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    for (int i = 0; i < selector.SelectedCount; i++)
                    {
                        NguoiDungInfor nd = (NguoiDungInfor)selector.GetSelectedRow(i);
                        if (nd.TenDangNhap.Equals(((NguoiDungInfor)Declare.USER_INFOR).TenDangNhap))
                        {
                            MessageBox.Show("Không thể xóa người dùng đang đăng nhập!");
                            break;
                        }
                        if (!Common.Int2Bool(((NguoiDungInfor)Declare.USER_INFOR).SupperUser) && Common.Int2Bool(nd.SupperUser))
                        {
                            MessageBox.Show("Không thể xóa Super User!");
                            break;
                        }
                        NguoiDungDataProvider.Delete(nd);
                    }
                    selector.ClearSelection();
                    gNguoiDung.DataSource = null;

                    LoadAllNguoiDung();
                    chkAll.Checked = false;
                }
            }
            catch { }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (gvNguoiDung.FocusedRowHandle < 0) return;
            NguoiDungInfor nd = (NguoiDungInfor)gvNguoiDung.GetRow(gvNguoiDung.FocusedRowHandle);
            frmHT_ChangePass frm = new frmHT_ChangePass(nd, true);
            frm.ShowDialog();
        }

        private void gvNguoiDung_DoubleClick(object sender, EventArgs e)
        {
            Point pt = gNguoiDung.PointToClient(MousePosition);
            GridHitInfo hitInfo = gvNguoiDung.CalcHitInfo(pt);
            if (hitInfo.InRow)
                EditOrder(hitInfo.RowHandle);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //ArrayList arrND = new ArrayList();
            //arrND.AddRange(selector.selection);
            //foreach (NguoiDungInfor nd in arrND)
            //{
            //    if (!nd.TenDangNhap.ToUpper().Equals("QUANTRI"))
            //    {
            //        string mySalt = Password.CreateSalt();
            //        string newPass = Password.SetPassword("123456", mySalt);
            //        nd.MatKhau = newPass;
            //        nd.Salt = mySalt;
            //        NguoiDungDataProvider.Update(nd);
            //        NguoiDungDataProvider.ChangePass(nd.IdNguoiDung, newPass);                                    
            //    }
            //}

            frmProgress.Instance.Description = "Đang import du lieu ....";
            frmProgress.Instance.MaxValue = 384;
            frmProgress.Instance.DoWork(ImportDL);
        }

        private void ImportDL()
        {
            string sql = "select initcap(nv.hoten) as TenDayDu, lower(tk.username) as TenDangNhap, nv.idnhanvien, nnd.idnhomnguoidung " +
                         "from tbl_tmp_nhanvien tk " +
                         "       inner join tbl_dm_nhanvien nv on tk.manhanvien = nv.manhanvien " +
                         "       inner join tbl_dm_nhomnguoidung nnd on tk.phanquyen = nnd.tennhom " +
                         "   where  lower(tk.username) not in (select lower(tendangnhap) from tbl_dm_nguoidung)";
            DataSet ds = DBTools.getData("TaiKhoan", sql);
            foreach (DataRow ct in ds.Tables["TaiKhoan"].Rows)
            {
                frmProgress.Instance.Description = String.Format("Đang import tai khoan {0} ....", ct["TenDangNhap"].ToString());
                try
                {
                    NguoiDungInfor objNguoiDung = new NguoiDungInfor();
                    //cap nhat thong tin NND
                    string mySalt = Password.CreateSalt();
                    string myPass = Password.SetPassword("123456", mySalt);

                    objNguoiDung.TenDayDu = ct["TenDayDu"].ToString();
                    objNguoiDung.TenDangNhap = ct["TenDangNhap"].ToString();
                    objNguoiDung.MatKhau = myPass;
                    objNguoiDung.Salt = mySalt;
                    objNguoiDung.IdNhanVien = Common.IntValue(ct["IdNhanVien"].ToString());
                    objNguoiDung.IdNhomNguoiDung = Common.IntValue(ct["IdNhomNguoiDung"].ToString());
                    objNguoiDung.SuDung = true;// (chkSuDung.Checked ? 1 : 0);
                    NguoiDungDataProvider.Insert(objNguoiDung);
                    frmProgress.Instance.Description = String.Format("Đã import xong tai khoan [{0}] ....", ct["TenDangNhap"].ToString());
                }
                catch {
                }
                frmProgress.Instance.Value += 1;
            }

            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = String.Format("Đã import xong {0} tai khoan", 384);
        }
    }
}