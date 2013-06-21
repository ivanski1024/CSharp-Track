using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingHomework.Tests
{
    [TestClass]
    public class MergeSorterTest
    {
        [TestMethod]
        public void MergeSorter_SortTest1()
        {
            var collection = TestTools.GetCollection();
            ISorter<int> sorter = new MergeSorter<int>();
            sorter.Sort(collection);
            Assert.AreEqual(true, TestTools.CheckIfSorted<int>(collection, 1));
        }
    }
}
