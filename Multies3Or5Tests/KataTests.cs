using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Multies3Or5.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void test_input_10_return_23()
        {
            var actual = Kata.Solution(10);
            Assert.AreEqual(23, actual);
        }
    }
}