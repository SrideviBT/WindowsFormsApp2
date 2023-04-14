using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Threading.Tasks;
using WindowsFormsApp2;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testMethod_Get()
        {
            var userList = RequestHelper.GetALL().Result;
            if (userList.Length > 0)
            {
                Assert.IsTrue(userList.Length > 0);
            }
        }

        [TestMethod]
        public void testMethod_GetById()
        {
            string obj = "717880";
            var userList = RequestHelper.Get(obj).Result;
            if (userList.Length > 0)
            {
                Assert.IsTrue(userList.Length > 0);
            };

        }
    }
}
