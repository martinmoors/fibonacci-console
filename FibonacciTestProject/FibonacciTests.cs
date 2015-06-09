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
            fibonacci.initArray(8);
            int[] seq = fibonacci.calcSeq(8);
            fibonacci.initArray(7);
            int[] seqFail = fibonacci.calcSeq(7);
            int[] seqAssumed = { 1, 2, 3, 5, 8, 13, 21, 34 };
            CollectionAssert.AreEqual(seqAssumed, seq);
            CollectionAssert.AreNotEqual(seqAssumed, seqFail);
        }
    }
}
