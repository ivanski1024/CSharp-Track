using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class SelectionSort
    {
        static void SwapElements(ref int first, ref int second)
        {
            int boof = first;
            first = second;
            second = boof;
        }
        static void Main()
        {
            string line = Console.ReadLine();
            string[] arrStr = line.Split(' ');
            int[] arr = new int[arrStr.Length];
            for (int i = 0; i < arrStr.Length; i++)
            {
                arr[i] = int.Parse(arrStr[i]);
            }
            int p=0;
            while (p < arr.Length)
            {
                int currMin = arr[p], minPos=p;

                for (int j = p+1; j < arr.Length; j++)
                { 
                    if(arr[j]<currMin)
                    {
                        currMin=arr[j];
                        minPos=j;
                    }
                }
                SwapElements(ref arr[p], ref arr[minPos]);
                p++;
            }
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write("{0} ", arr[j]);
            }
        }
    }
}
