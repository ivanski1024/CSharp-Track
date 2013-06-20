using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace Phonebook
{
    public class DictionaryPhonebookRepository : IPhonebookRepository
    {
        private OrderedSet<Contact> sortedContacts;
        private Dictionary<string, Contact> contactList;
        private MultiDictionary<string, Contact> multidict;

        public DictionaryPhonebookRepository()
        {
            this.sortedContacts = new OrderedSet<Contact>();
            this.contactList = new Dictionary<string, Contact>();
            this.multidict = new MultiDictionary<string, Contact>(false);
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
        public bool AddPhone(string name, IEnumerable<string> phoneNumbers)
        {
            string contactName = name.ToLowerInvariant();
            Contact contact;
            bool isFound = !this.contactList.TryGetValue(contactName, out contact);
            if (isFound)
            {
                contact = new Contact();
                contact.Name = name;
                contact.PhoneNumbers = new SortedSet<string>();
                this.contactList.Add(contactName, contact);
                this.sortedContacts.Add(contact);
            }

            foreach (var num in phoneNumbers)
            {
                this.multidict.Add(num, contact);
            }

            contact.PhoneNumbers.UnionWith(phoneNumbers);
            return isFound;
        }

        /// <summary>
        /// Replaces every occurance in your phonebook of a number with another one.
        /// </summary>
        /// <param name="oldPhoneNumber">The number you want to replace.</param>
        /// <param name="newPhoneNumber">The number with which you want to replace the old one.</param>
        /// <returns>The count of the replace numbers.</returns>
        public int ChangePhoneNumber(string oldPhoneNumber, string newPhoneNumber)
        {
            var found = this.multidict[oldPhoneNumber].ToList();
            foreach (var entry in found)
            {
                entry.PhoneNumbers.Remove(oldPhoneNumber);
                this.multidict.Remove(oldPhoneNumber, entry);

                entry.PhoneNumbers.Add(newPhoneNumber);
                this.multidict.Add(newPhoneNumber, entry);
            }

            return found.Count;
        }

        /// <summary>
        /// Lists a range of entries in the Phonebook. 
        /// </summary>
        /// <param name="startIndex">The start index of the range.</param>
        /// <param name="count">The count of elements</param>
        /// <returns>Returns array of contacts.</returns>
        public Contact[] ListEntries(int startIndex, int count)
        {
            if (startIndex < 0 || this.contactList.Count < startIndex + count)
            {
                throw new ArgumentOutOfRangeException("Invalid start index or count.");
            }

            Contact[] resultEntries = new Contact[count];

            for (int index = 0; index < count; index++)
            {
                resultEntries[index] = this.sortedContacts[startIndex + index];
            }

            return resultEntries;
        }
    }
}