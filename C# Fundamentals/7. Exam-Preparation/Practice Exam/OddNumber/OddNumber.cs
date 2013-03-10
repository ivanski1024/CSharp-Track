using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber
{
    class OddNumber
    {
        public struct number
        {
            public long num;
            public byte oddOrEven;
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            number[] numbers = new number[(n+1)/2];
            long currNumber;
            int count=0;
            bool found;
            for (int i = 0; i < n; i++) 
            {
                currNumber = long.Parse(Console.ReadLine());
                found = false;
                for (int j = 0; j < count; j++)
                {
                    if (numbers[j].num == currNumber) 
                    {
                        if (numbers[j].oddOrEven == 0) 
                        { numbers[j].oddOrEven = 1; }
                        else
                        { numbers[j].oddOrEven = 0; }
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    numbers[count].num = currNumber;
                    numbers[count].oddOrEven = 1;
                    count++;
                }
            }
            foreach (number k in numbers)
            {
                if (k.oddOrEven == 1)
                {
                    Console.WriteLine(k.num);
                    break;
                }
            }
        }
    }
}
