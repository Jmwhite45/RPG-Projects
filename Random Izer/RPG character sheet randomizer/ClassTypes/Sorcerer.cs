using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace RPG_character_sheet_randomizer.ClassTypes
{
    class Sorcerer
    {
        public static string[] getDnD(JObject obj, int lv)
        {

            List<string> list = new List<string>();
            List<string> L = obj["Sorcerer"]
                            .Select(t => (string)t).ToList();

            int r = Rolling.RollD(Vars.findSize<string>(L))-1;
            list.Add(L[r]);

            if(L[r] == "draconic")
            {
                List<string> D = obj["Dragon"]
                            .Select(t => (string)t).ToList();

                r = Rolling.RollD(Vars.findSize<string>(D))-1;
                list.Add(D[r]);
            }
            else
            {
                list.Add("");
            }

            if(true)// always preform this line of code. put in if statement for easy of reading and shortening
            {
                int meta = 0;
                if(lv > 3)
                {
                    meta += 2;
                }
                if (lv > 10)
                {
                    meta ++;
                }
                if (lv > 17)
                {
                    meta++;
                }

                List<string> M = obj["MetaMagic"]
                                .Select(t => (string)t).ToList();

                int size = Vars.findSize<string>(M);

                for (int i = 0; i < meta; i++)
                {
                    r = Rolling.RollD(size) - 1;
                    string value = M[r];
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
