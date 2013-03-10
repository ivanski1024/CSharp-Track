using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSchool
{
    class Student : Person
    {
        private readonly uint facultyNumber;
        private string comment;
        public uint FacultyNumber
        {
            get 
            {
                return this.facultyNumber;
            }
        } // Faculty number is set in the constructor and can't be changed afterwards.
        public string Comment
        {
            get 
            {
                return this.comment;
            }
            set
            {
                comment = value;
            }
        } // Comment can be set optionally after the initialize
        public Student(string firstName, string lastName, uint facultyNumber)
            : base(firstName, lastName)
        {
            this.facultyNumber = facultyNumber;
            this.comment = null;
        }
        public Student(Person person, uint facultyNumber)
            : base(person.FirstName, person.LastName)
        {
            this.facultyNumber = facultyNumber;
            this.comment = null;
        }
    }
}
