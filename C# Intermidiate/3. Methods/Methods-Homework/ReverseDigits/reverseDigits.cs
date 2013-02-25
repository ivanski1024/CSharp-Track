using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseDigits
{
    class ReverseDigits
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(ReverseInteger(n));
        }

        static int ReverseInteger(int n)
        {
            int reversed = 0;
            while (n > 0)
            {
                reversed *= 10;
                reversed += n % 10;
                n /= 10;
            }
            return reversed;
        }
    }
}
