using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.HeThong;
using QLBH.Core.TestUnits;

namespace QLBanHang.TestUnits
{
    public class SystemTestBase : TestBase
    {
        private readonly IfrmLoginTestView frmLogin;
        private static bool isGenDataPerTestMethod = true;
        public SystemTestBase(string username, string password)
            : base(isGenDataPerTestMethod)
        {
            isGenDataPerTestMethod = false;
            frmLogin = new frmLogin();
            frmLogin.TestLogin(username, password);
        }
    }
}
