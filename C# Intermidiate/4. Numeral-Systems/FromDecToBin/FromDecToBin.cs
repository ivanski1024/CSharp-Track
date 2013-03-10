using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromDecToBin
{
    class FromDecToBin
    {
        static void Main()
        {
            bool valid = false;
            int n = 0;
            List<byte> bits = new List<byte>();
            do
            {
                try
                {
                    Console.Write("Enter a decimal representation of a number: ");
                    n = int.Parse(Console.ReadLine());
                    valid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input isn't a number! Try again!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number is too big or too small! Try again!");
                }
            }
            while (!valid);
            while (n > 0)
            {
                bits.Add((byte)(n % 2));
                n /= 2;
            }
            for (int i = bits.Count - 1; i >= 0; i--)
            {
                Console.Write(bits[i]);
            }
            Console.WriteLine();
        }
    }
}
