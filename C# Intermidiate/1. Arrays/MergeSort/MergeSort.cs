using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class MergeSort
    {
        static void Main()
        {
            string line = Console.ReadLine();
            string[] elements = line.Split(' ');
            int[] array = new int[elements.Length];
            for (int i = 0; i < elements.Length; i++)
            {
                array[i] = int.Parse(elements[i]);
            }
            int[] sorted = MergeSortFunc(array);
            for (int i = 0; i < sorted.Length; i++)
            {
                Console.Write("{0} ", sorted[i]);
            }
        }
        static int[] MergeSortFunc(int[] a)
        {
            if (a.Length == 1)
                return a;
            int middle = a.Length / 2;
            int[] left = new int[middle];
            for (int i = 0; i < middle; i++)
            {
                left[i] = a[i];
            }
            int[] right = new int[a.Length - middle];
            for (int i = 0; i < a.Length - middle; i++)
            {
                right[i] = a[i + middle];
            }
            left = MergeSortFunc(left);
            right = MergeSortFunc(right);

            int leftptr = 0;
            int rightptr = 0;

            int[] sorted = new int[a.Length];
            for (int k = 0; k < a.Length; k++)
            {
                if (rightptr == right.Length || ((leftptr < left.Length) && (left[leftptr] <= right[rightptr])))
                {
                    sorted[k] = left[leftptr];
                    leftptr++;
                }
                else if (leftptr == left.Length || ((rightptr < right.Length) && (right[rightptr] <= left[leftptr])))
                {
                    sorted[k] = right[rightptr];
                    rightptr++;
                }
            }
            return sorted;
        }
    }
}
