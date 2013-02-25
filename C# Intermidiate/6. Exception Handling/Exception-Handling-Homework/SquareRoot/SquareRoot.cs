using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    throw new ArithmeticException();
                }
                Console.WriteLine(Math.Sqrt(n));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}