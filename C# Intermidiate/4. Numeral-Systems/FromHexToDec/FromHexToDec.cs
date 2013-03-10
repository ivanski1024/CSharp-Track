using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromHexToDec
{
    class FromHexToDec
    {
        static void Main()
        {
            string hex;
            do
            {
                Console.WriteLine("Enter a number in it's hexademical representation!");
                try
                {
                    hex = GetInput();
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The number entered isn't hexademical!\n(Hexademical numbers are with digits (0-9) and letters (A-F). Try again!");
                }
            }
            while (true);
            Console.WriteLine(HexToDec(hex));
        }
        static int HexToDec(string hex)
        {
            int dec = 0, pow = 1, k = 0;
            for (int i = hex.Length-1; i >=0; i--)
            {
                if (hex[i] >= '0' && hex[i] <= '9')
                {
                    k = hex[i] - '0';
                }
                else if(hex[i] >= 'A' && hex[i] <= 'F')
                {
                    k = 10 + hex[i] - 'A';
                }
                else if (hex[i] >= 'a' && hex[i] <= 'f')
                {
                    k = 10 + hex[i] - 'a';
                }
                dec += pow * k;
                pow *= 16;
            }
            return dec;
        }
        static string GetInput()
        {
            string hex = Console.ReadLine();
            for (int i = 0; i < hex.Length; i++)
            {
                if (!((hex[i] >= '0' && hex[i] <= '9') || (hex[i] >= 'A' && hex[i] <= 'F') || (hex[i] >= 'a' && hex[i] <= 'f')))
                {
                    throw new FormatException();
                }
            }
            return hex;
        }
    }
}
