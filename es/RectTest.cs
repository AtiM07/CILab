using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using hierarchy;

namespace ShapeTest
{
    [TestClass]
    public class RectTest
    {
        [TestMethod]
        public void TestRect1()
        {
            Rect rect = new Rect(0, 7, 7, 0);            
            double d = rect.Distance(-1, 1);
            Assert.AreEqual(1, d, 1e-6);
        }
        [TestMethod]
        public void TestRect2()
        {
            Rect rect = new Rect(0, 7, 7, 0);           
            double d = rect.Distance(8, 1);
            Assert.AreEqual(1, d, 1e-6);
        }
        [TestMethod]
        public void TestRect3()
        {
            Rect rect = new Rect(0, 7, 7, 0);            
            double d = rect.Distance(3, 8);
            Assert.AreEqual(1, d, 1e-6);
        }
        [TestMethod]
        public void TestRect4()
        {
            Rect rect = new Rect(0, 7, 7, 0);            
            double d = rect.Distance(3, -1);
            Assert.AreEqual(1, d, 1e-6);
        }
        [TestMethod]
        public void TestRect5()
        {
            Rect rect = new Rect(0, 7, 7, 0);
            double d = rect.Distance(-1, -1);
            Assert.AreEqual(Math.Sqrt(2), d, 1e-6);
        }
        [TestMethod]
        public void TestRect6()
        {
            Rect rect = new Rect(0, 7, 7, 0);            
            double d = rect.Distance(-1, 8);
            Assert.AreEqual(Math.Sqrt(2), d, 1e-6);
        }
        [TestMethod]
        public void TestRect7()
        {
            Rect rect = new Rect(0, 7, 7, 0);            
            double d = rect.Distance(8, 8);
            Assert.AreEqual(Math.Sqrt(2), d, 1e-6);
        }
        [TestMethod]
        public void TestRect8()
        {
            Rect rect = new Rect(0, 7, 7, 0);            
            double d = rect.Distance(8, -1);
            Assert.AreEqual(Math.Sqrt(2), d, 1e-6);
        }
        [TestMethod]
        public void TestRectInside()
        {
            Rect rect = new Rect(0, 7, 7, 0);            
            double d = rect.Distance(1, 1);
            Assert.AreEqual(-1, d, 1e-6);
        }
    }
}
