using System;
using System.Numerics;
class FibonacciNumbers
{
    static void Main()
    {
        BigInteger  one=0, two=1, boof;
        for (int i=1; i <= 100; i+=2)
        {
            Console.WriteLine("{0, 50}", one);
            Console.WriteLine("{0, 50}", two);
            boof = one + two;
            two+=boof;
            one = boof;
        }
    }
}