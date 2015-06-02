using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maddin
{
    /*
     * Calculates the fibonacci sequence in a console application
     * 
     * @Author Martin Moors
     */
    public class MainFibonacci
    {
        static void Main(string[] args)
        {
            Fibonacci fibonacci = new Fibonacci();
            fibonacci.toString(fibonacci.calcSeq());
           
        }

        
    }
}
