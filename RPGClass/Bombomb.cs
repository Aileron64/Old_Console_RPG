using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGClass
{
    public class Bombomb : AICharacter
    {
        private int timer = 5;
        public Bombomb()
        {
            Name = "Bombomb";
            CurrentHealth = 60;
            MaxHealth = 60;
            IsAlive = true;
            Defence = 5;
            AttackDamage = Strength;
            Gold = 25;
            AIattack = 7;
            AIdefend = 3;
        }

        public override void ProcessChoice(string choice, Character defender)
        {
            switch (choice)
            {
                default:
                    switch (timer)
                    {
                        case 5:
                            Console.WriteLine("The Bombomb sets it timer to 5\n");
                            break;
                        case 4:
                            Console.WriteLine("The Bombomb's timer counts down to 4\n");
                            break;
                        case 3:
                            Console.WriteLine("The Bombomb's timer counts down to 3\n");
                            break;
                        case 2:
                            Console.WriteLine("The Bombomb's timer counts down to 2\n");
                            break;
                        case 1:
                            Console.WriteLine("The Bombomb's timer counts down to 1\n");
                            break;
                        case 0:
                            Console.WriteLine("The Bombomb Selfdestructs dealing 200 Damage to " + defender.Name);
                            defender.CurrentHealth -= 200;
                            CurrentHealth = 0;
                            IsAlive = false;
                            break;
                    }
                    timer--;
                    break;
            }
        }
    }
}
