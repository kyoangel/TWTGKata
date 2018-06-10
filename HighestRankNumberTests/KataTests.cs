using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HighestRankNumber.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void empty_array_should_return_0()
        {
            var actual = Kata.HighestRank(new int[0]);
            Assert.AreEqual(0, actual);
        }

        [TestMethod()]
        public void single_element_array_test()
        {
            var actual = Kata.HighestRank(new int[] { 6 });
            Assert.AreEqual(6, actual);
        }

        [TestMethod()]
        public void the_same_count_number_should_return_bigger_one()
        {
            var actual = Kata.HighestRank(new int[] { 6, 9 });
            Assert.AreEqual(9, actual);
        }

        [TestMethod()]
        public void the_most_frequent_number_should_be_return()
        {
            var actual = Kata.HighestRank(new int[] { 12, 10, 8, 8, 3, 3, 3, 3, 2, 4, 10, 12, 10 });
            Assert.AreEqual(3, actual);
        }
    }
}