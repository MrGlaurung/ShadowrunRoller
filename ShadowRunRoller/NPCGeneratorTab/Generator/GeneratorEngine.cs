using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShadowRunRoller.Exceptions;
using ShadowRunRoller.NPCGeneratorTab.CharacterVault;
using ShadowRunRoller.Resources;

namespace ShadowRunRoller.NPCGeneratorTab.Generator
{
    class GeneratorEngine
    {
        private Random MyRandom { get; set; }
        private ToolStripStatusLabel MainStatusLabel;

        public GeneratorEngine(Random rnd, ToolStripStatusLabel StatusLabel = null)
        {
            this.MyRandom = rnd;
            if (StatusLabel != null) { MainStatusLabel = StatusLabel; }
        }

        private void SetStatusLabelText(string text)
        {
            if (MainStatusLabel != null)
            {
                MainStatusLabel.Text = text;
            }
        }

        public Character GenerateNewChar(CharacterStorage Vault, Character CurrentChr, int ChrPower)
        {
            if(!SaveCharacter(Vault, CurrentChr)) { return CurrentChr; }

            Character chr = new Character
            {
                BodyStat = RandomValue(ChrPower, true),
                AgilityStat = RandomValue(ChrPower, true),
                ReactionStat = RandomValue(ChrPower, true),
                StrengthStat = RandomValue(ChrPower, true),
                WillpowerStat = RandomValue(ChrPower, true),
                LogicStat = RandomValue(ChrPower, true),
                IntuitionStat = RandomValue(ChrPower, true),
                CharismaStat = RandomValue(ChrPower, true),
                EdgeStat = RandomValue(ChrPower, true),
                EdgeCurrentPoints = RandomValue(ChrPower, true),
                EssenceStat = RandomValue(ChrPower, true),
                MagicResonanceStat = RandomValue(ChrPower, true)
            };

            SetStatusLabelText(Globals.NEW_RANDOM_CHAR_DONE);

            return chr;
        }

        private bool SaveCharacter(CharacterStorage Vault, Character CurrentChr, bool TrashMe = false)
        {
            if (CurrentChr != null && CurrentChr.WorthSaving())
            {
                if (string.IsNullOrEmpty(CurrentChr.CharacterAlias) && !TrashMe)
                {
                    DialogResult dialogResult = MessageBox.Show(Globals.LOSTCHAR_BODY, Globals.CHAR_DIALOG_HEADLINE, MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.Cancel)
                    {
                        return false;
                    }
                }
                else if (TrashMe)
                {
                    DialogResult dialogResult = MessageBox.Show(Globals.TRASHCHAR_BODY, Globals.CHAR_DIALOG_HEADLINE, MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.Cancel)
                    {
                        return false;
                    }
                }
                else
                {
                    Character StoreChar = CurrentChr;
                    StoreCharacter(Vault, StoreChar);
                }
            }

            return true;
        }

        private int RandomValue(dynamic CharacterStrength, bool IsPrimary)
        {
            int total = 0;
            int addition = IsPrimary ? (int)Math.Round((double)Globals.NPC_POWER_MULTIPLIER[(int)CharacterStrength, 0] * .10, MidpointRounding.AwayFromZero) : 0;

            for (int i = 0; i < 5; i++)
            {
                total += this.MyRandom.Next(Globals.NPC_POWER_MULTIPLIER[(int)CharacterStrength, 0] + addition, (Globals.NPC_POWER_MULTIPLIER[(int)CharacterStrength, 1] + 1 + addition));
            }

            return (int)Math.Round((double)total / 5, 0);
        }

        public Character TrashCharacter(CharacterStorage Vault, Character TrashableCharacter)
        {
            if (!SaveCharacter(Vault, TrashableCharacter)) { return TrashableCharacter; }

            Vault.RemoveChar(TrashableCharacter.Id);
            return new Character();
        }

        public void StoreCharacter(CharacterStorage Vault, Character StoreThisChr)
        {
            try
            {
                Vault.AddChar(StoreThisChr);
            }
            catch (IllegalCharacterException ex)
            {
                MessageBox.Show(Globals.ILLEGAL_CHARACTER_BODY + "\n\n" + ex, Globals.ILLEGAL_CHARACTER_HEADLINE);
            }
        }
    }
}
