using System;
class Factoriel2
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K:");
        int k = int.Parse(Console.ReadLine());
        int fac = 1;
        for (int i=1; i <= n; i++)
        {
            fac *= i*i;
        }
        Console.WriteLine("{0}!*{1}!/{2}!={3}", n, k, k-n, fac);
    }
}
