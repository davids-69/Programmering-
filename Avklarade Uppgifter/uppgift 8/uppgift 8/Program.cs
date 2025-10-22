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

            int playermove;
            int pcmove;


            Random generator = new Random();


            // Console.WriteLine("Datorn rullade: " + pcmove + "\n \n");


            Console.WriteLine("välj drag");
            //   Console.WriteLine("Sten, sax, Påse");
            Console.WriteLine("Sten (1), sax (2), Påse (3)");





            while (true)
            {
                int answer = int.Parse(Console.ReadLine());
                //Datorn får ett slumpat drag
                pcmove = generator.Next(4);
                while (answer < 1 || answer > 3)
                {

                    Console.WriteLine("you didn't choose a move. choose again!");
                    answer = int.Parse(Console.ReadLine());


                }
                Console.WriteLine(" datorn valde" + pcmove );
            }

        }
    }
}

