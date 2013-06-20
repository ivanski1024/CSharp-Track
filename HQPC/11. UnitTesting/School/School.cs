namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class School
    {
        private List<Student> students;

        private List<Course> courses;

        public School()
        {
            this.Students = new List<Student>();
            this.Courses = new List<Course>();
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

        public List<Course> Courses
        {
            get
            {
                return this.courses;
            }

            private set 
            {
                this.courses = value;
            }
        }

        public void AddStudent(Student student)
        {
            for (int index = 0; index < this.Students.Count; index++)
            {
                if (this.Students[index].Number == student.Number)
                {
                    throw new ArgumentException("Student with the same number already exists!");
                }
            }

            this.Students.Add(student);
        }

        public static void Main()
        {
        }
    }
}
