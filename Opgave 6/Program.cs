using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList myList = new MyList();
            myList.AddNumber(1);
            myList.AddNumber(2);
            myList.AddNumber(3);
            myList.AddNumber(4);
            myList.AddNumber(5);
            myList.PrintArray();
            Console.ReadLine();
        }
    }
}
