using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendingIEnumerable
{
    static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> input) where T : IComparable
        {
            dynamic sum = 0;
            foreach (var element in input)
            {
                sum += element;
            }
            return sum;
        }
        public static T Product<T>(this IEnumerable<T> input) where T : IComparable
        {
            dynamic product = 1;
            foreach (var element in input)
            {
                product *= element;
            }
            return product;
        }
        public static T Min<T>(this IEnumerable<T> input) where T : IComparable
        {
            bool first=true;
            dynamic min = 0;
            foreach (var element in input)
            {
                if (first)
                {
                    min = element;
                    first = false;
                }
                else 
                {
                    if (min.CompareTo(element) > 0)
                    {
                        min = element;
                    }
                }
            }
            return min;
        }
        public static T Max<T>(this IEnumerable<T> input) where T : IComparable
        {
            bool first = true;
            dynamic max = 0;
            foreach (var element in input)
            {
                if (first)
                {
                    max = element;
                    first = false;
                }
                else
                {
                    if (max.CompareTo(element) < 0)
                    {
                        max = element;
                    }
                }
            }
            return max;
        }
        public static T Average<T>(this IEnumerable<T> input) where T : IComparable
        {
            dynamic average = 0;
            int count=0;
            foreach (var element in input)
            {
                average += element;
                count++;
            }
            average /= count;
            return average;
        }
    }
}
