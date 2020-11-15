using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using QLBH.Common;
using QLBH.Core.Data;
using QLBH.Core.Exceptions;
using QLBH.Core.Providers;

namespace QLBanHang.Modules.HeThong
{
    public class LockControl
    {
        public static void Lock(string functionName)
        {
            string sql = "SELECT lk.IdUser,nd.TenDangNhap,lk.Computer, lk.ProcessId FROM tbl_Function_Locking lk INNER JOIN tbl_dm_nguoidung nd ON lk.IdUser = nd.IdNguoidung WHERE lk.FormName=:formName AND lk.IdKho=:idKho";
            DataTable dt = SqlHelper.ExecuteDataset(ConnectionUtil.Instance.GetConnection(), CommandType.Text, sql, functionName, Declare.IdKho).Tables[0];
            if (dt != null && dt.Rows.Count > 0)
            {
                if (!Equals(dt.Rows[0]["Computer"], Common.GetComputerName()))
                {
                    throw new ManagedException(String.Format("Chức năng này đang được chạy bởi một máy khác [{0}]", dt.Rows[0]["Computer"]));
                }

                if (Common.IntValue(dt.Rows[0]["IdUser"]) != Declare.UserId)
                {
                    throw new ManagedException(String.Format("Chức năng này đang được chạy bởi một người dùng khác [{0}]", dt.Rows[0]["TenDangNhap"]));
                }

                if (dt.Rows[0]["ProcessId"] != DBNull.Value && Common.IntValue(dt.Rows[0]["ProcessId"]) != Process.GetCurrentProcess().Id)
                {
                    try
                    {
                        Process.GetProcessById(Common.IntValue(dt.Rows[0]["ProcessId"]));
                        throw new ManagedException("Chức năng này đang được chạy bởi ứng dụng khác");
                    }
                    catch (Exception)
                    {
                        //nothing
                    }
                }

                return;
            }

            GtidCommand sqlCmd = ConnectionUtil.Instance.GetConnection().CreateCommand();
            sqlCmd.CommandText = "sp_LockFunction_Insert1";
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@FormName", functionName);
            sqlCmd.Parameters.AddWithValue("@IdKho", Declare.IdKho);
            sqlCmd.Parameters.AddWithValue("@IdUser", Declare.UserId);
            sqlCmd.Parameters.AddWithValue("@Computer", Common.GetComputerName());
            sqlCmd.Parameters.AddWithValue("@ProcessId", Process.GetCurrentProcess().Id);
            sqlCmd.ExecuteNonQuery();

            return;
        }

        public static void Lock(string functionName, int idKho)
        {
            string sql = String.Format("SELECT lk.IdUser,nd.TenDangNhap,lk.Computer FROM tbl_Function_Locking lk INNER JOIN tbl_dm_nguoidung nd ON lk.IdUser = nd.IdNguoidung WHERE lk.FormName='{0}' AND lk.IdKho={1}", functionName, idKho);
            DataTable dt = SqlHelper.ExecuteDataset(ConnectionUtil.Instance.GetConnection(), CommandType.Text, sql).Tables[0];
            if (dt != null && dt.Rows.Count > 0)
            {
                if (!Equals(dt.Rows[0]["Computer"], Common.GetComputerName()))
                {
                    throw new ManagedException(String.Format("Chức năng này đang được chạy bởi một máy khác [{0}]", dt.Rows[0]["Computer"]));
                }

                if (Common.IntValue(dt.Rows[0]["IdUser"]) != Declare.UserId)
                {
                    throw new ManagedException(String.Format("Chức năng này đang được chạy bởi một người dùng khác [{0}]", dt.Rows[0]["TenDangNhap"]));
                }

                if (dt.Rows[0]["ProcessId"] != DBNull.Value && Common.IntValue(dt.Rows[0]["ProcessId"]) != Process.GetCurrentProcess().Id)
                {
                    try
                    {
                        Process.GetProcessById(Common.IntValue(dt.Rows[0]["ProcessId"]));
                        throw new ManagedException("Chức năng này đang được chạy bởi ứng dụng khác");
                    }
                    catch (Exception)
                    {
                        //nothing
                    }
                }

                return;
            }

            GtidCommand sqlCmd = ConnectionUtil.Instance.GetConnection().CreateCommand();
            sqlCmd.CommandText = "sp_LockFunction_Insert1";
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@FormName", functionName);
            sqlCmd.Parameters.AddWithValue("@IdKho", idKho);
            sqlCmd.Parameters.AddWithValue("@IdUser", Declare.UserId);
            sqlCmd.Parameters.AddWithValue("@Computer", Common.GetComputerName());
            sqlCmd.Parameters.AddWithValue("@ProcessId", Process.GetCurrentProcess().Id);
            sqlCmd.ExecuteNonQuery();

            return;
        }

        public static void Unlock(string functionName)
        {
            GtidCommand sqlCmd = ConnectionUtil.Instance.GetConnection().CreateCommand();
            sqlCmd.CommandText = "sp_LockFunction_Update1";
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@FormName", functionName);
            sqlCmd.Parameters.AddWithValue("@IdKho", Declare.IdKho);
            sqlCmd.Parameters.AddWithValue("@IdUser", Declare.UserId);
            sqlCmd.Parameters.AddWithValue("@Computer", Common.GetComputerName());
            sqlCmd.Parameters.AddWithValue("@ProcessId", Process.GetCurrentProcess().Id);
            sqlCmd.ExecuteNonQuery();
        }

        public static void Unlock(string functionName, int idKho)
        {
            GtidCommand sqlCmd = ConnectionUtil.Instance.GetConnection().CreateCommand();
            sqlCmd.CommandText = "sp_LockFunction_Update1";
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@FormName", functionName);
            sqlCmd.Parameters.AddWithValue("@IdKho", idKho);
            sqlCmd.Parameters.AddWithValue("@IdUser", Declare.UserId);
            sqlCmd.Parameters.AddWithValue("@Computer", Common.GetComputerName());
            sqlCmd.Parameters.AddWithValue("@ProcessId", Process.GetCurrentProcess().Id);
            sqlCmd.ExecuteNonQuery();
        }

        public static void CleanLockByProcessComputer()
        {
            try
            {
                string sql = @"SELECT lk.IdUser,nd.TenDangNhap,lk.Computer, lk.ProcessId 
                    FROM tbl_Function_Locking lk 
                        INNER JOIN tbl_dm_nguoidung nd ON lk.IdUser = nd.IdNguoidung 
                    WHERE lk.Computer=:computer";
                DataTable dt = SqlHelper.ExecuteDataset(ConnectionUtil.Instance.GetConnection(), CommandType.Text, sql, Common.GetComputerName()).Tables[0];
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["ProcessId"] != DBNull.Value)
                        {
                            if (Common.IntValue(dt.Rows[0]["ProcessId"]) != Process.GetCurrentProcess().Id)
                            {
                                try
                                {
                                    Process.GetProcessById(Common.IntValue(dt.Rows[0]["ProcessId"]));
                                }
                                catch (Exception)
                                {
                                    SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(),
                                        CommandType.Text,
                                        "Delete tbl_function_locking where computer = :computer and processid = :processid",
                                        Common.GetComputerName(),
                                        dt.Rows[0]["ProcessId"]);
                                }
                            }
                            else
                            {
                                SqlHelper.ExecuteNonQuery(ConnectionUtil.Instance.GetConnection(),
                                    CommandType.Text,
                                    "Delete tbl_function_locking where computer = :computer and processid = :processid",
                                    Common.GetComputerName(),
                                    dt.Rows[0]["ProcessId"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                EventLogProvider.Instance.WriteOfflineLog(ex.ToString(), "Clean locks.");
            }
        }

    }
}
