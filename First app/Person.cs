using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_app
{
    internal class Person
    {
        public String name; 

        public Person(String name) { this.name = name; }

        override public String ToString() {
            return name;
        }
    }
}
