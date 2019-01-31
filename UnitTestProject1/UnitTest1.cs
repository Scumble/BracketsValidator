using System;
using ConsoleApp4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "()";
            bool expected = true;

            bool actual = Bracket.checkBrackets(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = ")(";
            bool expected = false;

            bool actual = Bracket.checkBrackets(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = "(()))";
            bool expected = false;

            bool actual = Bracket.checkBrackets(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string input = "(())()";
            bool expected = true;

            bool actual = Bracket.checkBrackets(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
