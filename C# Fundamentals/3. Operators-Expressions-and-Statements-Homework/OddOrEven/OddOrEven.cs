using System;
class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        if ((int)a % 2 == 0) Console.WriteLine("The number is even.");
        else Console.WriteLine("The numbur is odd.");
    }
}
