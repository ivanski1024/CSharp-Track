using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheets
{
    class Sheets
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[11];
            int i=0;
            while (n > 0)
            {
                A[i] = n % 2;
                n /= 2;
                i++;
            }
            for (int j = 10; j >=0; j--)
            {
                if (A[j] == 0)
                {
                    Console.WriteLine("A{0}", 10-j);
                }
            }
        }
    }
}
