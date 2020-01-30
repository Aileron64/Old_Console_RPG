using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGClass
{
    public class Imp : AICharacter
    {
        public Imp()
        {
            Name = "Spiteful Imp";
            CurrentHealth = 55;
            MaxHealth = 60;
            IsAlive = true;
            Strength = 0;
            Defence = 6;
            AttackDamage = Strength;
            Gold = 17;
            AIattack = 12;
            AIdefend = 2;
        }

        public override int CalculateDamage(Character target)
        {
            return MaxHealth - CurrentHealth;
        }


    }
}
