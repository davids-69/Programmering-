using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {

            string weapon = Console.ReadLine();
            string playerName = Console.ReadLine();
            int pmaxDamage = 0;
            int pminDamage = 0;
            int enemyMaxDamage = 8;
            int enemyMinDamage = 3;
            int enemyHealth = 50;
            int playerHealth = 100;



            Random rnd = new Random();
            Console.WriteLine("What is your name?");
         
            Console.WriteLine($"Hello, {playerName}");
            Console.ReadKey();
            Console.WriteLine("welcome to my game");
            Console.ReadKey();
            Console.WriteLine("let me explain the rule of the game");
            Console.ReadKey();
            Console.WriteLine("you will be given a weapon and you will have to fight the enemy");

            Console.WriteLine("if you win you will get a prize");
            Console.WriteLine("if you lose you will die");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"{playerName} are you ready to play? (yes/no)");
            string answer = Console.ReadLine();
            {
                if (answer == "yes" || answer == "y" || answer == "Yes" || answer == "Y")
                {
                    Console.WriteLine("let's start the game");
                }
                else
                {
                    Console.WriteLine("goodbye");
                }
            }


            Console.WriteLine("good luck");
            Console.Clear();


            Console.WriteLine("you have two choices Sword or axe");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"You have a sword");
            Console.WriteLine("Now let's give your weapon some damage");
            
            Console.WriteLine($"Your {weapon} can do {pminDamage} min damage or {pmaxDamage} max damage");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"You have a Axe");
            Console.WriteLine("Now let's give your weapon some damage");
            
            Console.WriteLine($"Your Axe can do {pminDamage} min damage or {pmaxDamage} max damage");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Every Hero needs a health bar");
            Console.WriteLine("You start with 100 health");
            Console.WriteLine("Congrats");
            playerHealth = 100;
            Console.WriteLine($"You have {playerHealth} health");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Now you need to fight the enemy");
            Console.WriteLine("You will fight a goblin");
            enemyHealth = 50;
            Console.WriteLine($"The goblin has {enemyHealth} health");
            Console.WriteLine("The goblin can do 3 min damage or 8 max damage");
            enemyMaxDamage = 8;
            enemyMinDamage = 3;

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("NOW");
            Console.WriteLine("Get ready");
            Console.WriteLine("The fight will start in 3 seconds");

            Console.WriteLine("3");
            Console.WriteLine("2");
            Console.WriteLine("1");

            Console.WriteLine("LEEEETS GEEEET REEEADY TO RUMBLEEEEEEE");
            while (playerHealth > 0 && enemyHealth > 0)
            {
                weapon = Console.ReadLine();
                
                    if (weapon == "Sword" || weapon == "sword" || weapon == "SWORD")
                    {
                        Console.WriteLine("you chose Sword");
                        Console.WriteLine("good choice");
                    pmaxDamage = 10;
                    pminDamage = 5;
                }
                    else if (weapon == "Axe" || weapon == "axe" || weapon == "AXE")
                    {
                        Console.WriteLine("you chose Axe");
                        Console.WriteLine("good choice");
                    pmaxDamage = 14;
                    pminDamage = 7;
                }
                    else
                    {
                        Console.WriteLine("you didn't choose a valid weapon");
                    }

                    Console.WriteLine($"You have {playerHealth} health");
                    int playerDamage = rnd.Next(pminDamage, pmaxDamage);                
                    enemyHealth = enemyHealth - playerDamage;
                    Console.WriteLine($"You did {playerDamage} damage to the goblin");
                    Console.WriteLine($"The goblin has {enemyHealth} health left");

                    Console.WriteLine("The goblin is attacking you");
                    int enemyDamage = rnd.Next(enemyMinDamage, enemyMaxDamage);
                    playerHealth = playerHealth - enemyDamage;
                    Console.WriteLine($"The goblin did {enemyDamage} damage to you");
                    Console.WriteLine($"You have {playerHealth} health left");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("now $ {playerName} Choose your weapon agian");
                    Console.WriteLine("you have two choices Sword or axe");
                    weapon = Console.ReadLine();
                    {
                        if (weapon == "Sword" || weapon == "sword" || weapon == "SWORD")
                        {
                            Console.WriteLine("you chose Sword");
                            Console.WriteLine("good choice");
                        }
                        else if (weapon == "Axe" || weapon == "axe" || weapon == "AXE")
                        {
                            Console.WriteLine("you chose Axe");
                            Console.WriteLine("good choice");
                        }
                        else
                        {
                            Console.WriteLine("you didn't choose a valid weapon");
                        }
                    }

                }

            }
        }
    }




