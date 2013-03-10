using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSchool
{
    public class Person
    {
        protected string firstName;
        protected string lastName;

        public string FirstName
        {
            get 
            {
                return this.firstName;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }
        public string Name
        {
            get 
            {
                StringBuilder name = new StringBuilder();
                name.Append(this.firstName);
                name.Append(" ");
                name.Append(this.lastName);
                return name.ToString();
            }
        }
        
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
