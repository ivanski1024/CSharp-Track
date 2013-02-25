using System;
class Program
{

    static void Main()
    {
        int? IntegerNumber=null;
        double? DoubleNumber=null;
        Console.WriteLine("The integer number is:{0} \nThe Floating Point number is:",
        IntegerNumber, DoubleNumber);
        IntegerNumber+= '\0';
        DoubleNumber += 5;
        Console.WriteLine("The integer number is:{0} \nThe Floating Point number is:",
        IntegerNumber, DoubleNumber);
    }
}
