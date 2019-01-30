using System;
using System.Windows.Forms;
using ShadowRunRoller.Resources;
using Label = System.Windows.Forms.Label;

namespace ShadowRunRoller.NPCGeneratorTab
{
    public partial class NPCGeneratorWindow : UserControl
    {
        private ToolStripStatusLabel MainStatusLabel;
        private ToolTip tp;
        private Random rnd;
        private Character _CurrentlyShownCharacter;
        public Character CurrentlyShownCharacter { get { return this._CurrentlyShownCharacter; } set { this._CurrentlyShownCharacter = value; WriteCharInNPCWindow(this._CurrentlyShownCharacter); } }

        public NPCGeneratorWindow(Random rand, ToolStripStatusLabel StatusLabel = null)
        {
            InitializeComponent();
            if (StatusLabel != null) { MainStatusLabel = StatusLabel; }

            // Populate comboboxes.
            SetStatusLabelText(Globals.COMBOBOX_GENERATION);
            SetupComboBoxes(Globals.NPC_POWER_NAMES, PowerComboBox);
            PowerComboBox.SelectedIndex = 0;
            SetupComboBoxes(Globals.NPC_RACE_NAMES, RaceComboBox);
            SetupComboBoxes(Globals.NPC_CLASS_NAMES, ClassComboBox);

            SetStatusLabelText(Globals.NEW_EMPTY_CHAR_DONE);
            this.CurrentlyShownCharacter = new Character();

            SetStatusLabelText(Globals.FETCHING_RANDOM);
            this.rnd = rand;
        }

        private void SetupComboBoxes(string[] StringArrayWithTextStrings, ComboBox ComboBoxToAddItemsTo)
        {
            for (int i = 0; i < StringArrayWithTextStrings.Length; i++)
            {
                ComboBoxToAddItemsTo.DisplayMember = "Text";
                ComboBoxToAddItemsTo.ValueMember = "Value";
                ComboBoxToAddItemsTo.Items.Add(new { Text = StringArrayWithTextStrings[i], Value = i });
            }
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
            if (this.CurrentlyShownCharacter != null)
            {
                if (string.IsNullOrEmpty(this.CurrentlyShownCharacter.CharacterAlias))
                {
                    DialogResult dialogResult = MessageBox.Show(Globals.LOSTCHAR_BODY, Globals.LOSTCHAR_HEADLINE, MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                else
                {
                    // Store character in our lovely vault.
                }
            }

            Character chr = new Character
            {
                BodyStat = RandomValue(((dynamic)this.PowerComboBox.SelectedItem).Value, true),
                AgilityStat = RandomValue(((dynamic)this.PowerComboBox.SelectedItem).Value, true),
                ReactionStat = RandomValue(((dynamic)this.PowerComboBox.SelectedItem).Value, true),
                StrengthStat = RandomValue(((dynamic)this.PowerComboBox.SelectedItem).Value, true),
                WillpowerStat = RandomValue(((dynamic)this.PowerComboBox.SelectedItem).Value, true),
                LogicStat = RandomValue(((dynamic)this.PowerComboBox.SelectedItem).Value, true),
                IntuitionStat = RandomValue(((dynamic)this.PowerComboBox.SelectedItem).Value, true),
                CharismaStat = RandomValue(((dynamic)this.PowerComboBox.SelectedItem).Value, true),
                EdgeStat = RandomValue(((dynamic)this.PowerComboBox.SelectedItem).Value, true),
                EdgeCurrentPoints = RandomValue(((dynamic)this.PowerComboBox.SelectedItem).Value, true),
                EssenceStat = RandomValue(((dynamic)this.PowerComboBox.SelectedItem).Value, true),
                MagicResonanceStat = RandomValue(((dynamic)this.PowerComboBox.SelectedItem).Value, true)
            };

            SetStatusLabelText(Globals.NEW_RANDOM_CHAR_DONE);
            this.CurrentlyShownCharacter = chr;
        }

        private int RandomValue(dynamic CharacterStrength, bool IsPrimary)
        {
            int AddedPrimary = IsPrimary ? 1 : 0;
            double HalfCalculation = (double)this.rnd.Next(1, 3 + AddedPrimary) * Globals.NPC_POWER_MULTIPLIER[CharacterStrength] * (double)((double)this.rnd.Next(70000, 83337)/100000);

           return HalfCalculation < 1.0 ? 1 : (int)Math.Round(HalfCalculation);
        }

        public void WriteCharInNPCWindow(Character chr)
        {
            // Do the simple stuff. This are common bindings to register the values in the character object when they are changed in the window.
            CharacterNameTextBox.DataBindings.Clear();
            CharacterNameTextBox.DataBindings.Add("Text", chr, "CharacterName", false, DataSourceUpdateMode.OnPropertyChanged);
            CharacterAliasTextBox.DataBindings.Clear();
            CharacterAliasTextBox.DataBindings.Add("Text", chr, "CharacterAlias", false, DataSourceUpdateMode.OnPropertyChanged);

            // Bind up the stats.
            DoDataBinding(BodyStatTextBox, "BodyStat", chr);
            DoDataBinding(AgilityStatTextBox, "AgilityStat", chr);
            DoDataBinding(ReactionStatTextBox, "ReactionStat", chr);
            DoDataBinding(StrengthStatTextBox, "StrengthStat", chr);
            DoDataBinding(WillpowerStatTextBox, "WillpowerStat", chr);
            DoDataBinding(LogicStatTextBox, "LogicStat", chr);
            DoDataBinding(IntuitionStatTextBox, "IntuitionStat", chr);
            DoDataBinding(CharismaStatTextBox, "CharismaStat", chr);
            DoDataBinding(EdgeStatTextBox, "EdgeStat", chr);
            DoDataBinding(EdgeCurrentPointsTextBox, "EdgeCurrentPoints", chr);
            DoDataBinding(EssenceStatTextBox, "EssenceStat", chr);
            DoDataBinding(MagicResonanceStatTextBox, "MagicResonanceStat", chr);

            // Bind up the autocalculated stuff
            DoDataBinding(ComposureTextBox, "Composure", chr);
            DoDataBinding(LiftCarryTextBox, "LiftCarry", chr);
            DoDataBinding(MoveTextBox, "Move", chr);
            DoDataBinding(JudgeIntentionsTextBox, "JudgeIntentions", chr);
            DoDataBinding(MemoryTextBox, "Memory", chr);

            // Moving on to initiatives.
            DoDataBinding(InitiativeTextBox, "Initiative", chr);
            DoDataBinding(MatrixInitiativeTextBox, "MatrixInitiative", chr);
            DoDataBinding(AstralInitiativeTextBox, "AstralInitiative", chr);

            // Don't forget maximum success limits.
            DoDataBinding(PhysicalLimitTextBox, "PhysicalLimit", chr);
            DoDataBinding(MentalLimitTextBox, "MentalLimit", chr);
            DoDataBinding(SocialLimitTextBox, "SocialLimit", chr);

            // And we top this off with Condition monitors.
            DoDataBinding(ConditionMonitorTextBox, "ConditionMonitor", chr);
            DoDataBinding(StunMonitorTextBox, "StunMonitor", chr);
        }

        public void DoDataBinding(TextBox tb, string valueName, Character chr)
        {
            tb.Text = chr.GetType().GetProperty(valueName).GetValue(chr, null).ToString();
            tb.DataBindings.Clear();
            tb.DataBindings.Add("Text", chr, valueName, false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            switch ((sender as Label).Name)
            {
                case "BodyStatLabel":
                    AssignToolTip(Globals.BODYSTAT_HEADLINE, "", Globals.STAT_EXPLAINED + Environment.NewLine + Environment.NewLine + Globals.BODY_EXPLAINED, BodyStatLabel);
                    break;
                case "AgilityStatLabel":
                    AssignToolTip(Globals.AGILITYSTAT_HEADLINE, "", Globals.STAT_EXPLAINED + Environment.NewLine + Environment.NewLine + Globals.AGILITY_EXPLAINED, AgilityStatLabel);
                    break;
                case "ReactionStatLabel":
                    AssignToolTip(Globals.REACTIONSTAT_HEADLINE, "", Globals.STAT_EXPLAINED + Environment.NewLine + Environment.NewLine + Globals.REACTION_EXPLAINED, ReactionStatLabel);
                    break;
                case "StrengthStatLabel":
                    AssignToolTip(Globals.STRENGTHSTAT_HEADLINE, "", Globals.STAT_EXPLAINED + Environment.NewLine + Environment.NewLine + Globals.STRENGTH_EXPLAINED, StrengthStatLabel);
                    break;
                case "WillpowerStatLabel":
                    AssignToolTip(Globals.WILLPOWERSTAT_HEADLINE, "", Globals.STAT_EXPLAINED + Environment.NewLine + Environment.NewLine + Globals.WILLPOWER_EXPLAINED, WillpowerStatLabel);
                    break;
                case "LogicStatLabel":
                    AssignToolTip(Globals.LOGICSTAT_HEADLINE, "", Globals.STAT_EXPLAINED + Environment.NewLine + Environment.NewLine + Globals.LOGIC_EXPLAINED, LogicStatLabel);
                    break;
                case "IntuitionStatLabel":
                    AssignToolTip(Globals.INTUITIONSTAT_HEADLINE, "", Globals.STAT_EXPLAINED + Environment.NewLine + Environment.NewLine + Globals.INTUITION_EXPLAINED, IntuitionStatLabel);
                    break;
                case "CharismaStatLabel":
                    AssignToolTip(Globals.CHARISMASTAT_HEADLINE, "", Globals.STAT_EXPLAINED + Environment.NewLine + Environment.NewLine + Globals.CHARISMA_EXPLAINED, CharismaStatLabel);
                    break;
                case "EdgeStatLabel":
                    AssignToolTip(Globals.EDGESTAT_HEADLINE, "", Globals.STAT_EXPLAINED + Environment.NewLine + Environment.NewLine + Globals.EDGE_EXPLAINED, EdgeStatLabel);
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
                    AssignToolTip("Initiative - Calculated Value", "", Globals.INITIATIVE_GENERAL_EXPLAINED + Environment.NewLine + Environment.NewLine + Globals.INITIATIVE_EXPLAINED, InitiativeLabel);
                    break;
                case "MatrixInitiativeLabel":
                    AssignToolTip("Matrix Initiative - Calculated Value", "", Globals.INITIATIVE_GENERAL_EXPLAINED + Environment.NewLine + Environment.NewLine + Globals.MATRIX_INITIATIVE_EXPLAINED, MatrixInitiativeLabel);
                    break;
                case "AstralInitiativeLabel":
                    AssignToolTip("Astral Initiative - Calculated Value", "", Globals.INITIATIVE_GENERAL_EXPLAINED + Environment.NewLine + Environment.NewLine + Globals.ASTRAL_INITIATIVE_EXPLAINED, AstralInitiativeLabel);
                    break;
            }
        }
    }
}
