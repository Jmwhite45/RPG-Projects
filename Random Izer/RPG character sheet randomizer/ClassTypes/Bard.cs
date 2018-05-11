using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using static RPG_character_sheet_randomizer.Vars;
using static RPG_character_sheet_randomizer.Vars.GAME;

namespace RPG_character_sheet_randomizer.ClassTypes
{
    class Bard
    {
        public static string[] getDnD()
        {

            List<string> list = new List<string>();
            List<string> L = Vars.getdata(DND5e, "Bard");

            int r = Rolling.RollD(Vars.findSize<string>(L))-1;
            list.Add(L[r]);

            string[] subclass = list.ToArray();
            return subclass;
        }

        public static string[] getPath(int lv)
        {
            List<string> list = new List<string>();
            List<string> L = Vars.getdata(PATHFINDER, "Bard");
            int size = Vars.findSize<String>(L);
            for (int i = 2; i< lv; i++)
            {
                string var = null;
                while (var == null)
                {
                    if ((i == 2) || (i == 6) || (i == 10) || (i == 14) || (i == 18))
                    {
                        var = L[Rolling.RollD(size)];
                    }
                    int size2 = Vars.findSize<String>(list);
                    for (int j = 0; j < size2; j++)
                    {
                        if(list[j] == var)
                        {
                            var = null;
                        }
                    }
                }
            }
            int r = Rolling.RollD(Vars.findSize<string>(L)) - 1;
            list.Add(L[r]);
            
            return list.ToArray();
        }

    }
}
