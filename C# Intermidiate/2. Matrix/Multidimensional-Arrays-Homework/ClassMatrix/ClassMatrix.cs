using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMatrix
{
    class ClassMatrix
    {
        class Matrix
        {
            public int Rows, Cols;
            public int[,] matrix;
            public Matrix(int rows, int cols)
            {
                this.Rows = rows;
                this.Cols = cols;
                this.matrix = new int[this.Rows, this.Cols];
            }
            public Matrix(int[,] a)
            {
                this.matrix = a;
                this.Rows = matrix.GetLength(0);
                this.Cols = matrix.GetLength(1);
            }
            public int this[int x, int y]
            {
                get
                {
                    return matrix[x, y];
                }
                set
                {
                    matrix[x, y] = value;
                }
            }
            static public Matrix operator +(Matrix a, Matrix b)
            {
                if (a.Rows == b.Rows && a.Cols == b.Cols)
                {
                    Matrix sum = new Matrix(a.Rows, a.Cols);
                    for (int i = 0; i < a.Rows; i++)
                    {
                        for (int j = 0; j < a.Cols; j++)
                        {
                            sum[i, j] = a[i, j] + b[i, j];
                        }
                    }
                    return sum;
                }
                else
                {
                    throw new ArrayTypeMismatchException("The matrices should be with the same sizes!");
                }
            }
            static public Matrix operator -(Matrix a, Matrix b)
            {

                if (a.Rows == b.Rows && a.Cols == b.Cols)
                {
                    Matrix subtracted = new Matrix(a.Rows, a.Cols);
                    for (int i = 0; i < a.Rows; i++)
                    {
                        for (int j = 0; j < a.Cols; j++)
                        {
                            subtracted[i, j] = a[i, j] - b[i, j];
                        }
                    }
                    return subtracted;
                }
                else
                {
                    throw new ArrayTypeMismatchException("The matrices should be with the same sizes!");
                }
            }
            static public Matrix operator *(Matrix a, Matrix b)
            {
                if (a.Cols == b.Rows)
                {
                    Matrix product = new Matrix(a.Rows, a.Cols);
                    for (int i = 0; i < a.Rows; i++)
                    {
                        for (int j = 0; j < a.Cols; j++)
                        {
                            product[i, j] = 0;
                            for (int k = 0; k < a.Cols; k++)
                            {
                                product[i, j] += a[i, k] * b[k, j];
                            }
                        }
                    }
                    return product;
                }
                else
                {
                    throw new ArrayTypeMismatchException("The first matrix rows count should be the same as the second matrix cols count!");
                }
            }
            public static Matrix GetMatrix()
            {
                Matrix matrix;
                do
                {
                    try
                    {
                        Console.Write("Rows = ");
                        int r = int.Parse(Console.ReadLine());
                        Console.Write("Cols = ");
                        int c = int.Parse(Console.ReadLine());
                        matrix = new Matrix(r, c);
                        do
                        {
                            Console.WriteLine("Enter matrix with sizes {0}x{1} and integer elements.", r, c);
                            try
                            {
                                for (int i = 0; i < r; i++)
                                {

                                    string line = Console.ReadLine();
                                    string[] el = line.Split(' ');
                                    for (int j = 0; j < c; j++)
                                    {
                                        matrix[i, j] = int.Parse(el[j]);
                                    }

                                }
                                return matrix;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Matrix elements should be decimal values! Try again!");
                            }
                        }
                        while (true);

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("The count of rows and cols should be integers! Try again");
                    }
                }
                while (true);
            }
            static public void PrintMatrix(Matrix a)
            {
                for (int i = 0; i < a.Rows; i++)
                {
                    for (int j = 0; j < a.Cols; j++)
                    {
                        Console.Write("{0} ", a[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Main()
        {
            HomeScreen();
            Action(GetDecision());
        }
        static void Action(int decision)
        {
            Console.WriteLine();
            Matrix A;
            Matrix B;
            switch (decision)
            {
                case 1:
                    A = Matrix.GetMatrix();
                    B = Matrix.GetMatrix();
                    Console.WriteLine("A + B = ");
                    Matrix.PrintMatrix(A + B);
                    break;
                case 2:
                    A = Matrix.GetMatrix();
                    B = Matrix.GetMatrix();
                    Console.WriteLine("A - B = ");
                    Matrix.PrintMatrix(A - B);
                    break;
                case 3:
                    A = Matrix.GetMatrix();
                    B = Matrix.GetMatrix();
                    Console.WriteLine("A * B = ");
                    Matrix.PrintMatrix(A * B);
                    break;
                case 4:
                    return;
            }
        }
        static int GetDecision()
        {

            do
            {
                try
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo input = Console.ReadKey();
                        if (input.Key == ConsoleKey.D1 || (input.Key == ConsoleKey.NumPad1))
                        {
                            return 1;
                        }
                        else if (input.Key == ConsoleKey.D2 || (input.Key == ConsoleKey.NumPad2))
                        {
                            return 2;
                        }

                        else if (input.Key == ConsoleKey.D3 || (input.Key == ConsoleKey.NumPad3))
                        {
                            return 3;
                        }

                        else if (input.Key == ConsoleKey.D4 || (input.Key == ConsoleKey.NumPad4))
                        {
                            return 4;
                        }
                        else
                        {
                            Console.Clear();
                            HomeScreen();
                        }
                    }
                }
                catch
                { }
            }
            while (true);
            return 0;
        }
        private static void HomeScreen()
        {
            string[] menu = 
            {
                "What do you want to do? (1, 2 or 3)",
                "1. Add matrices",
                "2. Substract matrices",
                "3. Multiply matrices",
                "4. Exit"
            };
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine(menu[i]);
            }
        }
    }
}
