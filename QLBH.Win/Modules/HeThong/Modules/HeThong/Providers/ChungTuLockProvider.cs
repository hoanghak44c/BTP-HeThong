using System.Collections.Generic;
using QLBanHang.Modules.HeThong.DAO;
using QLBanHang.Modules.HeThong.Infors;

namespace QLBanHang.Modules.HeThong.Providers
{
    public class ChungTuLockProvider
    {

        private static ChungTuLockProvider instance;

        private ChungTuLockProvider()
        {
        }

        public static ChungTuLockProvider Instance
        {
            get
            {
                if (instance == null) instance = new ChungTuLockProvider();
                return instance;
            }
        }

        public List<ChungTuLockInfor> GetListChungTuLockInfor()
        {
            return ChungTuLockDAO.Instance.GetListChungTuLockInfor();
        }

        public int UnlockChungTu(ChungTuLockInfor infor)
        {
            return ChungTuLockDAO.Instance.UnlockChungTu(infor);
        }
    }
}