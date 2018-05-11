using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBattleTracker
{
    public class NPC: Character
    {
        private int MaxHP;
        private int CR;
        private int CurrentHP;
        private int initiative;
        private string Type;
        private string Size;
        private string Name;
        private string CharacterNotes;

        public NPC()
        {
            Name = null;
        }

        public NPC(int HP, int cr, int I, string T, string S, string N, string CN)
        {
            MaxHP = HP;
            CR = cr;
            CurrentHP = HP;
            initiative = I;
            Type = T;
            Name = N;
            Size = S;
            CharacterNotes = CN;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetInit()
        {
            return initiative + Rolling.RollD(20);
        }

        public int GetCR()
        {
            return CR;
        }

        public int getMaxHP()
        {
            return MaxHP;
        }

        public int getCurrentHP()
        {
            return CurrentHP;
        }
    }
}
