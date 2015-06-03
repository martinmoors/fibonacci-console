using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace de.gso
{
    /*
     * Tests the calculations of the fibonacci sequence
     * 
     * @Author Martin Moors
     */
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void TestSequence()
        {
            Fibonacci fibonacci = new Fibonacci();
            int[] seq = fibonacci.calcSeq(8);
            int[] seqFail = fibonacci.calcSeq(9);
            int[] seqAssumed = { 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            CollectionAssert.AreEqual(seqAssumed, seq);
            CollectionAssert.AreNotEqual(seqAssumed, seqFail);
        }
    }
}
