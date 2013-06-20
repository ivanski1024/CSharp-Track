namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface IPhonebookRepository
    {
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
        bool AddPhone(string name, IEnumerable<string> phoneNumbers);

        /// <summary>
        /// Replaces every occurance in your phonebook of a number with another one.
        /// </summary>
        /// <param name="oldPhoneNumber">The number you want to replace.</param>
        /// <param name="newPhoneNumber">The number with which you want to replace the old one.</param>
        /// <returns>The count of the replace numbers.</returns>
        int ChangePhoneNumber(string oldPhoneNumber, string newPhoneNumber);

        /// <summary>
        /// Lists a range of entries in the Phonebook. 
        /// </summary>
        /// <param name="startIndex">The start index of the range.</param>
        /// <param name="count">The count of elements</param>
        /// <returns>Returns array of contacts.</returns>
        Contact[] ListEntries(int startIndex, int count);
    }
}
