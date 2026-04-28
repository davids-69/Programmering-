using System;
using System.Threading;

namespace Uppgift_10
{
    internal class Program
    {
        const int MinBet = 10;
        const int MaxBet = 1000;
        const int JackpotMultiplier = 5;
        const int WinMultiplier = 2;

        static string[] slots = new string[3];
        static string slotResult = "";
        static int credits = 0;
        static int playerBet = 0;
        static int totalWins = 0;
        static int totalLosses = 0;
        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("  Välkommen till Enarmad Bandit!");
            Console.WriteLine("==============================");

            Console.WriteLine("Hur många krediter vill du sätta in?");
            Console.WriteLine("MIN: 10kr & MAX: 1000kr");
            while (!int.TryParse(Console.ReadLine(), out credits) || credits < MinBet || credits > MaxBet)
            {
                Console.WriteLine($"Ogiltigt belopp. Ange ett värde mellan {MinBet} och {MaxBet}:");
            }

            Console.WriteLine($"Du börjar med {credits} krediter.");
            Console.WriteLine();

            
            playerBet = GetBet();

            
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Krediter: {credits}  |  Insats: {playerBet}");
                Console.WriteLine("Tryck ENTER för att snurra, B för att byta insats, eller Q för att avsluta.");

                string input = Console.ReadLine().Trim().ToUpper();

                if (input == "Q")
                {
                    break;
                }
                else if (input == "B")
                {
                    playerBet = GetBet();
                    continue;
                }

                
                credits -= playerBet;

                Machine();
                DisplayResult();
                Check();

                if (credits <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Du har inga krediter kvar. Spelet är slut!");
                    break;
                }
            }

            
            Console.WriteLine();
            Console.WriteLine("==============================");
            Console.WriteLine("          Spelslut");
            Console.WriteLine("==============================");
            Console.WriteLine($"Slutsaldo:        {credits} krediter");
            Console.WriteLine($"Totala vinster:   {totalWins}");
            Console.WriteLine($"Totala förluster: {totalLosses}");
            Console.WriteLine("Tack för att du spelade!");
            Console.ReadKey();
        }

       
        static int GetBet()
        {
            int bet = 0;

            Console.WriteLine($"Ange din insats ({MinBet}–{MaxBet} krediter):");

            while (true)
            {
                string input = Console.ReadLine();

                if (!int.TryParse(input, out bet) || bet < MinBet || bet > MaxBet)
                {
                    Console.WriteLine($"Ogiltig insats. Ange ett värde mellan {MinBet} och {MaxBet}:");
                }
                else if (bet > credits)
                {
                    Console.WriteLine($"Du har inte tillräckligt med krediter. Du har {credits} krediter.");
                }
                else
                {
                    return bet;
                }
            }
        }

        
        static void Machine()
        {
            string[] symbols = new[] { "LEMON", "CHERRY", "7" };

            for (int i = 0; i < slots.Length; i++)
            {
                int index = random.Next(0, symbols.Length);
                slots[i] = symbols[index];
            }

            slotResult = slots[0] + slots[1] + slots[2];
        }

        
        static void DisplayResult()
        {
            Console.WriteLine();
            Console.WriteLine($"[ {slots[0],-8} | {slots[1],-8} | {slots[2],-8} ]");
        }

       
        static void Check()
        {
            bool allMatch = slots[0] == slots[1] && slots[1] == slots[2];
            bool is777 = slotResult == "777";

            if (is777)
            {
                int prize = playerBet * JackpotMultiplier;
                credits += prize;
                totalWins++;
                Console.WriteLine($"JACKPOT! Tre 7:or! Du vinner {prize} krediter!");
            }
            else if (allMatch)
            {
                int prize = playerBet * WinMultiplier;
                credits += prize;
                totalWins++;
                Console.WriteLine($"Tre lika! Du vinner {prize} krediter!");
            }
            else
            {
                totalLosses++;
                Console.WriteLine($"Ingen vinst. Du förlorade {playerBet} krediter.");
            }

            Console.WriteLine($"Saldo: {credits} krediter.");
        }
    }
}



