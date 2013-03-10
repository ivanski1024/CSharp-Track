using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendingIEnumerable
{
    class ExtendingIEnumerable
    {
        static void Main()
        {
            double[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("The sum element:     {0}", array.Sum());
            Console.WriteLine("The product element: {0}", array.Product());
            Console.WriteLine("The min element:     {0}", array.Min());
            Console.WriteLine("The max element:     {0}", array.Max());
            Console.WriteLine("The average element: {0}", array.Average());
        }
    }
}
