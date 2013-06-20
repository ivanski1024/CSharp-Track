namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Contact : IComparable<Contact>
    {
        private string name;
        private string nameCaseInsensitive;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
                this.nameCaseInsensitive = value.ToLowerInvariant();
            }
        }

        public string NameCaseInsensitive
        {
            get
            {
                return this.nameCaseInsensitive;
            }
        }

        public SortedSet<string> PhoneNumbers
        {
            get;
            set;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append('[');
            result.Append(this.Name);
            bool firstNumber = true;
            foreach (var phoneNumber in this.PhoneNumbers)
            {
                if (firstNumber)
                {
                    result.Append(": ");
                    firstNumber = false;
                }
                else
                {
                    result.Append(", ");
                }

                result.Append(phoneNumber);
            }

            result.Append(']');
            return result.ToString();
        }

        public int CompareTo(Contact other)
        {
            return this.nameCaseInsensitive.CompareTo(other.nameCaseInsensitive);
        }
    }
}
