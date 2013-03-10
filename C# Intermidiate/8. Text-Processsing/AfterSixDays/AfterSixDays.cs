using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterSixDays
{
    class AfterSixDays
    {
        static void Main()
        {
            Console.Write("Enter date and time (day.month.year hour:minute:second): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy h:m:s", CultureInfo.InvariantCulture);
            date = date.AddHours(6.5);
            Console.WriteLine("After six and a half hours it will be: {0} {1}", date.ToString("d.M.yyyy h:m:s"), date.ToString("dddd"));

            // 16.7.1993 9:30:23

        }
    }
}
