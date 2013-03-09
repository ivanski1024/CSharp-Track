using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Student
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public Student(string first, string last)
        {
            this.FirstName = first;
            this.LastName = last;
        }
        
        public Student(string first, string last, byte age)
        {
            this.FirstName = first;
            this.LastName = last;
            if (age < 120)
            {
                this.Age = age;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
