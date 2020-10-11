using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.Modules.HeThong.Infors;
using QLBanHang.Modules.HeThong.Providers;
using QLBH.Common.Providers;
using QLBH.Core.Form;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmHT_LockChungTuManager : DevExpress.XtraEditors.XtraForm
    {
        private List<ChungTuLockInfor> lstDataSource;

        public frmHT_LockChungTuManager()
        {
            InitializeComponent();
            lstDataSource = new List<ChungTuLockInfor>();
            dgvList.DataSource = lstDataSource;
        }

        private void LoadDuLieu()
        {
            frmProgress.Instance.Text = Text;
            frmProgress.Instance.MaxValue = 100;
            frmProgress.Instance.Value = 0;
            frmProgress.Instance.Description = "Đang nạp dữ liệu ...";
            lstDataSource.Clear();
            lstDataSource.AddRange(ChungTuLockProvider.Instance.GetListChungTuLockInfor());
            dgvList.RefreshDataSource();
            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
            frmProgress.Instance.Description = "Đã xong";
            frmProgress.Instance.IsCompleted = true;
        }

        private void tsbNapDuLieu_Click(object sender, EventArgs e)
        {
            frmProgress.Instance.DoWork(LoadDuLieu);
        }

        private void tsbUnLock_Click(object sender, EventArgs e)
        {
            ChungTuLockInfor lockInfor = (ChungTuLockInfor) grvChiTiet.GetFocusedRow();
            DateTime sysDate = CommonProvider.Instance.GetSysDate();
            if(lockInfor != null)
            {
                TimeSpan t = lockInfor.Last_Update_Date.AddHours(2) - sysDate;
                if(MessageBox.Show(
                    String.Format(
                        "Khóa sẽ tự động mở sau {0} phút nữa. Việc mở khóa ngay lúc này có thể gây lỗi cho hệ thống!!! Bạn có đồng ý mở không?", 
                        Math.Round(t.TotalMinutes)), "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 
                        MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return;

                frmProgress.Instance.DoWork(
                    delegate()
                        {
                            frmProgress.Instance.Text = Text;
                            frmProgress.Instance.MaxValue = 100;
                            frmProgress.Instance.Value = 0;
                            frmProgress.Instance.Description = "Đang mở khóa ...";
                            if(ChungTuLockProvider.Instance.UnlockChungTu(lockInfor) == 0)
                            {
                                MessageBox.Show("Chứng từ đã tự mở khóa");
                            }
                            frmProgress.Instance.Value = frmProgress.Instance.MaxValue;
                            frmProgress.Instance.Description = "Đã xong";
                            LoadDuLieu();
                        });
            }
        }

        private void frmHT_LockChungTuManager_Load(object sender, EventArgs e)
        {
            frmProgress.Instance.DoWork(LoadDuLieu);
        }
    }
}