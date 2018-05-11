/*
    Jonah White
    
    Name: RPG character Sheet Randomizer
    Updated: 1/25/2017
    description:
        This program will give you a random class, race, and stats for a RPG character.
        This works with Pathfinder and D&D 5e

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using static RPG_character_sheet_randomizer.Vars;
using static RPG_character_sheet_randomizer.Vars.CLASSES;
using static RPG_character_sheet_randomizer.Vars.GAME;
using static RPG_character_sheet_randomizer.Vars.ROLLS;



namespace RPG_character_sheet_randomizer
{
    public partial class RpgRndCharGen : Form
    {
        public RpgRndCharGen()
        {
            InitializeComponent();
        }

        int PathCountClasses = 28;
        int PathCountCoreClasses = 11;
        int PathCountACGClasses = 21;

        /* int PathCountEnergyTypes = 4;
         int PathCountCombateStyles = 1;
         int PathCountRangerCombateStyles = 6;*/
        int PathCountRagePowers = 42;
        int PathCountCoreRagePowers = 28;
        int PathCountACGNonBloodRagePowers = 39;
        int pathCountBloodRageLesser = 40;
        int pathCountBloodRageMid = 41;
        int pathCountBloodRageGreater = 42;

        int PathCountDruidBonds = 2;
        int PathCountDruidNatureDomains = 7;
        int PathCountDruidAnimalCompainions = 17;

        int PathCountWeaponTraining = 14;

        int PathCountMercyLevel3 = 3;
        int PathCountMercyLevel6 = 6;
        int PathCountMercyLevel9 = 11;
        int PathCountMercyLevel12 = 15;
        int PathCountDivineBond = 2;

        int PathCountRangerFavoredEmemy = 15;
        int PathCountRangerFavoredTerrain = 11;
        int PathCountHunterBonds = 2;
        int PathCountRangerAnimals = 12;

        int PathCountRace = 37;
        int PathCountCoreRace = 7;
        /*
        int PathCountAlchemistArchetype = 6;
        int PathCountArcanistArchetype = 9;
        int PathCountBarbarianArchetype = 12;
        int PathCountBardArchetype = 14;
        int PathCountBloodragerArchetype = 11;
        int PathCountBrawlerArchetype = 7;
        int PathCountCavalierArchetype = 2;
        int PathCountClericArchetype = 13;
        int PathCountDruidArchetype = 22;
        int PathCountfighterArchetype = 19;
        int PathCountGunslingerArchetype = 4;
        int PathCountHunterArchetype = 5;
        int PathCountInquisitorArchetype = 5;
        int PathCountInvestigatorArchetype = 6;
        int PathCountMagusArchetype = 4;
        int PathCountMonkArchetype = 19;
        int PathCountOracleArchetype = 7;
        int PathCountPaladinArchetype = 11;
        int PathCountRangerArchetype = 14;
        int PathCountRogueArchetype = 22;
        int PathCountShamanArchetype = 7;
        int PathCountSkaldArchetype = 4;
        int PathCountSlayerArchetype = 8;
        int PathCountSorcererArchetype = 3;
        int PathCountSummonerArchetype = 6;
        int PathCountSwashbucklerArchetype = 6;
        int PathCountWarpriestArchetype = 6;
        int PathCountWitchArchetype = 4;
        int PathCountWizardArchetype = 6;
        */
        int PathCountBloodline = 22;
        int PathCountAPGBloodline = 20;
        int PathCountCoreBloodline = 10;
        int PathCountSubBloodlines = 12;

        int PathCountOrder = 8;
        int PathCountACGOrder = 1;
        int PathCountAPGOrder = 7;

        // int PathCountMysteries = 10;
        int PathCountPatreons = 12;

        int PathCountschools = 14;
        int PathCountCoreSchools = 10;

        //int PathCountDiscoveries = 46;
        int PathCountSpirits = 10;
        int PathCountDeities = 20;
        /*  int PathCountDomains = 33;
          int PathCountSubDomain = 2;
          int PathCountChaosSubDomain = 3;
          int PathCountEvilSubDomain = 3;
          int PathCountGoodSubDomain = 3;
          int PathCountLawSubDomain = 3;*/

        XmlDocument Counts = new XmlDocument();

        XmlDocument PathfinderCore = new XmlDocument();
        XmlDocument PathfinderACG = new XmlDocument();
        XmlDocument PathfinderAPG = new XmlDocument();
        XmlDocument PathfinderARG = new XmlDocument();
        XmlDocument DnDCore = new XmlDocument();
        XmlDocument DnDUA = new XmlDocument();
        XmlDocument DnDVolos = new XmlDocument();
        XmlDocument XmlDnDEE = new XmlDocument();
        XmlDocument DnDSwords = new XmlDocument();

        public LinkedList<int> LNums = new LinkedList<int>();
        int[] AStats = new int[6];


        public LinkedList<string> LRaces = new LinkedList<string>();//contains list of races
        public LinkedList<string> LClasses = new LinkedList<string>();// contains list of Classes
        public LinkedList<string> LBloodlines = new LinkedList<string>();//Contains list of bloodlines
        public LinkedList<string> LBackGrounds = new LinkedList<string>();//Contains list of Backgrounds
        public LinkedList<string> LGods = new LinkedList<string>();//Contains list of gods
        public LinkedList<LinkedList<int>> LGodDomains = new LinkedList<LinkedList<int>>();//Contains list of gods
        public LinkedList<string> LDomains = new LinkedList<string>();//Contains list of Domains
        public LinkedList<string> LSubBloodlines = new LinkedList<string>();//Contains list of sub Bloodlines
        public LinkedList<string> LSchools = new LinkedList<string>();//Contains list of Schools
        public LinkedList<string> LSpirits = new LinkedList<string>();//contains list of Spirits
        public LinkedList<string> LOrders = new LinkedList<string>();//contains list of Orders
        public LinkedList<string> LPatreons = new LinkedList<string>();//Contains list of Patreons
        public LinkedList<string> LPaths = new LinkedList<string>();
        public LinkedList<string> LColleges = new LinkedList<string>();
        public LinkedList<string> LCircles = new LinkedList<string>();
        public LinkedList<string> LOaths = new LinkedList<string>();
        public LinkedList<string> Lways = new LinkedList<string>();
        public LinkedList<string> LDwarf = new LinkedList<string>();//Contains list of Schools
        public LinkedList<string> LDragonBorn = new LinkedList<string>();//contains list of Spirits
        public LinkedList<string> LElf = new LinkedList<string>();//contains list of Orders
        public LinkedList<string> LGnome = new LinkedList<string>();//Contains list of Patreons
        public LinkedList<string> LHalfElf = new LinkedList<string>();
        public LinkedList<string> LHalfOrc = new LinkedList<string>();
        public LinkedList<string> Lhalfling = new LinkedList<string>();
        public LinkedList<string> Lhuman = new LinkedList<string>();
        public LinkedList<string> Ltiefling = new LinkedList<string>();
        public LinkedList<string> LAasimar = new LinkedList<string>();
        public LinkedList<string> LFighterArchetypes = new LinkedList<string>();
        public LinkedList<string> LRogueArchetypes = new LinkedList<string>();
        public LinkedList<string> LRangerArchetypes = new LinkedList<string>();
        public LinkedList<string> LhalfSpawn = new LinkedList<string>();
        public LinkedList<string> LSpecialists = new LinkedList<string>();
        public LinkedList<string> LShifter = new LinkedList<string>();
        public LinkedList<string> LRevenant = new LinkedList<string>();
        public LinkedList<string> LPOrders = new LinkedList<string>();
        public LinkedList<string> LFightingStyles = new LinkedList<string>();

        private static readonly Random getrandom = new Random();
        private static readonly object syncLock = new object();
        public static RpgRndCharGen main;
        
        public void Init()//Initalizes the lists5
        {
            main = this;

            PathfinderCore.Load("../../XML/PathfinderCore.xml");
            PathfinderACG.Load("../../XML/PathfinderACG.xml");
            PathfinderAPG.Load("../../XML/PathfinderAPG.xml");
            PathfinderARG.Load("../../XML/PathfinderARG.xml");
            DnDCore.Load("../../XML/DnDCore.xml");
            DnDUA.Load("../../XML/DnDUA.xml");
            DnDVolos.Load("../../XML/DnDVolos.xml");
            XmlDnDEE.Load("../../XML/DnDEE.xml");
            DnDSwords.Load("../../XML/DnDSwords.xml");

            //---------------------------D&D-------------------------------
            //addes classes to list
            LClasses.AddLast("Barbarian");
            LClasses.AddLast("Bard");
            LClasses.AddLast("Cleric");
            LClasses.AddLast("Druid");
            LClasses.AddLast("Fighter");
            LClasses.AddLast("Monk");
            LClasses.AddLast("Paladin");
            LClasses.AddLast("Ranger");
            LClasses.AddLast("Rogue");
            LClasses.AddLast("Sorceror");
            LClasses.AddLast("Warlock");
            LClasses.AddLast("Wizard");
            if (CheckDnDUA.Checked == true)
            {
                LClasses.AddLast("Artificer");//13
                LClasses.AddLast("Psionics");//14
            }



            //add races to list
            LRaces.AddLast("Dragonborn");
            LRaces.AddLast("Dwarf");
            LRaces.AddLast("Elf");
            LRaces.AddLast("Gnome");
            LRaces.AddLast("Half-elf");//5
            LRaces.AddLast("Half-Orc");
            LRaces.AddLast("Halfling");
            LRaces.AddLast("Human");
            LRaces.AddLast("Tiefling");//9

            if (CheckDnDVGtM.Checked == true)
            {
                LRaces.AddLast("Aasimar");//10
                LRaces.AddLast("Firbolg");
                LRaces.AddLast("Goliath(Volo's guide to Monsters)");
                LRaces.AddLast("Kenku");
                LRaces.AddLast("LizardFolk");
                LRaces.AddLast("Tabaxi");//15
                LRaces.AddLast("Triton");
            }
            if ((CheckDnDVGtM.Checked == false) && ((CheckDnDEE.Checked == true) || (CheckDnDUA.Checked == true)))
            {
                LRaces.AddLast("");//10
                LRaces.AddLast("");
                LRaces.AddLast("");
                LRaces.AddLast("");
                LRaces.AddLast("");
                LRaces.AddLast("");//15
                LRaces.AddLast("");
            }
            if (CheckDnDEE.Checked == true)
            {
                LRaces.AddLast("Aarakocra");//17
                LRaces.AddLast("Deep Gnome");
                LRaces.AddLast("Goliath(Elemental Evil)");
                LRaces.AddLast("Genasi");//20
            }
            if ((CheckDnDEE.Checked == false) && (CheckDnDUA.Checked == true))
            {
                LRaces.AddLast("");//17
                LRaces.AddLast("");
                LRaces.AddLast("");
                LRaces.AddLast("");
            }

            if (CheckDnDUA.Checked == true)
            {
                LRaces.AddLast("Half-Spawn");//21
                LRaces.AddLast("Revenant");
                LRaces.AddLast("Changeling");
                LRaces.AddLast("Shifter");
                LRaces.AddLast("Warforged");//25
                LRaces.AddLast("Minotaur");
            }



            //add subclasses to list. SubClasses are for sorcerors, Paliden, Monk, clerics, wizards, druids, Bard, warlocks

            //barbarian subclasses
            LPaths.AddLast("Path of the Beserker");
            LPaths.AddLast("Path of the Totem Warrior");//2

            if (CheckDnDtSCAG.Checked == true)
            {
                LPaths.AddLast("Path of the BattleRager");
            }
            if (CheckDnDUA.Checked == true)
            {
                LPaths.AddLast("Path of the BloodRage Savage");
                LPaths.AddLast("Path of the Ancestral Guardian");
                LPaths.AddLast("Path of the Storm Herald");
                LPaths.AddLast("Path of the Zealot");
            }

            //bard: college of lore, of valor,
            LColleges.AddLast("College of Lore");
            LColleges.AddLast("College of Valor");//4
            if (CheckDnDUA.Checked == true)
            {
                LColleges.AddLast("College of Glamour");
                LColleges.AddLast("College of Whispers");
                LColleges.AddLast("College of Swords");
                LColleges.AddLast("College of Satire");
            }

            //Cleric SubClasses
            LDomains.AddLast("Knowledge Domain");
            LDomains.AddLast("Life Domain");
            LDomains.AddLast("Light Domain");
            LDomains.AddLast("Nature Domain");
            LDomains.AddLast("Tempest Domain");
            LDomains.AddLast("Trickery Domain");
            LDomains.AddLast("War Domain");//11

            if (CheckDnDtSCAG.Checked == true)
            {
                LDomains.AddLast("Arcana Domain");
            }
            if (CheckDnDUA.Checked == true)
            {
                LDomains.AddLast("Forge Domain");
                LDomains.AddLast("Grave Domain");
                LDomains.AddLast("Protection Domain");
                LDomains.AddLast("City Domain");
            }

            //Druid SubClasses
            LCircles.AddLast("Circle of the Land");
            LCircles.AddLast("Circle of the Moon");//2
            if (CheckDnDUA.Checked == true)
            {
                LCircles.AddLast("Circle of the Beast");//3
                LCircles.AddLast("Circle of the Death Bloom");
                LCircles.AddLast("Circle of the Fountain");
                LCircles.AddLast("Circle of Dreams");
                LCircles.AddLast("Circle of the Shepherd");
                LCircles.AddLast("Circle of Twilight");
            }

            //Paladin SubClasses
            LOaths.AddLast("Oath of Devotion");
            LOaths.AddLast("Oath of the Ancients");
            LOaths.AddLast("Oath of Vengeance");//3 

            if (CheckDnDtSCAG.Checked == true)
            {
                LOaths.AddLast("Oath of the crown");//4
            }
            if (CheckDnDUA.Checked == true)
            {
                LOaths.AddLast("Oath of Conquest");
                LOaths.AddLast("Oath of Treachery");
            }


            //Monk SubClasses
            Lways.AddLast("the Way of the Open Hand");
            Lways.AddLast("the Way of Shadow");
            Lways.AddLast("the Way of the Four Elements");//19

            if (CheckDnDtSCAG.Checked == true)
            {
                Lways.AddLast("Way of the Long Death");
                Lways.AddLast("Way of the Sun Soul");
            }
            if (CheckDnDUA.Checked == true)
            {
                Lways.AddLast("Way of the Kensei");//6
                Lways.AddLast("Way of Tranquility");
            }


            //sorceror sub classes
            LBloodlines.AddLast("draconic Bloodline");
            LBloodlines.AddLast("Wild Magic");//2
            if (CheckDnDtSCAG.Checked == true)
            {
                LBloodlines.AddLast("Storm Sorcery");//3
            }
            if (CheckDnDUA.Checked == true)
            {
                LBloodlines.AddLast("King's Blood");//4
                LBloodlines.AddLast("Shadow");
                LBloodlines.AddLast("Favored Soul");
                LBloodlines.AddLast("Phoenix Sorcery");
                LBloodlines.AddLast("Sea Sorcery");
                LBloodlines.AddLast("Stone Sorcery");
            }


            //Wizard SubClasses
            LSchools.AddLast("Abjuration");
            LSchools.AddLast("Conjuration");
            LSchools.AddLast("Divination");
            LSchools.AddLast("Enchantment");
            LSchools.AddLast("Evocation");
            LSchools.AddLast("Illusion");
            LSchools.AddLast("Necromancy");
            LSchools.AddLast("Transmutation");//8
            if (CheckDnDtSCAG.Checked == true)
            {
                LSchools.AddLast("Bladesinging");//9
            }
            if ((CheckDnDtSCAG.Checked == false) && (CheckDnDUA.Checked == true))
            {
                LSchools.AddLast("");
            }
            if (CheckDnDUA.Checked == true)
            {
                LSchools.AddLast("Blood Magic(V1)");//10
                LSchools.AddLast("Blood Magic(V2)");
                LSchools.AddLast("Artificer");
                LSchools.AddLast("Technomancy");
                LSchools.AddLast("Lore Mastery");
                LSchools.AddLast("Theurgy");
                LSchools.AddLast("War Magic");
            }

            //Warlock SubClasses
            LPatreons.AddLast("Archfey");
            LPatreons.AddLast("The Fiend");
            LPatreons.AddLast("The Great Old One");//3
            if (CheckDnDtSCAG.Checked == true)
            {
                LPatreons.AddLast("The Undying");//4
            }
            if (CheckDnDUA.Checked == true)
            {
                LPatreons.AddLast("The Undying Light");//5
                LPatreons.AddLast("Ghost in the Machine");
                LPatreons.AddLast("The Seeker");
                LPatreons.AddLast("The Hexblade");
                LPatreons.AddLast("The Raven Queen");

            }

            //Fighter archetypes
            LFighterArchetypes.AddLast("Champion");
            LFighterArchetypes.AddLast("Battle Master");
            LFighterArchetypes.AddLast("Eldritch Knight");//3
            if (CheckDnDUA.Checked == true)
            {
                LFighterArchetypes.AddLast("Blood Thrall");//4
                LFighterArchetypes.AddLast("Arcane Archer");
                LFighterArchetypes.AddLast("Knight");
                LFighterArchetypes.AddLast("Samurai");
                LFighterArchetypes.AddLast("SharpShooter");
                LFighterArchetypes.AddLast("Monster Hunter");
                LFighterArchetypes.AddLast("Cavalier");
                LFighterArchetypes.AddLast("Scout");
            }

            if (CheckDnDtSCAG.Checked == true)
            {
                LFighterArchetypes.AddLast("Purple Dragon Knight");
            }

            //Ranger archetypes
            LRangerArchetypes.AddLast("Hunter");
            LRangerArchetypes.AddLast("Beast Master");

            if (CheckDnDUA.Checked == true)
            {
                LRangerArchetypes.AddLast("Deep Stalker");//3
                LRangerArchetypes.AddLast("Horizon Walker");
                LRangerArchetypes.AddLast("Primeval Guardian");
            }

            //Rogue archetypes
            LRogueArchetypes.AddLast("Theif");
            LRogueArchetypes.AddLast("Assassin");
            LRogueArchetypes.AddLast("Arcane Trickster");

            if (CheckDnDUA.Checked == true)
            {
                LRogueArchetypes.AddLast("Inguisitive");//3
                LRogueArchetypes.AddLast("Scout");//4
            }

            if (CheckDnDtSCAG.Checked == true)
            {
                LRogueArchetypes.AddLast("MasterMind");
                LRogueArchetypes.AddLast("Swashbuckler");
            }

            if (CheckDnDUA.Checked == true)
            {
                //Artificer specialists
                LSpecialists.AddLast("Alchemist");
                LSpecialists.AddLast("Gunsmith");

                //Psionics Orders
                LPOrders.AddLast("Order of the Awakened");
                LPOrders.AddLast("Order of the Immortal");
            }
            //ADDES SUBSUB CLASSES(SUB BLOODLINES)
            LSubBloodlines.AddLast("Black Dragon");//sub bloodlines for draconic sorceror
            LSubBloodlines.AddLast("Blue Dragon");
            LSubBloodlines.AddLast("Brass Dragon");
            LSubBloodlines.AddLast("Bronze Dragon");
            LSubBloodlines.AddLast("Copper Dragon");
            LSubBloodlines.AddLast("Gold Dragon");
            LSubBloodlines.AddLast("Green Dragon");
            LSubBloodlines.AddLast("Red Dragon");
            LSubBloodlines.AddLast("Silver Dragon");
            LSubBloodlines.AddLast("White Dragon");


            //----------------------------------------------SUB RACES--------------------------------\\



            //code to add SUBRACES
            //Dwarven sub races
            LDwarf.AddLast("Hill");
            LDwarf.AddLast("Mountain");

            if (CheckDnDtSCAG.Checked == true)
            {
                LDwarf.AddLast("Gray");
            }

            //elven sub races
            LElf.AddLast("High");
            LElf.AddLast("Wood");
            LElf.AddLast("Dark");//5

            //Gnome sub races
            LGnome.AddLast("Forest");
            LGnome.AddLast("rock");//7

            if (CheckDnDtSCAG.Checked == true)
            {
                LGnome.AddLast("Deep");
            }

            //halfling
            Lhalfling.AddLast("LightFoot");
            Lhalfling.AddLast("Stout");//9

            //Human
            Lhuman.AddLast("Calishite");
            Lhuman.AddLast("Chondathan");
            Lhuman.AddLast("Damaran");
            Lhuman.AddLast("illuskan");
            Lhuman.AddLast("Mulan");
            Lhuman.AddLast("Rushemi");
            Lhuman.AddLast("Shou");
            Lhuman.AddLast("Tethyrian");
            Lhuman.AddLast("turami");//18


            if (CheckDnDUA.Checked == true)
            {
                //Tiefling
                Ltiefling.AddLast("Infernal");
                Ltiefling.AddLast("Abysal");

                //Half Spawn
                LhalfSpawn.AddLast("dwarf");
                LhalfSpawn.AddLast("elf");
                LhalfSpawn.AddLast("gnome");
                LhalfSpawn.AddLast("Halfling");

                //Shifter
                LShifter.AddLast("Beasthide");
                LShifter.AddLast("Cliffwalk");
                LShifter.AddLast("Longstride");
                LShifter.AddLast("Longtooth");
                LShifter.AddLast("Razorclaw");
                LShifter.AddLast("Wildhunt");

                //Revenent
                LRevenant.AddLast("Dwarf");
                LRevenant.AddLast("Elf");
                LRevenant.AddLast("Gnome");
                LRevenant.AddLast("Halfling");
                LRevenant.AddLast("Human");
                LRevenant.AddLast("Half-Spawn");//21
                LRevenant.AddLast("Shifter");

                if (CheckDnDVGtM.Checked == true)
                {
                    LRevenant.AddLast("Aasimar");
                }
            }

            if (CheckDnDVGtM.Checked == true)
            {
                //Aasimar
                LAasimar.AddLast("Protector");
                LAasimar.AddLast("Scourge");
                LAasimar.AddLast("Fallen");//21
            }


            //Adds backgrounds
            LBackGrounds.AddLast("Acolyte");
            LBackGrounds.AddLast("Charlatan");
            LBackGrounds.AddLast("Criminal");
            LBackGrounds.AddLast("Entertainer");
            LBackGrounds.AddLast("Folk Hero");
            LBackGrounds.AddLast("Guild Artisan");
            LBackGrounds.AddLast("Hermit");
            LBackGrounds.AddLast("Nobel");
            LBackGrounds.AddLast("Outlander");
            LBackGrounds.AddLast("Sage");
            LBackGrounds.AddLast("Sailor");
            LBackGrounds.AddLast("Soldier");
            LBackGrounds.AddLast("Urchin");//13

            if (CheckDnDtSCAG.Checked == true)
            {
                LBackGrounds.AddLast("City Watch");
                LBackGrounds.AddLast("Clan Crafter");
                LBackGrounds.AddLast("Cloistered Scholar");
                LBackGrounds.AddLast("Courtier");
                LBackGrounds.AddLast("Faction Agent");
                LBackGrounds.AddLast("Far Traveler");
                LBackGrounds.AddLast("Inheritor");
                LBackGrounds.AddLast("Knight of the Order");
                LBackGrounds.AddLast("Mercenary Veteran");
                LBackGrounds.AddLast("Urban Bounty Hunter");
                LBackGrounds.AddLast("Uthgardt Tribe Member");
                LBackGrounds.AddLast("Waterdhavian Nobel");
            }

            //FIGHTING SYTLES
            LFightingStyles.AddLast("Archery");
            LFightingStyles.AddLast("Defense");
            LFightingStyles.AddLast("Dueling");
            LFightingStyles.AddLast("Two Weapon Fighting");

            if (CheckDnDUA.Checked == true)
            {
                LFightingStyles.AddLast("Mariner");
                LFightingStyles.AddLast("Close Quarters Shooter");
                LFightingStyles.AddLast("Tunnel Fighter");
            }

        }

        public string CreateIDRequest(String Type, int Number)
        {
            String Request = Type + Number.ToString();

            return Request;
        }

        public string CreateIDRequest(String Type, int Number, char sub)
        {
            String Request = Type + Number.ToString() + sub;

            return Request;
        }

        //Function to get random number
        public static int RollD(int Dice)
        {
            lock (syncLock)
            { // synchronize
                return getrandom.Next(1, Dice + 1);
            }
        }

        public int[] RollStats()//This will roll the Str, Dex, Wis... stats
        {
            int iNextStat;
            int[] Stats = new int[6];
            LinkedList<int> Rolls = new LinkedList<int>();

            if (rbtn4D6.Checked == true)// runs code for if you are doing 4d6 Minus the lowest
            {

                for (int i = 0; i <= 5; i++)//runs the code 6 times(1 for each stat)
                {
                    for (int i2 = 1; i2 <= 4; i2++)//Does the rolls and adds them to a list
                    {
                        Rolls.AddLast(RollD(6));
                    }
                    iNextStat = Rolls.Sum();// adds the numbers of the list
                    iNextStat = iNextStat - Rolls.Min();// sub tracts the Lowest one                    

                    Stats[i] = iNextStat;// adds The stat to the list
                    while (Rolls.First != null)//Removes all numbers from List Rolls
                    {
                        Rolls.RemoveFirst();
                    }
                }

            }
            else if (rbtn3D6.Checked == true)
            {
                for (int i = 1; i <= 6; i++)//runs the code 6 times(1 for each stat)
                {

                    for (int i2 = 1; i2 <= 3; i2++)//Does the rolls and adds them to a list
                    {
                        Rolls.AddLast(RollD(6));
                    }
                    iNextStat = Rolls.Sum();// adds the numbers of the list       

                    Stats[i] = iNextStat;// adds The stat to the list
                    while (Rolls.First != null)//Removes all numbers from List Rolls
                    {
                        Rolls.RemoveFirst();
                    }
                }
            }
            return Stats;//gives you a list of 6 numbers 
        }

        public void ChangeClassImage(int C, int game)
        {
            ClassImage.Width = 293;
            ClassImage.Height = 503;
            if (game == 1)//pathfinder
            {
                if (C == 1)
                {
                    ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Barbarian;
                }
                else if (C == 2)
                {
                    ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Bard;
                }
                else if (C == 3)
                {
                    ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Cleric;
                }
                else if (C == 4)
                {
                    ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Druid;
                }
                else if (C == 5)
                {
                    ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Fighter;
                }
                else if (C == 6)
                {
                    ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Monk;
                }
                else if (C == 7)
                {
                    ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Palidin;
                }
                else if (C == 8)
                {
                    ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Ranger;
                }
                else if (C == 9)
                {
                    ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Rogue;
                }
                else if (C == 10)
                {
                    ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Sorcerer;
                }
                else if (C == 11)
                {
                    ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Wizard;
                }
                else if (C == 12)
                {
                    ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Arcanist;
                }
                else if (C == 13)
                {
                    ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Bloodrager;
                }
                else if (C == 14)
                {
                    ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Brawler;
                }
                else if (C == 15)
                {
                    ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Hunter;
                }
                else if (C == 16)
                {
                    ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Invesigater;
                }
                else if (C == 17)
                {
                    ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Shaman;
                }
                else if (C == 18)
                {
                    ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Skald;
                }
                else if (C == 19)
                {
                    ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Slayer;
                }
                else if (C == 20)
                {
                    ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Swashbuckler;
                }
                else if (C == 21)
                {
                    ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Warpriest;
                }
                else if (C == 22)
                {
                    ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Alchestist;
                }
                else if (C == 23)
                {
                    ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Cavalier;
                }
                else if (C == 24)
                {
                    ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Inguisitor;
                }
                else if (C == 25)
                {
                    ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Oracle;
                }
                else if (C == 26)
                {
                    ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Summoner;
                }
                else if (C == 27)
                {
                    ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Witch;
                }
            }
            /*  else if(game == 2)
              {
                  if(C == 1)
                  {
                      ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Dbarbarian;
                  }
                  else if(C == 2)
                  {
                      ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Dbard;
                  }
                  else if (C == 3)
                  {
                      ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.DCleric;
                      ClassImage.Width = 500;
                  }
                  else if (C == 4)
                  {
                      ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.DDruid;
                      ClassImage.Width = 350;
                  }
                  else if (C == 5)
                  {
                      ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.DFighter;
                  }
                  else if (C == 6)
                  {
                      ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Dmonk;
                      // this is a pathfinder image
                  }
                  else if (C == 7)
                  {
                      ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Dpaladin;
                      ClassImage.Width = 520;
                  }
                  else if (C == 8)
                  {
                      ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Dranger;
                  }
                  else if (C == 9)
                  {
                      ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.DRogue;
                  }
                  else if (C == 10)
                  {
                      ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Dsorcerer;
                      // this is a pathfinder image
                  }
                  else if (C == 11)
                  {
                      ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Dwarlock;
                  }
                  else if (C == 12)
                  {
                      ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Wizard1;
                      ClassImage.Width = 225;
                  }
                  else if (C == 13)
                  {
                     ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Dartificer;
                  }
                  else if (C == 14)
                  {
                     ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Psionics;
                  }
              }*/
        }

        public int RollClass(int Game)
        {
            int ClassNum = -1;
            bool end = false;
            if (Game == 1)//Pathfinder
            {
                do
                {
                    ClassNum = RollD(PathCountClasses);
                    if ((PathACG.Checked == true) && ((PathAPG.Checked == true)))
                    {
                        end = true;
                    }
                    else if ((PathACG.Checked == true) && ((PathAPG.Checked == false)))
                    {
                        if (ClassNum <= PathCountACGClasses)
                        {
                            end = true;
                        }
                    }
                    else if ((PathACG.Checked == false) && ((PathAPG.Checked == true)))
                    {
                        if ((ClassNum <= PathCountCoreClasses) || (ClassNum > PathCountACGClasses))
                        {
                            end = true;
                        }
                    }
                    else if ((PathACG.Checked == false) && ((PathAPG.Checked == false)))
                    {
                        if (ClassNum < PathCountCoreClasses)
                        {
                            end = true;
                        }
                    }
                    else
                    {
                        return -2;
                    }
                } while (end == false);
            }
            else if (Game == 2)//D&D
            {
            }
            else
            {
            }
            if (DevClassNum.Value > 0)
            {
                ClassNum = Convert.ToInt32(DevClassNum.Value);
            }
            ChangeClassImage(ClassNum, Game);

            return ClassNum;
        }

        public string getClass(int ClassNum)
        {
            string Class;

            if (ClassNum <= PathCountCoreClasses)
            {
                Class = PathfinderCore.GetElementById(CreateIDRequest("Class", ClassNum)).InnerText;
            }
            else if ((ClassNum > PathCountCoreClasses) && (ClassNum <= PathCountACGClasses))
            {
                Class = PathfinderACG.GetElementById(CreateIDRequest("Class", ClassNum)).InnerText;
            }
            else
            {
                Class = PathfinderAPG.GetElementById(CreateIDRequest("Class", ClassNum)).InnerText;
            }

            return Class;
        }

        public int RollRace(int game)
        {
            int RaceNum = -1;
            if (game == 1)//Pathfinder
            {
                bool End = false;
                do
                {
                    RaceNum = RollD(PathCountRace);
                    if (PathARG.Checked == true)
                    {
                        End = true;
                    }
                    else if (PathARG.Checked == false)
                    {
                        if (RaceNum <= PathCountCoreRace)
                        {
                            End = true;
                        }
                    }
                } while (End == false);
            }
            else if (game == 2)//D&D
            {

            }

            return RaceNum;
        }

        public string getRace(int race)
        {
            string Race = "";

            if (race > PathCountCoreRace)
            {
                Race = PathfinderARG.GetElementById(CreateIDRequest("Race", race)).InnerText;
            }
            else
            {
                Race = PathfinderCore.GetElementById(CreateIDRequest("Race", race)).InnerText;
            }
            return Race;
        }

        public string RollGetSchool(int game)
        {
            string School = "";
            int SchoolNum;
            bool end = true;

            if (game == 1)//pathfinder
            {
                do
                {
                    SchoolNum = RollD(PathCountschools);
                    if ((PathAPG.Checked == false) && (SchoolNum > PathCountCoreSchools))
                    {
                        end = false;
                    }
                    else
                    {
                        end = true;
                    }
                } while (end == false);

                if (SchoolNum <= PathCountCoreSchools)
                {
                    School = PathfinderCore.GetElementById(CreateIDRequest("School", SchoolNum)).InnerText;
                }
                else
                {

                    School = PathfinderAPG.GetElementById(CreateIDRequest("School", SchoolNum)).InnerText;
                }
            }
            else if (game == 2)//D&D
            {

            }

            return School;
        }

        public string RollGetOrder(int game, string race)
        {
            int OrderNum;
            bool end = false;
            XmlElement Order = PathfinderACG.GetElementById("Order1");


            if (game == 1)// pathfinder
            {
                do
                {
                    OrderNum = RollD(PathCountOrder);

                    if ((PathACG.Checked == true) && (PathARG.Checked == true))
                    {
                        end = true;
                    }
                    else if ((PathACG.Checked == true) && (PathARG.Checked == false))
                    {
                        if (OrderNum <= PathCountAPGOrder)
                        {
                            end = true;
                        }
                    }
                    else if ((PathACG.Checked == false) && (PathARG.Checked == true))
                    {
                        if (OrderNum > PathCountACGOrder)
                        {
                            end = true;
                        }
                    }
                    else if ((PathACG.Checked == false) && (PathARG.Checked == false))
                    {
                        if ((OrderNum > PathCountACGOrder) && (OrderNum <= PathCountAPGOrder))
                        {
                            end = true;
                        }
                    }
                    if (end == true)
                    {

                        if (OrderNum == PathCountACGOrder)
                        {
                            Order = PathfinderACG.GetElementById(CreateIDRequest("Order", OrderNum));
                        }
                        else if (OrderNum == PathCountOrder)
                        {
                            Order = PathfinderARG.GetElementById(CreateIDRequest("Order", OrderNum));
                        }
                        else
                        {
                            Order = PathfinderAPG.GetElementById(CreateIDRequest("Order", OrderNum));
                        }

                        if (Order.GetAttribute("Race") != "")
                        {
                            if (Order.GetAttribute("Race") != race)
                            {
                                end = false;
                            }
                        }
                    }
                } while (end == false);

            }
            else if (game == 2)//D&D
            {

            }

            return Order.InnerText;
        }

        public bool BloodlineRaceCheck(XmlDocument doc, int bloodlineNum, string race)
        {
            bool IsOkay = true;
            string BloodlineRace = doc.GetElementById(CreateIDRequest("Bloodline", bloodlineNum)).GetAttribute("race");

            if ((BloodlineRace != "") && (race != BloodlineRace))
            {
                IsOkay = false;
            }

            return IsOkay;
        }

        public int RollBloodline(int game, string Race)
        {
            int Bloodline = -1;
            if (game == 1)//Pathfinder
            {
                bool End = false;
                do
                {
                    Bloodline = RollD(PathCountBloodline);
                    if ((PathAPG.Checked == true) && (PathARG.Checked == true))
                    {
                        End = true;
                    }
                    else if ((PathAPG.Checked == true) && (PathARG.Checked == false))
                    {
                        if (Bloodline <= PathCountAPGBloodline)
                        {
                            End = true;
                        }
                    }
                    else if ((PathAPG.Checked == false) && (PathARG.Checked == true))
                    {
                        if ((Bloodline <= PathCountCoreBloodline) || (Bloodline > PathCountAPGBloodline))
                        {
                            End = true;
                        }
                    }
                    else if ((PathAPG.Checked == false) && (PathARG.Checked == false))
                    {
                        if (Bloodline <= PathCountCoreBloodline)
                        {
                            End = true;
                        }
                    }

                    if (End == true)
                    {
                        if (Bloodline <= PathCountCoreBloodline)
                        {
                            BloodlineRaceCheck(PathfinderCore, Bloodline, Race);
                        }
                        else if (Bloodline > PathCountAPGBloodline)
                        {
                            BloodlineRaceCheck(PathfinderARG, Bloodline, Race);
                        }
                        else
                        {
                            BloodlineRaceCheck(PathfinderAPG, Bloodline, Race);
                        }
                    }
                } while (End == false);
            }
            else if (game == 2)//D&D
            {

            }

            return Bloodline;
        }

        public string getBloodline(int Bloodline)
        {
            string bloodline = "";

            if (Bloodline <= PathCountCoreBloodline)
            {
                bloodline = PathfinderCore.GetElementById(CreateIDRequest("Bloodline", Bloodline)).InnerText;
            }
            else if (Bloodline > PathCountAPGBloodline)
            {
                bloodline = PathfinderARG.GetElementById(CreateIDRequest("Bloodline", Bloodline)).InnerText;
            }
            else
            {
                bloodline = PathfinderAPG.GetElementById(CreateIDRequest("Bloodline", Bloodline)).InnerText;
            }
            return bloodline;
        }

        public char RollRageBlood()
        {
            int i = RollD(7);
            char BloodType = 'Q';
            if (i == 1)
            {
                BloodType = 'A';
            }
            else if (i == 2)
            {
                BloodType = 'C';
            }
            else if (i == 3)
            {
                BloodType = 'D';
            }
            else if (i == 4)
            {
                BloodType = 'E';
            }
            else if (i == 5)
            {
                BloodType = 'F';
            }
            else if (i == 6)
            {
                BloodType = 'I';
            }
            else if (i == 7)
            {
                BloodType = 'U';
            }

            return BloodType;
        }

        public string RollGetRagePower()
        {
            char RageBlood = RollRageBlood();
            string Powers = "";
            var NumOfPowers = Math.Round((Level.Value / Convert.ToDecimal(2)));//every even level
            int ragePowers = Convert.ToInt32(NumOfPowers);

            var CurrentPowers = new List<int> { };

            bool Okay;
            int CurrentPower;
            XmlElement RagePower = PathfinderCore.GetElementById(("RagePower1"));//Temp Data

            bool temp = true;
            int devTool = 0;

            for (int i = 0; i < ragePowers; i++)
            {
                do
                {
                    Okay = true;
                    if (PathACG.Checked == true)
                    {
                        CurrentPower = RollD(PathCountRagePowers);
                    }
                    else
                    {
                        CurrentPower = RollD(PathCountCoreRagePowers);
                    }

                    if (temp == true)
                    {
                        devTool = CurrentPower;
                        temp = false;
                    }

                    if (CurrentPower <= PathCountCoreRagePowers)
                    {
                        RagePower = PathfinderCore.GetElementById(CreateIDRequest("RagePower", CurrentPower));
                    }
                    else
                    {
                        if (CurrentPower <= PathCountACGNonBloodRagePowers)
                        {
                            RagePower = PathfinderACG.GetElementById(CreateIDRequest("RagePower", CurrentPower));
                        }
                        else
                        {
                            char Tier = 'N';
                            bool ReRoll = false;
                            for (int i2 = 0; i2 < CurrentPowers.Count; i2++)
                            {
                                if ((CurrentPowers[i2] == pathCountBloodRageLesser) && (Tier == 'N'))
                                {
                                    Tier = 'L';
                                }
                                else if ((CurrentPowers[i2] == pathCountBloodRageMid) && (Tier != 'G'))
                                {
                                    Tier = 'M';
                                }
                                else if (CurrentPowers[i2] == pathCountBloodRageGreater)
                                {
                                    Tier = 'G';
                                }
                            }
                            do
                            {
                                if (Tier == 'N')
                                {
                                    if (CurrentPower != pathCountBloodRageLesser)
                                    {
                                        ReRoll = true;
                                    }
                                    else
                                    {
                                        ReRoll = false;
                                    }
                                }
                                else if (Tier == 'L')
                                {
                                    if (CurrentPower != pathCountBloodRageMid)
                                    {
                                        ReRoll = true;
                                    }
                                    else
                                    {
                                        ReRoll = false;
                                    }
                                }
                                else if (Tier == 'M')
                                {
                                    if (CurrentPower != pathCountBloodRageGreater)
                                    {
                                        ReRoll = true;
                                    }
                                    else
                                    {
                                        ReRoll = false;
                                    }
                                }
                                else if (Tier == 'G')
                                {
                                    ReRoll = true;
                                }

                                if (ReRoll == true)
                                {
                                    CurrentPower = RollD(PathCountRagePowers);
                                }
                                if (CurrentPower <= PathCountACGNonBloodRagePowers)
                                {
                                    ReRoll = false;
                                }
                            } while (ReRoll == true);

                            if (CurrentPower <= PathCountCoreRagePowers)
                            {
                                RagePower = PathfinderCore.GetElementById(CreateIDRequest("RagePower", CurrentPower));
                            }
                            else if ((CurrentPower >= pathCountBloodRageLesser) && (CurrentPower <= pathCountBloodRageGreater))
                            {
                                RagePower = PathfinderACG.GetElementById(CreateIDRequest("RagePower", CurrentPower, RageBlood));
                            }
                            else
                            {
                                RagePower = PathfinderACG.GetElementById(CreateIDRequest("RagePower", CurrentPower));
                            }

                        }
                    }
                    if (RagePower == null)
                    {
                        MessageBox.Show("ERROR Origenal: " + devTool.ToString());
                    }
                    if (RagePower.HasAttribute("Level"))
                    {
                        if (Level.Value < Convert.ToInt32(RagePower.GetAttribute("Level")))
                        {
                            Okay = false;
                        }
                    }
                    if ((Okay == true) && (RagePower.HasAttribute("PowerPreReq")))
                    {
                        Okay = false;
                        for (int i2 = 0; i2 < CurrentPowers.Count; i2++)
                        {
                            if (Convert.ToInt32(RagePower.GetAttribute("PowerPreReq")) == CurrentPowers[i2])
                            {
                                Okay = true;
                            }
                        }
                    }
                    if (Okay == true)
                    {

                        for (int i2 = 0; i2 < CurrentPowers.Count; i2++)
                        {
                            if (CurrentPower == CurrentPowers[i2])
                            {
                                Okay = false;
                            }
                            if (RagePower.HasAttribute("Max"))
                            {
                                int total = 0;

                                for (int i3 = 0; i3 <= CurrentPowers.Count; i3++)
                                {
                                    if (CurrentPower == CurrentPowers[i2])
                                    {
                                        total += 1;
                                    }
                                }

                                if (total > Convert.ToInt32(RagePower.GetAttribute("Max")))
                                {
                                    Okay = false;
                                }
                                else
                                {
                                    Okay = true;
                                }
                            }
                        }
                    }
                } while (Okay == false);
                CurrentPowers.Add(CurrentPower);
                Powers = Powers + Environment.NewLine + RagePower.InnerText;
            }

            return Powers;
        }

        public string RollGetNatureBond()
        {
            string RollGetNatureBond = "";
            int Bond = RollD(PathCountDruidBonds);

            if (Bond == 1)
            {
                int Domain = RollD(PathCountDruidNatureDomains);
                RollGetNatureBond = PathfinderCore.GetElementById(CreateIDRequest("Bond", Bond)).GetAttribute("name") + ": " + Environment.NewLine + PathfinderCore.GetElementById(CreateIDRequest("SubBond", Domain)).InnerText;
            }
            else if (Bond == 2)
            {
                int Animal = RollD(PathCountDruidAnimalCompainions);
                RollGetNatureBond = PathfinderCore.GetElementById(CreateIDRequest("Bond", Bond)).GetAttribute("name") + ": " + Environment.NewLine + PathfinderCore.GetElementById(CreateIDRequest("Animal", Animal)).InnerText;
            }
            else
            {
                RollGetNatureBond = "ERROR Bond out of bounds Bond = " + Bond.ToString();
            }

            return RollGetNatureBond;
        }

        public string RollGetWeaponTraining()
        {
            string WeaponTraining = "";
            int TrainingNum = RollD(PathCountWeaponTraining);

            WeaponTraining = PathfinderCore.GetElementById(CreateIDRequest("Weapon", TrainingNum)).InnerText;

            return WeaponTraining;
        }

        public string RollGetMercy()
        {
            string Mercies = "";
            int level = Convert.ToInt32(Level.Value);
            int Roll = 0;
            var currentMercies = new List<int> { };
            bool end;

            if (level >= 3)
            {
                Roll = RollD(PathCountMercyLevel3);
                Mercies = PathfinderCore.GetElementById(CreateIDRequest("Mercy", Roll)).InnerText;
                currentMercies.Add(Roll);
            }
            if (level >= 6)
            {
                do
                {
                    end = true;
                    Roll = RollD(PathCountMercyLevel6);
                    for (int i = 0; i < currentMercies.Count; i++)
                    {
                        if (currentMercies[i] == Roll)
                        {
                            end = false;
                        }
                    }
                } while (end == false);
                Mercies += Environment.NewLine + PathfinderCore.GetElementById(CreateIDRequest("Mercy", Roll)).InnerText;
                currentMercies.Add(Roll);
            }
            if (level >= 9)
            {

                do
                {
                    end = true;
                    Roll = RollD(PathCountMercyLevel9);
                    for (int i = 0; i < currentMercies.Count; i++)
                    {
                        if (currentMercies[i] == Roll)
                        {
                            end = false;
                        }
                    }
                } while (end == false);
                Mercies += Environment.NewLine + PathfinderCore.GetElementById(CreateIDRequest("Mercy", Roll)).InnerText;
                currentMercies.Add(Roll);
            }
            if (level >= 12)
            {

                do
                {
                    end = true;
                    Roll = RollD(PathCountMercyLevel12);
                    for (int i = 0; i < currentMercies.Count; i++)
                    {
                        if (currentMercies[i] == Roll)
                        {
                            end = false;
                        }
                    }
                } while (end == false);
                Mercies += Environment.NewLine + PathfinderCore.GetElementById(CreateIDRequest("Mercy", Roll)).InnerText;
                currentMercies.Add(Roll);
            }
            if (level >= 15)
            {

                do
                {
                    end = true;
                    Roll = RollD(PathCountMercyLevel12);
                    for (int i = 0; i < currentMercies.Count; i++)
                    {
                        if (currentMercies[i] == Roll)
                        {
                            end = false;
                        }
                    }
                } while (end == false);
                Mercies += Environment.NewLine + PathfinderCore.GetElementById(CreateIDRequest("Mercy", Roll)).InnerText;
                currentMercies.Add(Roll);
            }
            if (level >= 18)
            {

                do
                {
                    end = true;
                    Roll = RollD(PathCountMercyLevel12);
                    for (int i = 0; i < currentMercies.Count; i++)
                    {
                        if (currentMercies[i] == Roll)
                        {
                            end = false;
                        }
                    }
                } while (end == false);
                Mercies += Environment.NewLine + PathfinderCore.GetElementById(CreateIDRequest("Mercy", Roll)).InnerText;
                currentMercies.Add(Roll);
            }

            return Mercies;
        }

        public string RollGetFavoredEnemy()
        {
            string Enemy = "";
            int Enemies = 1;
            var CurrentEnemies = new List<int> { };
            if (Level.Value >= 5)
            {
                Enemies++;
            }
            if (Level.Value >= 10)
            {
                Enemies++;
            }
            if (Level.Value >= 15)
            {
                Enemies++;
            }
            if (Level.Value >= 20)
            {
                Enemies++;
            }

            for (int i = 0; i < Enemies; i++)
            {
                int Roll = 0;
                bool end;
                do
                {
                    end = true;
                    Roll = RollD(PathCountRangerFavoredEmemy);
                    for (int i2 = 0; i2 < CurrentEnemies.Count; i2++)
                    {
                        if (CurrentEnemies[i] == Roll)
                        {
                            end = false;
                        }
                    }

                } while (end == false);
                CurrentEnemies.Add(Roll);
                Enemy += Environment.NewLine + PathfinderCore.GetElementById(CreateIDRequest("Enemy", Roll)).InnerText;
            }

            return Enemy;
        }

        public string RollGetFavoredTerrain()
        {
            string Terrain = "";
            int Terrains = 1;
            var CurrentTerrains = new List<int> { };
            if (Level.Value >= 8)
            {
                Terrains++;
            }
            if (Level.Value >= 13)
            {
                Terrains++;
            }
            if (Level.Value >= 18)
            {
                Terrains++;
            }

            for (int i = 0; i < Terrains; i++)
            {
                int Roll = 0;
                bool end;
                do
                {
                    end = true;
                    Roll = RollD(PathCountRangerFavoredTerrain);
                    for (int i2 = 0; i2 < CurrentTerrains.Count; i2++)
                    {
                        if (CurrentTerrains[i] == Roll)
                        {
                            end = false;
                        }
                    }

                } while (end == false);
                CurrentTerrains.Add(Roll);
                Terrain += Environment.NewLine + PathfinderCore.GetElementById(CreateIDRequest("Terrain", Roll)).InnerText;
            }

            return Terrain;
        }

        public string RollGetHuntersBond()
        {
            string huntersBond = "";
            int Roll = RollD(PathCountHunterBonds);
            huntersBond = PathfinderCore.GetElementById(CreateIDRequest("HB", Roll)).InnerText;

            if (Roll == 2)
            {
                Roll = RollD(PathCountRangerAnimals);
                if (Roll == 12)
                {
                    Roll = 18;
                }

                huntersBond += Environment.NewLine + "Animal Companion: " + PathfinderCore.GetElementById(CreateIDRequest("Animal", Roll)).InnerText;
            }

            return huntersBond;
        }

        public void RollHPandGold(int game, int Class)
        {
            int HPDice = 0;
            int GoldDice = 0;
            if (game == 1)
            {
                if (Class == 1)
                {
                    HPDice = 12;
                    GoldDice = 3;
                }
                else if (Class == 2)
                {
                    HPDice = 8;
                    GoldDice = 3;
                }
                else if (Class == 3)
                {
                    HPDice = 8;
                    GoldDice = 4;
                }
                else if (Class == 4)
                {
                    HPDice = 8;
                    GoldDice = 2;
                }
                else if (Class == 5)
                {
                    HPDice = 10;
                    GoldDice = 5;
                }
                else if (Class == 6)
                {
                    HPDice = 8;
                    GoldDice = 1;
                }
                else if (Class == 7)
                {
                    HPDice = 10;
                    GoldDice = 5;
                }
                else if (Class == 8)
                {
                    HPDice = 10;
                    GoldDice = 5;
                }
                else if (Class == 9)
                {
                    HPDice = 8;
                    GoldDice = 4;
                }
                else if (Class == 10)
                {
                    HPDice = 6;
                    GoldDice = 2;
                }
                else if (Class == 11)
                {
                    HPDice = 6;
                    GoldDice = 2;
                }
                else if (Class == 12)
                {
                    HPDice = 6;
                    GoldDice = 2;
                }
                else if (Class == 13)
                {
                    HPDice = 10;
                    GoldDice = 3;
                }
                else if (Class == 14)
                {
                    HPDice = 10;
                    GoldDice = 3;
                }
                else if (Class == 15)
                {
                    HPDice = 8;
                    GoldDice = 4;
                }
                else if (Class == 16)
                {
                    HPDice = 8;
                    GoldDice = 3;
                }
                else if (Class == 17)
                {
                    HPDice = 8;
                    GoldDice = 3;
                }
                else if (Class == 18)
                {
                    HPDice = 8;
                    GoldDice = 3;
                }
                else if (Class == 19)
                {
                    HPDice = 10;
                    GoldDice = 5;
                }
                else if (Class == 20)
                {
                    HPDice = 10;
                    GoldDice = 5;
                }
                else if (Class == 21)
                {
                    HPDice = 8;
                    GoldDice = 5;
                }
                else if (Class == 22)
                {
                    HPDice = 8;
                    GoldDice = 3;
                }
                else if (Class == 23)
                {
                    HPDice = 10;
                    GoldDice = 5;
                }
                else if (Class == 24)
                {
                    HPDice = 8;
                    GoldDice = 4;
                }
                else if (Class == 25)
                {
                    HPDice = 8;
                    GoldDice = 3;
                }
                else if (Class == 26)
                {
                    HPDice = 8;
                    GoldDice = 2;
                }
                else if (Class == 27)
                {
                    HPDice = 6;
                    GoldDice = 3;
                }
                else if (Class == 28)
                {
                    HPDice = 10;
                    GoldDice = 5;
                }
            }
            else if (game == 2)
            {
                // 12 barbarian
                //8 bard cleric druid monk rogue warlock
                //10 fighter paladin ranger
                //6 sorcerer wizard
                if(Class == 1)
                {
                    HPDice = 12;
                }
                else if((Class == 2)||(Class == 3)||(Class == 4)||(Class == 6) || (Class == 9) || (Class == 11))
                {
                    HPDice = 8;
                }
                else if ((Class == 5)||(Class == 7) || (Class == 8))
                {
                    HPDice = 10;
                }
                else if((Class == 11) ||(Class == 12))
                {
                    HPDice = 6;
                }
            }

            int HP = HPDice;
            for (int i = 2; i <= Level.Value; i++)
            {
                HP += RollD(HPDice);
            }
            HPoutput.Text = HP.ToString();

            int Gold = 0;
            for (int i = 1; i <= GoldDice; i++)
            {
                Gold += (10 * RollD(6));
            }
            GoldOutput.Text = Gold.ToString();
        }

        public void RollAllStats()
        {
            AStats = RollStats();

            int strMod = 0;
            int wisMod = 0;
            int DexMod = 0;
            int IntMod = 0;
            int ConMod = 0;
            int ChaMod = 0;

            StrOutput.Text = AStats[0].ToString();
            IntOutput.Text = AStats[1].ToString();
            ConOutput.Text = AStats[2].ToString();
            WisOutput.Text = AStats[3].ToString();
            ChaOutput.Text = AStats[4].ToString();
            DexOutput.Text = AStats[5].ToString();

            strMod = Convert.ToInt32(((Convert.ToDouble(AStats[0].ToString())) / 2.1) - 5);
            IntMod = Convert.ToInt32(((Convert.ToDouble(AStats[1].ToString())) / 2.1) - 5);
            ConMod = Convert.ToInt32(((Convert.ToDouble(AStats[2].ToString())) / 2.1) - 5);
            wisMod = Convert.ToInt32(((Convert.ToDouble(AStats[3].ToString())) / 2.1) - 5);
            ChaMod = Convert.ToInt32(((Convert.ToDouble(AStats[4].ToString())) / 2.1) - 5);
            DexMod = Convert.ToInt32(((Convert.ToDouble(AStats[5].ToString())) / 2.1) - 5);
        
            StrOutput.Text += " ( " + strMod + " )";
            IntOutput.Text += " ( " + IntMod + " )";
            ConOutput.Text += " ( " + ConMod + " )";
            WisOutput.Text += " ( " + wisMod + " )";
            ChaOutput.Text += " ( " + ChaMod + " )";
            DexOutput.Text += " ( " + DexMod + " )";


        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            int Class = 0;
            int game = 0;

            if (rbtnPathfinder.Checked == true)
            {
                game = 1;
            }
            else if (rbtnDnD5e.Checked == true)
            {
                game = 2;
            }

            if (game == 1)//Code for a Pathfinder character
            {
                int Num;//random number to keep track of how many times I do things
                int race = RollRace(1);//rolls a random race
                Class = RollClass(1);
                int SubClass;
                int SubSorceror;

                ClassPowers.Text = "Class Powers: None";

                if (Class <= 0)
                {
                    MessageBox.Show("ERROR: This program is about to crash(likely). If you see this message please alert the developer(see bug reporting button) with this message: 'Class value renturned a value of " + Class + "' ");
                }
                if (race <= 0)
                {
                    MessageBox.Show("ERROR: This program is about to crash(likely). If you see this message please alert the developer(see bug reporting button) with this message: 'Race value renturned a value of " + race + "' ");
                }

                RaceOutput.Text = getRace(race);
                ClassOutput.Text = getClass(Class);

                if (Class == 1)
                {
                    int ragePowers = Convert.ToInt32((Level.Value / 2));

                    int[] CurrentPowers = new int[] { };

                    ClassPowers.Text = "Rage Powers: \r\n" + RollGetRagePower();

                }
                else if ((Class == 3) || (Class == 21))// if class is Cleric or Warlock
                {
                    int god = RollD(PathCountDeities);
                    int domain = RollD(5);

                    ClassOutput.Text = ClassOutput.Text + " of " + PathfinderCore.GetElementById(CreateIDRequest("Deity", god)).InnerText; ; // puts the Class on the screen

                    while (LNums.First != null)//Removes all content from list
                    {
                        LNums.RemoveFirst();
                    }
                    if (god == 1)
                    {
                        LNums.AddLast(2);
                        LNums.AddLast(6);
                        LNums.AddLast(14);
                        LNums.AddLast(17);
                        LNums.AddLast(23);
                    }
                    else if (god == 2)
                    {
                        LNums.AddLast(14);
                        LNums.AddLast(13);
                        LNums.AddLast(17);
                        LNums.AddLast(28);
                        LNums.AddLast(31);
                    }
                    else if (god == 3)
                    {
                        LNums.AddLast(14);
                        LNums.AddLast(17);
                        LNums.AddLast(13);
                        LNums.AddLast(3);
                        LNums.AddLast(24);
                    }
                    else if (god == 4)
                    {
                        LNums.AddLast(14);
                        LNums.AddLast(12);
                        LNums.AddLast(13);
                        LNums.AddLast(15);
                        LNums.AddLast(28);
                    }
                    else if (god == 5)
                    {
                        LNums.AddLast(14);
                        LNums.AddLast(1);
                        LNums.AddLast(19);
                        LNums.AddLast(5);
                        LNums.AddLast(24);
                    }
                    else if (god == 6)
                    {
                        LNums.AddLast(14);
                        LNums.AddLast(18);
                        LNums.AddLast(4);
                        LNums.AddLast(19);
                        LNums.AddLast(29);
                    }
                    else if (god == 7)
                    {
                        LNums.AddLast(14);
                        LNums.AddLast(5);
                        LNums.AddLast(4);
                        LNums.AddLast(27);
                        LNums.AddLast(29);
                    }
                    else if (god == 8)
                    {
                        LNums.AddLast(10);
                        LNums.AddLast(17);
                        LNums.AddLast(22);
                        LNums.AddLast(24);
                        LNums.AddLast(29);
                    }
                    else if (god == 9)
                    {
                        LNums.AddLast(26);
                        LNums.AddLast(15);
                        LNums.AddLast(16);
                        LNums.AddLast(17);
                        LNums.AddLast(27);
                    }
                    else if (god == 10)
                    {
                        LNums.AddLast(2);
                        LNums.AddLast(1);
                        LNums.AddLast(23);
                        LNums.AddLast(32);
                        LNums.AddLast(33);
                    }
                    else if (god == 11)
                    {
                        LNums.AddLast(8);
                        LNums.AddLast(16);
                        LNums.AddLast(25);
                        LNums.AddLast(15);
                        LNums.AddLast(32);
                    }
                    else if (god == 12)
                    {
                        LNums.AddLast(26);
                        LNums.AddLast(24);
                        LNums.AddLast(21);
                        LNums.AddLast(16);
                        LNums.AddLast(9);
                    }
                    else if (god == 13)
                    {
                        LNums.AddLast(4);
                        LNums.AddLast(9);
                        LNums.AddLast(13);
                        LNums.AddLast(27);
                        LNums.AddLast(31);
                    }
                    else if (god == 14)
                    {
                        LNums.AddLast(4);
                        LNums.AddLast(16);
                        LNums.AddLast(19);
                        LNums.AddLast(30);
                        LNums.AddLast(5);
                    }
                    else if (god == 15)
                    {
                        LNums.AddLast(30);
                        LNums.AddLast(21);
                        LNums.AddLast(17);
                        LNums.AddLast(12);
                        LNums.AddLast(11);
                    }
                    else if (god == 16)
                    {
                        LNums.AddLast(11);
                        LNums.AddLast(12);
                        LNums.AddLast(17);
                        LNums.AddLast(21);
                        LNums.AddLast(30);
                    }
                    else if (god == 17)
                    {
                        LNums.AddLast(8);
                        LNums.AddLast(11);
                        LNums.AddLast(27);
                        LNums.AddLast(21);
                        LNums.AddLast(31);
                    }
                    else if (god == 18)
                    {
                        LNums.AddLast(5);
                        LNums.AddLast(8);
                        LNums.AddLast(11);
                        LNums.AddLast(16);
                        LNums.AddLast(30);
                    }
                    else if (god == 19)
                    {
                        LNums.AddLast(4);
                        LNums.AddLast(11);
                        LNums.AddLast(27);
                        LNums.AddLast(20);
                        LNums.AddLast(30);
                    }
                    else if (god == 20)
                    {
                        LNums.AddLast(4);
                        LNums.AddLast(9);
                        LNums.AddLast(11);
                        LNums.AddLast(31);
                        LNums.AddLast(33);
                    }

                    //This code selects the Domain from the Linked list
                    LinkedListNode<int> DomainNumNode = LNums.First;
                    Num = 1;
                    while (Num < domain)
                    {
                        DomainNumNode = DomainNumNode.Next;
                        Num++;
                    }

                    ClassOutput.Text = ClassOutput.Text + " (" + PathfinderCore.GetElementById(CreateIDRequest("Domain", Convert.ToInt32(DomainNumNode.Value))).InnerText; // puts the Class on the screen

                    do
                    {
                        domain = RollD(5);
                    } while (domain == Num);

                    DomainNumNode = LNums.First;
                    Num = 1;
                    while (Num < domain)
                    {
                        DomainNumNode = DomainNumNode.Next;
                        Num++;
                    }
                    ClassOutput.Text = ClassOutput.Text + ", " + PathfinderCore.GetElementById(CreateIDRequest("Domain", Convert.ToInt32(DomainNumNode.Value))).InnerText + ") "; // puts the Class on the screen
                }
                else if (Class == 4)
                {
                    ClassPowers.Text = "Nature Bond: \r\n" + RollGetNatureBond();
                }
                else if (Class == 5)
                {
                    if (Level.Value >= 5)
                    {
                        ClassPowers.Text = "Weapon Training: \r\n" + RollGetWeaponTraining();
                    }
                }
                else if (Class == 7)
                {
                    int deity = RollD(PathCountDeities);
                    ClassOutput.Text += " of " + PathfinderCore.GetElementById(CreateIDRequest("Deity", deity)).InnerText;

                    ClassPowers.Text = "Mercy(s): \r\n" + RollGetMercy();

                    if (Level.Value >= 5)
                    {
                        int bond = RollD(PathCountDivineBond);
                        ClassPowers.Text += Environment.NewLine + Environment.NewLine + PathfinderCore.GetElementById(CreateIDRequest("DivineBond", bond)).InnerText;
                    }
                }
                else if (Class == 8)
                {
                    ClassPowers.Text = "Favored Enemy:" + Environment.NewLine + RollGetFavoredEnemy();

                    if (Level.Value >= 3)
                    {
                        ClassPowers.Text += Environment.NewLine + RollGetFavoredTerrain();
                    }
                    if (Level.Value >= 4)
                    {
                        ClassPowers.Text += Environment.NewLine + Environment.NewLine + RollGetHuntersBond();
                    }
                }
                else if ((Class == 10) || (Class == 13))// If class is Sorceror or bloodrager
                {
                    SubClass = RollBloodline(1, RaceOutput.Text);

                    ClassOutput.Text = ClassOutput.Text + "- " + getBloodline(SubClass); // puts the Class on the screen

                    if (SubClass == 6)// if draconic Bloodline
                    {
                        do
                        {
                            SubSorceror = RollD(PathCountSubBloodlines);
                        } while (SubSorceror > 10);

                        ClassOutput.Text = ClassOutput.Text + "- " + PathfinderCore.GetElementById(CreateIDRequest("SubBloodline", SubSorceror)).InnerText; // puts the Class on the screen
                    }
                    else if (SubClass == 7)// if Elemental Bloodline
                    {
                        do
                        {
                            SubSorceror = RollD(PathCountSubBloodlines);
                        } while (SubSorceror <= 10);


                        ClassOutput.Text = ClassOutput.Text + "- " + PathfinderCore.GetElementById(CreateIDRequest("SubBloodline", SubSorceror)).InnerText; // puts the Class on the screen
                    }
                }
                else if (Class == 11)//wizard
                {
                    ClassOutput.Text = ClassOutput.Text + "- " + RollGetSchool(1); // puts the Class on the screen

                }
                else if ((Class == 17) || (Class == 25))//if class is shaman or Oracle
                {
                    SubClass = RollD(PathCountSpirits);
                    ClassOutput.Text = ClassOutput.Text + "- " + PathfinderACG.GetElementById(CreateIDRequest("Spirit", SubClass)).InnerText; // puts the Class on the screen
                }
                else if ((Class == 23))//Cavaliers
                {
                    ClassOutput.Text = ClassOutput.Text + "- " + RollGetOrder(1, RaceOutput.Text); // puts the Class on the screen
                }
                else if ((Class == 27))//Witchs
                {
                    SubClass = RollD(PathCountPatreons);
                    ClassOutput.Text = ClassOutput.Text + "- " + PathfinderAPG.GetElementById(CreateIDRequest("Patreon", SubClass)).InnerText; // puts the Class on the screen
                }

                //MessageBox.Show(race + ": " + RaceOutput.Text + ". " + Class + ": " + ClassOutput.Text + ".");

                //Changes the Image
                // ChangeClassImage(Class, 1);

                RollAllStats();
                RollHPandGold(game, Class);
            }

            else if (game == 2)
            {
                GAME G = DND5e;
                int L = Convert.ToInt32(Level.Value);
                ROLLS R = ROLL4D6;

                if(rbtn3D6.Checked == true)
                {
                    R = ROLL3D6;
                }
                else if (rbtn4D6.Checked == true)
                {
                    R = ROLL4D6;
                }
                Character newCharacter = new Character(G, L, R);
                Vars.SavedChar = newCharacter;

                newCharacter.DisplayCharacter();
            }
    }

    private void rbtnPathfinder_CheckedChanged(object sender, EventArgs e)
    {
        label2.Visible = false;
        BackgroundOutput.Visible = false;
        ExpansionText.Text = "Pathfinder Expansions";
        PathExpansions.Visible = true;
        DnDExpansions.Visible = false;

        IdealOutput.Visible = false;
        IdealText.Visible = false;
        BondOutput.Visible = false;
        BondText.Visible = false;
        TraitOutput.Visible = false;
        TraitText.Visible = false;
        FlawOutput.Visible = false;
        FlawText.Visible = false;
    }

    private void rbtnDnD5e_CheckedChanged(object sender, EventArgs e)
    {
        label2.Visible = true;
        BackgroundOutput.Visible = true;
        ExpansionText.Text = "DnD 5e Expansions";
        PathExpansions.Visible = false;
        DnDExpansions.Visible = true;

        IdealOutput.Visible = true;
        IdealText.Visible = true;
        BondOutput.Visible = true;
        BondText.Visible = true;
        TraitOutput.Visible = true;
        TraitText.Visible = true;
        FlawOutput.Visible = true;
        FlawText.Visible = true;

            ClassImage.BackgroundImage = null;
        }

    private void ErrorRepo_Click(object sender, EventArgs e)
    {

            ErrorForm.Show();
    }


    private void DevVersion_Click(object sender, EventArgs e)
    {
        MessageBox.Show("ENTERING DEV MODE. This should not break the program but things done in this version will make the program crash. These abilities are ment for testing only if this is an accident please hit the exit Dev mode Button. IMPORTANT TO READ: by clicking okay and using Dev mode You agree to the following statement 'the Develepore of this program will not be held responsible to anything that may happen during the useage of dev mode.' Note: nothing can happen to your computer and I will be held responible if anything does IF AND ONLY IF you click okay and then click exit dev mode but if you click anything else I will not be held responible");
        DevClassNum.Visible = true;
        ExitDev.Visible = true;

        DevBackground.Visible = true;
        DevBackgroundNum.Visible = true;

        DevClass.Visible = true;
        DevClassNum.Visible = true;
    }

    private void ExitDev_Click(object sender, EventArgs e)
    {
        DevClassNum.Value = 0;
        DevClassNum.Visible = false;
        ExitDev.Visible = false;

        DevBackgroundNum.Value = 0;
        DevBackground.Visible = false;
        DevBackgroundNum.Visible = false;

        DevClass.Visible = false;
        DevClassNum.Visible = false;
    }

    private void btnLegal_Click(object sender, EventArgs e)
    {
        MessageBox.Show("All legal information Including but not limited to Open Game License and credits can be found in the Changelog. If no changelog is provided please report the error Immediately and one will be provided.");
    }

    private void RpgRndCharGen_Load(object sender, EventArgs e)
    {
        Init();
    }
}
}
