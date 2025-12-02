using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_09
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("skriv 3 olika namn");
            string[] namn = new string[3];
            for (int index = 0; index < namn.Length; index++)
            {
                namn[index] = Console.ReadLine();
            }
            while(true)
            {

            
                Console.WriteLine("skriv in 1, 2, 3 eller 0 for lista");
           
                int val = int.Parse(Console.ReadLine());
                if (val == 1)
                {
                    Console.WriteLine("personen heter " + namn[0]);
                }
                else if (val == 2)
                {
                    Console.WriteLine("personen heter " + namn[1]);
                }
                else if (val == 3)
                {
                    Console.WriteLine("personen heter " + namn[2]);
                }
                else if (val == 0)
                {
                    for (int index = 0; index < namn.Length; index++)
                    {
                        Console.WriteLine(namn[index]);
                        

                    }
                    break;
                }
                  //  Console.WriteLine("0 for lista" + " " + namn[0] + " " + namn[1] + " " + namn[2]);
            }
        }
    }
}
