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
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(biggerThanNeighbours(array, k));
        }

        static bool biggerThanNeighbours(int[] array, int k)
        {
            if(k>0 && k < array.Length-1)
            {
                return array[k] > array[k - 1] && array[k] > array[k + 1];
            }
            else if (k == 0)
            {
                return array[k] > array[k + 1];
            }
            else if (k == array.Length - 1)
            {
                return array[k] > array[k - 1];
            }
            else
            {
                Console.WriteLine("Index out of the range of the arrayay!");
                return false;
            }
        }
    }
}
