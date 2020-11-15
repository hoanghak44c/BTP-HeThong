using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.HeThong.Infors;

namespace QLBanHang.Modules.HeThong.DAO
{
    public class ChucNangDAO :BaseDAO
    {
        private static ChucNangDAO instance;
        private ChucNangDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmChucNang;
            //UseCaching = true;
        }
        public static ChucNangDAO Instance
        {
            get
            {
                if (instance == null) instance = new ChucNangDAO();
                return instance;
            }
        }

        public List<ChucNangInfor> ListAll()
        {
            return GetListAll<ChucNangInfor>(Declare.StoreProcedureNamespace.spChucNangListAll, null);
        }

        public void InsertIfNotExist(ChucNangInfor objChucNang)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spChucNangInsertIfNotExist);
            SetParams(objChucNang);
            Parameters["@p_IdChucNang"].Direction = ParameterDirection.Output;
            ExecuteNoneQuery();
        }

        public void Delete(int idChucNang)
        {
            CreateCommand(Declare.StoreProcedureNamespace.spChucNangDeleteCN, idChucNang);
            ExecuteNoneQuery();
        }

        public List<ChucNangInfor> Search(string thamso)
        {
            CreateCommand(Declare.StoreProcedureNamespace.spChucNangSearchCN, thamso);
            return FillToList<ChucNangInfor>();
        }
    }
}
