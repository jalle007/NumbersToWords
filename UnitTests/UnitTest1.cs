using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.WCF;

namespace UnitTests
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCase_0()
        {
            string value = "0";
            string expected = "zero dollars";
            string result = Convertor.Convert(value);

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestCase_1()
        {
            string value = "1";
            string expected = "one dollar";
            string result = Convertor.Convert(value);

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestCase_25_1()
        {
            string value = "25,1";
            string expected = "twenty-five dollars and ten cents";
            string result = Convertor.Convert(value);

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestCase_0_01()
        {
            string value = "0,01";
            string expected = "zero dollars and one cent";
            string result = Convertor.Convert(value);

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestCase_45_100()
        {
            string value = "45 100";
            string expected = "forty-five thousand one hundred dollars";
            string result = Convertor.Convert(value);

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestCase_999_999_999_99()
        {
            string value = "999 999 999,99";
            string expected = "nine hundred ninety-nine million nine hundred ninety-nine thousand nine hundred ninety-nine dollars and ninety-nine cents";
            string result = Convertor.Convert(value);

            Assert.AreEqual(result, expected);
        }

    }
}
