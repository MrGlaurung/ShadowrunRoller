using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadowRunRoller
{
    public partial class Form1 : Form
    {
        private DieRoller roller;

        public Form1()
        {
            InitializeComponent();

            checkBox2.Hide();
        }

        private void createDice()
        {
            diceList = new List<Dice>();

            for (int i = 0; i < Int32.Parse(NumberOfDiceBox.Text); i++)
            {
                Dice oneDie = new Dice(EdgeRollCheckbox.Checked);
                if (!oneDie.doRoll(rnd))
                {
                    throw new ApplicationException("Catastrophic failure with Dice.");
                }

                diceList.Add(oneDie);
            }

            diceList.ForEach(x => ResultMultilineBox.AppendText(x.ToString()));
            ResultMultilineBox.AppendText(Environment.NewLine);

            SuccessResultBox.Text = diceList.Count(x => x.ToInt() > 4).ToString();
            FailureResultBox.Text = diceList.Count(x => x.ToInt() == 1).ToString();

            checkResults();
        }

        private void checkResults()
        {
            int halfOfDice = Int32.Parse(NumberOfDiceBox.Text) / 2;
            if (diceList.Count(x => x.ToInt() == 1) > halfOfDice)
            {
                if (diceList.Count(x => x.ToInt() > 4) == 0)
                {
                    changeInfo(@"Critical failure!!", true);
                }
                else
                {
                    changeInfo(@"This roll is a Glitch.", true);
                }
            }
            else
            {
                changeInfo(@"You have " + diceList.Count(x => x.ToInt() > 4).ToString() + " successes.", false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeInfo(@"", true);
            createDice();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int tbValue;

            if (!int.TryParse(NumberOfDiceBox.Text, out tbValue))
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
