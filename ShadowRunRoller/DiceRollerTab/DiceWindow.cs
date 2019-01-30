using System;
using System.Windows.Forms;
using System.Drawing;
using ShadowRunRoller.DiceRollerTab;

namespace ShadowRunRoller
{
    public partial class DiceWindow : UserControl
    {
        private Random rnd;
        private ToolStripStatusLabel MainStatusLabel;

        private DieRoller Roller { get; set; }

        public DiceWindow(Random rand, ToolStripStatusLabel StatusLabel = null)
        {
            InitializeComponent();
            if(StatusLabel != null) { MainStatusLabel = StatusLabel; }
            this.rnd = rand;
        }

        private void SetStatusLabelText(string text)
        {
            if (MainStatusLabel != null)
            {
                MainStatusLabel.Text = text;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ChangeInfo(@"", true);
            this.Roller = new DieRoller(Int32.Parse(NumberOfDiceBox.Text), EdgeRollCheckbox.Checked);

            this.FixEverything();
        }

        private void FixEverything()
        {
            ChangeInfo(this.Roller.ResultString, !this.Roller.SuccessOfRoll);
            string resultText = this.Roller.NumberResult;
            string extraInfo = this.Roller.ResultString + " with " + this.Roller.NumberOfOnes + " 1:s rolled";
            Color col = Color.Black;

            if (Verbose.Checked == true) { resultText += " (" + extraInfo + ")"; }
            resultText += ".";

            if(!this.Roller.SuccessOfRoll) { col = Color.Red; }
            ResultMultilineBox.SelectionColor = col;
            ResultMultilineBox.AppendText(resultText + Environment.NewLine);
            ResultMultilineBox.ScrollToCaret();

            SuccessResultBox.Text = this.Roller.NumberOfSuccesses.ToString();
            FailureResultBox.Text = this.Roller.NumberOfFailures.ToString();
            OnesResultBox.Text = this.Roller.NumberOfOnes.ToString();

            SetStatusLabelText("Roll performed, " + this.Roller.NumberOfDice + " dice rolled. " + extraInfo);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Add exploding die
            this.OneMoreDie(true);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Add un-exploding die
            this.OneMoreDie(false);
        }

        private void OneMoreDie(bool exploding)
        {
            Dice myDie = new Dice(exploding);
            myDie.DoRoll(rnd);

            Roller.SumUp(Roller.NumberOfDice + 1, myDie);

            this.FixEverything();
        }

        private void NumberOfDiceBox_KeyPressed(object sender, EventArgs e)
        {

        }

        private void NumberOfDiceBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NumberOfDiceBox.Text) && !int.TryParse(NumberOfDiceBox.Text, out int tbValue))
            {
                ChangeInfo(@"You have to input a number of dice.", true);
                NumberOfDiceBox.Text = "5";
            }
            else
            {
                errorText.Text = "";
            }
        }

        private void ChangeInfo(string newInfo, bool isError)
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
