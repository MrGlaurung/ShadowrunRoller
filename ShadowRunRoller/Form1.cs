using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ShadowRunRoller
{
    public partial class Form1 : Form
    {
        private DieRoller Roller { get; set; }

        public Form1()
        {
            InitializeComponent();

            checkBox2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeInfo(@"", true);
            this.Roller = new DieRoller(Int32.Parse(NumberOfDiceBox.Text), EdgeRollCheckbox.Checked);

            changeInfo(this.Roller.ResultString, this.Roller.SuccessOfRoll);
            ResultMultilineBox.AppendText(this.Roller.NumberResult + Environment.NewLine);

            SuccessResultBox.Text = this.Roller.NumberOfSuccesses.ToString();
            FailureResultBox.Text = this.Roller.NumberOfFailures.ToString();
            OnesResultBox.Text = this.Roller.NumberOfOnes.ToString();
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
                NumberOfDiceBox.Te;
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
