using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromBinToHex
{
    class FromBinToHex
    {
        static void Main()
        {
            StringBuilder hex = new StringBuilder();
            bool valid = false;
            do
            {
                Console.WriteLine("Enter a number in it's binary representation: ");
                string bin = Console.ReadLine();
                char[] group = new char[4];
                try
                {
                    if (bin.Length % 4 != 0)
                    {
                        string zeros = new string('0', 4 - bin.Length % 4);
                        bin = zeros + bin;
                    }
                    for (int i = bin.Length - 1; i >= 0; i -= 4)
                    {
                        for (int j = i; j > i - 4; j--)
                        {
                            if (bin[j] == '0' || bin[j] == '1')
                            {
                                group[3-(i - j) ] = bin[j];
                            }
                            else
                            {
                                throw new FormatException();
                            }
                        }
                        string group2 = new string(group);
                        switch (group2)
                        {
                            case "0000": hex.Insert(0, 0); break;
                            case "0001": hex.Insert(0, 1); break;
                            case "0010": hex.Insert(0, 2); break;
                            case "0011": hex.Insert(0, 3); break;
                            case "0100": hex.Insert(0, 4); break;
                            case "0101": hex.Insert(0, 5); break;
                            case "0110": hex.Insert(0, 6); break;
                            case "0111": hex.Insert(0, 7); break;
                            case "1000": hex.Insert(0, 8); break;
                            case "1001": hex.Insert(0, 9); break;
                            case "1010": hex.Insert(0, "A"); break;
                            case "1011": hex.Insert(0, "B"); break;
                            case "1100": hex.Insert(0, "C"); break;
                            case "1101": hex.Insert(0, "D"); break;
                            case "1110": hex.Insert(0, "E"); break;
                            case "1111": hex.Insert(0, "F"); break;
                            default: throw new FormatException();
                        }
                    }

                    valid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The number you entered isn't in binary representation! (binary numbers contain only 0 and 1. Try again:");
                }
            }
            while (!valid);
            Console.WriteLine("The hexadecimal representation of your number is: {0}", hex);
        }
    }
}
