using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPGClass;

namespace Timed_Lab_12___Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            bool game = true;
            Character hero = new Hero();
            Arena arena = new Arena();
            ((Hero)hero).Intro();

            while (game == true) //The Game Loop
            {
                Console.Clear();
                switch (((Hero)hero).GetOptionChoice())     //Main Option Menu
                {
                    case "a":
                    case "A":                   //Battle Option
                        bool fighting = true;
                        string choice = arena.EnterTheArena();        //Choice Enemy
                           
                                Character[] Enemys = arena.GetEnemys(choice);
                                while (fighting == true)
                                {
                                    Console.Clear();
                                    bool HeroVictory = ((Hero)hero).Battle(Enemys);
                                    if (HeroVictory == true)
                                        break;
                                    foreach (Character Enemy in Enemys)
                                    {
                                        if (Enemy.IsAlive == true)
                                        {
                                            string aI = Enemy.GetBattleChoice();
                                            Enemy.ChangeStance(aI);
                                            Enemy.ProcessChoice(aI, hero); 
                                        }
                                    }
                                    Console.ReadLine();
                                    game = ((Hero)hero).IfAlive();
                                    fighting = ((Hero)hero).IfAlive();
                                }
                                if ((choice == "a" | choice == "b") && (hero.Fled == false)) //checks if boss is killed
                                    arena.AlaricIsAlive = false;
                                hero.Fled = false;
                            break;
                                
                    case "s":   //Shop Option
                    case "S":
                        Console.Clear();
                        game = ((Hero)hero).Shop();
                        break;

                    case "i":   //Inn Option
                    case "I":
                        Console.Clear();
                        ((Hero)hero).Inn();
                        break;

                    case "v":   //Veiw Status Option
                    case "V":
                        ((Hero)hero).View();
                        break;

                    case "q":   
                    case "Q":
                        Console.WriteLine("\nAre you sure you want to quit? (Y/N)");
                        string awnser = Console.ReadLine(); //how to quit
                        if (awnser == "y" | awnser == "Y")
                            game = false; 
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("\nHint: Enter the first letter of your choice");
                        Console.ReadLine(); //An error message and help combined into one!
                        break;
                }
            }
        }
    }
}
