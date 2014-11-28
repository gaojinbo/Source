using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using EastCarmen.Entity;
using EastCarmen.IDao;
using EastCarmen.Dao;
using System.Linq;
using System.Collections.Generic;
using EastCarmen.Service;
using EastCarmen.IService;

namespace EastCarmen.UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Student stu = new Student()
            {
                ID = Guid.NewGuid(),
                Name = "Jennifer",
                Age = 23
            };
            IStudentService service = new StudentService();
            bool result = service.Add(stu) != 0;

            Assert.IsTrue(result);
        }
    }
}
