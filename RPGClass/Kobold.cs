using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGClass
{
    public class Kobold : AICharacter
    {
        public Kobold()
        {
            Name = "Kobold";
            CurrentHealth = 50;
            MaxHealth = 50;
            IsAlive = true;
            Strength = 15;
            Defence = 5;
            AttackDamage = Strength;
            Gold = 11;
            AIattack = 7;
            AIdefend = 3;
        }




    }
}
