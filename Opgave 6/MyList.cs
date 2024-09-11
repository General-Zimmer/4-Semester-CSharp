using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_6
{
    internal class MyList
    {
        private int[] Array = new int[10];
        private int Index = 0;

        public MyList() { }

        public void AddNumber(int num) {
            Array[Index] = num;
            Index++;
        }

        public void PrintArray()
        {
            for (int i = 0; i < Index; i++)
            {
                Console.WriteLine(Array.GetValue(i));
            }
    }
    }
}
