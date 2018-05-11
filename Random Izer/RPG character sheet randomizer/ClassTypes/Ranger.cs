using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace RPG_character_sheet_randomizer.ClassTypes
{
    class Ranger
    {
        public static string[] getDnD(JObject obj, int lv)
        {

            List<string> list = new List<string>();
            List<string> L = obj["Ranger"]
                            .Select(t => (string)t).ToList();
            int r = Rolling.RollD(Vars.findSize<string>(L))-1;
            string arch = L[r];
            list.Add(arch);
            int size = 0;
            //fav enemy
            if (true)// fav enemy
            {
                int favEnemy = 1;
                if (lv >= 6)
                {
                    favEnemy++;
                }
                if (lv >= 14)
                {
                    favEnemy++;
                }

                List<string> FE = obj["Favored Enemy"]
                                .Select(t => (string)t).ToList();
                size = Vars.findSize<string>(FE);
                for (int i = 0; i<3; i++)
                {
                    if(favEnemy > 0)
                    {
                        r = Rolling.RollD(size) - 1;
                        string value = FE[r];
                        if (Vars.isDuplicate(list, value) == false)
                        {
                            list.Add(value);
                            favEnemy--;
                        }
                        else
                        {
                            i--;
                        }
                    }
                    else
                    {
                        list.Add("");
                        favEnemy--;
                    }
                }
            }

            //fav terrain
            if (true)// fav terrain
            {
                int favTerrain = 1;
                if (lv >= 6)
                {
                    favTerrain++;
                }
                if (lv >= 14)
                {
                    favTerrain++;
                }
                List<string> FT = obj["Favored Terrain"]
                                .Select(t => (string)t).ToList();
                size = Vars.findSize<string>(FT);
                for (int i = 0; i < 3; i++)
                {
                    if (favTerrain > 0)
                    {
                        r = Rolling.RollD(size) - 1;
                        string value = FT[r];
                        if (Vars.isDuplicate(list, value) == false)
                        {
                            list.Add(value);
                            favTerrain--;
                        }
                        else
                        {
                            i--;
                        }
                    }
                    else
                    {
                        list.Add("");
                        favTerrain--;
                    }
                }
            }

            if (arch == "Hunter")
            {

                List<string> H = obj["Hunters Prey"]
                                .Select(t => (string)t).ToList();
                List<string> D = obj["Defensive Tactic"]
                                .Select(t => (string)t).ToList();
                List<string> M = obj["Multiattack"]
                                .Select(t => (string)t).ToList();
                List<string> S = obj["Superior Defense"]
                                .Select(t => (string)t).ToList();

                if (lv >= 3)
                {
                    r = Rolling.RollD(Vars.findSize<string>(H))-1;
                    list.Add(H[r]);
                }
                if(lv >= 7)
                {
                    r = Rolling.RollD(Vars.findSize<string>(D))-1;
                    list.Add(D[r]);
                }
                if(lv >= 11)
                {
                    r = Rolling.RollD(Vars.findSize<string>(M))-1;
                    list.Add(M[r]);
                }
                if(lv >= 15)
                {
                    r = Rolling.RollD(Vars.findSize<string>(S))-1;
                    list.Add(S[r]);
                }
            }

            string[] subclass = list.ToArray();
            return subclass;
        }
    }
}
