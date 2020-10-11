using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using CrystalDecisions.Shared;
using System.Threading;
using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.BanHang;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.HeThong.Providers;
using QLBanHang.Modules.HeThong.Reports;
using QLBH.Common;
using QLBH.Core.Data;
using QLBH.Core.Form;

namespace QLBanHang.Modules.HeThong
{
    public partial class frm_GenMaVach : frmBCBase
    {
        private int SoHienTai = 0;
        private List<ItemInMaVachInfor> liSanPham = new List<ItemInMaVachInfor>();
        private List<MaVachInfor> liMaVach = new List<MaVachInfor>();

        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        public frm_GenMaVach()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        public frm_GenMaVach(List<ItemInMaVachInfor> liSanPham)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.liSanPham = liSanPham;
        }

        private void frm_BangGiaHienTai_Load(object sender, EventArgs e)
        {
            try
            {
                SinhMaVach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SinhMaVach()
        {
            liMaVach = new List<MaVachInfor>();
            foreach (ItemInMaVachInfor sp in liSanPham)
            {                
                if (sp.TrungMaVach == 1)//sinh trung ma vach
                {
                    List<MaVachInfor> mvs = UtilFunctions.GenTrungMaVach2(sp);
                    liMaVach.AddRange(mvs);
                }
                else//sinh khong trung ma vach
                {
                    List<MaVachInfor> mvs = UtilFunctions.GenKhongTrungMaVach(sp);
                    liMaVach.AddRange(mvs);                    
                }
            }
            gSanPham.DataSource = null;

            gSanPham.DataSource = new BindingList<MaVachInfor>(liMaVach);
        }

        private void tlsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tlsPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn tạo mã vạch này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    frmProgress.Instance.Description = "Đang cập nhật dữ liệu"; 
                    frmProgress.Instance.MaxValue = liSanPham.Count;
                    frmProgress.Instance.Value = 0;
                    frmProgress.Instance.DoWork(CapNhatMaVach);


                    //sinh file excel
                    Common.DevExport2Excel(gvSanPham, "Barcode");

                    //string content =
                    //    getSmallSerial(DateTime.Now.ToString("yyyy/MM/dd"), "0123456789", "01234",
                    //                   "163045831239BHF152223345", 0) +
                    //    getSmallSerial(DateTime.Now.ToString("yyyy/MM/dd"), "0123456789", "01234",
                    //                   "163045831239BHF152223345", 1)+
                    //    getSmallSerial(DateTime.Now.ToString("yyyy/MM/dd"), "0123456789", "01234",
                    //                   "163045831239BHF152223345", 2) +
                    //    getSmallSerial(DateTime.Now.ToString("yyyy/MM/dd"), "0123456789", "01234",
                    //                   "163045831239BHF152223345", 3) +
                    //    getSmallSerial(DateTime.Now.ToString("yyyy/MM/dd"), "0123456789", "01234",
                    //                   "163045831239BHF152223345", 4) +
                    //    getSmallSerial(DateTime.Now.ToString("yyyy/MM/dd"), "0123456789", "01234",
                    //                   "163045831239BHF152223345", 5);

                    //content = getContent(content);

                    //var bytes = Encoding.UTF8.GetBytes(content.ToCharArray());

                    //Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    //clientSocket.NoDelay = true;

                    //IPAddress ip = IPAddress.Parse("127.0.0.1");
                    //IPEndPoint ipep = new IPEndPoint(ip, 9100);
                    //clientSocket.Connect(ipep);
                    //clientSocket.Send(bytes);
                    //clientSocket.Close();

                }
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi thực hiện\n" + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi thực hiện", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void CapNhatMaVach()
        {
            string err = "";
            string sql = "";
            //cap nhat ma vach
            foreach (ItemInMaVachInfor sp in liSanPham)
            {
                if (sp.TrungMaVach != 1)
                {
                    try
                    {
                        //xoa du lieu cu
                        string maTrungTam =
                            DBTools.getValue(String.Format("Select MaTrungTam from tbl_DM_TrungTam where IdTrungTam = {0} and rownum=1",
                                                           sp.IdTrungTam));
                        sql =
                            String.Format(
                                "Delete from tbl_DM_MaVach where MaSanPham = '{0}' and MaTrungTam = '{1}'", sp.MaSanPham, maTrungTam);
                        SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text, sql);

                        //them du lieu moi
                        sql =
                            String.Format(
                                "Insert into tbl_DM_MaVach Values('{0}', '{1}', sysdate, {2}, '{3}', sysdate, '{4}')",
                                maTrungTam, sp.MaSanPham, sp.SoHienTai, nguoiDung.TenDangNhap, Declare.TenMay);
                        SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(), CommandType.Text, sql);

                    }
                    catch (Exception ex)
                    {
                        err += String.Format("Lỗi thao tác [{0}-{1}: {2}]\nsql:{3}", sp.IdTrungTam, sp.MaSanPham, ex.ToString(), sql);
                    }
                }
                frmProgress.Instance.Value += 1;
            }
            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = String.Format("Cập nhật xong mã vạch của {0} sản phẩm", selector.selection.Count);

            if (!String.IsNullOrEmpty(err))
                frmMsgBox.Instance.ShowMessage(err);
        }

        private string getContent(string content)
        {
            return String.Format(PRINTCMD, content);
        }

        private string getSmallSerial(string date, string model, string lastSegmentItemCode, string serial, int pos)
        {
            return String.Format(smallserial[pos], date, model, lastSegmentItemCode, serial);
        }

        private const string PRINTCMD = @"^H15\r\n^S2\r\n^Q26,3,7\r\n^W106\r\n^L\r\n^R0\r\n{0}\r\nE";

        //0:date 2015/01/01
        //1:model 0G23456789B
        //2:last segment item code 52223
        //3: serial 163045831239BHF152223345
        private readonly string[] smallserial =
            new[]
                {
                    @"AT,15,0,7,16,1,0,0,1,{0}-{1}\r\nAT,215,0,7,16,1,0,0,1,{2}\r\nBP,15,20,1,5,3,0,0,{3}\r\nAT,15,45,7,20,1,0,0,1,{3}\r\n",
                    @"AT,15,77,7,16,1,0,0,1,{0}-{1}\r\nAT,215,77,7,16,1,0,0,1,{2}\r\nBP,15,97,1,5,3,0,0,{3}\r\nAT,15,122,7,20,1,0,0,1,{3}\r\n",
                    @"AT,295,0,7,16,1,0,0,1,{0}-{1}\r\nAT,495,0,7,16,1,0,0,1,{2}\r\nBP,295,20,1,5,3,0,0,{3}\r\nAT,295,45,7,20,1,0,0,1,{3}\r\n",
                    @"AT,295,77,7,16,1,0,0,1,{0}-{1}\r\nAT,495,77,7,16,1,0,0,1,{2}\r\nBP,295,97,1,5,3,0,0,{3}\r\nAT,295,122,7,20,1,0,0,1,{3}\r\n",
                    @"AT,575,0,7,16,1,0,0,1,{0}-{1}\r\nAT,775,0,7,16,1,0,0,1,{2}\r\nBP,575,20,1,5,3,0,0,{3}\r\nAT,575,45,7,20,1,0,0,1,{3}\r\n",
                    @"AT,575,77,7,16,1,0,0,1,{0}-{1}\r\nAT,775,77,7,16,1,0,0,1,{2}\r\nBP,575,97,1,5,3,0,0,{3}\r\nAT,575,122,7,20,1,0,0,1,{3}\r\n"
                };

    }
}