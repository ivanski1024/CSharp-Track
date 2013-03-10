using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDigitInEnglish
{
    class LastDigitInEnglish
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(LastDigit(n));
        }
        static string LastDigit(int a) 
        {
            int i = a % 10;
            string digit;
            switch (i)
            { 
                case 0:
                    digit =  "zero";
                    break;
                case 1:
                    digit =  "one";
                    break;
                case 2:
                    digit =  "two";
                    break;
                case 3:
                    digit =  "three";
                    break;
                case 4:
                    digit =  "four";
                    break;
                case 5:
                    digit =  "five";
                    break;
                case 6:
                    digit =  "six";
                    break;
                case 7:
                    digit =  "seven";
                    break;
                case 8:
                    digit =  "eight";
                    break;
                case 9:
                    digit =  "nine";
                    break;
                default:
                    digit = "";
                    break;
            }
            return digit;
        }
    }
}
