using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int belopp = 100;
            int val = 0;
            while (belopp > 0)
            {
                Console.WriteLine("Du har " + belopp + " kr kvar.");
                Console.WriteLine("Liten glass: 25kr\nMellan glass: 50kr\nStor glass: 75kr");
                Console.WriteLine("Välj ett alternativ:");
                val = int.Parse(Console.ReadLine());
                if (val == 1)
                {
                    belopp -= 25;
                    Console.WriteLine("Du köpte en liten glass.");
                }
                else if (val == 2)
                {
                    belopp -= 50;
                    Console.WriteLine("Du köpte en mellan glass.");
                }
                else if (val == 3) 
                {
                    belopp -= 75;
                    Console.WriteLine("Du köpte en stor glass.");
                }
                else
                {
                    Console.WriteLine("Felaktigt val, försök igen.");
                }
            }
        }   
    }
}
