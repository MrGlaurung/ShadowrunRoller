using System;

namespace ShadowRunRoller.DiceRollerTab
{
    class Dice
    {
        private bool Exploding { get; set; }
        private Int32 Result { get; set; }
        private bool Rolled { get; set; }
        public int Successes { get; private set; }

        public Dice(bool isExploding)
        {
            this.Exploding = isExploding;
            this.Rolled = false;
            this.Successes = 0;
        }

        public Dice() : this(false) { }

        public override string ToString()
        {
            return Result.ToString();
        }

        public int ToInt()
        {
            return Result;
        }

        public bool DoRoll(Random rnd)
        {
            if (this.Rolled)
            {
                return false;
            }

            int shortResult = 0;
            int totalResult = 0;

            do
            {
                shortResult = rnd.Next(1, 7);
                if (shortResult > 4) this.Successes += 1;
                totalResult += shortResult;
            } while (shortResult == 6 && this.Exploding == true);

            this.Result = totalResult;
            this.Rolled = true;

            return true;
        }
    }
}
