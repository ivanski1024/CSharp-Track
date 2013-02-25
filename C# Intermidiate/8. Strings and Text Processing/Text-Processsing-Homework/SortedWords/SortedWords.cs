using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedWords
{
    class SortedWords
    {
        static void Main()
        {
            Console.WriteLine("Enter list of words seperated with spaces: ");
            string list = Console.ReadLine();
            string[] separators = { " " };
            string[] words = list.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words);
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
