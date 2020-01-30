using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGClass
{
    public class Ogre : AICharacter
    {
        public Ogre()
        {
            Name = "Ogre";
            CurrentHealth = 120;
            MaxHealth = 120;
            IsAlive = true;
            Strength = 40;
            Defence = 2;
            AttackDamage = Strength;
            Gold = 47;
            AIattack = 10;
            AIdefend = 4;
        }
    }
}
