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
        private List<Dice> diceList;

        public Form1()
        {
            InitializeComponent();

            checkBox2.Hide();
        }

        private void createDice()
        {
            diceList = new List<Dice>();

            for (int i = 0; i < Int32.Parse(textBox3.Text); i++)
            {
                Dice oneDie = new Dice(checkBox1.Checked);
                oneDie.doRoll();

                diceList.Add(oneDie);
            }

            textBox4.AppendText(diceList.ForEach(x => String.Join(" ", x.ToString())) + Environment.NewLine);
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

            if (!int.TryParse(textBox3.Text, out tbValue))
            {
                changeInfo(@"You have to input a number of dice.", true);
                textBox3.Text = "5";
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
