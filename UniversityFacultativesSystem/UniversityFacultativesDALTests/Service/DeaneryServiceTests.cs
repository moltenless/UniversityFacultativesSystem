using Microsoft.VisualStudio.TestTools.UnitTesting;
using UniversityFacultativesDAL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityFacultativesDAL.Entity;

namespace UniversityFacultativesDAL.Service.Tests
{
    [TestClass()]
    public class DeaneryServiceTests
    {
        [TestMethod()]
        public void GetTeacherTest()
        {
            DeaneryService deaneryService = new DeaneryService("deanery", "deanery32188");


            Assert.AreEqual(" ", "");
        }

        //[TestMethod()]
        //public void GetTeachersTest()
        //{
        //    DeaneryService deaneryService = new DeaneryService("deanery", "deanery32188");
        //    List<Teacher> teachers = deaneryService.GetTeachers();
        //    deaneryService.Close();
        //    Assert.AreEqual(teachers[6].FirstName, "Наталія");
        //}
    }
}