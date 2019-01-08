using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowRunRoller
{
    class DieRoller
    {
        public string ResultString { get; private set; }
        public bool SuccessOfRoll { get; private set; }
        public string NumberResult { get; private set; }
        public int NumberOfSuccesses { get; private set; }
        public int NumberOfFailures { get; private set; }
        public int NumberOfOnes { get; private set; }

        private Random rnd { get; set; }
        private List<Dice> diceList { get; set; }

        public DieRoller() : this(1, false) { }

        public DieRoller(int numberOfDice, bool edgeRoll)
        {
            this.rnd = new Random();

            this.ResultString = "";
            this.SuccessOfRoll = true;
            createDice(numberOfDice, edgeRoll);
        }

        private void createDice(int numberOfDice, bool edgeRoll)
        {
            this.diceList = new List<Dice>();

            for (int i = 0; i < numberOfDice; i++)
            {
                Dice oneDie = new Dice(edgeRoll);
                if (!oneDie.doRoll(rnd))
                {
                    throw new ApplicationException("Catastrophic failure with Dice.");
                }

                diceList.Add(oneDie);
            }

            this.NumberResult = String.Join(", ", this.diceList.Select(x => x.ToString()));

            checkResults(numberOfDice);
        }

        private void checkResults(int numberOfDice)
        {
            int halfOfDice = numberOfDice / 2;

            this.NumberOfSuccesses = diceList.Count(x => x.ToInt() > 4);
            this.NumberOfFailures = diceList.Count(x => x.ToInt() < 5);
            this.NumberOfOnes = diceList.Count(x => x.ToInt() == 1);

            if (diceList.Count(x => x.ToInt() == 1) > halfOfDice)
            {
                if (diceList.Count(x => x.ToInt() > 4) == 0)
                {
                    this.ResultString = @"Critical failure!!";
                    this.SuccessOfRoll = false;
                }
                else
                {
                    this.ResultString = @"This roll is a Glitch.";
                    this.SuccessOfRoll = true;
                }
            }
            else
            {
                this.ResultString = @"You have " + diceList.Count(x => x.ToInt() > 4).ToString() + " successes.";
                this.SuccessOfRoll = true;
            }
        }

    }
}
