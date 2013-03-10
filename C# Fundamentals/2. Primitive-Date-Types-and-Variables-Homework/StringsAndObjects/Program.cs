using System;
class Program
{
    static void Main()
    {
        string firstString = "Hello", secondString = "World", thirdString;
        object myObject = (firstString + " " + secondString);
        thirdString = myObject.ToString();
        Console.WriteLine(thirdString);
    }
}