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
            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();
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

            Console.WriteLine("now $ {playerName} Choose your weapon");
            Console.WriteLine("you have two choices Sword or axe");
            string weapon = Console.ReadLine();
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
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"You have a {weapon}");
            Console.WriteLine("Now let's give your weapon some damage");
            int pmaxDamage = 10;
            int pminDamage = 5;
            Console.WriteLine($"Your {weapon} can do {pminDamage} min damage or {pmaxDamage} max damage");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Every Hero needs a health bar");
            Console.WriteLine("You start with 100 health");
            Console.WriteLine("Congrats");
            int playerHealth = 100;
            Console.WriteLine($"You have {playerHealth} health");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Now you need to fight the enemy");
            Console.WriteLine("You will fight a goblin");
            int enemyHealth = 50;
            Console.WriteLine($"The goblin has {enemyHealth} health");
            Console.WriteLine("The goblin can do 3 min damage or 8 max damage");
            int enemyMaxDamage = 8;
            int enemyMinDamage = 3;
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("NOW");
            Console.WriteLine("Get ready");
            Console.WriteLine("The fight will start in 3 seconds"); 

            Console.WriteLine("3");
            Console.WriteLine("2");
            Console.WriteLine("1");

            Console.WriteLine("LEEEETS GEEEET REEEADY TO RUMBLEEEEEEE");
            while (playerHealth > 0)
            {
               // if 
                {
                    //För att tilldela ett slumpat värde så måste vi använda oss utav en
                    //funktion.Vi har tillgång tilldenna funktion tack vare våra importeradebibliotek(using System högst upp i programmet).
                    //Exempel på hur vi tilldelar ett randomvärde tillspelarens faktiska skada:
                    //Notera att "rnd" är namnet på vår random seed som vi skapade när programmet börjar!
                }
            }

        }

    }
}
