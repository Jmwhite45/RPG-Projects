using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBattleTracker
{
    public interface Character
    {
       int GetInit();
       string GetName();
        void addDamage(int Damage);
    }
}
