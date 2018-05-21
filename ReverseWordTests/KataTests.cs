using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReverseWord.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void ReverseWordsTest()
        {
            Assert.AreEqual("sihT si na !elpmaxe", Kata.ReverseWords("This is an example!"));
        }
    }
}