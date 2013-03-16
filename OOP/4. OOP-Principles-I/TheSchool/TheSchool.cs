using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSchool
{
    class TheSchool
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Ivan", "Petrov", 1001365));
            Class myClass = new Class(students);
            Teacher nakov = new Teacher("Svetlin", "Nakov");
            myClass.AddTeacher(nakov);
            myClass.AddTeacher(nakov);
        }
    }
}
