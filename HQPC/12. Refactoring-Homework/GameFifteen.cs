namespace GameFifteen
{
    using System;
    using System.Text;

    public static class GameFifteen
    {
        public static void Main(string[] args)
        {
            int n = 6;

            PrintMatrix(GenerateMatrix(n), n);
        }

        public static void PrintMatrix(int[,] matrix, int n)
        {
            StringBuilder output = new StringBuilder();
            for (int pp = 0; pp < n; pp++)
            {
                for (int qq = 0; qq < n; qq++)
                {
                    output.AppendFormat("{0,3}", matrix[pp, qq]);
                }

                output.AppendLine();
            }

            Console.WriteLine(output);
        }

        public static int[,] GenerateMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            int currentNumber = 1,
                row = 0,
                col = 0,
                deltaRow = 1,
                deltaCol = 1;
            while (true)
            {
                matrix[row, col] = currentNumber;

                if (!Check(matrix, row, col))
                {
                    break;
                }

                while (row + deltaRow < 0 || n <= row + deltaRow ||
                       col + deltaCol < 0 || n >= col + deltaCol ||
                       matrix[row + deltaRow, col + deltaCol] != 0)
                {
                    Change(ref deltaRow, ref deltaCol);
                }

                row += deltaRow;
                col += deltaCol;
                currentNumber++;
            }

            FindFirstFreeCell(matrix, out row, out col);

            currentNumber++;
            if (row != 0 && col != 0)
            {
                deltaRow = 1;
                deltaCol = 1;

                while (true)
                {
                    matrix[row, col] = currentNumber;

                    if (!Check(matrix, row, col))
                    {
                        break;
                    }

                    while (row + deltaRow < 0 || n <= row + deltaRow ||
                           col + deltaCol < 0 || col + deltaCol >= n ||
                           matrix[row + deltaRow, col + deltaCol] != 0)
                    {
                        Change(ref deltaRow, ref deltaCol);
                    }

                    row += deltaRow;
                    col += deltaCol;
                    currentNumber++;
                }
            }

            return matrix;
        }

        private static void Change(ref int dRow, ref int dCow)
        {
            int[] directionRow = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionCow = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int cd = 0;

            for (int count = 0; count < 8; count++)
            {
                if (directionRow[count] == dRow && directionCow[count] == dCow)
                {
                    cd = count;
                    break;
                }
            }

            if (cd == 7)
            {
                dRow = directionRow[0];
                dCow = directionCow[0];
            }
            else
            {
                dRow = directionRow[cd + 1];
                dCow = directionCow[cd + 1];
            }
        }

        private static bool Check(int[,] arr, int x, int y)
        {
            int directionsCount = 8;

            int[] directionRow = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionCow = { 1, 0, -1, -1, -1, 0, 1, 1 };
            for (int i = 0; i < directionsCount; i++)
            {
                if (x + directionRow[i] >= arr.GetLength(0) || x + directionRow[i] < 0)
                {
                    directionRow[i] = 0;
                }

                if (y + directionCow[i] >= arr.GetLength(0) || y + directionCow[i] < 0)
                {
                    directionCow[i] = 0;
                }
            }

            for (int i = 0; i < directionsCount; i++)
            {
                if (arr[x + directionRow[i], y + directionCow[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private static void FindFirstFreeCell(int[,] arr, out int row, out int col)
        {
            row = -1;
            col = -1;
            for (int currRow = 0; currRow < arr.GetLength(0); currRow++)
            {
                for (int currCol = 0; currCol < arr.GetLength(1); currCol++)
                {
                    if (arr[currRow, currCol] == 0)
                    {
                        row = currRow;
                        col = currCol;
                        return;
                    }
                }
            }
        }
    }
}
