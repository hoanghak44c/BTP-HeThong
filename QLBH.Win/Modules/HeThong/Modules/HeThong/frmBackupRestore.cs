using System;
using System.Data;
using System.Windows.Forms;
//using Microsoft.SqlServer.Management.Smo;
//using Microsoft.SqlServer.Management.Common;
using QLBH.Common;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmBackupRestore : Form
    {
        //private static Server srvSql;

        //public frmBackupRestore()
        //{
        //    InitializeComponent();
        //    Common.LoadStyle(this);
        //}

        //private void frmBackupRestore_Load(object sender, EventArgs e)
        //{
        //    // Create a DataTable where we enumerate the available servers
        //    DataTable dtServers = SmoApplication.EnumAvailableSqlServers(true);
        //    // If there are any servers at all
        //    if (dtServers.Rows.Count > 0)
        //    {
        //        // Loop through each server in the DataTable
        //        foreach (DataRow drServer in dtServers.Rows)
        //        {
        //            // Add the name to the combobox
        //            cmbServer.Items.Add(drServer["Name"]);
        //        }
        //    }

        //}

        //private void btnConnect_Click(object sender, EventArgs e)
        //{
            
        //    if (txtUsername.Text == "")
        //    {
        //        MessageBox.Show("Nhập tài khoản để kết nối với máy chủ vào!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtUsername.Focus();
        //        return;
        //    }
        //    // If a server was selected at all from the combobox
        //    //TuanLM modified 29/03/08
        //    if (cmbServer.Text.ToString()!="")//.SelectedItem != null && cmbServer.SelectedItem.ToString() != "")
        //    {
                
        //        try
        //        {
        //            // Create a new connection to the selected server name
        //            ServerConnection srvConn = new ServerConnection(cmbServer.Text.ToString());
                    
        //            // Log in using SQL authentication instead of Windows authentication
        //            srvConn.LoginSecure = false;
        //            // Give the login username
        //            srvConn.Login = txtUsername.Text;
        //            // Give the login password
        //            srvConn.Password = txtPassword.Text;
        //            // Create a new SQL Server object using the connection we created
        //            srvSql = new Server(srvConn);
        //            // Loop through the databases list
        //            this.cmbDatabase.Items.Clear();
        //            foreach (Database dbServer in srvSql.Databases)
        //            {
        //                // Add database to combobox
        //                cmbDatabase.Items.Add(dbServer.Name);
        //            }
        //            MessageBox.Show("Kết nối thành công. Hãy chọn cơ sở dữ liệu!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            cmbDatabase.Focus();
        //        }
        //        catch
        //        {
        //            MessageBox.Show("Lỗi khi kết nối với máy chủ. Hãy kiểm tra lại!", "Lỗi kết nối!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }
        //       //~TuanLM modified 29/03/08
        //    }
        //    else
        //    {
        //        // A server was not selected, show an error message
        //        MessageBox.Show("Hãy chọn máy chủ CSDL trước!", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }

        //}

        //private void btnCreate_Click(object sender, EventArgs e)
        //{
        //    // If there was a SQL connection created
        //    if (srvSql != null)
        //    {
        //        //saveBackupDialog.FileName="Backup" + 
        //        // If the user has chosen a path where to save the backup file
        //        if (saveBackupDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            // Create a new backup operation
        //            Backup bkpDatabase = new Backup();
        //            // Set the backup type to a database backup
        //            bkpDatabase.Action = BackupActionType.Database;
        //            // Set the database that we want to perform a backup on
        //            bkpDatabase.Database = cmbDatabase.SelectedItem.ToString();

        //            // Set the backup device to a file
        //            BackupDeviceItem bkpDevice = new BackupDeviceItem(saveBackupDialog.FileName, DeviceType.File);
        //            // Add the backup device to the backup
        //            bkpDatabase.Devices.Add(bkpDevice);
        //            // Perform the backup
        //            bkpDatabase.SqlBackup(srvSql);
        //            MessageBox.Show("Sao lưu dữ liệu thành công!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    else
        //    {
        //        // There was no connection established; probably the Connect button was not clicked
        //        MessageBox.Show("Không thể kết nối tới máy chủ CSDL. Hãy kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
        //}

        //private void btnRestore_Click(object sender, EventArgs e)
        //{
        //    // If there was a SQL connection created
        //    if (srvSql != null)
        //    {
        //        // If the user has chosen the file from which he wants the database to be restored
        //        if (openBackupDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            try
        //            {
        //                // Create a new database restore operation
        //                Restore rstDatabase = new Restore();
        //                // Set the restore type to a database restore
        //                rstDatabase.Action = RestoreActionType.Database;
        //                // Set the database that we want to perform the restore on
        //                rstDatabase.Database = cmbDatabase.SelectedItem.ToString();

        //                // Set the backup device from which we want to restore, to a file
        //                BackupDeviceItem bkpDevice = new BackupDeviceItem(openBackupDialog.FileName, DeviceType.File);
        //                // Add the backup device to the restore type
        //                rstDatabase.Devices.Add(bkpDevice);
        //                // If the database already exists, replace it
        //                rstDatabase.ReplaceDatabase = true;
        //                // Perform the restore
        //                rstDatabase.SqlRestore(srvSql);
        //                MessageBox.Show("Phục hồi dữ liệu thành công!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //            catch(Exception ex)
        //            {
        //                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return;
        //            }
        //            finally
        //            { 
                    
        //            }
        //        }
        //    }
        //    else
        //    {
        //        // There was no connection established; probably the Connect button was not clicked
        //        MessageBox.Show("Không thể kết nối tới máy chủ CSDL. Hãy kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }

        //}

        //private void btnClose_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

    }
}