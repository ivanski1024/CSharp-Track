using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldWithLargestSum
{
    class FieldWithLargestSum
    {
        static StreamReader input = new StreamReader("../../input.txt");
        static void Main()
        {
            int n=0;
            int[,] matrix = GetData(ref n);
            Console.WriteLine(FindMaxField(matrix, n, 2));            
        }
        static int[,] GetData(ref int n)
        {
            using (input)
            {
                n = int.Parse(input.ReadLine());
                int[,] matrix = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    string line = input.ReadLine();
                    string[] numbers = line.Split(' ');
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = int.Parse(numbers[j]);
                    }

                }
                return matrix;
            }
        }
        static int FindMaxField(int[,] matrix, int n, int s)
        {
            int maxSum = 0, currSum;

            for (int i = 0; i <= n - s; i++)
            {
                for (int j = 0; j <= n - s; j++)
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

                        }
                    }
                }
            }
            return maxSum;
        }
        static int SumOfField(int[,] matrix, int x, int y, int s)
        {
            int sum = 0;
            for (int i = x; i < x + s; i++)
            {
                for (int j = y; j < y + s; j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum;

        }
    }
}
