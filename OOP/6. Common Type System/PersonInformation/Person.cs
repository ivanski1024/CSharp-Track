using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInformation
{
    class Person
    {
        private string Name { get; set; }
        private byte? Age { get; set; }
        public Person(string name)
        {
            this.Name = name;
            this.Age = null;
        }
        public Person(string name, byte age)
        {
            this.Name = name;
            this.Age = age;
        }
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine(string.Format("Name: {0}", this.Name));
            info.AppendLine(string.Format("Age: {0}", Age == null ? "Not Specified" : this.Age.ToString()));
            return info.ToString();
        }
    }
}
