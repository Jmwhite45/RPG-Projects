using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPG_character_sheet_randomizer.Vars;
using static RPG_character_sheet_randomizer.Vars.ROLLS;

namespace RPG_character_sheet_randomizer
{
    class Rolling
    {

        private static readonly Random getrandom = new Random();
        private static readonly object syncLock = new object();

        public static int RollD(int Dice)
        {
            lock (syncLock)
            { // synchronize
                return getrandom.Next(1, Dice + 1);
            }
        }
        public static int[] RollStats(ROLLS roll)//This will roll the Str, Dex, Wis... stats
        {
            int iNextStat;
            int[] Stats = new int[6];
            LinkedList<int> Rolls = new LinkedList<int>();

            if (roll == ROLL4D6)// runs code for if you are doing 4d6 Minus the lowest
            {

                for (int i = 0; i <= 5; i++)//runs the code 6 times(1 for each stat)
                {
                    for (int i2 = 1; i2 <= 4; i2++)//Does the rolls and adds them to a list
                    {
                        Rolls.AddLast(RollD(6));
                    }
                    iNextStat = Rolls.Sum();// adds the numbers of the list
                    iNextStat = iNextStat - Rolls.Min();// sub tracts the Lowest one                    

                    Stats[i] = iNextStat;// adds The stat to the list
                    while (Rolls.First != null)//Removes all numbers from List Rolls
                    {
                        Rolls.RemoveFirst();
                    }
                }

            }
            else if (roll == ROLL3D6)
            {
                for (int i = 1; i <= 6; i++)//runs the code 6 times(1 for each stat)
                {

                    for (int i2 = 1; i2 <= 3; i2++)//Does the rolls and adds them to a list
                    {
                        Rolls.AddLast(RollD(6));
                    }
                    iNextStat = Rolls.Sum();// adds the numbers of the list       

                    Stats[i] = iNextStat;// adds The stat to the list
                    while (Rolls.First != null)//Removes all numbers from List Rolls
                    {
                        Rolls.RemoveFirst();
                    }
                }
            }
            return Stats;//gives you a list of 6 numbers 
        }

        public static int[] findMods(int[] stats)
        {
            int size = stats.Length;

            int[] mods = new int[size];

            for(int i= 0; i< stats.Length; i++)
            {
                mods[i] = Convert.ToInt16((Convert.ToDouble(stats[i]) / 2.1)-5);
            }
            return mods;
        }

        public static void DisplayStats(int[] stats, int[] mods)
        { 
            frmref.StrOutput.Text = stats[0] + "(" + mods[0] + ")";
            frmref.DexOutput.Text = stats[1] + "(" + mods[1] + ")";
            frmref.ConOutput.Text = stats[2] + "(" + mods[2] + ")";
            frmref.IntOutput.Text = stats[3] + "(" + mods[3] + ")";
            frmref.WisOutput.Text = stats[4] + "(" + mods[4] + ")";
            frmref.ChaOutput.Text = stats[5] + "(" + mods[5] + ")";
        }
    }
}
