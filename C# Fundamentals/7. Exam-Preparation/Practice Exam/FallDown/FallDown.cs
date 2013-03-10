using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallDown
{
    class FallDown
    {
        static void Main()
        {
            byte[] numbers = new byte[8];
            byte[] bits = new byte[8];
            byte[] powersOfTwo = new byte[8];
            byte curr, power;
            for (int i = 0; i < 8; i++)
            {
                power = 1;
                curr = byte.Parse(Console.ReadLine());
                for (int j = 0; j < 8; j++)
                {
                    if ((curr & (1 << j)) >> j == 1) 
                    {
                        bits[j]++;
                    }
                    if (j < i) { power *= 2; }
                }
                powersOfTwo[i] = power;
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < bits[i]; j++)
                {
                    numbers[j] += powersOfTwo[i];
                }
                //Console.WriteLine("2 ^ {0} = {1}", i, powersOfTwo[i]);
            }
            for (int i = 7; i >= 0; i--) 
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
