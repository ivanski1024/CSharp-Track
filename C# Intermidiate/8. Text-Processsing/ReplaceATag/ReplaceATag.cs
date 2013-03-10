using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceATag
{
    class ReplaceATag
    {
        static void Main()
        {
            string text;
            using(StreamReader file = new StreamReader("../../file.txt"))
            {
                text = file.ReadToEnd();
            }
            text = text.Replace("<a href=\"", "[URL=");
            text = text.Replace("\">", "]");
            text = text.Replace("</a>", "[/URL]");
            Console.WriteLine(text);
        }
    }
}
