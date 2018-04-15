using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortOdd.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void test_sample_1()
        {
            CollectionAssert.AreEqual(new int[] { 1, 3, 2, 8, 5, 4 }, Kata.SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
        }

        [TestMethod()]
        public void test_sample_2()
        {
            CollectionAssert.AreEqual(new int[] { 1, 3, 5, 8, 0 }, Kata.SortArray(new int[] { 5, 3, 1, 8, 0 }));
        }

        [TestMethod()]
        public void test_empty()
        {
            CollectionAssert.AreEqual(new int[] { }, Kata.SortArray(new int[] { }));
        }

        [TestMethod()]
        public void test_all_even()
        {
            CollectionAssert.AreEqual(new int[] { 2, 4, 6, 8, 10 }, Kata.SortArray(new int[] { 2, 4, 6, 8, 10 }));
        }
    }
}