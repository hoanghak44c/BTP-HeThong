using System.Data;
using QLBanHang.Modules.HeThong.DAO;

namespace QLBanHang.Modules.HeThong.Providers
{
    public interface ISessionDb
    {
        DataTable GetSessions();
    }

    public class SessionDbProdDataProvider : ISessionDb
    {

        private static SessionDbProdDataProvider instance;

        private SessionDbProdDataProvider()
        {
        }

        public static SessionDbProdDataProvider Instance
        {
            get { return instance ?? (instance = new SessionDbProdDataProvider()); }
        }

        public DataTable GetSessions()
        {
            return SessionDbProdDao.Instance.GetSessions();
        }
    }

    public class SessionDbStByDataProvider : ISessionDb
    {

        private static SessionDbStByDataProvider instance;

        private SessionDbStByDataProvider()
        {
        }

        public static SessionDbStByDataProvider Instance
        {
            get { return instance ?? (instance = new SessionDbStByDataProvider()); }
        }

        public DataTable GetSessions()
        {
            return SessionDbStByDao.Instance.GetSessions();
        }
    }
}