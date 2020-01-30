using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGClass
{
    public class Baby_Dragon : AICharacter
    {
        public Baby_Dragon()
        {
            Name = "Baby Dragon";
            CurrentHealth = 40;
            MaxHealth = 40;
            IsAlive = true;
            Strength = 35;
            Defence = 0;
            AttackDamage = Strength;
            Gold = 47;
            AIattack = 6;
            AIdefend = 1;
        }
    }
}
