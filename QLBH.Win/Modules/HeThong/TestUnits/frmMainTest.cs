using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules;

namespace QLBanHang.TestUnits
{
    public class frmMainTestController : frmMain
    {
        private static frmMainTestController instance;
        public static frmMainTestController Instance
        {
            get
            {
                if (instance == null) instance = new frmMainTestController();
                return instance;
            }
        }
    }

    [TestClass]
    public class frmMainTest
    {
        [TestMethod]
        public void TestMainShow()
        {
            frmMainTestController.Instance.ShowDialog();
        }
    }
}
