using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using QLBH.Common;
using QLBanHang.Modules.HeThong.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmHT_AddPheDuyetGiaBan : DevExpress.XtraEditors.XtraForm
    {
        #region Decalre .....

        public PheDuyetGiaBanInfor PheDuyetGiaBan;
        List<NhomNguoiDungInfor> liNhomNguoiDung = new List<NhomNguoiDungInfor>();
        #endregion

        public frmHT_AddPheDuyetGiaBan()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        public frmHT_AddPheDuyetGiaBan(PheDuyetGiaBanInfor qpPheDuyet)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            PheDuyetGiaBan = qpPheDuyet;
        }

        private void frmHT_AddNguoiDung_Load(object sender, EventArgs e)
        {
            LoadNhomNguoiDung();
            if (PheDuyetGiaBan != null)
            {
                txtMaNganhHang.Text = PheDuyetGiaBan.MaNganhHang;
                txtTenNganhHang.Text = PheDuyetGiaBan.TenNganhHang;
                cboNhomNguoiDung.SelectedValue = PheDuyetGiaBan.IdNhomNguoiDung;
                txtDungSaiMin.Text = PheDuyetGiaBan.DungSaiMIN.ToString();
                txtDungSaiMax.Text = PheDuyetGiaBan.DungSaiMAX.ToString();
                nudDoUuTien.Value = PheDuyetGiaBan.DoUuTien;
            }
        }

        private void LoadNhomNguoiDung()
        {
            liNhomNguoiDung = NhomNguoiDungDataProvider.LoadAll();
            cboNhomNguoiDung.DataSource = liNhomNguoiDung;
            cboNhomNguoiDung.DisplayMember = "TenNhom";
            cboNhomNguoiDung.ValueMember = "IdNhomNguoiDung";
            cboNhomNguoiDung.SelectedIndex = -1; 

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //if (Common.IntValue(txtDungSaiMin.Text.Trim())>=Common.IntValue(txtDungSaiMax.Text.Trim()))
                //{
                //    MessageBox.Show("Dung sai Min phải nhỏ hơn Dung sai Max!");
                //    txtDungSaiMin.Focus();
                //    return;
                //}

                if (Common.IntValue(txtDungSaiMin.Text.Trim())<0)
                {
                    MessageBox.Show("Dung sai Min phải lớn hơn 0!");
                    txtDungSaiMin.Focus();
                    return;
                }
                if (Common.IntValue(txtDungSaiMax.Text.Trim()) < 0)
                {
                    MessageBox.Show("Dung sai Min phải lớn hơn 0!");
                    txtDungSaiMin.Focus();
                    return;
                }
                if (cboNhomNguoiDung.SelectedIndex < 0)
                {
                    MessageBox.Show("Phải chọn nhóm người dùng!");
                    txtDungSaiMin.Focus();
                    return;
                }

                PheDuyetGiaBan.IdNhomNguoiDung = liNhomNguoiDung[cboNhomNguoiDung.SelectedIndex].IdNhomNguoiDung;
                PheDuyetGiaBan.NhomNguoiDung = liNhomNguoiDung[cboNhomNguoiDung.SelectedIndex].TenNhom;
                PheDuyetGiaBan.DungSaiMIN = Common.IntValue(txtDungSaiMin.Text.Trim());
                PheDuyetGiaBan.DungSaiMAX = Common.IntValue(txtDungSaiMax.Text.Trim());
                PheDuyetGiaBan.DoUuTien = Common.IntValue(nudDoUuTien.Value);

                this.DialogResult = DialogResult.OK;
            }
            catch 
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ. Vui lòng kiểm tra lại");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}