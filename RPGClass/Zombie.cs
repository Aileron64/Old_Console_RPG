using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGClass
{
    public class Zombie : AICharacter
    {
        public Zombie()
        {
            Name = "Zombie";
            CurrentHealth = 110;
            MaxHealth = 110;
            IsAlive = true;
            Strength = 20;
            Defence = 0;
            AttackDamage = Strength;
            Gold = 21;
            AIattack = 6;
            AIdefend = 5;
        }

        public override void ProcessChoice(string choice, Character defender)
        {
            switch (choice)
            {
                case "A":
                case "a":
                    Console.WriteLine();
                    Console.WriteLine("{0} attacks!", Name);
                    int damage = CalculateDamage(defender);
                    defender.CurrentHealth -= damage;
                    Console.WriteLine("{0} hits {1} for {2} points of damage!\n",
                        Name, defender.Name, damage);
                    break;

                case "D":
                case "d":
                    Console.WriteLine();
                    Console.WriteLine("{0} wanders aimlessly", Name);
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("\nHint: Enter the first letter of your choice");
                    Console.ReadLine();
                    break;
            }
        }

        public override void ChangeStance(string choice)
        {
            switch (choice)
            {
                default: InOffensiveStance = true;
                    InDefensiveStance = false;
                    break;
            }
        }
    }
}

