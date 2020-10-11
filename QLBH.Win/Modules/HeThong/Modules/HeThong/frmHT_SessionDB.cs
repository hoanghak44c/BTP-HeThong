using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
//using QLBanHang.Class;
using DevExpress.XtraGrid.Views.Grid;
using QLBanHang.Modules.HeThong.Providers;
using QLBH.Common;
using QLBH.Common.Providers;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmHT_SessionDB : DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"

        private DataTable dtSession;
        private int topRowIndex;
        private int selectedRowIndex;
        private bool isActivated;
        private CollectionChangeAction changeAction;
        private bool isStoped, isPaused = false;
        private DateTime currentDate;
        private ISessionDb sessionDb;

        private Thread autoRefreshThread;
#endregion

#region "Các phương thức khởi tạo"
        public frmHT_SessionDB()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            chkOnPos.Checked = true;
            sessionDb = SessionDbProdDataProvider.Instance;
            //this.Activated += frmHT_SessionDB_Activated;
            //this.LostFocus += frmHT_SessionDB_LostFocus;
        }

        //void frmHT_SessionDB_Activated(object sender, EventArgs e)
        //{
        //    isActivated = true;
        //}

        //void frmHT_SessionDB_LostFocus(object sender, EventArgs e)
        //{
        //    isActivated = false;
        //}
#endregion

#region "Các sự kiên"
        private void frmBH_TimChungTu_Load(object sender, EventArgs e)
        {
            try
            {
                isStoped = isPaused = false;
                autoRefreshThread = new Thread(Statistic);
                autoRefreshThread.Start();
                //timer1.Start();
            }
            catch(ThreadAbortException){}
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
#endregion


        private void frmBH_TimChungTu_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Statistic()
        {
            while (!isStoped)
            {
                try
                {
                    Thread.CurrentThread.Join(500);

                    if (isPaused) continue;

                    if (!Common.ApplicationIsActivated()) continue;

                    if (Application.OpenForms[0].ActiveMdiChild != this) continue;

                    dtSession = sessionDb.GetSessions();

                    int count = dtSession.Rows.Count;

                    if (InvokeRequired)
                    {
                        Invoke((MethodInvoker)
                               delegate
                               {
                                   txtSession.Text = count.ToString();
                                   
                                   gvDB.TopRowIndex = topRowIndex;

                                   if (gDB.DataSource == null)
                                   {
                                       gvDB.OptionsSelection.EnableAppearanceFocusedRow = false;
                                       //dsSession = DBTools.getData("session", sql1, "POS", "QLB%");
                                       gDB.DataSource = dtSession.Copy();
                                       gvDB.Columns[3].Width = 150;
                                       gvDB.Columns[4].Width = 150;
                                       gvDB.Columns[5].Width = 150;
                                       gvDB.Columns[6].Width = 150;
                                       gvDB.Columns[7].Width = 150;
                                       gvDB.Columns[8].Width = 150;
                                       gvDB.Columns[9].Width = 150;
                                       gvDB.Columns[10].Width = 250;
                                       gvDB.Columns[11].Width = 150;
                                       gvDB.Columns[12].Width = 150;
                                       gvDB.Columns[13].Width = 150;
                                       gvDB.Columns[14].Width = 150;
                                       gvDB.Columns[14].OptionsColumn.AllowEdit = false;
                                       gvDB.Columns[14].OptionsColumn.ReadOnly = true;
                                       gvDB.Columns[15].Width = 250;
                                       gvDB.Columns[16].Width = 150;
                                       gvDB.Columns[16].OptionsColumn.AllowEdit = false;
                                       gvDB.Columns[16].OptionsColumn.ReadOnly = true;
                                       gvDB.Columns[17].Width = 150;
                                       gvDB.Columns[18].Width = 150;
                                       gvDB.Columns[19].Width = 250;
                                       gvDB.Columns[20].Width = 150;
                                       gvDB.Columns[21].Width = 150;
                                   }
                                   else
                                   {
                                       gDB.DataSource = dtSession.Copy();

                                       gDB.RefreshDataSource();
                                   }

                                   if (selectedRowIndex >= gvDB.RowCount) gvDB.FocusedRowHandle = gvDB.RowCount - 1;

                                   gvDB.FocusedRowHandle = selectedRowIndex;

                               });
                    }
                }
                catch
                {
                    if(InvokeRequired)
                    {
                        Invoke((MethodInvoker)
                               delegate
                                   {
                                       txtSession.Text = "0";
                                   });
                    }
                }                
            }
        }

        private void frmHT_SessionDB_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                isStoped = true;
                //timer1.Stop();                
            }
            catch
            {
                
            }
        }

        private void gvDB_TopRowChanged(object sender, EventArgs e)
        {
            topRowIndex = gvDB.TopRowIndex;
        }

        void gvDB_RowClick(object sender, RowClickEventArgs e)
        {
            selectedRowIndex = e.RowHandle;
        }

        void gvDB_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            selectedRowIndex = e.RowHandle;
        }

        void gvDB_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle == e.PrevFocusedRowHandle + 1 ||
                e.FocusedRowHandle == e.PrevFocusedRowHandle - 1 )
            selectedRowIndex = e.FocusedRowHandle;
        }

        private void gtidButton1_Click(object sender, EventArgs e)
        {
            isPaused = !isPaused;

            gtidButton1.Text = isPaused ? "Tiếp tục" : "Tạm dừng";

            if (isPaused) currentDate = CommonProvider.Instance.GetSysDate();

            //if (isPaused) 
            //    timer1.Stop();
            //else
            //    timer1.Start();
        }

        private void frmHT_SessionDB_Leave(object sender, EventArgs e)
        {
            //timer1.Stop();
        }

        private void frmHT_SessionDB_Activated(object sender, EventArgs e)
        {
            //if(!isStop) timer1.Start();
        }

        private void gvDB_DoubleClick(object sender, EventArgs e)
        {
            if(gvDB.FocusedRowHandle >= 0)
            {
                var dr = (DataRowView) gvDB.GetRow(gvDB.FocusedRowHandle);
                var terminal = dr["TERMINAL"].ToString();
                var process = dr["PROCESS"].ToString().Split(':')[0];
                var execDate = Convert.ToDateTime(dr["SQL_EXEC_START"]);

                MessageBox.Show(NhatKyNguoiDungDataProvider.Instance.GetCurrentInfo(terminal, process, execDate));
            }
        }

        private void chkOnStby_CheckedChanged(object sender, EventArgs e)
        {
            chkOnPos.Checked = !((CheckBox)sender).Checked;

            if(((CheckBox)sender).Checked)
            {
                sessionDb = SessionDbStByDataProvider.Instance;
            } 
            else
            {
                sessionDb = SessionDbProdDataProvider.Instance;
            }
        }

        private void chkOnPos_CheckedChanged(object sender, EventArgs e)
        {
            chkOnStby.Checked = !((CheckBox) sender).Checked;
        }
    }
}