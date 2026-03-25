using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_11
{

    
    internal class Program
    {
        public class Animals
        {
            string animals;
            string Type;
            int choose;
            
        }
        static void Main(string[] args)
        {
            List<Animals> Animals = new List<Animals>();
            Animals animals = new Animals();
            Animals.Add(animals);

            while (true)
            {
                Console.WriteLine("choose a animal");
                Console.ReadKey();
            }
            if (Animals.Count == 0)
            {
                Console.WriteLine("animal amount");
                Console.ReadKey();
                animals = new Animals();


            }
        }
    }
}
