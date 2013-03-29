/*
 * 1. Define a class Student, which contains data about a student – first, middle and last name,
 * SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an 
 * enumeration for the specialties, universities and faculties. Override the standard methods, 
 * inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
 * 
 * 2. Add implementations of the ICloneable interface. The Clone() method should deeply copy all 
 * object's fields into a new object of type Student.
 * 
 * 3. Implement the  IComparable<Student> interface to compare students by names (as first criteria, 
 * in lexicographic order) and by social security number (as second criteria, in increasing order).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformation
{
    class StudentMain
    {
        static void Main(string[] args)
        {
            Student first = new Student("Georgi", "Georgiev", "Georgievi", 1235);
            Student second = new Student("Georgi", "Georgiev", "Georgiev", 1234);
            Console.WriteLine(first.CompareTo(second));
        }
    }
}
