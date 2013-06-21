using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;

namespace SortingHomework.Tests
{
    public static class TestTools
    {
        public static bool CheckIfSorted<T>(IList<T> collection, int direction) where T : IComparable<T>
        {
            for (int index = 1; index < collection.Count; index++)
            {
                if (collection[index].CompareTo(collection[index - 1]) * direction < 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static IList<int> GetCollection()
        {
            return new List<int>(new int[]{ 22, 11, 100, 33, 0, 101 });
        }
    }
}
