using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestElementLowerThanK
{
    class BiggestElementLowerThanK
    {
        static int[] array;
        static int n, k;
        static void Main()
        {
            GetInputData();
            Array.Sort(array);
            int pos = Array.BinarySearch(array, k);
            if (pos == -1)
            {
                Console.WriteLine("There isn't such number in the array which is <= {0}", k);
            }
            else
            {
                if (pos < -1)
                {
                    pos = pos * -1 - 2;
                }
                Console.WriteLine("The largest number in the array that is <= {0} is: {1}", k, array[pos]);
            }
        }
        private static void GetInputData()
        {
            Console.Write("N = "); 
            n = int.Parse(Console.ReadLine());
            array = new int[n];
            Console.WriteLine("Enter the {0} integers each seperated with ' '", n);
            string line;
            string[] numbers;
            int l = 0;
            do
            {
                line = Console.ReadLine();
                numbers = line.Split(' ');
                l = numbers.Length;
            }
            while (l != n);
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(numbers[i]);
            }
            Console.Write("K = ");
            k = int.Parse(Console.ReadLine());
        }
    }
}
