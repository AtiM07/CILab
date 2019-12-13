using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using дз3;

namespace TestRect
{
    [TestClass]
    public class TectRect
    {
        [TestMethod]
        public void RectLeftV()
        {
            Rect r = new Rect(1, 3, 4, 1);
            double d = r.Distance(1, 5);
            Assert.AreEqual(2, d, 1e-6);
        }

        [TestMethod]
        public void RectLeftPar()
        {
            Rect r = new Rect(1, 3, 4, 1);
            double d = r.Distance(0, 2);
            Assert.AreEqual(1, d, 1e-6);
        }

        [TestMethod]
        public void RectLeftN()
        {
            Rect r = new Rect(1, 3, 4, 1);
            double d = r.Distance(1, 0);
            Assert.AreEqual(1, d, 1e-6);
        }

        [TestMethod]
        public void RectRigthV()
        {
            Rect r = new Rect(1, 3, 4, 1);
            double d = r.Distance(4, 5);
            Assert.AreEqual(2, d, 1e-6);
        }

        [TestMethod]
        public void RectRigthPar()
        {
            Rect r = new Rect(1, 3, 4, 1);
            double d = r.Distance(5, 2);
            Assert.AreEqual(1, d, 1e-6);
        }

        [TestMethod]
        public void RectRigthN()
        {
            Rect r = new Rect(1, 3, 4, 1);
            double d = r.Distance(4, 0);
            Assert.AreEqual(1, d, 1e-6);
        }

        [TestMethod]
        public void RectV()
        {
            Rect r = new Rect(1, 3, 4, 1);
            double d = r.Distance(3, 5);
            Assert.AreEqual(2, d, 1e-6);
        }

        [TestMethod]
        public void RectPar1Left()
        {
            Rect r = new Rect(1, 4, 4, 1);
            double d = r.Distance(3, 3);
            Assert.AreEqual(1, d, 1e-6);
        }

        [TestMethod]
        public void RectPar1Rigth()
        {
            Rect r = new Rect(1, 4, 4, 1);
            double d = r.Distance(2, 3);
            Assert.AreEqual(1, d, 1e-6);
            double p = r.Distance(2, 2);
            Assert.AreEqual(1, p, 1e-6);
        }

        [TestMethod]
        public void RectN()
        {
            Rect r = new Rect(1, 3, 4, 1);
            double d = r.Distance(3, 0);
            Assert.AreEqual(1, d, 1e-6);
        }

        [TestMethod]
        public void Rect()
        {
            Rect r = new Rect(2, 4, 5, -3);
            double d = r.Distance(3, 2);
            Assert.AreEqual(1, d, 1e-6);
        }

    }
}
