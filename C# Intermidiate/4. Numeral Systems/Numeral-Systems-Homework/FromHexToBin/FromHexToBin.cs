using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromHexToBin
{
    class FromHexToBin
    {
        static void Main()
        {

            StringBuilder bin = new StringBuilder();
            bool valid = false, first = true; ;
            do
            {
                try
                {
                    Console.Write("Enter a number in it's hexademical representation: ");
                    string hex = Console.ReadLine();
                    for (int i = hex.Length - 1; i >= 0; i--)
                    {
                        switch (hex[i])
                        {
                            case '0': bin.Insert(0, "0000"); break;
                            case '1': bin.Insert(0, "0001"); break;
                            case '2': bin.Insert(0, "0010"); break;
                            case '3': bin.Insert(0, "0011"); break;
                            case '4': bin.Insert(0, "0100"); break;
                            case '5': bin.Insert(0, "0101"); break;
                            case '6': bin.Insert(0, "0110"); break;
                            case '7': bin.Insert(0, "0111"); break;
                            case '8': bin.Insert(0, "1000"); break;
                            case '9': bin.Insert(0, "1001"); break;
                            case 'A': bin.Insert(0, "1010"); break;
                            case 'a': bin.Insert(0, "1010"); break;
                            case 'B': bin.Insert(0, "1011"); break;
                            case 'b': bin.Insert(0, "1011"); break;
                            case 'C': bin.Insert(0, "1100"); break;
                            case 'c': bin.Insert(0, "1100"); break;
                            case 'D': bin.Insert(0, "1101"); break;
                            case 'd': bin.Insert(0, "1101"); break;
                            case 'E': bin.Insert(0, "1110"); break;
                            case 'e': bin.Insert(0, "1110"); break;
                            case 'F': bin.Insert(0, "1111"); break;
                            case 'f': bin.Insert(0, "1111"); break;
                            default:
                                throw new FormatException();
                                break;

                        }
                    }
                    valid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Your input isn't a hexadecimal number! ( hex numbers consist of 0-9 and a-f or A-F) Try again:");
                }
            }
            while (!valid);
            while (bin[0] == '0')
            {
                bin.Remove(0, 1);
            }
            
            Console.WriteLine("The number you entered in binary representation is: {0}", bin);
        }
    }
}
