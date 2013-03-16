using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSchool
{
    class Teacher : Person
    {
        private List<Discipline> disciplines; // The list of disciplines can be created in the constructor and/or could be added afterwards
        private string comment;
        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }
            set
            {
                this.disciplines = value;
            }
        }

        public Teacher(string firstName, string lastName)
            : base(firstName, lastName)
        {
            this.disciplines = new List<Discipline>();
            comment = null;
        }
        public Teacher(Person person)
            : base(person.FirstName, person.LastName)
        {
            this.disciplines = new List<Discipline>();
            comment = null;
        }
        public Teacher(string firstName, string lastName, List<Discipline> disciplines)
            : base(firstName, lastName)
        {
            this.disciplines = disciplines;
            comment = null;
        }
        public Teacher(Person person, List<Discipline> disciplines)
            : base(person.FirstName, person.LastName)
        {
            this.disciplines = disciplines;
            comment = null;
        }

        public void AddDiscipline(Discipline discipline)
        {
            disciplines.Add(discipline);
        }
    }
}
