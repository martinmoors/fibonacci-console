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
            fibonacci.initArray(5);
            long[] seq = fibonacci.calcSeq(5);
            fibonacci.initArray(7);
            long[] seqFail = fibonacci.calcSeq(7);
            long[] seqAssumed = { 1, 2, 3, 5, 8 };
            CollectionAssert.AreEqual(seqAssumed, seq);
            CollectionAssert.AreNotEqual(seqAssumed, seqFail);
        }
    }
}
