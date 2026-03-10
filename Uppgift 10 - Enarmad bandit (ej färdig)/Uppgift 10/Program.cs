using System;
using System.Text;

namespace Uppgift_10
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int credits = 100;

            Random random = new Random();
            string[] symbols = new[] { "CHERRY", "BELL", "LEMON", "STAR", "7" };
            Console.WriteLine("Välkommen till Slot Machine Game!");
            Console.WriteLine($"Du börjar med {credits} krediter.");
            Console.WriteLine("Tryck på valfri tangent för att spela...");

            while (true)
            {
                if (credits <= 0)
                {
                    Console.WriteLine("Du har inga krediter");

                }
            }
        }
       
    }

}