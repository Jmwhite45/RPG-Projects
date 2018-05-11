using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPG_character_sheet_randomizer.Vars;
using static RPG_character_sheet_randomizer.Vars.GAME;
using static RPG_character_sheet_randomizer.Vars.CLASSES;

namespace RPG_character_sheet_randomizer
{
    class HPGold
    {
        public static int HPDice = 0;
        public static int GoldDice = 0;

        public static void setGoldDice(GAME game, CLASSES Class)
        {
           /* if (game == PATHFINDER)
            {
                //3
                if ((Class == 1)|| (Class == 2)|| (Class == 10)|| (Class == 13)|| (Class == 14)|| (Class == 14) || (Class == 16) || (Class == 17) || (Class == 18) || (Class == 22) || (Class == 24) || (Class == 25) || (Class == 27))
                {
                    GoldDice = 3;
                }               
                    //4
                else if ((Class == 3)|| (Class == 15))
                {
                    GoldDice = 4;
                }
                //2
                else if ((Class == 4)|| (Class == 9)|| (Class == 11)|| (Class == 12)|| (Class == 26))
                {
                    GoldDice = 2;
                }
                //5
                else if ((Class == 5)|| (Class == 7)|| (Class == 8)|| (Class == 19)|| (Class == 20)|| (Class == 21) || (Class == 23) || (Class == 28))  {
                    GoldDice = 5;
                }
             
                //1
                else if (Class == 6)
                {
                    GoldDice = 1;
                }
            }*/
            if (game == DND5e)
            {
                if((Class == BARBARIAN))
                {
                    GoldDice = 2;
                }
                else if(Class == SORCERER)
                {
                    GoldDice = 3;
                }
                else if((Class == ROGUE)||(Class == WARLOCK)||(Class == WIZARD))
                {
                    GoldDice = 4;
                }
                else
                {
                    GoldDice = 5;
                }
            }
        }
        public static void setHPDice(GAME game, CLASSES Class)
        {
            if(game == PATHFINDER)
            {/*
                //12
                if (Class == 1)
                {
                    HPDice = 12;
                }

                //8
                else if ((Class == 2) || (Class == 3) || (Class == 4) || (Class == 6)|| (Class == 9)|| (Class == 15) || (Class == 16) || (Class == 17) || (Class == 18) || (Class == 21) || (Class == 22) || (Class == 24) || (Class == 25) || (Class == 26))
                {
                    HPDice = 8;
                }

                //10
                else if ((Class == 5)|| (Class == 7)|| (Class == 8)|| (Class == 13)|| (Class == 14)||(Class == 19) || (Class == 20) || (Class == 23) || (Class == 28))
                {
                    HPDice = 10;
                }
                //6
                else if ((Class == 10)|| (Class == 11)|| (Class == 12)|| (Class == 27))
                {
                    HPDice = 6;
                }*/
            }
            else if(game == DND5e)
            {
                // 12 barbarian
                //8 bard cleric druid monk rogue warlock
                //10 fighter paladin ranger
                //6 sorcerer wizard
                if (Class == BARBARIAN)
                {
                    HPDice = 12;
                }
                else if ((Class == BARD) || (Class == CLERIC) || (Class == DRUID) || (Class == MONK) || (Class == ROGUE) || (Class == WARLOCK))
                {
                    HPDice = 8;
                }
                else if ((Class == FIGHTER) || (Class == PALADIN) || (Class == RANGER))
                {
                    HPDice = 10;
                }
                else if ((Class == SORCERER) || (Class == WIZARD))
                {
                    HPDice = 6;
                }
            }
        }
        public static int RollHP(GAME game, CLASSES Class, int lv)
        {
            setHPDice(game, Class);

            int HP = HPDice;
            for (int i = 2; i <= lv; i++)
            {
                HP += Rolling.RollD(HPDice);
            }
            return HP;
        }
        public static int RollGold(GAME game, CLASSES Class)
        {
            setGoldDice(game, Class);
            int Dice = 4;
            int multiplier = 10;
            int Gold = 0;

            if (game == PATHFINDER)
            {
                Dice = 6;
            }
            if(game == DND5e)
            {
                if (Class == MONK)
                {
                    multiplier = 1;
                }
            }


            for (int i = 1; i <= GoldDice; i++)
            {
                
                Gold += (multiplier * Rolling.RollD(Dice));
            }
            return Gold;
        }

        public static void DisplayGold(int i)
        {
            frmref.GoldOutput.Text = i.ToString();
        }
        public static void DisplayHP(int i)
        {
            frmref.HPoutput.Text = i.ToString();
        }
    }
}
