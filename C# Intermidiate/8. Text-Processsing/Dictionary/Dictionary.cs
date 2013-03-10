using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Dictionary
    {
        static void Main()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            string[] seperators = {" - "};
            using(StreamReader dictfile = new StreamReader("../../dict.txt"))
            {
                for (string line = dictfile.ReadLine(); line != null; line = dictfile.ReadLine())
                {
                    string[] elements = line.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

                    dict.Add(elements[0], elements[1]);
                }
            }
            Console.Write("Enter a term: ");
            string word = Console.ReadLine();
            bool found = false;
            foreach (var el in dict)
            {
                if (el.Key == word)
                {
                    Console.WriteLine(el.Value);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("\"{0}\" wasn't found!", word);
            }
        }
    }
}
