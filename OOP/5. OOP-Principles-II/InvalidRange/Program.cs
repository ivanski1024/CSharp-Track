using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int intervalBegin = 1;
            int intervalEnd = 100;
            Console.OutputEncoding = Encoding.UTF8;

            RangeExceptionDemonstration.ElementInRange<int>(intervalBegin, intervalEnd, 42); //This will print positive message
            RangeExceptionDemonstration.ElementInRange<int>(intervalBegin, intervalEnd, 128); //This will throw InvalidRangeException

            DateTime timeIntervalBegin = new DateTime(1980, 1, 1);
            DateTime timeIntervalEnd = new DateTime(2013, 12, 31);

            RangeExceptionDemonstration.ElementInRange<DateTime>(timeIntervalBegin, timeIntervalEnd, DateTime.Now); //This will prove positive message
            RangeExceptionDemonstration.ElementInRange<DateTime>(timeIntervalBegin, timeIntervalEnd, new DateTime(2020, 1, 1)); //This will throw InvalidRangeException
        }
    }
}
