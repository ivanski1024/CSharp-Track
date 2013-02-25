using System;
class CircleRadius
{
    static void Main()
    {
        double r;
        const double pi=3.14;
        Console.WriteLine("Enter the radius");
        r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("The perimeter of the circle is {0} and the area is {1}.", (2*pi*r), (pi*r*r));
    }
}
