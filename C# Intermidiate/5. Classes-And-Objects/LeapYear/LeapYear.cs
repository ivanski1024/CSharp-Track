using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class LeapYear
    {
        static void Main()
        {
            do
            {
                try
                {
                    Console.WriteLine("Enter a date:");
                    Console.WriteLine("Is the year of the date you entered a leap one? {0}", DateTime.IsLeapYear( DateTime.Parse(Console.ReadLine()).Year));
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The date format should be: MM.DD.YYYY");
                }
            } while (true);
        }
    }
}
