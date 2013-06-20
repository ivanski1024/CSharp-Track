using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;
using System.Diagnostics;

namespace TestSchool
{
    [TestClass]
    public class SchoolTest
    {

        [TestMethod]
        public void SchoolConstructorTest()
        {
            School.School school = new School.School();
        }

        [TestMethod]
        public void AddStudentTest()
        {
            Student student = new Student("Pesho Peshev", 12345);
            School.School TelerikAcademy = new School.School();
            TelerikAcademy.AddStudent(student);
            Debug.Assert(TelerikAcademy.Students.Count.Equals(1));
            Debug.Assert(TelerikAcademy.Students.Contains(student));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddStudentTest2()
        {
            Student pesho = new Student("Pesho Peshev", 12345);
            Student gosho = new Student("Georgi Georgiev", 12345);
            School.School TelerikAcademy = new School.School();
            TelerikAcademy.AddStudent(pesho);
            TelerikAcademy.AddStudent(gosho);
        }


        [TestMethod]
        public void MainTest()
        {
            School.School.Main();
        }
    }
}
