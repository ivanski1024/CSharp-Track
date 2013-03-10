using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Students
    {
        static void Main()
        {
            Student[] students = {
            new Student("Georgi", "Georgiev", 21),
            new Student("Doncho", "Minkov", 23),
            new Student("Svetlin", "Nakov", 32),
             
            new Student("Nikolay", "Genov", 19),
            new Student("Nikolay", "Kostov", 21)
        };


            //Selecting only the students whose first name is before their last name alphabetically
            Console.WriteLine("These are the students whose first name is before last name alphabetically:");
            Student[] sorted = StudentsOperations.FirstNameBeforeLastName(students); 
            foreach (Student stud in sorted)
            {
                Console.WriteLine("{0} {1}", stud.FirstName, stud.LastName);
            }

            Console.WriteLine();

            //Selecting only the students between certain years ( [18; 24] in this case )
            Console.WriteLine("These are the students who are between {0} and {1} years old:", 18, 24);
            Student[] youngStudents = StudentsOperations.CertainAge(students, 18, 24);
            foreach (Student student in youngStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            Console.WriteLine();

            //Sorting the students by their names in descending order
            Console.WriteLine("The students sorted by there names in descending order:");
            Student[] sortedDescending = StudentsOperations.SortDescending(students);
            foreach (Student stud in sortedDescending)
            {
                Console.WriteLine("{0} {1}", stud.FirstName, stud.LastName);
            }

            Console.WriteLine();
            //Sorting the students by their names in descending order with LINQ
            Console.WriteLine("The students sorted by there names in descending order (using LINQ):");
            Student[] sortedDescendingLinq = StudentsOperations.SortDescendingLinq(students);
            foreach (Student stud in sortedDescendingLinq)
            {
                Console.WriteLine("{0} {1}", stud.FirstName, stud.LastName);
            }
        }
    }
}
