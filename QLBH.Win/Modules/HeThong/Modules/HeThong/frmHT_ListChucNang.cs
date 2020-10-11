using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QLBH.Common;
using QLBanHang.Modules.HeThong.Providers;
using DevExpress.XtraBars.Ribbon;
using QLBanHang.Modules.HeThong.Infors;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmHT_ListChucNang : DevExpress.XtraEditors.XtraForm
    {
        private RibbonControl _ribbon;
        private objGridMarkSelection selector = new objGridMarkSelection();

        public frmHT_ListChucNang()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        public frmHT_ListChucNang(RibbonControl ribbon)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this._ribbon = ribbon;
        }

        private void frmHT_ListChucNang_Load(object sender, EventArgs e)
        {
            LoadAllChucNang();
        }
        private void LoadAllChucNang()
        {
            gChucNang.DataSource = ChucNangDataProvider.LoadAll(); ;
            gvChucNang.Columns["ParentName"].GroupIndex = 0;
            gvChucNang.ExpandAllGroups();
            selector.View = gvChucNang;
            selector.CheckMarkColumn.VisibleIndex = 0;
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            gChucNang.DataSource = ChucNangDataProvider.Search(txtFilterHanhDong.Text);
            gvChucNang.Columns["ParentName"].GroupIndex = 0;
            gvChucNang.ExpandAllGroups();
            selector.View = gvChucNang;
            selector.CheckMarkColumn.VisibleIndex = 0;

            txtFilterHanhDong.Focus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (selector.SelectedCount == 0)
                {
                    MessageBox.Show("Phải chọn ít nhất một chức năng để xóa!");
                    return;                    
                }
                if (MessageBox.Show("Bạn có chắc chắn xóa chức năng này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    for (int i = 0; i < selector.SelectedCount; i++)
                    {
                        ChucNangInfor chucNang = (ChucNangInfor) selector.GetSelectedRow(i);
                        ChucNangDataProvider.Delete(chucNang);
                    }
                    selector.ClearSelection();
                    gChucNang.DataSource = null;

                    LoadAllChucNang();
                    chkAll.Checked = false;
                }
            }
            catch { }
        }

        private void btnNapDL_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < this._ribbon.Pages.Count; k++)
            {
                RibbonPageGroupCollection pgColection = this._ribbon.Pages[k].Groups;

                string prID = this._ribbon.Pages[k].Name; // pgColection[k].Name.ToString();
                string prName = this._ribbon.Pages[k].Text;
                for (int j = 0; j < pgColection.Count; j++)
                {
                    if (pgColection[j].Name.Contains("_ck")) continue;//bỏ qua những group tên có dạng _ck
                    RibbonPageGroupItemLinkCollection colection = pgColection[j].ItemLinks;

                    for (int i = 0; i < colection.Count; i++)
                    {
                        if (colection[i].Item.Name.Contains("_ck")) continue;//bỏ qua những item tên có dạng _ck vì ko có trong bảng danh mục chức năng
                        ChucNangInfor objChucNang = new ChucNangInfor();
                        objChucNang.ParentId = prID;
                        objChucNang.ParentName = prName;
                        objChucNang.MaChucNang = colection[i].Item.Name;
                        objChucNang.TenChucNang = colection[i].Item.Caption;

                        ChucNangDataProvider.InsertIfNotExist(objChucNang);

                        if(colection[i].Item is BarSubItem)
                        {
                            LinksInfo linksInfo = ((BarSubItem) colection[i].Item).LinksPersistInfo;
                            for (int l = 0; l < linksInfo.Count; l++)
                            {
                                if(linksInfo[l].Item.Name.Contains("_ck")) continue;
                                ChucNangInfor objSubChucNang = new ChucNangInfor();
                                objSubChucNang.ParentId = objChucNang.MaChucNang;
                                objSubChucNang.ParentName = objChucNang.TenChucNang;
                                objSubChucNang.MaChucNang = linksInfo[l].Item.Name;
                                objSubChucNang.TenChucNang = linksInfo[l].Item.Caption;

                                ChucNangDataProvider.InsertIfNotExist(objSubChucNang);
                            }
                        }
                    }
                }

            }
            LoadAllChucNang();
            MessageBox.Show("Nạp dữ liệu thành công!");
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

        private void gtidButton1_Click(object sender, EventArgs e)
        {
            gChucNang.ShowPrintPreview();
        }
        
    }
}