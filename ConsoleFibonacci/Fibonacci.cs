using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maddin
{
    public class Fibonacci
    {
        public int[] calcSeq()
        {
            int[] fibonacci = new int[9];

            for (int n = 1; n <= 8; n++)
            {
                fibonacci[n - 1] = n;
            }
            for (int i = 3; i <= 8; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
            return fibonacci;
        }

        public void toString(int[] seq)
        {
            for (int i = 0; i <= 8; i++)
            {
                System.Console.Write(seq[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
