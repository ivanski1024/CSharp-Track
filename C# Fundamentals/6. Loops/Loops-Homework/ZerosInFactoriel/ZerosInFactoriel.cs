using System;
class ZerosInFactoriel
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int del = 5, zeros=0;
        while (n / del > 0)
        {
            zeros += n / del;
            del *= 5;
        }
        Console.WriteLine(zeros);
    }
}
