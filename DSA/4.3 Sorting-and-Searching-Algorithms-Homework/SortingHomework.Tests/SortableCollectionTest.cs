using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingHomework.Tests
{
    [TestClass]
    public class SortableCollectionTest
    {
        [TestMethod]
        public void LinearSearchTest1()
        {
            SortableCollection<int> collection = new SortableCollection<int>(TestTools.GetCollection());
            Assert.AreEqual(true, collection.LinearSearch(33));
        }

        [TestMethod]
        public void LinearSearchTest2()
        {
            SortableCollection<int> collection = new SortableCollection<int>(TestTools.GetCollection());
            Assert.AreEqual(false, collection.LinearSearch(55));
        }

        [TestMethod]
        public void BinarySearchTest1()
        {
            SortableCollection<int> collection = new SortableCollection<int>(TestTools.GetCollection());
            collection.Sort(new Quicksorter<int>());
            Assert.AreEqual(true, collection.BinarySearch(33));
        }

        [TestMethod]
        public void BinarySearchTest2()
        {
            SortableCollection<int> collection = new SortableCollection<int>(TestTools.GetCollection());
            collection.Sort(new Quicksorter<int>());
            Assert.AreEqual(false, collection.BinarySearch(55));
        }
    }
}
