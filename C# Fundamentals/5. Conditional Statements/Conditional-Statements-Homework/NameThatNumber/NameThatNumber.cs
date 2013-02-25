using System;
using System.Text;
class NameThatNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a number (between 0 and 999): ");
        int number=int.Parse(Console.ReadLine());
        int hundreds=number/100,
            tens=(number/10)%10,
            ones=number%10;
        bool isTeen=false, isWithTwoDigits=false;
        StringBuilder name = new StringBuilder("");
        switch (hundreds)
        { 
            case 0:
                isWithTwoDigits = true;
                break;
            case 1:
                name.Append("one hundred ");
                break;
            case 2:
                name.Append("two hundred ");
                break;
            case 3:
                name.Append("three hundred ");
                break;
            case 4:
                name.Append("four hundred ");
                break;
            case 5:
                name.Append("five hundred ");
                break;
            case 6:
                name.Append("six hundred ");
                break;
            case 7:
                name.Append("seven hundred ");
                break;
            case 8:
                name.Append("eight hundred ");
                break;
            case 9:
                name.Append("nine hundred ");
                break;
        }
        switch (tens)
        {
            case 1:
                isTeen=true;
                if(!isWithTwoDigits)
                    name.Append("and ");
                switch (ones)
                {
                    case 0:
                        name.Append("ten");
                        break;
                    case 1: 
                        name.Append("eleven");
                        break;
                    case 2:
                        name.Append("twelve");
                        break;
                    case 3:
                        name.Append("thirteen");
                        break;
                    case 4:
                        name.Append("fourteen");
                        break;
                    case 5:
                        name.Append("fifteen");
                        break;
                    case 6:
                        name.Append("sixteen");
                        break;
                    case 7:
                        name.Append("seventeen");
                        break;
                    case 8:
                        name.Append("eighteen");
                        break;
                    case 9:
                        name.Append("nineteen");
                        break;
                }
                break;
                
            case 2:
                name.Append("twenty ");
                break;
            case 3:
                name.Append("thirty ");
                break;
            case 4:
                name.Append("fourty ");
                break;
            case 5:
                name.Append("fifty ");
                break;
            case 6:
                name.Append("sixty ");
                break;
            case 7:
                name.Append("seventy ");
                break;
            case 8:
                name.Append("eighty ");
                break;
            case 9:
                name.Append("ninety ");
                break;
        }
        if (!isTeen)
        {
            switch (ones)
            {
                case 0:
                    if (hundreds == 0 && tens == 0)
                    {
                        name.Append("zero");
                    }
                    break;
                case 1:
                    name.Append("one");
                    break;
                case 2:
                    name.Append("two");
                    break;
                case 3:
                    name.Append("three");
                    break;
                case 4:
                    name.Append("four");
                    break;
                case 5:
                    name.Append("five");
                    break;
                case 6:
                    name.Append("six");
                    break;
                case 7:
                    name.Append("seven");
                    break;
                case 8:
                    name.Append("eight");
                    break;
                case 9:
                    name.Append("nine");
                    break;
            }
        }

        //Changing the first letter to upper case
        name[0] = (char)((int)name[0] - 32);
        Console.WriteLine(name);
    }
}