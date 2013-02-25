using System;
using System.Text;
class FirstDemo
{
    static void Main()
    {

        Console.OutputEncoding = Encoding.Unicode;
        decimal a = 3.141576m;
        Console.WriteLine("{0:C}", a);
    }
}