using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillIn_Snake
{
    class Snake
    {
        static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int x=1;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[j, i] = x;
                        x++;
                    }
                }
                else
                {
                    for (int j = n-1; j > -1; j--)
                    {
                        matrix[j, i] = x;
                        x++;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,-3} ", matrix[i, j]);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            
        }
    }
}
