using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstractionAndMultiplicationOfPolynomials
{
    class SubstractionAndMultiplicationOfPolynomials
    {
        static void Main()
        {
            int[] polynom1 = EnterPolynom(), polynom2 = EnterPolynom();
            int action = GetAction();
            switch (action)
            {
                case 1:
                    SumPolynoms(polynom1, polynom2);
                    break;
                case 2:
                    MultiplyPolynoms(polynom1, polynom2);
                    break;
                case 3:
                    DividePolynoms(polynom1, polynom2);
                    break;
            }
        }

        private static void DividePolynoms(int[] polynom1, int[] polynom2)
        {
        }

        private static void MultiplyPolynoms(int[] p1, int[] p2)
        {
            int length = p1.Length + p2.Length;
            int[] multiplyed = new int[length];
            for (int i = 0; i < p1.Length; i++)
            {
                for (int j = 0; j < p2.Length; j++)
                {
                    multiplyed[i + j] += p1[i] * p2[j];
                }
            }
            Console.WriteLine("\n{0}\n * \n{1}\n=\n{2}", PrintThisPolynom(p1), PrintThisPolynom(p2), PrintThisPolynom(multiplyed));
        }

        static void SumPolynoms(int[] p1, int[] p2)
        {
            int[] p3 = p1.Length < p2.Length ? SumPolynomsWithDifferentLength(p1, p2) : SumPolynomsWithDifferentLength(p2, p1);
            Console.WriteLine("\n{0}\n+\n{1}\n=\n{2}", PrintThisPolynom(p1), PrintThisPolynom(p2), PrintThisPolynom(p3));
        }

        static int GetAction()
        {

            Menu();
            int desicion = 0;
            while (true)
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
                    else
                    {
                        Console.Clear();
                        Menu();
                    }
                }

            }
            return desicion;
        }

        private static void Menu()
        {
            Console.WriteLine("What do you want to do with those two polynoms?");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Multiply");
            Console.WriteLine("3. Substract");
        }

        static StringBuilder PrintThisPolynom(int[] p)
        {
            StringBuilder output = new StringBuilder();
            bool first = true;
            for (int i = p.Length - 1; i >= 0; i--)
            {
                if (p[i] != 0)
                {
                    if (!first)
                    {
                        output.Append("+ ");
                    }
                    output.Append(p[i]);
                    if (i == 1)
                    {
                        output.Append("x ");
                    }
                    else if (i > 1)
                    {
                        output.Append("x^");
                        output.Append(i);
                        output.Append(" ");

                    }
                    first = false;
                }
            }
            return output;
        }

        static int[] SumPolynomsWithDifferentLength(int[] shortP, int[] longP)
        {
            int[] p = new int[longP.Length];
            for (int i = 0; i < shortP.Length; i++)
            {
                p[i] = shortP[i] + longP[i];
            }
            for (int i = shortP.Length; i < longP.Length; i++)
            {
                p[i] = longP[i];
            }
            return p;
        }

        static int[] EnterPolynom()
        {
            int[] polynomQuef;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a polynoms queficients:");
                    string line = Console.ReadLine();
                    string[] quef = line.Split(' ');
                    polynomQuef = new int[quef.Length];
                    for (int i = 0; i < quef.Length; i++)
                    {
                        polynomQuef[i] = int.Parse(quef[i]);
                    }
                    return polynomQuef;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input isn't valid! Try again!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("A queficent you entered is too big or too small! Try again!");
                }
            }
        }
    }
}
