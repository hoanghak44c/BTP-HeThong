using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBH.Common.Providers;
using QLBH.Core.Data;

namespace QLBanHang.Modules.HeThong.DAO
{
    public class SystemDAO : BaseDAO
    {
        protected override object[] SetLogParams(params object[] paramValues)
        {
            List<object> paras = new List<object>(paramValues);
            paras.AddRange(new object[] { ((NguoiDungInfor)Declare.USER_INFOR).TenDangNhap, CommonProvider.Instance.GetSysDate(), Declare.TenMay });
            return paras.ToArray();
        }
    }
}
