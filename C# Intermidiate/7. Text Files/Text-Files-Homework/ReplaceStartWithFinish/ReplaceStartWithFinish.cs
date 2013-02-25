using System;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace ReplaceStartWithFinish
{
    class ReplaceStartWithFinish
    {
        static void Main()
        {
            string what = "start";
            string with = "finish";
            using (StreamReader file = new StreamReader("../../file.txt"))
            {
                using (StreamWriter boof = new StreamWriter("../../boof.txt"))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        line = line.Replace(what, with);
                        boof.WriteLine(line);
                    }
                }
            }
            File.Delete("../../file.txt");
            File.Move("../../boof.txt", "../../file.txt");
            
        }
    }
}
