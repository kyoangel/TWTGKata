using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PascalTriangle.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void test_level_1()
        {
            var actual = Kata.PascalsTriangle(1);
            actual.ToExpectedObject().ShouldEqual(new List<int>() { 1 });
        }

        [TestMethod()]
        public void test_level_2()
        {
            var actual = Kata.PascalsTriangle(2);
            actual.ToExpectedObject().ShouldEqual(new List<int>() { 1, 1, 1 });
        }

        [TestMethod()]
        public void test_level_3()
        {
            var actual = Kata.PascalsTriangle(3);
            actual.ToExpectedObject().ShouldEqual(new List<int>() { 1, 1, 1, 1, 2, 1 });
        }

        [TestMethod()]
        public void test_level_4()
        {
            var actual = Kata.PascalsTriangle(4);
            actual.ToExpectedObject().ShouldEqual(new List<int>() { 1, 1, 1, 1, 2, 1, 1, 3, 3, 1 });
        }

        [TestMethod()]
        public void test_level_5()
        {
            var actual = Kata.PascalsTriangle(5);
            actual.ToExpectedObject().ShouldEqual(new List<int>() { 1, 1, 1, 1, 2, 1, 1, 3, 3, 1, 1, 4, 6, 4, 1 });
        }
    }
}