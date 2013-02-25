using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareLineByLine
{
    class CompareLineByLine
    {
        static void Main()
        {
            StreamReader first = new StreamReader("../../first.txt");
            StreamReader second = new StreamReader("../../second.txt");
            int lines=0, same=0;
            string line;
            using (first)
            {
                using (second)
                {
                    do
                    {
                        line = first.ReadLine();
                        if (string.Compare(line, second.ReadLine()) == 0)
                        {
                            same++;
                        }
                        lines++;
                    } while (line != null);
                }
            }
            lines--;
            same--;

            Console.WriteLine("The count of the same lines: {0}\nThe count of the different lines: {1}", same, lines-same);
        }
    }
}
