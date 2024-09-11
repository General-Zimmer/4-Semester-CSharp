using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateAge(new DateTime(1990, 1, 1), out int aging);
            Console.WriteLine(aging);
            Console.ReadLine();
        }

        static void CalculateAge(DateTime BirthDateInput, out int age)
        {
            age = DateTime.Now.Year - BirthDateInput.Year;
        }
    }
}
