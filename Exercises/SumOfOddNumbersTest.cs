using NUnit.Framework;
using System;

namespace Exercises
{
    [TestFixture]
    public class SumOfOddNumbersTest
    {
        [Test]
        [TestCase(1, 1)]
        [TestCase(74088, 42)]
        [TestCase(148877, 53)]
        [TestCase(1000000, 100)]
        public void Test(long expected, long n)
        {
            Assert.AreEqual(expected, SumOfOddNumbers.RowSumOddNumbers(n));
        }
    }
}
