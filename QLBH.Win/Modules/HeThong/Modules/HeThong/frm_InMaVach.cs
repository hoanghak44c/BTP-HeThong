using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using CrystalDecisions.Shared;
using System.Threading;
using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.HeThong.Providers;
using QLBanHang.Modules.HeThong.Reports;
using QLBH.Common;
using QLBH.Core.Form;

namespace QLBanHang.Modules.HeThong
{
    public partial class frm_InMaVach : frmBCBase
    {
        private List<ItemInMaVachInfor> liSanPham = new List<ItemInMaVachInfor>();
        private List<ItemInMaVachInfor> liTimKiem = new List<ItemInMaVachInfor>();

        private objGridMarkSelection selector = new objGridMarkSelection();
        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();
        private int SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
        private int SoLuongHienTai = 0;


        Utils ut = new Utils();
        public frm_InMaVach()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            rpt = new rpt_InMaVachSP();
        }
        public void LoadComboBoxPages(ComboBox cboPage)
        {
            string[] values = { "50", "100", "150", "200", "1000", "2000", "Tất cả" };
            cboPage.Items.Clear();
            for (int i = 0; i < values.Length; i++)
                cboPage.Items.Add(values[i]);
            cboPage.SelectedIndex = 0;
        }
        private void LoadNganhHang()
        {
            //int idNND = Common.Int2Bool(nguoiDung.SupperUser) ? -1 : nguoiDung.IdNhomNguoiDung;
            List<TimKiemItemInfo> liNganh = InMaVachDataProvider.GetAllItemsByType(-1, 1, -1, -1);//type=1: nganh hang
            liNganh.Insert(0, new TimKiemItemInfo()
            {
                Id = 0,
                Ma = "",
                Ten = "Tất cả"
            });
            lueNganhHang.Properties.DataSource = liNganh;
            lueNganhHang.Properties.DisplayMember = "Ten";
            lueNganhHang.Properties.ValueMember = "Ma";
        }
        private void frm_BangGiaHienTai_Load(object sender, EventArgs e)
        {
            try
            {
                LoadNganhHang();
                LoadComboBoxPages(cboPage);

                DMTrungTamInfor tt = DMTrungTamDataProvider.GetTrungTamByIdInfo(Declare.IdTrungTam);
                if (tt != null)
                {
                    bteTrungTam.Text = tt.TenTrungTam;
                    bteTrungTam.Tag = tt;
                }
                //TimKiemBangGia();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tlsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tlsPrint_Click(object sender, EventArgs e)
        {
            //printMaVach();
            try
            {
                ShowReport("Mã vạch sản phẩm");
            }
            catch (System.Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }

        private void frm_InMaVach_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F9 && tlsPrint.Enabled)
                    this.tlsPrint_Click(sender, e);
                else if (e.KeyCode == Keys.F12 && tlsClose.Enabled)
                    this.tlsClose_Click(sender, e);
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

        protected override object OnSetDataSource()
        {
            //Ghi du lieu can ghi vao bang tbl_Tmp_MaVach
            //this.Cursor = Cursors.WaitCursor;
            //string where = "";
            //bool isPrint = false;
            string sql = "";


            //in bao cao
            sql = "Select * from tbl_Tmp_MaVach";
            DataSet ds = ut.getDataSet(sql, "tbl_Tmp_MaVach");

            BarcodeLib.TYPE type = BarcodeLib.TYPE.CODE128;

            if (Declare.CHUAN_MAVACH.Equals("Code 128"))
                type = BarcodeLib.TYPE.CODE128;
            else if (Declare.CHUAN_MAVACH.Equals("Code 13"))
                type = BarcodeLib.TYPE.EAN13;

            BarcodeLib.Barcode barcode = new BarcodeLib.Barcode();
            barcode.IncludeLabel = true;

            ArrayList liSanPham = new ArrayList();
            liSanPham.AddRange(selector.selection);
            foreach (ItemInMaVachInfor item in liSanPham)
            {
                if (item.SoLuong > 0)
                {
                    bool trungMaVach = Common.Int2Bool(item.TrungMaVach);
                    string mavach = "";
                    int nRow = item.SoLuong / 5;
                    int nAdd = item.SoLuong % 5;
                    int count = 0;
                    for (int i = 1; i <= nRow; i++)
                    {
                        DataRow dr = ds.Tables[0].NewRow();
                        dr["IdSanPham"] = item.IdSanPham;
                        dr["MaSanPham"] = item.MaSanPham;
                        dr["TenSanPham"] = item.TenSanPham;
                        dr["TenVietTat"] = item.TenVietTat;
                        dr["GiaBan"] = item.DonGia;

                        for (int j = 1; j <= 5; j++)
                        {
                            mavach = trungMaVach ? TaoMaVach(item.MaSanPham, 0) : TaoMaVach(item.MaSanPham, ++count);
                            dr["MaVach" + j] = mavach;
                            Image img = barcode.Encode(type, mavach);
                            dr["Barcode" + j] = Common.imageToByteArray(img);
                        }
                        ds.Tables[0].Rows.Add(dr);
                    }

                    if (nAdd > 0)
                    {
                        DataRow dr = ds.Tables[0].NewRow();
                        dr["IdSanPham"] = item.IdSanPham;
                        dr["MaSanPham"] = item.MaSanPham;
                        dr["TenSanPham"] = item.TenSanPham;
                        dr["TenVietTat"] = item.TenVietTat;
                        dr["GiaBan"] = item.DonGia;

                        for (int j = 1; j <= nAdd; j++)
                        {
                            mavach = trungMaVach ? TaoMaVach(item.MaSanPham, 0) : TaoMaVach(item.MaSanPham, ++count);

                            dr["MaVach" + j] = mavach;
                            Image img = barcode.Encode(type, mavach);
                            dr["Barcode" + j] = Common.imageToByteArray(img);
                        }
                        ds.Tables[0].Rows.Add(dr);
                    }
                }
            } 
            return ds;
        }
        //private void printMaVach()
        protected override void OnLoadReport()
        {
            try {
                base.SetDataSource();
                //Create a report object
                //and set its data source with the DataSet
                //rpt_InMaVachSanPham rpt = new rpt_InMaVachSanPham();
                //rpt.SetDataSource(ds);
                //frm_rpt frm = new frm_rpt(rpt);
                //frm.Show();

                //xoa du lieu
                //sql = "Delete From tbl_Tmp_MaVach";
                //DBTools.ExecuteQuery(sql, CommandType.Text);
                //this.Cursor = Cursors.Default;
            }
            catch (System.Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }

        private string TaoMaVach(string strCode, int stt)
        {
            DateTime d = DateTime.Now;
            string sday = "";
            //sday += (d.Day < 10) ? ("0" + d.Day) : (d.Day + "");
            //sday += (d.Month < 10) ? ("0" + d.Month) : (d.Month + "");
            //sday += d.Year.ToString().Substring(2);

            string rs = strCode + sday;

            if (stt != 0)
            {
                string serie = stt + "";
                string tmp = serie;
                for (int i = 0; i < (Declare.MAXMAVACH_SANPHAM - tmp.Length); i++)
                    serie = "0" + serie;
                rs += serie;
            }
            return rs;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            SoLuongHienTai = 0;
            SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            liSanPham = new List<ItemInMaVachInfor>();

            TimKiemBangGia();
        }

        private void LoadDuLieu()
        {
            int soBatDau = SoLuongHienTai;
            int soKetThuc = SoLuongTimKiem != -1 ? SoLuongHienTai + SoLuongTimKiem : -1;
            int idTrungTam = bteTrungTam.Tag != null
                                 ? ((DMTrungTamInfor)bteTrungTam.Tag).IdTrungTam
                                 : Declare.IdTrungTam;
            List<ItemInMaVachInfor> liTimKiem = InMaVachDataProvider.GetListAllByTrungTamPg(idTrungTam, txtSanPham.Text.Trim(), lueNganhHang.EditValue.ToString(), soBatDau, soKetThuc);
            liSanPham.AddRange(liTimKiem);

            //liChungTuBanHang = BanHangDataProvider.Instance.TimKiemChungTu(filter);

            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.IsCompleted = true;
            frmProgress.Instance.Description = "Đã xong";
        }

        private void TimKiemBangGia()
        {
            try
            {
                frmProgress.Instance.Description = Common.MsgProgress(SoLuongTimKiem);
                frmProgress.Instance.MaxValue = SoLuongTimKiem;
                frmProgress.Instance.Value = 0;
                frmProgress.Instance.DoWork(LoadDuLieu);

                gSanPham.DataSource = new BindingList<ItemInMaVachInfor>(liSanPham); 
                //gvListChungTu.Columns["ParentName"].GroupIndex = 0;
                gvSanPham.ExpandAllGroups();
                selector.View = gvSanPham;
                selector.CheckMarkColumn.Fixed = FixedStyle.Left;
                selector.CheckMarkColumn.VisibleIndex = 0;
                ((BindingList<ItemInMaVachInfor>)gSanPham.DataSource).ResetBindings();
                SoLuongHienTai = liSanPham.Count;
                selector.ClearSelection();

                this.groupBox4.Text = "Danh sách sản phẩm (" + liSanPham.Count + " sản phẩm)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bteTrungTam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteTrungTam_ButtonClick(sender, e, bteTrungTam, nguoiDung.IdNhanVien);
        }

        private void bteTrungTam_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteTrungTam_KeyDown(sender, e, bteTrungTam, nguoiDung.IdNhanVien);
        }

        private void bteTrungTam_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteTrungTam);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SoLuongTimKiem = Common.IntValue(cboPage.SelectedItem);
            if (SoLuongTimKiem == 0)
                SoLuongTimKiem = Declare.SOLUONG_TIMKIEM;
            if (cboPage.SelectedItem.Equals("Tất cả"))
            {
                if (MessageBox.Show(Declare.msgLoadDataWrn, "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SoLuongTimKiem = -1;
                }
                else
                {
                    return;
                }
            }

            TimKiemBangGia();
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            int idTrungTam = bteTrungTam.Tag != null
                                 ? ((DMTrungTamInfor) bteTrungTam.Tag).IdTrungTam
                                 : Declare.IdTrungTam;
            if (selector.selection.Count > 0)
            {
                List<ItemInMaVachInfor> liSanPham = new List<ItemInMaVachInfor>();
                foreach (ItemInMaVachInfor sp in selector.selection)
                {
                    sp.IdTrungTam = idTrungTam;
                    liSanPham.Add(sp);                    
                }
                frm_GenMaVach frm = new frm_GenMaVach(liSanPham);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa chọn sản phẩm nào để sinh mã vạch");
            }
       }
    }
}