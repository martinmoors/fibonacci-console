using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de.gso
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
            Fibonacci fib = new Fibonacci();
            fib.toString(fib.calcSeq(Convert.ToInt32(fib.getPosition()) - 1));
        }
    }
}
