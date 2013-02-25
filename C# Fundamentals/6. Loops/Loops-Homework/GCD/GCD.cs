using System;
class GCD
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int temp;
        while (y != 0)
        {
            temp = x;
            x = y;
            y = temp % y;
        }
        Console.WriteLine(x);
    }
}
