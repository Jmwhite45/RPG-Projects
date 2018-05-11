using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace RPG_character_sheet_randomizer.ClassTypes
{
    class Wizard
    {
        public static string[] getDnD(JObject obj)
        {

            List<string> list = new List<string>();
            List<string> L = obj["wizard"]
                            .Select(t => (string)t).ToList();

            int r = Rolling.RollD(Vars.findSize<string>(L))-1;
            list.Add(L[r]);

            string[] subclass = list.ToArray();
            return subclass;
        }
    }
}
