using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse_4._4
{
    internal static class Yeet
    {
        public static int power(this int n, int p)
        {
            if (p == 0)
                return 1;
            else
                return n * power(n, p - 1);
        }
    }
}
