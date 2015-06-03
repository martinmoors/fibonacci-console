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
    public class Fibonacci
    {
        public int[] calcSeq(int position)
        {
            int[] fibonacci = new int[position + 1];

            for (int n = 1; n <= position; n++)
            {
                fibonacci[n - 1] = n;
            }
            for (int i = 3; i <= position; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
            return fibonacci;
        }

        public void toString(int[] seq)
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
                        System.Console.Write(seq[i] + " ");
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
