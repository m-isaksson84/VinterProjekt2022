using System;
using System.Collections.Generic;

namespace VinterProjekt2022
{
    public class Prompt
    {
        public string name;
        string ans1;

        public string[] genus = {"1: Panthera", "2: Felis", "3: Gorilla", "4: Homo"};
        //public string[] felisSpecies = {"1: House cat", "2: Cougar", "3: Serval"};
        //public string[] gorillaSpecies = {"1: Houwdsecat", "2: ", "3: Nemdwatoda", "4: Andwnelida"};
        //public string[] homoSpecies = {"1: Housecat", "2: ", "3: Nematoda", "4: Annelida"};

        private string playerInput;

        public Prompt()
        {   
            System.Console.WriteLine("Choose a taxonomic kingdom:");
            Console.WriteLine("(Make sure to only answer with the numbers 1-4)");

            foreach (string genus in genus)
            {
                Console.WriteLine(genus);
            }

            playerInput = Console.ReadLine();
            Console.Clear();
            Console.ReadLine();

            if (ans1 == "2") {
                // skapar instans av genus>felis och kör dess konstruktor.
                //FelisPrompt genusFelis = new FelisPrompt();
            }

            if (ans1 == "3") {
                // skapar instans av genus>gorilla och kör dess konstruktor.
                //GorillaPrompt genusGorilla = new GorillaPrompt();
            }
        }
    }
}