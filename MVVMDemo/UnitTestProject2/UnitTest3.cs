using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, 2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(2, 3);
        }
    }
}
