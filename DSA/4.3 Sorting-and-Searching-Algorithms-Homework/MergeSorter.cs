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
            MergeSort(collection);
        }
        private IList<T> MergeSort(IList<T> collection)
        {

            


            // if list size is 0 (empty) or 1, consider it sorted
            // (using less than or equal prevents infinite recursion for a zero length m)
            if (collection.Count <= 1)
            {
                return collection;
            }
            else
            {
                // else list size is > 1, so split the list into two sublists
                IList<T> left = collection.Where<T>(
                    , right;
                int middle = collection.Count / 2;
                // recursively call merge_sort() to further split each sublist
                // until sublist size is 1
                left = MergeSort(left);
                right = MergeSort(right);
                // merge the sublists returned from prior calls to merge_sort()
                // and return the resulting merged sublist
                return Merge(left, right);
            }
        }


        //private IList<T> Merge(IList<T> left, IList<T> right)
        //{
        //    IList<T> result;
        //    while length(left) > 0 or length(right) > 0
        //        if length(left) > 0 and length(right) > 0
        //            if first(left) <= first(right)
        //                append first(left) to result
        //                left = rest(left)
        //            else
        //                append first(right) to result
        //                right = rest(right)
        //        else if length(left) > 0
        //            append first(left) to result
        //            left = rest(left)
        //        else if length(right) > 0
        //            append first(right) to result
        //            right = rest(right)
        //    end while
        //    return result;
        //}



        public static IList<T> Subsequance<T>(this IList<T> collection, int from, int to)
        {
            int length = collection.Count;

            if (from < 0 || length <= from)
            {
                throw new ArgumentOutOfRangeException("'from' is out of the boundries of the collection");
            }
            else if (to < 0 || length <= to)
            {
                throw new ArgumentOutOfRangeException("'to' is out of the boundries of the collection");
            }
            else if (to < from)
            {
                throw new ArgumentOutOfRangeException("'from' should be less than 'to'");
            }
            else
            {
                
            }
        }
    }
}