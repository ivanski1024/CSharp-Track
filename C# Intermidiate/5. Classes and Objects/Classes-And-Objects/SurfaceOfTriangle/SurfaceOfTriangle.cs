using System;

namespace SurfaceOfTriangle
{
    class SurfaceOfTriangle
    {
        static void Main()
        {
            MakeDecision(GetDecision());
        }

        static void MakeDecision(int decision)
        {
            Console.WriteLine();
            double S = 0, a, b, c, h;
            float alpha;
            switch (decision)
            {
                case 1:
                    Console.WriteLine("Enter a side of the triangle and the altitude to it");
                    Console.Write("a = "); a = double.Parse(Console.ReadLine());
                    Console.Write("h = "); h = double.Parse(Console.ReadLine());
                    S = TriangleSurface(a, h);
                    break;
                case 2:
                    Console.Write("a = "); a = double.Parse(Console.ReadLine());
                    Console.Write("b = "); b = double.Parse(Console.ReadLine());
                    Console.Write("Angle (in degrees) = "); alpha = float.Parse(Console.ReadLine());
                    S = TriangleSurface(a, b, alpha);
                    break;
                case 3:
                    Console.Write("a = "); a = double.Parse(Console.ReadLine());
                    Console.Write("b = "); b = double.Parse(Console.ReadLine());
                    Console.Write("c = "); c = double.Parse(Console.ReadLine());
                    S = TriangleSurface(a, b, c);
                break;
                case 4:
                    return;
            }
            Console.WriteLine("Sabc = {0}", S);
        }

        private static int GetDecision()
        {
            Menu();
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

                    else if (input.Key == ConsoleKey.D4 || (input.Key == ConsoleKey.NumPad4))
                    {
                        return 4;
                    }
                    else
                    {
                        Console.Clear();
                        Menu();
                    }
                }
            }
        }

        static void Menu()
        {
            Console.WriteLine("How do you want to calculate the surface of the triangle?");
            Console.WriteLine("1. A side and the altitude to it.");
            Console.WriteLine("2. Two sides and the angle between them.");
            Console.WriteLine("3. Three sides.");
            Console.WriteLine("4. Exit.");
        }
        static double TriangleSurface(double a, double h)
        {
            return h * a / 2;
        }
        static double TriangleSurface(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
        }
        static double TriangleSurface(double a, double b, float angle)
        {
            return TriangleSurface(a, b, (Math.Sqrt(a * a + b * b + 2 * a * b * Math.Cos(Math.PI*angle/180.0))));
        }
    }
}
