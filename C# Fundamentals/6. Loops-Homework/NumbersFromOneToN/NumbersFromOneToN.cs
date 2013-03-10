using System;
class NumbersFromOneToN
{
    static void Main()
    {
        Console.WriteLine("Enter N");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", i);
        }
    }
}
