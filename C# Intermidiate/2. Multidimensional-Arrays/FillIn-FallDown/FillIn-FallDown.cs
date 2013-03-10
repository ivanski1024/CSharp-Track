using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillIn_FallDown
{
    class FallDown
    {
        static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[j, i] = i * n + j + 1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,-3} ", matrix[i,j]);
                }
                Console.WriteLine(); 
                Console.WriteLine();
            }
            
        }
    }
}
