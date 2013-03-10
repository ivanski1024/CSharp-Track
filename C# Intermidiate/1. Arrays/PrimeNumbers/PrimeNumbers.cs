using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main()
        {
            StringBuilder nums = new StringBuilder();
            bool[] numbers = new bool[10000000];
            long i = 2;
            int counter = 0;
            while (i < 10000000)
            {
                if (!numbers[i])
                {
                    long j = 2*i;
                    while (j < 10000000)
                    {
                        numbers[j] = true;
                        j += i;
                    }
                    nums.Append(i);
                    nums.Append(" ");
                    counter++;
                }
                i++;
            }
            nums.Append(counter);
            Console.WriteLine(nums);
        }
    }
}
