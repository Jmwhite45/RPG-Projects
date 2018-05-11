using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace RPG_character_sheet_randomizer.ClassTypes
{
    class Warlock
    {
        public static string[] getDnD(JObject obj, int lv)
        {

            List<string> list = new List<string>();
            List<string> L = obj["Warlock"]
                            .Select(t => (string)t).ToList();

            int r = Rolling.RollD(Vars.findSize<string>(L))-1;
            list.Add(L[r]);

            if(true)
            {
                List<string> P = obj["patron"]
                                .Select(t => (string)t).ToList();

                r = Rolling.RollD(Vars.findSize<string>(P))-1;
                list.Add(P[r]);
            }

            if(lv >= 2)
            {
                int totel = 2;

                if(lv >= 5)
                {
                    totel++;
                }
                if(lv >= 7)
                {
                    totel++;
                }
                if (lv >= 9)
                {
                    totel++;
                }
                if (lv >= 12)
                {
                    totel++;
                }
                if (lv >= 15)
                {
                    totel++;
                }
                if (lv >= 18)
                {
                    totel++;
                }

                List<string> I = obj["Invocation"]
                                .Select(t => (string)t).ToList();
                int size = Vars.findSize<string>(I);
                for (int i=0; i<totel;  i++)
                {
                    r = Rolling.RollD(size)-1;                    
                    string value = I[r];
                    if (Vars.isDuplicate(list, value) == false)
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
