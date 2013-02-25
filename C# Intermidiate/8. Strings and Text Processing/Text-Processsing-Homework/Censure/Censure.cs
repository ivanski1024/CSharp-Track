using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Censure
{
    class Censure
    {
        static void Main()
        {
            string dict = "PHP, CLR, Microsoft", text;
            char[] seperators = {' ', ','};
            string[] dirtyWords = dict.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
            using (StreamReader file = new StreamReader("../../../text.txt"))
            {
                text = file.ReadToEnd();
            }
            foreach (string word in dirtyWords)
            {
                //String replacer = new String(
                text = Regex.Replace(text, word, new String('*', word.Length));
            }
            Console.WriteLine(text);

        }
    }
}
