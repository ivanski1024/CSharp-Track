namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            Quicksort(collection, 0, collection.Count - 1);
        }

        public static void Quicksort(IList<T> collection, int left, int right)
        {
            int leftIndex = left, rightIndex = right;
            T pivot = collection[(left + right) / 2];

            while (leftIndex <= rightIndex)
            {
                while (collection[leftIndex].CompareTo(pivot) < 0)
                {
                    leftIndex++;
                }

                while (collection[rightIndex].CompareTo(pivot) > 0)
                {
                    rightIndex--;
                }

                if (leftIndex <= rightIndex)
                {
                    // Swap
                    T tmp = collection[leftIndex];
                    collection[leftIndex] = collection[rightIndex];
                    collection[rightIndex] = tmp;

                    leftIndex++;
                    rightIndex--;
                }
            }

            // Recursive calls
            if (left < rightIndex)
            {
                Quicksort(collection, left, rightIndex);
            }

            if (leftIndex < right)
            {
                Quicksort(collection, leftIndex, right);
            }
        }


    }
}
