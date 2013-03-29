using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidRange
{
    class RangeExceptionDemonstration
    {
        public static void ElementInRange<T>(T rangeBegin, T rangeEnd, T element)
        where T : IComparable
        {
            if (element.CompareTo(rangeBegin) * element.CompareTo(rangeEnd) <= 0)
            {
                Console.WriteLine("The element {0} is in the range [{1}, {2}]", element, rangeBegin, rangeEnd);
            }
            else
            {
                throw new InvalidRangeException<T>(rangeBegin, rangeEnd, string.Format("The element {0} is not in the wanted range [{1}, {2}]", element, rangeBegin, rangeEnd));
            }
        }
    }
}
