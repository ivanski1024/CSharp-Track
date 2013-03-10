using System;
using System.Numerics;
class SumOfFibonacci
{
    static void Main()
    {
        BigInteger sum = 1;
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        int first=0, second=1;
        for (int i = 2; i <= n; i++)
        {
            sum += first + second;
            second += first;
            first = second - first;
        }
        Console.WriteLine(sum);
    }
}
