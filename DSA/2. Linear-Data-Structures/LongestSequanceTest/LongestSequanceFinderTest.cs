using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LongestSequance;

namespace LongestSequanceTest
{
    [TestClass]
    public class LongestSequanceFinderTest
    {
        [TestMethod]
        public void FindLongestSequanceTest1()
        {
            List<int> list = new List<int>();
            for (int index = 0; index < 5; index++)
            {
                for (int secondIndex = 0; secondIndex < index; secondIndex++)
                {
                    list.Add(index);
                }
            }

            List<int> output = LongestSequanceFinder.FindLongestSequance(list);
            Assert.AreEqual(4, output.Count);
            for (int index = 0; index < output.Count; index++)
            {
                Assert.AreEqual(4, output[index]);
            }
        }

        [TestMethod]
        public void FindLongestSequanceTest2()
        {
            List<int> list = new List<int>();
            List<int> output = LongestSequanceFinder.FindLongestSequance(list);
            Assert.AreEqual(0, output.Count);
        }
    }
}
