using System;

namespace VinterProjekt2022
{
    public class Setup
    {     
        private bool genusChosen = false;
        private bool genusChosenPanthera = false;
        private bool genusChosenFelis = false;

        private int finalChoice;
        private int genusChoice;

        public int globalFinalChoice
        {
            get
            {
                return finalChoice;
            }
            set
            {
                finalChoice = value;
            }
        }

        public int globalGenusChoice
        {
            get
            {
                return genusChoice;
            }
            set
            {
                genusChoice = value;
            }
        }

        public Setup() 
        {
            while (genusChosen == false) 
            {
                // to do (alt): prova konvertera text till void-metoder i separat klass?
                Console.WriteLine("Choose a taxonomic genus:");
                Console.WriteLine("(Make sure to only answer with the numbers 1-4)");
                Console.WriteLine("1: Panthera");
                Console.WriteLine("2: Felis");
                Console.WriteLine("3: Gorilla");
                Console.WriteLine("4: Homo");
                    
                string genusChoiceInput = Console.ReadLine();
                Console.Clear();

                if (genusChoiceInput == "1") 
                {
                    genusChoice = 1;
                    genusChosenPanthera = true;
                    genusChosen = true;
                }

                if (genusChoiceInput == "2") 
                {
                    genusChoice = 2;
                    genusChosenFelis = true;
                    genusChosen = true;
                }

                while (genusChosenPanthera == true) 
                { 
                    Console.WriteLine("Select a species:");
                    Console.WriteLine("(Make sure to only answer with the numbers 1-4)");
                    Console.WriteLine("1: Lion");
                    Console.WriteLine("2: Panther");
                    Console.WriteLine("3: Tiger");
                    Console.WriteLine("4: Back");

                    string speciesChoiceInput = Console.ReadLine();
                    Console.Clear();

                    if (speciesChoiceInput == "1") 
                    {
                        finalChoice = 1;
                        genusChosenPanthera = false;
                    }

                    if (speciesChoiceInput == "2") 
                    {
                        finalChoice = 2;
                        genusChosenPanthera = false;
                    }

                    if (speciesChoiceInput == "4") 
                    {
                        genusChosenPanthera = false;
                        genusChosen = false;
                    }
                }

                while (genusChosenFelis == true) 
                { 
                    Console.WriteLine("Select a species:");
                    Console.WriteLine("(Make sure to only answer with the numbers 1-4)");
                    Console.WriteLine("1: Cat");
                    Console.WriteLine("2: Lynx");
                    Console.WriteLine("3: Ocelot");
                    Console.WriteLine("4: Back");

                    string speciesChoiceInput = Console.ReadLine();
                    Console.Clear();

                    if (speciesChoiceInput == "1") 
                    {
                        finalChoice = 3;
                        genusChosenFelis = false;
                    }

                    if (speciesChoiceInput == "2") 
                    {
                        finalChoice = 4;
                        genusChosenFelis = false;
                    }

                    if (speciesChoiceInput == "4") 
                    {
                        genusChosenFelis = false;
                        genusChosen = false;
                    }
                }
            }
        }
    }
}