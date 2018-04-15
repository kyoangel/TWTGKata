using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarParkEscape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedObjects;

namespace CarParkEscape.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod]
        public void BasicTest1()
        {
            Kata kata = new Kata();
            int[,] carpark = new int[,] { { 1, 0, 0, 0, 2 },
                                          { 0, 0, 0, 0, 0 } };
            string[] expected = new string[] { "L4", "D1", "R4" };
            var actual = kata.escape(carpark);
            actual.ToExpectedObject().ShouldEqual(expected);
        }

        [TestMethod]
        public void BasicTest2()
        {
            Kata kata = new Kata();
            int[,] carpark = new int[,] { { 2, 0, 0, 1, 0 },
                                          { 0, 0, 0, 1, 0 },
                                          { 0, 0, 0, 0, 0 } };
            string[] expected = new string[] { "R3", "D2", "R1" };
            var actual = kata.escape(carpark);
            actual.ToExpectedObject().ShouldEqual(expected);
        }

        [TestMethod]
        public void BasicTest3()
        {
            Kata kata = new Kata();
            int[,] carpark = new int[,] { { 0, 2, 0, 0, 1 },
                                          { 0, 0, 0, 0, 1 },
                                          { 0, 0, 0, 0, 1 },
                                          { 0, 0, 0, 0, 0 } };
            string[] expected = new string[] { "R3", "D3" };
            var actual = kata.escape(carpark);
            actual.ToExpectedObject().ShouldEqual(expected);
        }

        [TestMethod]
        public void BasicTest4()
        {
            Kata kata = new Kata();
            int[,] carpark = new int[,] { { 1, 0, 0, 0, 2 },
                                          { 0, 0, 0, 0, 1 },
                                          { 1, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 0 } };
            string[] expected = new string[] { "L4", "D1", "R4", "D1", "L4", "D1", "R4" };
            var actual = kata.escape(carpark);
            actual.ToExpectedObject().ShouldEqual(expected);
        }

        [TestMethod]
        public void BasicTest5()
        {
            Kata kata = new Kata();
            int[,] carpark = new int[,] { { 0, 0, 0, 0, 2 } };
            string[] expected = new string[] { };
            var actual = kata.escape(carpark);
            actual.ToExpectedObject().ShouldEqual(expected);
        }

        [TestMethod]
        public void BasicTest6()
        {
            Kata kata = new Kata();
            int[,] carpark = new int[,] { { 1, 0, 0, 0, 0 },
                                          { 1, 0, 0, 0, 2 },
                                          { 1, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 0 } };
            string[] expected = new string[] { "L4", "D2", "R4" };

            var actual = kata.escape(carpark);
            actual.ToExpectedObject().ShouldEqual(expected);
        }
    }
}