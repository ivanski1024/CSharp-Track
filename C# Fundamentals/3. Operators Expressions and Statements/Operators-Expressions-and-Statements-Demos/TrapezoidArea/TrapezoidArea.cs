using System;
class TrapezoidArea
{
    static void Main()
    {
        double a, b, h;
        Console.Write("a=");
        a = double.Parse(Console.ReadLine());
        Console.Write("b=");
        b = double.Parse(Console.ReadLine());
        Console.Write("h=");
        h = double.Parse(Console.ReadLine());
        Console.Write( ((a+b)*h)/2 );
    }
}