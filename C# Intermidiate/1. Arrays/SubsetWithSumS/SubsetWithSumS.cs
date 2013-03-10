using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetWithSumS
{
    class SubsetWithSumS
    {
        static void Main()
        {
            string line = Console.ReadLine();
            string[] nums = line.Split(' ');
            int l=nums.Length;
            int[] numbers = new int[l];
            int[] bits = new int[l];
            int pow = 1;
            for (int i = 0; i < l; i++)
            {
                pow*=2;
                numbers[i] = int.Parse(nums[i]);
            }
            Console.Write("S = ");
            int s = int.Parse(Console.ReadLine());
            int subsetSum;
            bool isThereSumS = false, first = true ;
            
            for (int i = 0; i < pow; i++)
            {
                subsetSum = 0;
                for (int j = 0; j < l; j++)
                {
                    bits[j] = ((i & (1 << j)) >> j);
                    subsetSum += bits[j] * numbers[j];
                }
                if (subsetSum == s)
                {
                    if (!isThereSumS)
                    {
                        Console.Write("YES ( ");
                    }
                    first = true;
                    for (int j = 0; j < l; j++)
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
