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
            Fibonacci fibonacci = new Fibonacci();
            String position = "";
            Console.Write("Bitte Position eingeben: ");
            position = Console.ReadLine();
            fibonacci.toString(fibonacci.calcSeq(Convert.ToInt32(position) - 1));
        }
    }
}
