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

        [TestMethod]
        public void testMethod_Post()
        {
            string name = "Sridevi";
            string email = "sridevi@gmail.com";
            string gender = "female";
            string status = "active";
            var response = RequestHelper.Post(name,email,gender,status).Result;
            if (response.Length > 0)
            {
                Assert.IsTrue(true,"OK");
            };

        }

        [TestMethod]
        public void testMethod_Delete()
        {
            string id = "974261";
            var response = RequestHelper.Delete(id).Result;
            
             Assert.IsTrue(true,String.Empty);
            

        }
    }
}
