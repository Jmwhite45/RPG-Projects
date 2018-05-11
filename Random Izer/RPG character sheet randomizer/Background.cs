using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPG_character_sheet_randomizer.Vars;
using static RPG_character_sheet_randomizer.Vars.GAME;


/*
 background array format

    1 background
    2 trait
    3 Ideal
    4 Bond
    5 Flaw
    6 Special
*/
namespace RPG_character_sheet_randomizer
{
    class Background
    {
        public static int[] RollBackground(GAME G)
        {
            List<string> backgrounds = collectBackgrounds(G);

            int[] background = new int[6];
            background[0] = Rolling.RollD(findSize<string>(backgrounds));
            int back = background[0];

            if(background[0] == 19)
            {
                background[1] = Rolling.RollD(6); //6
            }
            else
            {
                background[1] = Rolling.RollD(8); //6
            }

            background[2] = Rolling.RollD(6); //6
            background[3] = Rolling.RollD(6); //6
            background[4] = Rolling.RollD(6); //6

            if(back == 2)
            {
                background[5] = Rolling.RollD(6);
            }
            else if((back == 3)||(back == 7))
            {
                background[5] = Rolling.RollD(8);
            }
            else if ((back == 4) || (back == 5) ||(back == 9)||(back == 10))
            {
                background[5] = Rolling.RollD(10);
            }
            else if (back == 6)
            {
                background[5] = Rolling.RollD(20);
            }
            else
            {
                background[5] = 0;
            }
            return background;
        }


        public static List<string> collectBackgrounds(GAME game)
        {
            List<string> backgrounds = new List<string>();
            if (game == DND5e)
            {
                backgrounds = Vars.D5Core["Background"]
                               .Select(t => (string)t).ToList();
                if (frmref.CheckDnDtSCAG.Checked == true)
                {
                    List<string> add = Vars.D5Swords["Background"]
                                   .Select(t => (string)t).ToList();
                  backgrounds.AddRange(add);
                }
            }

            return backgrounds;
        }
        public static void displayBackground(int[] background, GAME G)
        {
            List<string> backgrounds = collectBackgrounds(G);

            frmref.BackgroundOutput.Text = backgrounds[background[0]-1];
            frmref.TraitOutput.Text = background[1].ToString();
            frmref.IdealOutput.Text = background[2].ToString();
            frmref.BondOutput.Text = background[3].ToString();
            frmref.FlawOutput.Text = background[4].ToString();
            
            displayBackgroundSpecial(background[1], background[5]);
        }

        public static void displayBackgroundSpecial(int Background, int BackNum)//1,6
        {
            if (Background == 2)
            {
                frmref.BGRollOutput.Text = " scam: " + BackNum;
            }
            else if (Background == 3)
            {
                frmref.BGRollOutput.Text = " Specialty: " + BackNum;
            }
            else if (Background == 4)
            {
                frmref.BGRollOutput.Text = " Routine: " + BackNum;
            }
            else if (Background == 5)
            {
                frmref.BGRollOutput.Text = " Defining Event: " + BackNum;
            }
            else if (Background == 6)
            {
                frmref.BGRollOutput.Text = " Guild Business: " + BackNum;
            }
            else if (Background == 7)
            {
                frmref.BGRollOutput.Text = " Life of Secultion: " + BackNum;
            }
            else if (Background == 9)
            {
                frmref.BGRollOutput.Text = " Origin: " + BackNum;
            }
            else if (Background == 10)
            {
                frmref.BGRollOutput.Text = " Specialty: " + BackNum;
            }
            else if (Background == 12)
            {
                frmref.BGRollOutput.Text = " Specialty: " + BackNum;
            }
            else if (Background == 20)
            {
                frmref.BGRollOutput.Text = " Inheritace: " + BackNum;
            }
            else
            {
                frmref.BGRollOutput.Text = "";
            }
        }
    }
}
