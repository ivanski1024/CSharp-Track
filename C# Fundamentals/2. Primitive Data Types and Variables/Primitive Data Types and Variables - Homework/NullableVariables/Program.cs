using System;
class Program
{
    static void Main()
    {
        int? IntegerNumber=null;
        double? DoubleNumber = 5;
        Console.WriteLine("The integer number is:{0} \nThe Floating Point number is:{1}",
        IntegerNumber, DoubleNumber);
        IntegerNumber += 5;
        DoubleNumber += null;
        Console.WriteLine("the integer number is:{0} \nthe floating point number is:{1}",
        IntegerNumber, DoubleNumber);
    }
}
