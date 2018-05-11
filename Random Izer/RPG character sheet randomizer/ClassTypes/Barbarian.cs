using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using static RPG_character_sheet_randomizer.Vars.GAME;

namespace RPG_character_sheet_randomizer.ClassTypes
{
    class Barbarian
    {
        public static string[] getDnD(int lv)
        {
            List<string> list = new List<string>();
            List<string> L = Vars.getdata(DND5e, "Barbarian");

            int r = Rolling.RollD(Vars.findSize<string>(L)) - 1;
            list.Add(L[r]);

            if (L[r] == "Path of the Totem Warrior")
            {
                int totemNum = 0;
                if (lv >= 14)
                {
                    totemNum++;
                }
                if (lv >= 6)
                {
                    totemNum++;
                }
                if (lv >= 3)
                {
                    totemNum++;
                }

                List<string> Totems = Vars.getdata(DND5e, "Totem")
                  .Select(t => (string)t).ToList();
                int size = Vars.findSize<string>(Totems);

                for (int i = 0; i < totemNum; i++)
                {
                    r = Rolling.RollD(size) - 1;
                    list.Add(Totems[r]);
                }
            }

            string[] subclass = list.ToArray();
            return subclass;
        }

        public static string[] getPath(int lv)
        {
            List<string> list = new List<string>();
            List<string> L = Vars.getdata(PATHFINDER, "Barbarian");
            double d = lv / 2;
            int num = Convert.ToInt32(Math.Floor(d));

            for (int i = 0; i < num; i++)
            {
                int roll = Rolling.RollD(L.Count);
                string value = L[roll];
                if (Vars.isDuplicate(list, value) == false)
                {
                    list.Add(value);
                }
                else
                {
                    num++;
                }
            }

            return list.ToArray();
        }
    }
}
