using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBH.Core.Exceptions;
using QLBH.Core.Form;
using QLBH.Core.Net;
using QLBH.Core.Version;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmHT_SaleTid_CapNhatPhienBanMoi : DevExpress.XtraEditors.XtraForm
    {
        private readonly string sPath;

        private bool success;

        public frmHT_SaleTid_CapNhatPhienBanMoi()
        {
            InitializeComponent();

            //sPath = String.Format(@"{0}\{1}", @"C:\Program Files\GTID\SaleTid", Path.GetRandomFileName());

            sPath = String.Format(@"{0}\{1}", Application.StartupPath, Path.GetRandomFileName());

            Directory.CreateDirectory(sPath);
        }
        
        public bool IsProcessOpen(string name)
        {
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName == name)
                {
                    return true;
                }
            }
            return false;
        } 

        private string getCommingVersion()
        {
            return Directory.GetFiles(sPath, "*@FRT*.exe")[0].Substring(
                Directory.GetFiles(sPath, "*@FRT*.exe")[0].Length - 18, 14);
        }

        private void bteUpdatePack_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var openFileDialog = new OpenFileDialog();

                openFileDialog.Multiselect = false;

                openFileDialog.Filter = "SaleTidPackage|SaleTidPackage.exe";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in Directory.GetFiles(sPath, "*@FRT*.exe"))
                    {
                        File.Delete(file);
                    }

                    File.Copy(openFileDialog.FileName, String.Format("{0}\\{1}", sPath, openFileDialog.SafeFileName), true);

                    var processStartInfo =
                        new ProcessStartInfo(String.Format("{0}\\{1}", sPath, openFileDialog.SafeFileName)) { WorkingDirectory = sPath };

                    Process.Start(processStartInfo);

                    Thread.CurrentThread.Join(3000);

                    while (IsProcessOpen(openFileDialog.SafeFileName))
                    {
                        Thread.CurrentThread.Join(3000);
                    }

                    if (Directory.GetFiles(sPath, "*@FRT*.exe").Length == 0 ||
                        
                        Directory.GetFiles(sPath, String.Format("*{0}*",  getCommingVersion())).Length < 2)
                    {
                        throw new ManagedException("Gói cập nhật không hợp lệ");
                    }

                    bteUpdatePack.Text = openFileDialog.SafeFileName;

                    btnSave.Enabled = true;
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                this.Close();
            }
        }

        private void Upgrade()
        {
            try
            {
                frmProgress.Instance.Description = "Đang thực hiện nâng cấp...";

                var commingVersion = getCommingVersion();

                if (VerBase.CurrentVersion >= Convert.ToDouble(commingVersion))
                {
                    throw new ManagedException("Gói cập nhật không hợp lệ");
                }

                foreach (var file in Directory.GetFiles(sPath, "*@FRT*.exe"))
                {
                    var fileInfo = new FileInfo(file);

                    var request = (FtpWebRequest)GtidWebRequest.CreateA("osp4q3rUgFY9M1hI/+3PKq8RiHTqHIYgngpHhEi9qOA=", fileInfo.Name);

                    request.Method = WebRequestMethods.Ftp.UploadFile;

                    request.Credentials = new GtidNetWorkCredential("T5NJ7G++L34=", "kfsRLYOLdZwiZXn3EqCugQ==");

                    var requestStream = request.GetRequestStream();

                    var sourceStream = new FileStream(file, FileMode.Open);

                    var upBuffer = new byte[1024 * 2];

                    int bytesSize;

                    frmProgress.Instance.MaxValue = Convert.ToInt32(sourceStream.Length);

                    var totalSize = 0;

                    frmProgress.Instance.Value = 0;

                    while ((bytesSize = sourceStream.Read(upBuffer, 0, upBuffer.Length)) > 0)
                    {
                        totalSize += bytesSize;

                        frmProgress.Instance.Value = totalSize;

                        requestStream.Write(upBuffer, 0, bytesSize);

                        Thread.CurrentThread.Join(10);
                    }

                    sourceStream.Close();

                    requestStream.Close();

                    var response = (FtpWebResponse)request.GetResponse();

                    if (response != null)
                    {
                        if (response.StatusDescription.Contains("OK"))
                        {
                            response.Close();

                            success = true;
                        }
                        else
                        {
                            success = false;

                            throw new ManagedException("Cập nhật không thành công");
                        }
                    }

                    Thread.CurrentThread.Join(1000);
                }

                SaleTidVer.Instance.UpToVersion(commingVersion);

                frmProgress.Instance.Description = "Đã xong!";

                frmProgress.Instance.Value = frmProgress.Instance.MaxValue;

                frmProgress.Instance.IsCompleted = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                frmProgress.Instance.Description = "Không hoàn thành!";

                frmProgress.Instance.Value = frmProgress.Instance.MaxValue;

                frmProgress.Instance.IsCompleted = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmProgress.Instance.Caption = Text; 
            
            frmProgress.Instance.DoWork(Upgrade);

            if (success)

                this.Close();
        }

        private void frmHT_SaleTid_CapNhatPhienBanMoi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Directory.Delete(sPath, true);
        }
    }
}