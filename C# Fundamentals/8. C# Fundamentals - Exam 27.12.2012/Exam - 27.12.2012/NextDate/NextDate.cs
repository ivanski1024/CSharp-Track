using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextDate
{
    class NextDate
    {
        static int day, month, year;
        static void Main()
        {
            day = int.Parse(Console.ReadLine());
            month = int.Parse(Console.ReadLine());
            year = int.Parse(Console.ReadLine());
            if (day == 28)
            {
                if (month == 2)
                {
                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    {
                        day++;
                    }
                    else
                    {
                        day = 1;
                        month++;
                    }
                }
                else
                {
                    day++;
                }
            }
            else if (day == 29)
            {
                if (month == 2)
                {
                    day = 1;
                    month++;
                }
                else
                {
                    day++;
                }
            }
            else if (day == 30)
            {
                if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    day = 1;
                    month++;
                }
                else
                {
                    day++;
                }
            }
            else if (day == 31)
            {
                if (month == 12)
                {
                    day = 1;
                    month = 1;
                    year++;
                }
                else
                {
                    day = 1;
                    month++;
                }
            }
            else 
            {
                day++;
            }
            Console.WriteLine("{0}.{1}.{2}", day, month, year);
        }
    }
}
