using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTest_mixed_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SuccessfulTestMethod1()
        {
        }

        [TestMethod]
        public void FailedTestMethod1()
        {
            Assert.Equals(1, 2);
        }
    }
}
