using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Configuration;
using ShadowRunRoller.DiceRollerTab;

namespace ShadowRunRoller
{
    public partial class DiceWindow : UserControl
    {
        private Random rnd = new Random();
        private ToolStripStatusLabel MainStatusLabel;

        private DieRoller Roller { get; set; }

        public DiceWindow(ToolStripStatusLabel StatusLabel = null)
        {
            InitializeComponent();
            if(StatusLabel != null) { MainStatusLabel = StatusLabel; }
        }

        private void setStatusLabelText(string text)
        {
            if (MainStatusLabel != null)
            {
                MainStatusLabel.Text = text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeInfo(@"", true);
            this.Roller = new DieRoller(Int32.Parse(NumberOfDiceBox.Text), EdgeRollCheckbox.Checked);

            this.fixEverything();
        }

        private void fixEverything()
        {
            changeInfo(this.Roller.ResultString, this.Roller.SuccessOfRoll);
            string resultText = this.Roller.NumberResult;
            if(Verbose.Checked == true) { resultText += " (" + this.Roller.ResultString + " with " + this.Roller.NumberOfOnes + " 1:s rolled)"; }
            ResultMultilineBox.AppendText(resultText + Environment.NewLine);

            SuccessResultBox.Text = this.Roller.NumberOfSuccesses.ToString();
            FailureResultBox.Text = this.Roller.NumberOfFailures.ToString();
            OnesResultBox.Text = this.Roller.NumberOfOnes.ToString();
            setStatusLabelText("Roll performed, " + this.Roller.numberOfDice + " dice rolled.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Add exploding die
            this.OneMoreDie(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Add un-exploding die
            this.OneMoreDie(false);
        }

        private void OneMoreDie(bool exploding)
        {
            Dice myDie = new Dice(exploding);
            myDie.doRoll(rnd);

            Roller.SumUp(Roller.numberOfDice + 1, myDie);

            this.fixEverything();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int tbValue;

            if (!string.IsNullOrEmpty(NumberOfDiceBox.Text) && !int.TryParse(NumberOfDiceBox.Text, out tbValue))
            {
                changeInfo(@"You have to input a number of dice.", true);
                NumberOfDiceBox.Text = "5";
            }
            else
            {
                errorText.Text = "";
            }
        }

        private void changeInfo(string newInfo, bool isError)
        {
            if (isError)
            {
                successText.Text = "";
                errorText.Text = newInfo;
            }
            else
            {
                errorText.Text = "";
                successText.Text = newInfo;
            }
        }
    }
}
