using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Einstein.Data.DAL;
using Einstein.Data;

namespace Einstein.UnitTest
{
    [TestClass]
    public class MenuInfoDALTest
    {
        [TestMethod]
        public void TestAdd()
        {
            MenuInfoDAL dal = new MenuInfoDAL();
            var menu = new MenuInfo()
                {
                    MenuID = System.Guid.NewGuid().ToString(),
                    MenuName = "导出考勤记录",
                    IconName = "default",
                    ObjectName = "Form1",
                    ObjectParameters = null,
                    ParentID = "468b36ff-65f5-4e94-a767-0b3efb0565e7",
                    ShortcutKey = null
                };

            dal.Add(menu);
        }

        [TestMethod]
        public void TestRemove()
        {
            MenuInfoDAL dal = new MenuInfoDAL();
            dal.Remove("e25bf6c1-0714-4618-b92d-9f88fb6e793d");
        }

        [TestMethod]
        public void TestSelectAll()
        {
            MenuInfoDAL dal = new MenuInfoDAL();
            IList<MenuInfo> list = dal.SelectAll();
        }

        [TestMethod]
        public void TestSelectByCardID()
        {
            MenuInfoDAL dal = new MenuInfoDAL();
            MenuInfo into = dal.SelectByMenuID("6bb66972-32ee-4741-acb2-3ab23977c973");
        }

        [TestMethod]
        public void TestUpdate()
        {
            MenuInfoDAL dal = new MenuInfoDAL();
            dal.Update("6bb66972-32ee-4741-acb2-3ab23977c973","testupdate");
        }
    }
}
