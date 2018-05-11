using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace RPG_character_sheet_randomizer.ClassTypes
{
    class Fighter
    {
        public static string[] getDnD(JObject obj, int lv)
        {

            List<string> list = new List<string>();
            List<string> L = obj["Fighter"]
                            .Select(t => (string)t).ToList();

            int r = Rolling.RollD(Vars.findSize<string>(L))-1;
            list.Add(L[r]);

            if (L[r] == "Battle Master")
            {
                int manu = 0;
                if(lv >= 3)
                {
                    manu += 3;
                }
                if (lv >= 7)
                {
                    manu += 2;
                }
                if (lv >= 10)
                {
                    manu += 2;
                }
                if (lv >= 15)
                {
                    manu += 2;
                }
                List<string> Manu = obj["Maneuver"]
                            .Select(t => (string)t).ToList();
                int size = Vars.findSize<string>(Manu);

                for (int i = 0; i< manu; i++)
                {
                    int m = Rolling.RollD(size)-1;
                    string value = Manu[m];
                    if(Vars.isDuplicate(list, value) == false)
                    {
                        list.Add(value);
                    }
                    else
                    {
                        i--;
                    }
                }
            }
            string[] subclass = list.ToArray();
            return subclass;
        }
    }
}
