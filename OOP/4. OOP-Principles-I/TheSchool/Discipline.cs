using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSchool
{
    class Discipline
    {
        private readonly string name;
        private uint lectures;
        private uint exercises;
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
        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public uint Lectures
        {
            get
            {
                return this.lectures;
            }
            set
            {
                this.lectures = value;
            }
        }
        public uint Exercises
        {
            get
            {
                return this.exercises;
            }
            set
            {
                this.exercises = value;
            }
        }
        public Discipline(string name, uint lectures, uint exercises)
        {
            this.name = name;
            this.lectures = lectures;
            this.exercises = exercises;
            comment = null;
        }
    }
}