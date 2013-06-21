using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingHomework.Tests
{
    [TestClass]
    public class QuicksorterTest
    {
        [TestMethod]
        public void Quicksorter_SortTest()
        {
            var collection = TestTools.GetCollection();
            ISorter<int> sorter = new Quicksorter<int>();
            sorter.Sort(collection);
            Assert.AreEqual(true, TestTools.CheckIfSorted<int>(collection, 1));
        }
    }
}
