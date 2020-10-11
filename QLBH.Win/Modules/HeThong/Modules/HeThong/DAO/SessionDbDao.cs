using System.Data;
using QLBH.Core.Data;

namespace QLBanHang.Modules.HeThong.DAO
{
    public class SessionDbProdDao : BaseDAO
    {
        private static SessionDbProdDao instance;

        public static SessionDbProdDao Instance
        {
            get { return instance ?? (instance = new SessionDbProdDao()); }
        }        

        public DataTable GetSessions()
        {
            string sqlCmd =
                @"select sid,serial#,user#,username,command,status,server,schemaname, 
                                    osuser,process,machine,port,terminal,program, type,sql_Id,
                                    sql_child_number,sql_exec_start,action,event,state,service_name 
                                from v$session where username=:username and program like :program";

            return GetDataTableCommand(sqlCmd, "POS", "QLB%");
        }
    }
    public class SessionDbStByDao : Base3Dao
    {
        private static SessionDbStByDao instance;

        public static SessionDbStByDao Instance
        {
            get { return instance ?? (instance = new SessionDbStByDao()); }
        }

        public DataTable GetSessions()
        {
            string sqlCmd =
                @"select sid,serial#,user#,username,command,status,server,schemaname, 
                                    osuser,process,machine,port,terminal,program, type,sql_Id,
                                    sql_child_number,sql_exec_start,action,event,state,service_name 
                                from v$session where username=:username and program like :program";

            return GetDataTableCommand(sqlCmd, "POS", "QLB%");
        }
    }
}