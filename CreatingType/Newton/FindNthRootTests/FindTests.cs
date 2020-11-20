using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindNthRoot;
using System;
using System.Collections.Generic;
using System.Text;

namespace FindNthRoot.Tests
{
    [TestClass()]
    public class FindTests
    {
        [TestMethod()]
        public void TestCase1()
        {
            double test;
            test = Find.Newton(1, 5, 0.0001);
            Assert.AreEqual(test, 1, 1);
        }

        [TestMethod()]
        public void TestCase2()
        {
            double test;
            test = Find.Newton(8, 3, 0.0001);
            Assert.AreEqual(test, 2, 1);
        }

        [TestMethod()]
        public void TestCase3()
        {
            double test;
            test = Find.Newton(0.001, 3, 0.0001);
            Assert.AreEqual(test, 0.1, 1);
        }

        [TestMethod()]
        public void TestCase4()
        {
            double test;
            test = Find.Newton(0.04100625, 4, 0.0001);
            Assert.AreEqual(test, 0.45, 1);
        }

        [TestMethod()]
        public void TestCase5()
        {
            double test;
            test = Find.Newton(8, 3, 0.0001);
            Assert.AreEqual(test, 2, 1);
        }

        [TestMethod()]
        public void TestCase6()
        {
            double test;
            test = Find.Newton(0.0279936, 7, 0.0001);
            Assert.AreEqual(test, 0.6, 1);
        }

        [TestMethod()]
        public void TestCase7()
        {
            double test;
            test = Find.Newton(0.0081, 4, 0.1);
            Assert.AreEqual(test, 0.3, 1);
        }

        public void TestCase8()
        {
            double test;
            test = Find.Newton(-0.008, 3, 0.1);
            Assert.AreEqual(test, -0.2, 1);
        }

        [TestMethod()]
        public void TestCase9()
        {
            double test;
            test = Find.Newton(0.004241979, 9, 0.00000001);
            Assert.AreEqual(test, 0.545, 1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCase10_OutOfRange()
        => Find.Newton(-0.01, 2, 0.0001);

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCase11_OutOfRange()
            => Find.Newton(0.001, -2, 0.0001);

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCase12_OutOfRange()
            => Find.Newton(0.01, 2, -1);
    }
}