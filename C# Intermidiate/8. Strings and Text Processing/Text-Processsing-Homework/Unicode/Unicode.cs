using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Unicode
{
    class Unicode
    {
        static void Main()
        {
            Console.WriteLine("Enter a string: ");
            string text = Console.ReadLine();
            char[] chars = text.ToArray<char>();
            StringBuilder unicode = new StringBuilder();
            foreach (char c in chars)
            {
                unicode.AppendFormat("\\u{0:x4}", (int)c); 
            }
            Console.WriteLine(unicode);
        }
    }
}
