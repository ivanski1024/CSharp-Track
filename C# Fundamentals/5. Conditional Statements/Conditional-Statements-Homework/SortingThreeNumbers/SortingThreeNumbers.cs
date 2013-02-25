using System;
class SortingThreeNumbers
{
    static void switchTwoNumbers(ref double first, ref double second)
    {
        double boof;
        boof=first;
        first=second;
        second=boof;
    }
    static void Main()
    {
        double a, b, c;
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());
        if (a < b)
        {
            if (a < c)
            {
                if (b > c)
                {
                    switchTwoNumbers(ref b, ref c);
                    switchTwoNumbers(ref a, ref c);
                }
                else
                {
                    switchTwoNumbers(ref a, ref c);
                }
            }
            else if (a > c)
            {
                switchTwoNumbers(ref a, ref b);
            }

        }
        else
        {
            if (c > b)
            {
                switchTwoNumbers(ref b, ref c);
                if (b > a)
                { 
                    switchTwoNumbers(ref a, ref b);
                }
            }
        }
        Console.WriteLine("The sorted numbers are {0} {1} {2}", a, b, c);
    }
}
