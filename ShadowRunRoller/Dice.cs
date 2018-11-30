using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowRunRoller
{
    class Dice
    {
        private bool Exploding { get; set; }
        private Int32 Result { get; set; }
        private bool Rolled { get; set; }

        public Dice(bool isExploding)
        {
            this.Exploding = isExploding;
            this.Rolled = false;
        }

        public Dice() : this(false) { }

        public override string ToString()
        {
            return Result.ToString();
        }

        public bool doRoll()
        {
            if (this.Rolled)
            {
                return false;
            }

            Random rnd = new Random();
            int shortResult = 0;

            do
            {
                shortResult += rnd.Next(1, 7);
            } while (shortResult == 6 && this.Exploding == true);

            this.Result = shortResult;
            this.Rolled = true;

            return true;
        }
    }
}
