namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Course
    {

        public static readonly int CourseMaxSize = 30;
        private List<Student> students;

        public Course() 
        {
            this.Students = new List<Student>();
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }

            private set
            {
                this.students = value;
            }
        }

        public void JoinCourse(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student is null!");
            }
            else if (this.students.Count >= CourseMaxSize)
            {
                throw new ArgumentException("Course is full!");
            }
            else
            {
                this.Students.Add(student);
            }
        }

        public void LeaveCourse(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student is null!");
            }
            else
            {
                this.students.Remove(student);
            }
        }
    }
}
