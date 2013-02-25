using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromBinToDec
{
    class FromBinToDec
    {
        static void Main()
        {
            int n = 0;
            bool valid = false;
            do
            {
                try
                {
                    n = ConvertToDecimal();
                    valid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The input isn't a number! Enter again!");
                }
                catch (OperationCanceledException)
                {
                    Console.WriteLine("The number you entered isn't binary! Enter again!");
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("You haven't entered anything. Do you want to exit? (Y or N)");
                    while (true)
                    {

                        if (Console.KeyAvailable)
                        {
                            ConsoleKeyInfo input = Console.ReadKey();
                            if (input.Key == ConsoleKey.Y)
                            {
                                return;
                            }
                            else if (input.Key == ConsoleKey.N)
                            {
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("You haven't entered anything. Do you want to exit? (Y or N)");
                            }
                        }
                    }
                }
            }
            while (!valid);
            Console.WriteLine("The decimal representation of your number is: {0}", n);

        }

        static int ConvertToDecimal()
        {
            Console.WriteLine("Enter a number in it's binary representation: ");
            string line = Console.ReadLine();
            int n = 0, k = 0, pow = 1;
            for (int i = line.Length - 1; i >= 0; i--)
            {

                if (int.TryParse(line[i].ToString(), out k))
                {
                    //aConsole.WriteLine(k);
                    if (k == 0 || k == 1)
                    {
                        n += pow * k;
                        pow *= 2;
                    }
                    else
                    {
                        throw new OperationCanceledException();
                    }
                }
                else
                {
                    throw new FormatException();
                }

            }
            return n;
        }
    }
}
