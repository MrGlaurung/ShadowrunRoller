using System;
using System.Collections.Generic;
using ShadowRunRoller.Resources;

namespace ShadowRunRoller.NPCGeneratorTab
{
    public class Character
    {
        public string CharacterName { get; set; }
        public string CharacterAlias { get; set; }
        public int BodyStat { get; set; }
        public int GetFullBodyStat() { return this.BodyStat + GetCyberwareBonus("Body"); }
        public int AgilityStat { get; set; }
        public int GetFullAgilityStat() { return this.BodyStat + GetCyberwareBonus("Agility"); }
        public int ReactionStat { get; set; }
        public int GetFullReactionStat() { return this.ReactionStat + GetCyberwareBonus("Reaction"); }
        public int StrengthStat { get; set; }
        public int GetFullStrengthStat() { return this.StrengthStat + GetCyberwareBonus("Strength"); }
        public int WillpowerStat { get; set; }
        public int GetFullWillpowerStat() { return this.WillpowerStat + GetCyberwareBonus("Willpower"); }
        public int LogicStat { get; set; }
        public int GetFullLogicStat() { return this.LogicStat + GetCyberwareBonus("Logic"); }
        public int IntuitionStat { get; set; }
        public int GetFullIntuitionStat() { return this.IntuitionStat + GetCyberwareBonus("Intuition"); }
        public int CharismaStat { get; set; }
        public int GetFullCharismaStat() { return this.CharismaStat + GetCyberwareBonus("Charisma"); }
        public int EdgeStat { get; set; }
        public int EdgeCurrentPoints { get; set; }
        public int EssenceStat { get; set; }
        public int GetFullEssenceStat() { return this.EssenceStat + GetCyberwareBonus("Essence"); }
        public int MagicResonanceStat { get; set; }
        public int GetFullMagicResonanceStat() { return this.MagicResonanceStat + GetCyberwareBonus("MagicResonance"); }
        public List<Skill> Skills { get; set; }
        public List<Contact> Contacts { get; set; }
        public List<Quality> Qualities { get; set; }
        public List<Equipment> Equipments { get; set; }
        public List<Cybertech> Cybertechs { get; set; }
        public List<Spells> Spells { get; set; }
        public int Initiative { get { return this.ReactionStat + this.IntuitionStat; } set { return; } }
        public int MatrixInitiative { get { return this.ReactionStat + this.IntuitionStat; } set { return; } }
        public int AstralInitiative { get { return this.IntuitionStat * 2; } set { return; } }
        public int Composure { get { return this.WillpowerStat + this.CharismaStat; } set { return; } }
        public int JudgeIntentions { get { return this.CharismaStat + this.IntuitionStat; } set { return; } }
        public int Memory { get { return this.LogicStat + this.WillpowerStat; } set { return; } }
        public int PhysicalLimit { get { return (int)Math.Ceiling((double)((this.StrengthStat * 2) + this.BodyStat + this.ReactionStat) / 3); } set { return; } }
        public int MentalLimit { get { return (int)Math.Ceiling((double)((this.LogicStat * 2) + this.IntuitionStat + this.WillpowerStat) / 3); } set { return; } }
        public int SocialLimit { get { return (int)Math.Ceiling((double)((this.CharismaStat * 2) + this.WillpowerStat + this.EssenceStat) / 3); } set { return; } }
        public int ConditionMonitor { get { return (int)Math.Ceiling((double)this.GetFullBodyStat()/2) + 2; } set { return; } }
        public int StunMonitor { get { return (int)Math.Ceiling((double)this.GetFullWillpowerStat() / 2) + 2; ; } set { return; } }
        public string LiftCarry { get { return (this.StrengthStat * 15).ToString() + "/" + (this.StrengthStat * 10).ToString(); } set { return; } }
        public string Move { get { string sprint = "2m per hit"; if (0 == Globals.RACE.Dwarf || 0 == Globals.RACE.Troll) { sprint = "1m per hit"; } return (this.AgilityStat * 2).ToString() + "/" + (this.AgilityStat * 4).ToString() + "/" + sprint; } set { return; } }

        public int GetCyberwareBonus(string stat)
        {
            return 0;
        }
    }
}
