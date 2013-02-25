using System;
class TheIBitFromBIs
{
    static void Main()
    {
        Console.Write("i=");
        int i = int.Parse(Console.ReadLine());
        Console.Write("b=");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine((i & (1 << b)) >> b);
    }
}
