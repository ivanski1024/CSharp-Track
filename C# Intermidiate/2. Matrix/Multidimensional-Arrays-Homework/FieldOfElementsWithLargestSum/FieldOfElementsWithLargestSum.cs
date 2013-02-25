using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOfElementsWithLargestSum
{
    class FieldOfElementsWithLargestSum
    {
        static int n, m;
        static void Main()
        {
            int[,] matrix = GetData();
            FindMaxField(matrix, 3);
        }

        static void FindMaxField(int[,] matrix, int s)
        {
            int maxSum = 0, currSum, maxX = 0, maxY = 0;

            for (int i = 0; i <= n - s; i++)
            {
                for (int j = 0; j <= m - s; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        maxSum = SumOfField(matrix, i, j, s);
                    }
                    else
                    {
                        currSum = SumOfField(matrix, i, j, s);
                        if (currSum > maxSum)
                        {
                            maxSum = currSum;
                            maxX = i;
                            maxY = j;

                        }
                    }
                }
            }
            return maxSum;
        }

        static void PrintThatField(int[,] matrix, int maxX, int maxY, int s)
        {
            for (int i = maxX; i < maxX + s; i++)
            {
                for (int j = maxY; j < maxY + s; j++)
                {
                    Console.Write("{0,-3}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        static int SumOfField(int[,] matrix, int x, int y, int s)
        {
            int sum = 0;
            for (int i = x; i < x+s; i++)
            {
                for (int j = y; j < y+s; j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum;

        }

        static int[,] GetData()
        {
            //Console.Write("N = ");
            n = int.Parse(Console.ReadLine());
            //Console.Write("M = ");
            m = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter an {0}x{1} sized matrix with {0} rows and {1} cols.", n, m);
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] numbers = line.Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(numbers[j]);
                }

            }
            return matrix;
        }
    }
}
