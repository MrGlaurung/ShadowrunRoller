using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadowRunRoller.Resources
{
    static class Globals
    {
        public const string APPLICATION_NAME = "Shadowrun GM Tool";
        public static readonly string APPLICATION_VERSION = Application.ProductVersion;
        public const string APPLICATION_HELP = "This is a Shadowrun GM tool to help you with your tasks as a GM. Nothing in this product is 100% rule correct, apart from dice rolling.";

        public const string APPLICATION_LOADED = "Program loaded and started.";

        public const string STAT = "Stat";
        public const string STAT_EXPLAINED =
            "Attributes are the inherent characteristics of your shadowrunner,\n" +
            "the basic abilities they bring to the table. Shadowrunners have a\n" +
            "numerical rating for each attribute, which is used to help\n" +
            "determine the amount of dice rolled for tests in the game.\n" +
            "Attributes fall into three different groups: Physical, Mental,\n" +
            "and Special. Every character has a rating in each of the Physical\n" +
            "and Mental attributes, though they may not have ratings in the\n" +
            "Special attributes. For humans, all attributes are between 1 and 6,\n" +
            "though certain modifications and qualities can change this. Metatypes\n" +
            "have different ranges in these attributes.";
        public const string BODY_EXPLAINED =
            "BODY (BOD) [B]\n" +
            "Body measures your physical health and resiliency. It affects how\n" +
            "much damage you can take and stay on your feet, how well you resist\n" +
            "damage coming your way, your ability to recover from poisons and\n"+
            "diseases, and things of that nature.";
        public const string AGILITY_EXPLAINED = 
            "AGILITY (AGI) [A]\n" +
            "Agility measures things like hand-eye coordination, flexibility,\n" +
            "nimbleness, and balance.Agility is the most important attribute\n" +
            "when it comes to scoring hits during combat, as you need to be\n" +
            "coordinated to land your blows, whether you’re swinging a sword\n" +
            "or carefully aiming a rifle.It also is critical in non-combat\n" +
            "situations, such as sneaking quietly past security guards or\n" + 
            "smoothly lifting a keycard from its secured position.";
        public const string REACTION_EXPLAINED =
            "REACTION (REA) [R]\n" +
            "Reaction is about reflexes, awareness, and your character’s\n" +
            "ability to respond to events happening around them.Reaction\n" +
            "plays an important role in deciding how soon characters act in\n" +
            "combat and how skilled they are in avoiding attacks from others.\n" +
            "It also helps you make that quick turn down a narrow alley on your\n" +
            "cycle to avoid the howling gangers on your tail.";
        public const string STRENGTH_EXPLAINED =
            "STRENGTH (STR) [S]\n" +
            "Strength is an indicator of, well, how strong your character is. The\n" +
            "higher your strength, the more damage you’ll do when you’re raining blows\n" +
            "down on an opponent, and the more you’ll be able to move or carry when\n" +
            "there’s stuff that needs to be moved. Or carried. Strength is also\n" +
            "important with athletic tasks such as climbing, running, and swimming.";
        public const string WILLPOWER_EXPLAINED =
            "WILLPOWER (WIL) [W]\n" +
            "Willpower is your character’s desire to push through\n" +
            "adversity, to resist the weariness of spellcasting, and to\n" +
            "stay upright after being nailed in the head with a sap.\n" +
            "Whether you’re testing yourself against a toxic wilderness\n" +
            "or a pack of leather-clad orks with crowbars, Willpower\n" +
            "will help you make it through.";
        public const string LOGIC_EXPLAINED =
            "LOGIC (LOG) [L]\n" +
            "The Logic attribute measures the cold, calculating\n" +
            "power of your rational mind.Whether you are attempting\n" +
            "to repair complicated machinery or patch up an injured\n" +
            "teammate, Logic helps you get things right.Logic\n" +
            "is also the attribute hermetic mages use to resist Drain\n" +
            "from the spells they rain down on their hapless foes.\n" +
            "Deckers also find Logic extremely useful, as it helps\n" +
            "them develop the attacks and counterattacks that are\n" +
            "part of their online battles.";
        public const string INTUITION_EXPLAINED =
            "INTUITION (INT) [I]\n" +
            "Intuition is the voice of your gut, the instinct that\n" +
            "tells you things before your logical brain can figure them\n" +
            "out. Intuition helps you anticipate ambushes, notice that\n" +
            "something is amiss or out of place, and stay on the trail\n" +
            "of someone you’re pursuing.";
        public const string CHARISMA_EXPLAINED =
            "CHARISMA (CHA) [C]\n" +
            "Charisma is your force of personality, the persuasiveness\n" +
            "and charm you can call on to get people to do what\n" +
            "you want without having to go to the trouble of pulling a\n" +
            "gun on them.It’s not entirely about your appearance, but\n" +
            "it’s also not entirely not about your appearance. What it’s\n" +
            "mostly about is how you use what you have—your voice,\n" +
            "your face, your words, and all the tools at your disposal—to\n" +
            "charm and/or intimidate the people you encounter. Additionally,\n" +
            "Charisma is an important attribute for shamanic\n" +
            "mages, as it helps them resist the damaging Drain from\n" +
            "spells they cast.";
    }
}