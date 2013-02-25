using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OddNumber2
{
    class OddNumber2
    {
        static bool[] numbers = new bool[214748364];
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            long currNumber;
            for (int i = 0; i < n; i++)
            {
                currNumber = long.Parse(Console.ReadLine());
                if (numbers[currNumber] == false) { numbers[currNumber] = true; }
                else { numbers[currNumber] = false; }
            }
            for (long i = 0; i < numbers.Length; i++)
            {
                if (numbers[i])
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
