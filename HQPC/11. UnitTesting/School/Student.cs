namespace School
{
    using System;
    using System.Linq;

    public class Student
    {
        private string name;

        private int number;

        public Student(string name, int number)
        {
            this.Name = name;
            this.Number = number;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name can't be null!");
                }
                else if (value == string.Empty)
                {
                    throw new ArgumentException("Name can't be empty!");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public int Number
        {
            get
            {
                return this.number;
            }

            set
            {
                if (value < 10000 || 99999 < value)
                {
                    throw new ArgumentOutOfRangeException("Student's number should be between 10000 and 99999!");
                }
                else
                {
                    this.number = value;
                }
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is Student)
            {
                if ((this.Name == (obj as Student).name) &&
                    (this.Number == (obj as Student).Number))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }
    }
}
