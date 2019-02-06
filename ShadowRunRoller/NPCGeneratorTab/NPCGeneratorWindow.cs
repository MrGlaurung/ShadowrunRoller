using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ShadowRunRoller.Exceptions;
using ShadowRunRoller.Resources;
using ShadowRunRoller.NPCGeneratorTab.CharacterVault;
using ShadowRunRoller.NPCGeneratorTab.Generator;
using Label = System.Windows.Forms.Label;

namespace ShadowRunRoller.NPCGeneratorTab
{
    public partial class NPCGeneratorWindow : UserControl
    {
        private ToolTip tp;
        private Random rnd;
        private ToolStripStatusLabel MainStatusLabel;
        private CharacterStorage ChrVault;
        private GeneratorEngine CharacterEngine;
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

            ChrVault = new CharacterStorage();;

            SetStatusLabelText(Globals.NEW_EMPTY_CHAR_DONE);
            this.CurrentlyShownCharacter = new Character();

            CharacterEngine = new GeneratorEngine(rand, StatusLabel);

            SetStatusLabelText(Globals.FETCHING_RANDOM);
            this.rnd = rand;

            // This is a debug part to check how the results will be depending on which min or max you have
            // in stats for the different character strengths. It's the function I used to create the excel
            // page included in the project.
            // Set a breakpoint at the end of the foreach loop and examine the variable "myresults" to view
            // the distribution of results.
            //Dictionary<string, Dictionary<int, int>> myresults = new Dictionary<string, Dictionary<int, int>>();
            //int[] str = {0, 1, 2, 3, 4, 5, 6};
            //foreach (int n in str)
            //{
            //    Dictionary<int, int> mydict = new Dictionary<int, int>();
            //    for (int i = 0; i < 1000000; i++)
            //    {
            //        int newrnd = RandomValue(n, false);
            //        if(mydict.ContainsKey(newrnd)) { mydict[newrnd] += 1; }
            //        else { mydict.Add(newrnd, 1); }
            //    }

            //    myresults.Add(Globals.NPC_POWER_NAMES[n], mydict.OrderBy(f => f.Key).ToDictionary(x => x.Key, x => x.Value));
            //}
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

        public void WriteCharInNPCWindow(Character chr)
        {
            FixVault(chr);

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

        public void FixVault(Character chr)
        {
            CharactersInVaultComboBox.Items.Clear();

            Dictionary<Guid, string> AllChars = ChrVault.GetAllCharsId();
            foreach (Guid gu in AllChars.Keys)
            {
                CharactersInVaultComboBox.DisplayMember = "Text";
                CharactersInVaultComboBox.ValueMember = "Value";
                CharactersInVaultComboBox.Items.Add(new { Text = AllChars[gu], Value = gu });
            }
        }

        public void DoDataBinding(TextBox tb, string valueName, Character chr)
        {
            tb.Text = chr.GetType().GetProperty(valueName).GetValue(chr, null).ToString();
            tb.DataBindings.Clear();
            tb.DataBindings.Add("Text", chr, valueName, false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            this.CurrentlyShownCharacter = this.CharacterEngine.GenerateNewChar(this.ChrVault, this.CurrentlyShownCharacter, (int)((dynamic)this.PowerComboBox.SelectedItem).Value);

            WriteCharInNPCWindow(this.CurrentlyShownCharacter);
        }

        private void TrashButton_Click(object sender, EventArgs e)
        {
            CurrentlyShownCharacter = CharacterEngine.TrashCharacter(ChrVault, CurrentlyShownCharacter);

            WriteCharInNPCWindow(this.CurrentlyShownCharacter);
        }

        private void StoreButton_Click(object sender, EventArgs e)
        {
            CharacterEngine.StoreCharacter(ChrVault, CurrentlyShownCharacter);

            WriteCharInNPCWindow(this.CurrentlyShownCharacter);
        }

        private void CharactersInVaultComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Character fetched = ChrVault.FetchCharacter((Guid)((dynamic)this.CharactersInVaultComboBox.SelectedItem).Value);
            if (CurrentlyShownCharacter.WorthSaving())
            {
                if (fetched != null && CurrentlyShownCharacter.CheckSum() !=
                    ChrVault.FetchCharacter(CurrentlyShownCharacter.Id).CheckSum())
                {
                    CharacterEngine.StoreCharacter(ChrVault, CurrentlyShownCharacter);
                }
            }

            CurrentlyShownCharacter = fetched;
            WriteCharInNPCWindow(fetched);
        }
    }
}
