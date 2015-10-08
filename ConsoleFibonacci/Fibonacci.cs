using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de.gso
{

    /*
     * Calculates the fibonacci sequence in an console application
     * 
     * @Author Martin Moors
     */
    public class Fibonacci
    {

        long[] fib;

        public void initArray(int pos)
        {
            fib = new long[pos];
        }
       
        public long[] calcSeq(int pos)
        {
            fillArrayRecursive(1, pos - 2);

            calculateSequenceRecursive(2, pos - 2);

            fib[0] = 1;

            return fib;
        }

        public void calculateSequenceRecursive(int l, int pos)
        {
            if (l <= pos)
            {
                l++;
                fib[l] = fib[l - 1] + fib[l - 2];
                calculateSequenceRecursive(l, pos);
            }
        }

        public void fillArrayRecursive(int l, int pos) {
           
            if (l <= pos)
            {
                l++;
                fib[l - 1] = l;
                fillArrayRecursive(l, pos);
            }
        }

        public void toString(long[] seq)
        {
            switch (seq.Length)
            {
                case 1:
                    System.Console.Write("1");
                    break;
                case 2:
                    System.Console.Write("1 2");
                    break;
                case 3:
                    System.Console.Write("1 2 3");
                    break;
                default:
                    for (int i = 0; i <= seq.Length - 1; i++)
                    {
                        System.Console.WriteLine(seq[i]);
                    }
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public String getPosition()
        {
            String position = "";
            int i = 0;
            Console.Write("Bitte Position eingeben: ");
            position = Console.ReadLine();
            bool result = int.TryParse(position, out i);
            while (!result)
            {
                Console.WriteLine("Eingabe keine Zahl!");
                Console.Write("Bitte Position eingeben: ");
                position = Console.ReadLine();
                result = int.TryParse(position, out i);
            }
            return position;
        }
    }
}
