using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestAreaOfEqualNeighbours
{
    class LargestAreaOfEqualNeighbours
    {
        public struct Position
        {
            public int x, y;
            public Position(int cx, int cy)
            {
                this.x = cx;
                this.y = cy;
            }
        }
        static readonly Position[] dir = new Position[4] 
    { 
        new Position(0, 1), 
        new Position(1, 0),
        new Position(0, -1), 
        new Position(-1, 0) 
    };
        static int n, m, currSize;
        static int[,] matrix;
        static bool[,] track;

        static void Main()
        {
            GetInputData();
            Console.WriteLine("The largest area of equal neighbours is with size: {0}", LargestArea());
        }
        static int LargestArea()
        {
            int maxSize = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (!track[i, j])
                    {
                        Position current = new Position(i, j);
                        currSize = 0;
                        SizeOfField(current);
                        if (currSize > maxSize)
                        {
                            maxSize = currSize;
                        }
                    }
                }
            }
            return maxSize;
        }
        static void SizeOfField(Position current)
        {
            currSize++;
            track[current.x, current.y] = true;
            for (int i = 0; i < 4; i++)
            {
                if (((current.x + dir[i].x) >= 0) && ((current.x + dir[i].x) < n) && ((current.y + dir[i].y) >= 0) && ((current.y + dir[i].y) < m))
                {
                    if (matrix[current.x + dir[i].x, current.y + dir[i].y] == matrix[current.x, current.y] && !track[current.x + dir[i].x, current.y + dir[i].y])
                    {
                        Position step = new Position(current.x + dir[i].x, current.y + dir[i].y);
                        SizeOfField(step);
                    }
                }
            }

        }
        static void GetInputData()
        {
            Console.Write("Rows = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Cols = ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an {0}x{1} sized matrix with {0} rows and {1} cols.", n, m);
            matrix = new int[n, m];
            track = new bool[n, m];
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] numbers = line.Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(numbers[j]);
                }
            }
        }
    }
}
