using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStrings
{
    class SortStrings
    {
        static void Main()
        {
            StreamReader input = new StreamReader("../../input.txt");
            StreamWriter output = new StreamWriter("../../output.txt");
            List<string> strings = new List<string>();
            using (input)
            {
                string line = input.ReadLine();
                while (line != null)
                {
                    strings.Add(line);
                    line = input.ReadLine();
                }
            }
            strings.Sort();
            using (output)
            {
                for (int i = 0; i < strings.Count; i++)
                {
                    output.WriteLine(strings[i]);
                }
            }
        }
    }
}
