using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CountOfSubstrings
{
    class CountOfSubstrings
    {
        static void Main()
        {
            string text;
            using(StreamReader file = new StreamReader("../../file.txt"))
            {
                text = file.ReadToEnd();
            }
            Console.WriteLine("For what string are you searching for? ");
            string lookedFor = Console.ReadLine();
            Console.WriteLine( Regex.Matches(text, lookedFor, RegexOptions.IgnoreCase).Count);
        }
    }
}
