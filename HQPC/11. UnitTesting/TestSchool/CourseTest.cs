using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;
using System.Diagnostics;

namespace TestSchool
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void CourseConstructorTest()
        {
            Course KPK = new Course();
        }

        [TestMethod]
        public void JoinCourseTest()
        {
            Course KPK = new Course();
            KPK.JoinCourse(new Student("Gosho Petrov", 12345));
            Debug.Assert(KPK.Students.Count.Equals(1));
            Debug.Assert(KPK.Students[0].Equals(new Student("Gosho Petrov", 12345)));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void JoinCourseTest2()
        {
            Course KPK = new Course();
            KPK.JoinCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void JoinCourseTest3()
        {
            Course KPK = new Course();
            for (int i = 0; i < 31; i++)
            {
                KPK.JoinCourse(new Student(string.Format("Student{0}", i), 10000 + i));
            }
        }

        [TestMethod]
        public void LeaveCourseTest()
        {
            Course KPK = new Course();
            KPK.JoinCourse(new Student("Gosho", 12345));
            KPK.LeaveCourse(new Student("Gosho", 12345));
            Debug.Assert(KPK.Students.Count.Equals(0));
        }

        [TestMethod]
        public void LeaveCourseTest2()
        {
            Course KPK = new Course();
            Student student = new Student("Gosho", 12345);
            KPK.JoinCourse(student);
            KPK.LeaveCourse(student);
            Debug.Assert(KPK.Students.Count.Equals(0));
        }
    }
}
