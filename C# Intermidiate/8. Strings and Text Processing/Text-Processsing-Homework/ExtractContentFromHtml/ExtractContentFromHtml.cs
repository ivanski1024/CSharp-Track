using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractContentFromHtml
{
    class ExtractContentFromHtml
    {
        static void Main()
        {
            string html;
            using (StreamReader file = new StreamReader("../../file.html"))
            {
                html = file.ReadToEnd();
            }
            Console.WriteLine(html);
            html=Regex.Replace(html, "</(.*?)>", "");
            html=Regex.Replace(html, "<(.*?)>", "");
            Console.WriteLine(html);
        }
    }
}
