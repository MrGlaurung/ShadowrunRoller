using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace ShadowRunRoller.Resources
{
    static class Globals
    {
        // This file contains both important variables and translations.
        // On top here are the variables. The rest is only text I use in the application
        // that can easily be translated to another language (NOT FRENCH!) Q 190130
        public static readonly string APPLICATION_VERSION = Application.ProductVersion;
        public enum RACE
        {
            Human = 0, Elf, Dwarf, Orc, Troll
        }
        public static readonly string[] NPC_RACE_NAMES = {"Human", "Elf", "Dwarf", "Orc", "Troll"};
        public enum CLASS
        {
            StreetSamurai = 0
        }
        public static readonly string[] NPC_CLASS_NAMES = { "Street Samurai" };
        public enum NPCPOWER
        {
            Soddy = 0, BelowAverage, Average, AboveAverage, Strong, Powerful, Mastermind
        }
        public static readonly string[] NPC_POWER_NAMES = { "Soddy", "Below Average", "Average", "Above Average", "Strong", "Powerful", "Mastermind" };
        public static readonly int[,] NPC_POWER_MULTIPLIER = { {1, 2}, {1, 3}, {2, 6}, {4, 9}, {7, 12}, {10, 15}, {13, 18} };

        public const string APPLICATION_NAME = "Shadowrun GM Tool";
        public const string APPLICATION_HELP =
            "This is a Shadowrun GM tool to help you with your tasks as a GM.\n" +
            "The NPC rolling will never give you a perfectly legal char according\n" +
            "to the rules. There might be a bit too high in one stat or a bit too\n" +
            "many points spent here or there.\n" +
            "\n" +
            "But it'll get you an NPC fast, smooth and simple and you can modify any\n" +
            "stat you don't like in a blink of an eye.\n" +
            "\n" +
            "This program is published under GPL by Anders Liden from Gothenburg.\n" +
            "I hope you enjoy it.\n";
        public const string NEW_EMPTY_CHAR_DONE = "Empty NPC created for your enjoyment.";
        public const string NEW_RANDOM_CHAR_DONE = "New random character created.";
        public const string COMBOBOX_GENERATION = "Generating info in comboboxes.";
        public const string FETCHING_RANDOM = "Fetching random from main window.";
        public const string APPLICATION_LOADED = "Program loaded and started.";
        public const string LOSTCHAR_HEADLINE = "Current character will be lost!";
        public const string LOSTCHAR_BODY = "Your current visible character will be lost if you press OK.\n\n" +
                                            "The only thing you need to do to keep your current character\n" +
                                            "as one of the characters in memory is to type in an alias.\n\n" +
                                            "You can press cancel now and enter an alias before you create\n" +
                                            "a new character, or you can press OK and loose your current char.";
        public const string STAT = "Stat";
        public const string STAT_EXPLAINED =
            "Attributes are the inherent characteristics of your\n" +
            "shadowrunner, the basic abilities they bring to the table.\n" +
            "Shadowrunners have a numerical rating for each\n" +
            "attribute, which is used to help determine the amount\n" +
            "of dice rolled for tests in the game. Attributes fall into\n" +
            "three different groups: Physical, Mental, and Special.\n" +
            "Every character has a rating in each of the Physical and\n" +
            "Mental attributes, though they may not have ratings in\n" +
            "the Special attributes.\n" +
            "For humans, all attributes are between 1 and 6,\n" +
            "though certain modifications and qualities can change\n" +
            "this. Metatypes have different ranges in these attributes.";
        public const string BODYSTAT_HEADLINE = "Body - STAT - Physical";
        public const string BODY_EXPLAINED =
            "BODY (BOD) [B]\n" +
            "Body measures your physical health and resiliency.\n" +
            "It affects how much damage you can take and stay on\n" +
            "your feet, how well you resist damage coming your way,\n" +
            "your ability to recover from poisons and diseases, and\n" +
            "things of that nature.";
        public const string AGILITYSTAT_HEADLINE = "Agility - STAT - Physical";
        public const string AGILITY_EXPLAINED = 
            "AGILITY (AGI) [A]\n" +
            "Agility measures things like hand-eye coordination,\n" +
            "flexibility, nimbleness, and balance. Agility is the most\n" + 
            "important attribute when it comes to scoring hits during\n" +
            "combat, as you need to be coordinated to land your\n" +
            "blows, whether you’re swinging a sword or carefully aiming\n" +
            "a rifle. It also is critical in non-combat situations, such\n" +
            "as sneaking quietly past security guards or smoothly lifting\n" +
            "a keycard from its secured position.";
        public const string REACTIONSTAT_HEADLINE = "Agility - STAT - Physical";
        public const string REACTION_EXPLAINED =
            "REACTION (REA) [R]\n" +
            "Reaction is about reflexes, awareness, and your\n" +
            "character’s ability to respond to events happening\n" +
            "around them. Reaction plays an important role in deciding\n" +
            "how soon characters act in combat and how\n" +
            "skilled they are in avoiding attacks from others. It\n" +
            "also helps you make that quick turn down a narrow\n" +
            "alley on your cycle to avoid the howling gangers on\n" +
            "your tail.";
        public const string STRENGTHSTAT_HEADLINE = "Strength - STAT - Physical";
        public const string STRENGTH_EXPLAINED =
            "STRENGTH (STR) [S]\n" +
            "Strength is an indicator of, well, how strong your\n" +
            "character is. The higher your strength, the more damage\n" +
            "you’ll do when you’re raining blows down on an opponent,\n" +
            "and the more you’ll be able to move or carry\n" +
            "when there’s stuff that needs to be moved. Or carried.\n" +
            "Strength is also important with athletic tasks such as" +
            "\nclimbing, running, and swimming.";
        public const string WILLPOWERSTAT_HEADLINE = "Willpower - STAT - Mental";
        public const string WILLPOWER_EXPLAINED =
            "WILLPOWER (WIL) [W]\n" +
            "Willpower is your character’s desire to push through\n" +
            "adversity, to resist the weariness of spellcasting, and to\n" +
            "stay upright after being nailed in the head with a sap.\n" +
            "Whether you’re testing yourself against a toxic wilderness\n" +
            "or a pack of leather-clad orks with crowbars, Willpower\n" +
            "will help you make it through.";
        public const string LOGICSTAT_HEADLINE = "Logic - STAT - Mental";
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
        public const string INTUITIONSTAT_HEADLINE = "Intuition - STAT - Mental";
        public const string INTUITION_EXPLAINED =
            "INTUITION (INT) [I]\n" +
            "Intuition is the voice of your gut, the instinct that\n" +
            "tells you things before your logical brain can figure them\n" +
            "out. Intuition helps you anticipate ambushes, notice that\n" +
            "something is amiss or out of place, and stay on the trail\n" +
            "of someone you’re pursuing.";
        public const string CHARISMASTAT_HEADLINE = "Charisma - STAT - Mental";
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
        public const string EDGESTAT_HEADLINE = "Edge - STAT - Special";
        public const string EDGE_EXPLAINED =
            "Edge [E]\n" +
            "Edge is the ultimate intangible, that certain something\n" +
            "that provides a boost when you need it, that gets\n" +
            "you out of a tough spot when the chips are down. It’s not\n" +
            "used to calculate dice pools; instead, you spend a point\n" +
            "of Edge to acquire a certain effect. Every character has at\n" +
            "least one point of Edge, more if they want to take more\n" +
            "frequent advantage of the boosts it offers.";
        public const string CURRENT_EDGE_EXPLAINED =
            "Current [E]dge points\n" +
            "These are your current edge points that you can\n." +
            "freely use. If you use an edge this value will decline\n" +
            "if your burn an edge both this value and your stat will\n" +
            "decline.";
        public const string ESSENCE_EXPLAINED =
            "ESSENCE [ESS]\n" +
            "Essence is your metahumanity encapsulated in a\n" +
            "number. In Shadowrun, you have ample opportunities to\n" +
            "alter your body or push it beyond its normal limits. Such\n" +
            "actions often have a cost, and they can result in a loss of a\n" +
            "portion of your metahumanity, which means a loss of Essence\n" +
            "points. Each character starts with an Essence rating\n" +
            "of 6, and it acts as a cap on the amount of alterations you\n" +
            "can adopt. When it’s gone, it doesn’t come back. It also\n" +
            "affects the Magic and Resonance attributes, as losses in\n" +
            "Essence are reflected by losses in Magic and Resonance.\n\n" +
            "While denizens of the Sixth World are accustomed to\n" +
            "seeing a variety of augmentations and alterations to the\n" +
            "metahuman form, the “uncanny valley” still exists. The\n" +
            "uncanny valley is the disconcerting effect that happens\n" +
            "when people see something that is almost, but not quite,\n" +
            "metahuman. An animated cartoon with exaggerated\n" +
            "features looks fine to metahuman eyes, but a computer\n" +
            "program that closely, but not exactly, replicates human\n" +
            "appearance is a troubling and unpleasant sight to most\n" +
            "viewers. This is what happens when people see others\n" +
            "with augmentations—on some level, people notice there\n" +
            "is something less (or more) human about that, and they\n" +
            "respond to it negatively. The change may not be exactly\n" +
            "visible, but it is in some way noticeable—in one way or\n" +
            "another, a person has become less human, and on some\n" +
            "level other people notice this. This is why a character’s Essence\n" +
            "is included in the calculation of their Social limit.";
        public const string MAGIC_RESONANCE_EXPLAINED =
            "MAGIC [MAG]\n" +
            "If you intend to cast spells or use magic in any way,\n" +
            "your character needs to have the Magic attribute. Most\n" +
            "individuals do not have this attribute, meaning their rating\n" +
            "is zero. Mages, who cast spells, and adepts, who\n" +
            "channel magic into enhanced physical and mental abilities,\n" +
            "need this quality. Their Magic rating measures how\n" +
            "capable they are in the arcane arts and how much power\n" +
            "they can draw down to help them in their efforts.\n\n" +
            "RESONANCE [RES]\n" +
            "Similar to Magic for mages and adepts, Resonance is\n" +
            "the special attribute for technomancers. Technomancers\n" +
            "interface with the Matrix using the power of their mind,\n" +
            "and Resonance measures the strength of their ability to\n" +
            "interact with and shape that environment.\n" +
            "Non-technomancers have a zero rating\n" +
            "for Resonance.";
        public const string COMPOSURE_EXPLAINED =
            "COMPOSURE [COM]\n" +
            "Some situations are tough to deal with, even for hardened\n" +
            "professionals like shadowrunners. When a character\n" +
            "is faced with an emotionally overwhelming situation\n" +
            "there are only two choices. Stay and fight or\n" +
            "turn into a quivering lump of goo. To find out which\n" +
            "one happens, make a Willpower + Charisma Test, with\n" +
            "a threshold based on the severity of the situation.Take\n" +
            "note that repeating similar situations over and again\n" +
            "eventually eliminates the need to perform this test.\n" +
            "Staring down a group of well-armed gangers will be\n" +
            "scary at first, but after a character does it a few times\n" +
            "the fear gives way to instinct.";
        public const string JUDGE_INTENTIONS_EXPLAINED =
            "Judge Intentions\n" +
            "Reading another person is also a matter of instinct. A\n" +
            "character can use their instincts to guess at the intentions\n" +
            "of another person or to gauge how much they can\n" +
            "trust someone.Make an Opposed Intuition + Charisma\n" +
            "Test against the target’s Willpower + Charisma.This is\n" +
            "not an exact science. A successful test doesn’t mean\n" +
            "the target will never betray you (intentions have been\n" +
            "known to change), and deceptive characters can gain\n" +
            "another’s confidence easily.This primarily serves as a\n" +
            "benchmark or gut instinct about how much you can\n" +
            "trust the person you are dealing with.";
        public const string MEMORY_EXPLAINED =
            "Memory\n" +
            "While there are numerous mnemonic devices, and even a\n" +
            "few select pieces of bioware, designed for remembering\n" +
            "information, memory is not a skill. If a character needs\n" +
            "to recall information make a Logic + Willpower Test. Use\n" +
            "the Knowledge Skill Table to determine the threshold. If a\n" +
            "character actively tries to memorize information, make a\n" +
            "Logic + Willpower Test at the time of memorization. Each\n" +
            "hit adds a dice to the Recall Test later on.\n" +
            "Glitches can have a devastating effect on memory.\n" +
            "A glitch means the character misremembers some portion\n" +
            "of the information, such as order of numbers in a\n" +
            "passcode. A critical glitch means the character has completely\n" +
            "fooled himself into believing and thus remembering\n" +
            "something that never actually happened.";
        public const string LIFT_CARRY_EXPLAINED =
            "Lift / Carry\n" +
            "The baseline for lifting weight is 15 kilograms per\n" +
            "point of Strength. Anything more than that requires a\n" +
            "Strength + Body Test. Each hit increases the max weight\n" +
            "lifted by 15 kilograms. Lifting weight above your head,\n" +
            "as with a clean & jerk, is more difficult. The baseline for\n" +
            "lifting weight above the head is 5 kilograms per point\n" +
            "Strength. Each hit on the Lifting Test increases the maximum\n" +
            "weight you can lift by 5 kilograms.\n" +
            "Carrying weight is significantly different than lifting\n" +
            "weight. Characters can carry Strength x 10 kilograms in\n" +
            "gear without effort. Additional weight requires a Lifting\n" +
            "Test. Each hit increases the maximum by 10 kilograms.";
        public const string MOVE_EXPLAINED =
            "Move\n" +
            "Getting from one place to another, especially from one\n" +
            "piece of cover to another or closing the distance on an opponent,\n" +
            "is important. Characters in Shadowrun have three\n" +
            "types of movement: Walking, Running, and Sprinting.\n" +
            "A character’s movement for an entire Combat Turn\n" +
            "(meaning total movement for all Initiative Passes, not\n" +
            "for each Initiative Pass) is based on their Run rate, which\n" +
            "is determined by metatype. Walk rate determines the\n" +
            "farthest a character can move during a Combat Turn before\n" +
            "they are considered to be Running.\n" +
            "It’s important to point out that “run” does not mean\n" +
            "bolt as fast as you can; that’s sprinting. Think of running as\n" +
            "a trained combat hustle or a jog, something to get you to\n" +
            "another point quickly but still leave you able to perform\n" +
            "other actions, albeit with a penalty. Sprinting is exactly\n" +
            "that, running as fast as you can from point A to point B.";
        public const string INITIATIVE_GENERAL_EXPLAINED =
            "Generally regarding Initiative\n" +
            "Initiative determines the order in which characters act,\n" +
            "as well as how often they act during a single Combat\n" +
            "Turn. Initiative is based on three factors: Initiative Attribute,\n" +
            "Initiative Score, and Initiative Dice.";
        public const string INITIATIVE_EXPLAINED =
            "Initiative\n" +
            "The Initiative Attribute is a derived attribute\n" +
            "used to measure the speed, perceptiveness, and\n" +
            "reaction rate of a combatant. See the Initiative\n" +
            "Attribute Chart to determine Initiative attributes\n" +
            "for different types of combatants (Physical, Astral,\n" +
            "Matrix, or Rigging) and their Base Initiative Die.\n\n" +
            "To determine a character’s Initiative Score, make an\n" +
            "Initiative Test rolling the character’s Initiative Dice and\n" +
            "adding the total to your Initiative attribute—this total is\n" +
            "your Initiative Score. Edge may be used on this test to\n" +
            "roll the maximum of 5D6 for a single Combat Turn. The\n" +
            "gamemaster records the score for each character, from\n" +
            "highest to lowest. The character with the highest score\n" +
            "goes first and the others follow in descending order\n" +
            "during each Initiative Pass.\n" +
            "If there is a tied Initiative Score use ERIC (Edge, Reaction,\n" +
            "Intuition, Coin toss) to break the tie, comparing\n" +
            "Attributes in that order, with the character with the higher\n" +
            "Attribute going first. If you’re still tied after comparing\n" +
            "all three tie-breaker Attributes, flip a coin. Alternately, at\n" +
            "the gamemaster’s discretion, both characters can act simultaneously.";
        public const string MATRIX_INITIATIVE_EXPLAINED =
            "Matrix Initiative\n" +
            "This value is used when fighting in the Matrix.\n" +
            "In all other aspects, see Initiative.";
        public const string ASTRAL_INITIATIVE_EXPLAINED =
            "Astral Initiative\n" +
            "This value is used when fighting astrally.\n" +
            "In all other aspects, see Initiative.";
    }
}