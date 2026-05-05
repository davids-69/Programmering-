using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace FileManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hämta information ifrån textfilen! Denna fil finns lokalt på datorn.
            //string input01 = File.ReadAllText("../../Tim's mapp/File00.txt");
            string input01 = File.ReadAllText("C:\\Users\\Axevalla\\Desktop\\Programmering-\\Uppgift 12 - Skriva till- och från fil\\FileManagement\\FilesToRead\\File01.txt");
            string input02 = File.ReadAllText("C:\\Users\\Axevalla\\Desktop\\Programmering-\\Uppgift 12 - Skriva till- och från fil\\FileManagement\\FilesToRead\\File02.txt");
            string[] input03 = File.ReadAllLines("C:\\Users\\Axevalla\\Desktop\\Programmering-\\Uppgift 12 - Skriva till- och från fil\\FileManagement\\FilesToRead\\File03.txt");
            string[] input04 = File.ReadAllLines("C:\\Users\\Axevalla\\Desktop\\Programmering-\\Uppgift 12 - Skriva till- och från fil\\FileManagement\\FilesToRead\\File04.txt");
            //Jobba med File01 här
            string result01 = File01Task(input01);
            Console.WriteLine(result01);

            //Jobba med File02 här
            List<int> result02 = File02Task(input02);
            foreach(int siffra in result02)
            {
                Console.WriteLine(siffra);
            }

            //Jobba med File03 här
            int[] result03 = File03Task(input03);
            Console.WriteLine("Result 03:");
            foreach (int siffra in result03)
            {
                Console.WriteLine(siffra);
            }
            //Jobba med File04 här
            string result04 = File04Task(input04);
            Console.WriteLine(result04);
            //Kalla på funktion
            //Skriv till textdokumentet

            //Jobba med File05 här
            //Kalla på funktion
            //Skriv till textdokumentet
        }

        static string File01Task(string input)
        {
            //För enkelhetens skull lagrar vi vår string i en array av karaktärer
            //Detta så att vi kan använda oss av funktionen "sort".
            char[] listToSort = input.ToCharArray();
            string returnString = "";

            //Sortera arrayen här.
            Array.Sort(listToSort);


            foreach (char letter in listToSort)
            {
                returnString += letter;
            }

            //sortera arrayen här.
            //???

            //Här skickar vi tillbaka listan i datatypen "string".
            return returnString;
        }

        static List<int> File02Task(string input)
        {
            string[] listToSort = input.Split(',');

            

            //Vi vill mata in vår lista av "bokstavssiffror" så att de blir till
            //faktiska siffror. Vi använder en lista här istället för en array eftersom
            //vi kommer att vilja lägga till saker dynamiskt. 
            List<int> intsInList = new List<int>();

            foreach(string siffra in listToSort)
            {
                intsInList.Add(int.Parse(siffra));
                //För varje (for each) siffra (vårt valda variabelnamn) i vår lista
                //ska läggas in i vår lista "intsInList". 

            }

            return intsInList;
        }

        static int[] File03Task(string[] input)
        {
            List<int> intsInList = new List<int>();
            foreach (string siffra in input)
            {
                intsInList.Add(int.Parse(siffra));
            }
            intsInList.Sort();
            return intsInList.ToArray();
        }

        static string File04Task(string[] input)
        {
            Console.WriteLine(input);
            foreach(string line in input)
            {
                Console.WriteLine(line);
                
            }
            //Svara på frågorna! 
            //Ledtråd: jobba med varje array-element för sig.
            
            
            //return? Just nu är funktionen "void" -- dvs. funktionen skickar inte tillbaka 
            //något värde.
            //Vill ni skicka tillbaka en string eller en List<string?/char?>?
            return "";
        }
        

        static void File05Task(string[] input)
        {
            //Samma uppgift som File04, fast nu ska ni ersätta den existerande informationen
            //med ny information!
        }
    }
}
