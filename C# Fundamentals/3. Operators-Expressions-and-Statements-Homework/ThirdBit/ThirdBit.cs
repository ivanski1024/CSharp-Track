using System;
class ThirdBit
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int p = 2;
        int mask = 1 << p;
        mask = a & mask;
        mask = mask >> p;
        Console.WriteLine(mask);
    }
}
