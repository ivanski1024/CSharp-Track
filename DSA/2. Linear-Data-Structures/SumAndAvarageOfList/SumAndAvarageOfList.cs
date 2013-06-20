using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAndAvarageOfList
{
    class SumAndAvarageOfList
    {
        static void Main()
        {
            List<int> list = new List<int>();

            while (true)
            {
                string currString = Console.ReadLine();
                if (currString.Equals(string.Empty))
                {
                    break;
                }

                int currElement = int.Parse(currString);
                list.Add(currElement);
            }

            Console.WriteLine("Sum = {0}\nAverage = {1}", list.Sum(), list.Average());
        }
    }
}
