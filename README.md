# ShadowrunRoller

ShadowrunRoller is the first name for an application that I'm trying to build. First of all it was just going
to be rolling dice Shadowrun style, but then I came up with the idea to be able to generate NPC characters of
different strengths. On top of that I got the idea to also have many characters in memory and generate a combat
outline for those chars with initative and so on and being able to check off each character as they are performing
their actions in a combat round.

I have some trouble "stealing" the xml-files of skills, spells and other things from Chummer (which I plan to do).
Importing them into the project have proved much more difficult than I imagined.
I'll work on this as soon as I have more time, but as of now (190314) I'm a bit busy in RL.

These are the thought basic milestones:

* [DONE] Create a program where you can roll a number of D6 Shadowrun style.
* [DONE] Create the possibility to roll edge dice roll.
* [DONE] Create the possibility to add dice to an existing roll and make those dice exploding or not.

This is version 1.
When this was done the basic idea of the application was done. Now moving on to more elaborate things.

* [DONE] Create an NPC character with stats, calculated stats, limits and condition.
* [UNDER CONSTRUCTION] Create a "vault" to store the character in when they are in memory.
* [FUTURE] Save and load character and save/load a group of characters.
* [FUTURE] Skills, Cyberware, Equipment, Contacts, Spells and Qualities autogenerating and possibility to change around.

This is version 2.
With all of this we have a working NPC generator. Then we go to the next step.

* [FUTURE] Create a new tab where I can see all of the characters I currently have in memory and important info about them.
* [FUTURE] Make it possible to roll initiative for NPCs and show initiative score for NPCs and PCs.
* [FUTURE] Sort the characters displayed depending on their initiative score.
* [FUTURE] Make it possible to check off actions and count down initiative score on each char.

This is version 3.
That will take us to a full fledged NPC generator with possibility of showing and counting down initiative for NPCs and PCs.
You would still have to manually enter PCs by hand by type in their stats so that leads us to the following version:

* [FAR, DISTANT FUTURE] Import Chummer 5 files into Shadowrun Roller for PCs and very important NPCs

Other ideas I have:
* [IDEA, NOT SCHEDULED] Make an NPC 100% rule correct. Today I just run random numbers for stats and skills based
on how tough the character is supposed to be. Perhaps have a "force rule-perfect" option to actually roll real PCs
fully randomly??
* [IDEA, NOT SCHEDULED] Allow for "time passed" between combat scenes and automatically calculate recovery of
condition if you don't do anything extraordinary.
* [IDEA, NOT SCHEDULED] Have a settings file where some settings can be saved.
* [IDEA, NOT SCHEDULED] Create an actual installer package.

You can reach me through github or at devel at liden.cx.

All of this code is GPL.
