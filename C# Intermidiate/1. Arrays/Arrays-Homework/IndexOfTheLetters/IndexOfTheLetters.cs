using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfTheLetters
{
    class IndexOfTheLetters
    {
        static void Main()
        {
            char[] alphabet = new char['Z' - 'A' + 1];
            for (int i = 0; i < 'Z' - 'A' + 1; i++)
            {
                alphabet[i] = (char)('A' + i);
            }
            string line = Console.ReadLine();
            for (int i = 0; i < line.Length; i++)
            {
                Console.WriteLine("{0} - {1}", line[i], (int)(line[i]-'A'));
            }
        }
    }
}
