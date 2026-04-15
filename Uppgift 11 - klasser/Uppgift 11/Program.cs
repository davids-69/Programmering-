using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_11
{


    internal class Program
    {
        public class Animals
        {

            public string animals;
            public string diet;
            public int numberOfLegs;


            public void animalInfo()
            {
                Console.WriteLine("Animal name: " + animals);
                Console.WriteLine("Animal food: " + diet);
                Console.WriteLine("Animal Legs: " + numberOfLegs);
            }
            public Animals(string animalname, string dietType, int legs)
            {
                animals = animalname;
                diet = dietType;
                numberOfLegs = legs;

                animalname = animals;
            }

        }
        static void Main(string[] args)
        {

            // animals.animalInfo();
            Animals animals = new Animals("Hund", "kött", 4);

            int choose = 0;
            choose = 0;
            List<Animals> Animals = new List<Animals>();

            //Animals dogAnimal = new Animals("dog", "meat", 4);



            while (true)
            {


                while (choose <= 0 || choose >= 4)
                {
                    Console.WriteLine("nr 1 = choose a animal");
                    Console.WriteLine("nr 2 = list of animals");
                    Console.WriteLine("nr 3 = exit the game");
                    Console.WriteLine("Choose 1 - 3");
                    choose = Convert.ToInt32(Console.ReadLine());


                }
                if (choose == 1)
                {

                    animals = new Animals("cat" , "meat", 4);
                    Console.WriteLine("choose a animal");
                    animals.animals = Console.ReadLine();
                    Console.WriteLine("what does the animal eat");
                    animals.diet = Console.ReadLine();
                    Console.WriteLine("number of legs");
                    animals.numberOfLegs = Convert.ToInt32(Console.ReadLine());
                    Animals.Add(animals);
                }
                if (choose == 2)
                {

                    Console.WriteLine("list of animals");
                    for (int i = 0; i < Animals.Count; i++)
                    {

                        Animals[i].animalInfo();
                    }
                }
                else if (choose == 3)
                {
                    break;
                }
                choose = 0;
                 
            }
        }
    }
}
                     


