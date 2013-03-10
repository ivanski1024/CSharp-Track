using System;
class SwitchIfTheFirstIsBigger
{
    static void Main()
    {
        int first=int.Parse(Console.ReadLine()), second=int.Parse(Console.ReadLine());
        if (first > second)
        {
            first += second;
            second = first - second;
            first -= second;
        }
        Console.WriteLine("The new first number is {0} and the new second one is {1}", first, second);
    }
}


