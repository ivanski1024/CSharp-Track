using System;
class PBitIs1
{
    static void Main()
    {
        Console.Write("v=");
        int v = int.Parse(Console.ReadLine());
        Console.Write("p=");
        int p = int.Parse(Console.ReadLine());
        int myBit = ((v & (1 << p)) >> p);
        Console.WriteLine(myBit);
    }
}