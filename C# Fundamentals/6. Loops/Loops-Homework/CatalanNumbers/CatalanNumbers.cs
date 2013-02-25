using System;
class CatalanNumbers
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double C = 1;
        for (double i = 2; i <= n + 1; i++)
        {
            C *= (n - 1 + i) / i;
        }
        Console.WriteLine(C);
    }
}
