using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TribonacciTriangle
{
    class TribonacciTriangle
    {
        static void Main()
        {
            long first, second, third, l, curr;
            first=int.Parse(Console.ReadLine());
            second = int.Parse(Console.ReadLine());
            third = int.Parse(Console.ReadLine());
            l = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}\n{1} {2}", first, second, third);
            for (int i = 3; i <= l; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    curr = first + second + third;
                    Console.Write(curr);
                    if (j != i - 1)
                    { Console.Write(" "); }
                    first = second;
                    second = third;
                    third = curr;
                }
                Console.WriteLine();
            }
        }
    }
}
