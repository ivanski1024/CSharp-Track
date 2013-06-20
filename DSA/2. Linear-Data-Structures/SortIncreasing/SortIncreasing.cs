using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortIncreasing
{
    class SortIncreasing
    {
        static void Main()
        {
            List<int> list = new List<int>();

            while (true)
            {
                string currString = Console.ReadLine();
                if (currString == string.Empty)
                {
                    break;
                }
                else
                {
                    int currElement = int.Parse(currString);
                    list.Add(currElement);
                }
            }

            list.Sort();

            for (int index = 0; index < list.Count; index++)
            {
                Console.WriteLine(list[index]);
            }
        }
    }
}
