using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CountingChangeCombinations.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void test_sum_4_with_coin_1_2_should_be_3()
        {
            var actual = Kata.CountCombinations(4, new int[] { 1, 2 });
            Assert.AreEqual(3, actual);
        }

        [TestMethod()]
        public void test_sum_10_with_coin_5_2_3_should_be_4()
        {
            var actual = Kata.CountCombinations(10, new int[] { 5, 2, 3 });
            Assert.AreEqual(4, actual);
        }
    }
}