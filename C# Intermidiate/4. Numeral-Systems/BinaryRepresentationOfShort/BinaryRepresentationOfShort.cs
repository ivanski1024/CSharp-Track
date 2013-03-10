using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryRepresentationOfShort
{
    class BinaryRepresentationOfShort
    {
        static void Main()
        {
            short n = 0;
            Console.WriteLine("Enter a number of type signed short [-32768, 32767].");
            while (true)
            {
                try
                {
                    n = short.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("This isn't a number. Try again.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number is either too big or too small!\nIt should be in the range: [-32768, 32767]. Try again!");
                }
            }
            int modified = 0;
            if (n >= 0)
            {
                modified = n;
            }
            else
            {
                modified = (short.MaxValue) + (n - short.MinValue) + 1;
            }
            StringBuilder representation = new StringBuilder();
            for (int i = 0; i < 16; i++)
            {
                representation.Insert(0, modified % 2);
                modified /= 2;
            }
            Console.WriteLine(representation);
        }
    }
}
