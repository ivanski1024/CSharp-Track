using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadNumberInRange
{
    class ReadNumberInRange
    {
        static void Main()
        {
            int[] arr = new int[10];
            int begin = 2;
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    try
                    {
                        arr[i] = ReadNumber(begin, 99);
                        begin = arr[i] + 1;
                        if (begin > 99)
                        {
                            Console.WriteLine("Your interval has become with zero length!");
                            return;
                        }
                        break;
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Your last number doesn't belong to the given interval [{0}, {1}] Try again!", begin, 99);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("This isn't a number!");
                    }
                }
                while (true);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
        static int ReadNumber(int start, int end)
        {
            int number = int.Parse(Console.ReadLine());
            if (number >= start && number <= end)
            {
                return number;
            }
            else
            {
                throw new ArgumentOutOfRangeException("The number is outside the given interval.");
            }
        }
    }
}
