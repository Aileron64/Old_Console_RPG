using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGClass
{
    public class Treasure_Goblin : AICharacter
    {
        private int count = 2;
        public Treasure_Goblin()
        {
            Name = "Treasure Goblin";
            CurrentHealth = 50;
            MaxHealth = 50;
            IsAlive = true;
            Strength = 0;
            Defence = 6;
            AttackDamage = Strength;
            Gold = 120;
            AIattack = 12;
            AIdefend = 2;
        }

        public override void ProcessChoice(string choice, Character defender)
        {
            switch (choice)
            {
                default:
                    switch (count)
                    {
                        case 2:
                            Console.WriteLine("\nThe Goblin panics and starts to open a portal to escape\n");
                            break;
                        case 1:
                            Console.WriteLine("\nThe Goblin's portal has almost stabilized\n");
                            break;
                        case 0:
                            Console.WriteLine("\nThe Goblin escapes through his portal");
                            CurrentHealth = 0;
                            IsAlive = false;
                            Gold = 0;
                            break;
                    }
                    count--;
                    break;
            }
        }
    }
}
