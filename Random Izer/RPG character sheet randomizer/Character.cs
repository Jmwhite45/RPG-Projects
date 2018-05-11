using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPG_character_sheet_randomizer.Vars;
using static RPG_character_sheet_randomizer.Vars.GAME;
using static RPG_character_sheet_randomizer.Vars.ROLLS;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Net.Mail;
using static System.Environment;

namespace RPG_character_sheet_randomizer
{
    public class Character
    {
        public CLASSES CClass = 0;
        public string[] SubClass = null;

        public RACE CRace = 0;
        public string SubRace = "";

        public ROLLS rollType = 0;
        public int[] Stats = new int[6];
        public int[] Mods = new int[6];

        public int[] background = new int[6];

        public GAME game = 0;

        public int HP = 0;
        public int Gold = 0;
        public int level = 1;

        public Character(GAME G, int L, ROLLS R)
        {
            game = G;
            level = L;

            rollType = R;
            Stats = Rolling.RollStats(rollType);
            Mods = Rolling.findMods(Stats);

            CClass = Class.RollClass(game);
            CRace = race.RollRace(game);

            HP = HPGold.RollHP(game, CClass, level);
            Gold = HPGold.RollGold(game, CClass);

            if (game == DND5e)
            {
                background = Background.RollBackground(game);
            }
        }

        public void DisplayCharacter()
        {
            SubClass = Class.DisplayClass(CClass, level, game);
            SubRace = race.displayRace(CRace, game);
            Rolling.DisplayStats(Stats, Mods);
            HPGold.DisplayGold(Gold);
            HPGold.DisplayHP(HP);
            Background.displayBackground(background, game);
        }
    }
}
