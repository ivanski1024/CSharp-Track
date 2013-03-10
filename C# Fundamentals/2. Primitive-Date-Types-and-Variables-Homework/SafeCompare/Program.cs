using System;
class Program
{
    static void Main()
    {
        double a, b;
        a = 1.123456;
        b = 1.123457;
        bool compare = ( ( a - b < 0.000001f ) && ( b - a < 0.000001f ) );
        Console.WriteLine(compare);
    }
}
