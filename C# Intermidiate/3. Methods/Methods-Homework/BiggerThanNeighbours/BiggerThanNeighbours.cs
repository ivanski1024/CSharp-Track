using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerThanNeighbours
{
    class BiggerThanNeighbours
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(biggerThanNeighbours(arr, k));
        }

        static bool biggerThanNeighbours(int[] arr, int k)
        {
            if(k>0 && k < arr.Length-1)
            {
                return arr[k] > arr[k - 1] && arr[k] > arr[k + 1];
            }
            else if (k == 0)
            {
                return arr[k] > arr[k + 1];
            }
            else if (k == arr.Length - 1)
            {
                return arr[k] > arr[k - 1];
            }
            else
            {
                Console.WriteLine("Index out of the range of the array!");
                return false;
            }
        }
    }
}
