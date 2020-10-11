// <summary>
// Mô tả class: Lớp đối tượng thực hiện việc đăng nhập hệ thống
// </summary>
// <remarks>
// Người tạo: Nguyen Gia Dang
// Ngày tạo: 09/10/2007
// </remarks>

using System;
using System.Data;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.HeThong.Providers;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBH.Core;
using QLBH.Core.Data;
using QLBH.Core.Exceptions;
using QLBH.Core.Providers;

//using QLBanHang.Class;

namespace QLBanHang.Modules.HeThong
{
    public interface IfrmLoginTestView
    {
        void TestLogin(string username, string pass);
    }

    public partial class frmLogin : DevExpress.XtraEditors.XtraForm, IfrmLoginTestView
    {
        Form mainForm = null;
        public bool ClosedByTimeOut;
        private bool loginSuccess;
        private Thread checkTimeOutThread;
        public frmLogin()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            lastTimeShow = DateTime.Now;
            checkTimeOutThread = new Thread(CheckTimeOut);
            checkTimeOutThread.Start();
        }

        public frmLogin(string username)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            txtTenDangNhap.Text = username;
            lastTimeShow = DateTime.Now;
            checkTimeOutThread = new Thread(CheckTimeOut);
            checkTimeOutThread.Start();
        }

        public frmLogin(Form frm)
        {
            InitializeComponent();
            mainForm = frm;
            Common.LoadStyle(this);
            lastTimeShow = DateTime.Now;
            checkTimeOutThread = new Thread(CheckTimeOut);
            checkTimeOutThread.Start();
        }

        private DateTime lastTimeShow;
        private void CheckTimeOut()
        {
            while (!ClosedByTimeOut && !loginSuccess)
            {
                if (lastTimeShow.AddMinutes(Declare.EXIT_TIMEOUT - Declare.LOGIN_TIMEOUT) < DateTime.Now)
                {
                    ConnectionUtil.Instance.IsTimeOutApp = true;

                    //for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                    //{
                    //    Application.OpenForms[i].Close();
                    //}

                    ConnectionUtil.Instance.CloseConnections();

                    //Declare.Authenticating = 0;

                    ClosedByTimeOut = true;

                    //Application.Exit();
                    
                    if (Process.GetCurrentProcess().MainModule.ModuleName == "QLBanHang.exe")

                        Invoke((MethodInvoker)
                               delegate
                                   {
                                       this.DialogResult = DialogResult.Ignore;
                                   });
                    break;
                }
                //Debug.Print("{0}: Running check time out from frmLogin", DateTime.Now);
                Thread.CurrentThread.Join(1000);
            }
        }

        public bool IsCompletedTestUnit;
        public void TestLogin(string username, string pass)
        {
            try
            {
                Debug.Print(Process.GetCurrentProcess().MainModule.ModuleName);
                IsCompletedTestUnit = false;
                txtTenDangNhap.Text = username;
                txtMatKhau.Text = pass;
                LoginApp();
                IsCompletedTestUnit = true;
            }
            catch (Exception)
            {
                IsCompletedTestUnit = true;
                throw;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            if (!String.IsNullOrEmpty(txtTenDangNhap.Text)) txtMatKhau.Focus();
            //this.cboCaBanHang.SelectedIndex = 0;
        }

        private void cmdHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
            ClosedByTimeOut = true;

        }

        private void cmdDangNhap_Click(object sender, EventArgs e)
        {
            //if (cboCaBanHang.SelectedIndex == 0)
            //{
            //    MessageBox.Show("Chọn ca làm việc!");
            //    return;
            //}

            //chuyển sang viết try catch để đưa ra các thông báo
            try
            {
                //ConnectionUtil.Instance.IsUAT = chkUAT.Checked;
                LoginApp();

                CommonProvider.Instance.LogClientInfo();

                var userInfo = ((NguoiDungInfor) Declare.USER_INFOR);

                Declare.SYSDATE = CommonProvider.Instance.GetSysDate();

                //check xem co phai doi mat khau luon khong?
                if (userInfo.ChangeOnNext)
                {
                    MessageBox.Show("Đây là mật khẩu chỉ được sử dụng lần đầu. Bạn phải đổi mật khẩu khác!");

                    while (new frmHT_ChangePass().ShowDialog() != DialogResult.OK)
                    {
                        MessageBox.Show("Đây là mật khẩu chỉ được sử dụng lần đầu. Bạn phải đổi mật khẩu khác!");
                    }
                }

                if (userInfo.ThoiGianApDung > 0)
                {
                    //check xem mat khau da het thoi gian ap dung chua
                    if (userInfo.NgayTaoMatKhau.Date.AddDays(userInfo.ThoiGianApDung) < Declare.SYSDATE.Date)
                    {
                        MessageBox.Show("Mật khẩu này đã hết hạn sử dụng. Bạn phải đổi mật khẩu khác!");

                        while (new frmHT_ChangePass().ShowDialog() != DialogResult.OK)
                        {
                            MessageBox.Show("Mật khẩu này đã hết hạn sử dụng. Bạn phải đổi mật khẩu khác!");
                        }
                    }
                    //canh bao mat khau sap het thoi gian ap dung
                    else if (Convert.ToInt32(Declare.SYSDATE.Date.Subtract(userInfo.NgayTaoMatKhau.Date).TotalDays) + 7 > userInfo.ThoiGianApDung)
                    {
                        if (MessageBox.Show(String.Format("Mật khẩu này chỉ còn hạn sử dụng trong vòng {0} ngày nữa. Bạn có muốn đổi mật khẩu khác không?",
                            userInfo.ThoiGianApDung - Convert.ToInt32(Declare.SYSDATE.Date.Subtract(userInfo.NgayTaoMatKhau.Date).TotalDays)), "Cảnh báo",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            new frmHT_ChangePass().ShowDialog();
                        }
                    }                    
                }

                loginSuccess = true;

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            catch (ManagedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                EventLogProvider.Instance.WriteOfflineLog(ex.ToString(), "Login");
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }

        private void LoginApp()
        {
            if (Common.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                txtTenDangNhap.Select();
                
                //Không dùng MessageBox để chạy unit test mượt hơn
                //MessageBox.Show(Declare.msgLogin_InputUserName, Declare.titleNotice,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                //return;
                throw new ManagedException(Declare.msgLogin_InputUserName, false);
            }

            string userName = this.txtTenDangNhap.Text.Trim().Replace("or", "").Replace("--", "").Replace("'", "");
            string passWord = txtMatKhau.Text.Trim();
            NguoiDungInfor user;

            if (userName.ToLower().Equals("admin"))// && (txtMatKhau.Text == Password.CreateSystemPassword()))
            {
                ClosedByTimeOut = true;
                loginSuccess = false;
                this.Close();
                return;

                user = new NguoiDungInfor();
                user.TenDangNhap = userName;
                user.MatKhau = Password.CreateSystemPassword();
                user.Salt = "";
                user.TenChucVu = "Quản trị";
                user.Status = 1;
                user.SupperUser = 1;
                Declare.USER_INFOR = user;

                Declare.LogIn = 2;//dang nhap thanh cong
                //this.DialogResult = DialogResult.OK;

                //this.Close();
            }
            else
            {
                try
                {
                    user = NguoiDungDataProvider.GetNguoiDungInfo(userName);
                    if (user != null && user.SuDung)
                    {
                        if (Password.IsCorrectPassword(user.MatKhau, passWord, user.Salt))
                        {
                            EventLogProvider.Instance.UserName = userName;

                            if (Declare.MULTI_USER_SESSION || (!Declare.MULTI_USER_SESSION && user.Status == 0))
                            {
                                user.Status = 1;
                                NguoiDungDataProvider.GetChucNangUser(user);//load danh muc cac quyen cua user
                                NguoiDungDataProvider.GetKhoUser(user);//load danh sach kho cua user
                                NguoiDungDataProvider.GetNganhHangUser(user);//load nganh hang nguoi dung
                                NguoiDungDataProvider.GetHangSXUser(user);//load nganh hang nguoi dung
                                //NguoiDungDataProvider.UpdateUserStatus(user);//cap nhat trang thai user dang login
                                /*string sql = "Update tbl_DM_NguoiDung Set Status = " + user.Status +
                                             " Where IdNguoiDung = " + user.IdNguoiDung;
                                GtidCommand SqlComm = new GtidCommand(sql, ConnectionUtil.Instance.GetConnection());
                                SqlComm.CommandType = CommandType.Text;
                                SqlComm.ExecuteNonQuery();*/
                                Declare.UserId = user.IdNguoiDung;
                                Declare.UserName = user.TenDangNhap;
                                Declare.IdNhanVien = user.IdNhanVien;
                                Declare.USER_INFOR = user;
                                Declare.LogIn = 2;//đăng nhập thành công
                                QLBHUtils.IsShowNotify = user.ShowNotify == 1 ? true : false;//cho phep show notify o taskbar hay khong
                                //this.DialogResult = DialogResult.OK;
                                //this.Close();

                                //lay cac tham so khac
                                try
                                {
                                    string str = String.Empty;
                                    str = "Select distinct tt.TenTrungTam, tt.MaTrungTam, IDKHODEFAULT, kh.TenKho, nd.ChonKho, nd.FormMacDinh, kh.OtherTrungTam, nv.IdTrungTamHachToan, " +
                                                  " nd.IdTrungTamDefault, nd.IdLoaiDTDefault, nd.IdDoiTuongDefault,tt.DienThoai as DienThoaiTrungTam, nv.IdQuanLyTrucTiep, " +
                                                  " dt.TenDoiTuong, nd.IdTruongCaDefault, tc.HoTen as TenTruongCa, nd.IdThuNganDefault, tn.HoTen as TenThuNgan, nd.IdThoiHanTTDefault " +
                                                  " From tbl_DM_NguoiDung nd left outer join tbl_DM_Kho kh on IDKHODEFAULT=kh.IdKho " +
                                                  " left outer join tbl_DM_NhanVien nv on nd.IdNhanVien=nv.IdNhanVien " +
                                                  " left outer join tbl_DM_DoiTuong dt on nd.IdDoiTuongDefault=dt.IdDoiTuong " +
                                                  " left outer join tbl_DM_TrungTam tt on nd.IdTrungTamDefault=tt.IdTrungTam " +
                                                  " left outer join tbl_DM_NhanVien tc on nd.IdTruongCaDefault=tc.IdNhanVien " +
                                                  " left outer join tbl_DM_NhanVien tn on nd.IdThuNganDefault=tn.IdNhanVien " +
                                                  " Where nd.IdNguoiDung = " + user.IdNguoiDung;
                                    DataTable dt = DBTools.getData("tmp", str).Tables["tmp"];
                                    //GtidCommand gtidCommand = new GtidCommand("GetThamSoNguoiDung", ConnectionUtil.Instance.GetConnection());
                                    //gtidCommand.CommandType = CommandType.StoredProcedure;
                                    //gtidCommand.Parameters.AddWithValue("@p_IdNguoiDung", user.IdNguoiDung);
                                    //DataTable dt = DBTools.getData(gtidCommand, "tmp").Tables["tmp"];
                                    if (dt != null && dt.Rows.Count > 0)
                                    {
                                        Declare.IdTrungTamHachToan = dt.Rows[0]["IdTrungTamHachToan"] != DBNull.Value ? Common.IntValue(dt.Rows[0]["IdTrungTamHachToan"]) : 0;
                                        Declare.IdTrungTam = dt.Rows[0]["IdTrungTamDefault"] != DBNull.Value ? Common.IntValue(dt.Rows[0]["IdTrungTamDefault"]) : 0;
                                        Declare.TenTrungTam = dt.Rows[0]["TenTrungTam"] != DBNull.Value ? dt.Rows[0]["TenTrungTam"].ToString() : "";
                                        Declare.MaTrungTam = dt.Rows[0]["MaTrungTam"] != DBNull.Value ? dt.Rows[0]["MaTrungTam"].ToString() : "";
                                        Declare.IdKho = dt.Rows[0]["IdKhoDefault"] != DBNull.Value ? Common.IntValue(dt.Rows[0]["IdKhoDefault"]) : 0;
                                        Declare.TenKho = dt.Rows[0]["TenKho"] != DBNull.Value ? dt.Rows[0]["TenKho"].ToString() : "";
                                        Declare.IdLoaiKhachHang = dt.Rows[0]["IdLoaiDTDefault"] != DBNull.Value ? Common.IntValue(dt.Rows[0]["IdLoaiDTDefault"]) : 0;
                                        Declare.IdKHMacDinh = dt.Rows[0]["IdDoiTuongDefault"] != DBNull.Value ? Common.IntValue(dt.Rows[0]["IdDoiTuongDefault"]) : 0;
                                        Declare.TenKhachHang = dt.Rows[0]["TenDoiTuong"] != DBNull.Value ? dt.Rows[0]["TenDoiTuong"].ToString() : "";
                                        Declare.IdTruongCa = dt.Rows[0]["IdTruongCaDefault"] != DBNull.Value ? Common.IntValue(dt.Rows[0]["IdTruongCaDefault"]) : 0;
                                        Declare.IdThuNgan = dt.Rows[0]["IdThuNganDefault"] != DBNull.Value ? Common.IntValue(dt.Rows[0]["IdThuNganDefault"]) : 0;
                                        Declare.IdQuanLyTrucTiep = dt.Rows[0]["IdQuanLyTrucTiep"] != DBNull.Value ? Common.IntValue(dt.Rows[0]["IdQuanLyTrucTiep"]) : -1;
                                        Declare.IdThoiHanThanhToan = dt.Rows[0]["IdThoiHanTTDefault"] != DBNull.Value ? Common.IntValue(dt.Rows[0]["IdThoiHanTTDefault"]) : 0;
                                        Declare.DienThoaiTrungTam = dt.Rows[0]["DienThoaiTrungTam"] != DBNull.Value ? dt.Rows[0]["DienThoaiTrungTam"].ToString() : "";
                                        //Declare.MAVUNG = dt.Rows[0]["MaVung"] != DBNull.Value ? dt.Rows[0]["MaVung"].ToString() : "01";                                        
                                        //Declare.NgayKhoaSo = dt.Rows[0]["NgayKhoaSo"] != DBNull.Value ? (DateTime)dt.Rows[0]["NgayKhoaSo"] : System.DateTime.Now.AddDays(-1);
                                        //Declare.NgayDuDau = dt.Rows[0]["NgayDuDau"] != DBNull.Value ? (DateTime)dt.Rows[0]["NgayDuDau"] : System.DateTime.Now;// DateTime.Parse(SqlDateTime.MinValue.ToString());
                                        //Declare.InHoaDon = dt.Rows[0]["InhoaDon"] != DBNull.Value ? Equals(dt.Rows[0]["InhoaDon"], 1) : false;
                                        //Declare.InBill = dt.Rows[0]["InBill"] != DBNull.Value ? Equals(dt.Rows[0]["InBill"], 1) : false;
                                        //Declare.InPhieuThu = dt.Rows[0]["InPhieuThu"] != DBNull.Value ? Equals(dt.Rows[0]["InPhieuThu"], 1) : false;
                                        Declare.HienThiChonKho = dt.Rows[0]["ChonKho"] != DBNull.Value ? Equals(dt.Rows[0]["ChonKho"], 1) : false;
                                        Declare.GiaoDienMacDinh = dt.Rows[0]["FormMacDinh"] != DBNull.Value ? dt.Rows[0]["FormMacDinh"].ToString() : "";
                                        //Declare.IdTrungTam = Common.IntValue(dt.Rows[0]["IdTrungTam"]);
                                        Declare.LstOthersTrungTam = dt.Rows[0]["OtherTrungTam"] != DBNull.Value ? dt.Rows[0]["OtherTrungTam"].ToString() : "";

                                        DateTime now = CommonProvider.Instance.GetSysDate();
                                        Declare.NgayLamViec = now.AddDays(-now.Day + 1);
                                    }
                                    str = "Select th.IdTienTe, tt.KyHieu, th.TyLeGia, th.ChuanMaVach,th.MaxLength ";
                                    str += " From tbl_ThongTin th inner join tbl_DM_TienTe tt on tt.IdTienTe = th.IdTienTe";
                                    dt = DBTools.getData("tmp", str).Tables["tmp"];
                                    if (dt != null && dt.Rows.Count > 0)
                                    {
                                        Declare.IdTienTe = Common.IntValue(dt.Rows[0]["IdTienTe"]);
                                        if (Declare.IdTienTe == 0) Declare.IdTienTe = 1;
                                        Declare.KyHieuTienTe = dt.Rows[0]["KyHieu"].ToString();
                                        Declare.TyLeChenhGiaNhap_Xuat = Common.IntValue(dt.Rows[0]["TyLeGia"]);
                                        Declare.CHUAN_MAVACH = dt.Rows[0]["ChuanMaVach"].ToString();
                                        Declare.LENGH_HT = Common.IntValue(dt.Rows[0]["MaxLength"]);
                                        Declare.LENGH_NOTE = Common.IntValue(dt.Rows[0]["MaxLength"]) * 2 + 30;
                                    }
                                    //tham so ban hang
                                    str = "Select * From tbl_Thamso_Banhang";
                                    dt = DBTools.getData("tmp", str).Tables["tmp"];
                                    if (dt != null && dt.Rows.Count > 0)
                                    {
                                        if (dt.Rows[0]["LstNotInHoaDon".ToUpper()] != DBNull.Value) Declare.LstNotInHoaDon = dt.Rows[0]["LstNotInHoaDon".ToUpper()].ToString();
                                        if (dt.Rows[0]["LstSuaGiaBan"] != DBNull.Value) Declare.LstSuaGiaBan = dt.Rows[0]["LstSuaGiaBan"].ToString();
                                        if (dt.Rows[0]["LstSuaCKhauKoLenODT"] != DBNull.Value) Declare.LstSuaCKhauKoLenODT = dt.Rows[0]["LstSuaCKhauKoLenODT"].ToString();
                                        if (dt.Rows[0]["LstSuaCKhauKoLenOD"] != DBNull.Value) Declare.LstSuaCKhauKoLenOD = dt.Rows[0]["LstSuaCKhauKoLenOD"].ToString();
                                        if (dt.Rows[0]["LstKMDuocBanOD"] != DBNull.Value) Declare.LstKMDuocBanOD = dt.Rows[0]["LstKMDuocBanOD"].ToString();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                }
                            }
                            else
                            {
                                this.txtTenDangNhap.Focus();
                                this.txtTenDangNhap.SelectAll();
                                throw new ManagedException(Declare.msgLogin_UserHasLoggedIn);
                            }
                        }
                        else
                        {
                            txtMatKhau.Select();
                            txtMatKhau.SelectAll();
                            throw new ManagedException(Declare.msgLogin_WrongPassword);
                        }

                    }
                    else
                    {
                        txtTenDangNhap.Select();
                        txtTenDangNhap.SelectAll();
                        throw new ManagedException(Declare.msgLogin_UserNotExist);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            
            //ClosedByTimeOut = true;
            loginSuccess = true;

            //TuanLM modify 29/03/08
            if (Declare.LogIn!=0)
                this.Close();
            else
                Application.Exit();
            //~TuanLM modify 29/03/08
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmdDangNhap_Click(null, EventArgs.Empty);
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            txtMatKhau.SelectAll();
        }

        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            txtTenDangNhap.SelectAll();
        }

        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmdDangNhap_Click(null, EventArgs.Empty);
            }

        }
     }
}