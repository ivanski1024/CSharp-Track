using System;
class Program
{
    static void Main()
    {
        string cName, cAddress, cFaxNumber, cSite, mFirstName, mLastName;
        int cNumber, mAge, mNumber;
        Console.WriteLine("Company Information:");
        Console.Write("Company Name: ");
        cName = Console.ReadLine();
        Console.Write("Company Address: ");
        cAddress = Console.ReadLine();
        Console.Write("Company Phone Number: ");
        cNumber = Convert.ToInt32( Console.ReadLine());
        Console.Write("Company Fax: ");
        cFaxNumber = Console.ReadLine();
        Console.Write("Company Website: ");
        cSite = Console.ReadLine();
        Console.Write("Manager First Name: ");
        mFirstName = Console.ReadLine();
        Console.Write("Manager Last Name: ");
        mLastName = Console.ReadLine();
        Console.Write("Manager Phone Number: ");
        mNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Manager Age: ");
        mAge = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(
            "This is {0} it's located at {1}.\n" +
            "It's phone number is: {2:+359 ### ### ###}\n" +
            "The company's fax number is {3}\n"+
            "The company's Website is {4:http://}\n"+
            "The company's manager is {5} {6}\n"+
            "He/She is {8} years old and he/she's phone number is {7:+359 ### ### ###}\n",
            cName, cAddress, cNumber, cFaxNumber, cSite, mFirstName, mLastName, mNumber, mAge);
    }
}
