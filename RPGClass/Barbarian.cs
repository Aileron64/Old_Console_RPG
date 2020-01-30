using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGClass
{
    public class Barbarian : AICharacter
    {
            private Random rand = new Random();
            private bool SuperAttack = false;
            public Barbarian()
        {
            Name = "Alaric The Barbarian";
            CurrentHealth = 320;
            MaxHealth = 320;
            IsAlive = true;
            Strength = 40;
            Defence = 10;
            AttackDamage = Strength;
            Gold = 1000;
        }

        public override string GetBattleChoice() 
        {
            int num = rand.Next(1, 6);
            if (num > 4)
            {
                return "A";
            }
            else if (num > 1)
            {
                return "S";
            }
            else
            {
                return "D";
            }
        }

        public override void ProcessChoice(string choice, Character defender)
        {
            if (SuperAttack != true)
            {
                switch (choice)
                {
                    case "A":
                        Console.WriteLine();
                        Console.WriteLine("{0} attacks!", Name);
                        int damage = CalculateDamage(defender);
                        defender.CurrentHealth -= damage;
                        Console.WriteLine("{0} hits {1} for {2} points of damage!\n",
                            Name, defender.Name, damage);
                        break;

                    case "D":
                        Console.WriteLine();
                        Console.WriteLine("{0} defends!", Name);
                        break;

                    case "S": 
                        Console.WriteLine("Alaric roars as he gather might for his ultimate attack");
                        SuperAttack = true;
                        break;
                }
            }
            else
            {
                int damage = 0;
                Console.WriteLine();
                Console.WriteLine("Alaric unleashes his ultimate attack!", Name);   //The Idea is to defend when he does this
                if (defender.InDefensiveStance == false)
                {
                    damage = CalculateDamage(defender) * 5;
                }
                else
                {
                    damage = CalculateDamage(defender);
                }
                defender.CurrentHealth -= damage;
                Console.WriteLine("Alaric hits {1} for {2} points of damage!\n",
                    Name, defender.Name, damage);
                SuperAttack = false;
            }
        }
    }
}
