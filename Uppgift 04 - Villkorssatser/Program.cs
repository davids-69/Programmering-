using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_4
{
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vad heter du? ");
            string namn = Console.ReadLine();


            if (namn.Equals("david", StringComparison.OrdinalIgnoreCase))

            {
                Console.WriteLine("Hej David! \nTrevligt att träffas");

            }
            else if (namn == "bengt")
            {
                String name = Console.ReadLine();
                Console.WriteLine("hej bengt");

            }

            else 
                {
                string name = Console.ReadLine();
                Console.WriteLine("Hej");
                Console.WriteLine("trevligt och träffas.");
            }
        }
    }
}
