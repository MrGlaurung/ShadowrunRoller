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
using Label = System.Windows.Forms.Label;

namespace ShadowRunRoller.NPCGeneratorTab
{
    public partial class NPCGeneratorWindow : UserControl
    {
        private ToolStripStatusLabel MainStatusLabel;
        private ToolTip tp;

        public NPCGeneratorWindow(ToolStripStatusLabel StatusLabel = null)
        {
            InitializeComponent();
            if (StatusLabel != null) { MainStatusLabel = StatusLabel; }
        }

        private void SetStatusLabelText(string text)
        {
            if (MainStatusLabel != null)
            {
                MainStatusLabel.Text = text;
            }
        }

        private void AssignToolTip(string headline, string addition, string explanation, Label theLabel)
        {
            if (tp != null)
            {
                tp.Active = false;
                tp = null;
            }
            if (!string.IsNullOrEmpty(addition)) { headline += " (" + addition + ")"; }
            tp = new ToolTip
            {
                IsBalloon = true,
                InitialDelay = 1,
                ReshowDelay = 1000,
                UseAnimation = true,
                UseFading = true,
                AutoPopDelay = 30000,
                ShowAlways = true,
                ToolTipIcon = ToolTipIcon.Info,
                ToolTipTitle = headline
            };

            tp.SetToolTip(theLabel, explanation);
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Character chr = new Character
            {
                BodyStat = 42,
                AgilityStat = 42,
                ReactionStat = 42,
                StrengthStat = 42,
                WillpowerStat = 42,
                LogicStat = 42,
                IntuitionStat = 42,
                CharismaStat = 42,
                EdgeStat = 42,
                EdgeCurrentPoints = 17,
                EssenceStat = 42,
                MagicResonanceStat = 42
            };

            WriteCharInNPCWindow(chr);
        }

        public void WriteCharInNPCWindow(Character chr)
        {
            // Fill all the statboxes.
            BodyStatTextBox.Text = chr.BodyStat.ToString();
            AgilityStatTextBox.Text = chr.AgilityStat.ToString();
            ReactionStatTextBox.Text = chr.ReactionStat.ToString();
            StrengthStatTextBox.Text = chr.StrengthStat.ToString();
            WillpowerStatTextBox.Text = chr.WillpowerStat.ToString();
            LogicStatTextBox.Text = chr.LogicStat.ToString();
            IntuitionStatTextBox.Text = chr.IntuitionStat.ToString();
            CharismaStatTextBox.Text = chr.CharismaStat.ToString();

            // Fill up all the special stats.
            EdgeStatTextBox.Text = chr.EdgeStat.ToString();
            CurrentEdgePointsTextBox.Text = chr.EdgeCurrentPoints.ToString();
            EssenceStatTextBox.Text = chr.EssenceStat.ToString();
            MagicStatTextBox.Text = chr.MagicResonanceStat.ToString();

            // Fill all the auto-counted boxes.
            ComposureTextBox.Text = chr.GetComposure().ToString();
            JudgeIntentionsTextBox.Text = chr.GetJudgeIntentions().ToString();
            LiftCarryTextBox.Text = chr.GetLiftCarry();
            MemoryTextBox.Text = chr.GetMemory().ToString();
            MoveTextBox.Text = chr.GetMovement();

            // Initiative... Here we go.
            InitiativeTextBox.Text = chr.GetInitiative().ToString();
            MatrixInitiativeTextBox.Text = chr.GetMatrixInitiative().ToString();
            AstralInitiativeTextBox.Text = chr.GetAstralInitiative().ToString();
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            switch ((sender as Label).Name)
            {
                case "BodyStatLabel":
                    AssignToolTip("Body - STAT - Physical", "", Globals.STAT_EXPLAINED + Environment.NewLine + Environment.NewLine + Globals.BODY_EXPLAINED, BodyStatLabel);
                    break;
                case "AgilityStatLabel":
                    AssignToolTip("Agility - STAT - Physical", "", Globals.STAT_EXPLAINED + Environment.NewLine + Environment.NewLine + Globals.AGILITY_EXPLAINED, AgilityStatLabel);
                    break;
                case "ReactionStatLabel":
                    AssignToolTip("Reaction - STAT - Physical", "", Globals.STAT_EXPLAINED + Environment.NewLine + Environment.NewLine + Globals.REACTION_EXPLAINED, ReactionStatLabel);
                    break;
                case "StrengthStatLabel":
                    AssignToolTip("Strength - STAT - Physical", "", Globals.STAT_EXPLAINED + Environment.NewLine + Environment.NewLine + Globals.STRENGTH_EXPLAINED, StrengthStatLabel);
                    break;
                case "WillpowerStatLabel":
                    AssignToolTip("Willpower - STAT - Mental", "", Globals.STAT_EXPLAINED + Environment.NewLine + Environment.NewLine + Globals.WILLPOWER_EXPLAINED, WillpowerStatLabel);
                    break;
                case "LogicStatLabel":
                    AssignToolTip("Logic - STAT - Mental", "", Globals.STAT_EXPLAINED + Environment.NewLine + Environment.NewLine + Globals.LOGIC_EXPLAINED, LogicStatLabel);
                    break;
                case "IntuitionStatLabel":
                    AssignToolTip("Intuition - STAT - Mental", "", Globals.STAT_EXPLAINED + Environment.NewLine + Environment.NewLine + Globals.INTUITION_EXPLAINED, IntuitionStatLabel);
                    break;
                case "CharismaStatLabel":
                    AssignToolTip("Charisma - STAT - Mental", "", Globals.STAT_EXPLAINED + Environment.NewLine + Environment.NewLine + Globals.CHARISMA_EXPLAINED, CharismaStatLabel);
                    break;
                case "EdgeStatLabel":
                    AssignToolTip("Edge - STAT - Special", "", Globals.STAT_EXPLAINED + Environment.NewLine + Environment.NewLine + Globals.EDGE_EXPLAINED, EdgeStatLabel);
                    break;
                case "EdgeCurrentLabel":
                    AssignToolTip("Edge Current Points", "", Globals.CURRENT_EDGE_EXPLAINED, EdgeCurrentLabel);
                    break;
                case "EssenceStatLabel":
                    AssignToolTip("Essence - STAT - Special", "", Globals.STAT_EXPLAINED + Environment.NewLine + Environment.NewLine + Globals.ESSENCE_EXPLAINED, EssenceStatLabel);
                    break;
                case "MagicResonanceStatLabel":
                    AssignToolTip("Magic/Resonance - STAT - Special", "", Globals.STAT_EXPLAINED + Environment.NewLine + Environment.NewLine + Globals.MAGIC_RESONANCE_EXPLAINED, MagicResonanceStatLabel);
                    break;
                case "ComposureLabel":
                    AssignToolTip("Composure - Calculated Value", "", Globals.COMPOSURE_EXPLAINED, ComposureLabel);
                    break;
                case "JudgeIntentionsLabel":
                    AssignToolTip("Judge Intentions - Calculated Value", "", Globals.JUDGE_INTENTIONS_EXPLAINED, JudgeIntentionsLabel);
                    break;
                case "MemoryLabel":
                    AssignToolTip("Memory - Calculated Value", "", Globals.MEMORY_EXPLAINED, MemoryLabel);
                    break;
                case "LiftCarryLabel":
                    AssignToolTip("Lift / Carry - Calculated Value", "", Globals.LIFT_CARRY_EXPLAINED, LiftCarryLabel);
                    break;
                case "MoveLabel":
                    AssignToolTip("Movement - Calculated Value", "", Globals.MOVE_EXPLAINED, MoveLabel);
                    break;
                case "InitiativeLabel":
                    AssignToolTip("Initiative", "", Globals.INITIATIVE_EXPLAINED, InitiativeLabel);
                    break;
                case "MatrixInitiativeLabel":
                    AssignToolTip("Matrix Initiative", "", Globals.MATRIX_INITIATIVE_EXPLAINED, MatrixInitiativeLabel);
                    break;
                case "AstralInitiativeLabel":
                    AssignToolTip("Astral Initiative", "", Globals.ASTRAL_INITIATIVE_EXPLAINED, AstralInitiativeLabel);
                    break;
            }
        }
    }
}
