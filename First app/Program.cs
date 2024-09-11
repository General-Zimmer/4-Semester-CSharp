using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person martin = new Person("Martin");
            Console.WriteLine(martin);
            Console.ReadLine();
        }
    }
}
