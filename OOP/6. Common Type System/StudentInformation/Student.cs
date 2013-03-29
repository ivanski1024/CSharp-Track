using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformation
{
    class Student : ICloneable, IComparable<Student>
    {
        public enum UniversityEnum
        {
            SU,
            TU,
            LTU,
            NBU
        }
        public enum FacultyEnum
        {
            FMI,
            HF,
            FF,
            FZF,
            SF
        }
        public enum SpecialtyEnum
        {
            ComputerScience,
            Informatics,
            SoftwareEngineering,
            InformationSystems,
            AppliedMathematics
        }

        public Student(string firstName, string middleName, string lastName, int ssn)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.ssn = ssn;
        }

        string firstName, middleName, lastName, address, phone;
        int ssn;
        private Student.UniversityEnum university;
        private Student.FacultyEnum faculty;
        private Student.SpecialtyEnum specialty;
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        }
        public string MiddleName
        {
            get
            {
                return this.middleName;
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
                return string.Format("{0} {1} {2}", this.firstName, this.middleName, this.lastName);
            }
        }
        public int SSN
        {
            get
            {
                return this.ssn;
            }
        }
        public string Address
        {
            get
            {
                return this.address;
            }
        }
        public string Phone
        {
            get
            {
                return this.phone;
            }
        }
        public UniversityEnum University
        {
            get
            {
                return this.university;
            }
        }
        public FacultyEnum Faculty
        {
            get
            {
                return this.faculty;
            }
        }
        public SpecialtyEnum Specialty
        {
            get
            {
                return this.specialty;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is Student)
            {
                if (
                    this.Name.Equals((obj as Student).Name) &&
                    this.SSN.Equals((obj as Student).SSN) &&
                    this.Address.Equals((obj as Student).Address) &&
                    this.Phone.Equals((obj as Student).Phone) &&
                    this.University.Equals((obj as Student).University) &&
                    this.Faculty.Equals((obj as Student).Faculty) &&
                    this.Specialty.Equals((obj as Student).Specialty))
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
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(string.Format("Student: {0}", this.Name));
            output.AppendLine(string.Format("SSN: {0}", this.ssn));
            output.AppendLine(string.Format("Address: {0}", this.address));
            output.AppendLine(string.Format("Phone: {0}", this.phone));
            output.AppendLine(string.Format("University: {0}", this.university));
            output.AppendLine(string.Format("Faculty: {0}", this.faculty));
            output.AppendLine(string.Format("Specialty: {0}", this.specialty));
            return output.ToString();
        }
        public override int GetHashCode()
        {
            // TODO: Implement GetHashCode()
            return base.GetHashCode();
        }
        public static bool operator ==(Student left, Student right)
        {
            return Student.Equals(left, right);
        }
        public static bool operator !=(Student left, Student right)
        {
            return !Student.Equals(left, right);
        }
        public Object Clone()
        {
            Student clone = new Student((string)this.firstName.Clone(), (string)this.middleName.Clone(), (string)this.lastName.Clone(), this.ssn);
            clone.address = (string)this.address.Clone();
            clone.phone = (string)this.phone.Clone();
            clone.university = this.university;
            clone.faculty = this.faculty;
            clone.specialty = this.specialty;
            return clone;
        }
        public int CompareTo(Student student)
        {
            int queficient = this.Name.CompareTo(student.Name);
            if (queficient == 0)
            {
               return this.ssn.CompareTo(student.ssn);
            }
            else
            {
                return queficient;
            }
        }
    }
}
