using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddBigNumbers
{
    class AddBigNumbers
    {
        static void Main()
        {
            byte?[] a = GetNumber();
            byte?[] b = GetNumber();
            byte?[] sum = SumNumbers(a, b);
            PrintThisNumberI(sum);
        }
        static void PrintThisNumberI(byte?[] a)   // Prints a number
        {
            StringBuilder number = new StringBuilder();
            for (int i = a.Length - 1; i >= 0; i--)
            {
                number.Append(a[i]);
            }
            Console.WriteLine(number);
        }

        static byte?[] SumNumbers(byte?[] a, byte?[] b)  // Sums up two numbers that are kept in array
        {                                                // in which every cell represents K in K*(10^i) where i is the index of the cell.
            int l, s;
            bool longer = false;
            byte rest = 0;
            if (a.Length > b.Length)
            {
                l = a.Length;
                s = b.Length;
                longer = true;
            }
            else 
            {
                s = a.Length;
                l = b.Length;
            }
            byte?[] sum = new byte?[l + 1];
            Adding(a, b, s, ref sum, ref rest);
            if (longer)
            {
                Adding(ref a, sum, s, rest);
            }
            else
            {
                Adding(ref b, sum, s, rest);
            }
            return sum;
        }

        static void Adding(ref byte?[] a, byte?[] sum, int pos, byte rest) //Adds up a number with the rest from the last adding and keep it in sum
        {
                for (int i = pos; i < a.Length; i++)
                {
                    sum[i] = (byte?)((a[i] + rest) % 10);
                    rest = (byte)((a[i] + rest) / 10);
                }
                if (rest == 1)
                {
                    sum[a.Length] = 1;
                }
        }
        static void Adding(byte?[] a, byte?[] b, int length, ref byte?[] sum, ref byte rest) // Adds up two numbers only to the length of the short one
                                                                                             // Keeps the "rest" of the adding  7+6=13=3+1*10
        {
            for (int i = 0; i < length; i++)
            {
                sum[i] = (byte?)((a[i] + b[i] + rest) % 10);
                rest = (byte)((a[i] + b[i] + rest) / 10);
            }
        }
        private static byte?[] GetNumber()  // Reads a long number from the Console and as a result returns an array of byte? with the number
                                            // The last digit ( for 10^0 ) is in number[0]
        {
            string line = Console.ReadLine();
            int l = line.Length;
            byte?[] number = new byte?[l];
            for (int i = l-1; i >= 0; i--)
            {
                number[i] = (byte)(line[l-i-1] - '0');
            }
            return number;
        }
    }
}
