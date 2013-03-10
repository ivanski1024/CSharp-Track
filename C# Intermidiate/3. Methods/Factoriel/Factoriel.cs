using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factoriel
{
    class Factoriel
    {

        static void Main()
        {

            ArrayList number = new ArrayList();
            number.Add(1);
            PrintNUmber(number);
            FactorielFunc(number);
        }

        private static void FactorielFunc(ArrayList number)
        {
            for (int i = 2; i <= 100; i++)
            {
                MultiplyNumber(ref number, i);
                PrintNUmber(number);
            }
        }

        private static void MultiplyNumber(ref ArrayList number, int p)
        {
            int length = number.Count, next=0;
            for (int i = 0; i < length; i++)
            {
                next = (int)number[i] * p + next;
                number[i] = next % 10;
                next /= 10;
            }
            while (next > 0)
            {
                number.Add(next % 10);
                next /= 10;
            }
        }

        private static void PrintNUmber(ArrayList number)
        {
            for (int i = number.Count-1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }
            Console.WriteLine();
        }
    }
}
