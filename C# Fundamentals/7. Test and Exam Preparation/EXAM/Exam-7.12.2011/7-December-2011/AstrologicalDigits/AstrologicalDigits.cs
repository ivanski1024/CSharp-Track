using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstrologicalDigits
{
    class AstrologicalDigits
    {
        static void Main()
        {
            string N = Console.ReadLine();
            int n = 0, currN;
            for (int i = 0; i < N.Length; i++)
            {
                if (N[i] >= '0' && N[i] <= '9')
                {
                    n += N[i] - '0';
                }
            }
            while (n > 9)
            {
                currN = 0;
                while (n > 0)
                {

                    currN += n % 10;
                    n /= 10;
                }
                n = currN;
            }
            Console.WriteLine(n);
        }
    }
}
