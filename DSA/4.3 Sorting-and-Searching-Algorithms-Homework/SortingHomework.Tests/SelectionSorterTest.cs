using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingHomework.Tests
{
    [TestClass]
    public class SelectionSorterTest
    {
        [TestMethod]
        public void SelectionSorter_SortTest1()
        {
            var collection = TestTools.GetCollection();
            ISorter<int> sorter = new SelectionSorter<int>();
            sorter.Sort(collection);
            Assert.AreEqual(true, TestTools.CheckIfSorted<int>(collection, 1));
        }
    }
}
