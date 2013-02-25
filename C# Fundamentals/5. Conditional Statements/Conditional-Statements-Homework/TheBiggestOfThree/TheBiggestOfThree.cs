using System;
class TheBiggestOfThree
{
    static void Main()
    {
        int a, b, c, max;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        if (a > b)
        {
            if (a > c) max = a;
            else max = c;
        }
        else
        {
            if (b > c) max = b;
            else max = c;
        }
        Console.WriteLine("The biggest number is {0}", max);
    }
}