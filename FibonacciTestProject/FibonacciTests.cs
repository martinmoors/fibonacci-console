using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Maddin;
namespace Maddin
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void TestSequence()
        {
            Fibonacci fibonacci = new Fibonacci();
            int[] seq = fibonacci.calcSeq();
            int[] seqAssumed = { 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            CollectionAssert.AreEqual(seqAssumed, seq);
        }
    }
}
