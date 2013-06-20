using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Phonebook.Tests
{
    [TestClass]
    public class ListPhonebookRepositoryTest
    {
        [TestMethod]
        public void AddPhoneTest1()
        {
            ListPhonebookRepository phonebook = new ListPhonebookRepository();
            List<string> numbers = new List<string>();
            numbers.Add("+359888888888");
            Assert.AreEqual(true, phonebook.AddPhone("Pesho", numbers));
        }

        [TestMethod]
        public void AddPhoneTest2()
        {
            ListPhonebookRepository phonebook = new ListPhonebookRepository();
            List<string> numbers = new List<string>();
            numbers.Add("+359888888888");
            phonebook.AddPhone("Pesho", numbers);
            numbers.Clear();
            numbers.Add("+359889999999");
            Assert.AreEqual(false, phonebook.AddPhone("Pesho", numbers));
        }

        [TestMethod]
        public void ChangePhoneNumberTest1()
        {
            ListPhonebookRepository phonebook = new ListPhonebookRepository();
            List<string> numbers = new List<string>();
            numbers.Add("+359888888888");
            phonebook.AddPhone("Pesho", numbers);
            phonebook.AddPhone("Gosho", numbers);
            Assert.AreEqual(2, phonebook.ChangePhoneNumber("+359888888888", "+359888999999"));
        }

        [TestMethod]
        public void ListEntriesTest1()
        {
            ListPhonebookRepository phonebook = new ListPhonebookRepository();
            SortedSet<string> numbers = new SortedSet<string>();
            numbers.Add("+359888888888");
            phonebook.AddPhone("Pesho", numbers);
            phonebook.AddPhone("Gosho", numbers);

            Contact[] expectedEntries = new Contact[2];
            expectedEntries[0] = new Contact();
            expectedEntries[0].Name = "Gosho";
            expectedEntries[0].PhoneNumbers = numbers;
            expectedEntries[1] = new Contact();
            expectedEntries[1].Name = "Pesho";
            expectedEntries[1].PhoneNumbers = numbers;

            Contact[] entries = phonebook.ListEntries(0, 2);

            Assert.AreEqual(2, entries.Length);
            for (int index = 0; index < 2; index++)
            {
                Assert.AreEqual(expectedEntries[index].ToString(), entries[index].ToString());
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ListEntriesTest2()
        {
            ListPhonebookRepository phonebook = new ListPhonebookRepository();
            SortedSet<string> numbers = new SortedSet<string>();
            numbers.Add("+359888888888");
            phonebook.AddPhone("Pesho", numbers);
            phonebook.AddPhone("Gosho", numbers);

            Contact[] entries = phonebook.ListEntries(0, 3);
        }

    }
}
