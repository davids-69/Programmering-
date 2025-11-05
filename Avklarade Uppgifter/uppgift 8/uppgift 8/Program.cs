using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

           // int playermove;
            int pcmove;
            int playerscore = 0;
            int pcscore = 0;
           


            Random generator = new Random();


            // Console.WriteLine("Datorn rullade: " + pcmove + "\n \n");


            Console.WriteLine("välj drag");
            Console.WriteLine("Sten (0), sax (1), Påse (2)");



            while (true)
            {
                Console.WriteLine("choose");
                int answer = int.Parse(Console.ReadLine());
                //Datorn får ett slumpat drag

                pcmove = generator.Next(3);
                while (answer < 0 || answer > 2)
                {

                    Console.WriteLine("you didn't choose a move. choose again!");
                    answer = int.Parse(Console.ReadLine());


                }
                Console.WriteLine("Sten (0), sax (1), Påse (2)");
                Console.WriteLine(" datorn valde " + pcmove);
                
                

                if (answer == 0 && pcmove == 0) // är lika med
                {
                    Console.WriteLine("draw!");
                }
                else if (answer == 1 && pcmove == 1)
                {
                    Console.WriteLine("draw!");
                }
                else if (answer == 2 && pcmove == 2)
                {
                    Console.WriteLine("draw!"); // är lika med
                }
                else if (answer == 0 && pcmove == 1) 
                {
                    Console.WriteLine("sten slår sax");
                    Console.WriteLine("player win");
                    playerscore = playerscore + 1;
                }
                else if (answer == 1 && pcmove == 0)
                {
                    Console.WriteLine("sten slår sax");
                    Console.WriteLine("player lose");
                    pcscore = pcscore + 1;
                }
                else if (answer == 1 && pcmove == 2) 
                {
                    Console.WriteLine("sax slår påse");
                    Console.WriteLine("player win");
                    playerscore = playerscore + 1;
                }
                else if (answer == 2 && pcmove == 1)
                {
                    Console.WriteLine("sax slår påse ");
                    Console.WriteLine("player lose");
                    pcscore = pcscore + 1;
                } 
                else if (answer == 2 && pcmove == 0)
                {
                    Console.WriteLine("påse slår sten");
                    Console.WriteLine("player win");
                    playerscore = playerscore + 1;
                }
                else if(answer == 0 && pcmove == 2)
                {
                    Console.WriteLine("påse slår sten");
                    Console.WriteLine("player lose");
                    pcscore = pcscore + 1;
                }
               else
                {
                    Console.WriteLine($"player: {answer} cpu: {pcmove}");
                }

                if (playerscore >= 3) 
                { 
                    Console.WriteLine("congratz! you win");
                    Console.WriteLine("GAME OVER");
                    break;
                }
                else if (pcscore >= 3)
                {
                    Console.WriteLine("to bad, you lose! pc win");
                    Console.WriteLine("GAME OVER");
                    break;
                }
            }
        }
    }
}

