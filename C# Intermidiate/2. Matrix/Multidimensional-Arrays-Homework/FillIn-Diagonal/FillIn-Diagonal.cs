using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillIn_Diagonal
{
    class Diagonal
    {
        static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int x = 1;
            for (int sum = 0; sum < n; sum++)
            {
                for (int i = sum; i >= 0; i--)
                {
                    matrix[n-i-1, sum-i] = x;
                    x++;
                }
            }
            for (int sum = n; sum <= 2 * n - 2; sum++)
            {
                for (int i = n-1; i >=sum - n + 1  ; i--)
                {
                    matrix[n-i-1, sum - i] = x;
                    x++;
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
