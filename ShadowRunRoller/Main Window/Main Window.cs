using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShadowRunRoller.DiceRollerTab;

namespace ShadowRunRoller.Main_Window
{
    public partial class Main_Window : Form
    {
        public Main_Window()
        {
            InitializeComponent();
            MainWindowTab1.Controls.Add(new DiceWindow(MainWindowTooltipTextStripLeft));
            MainWindowTab1.Controls[0].Anchor = ( AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right );
            MainWindowTooltipTextStripLeft.Text = @"Program Loaded.";
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.Environment.APPLICATION_HELP, Resources.Environment.APPLICATION_NAME + " " + Resources.Environment.APPLICATION_VERSION);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void diceRollerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindowTabControl.SelectedTab = MainWindowTab1;
        }

        private void nPCGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindowTabControl.SelectedTab = MainWindowTab2;
        }
    }
}
