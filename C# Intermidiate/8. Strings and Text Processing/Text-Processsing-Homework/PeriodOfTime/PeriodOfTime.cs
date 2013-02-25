using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodOfTime
{
    class PeriodOfTime
    {
        static void Main()
        {
            Console.Write("Enter the first date: ");
            DateTime begin = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            Console.Write("Enter the second date: ");
            DateTime end = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            TimeSpan period = end - begin;
            Console.WriteLine("Distance: {0} days", period.Days);
        }
    }
}
