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
    }
}