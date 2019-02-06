using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ShadowRunRoller.DiceRollerTab
{
    class DieRoller
    {
        #region Properties
        public string ResultString { get; private set; }
        public bool SuccessOfRoll { get; private set; }
        public string NumberResult { get; private set; }
        public int NumberOfSuccesses { get; private set; }
        public int NumberOfFailures { get; private set; }
        public int NumberOfOnes { get; private set; }
        public int NumberOfDice { get; set; }
        private Random Rnd { get; set; }
        private List<Dice> DiceList { get; set; }
        #endregion

        #region Constructors
        public DieRoller(int numberOfDice, bool edgeRoll)
        {
            this.Rnd = new Random();

            this.ResultString = "";
            this.SuccessOfRoll = false;
            this.NumberOfDice = numberOfDice;
            CreateDice(numberOfDice, edgeRoll);
        }

        public DieRoller() : this(1, false) { }
        #endregion

        #region Private Class Functions
        private void CreateDice(int numberOfDice, bool edgeRoll)
        {
            this.DiceList = new List<Dice>();

            for (int i = 0; i < numberOfDice; i++)
            {
                Dice oneDie = new Dice(edgeRoll);
                if (!oneDie.DoRoll(Rnd))
                {
                    throw new ApplicationException("Catastrophic failure with Dice.");
                }

                DiceList.Add(oneDie);
            }

            SumUp(numberOfDice);
        }

        private void CheckResults(int numberOfDice)
        {
            this.NumberOfDice = numberOfDice;
            int halfOfDice = numberOfDice / 2;

            this.NumberOfSuccesses = DiceList.Sum(x => x.Successes);
            this.NumberOfFailures = DiceList.Count(x => x.ToInt() < 5);
            this.NumberOfOnes = DiceList.Count(x => x.ToInt() == 1);

            if (DiceList.Count(x => x.ToInt() == 1) > halfOfDice)
            {
                if (DiceList.Count(x => x.ToInt() > 4) == 0)
                {
                    this.ResultString = @"Critical failure";
                    this.SuccessOfRoll = false;
                }
                else
                {
                    this.ResultString = @"This roll is a Glitch with " + NumberOfSuccesses + " successes";
                    this.SuccessOfRoll = true;
                }
            }
            else
            {
                this.ResultString = @"You have " + NumberOfSuccesses + " successes";
                if (NumberOfSuccesses > 0) { this.SuccessOfRoll = true; }
            }
        }
        #endregion

        #region Class Functions
        public void SumUp(int numberOfDice, Dice die)
        {
            this.DiceList.Add(die);
            this.SumUp(numberOfDice);
        }

        public void SumUp(int numberOfDice)
        {
            this.NumberResult = String.Join(", ", this.DiceList.Select(x => x.ToString()));

            CheckResults(numberOfDice);
        }
        #endregion
    }
}
