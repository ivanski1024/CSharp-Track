using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatenateTwoFiles
{
    class ConcatenateTwoFiles
    {
        static void Main()
        {
            StreamWriter concatenated = new StreamWriter(@"../../cancatenated.txt");
            StreamReader first = new StreamReader(@"../../first.txt");
            StreamReader second = new StreamReader(@"../../second.txt");
            using (concatenated)
            {
                using (first)
                {
                    concatenated.WriteLine(first.ReadToEnd());
                }
                using (second)
                {
                    concatenated.WriteLine(second.ReadToEnd());
                }
            }
        }
    }
}