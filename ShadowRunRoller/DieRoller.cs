using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowRunRoller
{
    class DieRoller
    {
        private Random rnd;

        public DieRoller() : this(1) { }

        public DieRoller(int NumberOfDice)
        {
            rnd = new Random();
        }
    }
}
