using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceWord
{
    class ReplaceWord
    {
        static void Main()
        {
            string what = @"\bstart\b";
            string with = "finish";
            using (StreamReader file = new StreamReader("../../file.txt"))
            {
                using (StreamWriter boof = new StreamWriter("../../boof.txt"))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        line = Regex.Replace(line, what, with);
                        boof.WriteLine(line);
                    }
                }
            }
            File.Delete("../../file.txt");
            File.Move("../../boof.txt", "../../file.txt");
        }
    }
}
