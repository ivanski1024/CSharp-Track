using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
            Console.WriteLine("Enter the first array with the elements separated with ' '. (No space at the end of the line!)");
            string line = Console.ReadLine();
            string[] Arr1 = line.Split(' ');
            Console.WriteLine("Enter the second array with the elements separated with ' '. (No space at the end of the line!)");
            line = Console.ReadLine();
            string[] Arr2 = line.Split(' ');
            bool same = true;
            if (Arr1.Length != Arr2.Length)
            {
                same = false;
            }
            else
            {
                for (int j = 0; j < Arr1.Length; j++)
                {
                    if (Arr1[j] != Arr2[j])
                    {
                        same = false;
                        break;
                    }
                }
            }
            Console.WriteLine(same);
        }
    }
}
