using System;
class ChangingThePBit
{
    static void Main()
    {
        int n, v, p;
        Console.Write("n=");
        n = int.Parse(Console.ReadLine());
        Console.Write("v=");
        v = int.Parse(Console.ReadLine());
        Console.Write("p=");
        p = int.Parse(Console.ReadLine());
        if (v == 1)
        {
            n |= (1 << p);
        }
        else if ( v == 0 )
        {
            n &= ~(1<<p);
        }
        Console.WriteLine(n);
    }
}