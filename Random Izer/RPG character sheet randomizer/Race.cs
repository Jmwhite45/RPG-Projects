using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPG_character_sheet_randomizer.Vars;
using static RPG_character_sheet_randomizer.Vars.GAME;
using static RPG_character_sheet_randomizer.Vars.RACE;
using Newtonsoft.Json.Linq;
using System.IO;
using RPG_character_sheet_randomizer.Race;

namespace RPG_character_sheet_randomizer
{
   class race
    {
        public static List<string> collectRaces(GAME game)
        {
            List<string> Races = new List<string>();
            if (game == DND5e)
            {
               Races = Vars.D5Core["Race"]
                               .Select(t => (string)t).ToList();
                if (frmref.CheckDnDEE.Checked == true)
                {
                    Races.AddRange(Vars.D5EE["Race"]
                              .Select(t => (string)t).ToList());
                }

                if (frmref.CheckDnDVGtM.Checked == true)
                {
                   Races.AddRange(Vars.D5Volos["Race"]
                               .Select(t => (string)t).ToList());
                }
            }

            return Races;
        }
        public static RACE RollRace(GAME game)
        {
            List<string> races = collectRaces(game);
            int count = Vars.findSize<string>(races);
            int roll = Rolling.RollD(count);

            //    if (frmref.DevRaceNum.Value > 0)
            //    {
            //        roll = (CLASSES)Convert.ToInt32(frmref.DevRaceNum.Value);
            //    }


            return (RACE)Convert.ToInt32(roll);
        }

        public static string displayRace(RACE R, GAME G)
        {
            string sub = null;
            if(G == DND5e)
            {
               sub = displayRace5e(R);
            }

            return sub;
        }

        public static string displayRace5e(RACE R)
        {
            List<string> Races = collectRaces(DND5e);

            int irace = (int)R;

            string subRace = "";
            if(R == DRAGONBORN)
            {
                subRace = DragonBorn.getSubRace();
            }
            if(R == DWARF)
            {
                subRace = Dwarf.getSubRace();
            }
            if(R == ELF)
            {
                subRace = Elf.getSubRace();
            }
            if(R == GNOME)
            {
                subRace = Gnome.getSubRace();
            }
            if(R == HALFLING)
            {
                subRace = Halfling.getSubRace();
            }

            if (subRace != "")
            {
                frmref.RaceOutput.Text = Races[irace-1] + "- " + subRace;
            }
            else
            {
               frmref.RaceOutput.Text = Races[irace-1];
            }

            return subRace;
        }

    }
}
