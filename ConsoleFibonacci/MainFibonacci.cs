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
            int pos = Convert.ToInt32(fib.getPosition());
            fib.initArray(pos);
            fib.toString(fib.calcSeq(pos));
        }
    }
}
