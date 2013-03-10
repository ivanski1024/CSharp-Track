using System;
class Factorial
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K:");
        int k = int.Parse(Console.ReadLine());
        int fac = 1;
        for (int i = k + 1; i <= n; i++)
        {
            fac *= i;
        }
        Console.WriteLine("{0}!/{1}!={2}", n, k, fac);

    }
}
