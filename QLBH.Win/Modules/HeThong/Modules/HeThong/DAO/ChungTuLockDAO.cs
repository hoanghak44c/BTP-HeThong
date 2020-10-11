using System.Collections.Generic;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.HeThong.DAO
{
    public class ChungTuLockDAO : BaseDAO
    {

        private static ChungTuLockDAO instance;

        private ChungTuLockDAO()
        {
        }

        public static ChungTuLockDAO Instance
        {
            get
            {
                if (instance == null) instance = new ChungTuLockDAO();
                return instance;
            }
        }

        public List<ChungTuLockInfor> GetListChungTuLockInfor()
        {
            return GetListCommand<ChungTuLockInfor>(Declare.StoreProcedureNamespace.spChungTuGetListLockInfor);
        }

        public int UnlockChungTu(ChungTuLockInfor infor)
        {
            return ExecuteCommand(Declare.StoreProcedureNamespace.spChungTuBanHangLockEdit, infor.IdChungtu, 0, 0,
                           infor.ProcessId, infor.LockAccount, infor.LockMachine);
        }
    }
}