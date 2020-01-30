using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPGClass;

namespace Timed_Lab_12___Inheritance
{
    class Arena
    {
        Random rand = new Random();
        private bool firstTime = true;
        //private bool xenuIsAlive = true; //enemies I didn't have time to add
        private bool alaricIsAlive = true;
        //private bool steveIsAlive = true;
        
        //public bool XenuIsAlive
        //{
        //    get { return xenuIsAlive; }
        //    set { xenuIsAlive = value; }
        //}   
        public bool AlaricIsAlive
        {
            get { return alaricIsAlive; }
            set { alaricIsAlive = value; }
        }
        //public bool SteveIsAlive
        //{
        //    get { return steveIsAlive; }
        //    set { steveIsAlive = value; }
        //}



        public string EnterTheArena()
        {
            string r = "";
            while (true)
            {
                Console.Clear();
                if (alaricIsAlive == true)
                {
                    Console.WriteLine("\nWelcome to the Arena");
                    if (firstTime == true)
                    {
                        Console.WriteLine("\nIf your here to compete then you may choose to fight our champion,\n\n"
                            + "Or we could release some random monsters for you to fight");
                        firstTime = false;
                    }
                }
                else
                {
                    Console.WriteLine("\nWelcome Back Champ!");
                }
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\nWho do you want to fight?\n\n(R)andom Monsters");
                //if (xenuIsAlive == true)
                //    Console.WriteLine("(X)enu The Illusionist\t(500 Gold Prize)");
                if (alaricIsAlive == true)
                    Console.WriteLine("(A)laric The Barbarian\t(1000 Gold Prize)");
                //if (steveIsAlive == true)
                //    Console.WriteLine("(S)teve The Summoner\t(1500 Gold Prize)");
                Console.WriteLine("(N)evermind");
                r = Console.ReadLine();
                if (r == "a" | r == "A" | r == "r" | r == "R")
                    //| r == "x" | r == "X" | r == "s" | r == "S")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nHint: Enter the first letter of your choice");
                    Console.ReadLine();
                }
            }
            return r;
        } //Lets you pick what to fight

        public Character[] GetEnemys(string c)      //Creates Enemy to Fight
        {
            switch(c)
            {
                default:
                case "r":
                case "R":
                    Character[] r = new Character[(rand.Next(2, 5))];
                    for (int i = 0; i < r.Length; i++)
                    {
                        r[i] = GetRandomMonster();
                    }
                    return r;   
                    
                case "a":
                case "A":
                    Character[] a = {new Barbarian()};
                    return a;
            }
        }

        public Character GetRandomMonster()
        {
            Character result;           //Gets a random monster to fight
            switch (rand.Next(0, 9))
            {
                default:
                case 0:
                case 1:
                    result = new Kobold();
                    break;
                case 2:
                    result = new Bombomb();
                    break;             
                case 3:
                    result = new Ogre();
                    break;
                case 4:
                    result = new Imp();
                    break;
                case 5:
                    result = new Baby_Dragon();
                    break;
                case 6:
                    result = new Treasure_Goblin();
                    break;
                case 7:
                    result = new Turtle();
                    break;
                case 8:
                    result = new Zombie();
                    break;
            }
            return result;
        }
    }
}
