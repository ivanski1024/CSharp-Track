using System;
class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine(  ((a % 7 == 0) && ( a % 5 == 0 ))  );
    }
}