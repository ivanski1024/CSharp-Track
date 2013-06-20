namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class PhonebookDemo
    {
        public static void Main()
        {
        }

        public static string RunProgram(string[] userInput)
        {
            Phone phone = new Phone();
            return phone.Start(userInput);
        }
    }
}