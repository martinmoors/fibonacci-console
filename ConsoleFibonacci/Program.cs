using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    /*
     * Calculates the fibonacci sequence in a console application
     * 
     * test
     * 
     * @Author Martin Moors
     */
    class Program
    {
        static void Main(string[] args)
        {
            toString(calcSeq());
        }

        static int[] calcSeq()
        {
            int[] fibonacci = new int[46];

            for (int n = 1; n <= 43; n++)
            {
                fibonacci[n - 1] = n;
            }
            for (int i = 3; i <= 43; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
            return fibonacci;
        }

        static void toString(int[] seq) 
        {
            Console.Write("1 2 3 ");
            for (int i = 3; i <= 43; i++)
            {
                System.Console.Write(seq[i] + " ");
                if (i % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
