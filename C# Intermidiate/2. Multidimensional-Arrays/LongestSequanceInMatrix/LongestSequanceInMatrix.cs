using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSequanceInMatrix
{
    class LongestSequanceInMatrix
    {
        static string[,] matrix;
        static int n, m;
        static void Main()
        {
            int maxLength = 0, currLength;
            string maxElement = "";
            GetInputData();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    currLength = TryField(i, j);
                    if (currLength > maxLength)
                    {
                        maxLength = currLength;
                        maxElement = matrix[i, j];
                    }
                }
            }
            for (int i = 0; i < maxLength; i++)
            {
                Console.Write("{0} ", maxElement);
            }
        }
        static int TryField(int x, int y)
        {
            int maxForField = 1, currForField;
            int dirX, dirY;
            dirX = -1; dirY = 0;
            currForField = 1 + GoThisWay(x, y, dirX, dirY) + GoThisWay(x, y, -1 * dirX, -1 * dirY);
            if (maxForField < currForField)
            {
                maxForField = currForField;
            }
            dirY = -1;
            for (dirX = -1; dirX < 2; dirX++)
            {
                currForField = 1 + GoThisWay(x, y, dirX, dirY) + GoThisWay(x, y, -1 * dirX, -1 * dirY);
                if (maxForField < currForField)
                {
                    maxForField = currForField;
                }
            }
            return maxForField;
        }

        private static int GoThisWay(int x, int y, int dirX, int dirY)
        {
            bool go = true;
            int lenght = 0;
            while (go)
            {
                if (x + dirX >= 0 && x + dirX < n && y + dirY >= 0 && y + dirY < m)
                {
                    if (matrix[x, y] == matrix[x + dirX, y + dirY])
                    {
                        x += dirX;
                        y += dirY;
                        lenght++;
                    }
                    else
                    {
                        go = false;
                    }
                }
                else
                {
                    go = false;
                }
            }
            return lenght;
        }
        static void GetInputData()
        {
            Console.Write("Rows = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Cols = ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an {0}x{1} sized matrix of strings with {0} rows and {1} cols.", n, m);
            matrix = new string[n, m];

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] lineMembers = line.Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = lineMembers[j];
                }
            }
        }
    }
}
