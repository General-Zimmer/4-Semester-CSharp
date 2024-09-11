using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1.Factorial());
            Console.WriteLine(4.Factorial());
            Console.ReadLine();
        }

        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }

    }
}
