using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class StudentsOperations
    {

        public static Student[] FirstNameBeforeLastName( Student[] students)
        {
            var nameStudents =
                    from student in students
                    where student.FirstName.CompareTo(student.LastName) < 0
                    select student;

            return nameStudents.ToArray<Student>();
        }

        public static Student[] CertainAge(Student[] students, byte down, byte up)
        {
            var youngStudents =
                from student in students
                where student.Age >= down && student.Age <= up
                select student;
            return youngStudents.ToArray<Student>();
        }

        public static Student[] SortDescending(Student[] students)
        {
            var sorted = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
            return sorted.ToArray<Student>();
        }

        public static Student[] SortDescendingLinq(Student[] students)
        {
            var sorted =
                from student in students
                orderby student.FirstName, student.LastName descending                 
                select student;
            return sorted.ToArray<Student>();
        }


    }
}
