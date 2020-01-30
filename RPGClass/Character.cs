using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGClass
{
    public class Character
    {
        private int currentHealth;     
        private Random rand = new Random();

        public virtual int CurrentHealth
        {
            get 
            { 
                return currentHealth;
            }
            set 
            { 
                if (value <= 0)
                {
                IsAlive = false;
                currentHealth = 0;
                }
                else
                {
                currentHealth = value; 
                }
            }
        }

        public string Name { get; set; }
        public bool IsAlive { get; set; }
        public int MaxHealth { get; set; }
        public int Gold { get; set; }
        public int Strength { get; set; }
        public int Defence { get; set; }
        public double AttackDamage { get; set; }
        public bool InOffensiveStance { get; set; }
        public bool InDefensiveStance { get; set; }
        public bool Fled { get; set; }

        public Character()
        {

        }

        public virtual void ChangeStance(string choice)
        {
            switch(choice)
            {
                case "A":
                case "a": InOffensiveStance = true;
                    InDefensiveStance = false;
                    break;
                case "D":
                case "d": InDefensiveStance = true;
                    InOffensiveStance = false;
                    break;
                case "F":
                case "f": InDefensiveStance = false;
                    InOffensiveStance = false;
                    break;
            }
        }

        public virtual int CalculateDamage(Character target)
        {
            double maxDamage = (AttackDamage * 1.25) - target.Defence;
            double minDamage = (AttackDamage * 0.75) - target.Defence;

            if (minDamage < 1.0)
            {
                minDamage = 1.0;
            }
            if (maxDamage < 1.0)
            {
                maxDamage = 1.0;
            }

            int value = rand.Next(Convert.ToInt32(minDamage), Convert.ToInt32((maxDamage + 1.0)));

            if (InOffensiveStance == true)
            {
                value = Convert.ToInt32(Convert.ToDouble(value) * 1.5);
            }

            if (target.InDefensiveStance == true)
            {
                value = Convert.ToInt32(Convert.ToDouble(value) * 0.5);
            }

            return value;
        }

        public virtual string GetBattleChoice()
        {
            return "";
        }

        public virtual void PrintStatus()
        {
            Console.WriteLine("Name: " + Name + "\t" + CurrentHealth + "/" + MaxHealth);
        }

        public virtual void ProcessChoice(string choice, Character defender)      
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
                    Console.WriteLine("{0} defends!", Name);
                    break;

                case "F":
                case "f":
                    int chance = rand.Next(0, 3);
                    if (chance > 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("{0} flees!", Name);
                        Fled = true;
                        IsAlive = true;
                    }
                    else
                    {
                        Console.WriteLine("\nCould not escape");
                    }
                    break;

                default:
                        Console.Clear();
                        Console.WriteLine("\nHint: Enter the first letter of your choice");
                        Console.ReadLine();
                        break;
            }
        }
    }
}
