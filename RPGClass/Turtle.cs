using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGClass
{
    public class Turtle : AICharacter
    {
            public Turtle()
        {
            Name = "Turtle Warrior";
            CurrentHealth = 140;
            MaxHealth = 140;
            IsAlive = true;
            Strength = 20;
            Defence = 10;
            AttackDamage = Strength;
            Gold = 32;
            AIattack = 12;
            AIdefend = 8;
        }

    }
}
