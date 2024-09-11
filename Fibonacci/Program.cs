using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int fib = Fibonacci(76);
            Console.WriteLine(fib);
            Console.ReadLine();
        }


        public static int Fibonacci(int n, ref int[] array)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                if (array[n-1] == 0)
                {
                    array[n - 1] = Fibonacci(n - 1, ref array);
                }
                if (array[n - 2] == 0)
                {
                    array[n - 2] = Fibonacci(n - 2, ref array);
                }
                return array[n - 1] + array[n - 2];
            }
        }

        public static int Fibonacci(int n)
        {
            int[] arraying = new int[n];
            return Fibonacci(n, ref arraying);
        }
    }
}
