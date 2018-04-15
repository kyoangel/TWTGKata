using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnagramDetection.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void test_sample1_foefet_toffee_true()
        {
            var actual = Kata.IsAnagram("foefet", "toffee");
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void test_sample1_Buckethead_DeathCubeK_true()
        {
            var actual = Kata.IsAnagram("Buckethead", "DeathCubeK");
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void test_sample1_Twoo_Woot_true()
        {
            var actual = Kata.IsAnagram("Twoo", "Woot");
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void test_sample1_apple_pale_true()
        {
            var actual = Kata.IsAnagram("apple", "pale");
            Assert.IsFalse(actual);
        }
    }
}