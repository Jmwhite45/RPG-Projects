using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPGBattleTracker.Vars;

namespace RPGBattleTracker
{
    class Damage
    {
        public DAMAGETYPE type;
        public int amount;

        public Damage(DAMAGETYPE Type, int Amount)
        {
            type = Type;
            amount = Amount;
        }

        override
        public string ToString()
        {
            return type.ToString() + " (" + amount.ToString() + ")";
        }
    }
}
