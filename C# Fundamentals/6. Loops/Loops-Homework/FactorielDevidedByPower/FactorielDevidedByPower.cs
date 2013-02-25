using System;
using System.Numerics;
class FactorielDevidedByPower
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("X = ");
        int x = int.Parse(Console.ReadLine());
        double sum = 1, fac = 1, pow = 1;
        for (int i = 1; i < n; i++)
        {
            fac *= i;
            pow *= x;
            sum += (fac / pow);
        }
        Console.WriteLine(sum);
    }
}
