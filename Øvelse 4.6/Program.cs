using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse_4._6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Person> people = new List<Person>
            {
                new Person {Name = "Lasse", Weight = 90, Height = 190},
                new Person {Name = "Lone", Weight = 70, Height = 160},
                new Person {Name = "Lasse2", Weight = 80, Height = 180},
                new Person {Name = "Lis", Weight = 60, Height = 170},
                new Person {Name = "Lene", Weight = 50, Height = 150},
                new Person {Name = "Simon", Weight = 40, Height = 140},
                new Person {Name = "Liva", Weight = 30, Height = 130},
                new Person {Name = "Lulu", Weight = 20, Height = 120},
                new Person {Name = "Lucas", Weight = 10, Height = 110},
                new Person {Name = "Luna", Weight = 5, Height = 100}
            };

            people.Sort(new ByWeightSorter());
            Console.WriteLine("Weight sorter: ");
            foreach (Person person in people)
            {
                Console.WriteLine(person.Name + " " + person.Weight + " " + person.Height);
            }
            Console.WriteLine("");
            Console.WriteLine();


            people.Sort(new ByHeightSorter());
            Console.WriteLine("Height sorter");
            foreach (Person person in people)
            {
                Console.WriteLine(person.Name + " " + person.Weight + " " + person.Height);
            }
            Console.WriteLine();
            Console.WriteLine();


            people.Sort(new ByNameSorter());
            Console.WriteLine("Name sorter");
            foreach (Person person in people)
            {
                Console.WriteLine(person.Name + " " + person.Weight + " " + person.Height);
            }
            Console.WriteLine();
            Console.WriteLine();
           
            Console.ReadLine();
        }

        public class ByWeightSorter : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                return x.Weight.CompareTo(y.Weight);
            }
        }

        public class ByHeightSorter : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                return x.Height.CompareTo(y.Height);
            }
        }

        public class ByNameSorter : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }

        public class Person
        {
            public string Name { get; set; }
            public int Weight { get; set; }
            public int Height { get; set; }
        }
    }
}
