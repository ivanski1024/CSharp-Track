namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Phone
    {
        private const string Code = "+359";
        private IPhonebookRepository data;
        private StringBuilder output;

        public Phone()
        {
            this.data = new DictionaryPhonebookRepository();
            this.output = new StringBuilder();
        }

        public string Start()
        {
            List<string> userInput = new List<string>();
            string input;
            do
            {
                input = Console.ReadLine();
                userInput.Add(input);
            }
            while (input != "End");

            return this.Run(userInput.ToArray());
        }

        public string Start(string[] userInput)
        {
            return this.Run(userInput);
        }

        private string Run(string[] userInput)
        {
            int indexOfInput = 0;
            while (true)
            {
                string input = userInput[indexOfInput];
                indexOfInput++;
                if (input == "End" || input == null)
                {
                    break;
                }
                else
                {
                    int indexOfFirstBracket = input.IndexOf('(');
                    if (indexOfFirstBracket == -1)
                    {
                        Console.WriteLine("error!");
                        Environment.Exit(0);
                    }

                    string command = input.Substring(0, indexOfFirstBracket);

                    string s = input.Substring(indexOfFirstBracket + 1, input.Length - indexOfFirstBracket - 2);
                    string[] strings = s.Split(',');
                    for (int j = 0; j < strings.Length; j++)
                    {
                        strings[j] = strings[j].Trim();
                    }

                    if (command.StartsWith("AddPhone") && (strings.Length >= 2))
                    {
                        this.ExecuteCommand("AddPhone", strings);
                    }
                    else if ((command == "ChangePhone") && (strings.Length == 2))
                    {
                        this.ExecuteCommand("ChangeРhone", strings);
                    }
                    else if ((command == "List") && (strings.Length == 2))
                    {
                        this.ExecuteCommand("List", strings);
                    }
                    else
                    {
                        throw new StackOverflowException();
                    }
                }
            }

            return this.output.ToString();
        }

        private void ExecuteCommand(string command, string[] arguments)
        {
            switch (command)
            {
                case "AddPhone":

                    string name = arguments[0];
                    var phoneNumbers = arguments.Skip(1).ToList();
                    for (int number = 0; number < phoneNumbers.Count; number++)
                    {
                        phoneNumbers[number] = this.ConvertNumber(phoneNumbers[number]);
                    }

                    bool isCreated = this.data.AddPhone(name, phoneNumbers);

                    if (isCreated)
                    {
                        this.Print("Phone entry created");
                    }
                    else
                    {
                        this.Print("Phone entry merged");
                    }

                    break;
                case "ChangeРhone":
                    this.Print(
                        string.Format(
                        "{0} numbers changed",
                        this.data.ChangePhoneNumber(this.ConvertNumber(arguments[0]), this.ConvertNumber(arguments[1]))));
                    break;
                case "List":
                    try
                    {
                        IEnumerable<Contact> entries = this.data.ListEntries(int.Parse(arguments[0]), int.Parse(arguments[1]));
                        foreach (var entry in entries)
                        {
                            Print(entry.ToString());
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Print("Invalid range");
                    }

                    break;
            }
        }

        private string ConvertNumber(string number)
        {
            StringBuilder result = new StringBuilder();

            for (int index = 0; index <= result.Length; index++)
            {
                result.Clear();

                foreach (char ch in number)
                {
                    if (char.IsDigit(ch) || (ch == '+'))
                    {
                        result.Append(ch);
                    }
                }

                if (result.Length >= 2 && result[0] == '0' && result[1] == '0')
                {
                    result.Remove(0, 1);
                    result[0] = '+';
                }

                while (result.Length > 0 && result[0] == '0')
                {
                    result.Remove(0, 1);
                }

                if (result.Length > 0 && result[0] != '+')
                {
                    result.Insert(0, Code);
                }
            }

            return result.ToString();
        }

        private void Print(string text)
        {
            output.AppendLine(text);
        }
    }
}