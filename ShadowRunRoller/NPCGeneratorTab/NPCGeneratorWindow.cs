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
using ShadowRunRoller.NPCGeneratorTab.Generator;
using ShadowRunRoller.Resources;

namespace ShadowRunRoller.NPCGeneratorTab
{
    public partial class NPCGeneratorWindow : UserControl
    {
        private ToolStripStatusLabel MainStatusLabel;
        public TextBox GetStrengthStatTextBox() { return StrengthStatTextBox; }

        public NPCGeneratorWindow(ToolStripStatusLabel StatusLabel = null)
        {
            InitializeComponent();
            SetupToolTips();
            if (StatusLabel != null) { MainStatusLabel = StatusLabel; }
        }

        private void SetStatusLabelText(string text)
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
            ToolTip tp = new ToolTip
            {
                IsBalloon = true,
                InitialDelay = 500,
                ReshowDelay = 1000,
                UseAnimation = true,
                UseFading = true,
                AutoPopDelay = 30000,
                ShowAlways = true,
                ToolTipIcon = ToolTipIcon.Info,
                ToolTipTitle = stat + " - " + Globals.STAT + " - " + type
            };

            tp.SetToolTip(theLabel, Globals.STAT_EXPLAINED + Environment.NewLine + Environment.NewLine + explanation);
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Character chr = new Character();
            chr.BodyStat = 4;
            chr.AgilityStat = 2;
            chr.ReactionStat = 2;
            chr.StrengthStat = 7;
            chr.WillpowerStat = 3;
            chr.LogicStat = 4;
            chr.IntuitionStat = 3;
            chr.CharismaStat = 14;
            chr.EdgeStat = 3;
            chr.EdgeCurrentPoints = 3;
            chr.EssenceStat = 5;
            chr.MagicResonanceStat = 7;

            FillWindow.WriteOutChar(chr,this);
        }
    }
}
