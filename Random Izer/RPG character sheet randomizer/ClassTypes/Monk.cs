using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace RPG_character_sheet_randomizer.ClassTypes
{
    class Monk
    {
        public static string[] getDnD(JObject obj, int lv)
        {

            List<string> list = new List<string>();
            List<string> L = obj["Monk"]
                            .Select(t => (string)t).ToList();

            int r = Rolling.RollD(Vars.findSize<string>(L))-1;
            list.Add(L[r]);
            if(L[r] == "the Way of the Four Elements")
            {
                List<string> D = obj["Discipline"]
                                .Select(t => (string)t).ToList();

                int Disciple = 0;
                if(lv >= 3)
                {
                    Disciple++;
                    list.Add("Elemental Attunement");
                }
                if (lv >= 6)
                {
                    Disciple++;
                }
                if (lv >= 11)
                {
                    Disciple++;
                }
                if (lv >= 17)
                {
                    Disciple++;
                }

                int size = Vars.findSize<string>(D);

                for (int i =0; i<Disciple; i++)
                {
                    r = Rolling.RollD(size) - 1;
                    string value = D[r];
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
