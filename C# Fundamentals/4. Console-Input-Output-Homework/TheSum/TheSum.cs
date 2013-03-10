using System;
using System.Threading;
class TheSum
{
    static void Main()
    {
        int n = 2;
        decimal sum = 1, LastSum = 0, sign = 1;

        while (n<1000)
        {
            LastSum = sum;
            sum += ( sign / n );
            if (sign == 1) sign = -1;
            else sign = 1;
            n++;
        }
        Console.WriteLine("{0:0.000}",sum);
    }
}
