using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UpperCase
{
    class UpperCase
    {
        static void Main()
        {
            string text;
            using (StreamReader file = new StreamReader("../../file.txt"))
            {
                text = file.ReadToEnd();
            }
            text = Regex.Replace(text, "<upcase>(.*?)</upcase>", x => x.Value.ToUpper());
            text = Regex.Replace(text, "<UPCASE>", "");
            text = Regex.Replace(text, "</UPCASE>", "");
            Console.WriteLine(text);
        }
    }
}
