using System;
class QuadricEquation
{
    static void Main()
    {
        double a, b, c;
        Console.Write("a="); a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b="); b = Convert.ToDouble(Console.ReadLine());
        Console.Write("c="); c = Convert.ToDouble(Console.ReadLine());

        double D = b * b - 4 * a * c;
        if (a == 0)
        {
            Console.WriteLine("X={0}", (-c / b));
        }
        else
        {
            if (D < 0)
                Console.WriteLine("There aren't real roots of the equation {0}x*x+{1}x+{2}=0", a, b, c);
            else if (D == 0)
                Console.WriteLine("X1=X2={0}", (-b - Math.Sqrt(D) / 2));
            else
                Console.WriteLine("X1 = {0:0.00} X2 = {1:0.00}", (-b - Math.Sqrt(D) / 2), (-b + Math.Sqrt(D) / 2));
        }
    }
}
