using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse_4._2
{
    internal class Program
    {
        public static List<String> Warnings = new List<string>();
        public delegate void Warning();
        static void Main(string[] args)
        {
            PowerPlant powerPlant = new PowerPlant();
            powerPlant.addWarning(consoleWarning);
            powerPlant.addWarning(FUCKwarning);

            for (int i = 0; i < 10; i++)
            {
                powerPlant.heatUp();
            }
            Console.WriteLine(Warnings.Count());
            Console.ReadLine();
        }

        public static void consoleWarning()
        {
            Console.WriteLine("WAAAARNING");
        }

        public static void FUCKwarning()
        {
            Warnings.Add("List warniniiing");
        }
    }
}
