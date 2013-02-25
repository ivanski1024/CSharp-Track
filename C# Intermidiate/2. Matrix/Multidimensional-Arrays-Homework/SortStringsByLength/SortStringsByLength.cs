using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStringsByLength
{
    class SortStringsByLength
    {
        static void Main()
        {
            string line = Console.ReadLine();
            string[] array = line.Split(' ');
            SortByLength(ref array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void SortByLength(ref string[] array)
        {
            int p = 0;
            while (p < array.Length)
            {
                int currMin = array[p].Length, minPos = p;

                for (int j = p + 1; j < array.Length; j++)
                {
                    if (array[j].Length< currMin)
                    {
                        currMin = array[j].Length;
                        minPos = j;
                    }
                }
                SwapElements(ref array[p], ref array[minPos]);
                p++;
            }
        }

        private static void SwapElements(ref string p1, ref string p2)
        {
            string boof;
            boof = p1;
            p1 = p2;
            p2 = boof;
        }
    }
}
