using System;
class GreaterNumber
{
    static void Main()
    {
        int first, second;
        first = Convert.ToInt32(Console.ReadLine());
        second = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The greater number is: {0}",(Math.Abs(first-second)+first+second)/2);
    }
}
