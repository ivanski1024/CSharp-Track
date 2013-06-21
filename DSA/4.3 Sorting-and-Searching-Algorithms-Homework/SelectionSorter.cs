namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            for (int firstNotSortedIndex = 0; firstNotSortedIndex < collection.Count; firstNotSortedIndex++)
            {
                int minIndex = firstNotSortedIndex;
                for (int currIndex = firstNotSortedIndex+1; currIndex < collection.Count; currIndex++)
                {
                    if (collection[currIndex].CompareTo(collection[minIndex]) < 0)
                    {
                        minIndex = currIndex;
                    }
                }
                if (firstNotSortedIndex != minIndex)
                {
                    SwitchElementsInCollection(collection, firstNotSortedIndex, minIndex);
                }
            }
        }

        public static void SwitchElementsInCollection(IList<T> collection, int firstIndex, int secondIndex)
        {
            T boof = collection[firstIndex];
            collection[firstIndex] = collection[secondIndex];
            collection[secondIndex] = boof;
        }
    }
}
