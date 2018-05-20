using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FindTheMissingTermInAP.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void FindMissingTest()
        {
            var actual = Kata.FindMissing(new List<int> { 1, 3, 5, 9, 11 });
            Assert.AreEqual(7, actual);
        }


        [TestMethod()]
        public void test2()
        {
            var actual = Kata.FindMissing(new List<int> { 0, 5, 10, 20, 25 });
            Assert.AreEqual(15, actual);
        }

        [TestMethod()]
        public void test3()
        {
            var actual = Kata.FindMissing(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 });
            Assert.AreEqual(10, actual);
        }

    }
}