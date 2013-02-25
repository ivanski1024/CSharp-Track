using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertingLineNumbers
{
    class InsertingLineNumbers
    {
        static void Main()
        {
            StreamReader input = new StreamReader("../../input.txt");
            StreamWriter output = new StreamWriter("../../output.txt");
            string line;
            using (input)
            {
                using (output)
                {
                    int lineNumber = 1;
                    do
                    {
                        line = input.ReadLine();
                        output.WriteLine("{0}. {1}", lineNumber, line);
                        lineNumber++;
                    }
                    while (line != null);
                }
            }
        }
    }
}
