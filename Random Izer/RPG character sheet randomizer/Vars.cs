using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RPG_character_sheet_randomizer
{
    public class Vars
    {
        public static string patch = "1.2.0";

        public static Character SavedChar;

        public enum GAME { NONE, DND5e, PATHFINDER }
        public enum CLASSES
        {
            NONE,
            BARBARIAN,
            BARD,
            CLERIC,
            DRUID,
            FIGHTER,
            MONK,
            PALADIN,
            RANGER,
            ROGUE,
            SORCERER,
            WARLOCK,
            WIZARD,
            ALCHEMIST,
            CAVALIER,
            GUNSLINGER,
            INQUISITOR,
            MAGUS,
            ORACLE,
            SUMMONER,
            VIGILANTE,
            WITCH,
            ANTIPALADIN,
            NINJA,
            SAMURAI,
            ARCANIST,
            BLOODRAGER,
            BRAWLER,
            HUNTER,
            INVESTIGATOR,
            SHAMAN,
            SKALD,
            SLAYER,
            SWASHBUCKLER,
            WARPRIEST,
            ARTIFICER,
            PSIONICS
        }
        public enum RACE { NONE, DWARF, ELF, HALFLING, HUMAN, DRAGONBORN, GNOME, HALFELF, HALFORC, TEIFLING }
        public enum ROLLS { ROLL3D6, ROLL4D6}

        public static JObject D5Core = JObject.Parse(File.ReadAllText(@"../../JSON/DnDCore.json"));
        public static JObject D5EE = JObject.Parse(File.ReadAllText(@"../../JSON/DnDEE.json"));
        public static JObject D5Swords = JObject.Parse(File.ReadAllText(@"../../JSON/DnDSwords.json"));
        public static JObject D5Volos = JObject.Parse(File.ReadAllText(@"../../JSON/DnDVolos.json"));

        public static JObject PathCore = JObject.Parse(File.ReadAllText(@"../../JSON/PathCore.json"));

        public static RpgRndCharGen frmref = RpgRndCharGen.main;
        public static ErrorReportingForm ErrorForm = new ErrorReportingForm();

        public static int findSize<T>(List<T> L)
        {
            
            int total = 0;
            foreach(T item in L)
            {
                total++;
            }
            return total;
        }

        public static T[] shorten<T>(T[] A)
        {
            int newSize = 0;
            for(int i=0; i < A.Length; i++)
            {
                if(A[i] != null)
                {
                    newSize++;
                }
            }
            T[] newA = new T[newSize];

            for(int i=0; i<newA.Length; i++)
            {
                newA[i] = A[i];
            }

            return newA;
        }

        public static bool isDuplicate(List<string> L, string v)
        {
            int size = findSize<string>(L);
            for (int i = 0; i< size; i++)
            {
                if(L[i] == v)
                {
                    return true;
                }
            }

            return false;
        }

        public static List<string> getdata(GAME G, string type)
        {
            List<string> L = new List<string>();
            if (G == GAME.DND5e)
            {
                List<string> range;
               range = D5Core[type].Select(t => (string)t).ToList();

                if (range != null)
                {
                    L.AddRange(range);
                }


                bool n = D5EE[type].HasValues;
                if (n == true)
                {
                    range = D5EE[type].Select(t => (string)t).ToList();
                    L.AddRange(range);
                }


                n = D5Swords[type].HasValues;
                if (n == true)
                {
                    range = D5Swords[type].Select(t => (string)t).ToList();
                    L.AddRange(range);
                }

                n = D5Volos[type].HasValues;
                if (n == true)
                {
                    range = D5Volos[type].Select(t => (string)t).ToList();
                    L.AddRange(range);
                }
            }
            else if(G == GAME.PATHFINDER)
            {
                L.AddRange(PathCore[type]
                                .Select(t => (string)t).ToList());
            }
            return L;
        }
    }
}
