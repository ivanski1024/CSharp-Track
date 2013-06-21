using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingHomework
{
    public class Quicksorter2<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            Quicksort(collection, 0, collection.Count - 1);
        }

        private void Quicksort(IList<T> collection, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int pivotIndex = leftIndex + (rightIndex - leftIndex) / 2;
                T pivot = collection[pivotIndex];
                int l = leftIndex;
                int r = rightIndex;

                //While L and R are not the same.
                while (r - l >= 1)
                {
                    while (collection[l].CompareTo(pivot) < 0 && l <= pivotIndex)
                    {
                        l++;
                    }

                    while (collection[r].CompareTo(pivot) > 0 && pivotIndex <= r)
                    {
                        r--;
                    }

                    SelectionSorter<T>.SwitchElementsInCollection(collection, l, r);

                    if (pivotIndex == l && l == r)
                    {
                        break;
                    }
                    else if (pivotIndex == l)
                    {
                        pivotIndex = r;
                        l++;
                    }
                    else if(pivotIndex == r)
                    {
                        pivotIndex = l;
                        r--;
                    }
                }

                Quicksort(collection, leftIndex, pivotIndex - 1);
                Quicksort(collection, pivotIndex + 1, rightIndex);
            }
        }
    }
}
