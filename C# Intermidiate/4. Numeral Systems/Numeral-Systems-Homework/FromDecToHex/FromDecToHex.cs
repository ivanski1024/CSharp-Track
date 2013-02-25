using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromDecToHex
{
    class FromDecToHex
    {
        static void Main()
        {
            int dec = 0;
            do
            {
                Console.Write("Enter a decimal integer number: ");
                try
                {
                    dec = GetInput();
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input isn't an iteger number! Try again!");
                }
            } 
            while (true);
            StringBuilder hex = DecToHex(dec);
            Console.WriteLine(hex);
        }

        private static int GetInput()
        {
            string number = Console.ReadLine();
            int n = 0;
            if (int.TryParse(number, out n))
            {
                return n;
            }
            else
            {
                throw new FormatException();
            }
        }

        static StringBuilder DecToHex(int dec)
        {
            StringBuilder hex=new StringBuilder();
            int digit;
            while (dec > 0)
            { 
                digit=dec%16;
                if (digit < 10)
                {
                    hex.Insert(0, digit);
                }
                else
                {
                    digit %= 10;
                    hex.Insert(0, (char)('A'+digit));
                }
                dec /= 16;
            }
            return hex;
        }
    }
}
