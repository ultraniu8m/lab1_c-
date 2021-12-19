using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using library_for_test;

namespace tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int input = 10;
            int[] output = new int [3]{ 1, 2, 5 };
            string[] got = PrimeFactors(10);
            Assert.Equals(output, got);
        }
        public void TestMethod2()
        {

        }
    }
}
