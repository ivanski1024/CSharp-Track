using System;
class PrintDateAndTime
{
    static void Main()
    {
        DateTime time = DateTime.Now;
        string format = "MM/dd/yyyy HH:mm";
        Console.WriteLine(time.ToString(format));
    }
}