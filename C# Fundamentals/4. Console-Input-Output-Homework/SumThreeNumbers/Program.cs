using System;
    class SumThreeNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter 3 numbers.");
            int a = int.Parse(Console.ReadLine()),
                b = int.Parse(Console.ReadLine()),
                c = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of the numbers is: {0}", a+b+c);
        }
    }
