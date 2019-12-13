using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using дз3;

namespace TestShape
{
    [TestClass]
    public class TestLine
    {
        [TestMethod]
        public void TestLineBefore()
        {
            Line l = new Line(0, 2, 2, 2);
            double d = l.Distance(-1, 2);
            Assert.AreEqual(1, d, 1e-6);
        }
        [TestMethod]
        public void TestLineAfter()
        {
            Line l = new Line(0, 2, 2, 2);
            double d = l.Distance(3, 2);
            Assert.AreEqual(1, d, 1e-6);
        }
        [TestMethod]
        public void TestLineMiddle()
        {
            Line l = new Line(0, 2, 2, 2);
            double d = l.Distance(1, 3);
            Assert.AreEqual(1, d, 1e-6);
        }
        [TestMethod]
        public void TestLineOn()
        {
            Line l = new Line(0, 2, 2, 2);
            double d = l.Distance(1, 2);
            Assert.AreEqual(0, d, 1e-6);
        }
    }
}
