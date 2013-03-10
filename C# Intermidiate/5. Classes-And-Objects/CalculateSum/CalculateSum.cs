using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSum
{
    class CalculateSum
    {
        static void Main()
        {
            Console.WriteLine(GetInputAndCalculateSum());
        }

        static int GetInputAndCalculateSum()
        {
            string line = Console.ReadLine();
            string[] numbers = line.Split(' ');
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += int.Parse(numbers[i]);
            }
            return sum;
        }
    }
}
