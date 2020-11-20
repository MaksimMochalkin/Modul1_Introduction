using Microsoft.VisualStudio.TestTools.UnitTesting;
using SystemDoubleExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SystemDoubleExtensions.Tests
{
    [TestClass()]
    public class DoubleExtensionTests
    {
        
        [TestMethod()]
        public void BinaryTest1()
        {
            double x = -255.255;
            string ExpectedResult = "1100000001101111111010000010100011110101110000101000111101011100";
            string actual = DoubleExtension.Binary(x);

            Assert.AreEqual(ExpectedResult, actual);
        }

        [TestMethod()]
        public void BinaryTest2()
        {
            double x = 255.255;
            string ExpectedResult = "0100000001101111111010000010100011110101110000101000111101011100";
            string result = DoubleExtension.Binary(x);

            Assert.AreEqual(result, ExpectedResult);
        }

        [TestMethod()]
        public void BinaryTest3()
        {
            double x = 4294967295.0;
            string ExpectedResult = "0100000111101111111111111111111111111111111000000000000000000000";
            string result = DoubleExtension.Binary(x);

            Assert.AreEqual(result, ExpectedResult);
        }
        
        [TestMethod()]
        public void BinaryTest4()
        {
            double x = double.MinValue;
            string ExpectedResult = "1111111111101111111111111111111111111111111111111111111111111111";
            string result = DoubleExtension.Binary(x);

            Assert.AreEqual(result, ExpectedResult);
        }

        [TestMethod()]
        public void BinaryTest5()
        {
            double x = double.MaxValue;
            string ExpectedResult = "0111111111101111111111111111111111111111111111111111111111111111";
            string result = DoubleExtension.Binary(x);

            Assert.AreEqual(result, ExpectedResult);
        }

        [TestMethod()]
        public void BinaryTest6()
        {
            double x = double.Epsilon;
            string ExpectedResult = "0000000000000000000000000000000000000000000000000000000000000001";
            string result = DoubleExtension.Binary(x);

            Assert.AreEqual(result, ExpectedResult);
        }

        [TestMethod()]
        public void BinaryTest7()
        {
            double x = double.NaN;
            string ExpectedResult = "1111111111111000000000000000000000000000000000000000000000000000";
            string result = DoubleExtension.Binary(x);

            Assert.AreEqual(result, ExpectedResult);
        }

        [TestMethod()]
        public void BinaryTest8()
        {
            double x = double.NegativeInfinity;
            string ExpectedResult = "1111111111110000000000000000000000000000000000000000000000000000";
            string result = DoubleExtension.Binary(x);

            Assert.AreEqual(result, ExpectedResult);
        }

        [TestMethod()]
        public void BinaryTest9()
        {
            double x = double.PositiveInfinity;
            string ExpectedResult = "0111111111110000000000000000000000000000000000000000000000000000";
            string result = DoubleExtension.Binary(x);

            Assert.AreEqual(result, ExpectedResult);
        }

        [TestMethod()]
        public void BinaryTest10()
        {
            double x = -0.0;
            string ExpectedResult = "1000000000000000000000000000000000000000000000000000000000000000";
            string result = DoubleExtension.Binary(x);

            Assert.AreEqual(result, ExpectedResult);
        }

        [TestMethod()]
        public void BinaryTest11()
        {
            double x = 0.0;
            string ExpectedResult = "0000000000000000000000000000000000000000000000000000000000000000";
            string result = DoubleExtension.Binary(x);

            Assert.AreEqual(result, ExpectedResult);
        }
    }
}
