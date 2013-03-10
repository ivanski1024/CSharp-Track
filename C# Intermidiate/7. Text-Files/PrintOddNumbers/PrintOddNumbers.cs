using System;
using System.IO;
using System.Linq;

namespace PrintOddNumbers
{
    class PrintOddNumbers
    {
        static void Main()
        {
            StreamReader input = new StreamReader(@"../../input.txt");
            using (input)
            {
                string line;
                int counter = 0;
                do
                {
                    line = input.ReadLine();
                    if (counter % 2 == 0)
                    {
                        Console.WriteLine(line);
                    }
                    counter++;
                }
                while (line != null);
            }
        }
    }
}
