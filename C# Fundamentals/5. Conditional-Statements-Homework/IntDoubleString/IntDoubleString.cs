using System;
class IntDoubleString
{
    static void Main()
    {
        string input=Console.ReadLine();
        byte type;
        double myDouble;
        int myInt;
        string myString;
        if (double.TryParse(input, out myDouble)) type = 1;
        else if (int.TryParse(input, out myInt)) type = 2;
        else type = 3;
        switch (type)
        {
            case 1:
                myDouble = double.Parse(input) + 1;
                Console.WriteLine(myDouble);
                break;
            case 2:
                myInt = int.Parse(input) + 1;
                Console.WriteLine(myInt);
                break;
            case 3:
                myString = (input + "*");
                Console.WriteLine(myString);
                break;
        }
    }
}
