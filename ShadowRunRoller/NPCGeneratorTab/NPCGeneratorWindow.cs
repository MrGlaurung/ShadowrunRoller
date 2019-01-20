using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShadowRunRoller.Resources;

namespace ShadowRunRoller.NPCGeneratorTab
{
    public partial class NPCGeneratorWindow : UserControl
    {
        private ToolStripStatusLabel MainStatusLabel;

        public NPCGeneratorWindow(ToolStripStatusLabel StatusLabel = null)
        {
            InitializeComponent();
            SetupToolTips();
            if (StatusLabel != null) { MainStatusLabel = StatusLabel; }
        }

        private void setStatusLabelText(string text)
        {
            if (MainStatusLabel != null)
            {
                MainStatusLabel.Text = text;
            }
        }

        private void SetupToolTips()
        {
            AssignToolTip("Body", "Physical", Globals.BODY_EXPLAINED, BodyStatLabel);
            AssignToolTip("Agility", "Physical", Globals.AGILITY_EXPLAINED, AgilityStatLabel);
            AssignToolTip("Reaction", "Physcial", Globals.REACTION_EXPLAINED, ReactionStatLabel);
            AssignToolTip("Strength", "Physical", Globals.STRENGTH_EXPLAINED, StrengthStatLabel);
            AssignToolTip("Willpower", "Mental", Globals.WILLPOWER_EXPLAINED, WillpowerStatLabel);
            AssignToolTip("Logic", "Mental", Globals.LOGIC_EXPLAINED, LogicStatLabel);
            AssignToolTip("Intuition", "Intuition", Globals.INTUITION_EXPLAINED, IntuitionStatLabel);
        }

        private void AssignToolTip(string stat, string type, string explanation, Label theLabel)
        {
            ToolTip tp = new ToolTip();
            tp.IsBalloon = true;
            tp.InitialDelay = 500;
            tp.ReshowDelay = 1000;
            tp.UseAnimation = true;
            tp.UseFading = true;
            tp.AutoPopDelay = 30000;
            tp.ShowAlways = true;

            tp.ToolTipTitle = stat + " - Stat - " + type;
            tp.SetToolTip(theLabel, Globals.STAT_EXPLAINED + Environment.NewLine + Environment.NewLine + explanation);
        }
    }
}
