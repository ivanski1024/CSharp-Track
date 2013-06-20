using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;
using System.Diagnostics;


namespace TestSchool
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void StudentConstructorTest()
        {
            Student student = new Student("Svetlin Nakov", 12345);
            Debug.Assert(student.Name.Equals("Svetlin Nakov"));
            Debug.Assert(student.Number.Equals(12345));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StudentConstructorTest2()
        {
            Student student = new Student("", 12345);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentConstructorTest3()
        {
            Student student = new Student(null, 12345);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentConstructorTest4()
        {
            Student student = new Student("pesho", 100);
        }

        [TestMethod]
        public void EqualsTest()
        {
            Student pesho = new Student("pesho", 54321);
            Debug.Assert(pesho.Equals(new Student("pesho", 54321)));
            Debug.Assert(!pesho.Equals(new Student("gosho", 12345)));
        }
    }
}
