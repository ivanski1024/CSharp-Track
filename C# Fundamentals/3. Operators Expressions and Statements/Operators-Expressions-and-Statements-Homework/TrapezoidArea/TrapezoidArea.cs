using System;
class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine()),
               b = double.Parse(Console.ReadLine()),
               h = double.Parse(Console.ReadLine());
        Console.WriteLine(((a+b)*h)/2);
    }
}