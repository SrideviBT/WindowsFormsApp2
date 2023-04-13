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
        public void TestMethodGet()
        {
            string obj = "944961";
            string obj1 = "966962";
           
            Assert.AreEqual(RequestHelper.Get(obj).ToString(),RequestHelper.Get(obj1).ToString());

        }

        [TestMethod]
        public void TestMethodDelete()
        {
            string obj = "717880";
            string obj1 = "717879";

            Assert.AreEqual(RequestHelper.Delete(obj).ToString(), RequestHelper.Delete(obj1).ToString());

        }
    }
}
