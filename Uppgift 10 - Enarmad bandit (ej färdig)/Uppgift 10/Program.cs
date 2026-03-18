using System;
using System.Text;
using System.Collections;

namespace Uppgift_10
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int credits = 1000;
            Random random = new Random();
            int playerBet = 0;
            bool slotsA = true;
            bool slotLoop = true;
            int spin = 0;
            string[] slot1 = new string[3];
            int slotmachine;
            int win = 0;
            int loss = 0;
            int resultat = 0;
            string slotResult = "";

            credits = random.Next(10, 1001);

            string[] symbols = new[] { "CHERRY", "LEMON", "7" };


            Console.WriteLine("Välkommen till Slot Machine Game!");
            //  Console.WriteLine($"Du börjar med {credits} krediter.");
           
            
          //  credits = int.Parse(Console.ReadLine());
            Console.WriteLine("Du har nu möljiheten att sätta in dina krediter, skriv in hur många krediter du vill sätta in:");
            Console.ReadLine();
            Console.WriteLine("du har nu satt in credits och är redo att spela");

            while (playerBet < 10 || playerBet > 1000 || playerBet > credits)
            {
                playerBet = Convert.ToInt32(Console.ReadLine());
            }

            while (true)
            {
                /* if (credits >= 0)
                 {
                     Console.WriteLine(symbols[random.Next(0, 3)] + symbols[random.Next(0, 3)] + symbols[random.Next(0, 3)]);

                 }

                 else
                 {
                     Console.WriteLine("Du har inga krediter");

                 }
                break;
                */

                machine();
            }


            void machine()
            {
                for (int i = 0; i < slot1.Length; i++)
                {
                    slotmachine = random.Next(1, 4);
                    if (slotmachine == 1)
                    {
                        slot1[i] = "lemon";
                        
                    }
                    if (slotmachine == 2)
                    {
                        slot1[i] = "cherry";
                        
                    }
                    if (slotmachine == 3)
                    {
                        slot1[i] = "7";
                        
                    }
                    
                }

                
            }
            void check()
            {
                if (slotResult == "777" || slotResult == "cherrycherrycherry" |slotResult == "lemonlemonlemon")
                {

                }
            }
        }
        
       
    
    
    }
}

