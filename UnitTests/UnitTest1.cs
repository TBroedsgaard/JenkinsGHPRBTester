using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void BasicSums()
        {
            Assert.AreEqual(2 + 2, 2 + 2);
        }
    }
}
