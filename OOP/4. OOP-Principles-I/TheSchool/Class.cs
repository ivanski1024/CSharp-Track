using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSchool
{
    class ElementAlreadyExists : System.Exception
    {
        
    }
    class Class
    {
        private List<Student> students;
        private List<Teacher> teachers;
        private string comment;
        public List<Student> Students
        {
            get 
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }

        public List<Teacher> Teachers
        {
            get 
            {
                return this.teachers;
            }
            set
            {
                this.teachers = value;
            }
        }

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

        public Class(List<Student> students)
        {
            this.students = students;
            this.teachers = new List<Teacher>();
            comment = null;
        }
        public Class(List<Student> students, List<Teacher> teachers)
        {
            this.students = students;
            this.teachers = teachers;
            comment = null;
        }

        public void AddTeacher(Teacher teacher)
        {
            if(teachers.IndexOf(teacher)<0)
            {
                teachers.Add(teacher);
            }
            else
            {
                throw new ElementAlreadyExists();
            }
        }

    
    }
}
