using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Json;
using static System.IO.File;
using Newtonsoft.Json;
using static RPG_character_sheet_randomizer.Vars;
using static RPG_character_sheet_randomizer.Vars.GAME;
using static RPG_character_sheet_randomizer.Vars.CLASSES;
using Newtonsoft.Json.Linq;
using System.IO;
using RPG_character_sheet_randomizer.ClassTypes;

/* subclass array style
 * 
 * 1 subclass
 * 2-> other information
 * 
 * other informations style sorted by class
 * Generic:
 * 2-> that subclass's or classes choices(no spells yet)
 * 
 * Ranger:
 * 2 ranger arch
 * 3,4,5 fav enemy(empty if none)
 * 6,7,8 fav terrain(empty if none)
 * rest is hunter only
 * 9 Hunters Prey
 * 10 Defensive Tactic
 * 11 Multiattack
 * 12 Superior Defense
 * 
 * sorcerer:
 * 2 draconic bloodline (empty if none)
 * 3-> meta magic
 * 
 * warlock:
 * 2 patreon
 * 3-> invocations
*/

namespace RPG_character_sheet_randomizer
{
    class Class
    {
        //public static RpgRndCharGen frmref;

        public static List<string> CollectClasses(GAME Game)
        {
            List<string> Classes = new List<string>();
            if (Game == DND5e)
            {
                Classes = D5Core["Class"]
                               .Select(t => (string)t).ToList();
            }
            else if(Game == PATHFINDER)
            {
                Classes = PathCore["Class"]
                                .Select(t => (string)t).ToList();
            }

            return Classes;

        }

        public static string[] DisplayClass(CLASSES C, int lv, GAME Game)
        {
            string[] selectedClass = new string[1];
            if(Game == DND5e)
            {
                selectedClass = DisplayClassDnD(C, lv);
            }
            else if (Game == PATHFINDER)
            {
                selectedClass = DisplayClassPath(C, lv);
            }

            return selectedClass;
        }
        
        public static CLASSES RollClass(GAME game)
        {
            List<string> Classes = CollectClasses(game);
            int count = Vars.findSize<string>(Classes);
            int roll = Rolling.RollD(count);

            if(frmref.DevClassNum.Value != 0)
            {
                roll = Convert.ToInt32(frmref.DevClassNum.Value);
            }

            //    if (frmref.DevRaceNum.Value > 0)
            //    {
            //        roll = (CLASSES)Convert.ToInt32(frmref.DevRaceNum.Value);
            //    }

            CLASSES Ret = (CLASSES)Convert.ToInt32(roll);

            return Ret;
        }

        public static void ChangeClassImage(CLASSES C, GAME game)
        {
            frmref.ClassImage.Width = 293;
            frmref.ClassImage.Height = 503;
            if (game == PATHFINDER)//pathfinder
            {
                if (C == BARBARIAN)
                {
                    frmref.ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Barbarian;
                }
                else if (C == BARD)
                {
                    frmref.ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Bard;
                }
                else if (C == CLERIC)
                {
                    frmref.ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Cleric;
                }
                else if (C == DRUID)
                {
                    frmref.ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Druid;
                }
                else if (C == FIGHTER)
                {
                    frmref.ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Fighter;
                }
                else if (C == MONK)
                {
                    frmref.ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Monk;
                }
                else if (C == PALADIN)
                {
                    frmref.ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Palidin;
                }
                else if (C == RANGER)
                {
                    frmref.ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Ranger;
                }
                else if (C == ROGUE)
                {
                    frmref.ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Rogue;
                }
                else if (C == SORCERER)
                {
                    frmref.ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Sorcerer;
                }
                else if (C == WIZARD)
                {
                    frmref.ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Wizard;
                }
                else if (C == ARCANIST)
                {
                    frmref.ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Arcanist;
                }
                else if (C == BLOODRAGER)
                {
                    frmref.ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Bloodrager;
                }
                else if (C == BRAWLER)
                {
                    frmref.ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Brawler;
                }
                else if (C == HUNTER)
                {
                    frmref.ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Hunter;
                }
                else if (C == INVESTIGATOR)
                {
                    frmref.ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Invesigater;
                }
                else if (C == SHAMAN)
                {
                    frmref.ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Shaman;
                }
                else if (C == SKALD)
                {
                    frmref.ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Skald;
                }
                else if (C == SLAYER)
                {
                    frmref.ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Slayer;
                }
                else if (C == SWASHBUCKLER)
                {
                    frmref.ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Swashbuckler;
                }
                else if (C == WARPRIEST)
                {
                    frmref.ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Warpriest;
                }
                else if (C == ALCHEMIST)
                {
                    frmref.ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Alchestist;
                }
                else if (C == CAVALIER)
                {
                    frmref.ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Cavalier;
                }
                else if (C == INQUISITOR)
                {
                    frmref.ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Inguisitor;
                }
                else if (C == ORACLE)
                {
                    frmref.ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Oracle;
                }
                else if (C == SUMMONER)
                {
                    frmref.ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Summoner;
                }
                else if (C == WITCH)
                {
                    frmref.ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Witch;
                }
            }
            /*  else if(game == 2)
              {
                  if(C == 1)
                  {
                      ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Dbarbarian;
                  }
                  else if(C == 2)
                  {
                      ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Dbard;
                  }
                  else if (C == 3)
                  {
                      ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.DCleric;
                      ClassImage.Width = 500;
                  }
                  else if (C == 4)
                  {
                      ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.DDruid;
                      ClassImage.Width = 350;
                  }
                  else if (C == 5)
                  {
                      ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.DFighter;
                  }
                  else if (C == 6)
                  {
                      ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Dmonk;
                      // this is a pathfinder image
                  }
                  else if (C == 7)
                  {
                      ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Dpaladin;
                      ClassImage.Width = 520;
                  }
                  else if (C == 8)
                  {
                      ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Dranger;
                  }
                  else if (C == 9)
                  {
                      ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.DRogue;
                  }
                  else if (C == 10)
                  {
                      ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Dsorcerer;
                      // this is a pathfinder image
                  }
                  else if (C == 11)
                  {
                      ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Dwarlock;
                  }
                  else if (C == 12)
                  {
                      ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Wizard1;
                      ClassImage.Width = 225;
                  }
                  else if (C == 13)
                  {
                     ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Dartificer;
                  }
                  else if (C == 14)
                  {
                     ClassImage.BackgroundImage = RPG_character_sheet_randomizer.Properties.Resources.Psionics;
                  }
              }*/
        }

        private static string[] DisplayClassDnD(CLASSES C, int lv)
        {
            List<string> Classes = CollectClasses(DND5e);

            int iclass = (int)C-1;

            string[] subclass = getSubClassDnD(C, lv); 
           frmref.ClassOutput.Text = Classes[iclass]+"- "+subclass[0];
            frmref.ClassPowers.Text = "Class Powers:" + System.Environment.NewLine;
                // add 2
            for (int i =1; i<subclass.Count(); i++)
            {
                if((C == BARBARIAN)&&(i == 1))
                {
                    frmref.ClassPowers.Text += "Totem(s): " + System.Environment.NewLine + subclass[i] ;
                }
                else if ((C == FIGHTER) && (i == 1))
                {
                    frmref.ClassPowers.Text += "Manuver(s): " + System.Environment.NewLine + subclass[i] ;
                }
                else if ((C == MONK) && (i == 1))
                {
                    frmref.ClassPowers.Text += "Discipline(s): " + System.Environment.NewLine + subclass[i] ;
                }
                else if ((C == RANGER)&&((i >=1)&&(i<=3)))
                {
                    if (subclass[i] != "")
                    {
                        frmref.ClassPowers.Text += "Favored Enemy: " +  subclass[i] + System.Environment.NewLine;
                    }
                }
                else if ((C == RANGER) && ((i >= 4) && (i <= 6)))
                {
                    if (subclass[i] != "")
                    {
                        frmref.ClassPowers.Text += "Favored Terrain: " + subclass[i] + System.Environment.NewLine;
                    }
                }
                else if((C == SORCERER) && (i == 1))
                {
                    if (subclass[i] != "")
                    {
                        frmref.ClassPowers.Text += "Dragon Type: " + System.Environment.NewLine + subclass[i] + System.Environment.NewLine + System.Environment.NewLine;
                    }
                }
                else if((C == SORCERER)&&(i == 2))
                {
                    frmref.ClassPowers.Text += "MetaMagic: " + System.Environment.NewLine + subclass[i] ;
                }
                else if ((C == WARLOCK) && (i == 1))
                {
                    frmref.ClassPowers.Text += "Patreon: " + System.Environment.NewLine + subclass[i] + System.Environment.NewLine;
                }
                else if ((C == WARLOCK) && (i == 2))
                {
                    frmref.ClassPowers.Text += "Invocations: " + System.Environment.NewLine + subclass[i] ;
                }
                else
                {
                    frmref.ClassPowers.Text += System.Environment.NewLine + subclass[i] ;
                }
                
            }

            ChangeClassImage(C, DND5e);

            return subclass;
        }

        private static string[] DisplayClassPath(CLASSES C, int lv)
        {
            List<string> Classes = CollectClasses(DND5e);
            string[] subclass = getSubClassPath(C, lv);
            int iclass = (int)C - 1;
            frmref.ClassOutput.Text = Classes[iclass];
            frmref.ClassPowers.Text = "Class Powers:";

            return subclass;
        }
        private static string[] getSubClassPath(CLASSES C, int lv)
        {
            string[] Sub = new string[20];

            if (C == BARBARIAN)
            {
                Sub = Barbarian.getPath(lv);
            }
            else if (C == BARD)
            {
                Sub = Bard.getPath(lv);
            }
            else if (C == CLERIC)
            {
               // Sub = Cleric.getPath();
            }
            else if (C == DRUID)
            {
               // Sub = Druid.getPath();
            }
            else if (C == FIGHTER)
            {
                //Sub = Fighter.getPath(D5Core, lv);
            }
            else if (C == MONK)
            {
                //Sub = Monk.getPath(D5Core, lv);
            }
            else if (C == PALADIN)
            {
               // Sub = Paladin.getPath(D5Core);
            }
            else if (C == RANGER)
            {
                //Sub = Ranger.getPath(D5Core, lv);
            }
            else if (C == ROGUE)
            {
               // Sub = Rogue.getPath(D5Core);
            }
            else if (C == SORCERER)
            {
              //  Sub = Sorcerer.getPath(D5Core, lv);
            }
            else if (C == WIZARD)
            {
              //  Sub = Wizard.getPath(D5Core);
            }

            Sub = Vars.shorten<string>(Sub);

            return Sub;
        }
        private static string[] getSubClassDnD(CLASSES C, int lv)
        {
            string[] Sub = new string[20];// may need to change temp size

            if(C == BARBARIAN)
            {
                Sub = Barbarian.getDnD(lv);
            }
            else if(C == BARD)
            {
                Sub = Bard.getDnD();
            }
            else if(C == CLERIC)
            {
                Sub = Cleric.getDnD(D5Core);
            }
            else if(C == DRUID)
            {
                Sub = Druid.getDnD(D5Core);
            }
            else if(C == FIGHTER)
            {
                Sub = Fighter.getDnD(D5Core, lv);
            }
            else if(C == MONK)
            {
                Sub = Monk.getDnD(D5Core, lv);
            }
            else if(C == PALADIN)
            {
                Sub = Paladin.getDnD(D5Core);
            }
            else if(C == RANGER)
            {
                Sub = Ranger.getDnD(D5Core, lv);
            }
            else if(C == ROGUE)
            {
                Sub = Rogue.getDnD(D5Core);
            }
            else if(C == SORCERER)
            {
                Sub = Sorcerer.getDnD(D5Core, lv);
            }
            else if(C == WARLOCK)
            {
                Sub = Warlock.getDnD(D5Core, lv);
            }
            else if(C == WIZARD)
            {
                Sub = Wizard.getDnD(D5Core);
            }

            Sub = Vars.shorten<string>(Sub);

            return Sub;
        }
    }
}
