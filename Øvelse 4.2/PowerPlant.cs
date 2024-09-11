using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse_4._2
{

    internal class PowerPlant
    {
        public delegate void Warning();
        private Warning warning;
        private Random Random = new Random();
        public PowerPlant()
        {
        }

        public void heatUp()
        {
            if (Random.Next(0, 100) > 50)
                this.warning();
        }

        public void addWarning(Warning warning)
        {
            this.warning += warning;
        }
    }
}
