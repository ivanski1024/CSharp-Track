namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ListPhonebookRepository : IPhonebookRepository
    {
        public ListPhonebookRepository()
        {
            this.ContactList = new List<Contact>();
        }

        public List<Contact> ContactList
        {
            get;
            set;
        }

        /// <summary>
        /// Adds new contact in the phonebook if contact with the same name doesn't exist. 
        /// If contact with the same name does exist it extends the list of it's phonenumbers.
        /// </summary>
        /// <param name="name">The name of the contact</param>
        /// <param name="phoneNumbers">The phonenumbers you want to add in the contact</param>
        /// <returns>
        /// Returns true if the contact was added and false 
        /// if a contact with the same name was found and then extended.
        /// </returns>
        public bool AddPhone(string name, IEnumerable<string> numbers)
        {
            var currentEntries =
                     from entry in this.ContactList
                     where entry.NameCaseInsensitive == name.ToLowerInvariant()
                     select entry;

            bool existedTillNow;

            switch (currentEntries.Count())
            {
                case 0:
                    Contact newContact = new Contact();
                    newContact.Name = name;
                    newContact.PhoneNumbers = new SortedSet<string>();

                    foreach (var number in numbers)
                    {
                        newContact.PhoneNumbers.Add(number);
                    }

                    this.ContactList.Add(newContact);

                    existedTillNow = true;
                    break;

                case 1:
                    Contact currentContact = currentEntries.First();
                    foreach (var number in numbers)
                    {
                        currentContact.PhoneNumbers.Add(number);
                    }

                    existedTillNow = false;
                    break;

                default:
                    Console.WriteLine("Duplicated name in the phonebook found: " + name);
                    return false;
            }

            return existedTillNow;
        }

        /// <summary>
        /// Replaces every occurance in your phonebook of a number with another one.
        /// </summary>
        /// <param name="oldPhoneNumber">The number you want to replace.</param>
        /// <param name="newPhoneNumber">The number with which you want to replace the old one.</param>
        /// <returns>The count of the replace numbers.</returns>
        public int ChangePhoneNumber(string oldPhoneNumber, string newPhoneNumber)
        {
            var favorableContacts =
                from contact in this.ContactList
                where contact.PhoneNumbers.Contains(oldPhoneNumber)
                select contact;

            int nums = 0;

            foreach (var contact in favorableContacts)
            {
                contact.PhoneNumbers.Remove(oldPhoneNumber);
                contact.PhoneNumbers.Add(newPhoneNumber);
                nums++;
            }

            return nums;
        }

        /// <summary>
        /// Lists a range of entries in the Phonebook. 
        /// </summary>
        /// <param name="startIndex">The start index of the range.</param>
        /// <param name="count">The count of elements</param>
        /// <returns>Returns array of contacts.</returns>
        public Contact[] ListEntries(int startIndex, int count)
        {
            if (startIndex < 0 || this.ContactList.Count < startIndex + count)
            {
                throw new ArgumentOutOfRangeException("Invalid start index or count.");
            }

            this.ContactList.Sort();
            Contact[] resultEntries = new Contact[count];

            for (int index = 0; index < count; index++)
            {
                resultEntries[index] = this.ContactList[startIndex + index];
            }

            return resultEntries;
        }
    }
}