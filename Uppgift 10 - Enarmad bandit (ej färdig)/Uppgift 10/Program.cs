using System;
using System.Text;

namespace Uppgift_10
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            int credits = 0;
            Random random = new Random();
            credits = random.Next(10, 1001);


            Console.ReadLine();
            string[] symbols = new[] { "CHERRY", "LEMON", "7" };
            Console.WriteLine("Välkommen till Slot Machine Game!");
          //  Console.WriteLine($"Du börjar med {credits} krediter.");
            Console.WriteLine("Tryck på valfri tangent för att spela...");
            credits = int.Parse(Console.ReadLine());
            Console.WriteLine("Du har nu möljiheten att sätta in dina krediter, skriv in hur många krediter du vill sätta in:");

            Console.WriteLine("du har nu satt in credits och är redo att spela");


            while (true)
            {
                if (credits >= 0)
                {
                    Console.WriteLine(symbols[random.Next(0, 3)] + symbols[random.Next(0, 3)] + symbols[random.Next(0, 3)]);

                }

                else
                {
                    Console.WriteLine("Du har inga krediter");

                }
            }
            
        }
       
    }

}