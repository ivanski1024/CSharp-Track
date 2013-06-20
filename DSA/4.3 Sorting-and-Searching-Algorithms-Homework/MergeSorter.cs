namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            T[] boofArray = new T[collection.Count];

            collection.CopyTo(boofArray, 0);

            T[] sortedArray = MergeSort(boofArray);

            ReplaceCollection(collection, sortedArray);
        }

        private T[] MergeSort(T[] array)
        {
            int Length = array.Length;
            bool ArrayIsWithEvenLength = (Length % 2) == 0;

            if (Length <= 1)
            {
                return array;
            }
            else
            {
                T[] left, right;

                if (ArrayIsWithEvenLength)
                {
                    right = new T[Length / 2];
                }
                else
                {
                    right = new T[Length / 2 + 1];
                    right[Length / 2] = array[Length - 1];
                }
                left = new T[Length / 2];

                for (int index = 0; index < Length / 2; index++)
                {
                    left[index] = array[index];
                    right[index] = array[Length / 2 + index];
                }

                left = MergeSort(left);
                right = MergeSort(right);

                return Merge(left, right);
            }
        }

        private T[] Merge(T[] left, T[] right)
        {
            int leftLength = left.Length;
            int rightLength = right.Length;
            int length = leftLength + rightLength;

            T[] merged = new T[length];

            int leftIndex = 0;
            int rightIndex = 0;

            for (int index = 0; index < length; index++)
            {
                if (leftIndex < leftLength && rightIndex < rightLength)
                {
                    if (left[leftIndex].CompareTo(right[rightIndex]) <= 0)
                    {
                        merged[index] = left[leftIndex];
                        leftIndex++;
                    }
                    else
                    {
                        merged[index] = right[rightIndex];
                        rightIndex++;
                    }
                }
                else if (leftIndex >= leftLength)
                {
                    merged[index] = right[rightIndex];
                    rightIndex++;
                }
                else
                {
                    merged[index] = left[leftIndex];
                    leftIndex++;
                }
            }
            return merged;
        }

        private T Min(T t1, T t2)
        {
            if (t1.CompareTo(t2) <= 0)
            {
                return t1;
            }
            else
            {
                return t2;
            }
        }

        private void ReplaceCollection(IList<T> collection, T[] sortedArray)
        {
            if (collection.Count != sortedArray.Length)
            {
                throw new ArgumentException("The collections in the arguments are not with the same length!");
            }
            else
            {
                for (int index = 0; index < collection.Count; index++)
                {
                    collection[index] = sortedArray[index];
                }
            }
        }
    }
}