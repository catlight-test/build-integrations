using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTest_failed_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FailedTestMethod1()
        {
             Assert.Fail("Fail 1");
        }

        [TestMethod]
        public void FailedTestMethod2()
        {
            Assert.Equals(1,2);
        }
    }
}
