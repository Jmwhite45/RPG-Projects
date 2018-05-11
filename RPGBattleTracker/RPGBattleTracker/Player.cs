using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBattleTracker
{
    public class Player
    {
        private int MaxHP;
        private int Level;
        private int CurrentHP;
        private int initiative;
        private string race;
        private string Class;
        private string Name;
        private string PlayerName;
        private string CharacterNotes;
        private int PassivePerception;

        public Player(int L, int HP, string R, string C, string N, string P, string CN, int PP)
        {
            MaxHP = HP;
            Level = L;
            CurrentHP = HP;
            race = R;
            Class = C;
            Name = N;
            PlayerName = P;
            CharacterNotes = CN;
            PassivePerception = PP;
        }

        public int getHP()
        {
            return CurrentHP;
        }

        public string getName()
        {
            return Name;
        }
        public string getPlayer()
        {
            return PlayerName;
        }

        public void setInit(int init)
        {
            initiative = init;
        }
        public int getInit()
        {
            return initiative;
        }
    }
}
