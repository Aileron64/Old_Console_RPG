using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGClass
{
    public class Hero : Character
    {
        public Hero()
        {
            Name = "Hero";
            CurrentHealth = 180;
            MaxHealth = 180;
            IsAlive = true;
            Strength = 30;
            Defence = 20;
            AttackDamage = Strength;
            Gold = 0;
        }

        private bool[] Items = new bool[8];     //Whether or not you own the Item
        private string[] ShopWares =            //Items
        {
        "(M)irror Shield: 50 Gold, --------------- + 10 Defence",
        "(S)word of One Thousand Truths: 100 Gold, + 10 Strength",
        "(D)iamond Armor: 150 Gold,--------------- + 20 Defence",
        "(B)atman's Utility Belt: 150 Gold, ------ + 10 Defence, + 10 Max Health",
        "(R)ing of Power: 200 Gold, -------------- + 10 Strength, + 20 Max Health",
        "(L)uigi's Hat: 250 Gold, ---------------- + 40 Max Health",
        "(F)airy in a Bottle: 300 Gold, ---------- Second Chance, (1 use)",
        "(C)ool Car: 1200 Gold, ------------------ Finishes the game",
        };

        public bool Shop() //The Shop
        {
            bool shopping = true;
            while (shopping == true)
            {
                Console.WriteLine("\nWhat would you like to buy?\t\t\t\t" + Gold + " Gold\n");
                for (int i = 0; i < Items.Length; i++)
                {
                    if (Items[i] == false)
                    {
                        Console.WriteLine(ShopWares[i]);
                    }
                }
                Console.WriteLine("(N)evermind");
                string choice = Console.ReadLine();
                Console.Clear();
                
                switch (choice)
                {
                    //(M)irror Shield: 50 Gold, + 5 Defence----------------------------------------------------
                    case "m":
                    case "M":
                        if (Items[0] == false)
                        {
                            if (Gold >= 50)
                            {
                                Console.WriteLine("\nYou bought the Mirror Shield\n\nYour defence has increased by 5!");
                                ShopWares[0] = "Mirror Shield";
                                Items[0] = true;
                                Gold -= 50;
                                Defence += 5;
                            }
                            else
                            {
                                Console.WriteLine("\nYou can't afford that");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nYou already own that item");
                        }
                        break;

                    //(S)word of One Thousand Truths: 100 Gold, + 10 Strength----------------------------------------
                    case "s":
                    case "S":
                        if (Items[1] == false)
                        {
                            if (Gold >= 100)
                            {
                                Console.WriteLine("\nYou bought the Sword of One Thousand Truths\n\nYour strength has increased by 10!");
                                ShopWares[1] = "Sword of One Thousand Truths";
                                Items[1] = true;
                                Gold -= 100;
                                Strength += 10;
                            }
                            else
                            {
                                Console.WriteLine("\nYou can't afford that");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nYou already own that item");
                        }
                        break;

                    //(D)iamond Armor: 150 Gold,+ 10 Defence-------------------------------------------------------
                    case "d":
                    case "D":
                        if (Items[2] == false)
                        {
                            if (Gold >= 150)
                            {
                                Console.WriteLine("\nYou bought Diamond Armor\n\nYour defence has increased by 10!");
                                ShopWares[2] = "Diamond Armor";
                                Items[2] = true;
                                Gold -= 150;
                                Defence += 10;
                            }
                            else
                            {
                                Console.WriteLine("\nYou can't afford that");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nYou already own that item");
                        }
                        break;


                    //(B)atman's Utility Belt: 150 Gold, + 10 Defence, + 10 Max Health--------------------
                    case "b":
                    case "B":
                        if (Items[3] == false)
                        {
                            if (Gold >= 150)
                            {
                                Console.WriteLine("\nYou bought Batman's Utility Belt!\n\nYour defence has increased by 10!\nYour max health has increased by 10!");
                                ShopWares[3] = "Batman's Utility Belt";
                                Items[3] = true;
                                Gold -= 150;
                                Defence += 10;
                                MaxHealth += 10;
                                CurrentHealth += 10;
                            }
                            else
                            {
                                Console.WriteLine("\nYou can't afford that");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nYou already own that item");
                        }
                        break;


                    //(R)ing of Power: 200 Gold, + 1- Attack, + 20 Max Health------------------------------------------------------------
                    case "r":
                    case "R":
                        if (Items[4] == false)
                        {
                            if (Gold >= 200)
                            {
                                Console.WriteLine("\nYou bought the Ring of Power\n\nYour strength has increased by 10!\nYour max health has increased by 20!");
                                ShopWares[4] = "Diamond Armor";
                                Items[4] = true;
                                Gold -= 200;
                                Strength += 10;
                                MaxHealth += 20;
                                CurrentHealth += 20;
                            }
                            else
                            {
                                Console.WriteLine("\nYou can't afford that");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nYou already own that item");
                        }
                        break;

                    //(L)uigi's Hat: 250 Gold, + 40 Max Health--------------------------------------------------
                    case "L":
                    case "l":
                        if (Items[5] == false)
                        {
                            if (Gold >= 250)
                            {
                                Console.WriteLine("\nYou bought Luigi's Hat!\n\nYour max health has increased by 40!");
                                ShopWares[5] = "Luigi's Hat";
                                Items[5] = true;
                                Gold -= 250;
                                MaxHealth += 40;
                                CurrentHealth += 40;
                            }
                            else
                            {
                                Console.WriteLine("\nYou can't afford that");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nYou already own that item");
                        }
                        break;

                    //"(F)airy in a Bottle: 200 Gold, --------------------------------------------------------------------
                    case "f":
                    case "F":
                        if (Items[6] == false)
                        {
                            if (Gold >= 300)
                            {
                                Console.WriteLine("\nYou bought a Fairy in a Bottle\n\nHopefully you don't have to use it!");
                                ShopWares[6] = "\nFairy in a Bottle";
                                Items[6] = true;
                                Gold -= 300;
                                Defence += 5;
                            }
                            else
                            {
                                Console.WriteLine("\nYou can't afford that");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nYou already own that item");
                        }
                        break;


                    //Cool Car----------------------------------------------------------------
                    case "c":
                    case "C":
                        if (Gold >= 1200)
                        {
                            Items[7] = true;
                            Console.Clear();
                            Console.WriteLine("\nCongratulations, You Did It!");
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("\nYou Finaly Have An Awseome Cool Car!");
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("\nHistory Will Remeber How These Events Came To Past!");
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("\nYou Win!");
                            Console.ReadLine();
                            shopping = false;
                        }
                        else
                        {
                            Console.WriteLine("\nYou can't afford that");
                        }
                        break;

                    case "":
                    case "n":
                    case "N":
                        Console.WriteLine("\nThank You, Come Again");
                        shopping = false;
                        break;
                    default:
                        Console.WriteLine("\nHint: Enter the first letter of your choice");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
            if (Items[7] == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string GetOptionChoice()
        {
            Console.WriteLine("\nWhere do you want to go?\t\t\t"
                + CurrentHealth + "/" + MaxHealth + " Hp\n(A)rena\t\t\t\t\t\t"
                + Gold + " Gold\n(S)hop\n(I)nn\n(V)eiw Items and Stats\n(Q)uit and give up");
            return Console.ReadLine();
        }//The Main Menu

        public void Inn()  /// Inn Meathod
        {
            Console.WriteLine("\nWould You Like To Stay At The Inn?\t\t" + Gold + " Gold\nThe Cost is 10 Gold (Y/N)");
            string awnser = Console.ReadLine();
            Console.Clear();
            if (awnser == "y" | awnser == "Y")
            {
                if (Gold >= 10)
                {
                    Console.WriteLine("\nYou spend the night at the Inn,\n\nHeath is restored to full\n");
                    CurrentHealth = MaxHealth;
                    Gold -= 10;
                }
                else
                {
                    Console.WriteLine("\nI'm sorry you don't have enough gold to stay here");
                }
            }
            else
            {
                Console.WriteLine("\nCome back if you change your mind");
            }
            Console.ReadLine();
        }

        public void View() //Displays stats and items
        {
            Console.Clear();
            Console.WriteLine("\n" + CurrentHealth + "/" + MaxHealth + " Health\n"
                + Gold + " Gold\n\n"
                + Strength + " Strength\n"
                + Defence + " Defence\n\nItems\n____\n\n");
            for (int i = 0; i < ShopWares.Length; i++)
            {
                if (Items[i] == true)
                {
                    Console.WriteLine(ShopWares[i]);
                }
            }
            Console.ReadLine();
        }

        public void Intro()
        {
            Console.WriteLine("\nWhat is the name of our Hero?");
            Name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\nYou have just turned 16 and recieved your dirvers licence\n\n"
                + "But unfortunately you don't have a car to drive, such a tragedy");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\nBut their is hope, because their is a really cool car for sale\n"
                + "\nin the shop nearby, and you know just how to make enough money to buy it...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\nBy fighting to death in the local Arena!"
                + "\n\nThis is definitely by far, the greatest idea you've ever had!");
            Console.ReadLine();
        } //Pointless intro segment

        public override string GetBattleChoice() 
        {
            Console.WriteLine("\nChoose an action:\n(A)ttack\n(D)efend\n(F)lee");
            return Console.ReadLine();
        }

        public override void PrintStatus()
        {
            Console.WriteLine("\nName: " + Name + "\t" + CurrentHealth + "/" + MaxHealth + "\n------------------------");
        }

        public bool Battle(Character[] Enemies)
        {
            if (VictoryCheck(Enemies) == true) //Check for posible victory
            {
                return true;
            }
            //Hero Attack Phase------------------------------------------------------
            int target = 0;
            int count = 0;

            PrintStatus();
            foreach (Character Enemy in Enemies)
            {
                count++;
            }

            foreach (Character Enemy in Enemies)
            {
                if (Enemy.IsAlive == true)
                {
                    Enemy.PrintStatus();
                }
            }

            string choice = GetBattleChoice();
            if (choice == "A" | choice == "a")
            {
                count = 0;
                Console.Clear();
                Console.WriteLine("\nWhat do you want to attack?\n");
                foreach (Character Enemy in Enemies)
                {
                    count++;
                    if (Enemy.IsAlive == true)
                    {
                        Console.WriteLine("(" + count + ") " + Enemy.Name + "  " + Enemy.CurrentHealth + "/" + Enemy.MaxHealth + " Hp");
                    }
                }
                target = Convert.ToInt32(Console.ReadLine());
                target--;
            }

            Console.Clear();
            ChangeStance(choice);
            ProcessChoice(choice, Enemies[target]);
            if (VictoryCheck(Enemies) == true) //Check for posible victory
            {
                return true;
            }
            else
            {
                return false;
            }
                

        }/////Hero Attack Phase

        public bool VictoryCheck(Character[] Enemies)
        {
            bool enemycheck = false;
            foreach (Character Enemy in Enemies)
            {
                if (Enemy.IsAlive == true)
                {
                    enemycheck = true;
                }
            }

            if (enemycheck == false)
            {
                int earnings = 0;
                for (int i = 0; i < Enemies.Length; i++)
                {
                    earnings += Enemies[i].Gold;
                }
                Console.WriteLine("You are Victorius!\n\nYou recieve " + earnings + " gold!");
                Gold += earnings;
                Console.ReadLine();
                return true;
            }
            else if (Fled == true)
            {
                Console.WriteLine("\nYou have fled the arena");
                Console.ReadLine();
                return true;
            }
            else
            {
                return false;
            }
        }/////////Checks if you won or fled

        public bool IfAlive()
        {
            if (IsAlive == true)
                return true;
            else
            {
                Console.Clear();
                Console.WriteLine("\nYou Have Fallen In Battle");
                Console.ReadLine();
                if (Items[6] == true)
                {
                    Console.Clear();
                    Console.WriteLine("\nWait....");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("\nYour Fairy in a Bottle is released to grant you a second chance"
                        + "\n\nYour Health is restored to full and the fight continues");
                    Console.ReadLine();
                    IsAlive = true;
                    CurrentHealth = MaxHealth;
                    return true;
                }
                else
                return false;
            }
        }///////////Checks if you died
    }
}
