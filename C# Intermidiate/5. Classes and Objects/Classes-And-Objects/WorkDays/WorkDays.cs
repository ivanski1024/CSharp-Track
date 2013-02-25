using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDays
{
    class WorkDays
    {
        static void Main()
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("Enter a date: ");
            DateTime last = DateTime.Parse(Console.ReadLine());
            StreamReader reader = new StreamReader("../../holidays.txt");
            int l;
            DateTime[] holidays;

            using (reader)
            {
                l = int.Parse(reader.ReadLine());
                holidays = new DateTime[l];
                string line;
                for (int i = 0; i < l; i++)
                {
                    line = reader.ReadLine();
                    holidays[i] = DateTime.Parse(line);
                    i++;
                }
            }

            int workdays=0;
            bool holiday = false;
            while (today.Date != last.Date.AddDays(1))
            {
                holiday = false;
                for (int i = 0; i < l; i++)
                {
                    if (holidays[i] == today)
                    {
                        holiday = true;
                        break;
                    }
                    else if(holidays[i]>=today)
                    {
                        break;
                    }

                }
                switch (today.DayOfWeek)
                {
                    case DayOfWeek.Saturday:
                        holiday = true;
                        break;
                    case DayOfWeek.Sunday:
                        holiday = true;
                        break;
                }
                if (!holiday)
                {
                    workdays++;
                }
                //Console.WriteLine(today.Date);
                today=today.AddDays(1);
            }
            Console.WriteLine("The work days from today till {0} are {1}", last.Date, workdays);
        }
    }
}
