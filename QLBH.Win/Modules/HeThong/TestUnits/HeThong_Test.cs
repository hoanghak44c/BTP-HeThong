using System;
using System.Diagnostics;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules;
using QLBanHang.Modules.HeThong;
using QLBH.Core.Printers;
using QLBH.Core.Printers.Godex;

namespace QLBanHang.TestUnits
{
    [TestClass]
    public class HeThong_Test
    {
        public HeThong_Test()
        {
            //ConnectionUtil.Instance.IsUAT = 1;
            //frmLogin frmLogin = new frmLogin();
            //frmLogin.TestLogin("quantri", "khong biet dau");
        }

        #region TestSys
        [TestMethod]
        public void TestSys()
        {
            frmMain frm = new frmMain();
            frm.ShowDialog();
        }

        [TestMethod]
        public void TestNhomNguoiDung()
        {
            frmHT_ListNhomNguoiDung frm = new frmHT_ListNhomNguoiDung();
            frm.ShowDialog();
        }

        [TestMethod]
        public void TestListNguoiDung()
        {
            frmHT_ListNguoiDung frm = new frmHT_ListNguoiDung();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestMonitorSession()
        {
            frmHT_SessionDB frm = new frmHT_SessionDB();
            frm.ShowDialog();
        }
        
        [TestMethod]
        public void TestNangCap()
        {
            frmHT_SaleTid_CapNhatPhienBanMoi frm = new frmHT_SaleTid_CapNhatPhienBanMoi();
            frm.ShowDialog();
        }
        #endregion

    }
}
