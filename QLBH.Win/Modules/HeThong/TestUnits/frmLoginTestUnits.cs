using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules;
using QLBanHang.Modules.HeThong;
using QLBH.Common;
using QLBH.Core.Form;
using QLBH.Core.TestUnits;

namespace QLBanHang.TestUnits
{
    [TestClass]
    public class frmLoginTestUnits : TestBase, IfrmLoginTestView
    {
        private readonly TestController testController;
        private static bool isGenDataPerTestMethod = false;
        
        public frmLoginTestUnits() : base(isGenDataPerTestMethod)
        {
            testController = new TestController(new frmLogin());
            isGenDataPerTestMethod = false;
        }

        [TestMethod]
        public void TestWrongPass()
        {
            try
            {
                TestLogin("quyenntl", "quyenntl");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(Declare.msgLogin_WrongPassword, ex.Message);
            }
            Assert.AreNotEqual(2, Declare.LogIn);
            Assert.AreEqual(true, testController.TestView.Controls.Find("txtMatKhau", true)[0].Focused);
        }

        [TestMethod]
        public void TestNonExistUser0()
        {
            try
            {
                TestLogin("xxx", "quantri");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(Declare.msgLogin_UserNotExist, ex.Message);
            }
            Assert.AreNotEqual(2, Declare.LogIn);
            Assert.AreEqual(true, testController.TestView.Controls.Find("txtTenDangNhap", true)[0].Focused);
        }

        [TestMethod]
        public void TestNonExistUser1()
        {
            try
            {
                TestLogin("' or 1=1 or ''='", "quantri");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(Declare.msgLogin_UserNotExist, ex.Message);
            }
            Assert.AreNotEqual(2, Declare.LogIn);
            Assert.AreEqual(true, testController.TestView.Controls.Find("txtTenDangNhap", true)[0].Focused);
        }

        [TestMethod]
        public void TestMissingUserName()
        {
            try
            {
                TestLogin("", "1");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(Declare.msgLogin_InputUserName, ex.Message);
            }
            Assert.AreNotEqual(2, Declare.LogIn);
            Assert.AreEqual(true, testController.TestView.Controls.Find("txtTenDangNhap", true)[0].Focused);
        }

        [TestMethod]
        public void TestMissingPassword()
        {
            try
            {
                TestLogin("quantri", "");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(Declare.msgLogin_InputPassword, ex.Message);
            }
            Assert.AreNotEqual(2, Declare.LogIn);
            Assert.AreEqual(true, testController.TestView.Controls.Find("txtMatKhau", true)[0].Focused);
        }

        [TestMethod]
        public void TestValidLogin()
        {
            TestLogin("tuanna", "tuanna");
            Assert.AreEqual(2, Declare.LogIn);
            Declare.LogIn = 0;
        }

        #region Implementation of IfrmLoginTestView

        public void TestLogin(string username, string pass)
        {
            (testController.TestView as IfrmLoginTestView).TestLogin(username, pass);
        }

        #endregion
    }
}
