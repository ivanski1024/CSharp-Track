using System;
class CircleAndRectangle
{
    static void Main()
    {
        double x, y;
        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        bool withinCircle, withinRectangle;
        withinCircle = ((x-1)*(x-1)+(y-1)*(y-1) <= 3);
        withinRectangle = (x>=1)&&(x<=7)&&(y>=-3)&&(y<=-1);
        Console.WriteLine( (withinCircle)&&(!withinRectangle) );
    }
} 