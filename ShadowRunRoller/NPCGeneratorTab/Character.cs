using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShadowRunRoller.Resources;

namespace ShadowRunRoller.NPCGeneratorTab
{
    public class Character
    {
        public int BodyStat { get; set; }
        public int AgilityStat { get; set; }
        public int ReactionStat { get; set; }
        public int StrengthStat { get; set; }
        public int WillpowerStat { get; set; }
        public int LogicStat { get; set; }
        public int IntuitionStat { get; set; }
        public int CharismaStat { get; set; }
        public int EdgeStat { get; set; }
        public int EdgeCurrentPoints { get; set; }
        public int EssenceStat { get; set; }
        public int MagicResonanceStat { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Contact> Contacts { get; set; }
        public List<Quality> Qualities { get; set; }
        public List<Equipment> Equipments { get; set; }
        public List<Cybertech> Cybertechs { get; set; }
        public List<Spells> Spells { get; set; }
        public int GetInitiative() { return this.ReactionStat + this.IntuitionStat; }
        public int GetMatrixInitiative() { return this.ReactionStat + this.IntuitionStat; }
        public int GetAstralInitiative() { return this.IntuitionStat * 2; }
        public int GetComposure() { return this.WillpowerStat + this.CharismaStat; }
        public int GetJudgeIntentions() { return this.CharismaStat + this.IntuitionStat; }
        public int GetMemory() { return this.LogicStat + this.WillpowerStat; }
        public int GetPhysicalLimit() { return (int)Math.Ceiling((double)((this.StrengthStat * 2) + this.BodyStat + this.ReactionStat) / 3); }
        public int GetMentalLimit() { return (int)Math.Ceiling((double)((this.LogicStat * 2) + this.IntuitionStat + this.WillpowerStat) / 3); }
        public int GetSocialLimit() { return (int)Math.Ceiling((double)((this.CharismaStat * 2) + this.WillpowerStat + this.EssenceStat) / 3); }

        public string GetLiftCarry()
        {
            return (this.StrengthStat*15).ToString() + "/" + (this.StrengthStat*10).ToString();
        }

        public string GetMovement()
        {
            string sprint = "2m per hit";
            if(0 == Globals.RACE.Dwarf || 0 == Globals.RACE.Troll) { sprint = "1m per hit"; }
            return (this.AgilityStat * 2).ToString() + "/" + (this.AgilityStat * 4).ToString() + "/" + sprint;
        }
    }
}
