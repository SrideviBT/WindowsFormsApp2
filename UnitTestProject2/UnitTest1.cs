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
        public void TestMethod1()
        {
            string obj = "717880";
            string obj1 = "717879";
           
            Assert.AreEqual(RequestHelper.Get(obj).ToString(),RequestHelper.Get(obj1).ToString());

        }
    }
}
