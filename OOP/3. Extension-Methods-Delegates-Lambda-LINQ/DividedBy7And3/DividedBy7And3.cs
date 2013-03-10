using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividedBy7And3
{
    class DividedBy7And3
    {
        static void Main()
        {
            int[] array = { 3, 6, 7, 9, 12, 14, 15, 18, 21, 24, 27, 28, 31, 34, 35, 38, 41, 42 };
            foreach (int number in Divided.DividedNumbers(array)) // Prints numbers that are dividable with Lamba Expression
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();

            foreach (int number in Divided.DividedNumbersLinq(array)) // Prints numbers that are dividable with LINQ
            {
                Console.Write("{0} ", number);
            }
            
            Console.WriteLine();
        }
    }
}
