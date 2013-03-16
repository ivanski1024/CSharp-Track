using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHuman
{
    class Student : Human
    {
        private float grade;
        public Student(string firstName, string lastName, float grade) : base (firstName, lastName)
        {
            this.grade = grade;
        }

        public float Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                this.grade = value;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(this.Name);
            str.Append(" ");
            str.Append(this.Grade);
            return str.ToString();
        }
    }
}
