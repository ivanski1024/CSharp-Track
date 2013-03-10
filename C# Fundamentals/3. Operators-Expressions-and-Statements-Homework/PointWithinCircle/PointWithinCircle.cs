using System;
class PointWithinCircle
{
    static void Main()
    {
        Console.Write("X = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Y = ");
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine( (x*x+y*y)<=25 );
    }
}
