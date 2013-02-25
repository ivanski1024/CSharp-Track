using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetOfKElementsWithSumS
{
    class SubsetOfKElementsWithSumS
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("S = ");
            int s = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            Console.WriteLine("Enter the {0} elements of the array", n);
            int pow = 1;
            for (int i = 0; i < n; i++)
            {
                pow *= 2;
               numbers[i] = int.Parse(Console.ReadLine());
            }
            int[] bits = new int[n];
            int subsetSum;
            int countOfElements = 0;
            bool isThereSumS = false, first = true;
            for (int i = 0; i < pow; i++)
            {
                countOfElements = 0;
                subsetSum = 0;
                for (int j = 0; j < n; j++)
                {
                    bits[j] = ((i & (1 << j)) >> j);

                    countOfElements += bits[j];
                    subsetSum += bits[j] * numbers[j];
                }
                if (subsetSum == s && countOfElements==k)
                {
                    Console.Write("YES ( ");
                    first = true;
                    for (int j = 0; j < n; j++)
                    {
                        if (((i & (1 << j)) >> j) == 1)
                        {
                            if (!first)
                            {
                                Console.Write("+");
                            }
                            Console.Write(numbers[j]);
                            first = false;

                        }
                    }
                    Console.WriteLine(" )");
                    isThereSumS = true;
                    return;
                }
            }
            if (!isThereSumS)
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
