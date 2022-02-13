using System;
using System.Collections.Generic;

namespace VinterProjekt2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Companion companion = new Companion();

            //prova konvertera text till void-metoder i separat klass?
            System.Console.WriteLine("Choose a taxonomic genus:");
            Console.WriteLine("(Make sure to only answer with the numbers 1-4)");
            System.Console.WriteLine("1: Panthera");
            System.Console.WriteLine("2: Felis");
            System.Console.WriteLine("3: Gorilla");
            System.Console.WriteLine("4: Homo");
            
            string PlayerChoice1 = Console.ReadLine();
            
            if (PlayerChoice1 == "1") 
            {
                    System.Console.WriteLine("Select a species:");
                    Console.WriteLine("(Make sure to only answer with the numbers 1-4)");
                    System.Console.WriteLine("1: Lion");
                    System.Console.WriteLine("2: Panther");
                    System.Console.WriteLine("3: Tiger");
            }

            if (PlayerChoice1 == "2") 
            {
                System.Console.WriteLine("Select a species:");
                Console.WriteLine("(Make sure to only answer with the numbers 1-4)");
                System.Console.WriteLine("1: Cat");
                System.Console.WriteLine("2: Ocelot");
                System.Console.WriteLine("3: Lynx");
            }
            
            string PlayerChoice = Console.ReadLine();
            /*
            Dessa if-satser ser till att companion tillämpar de egenskaper som de olika djuren/companions har.
            Inledningsvis anropas en tom companion-instans så koden i while-loopen fungerar från början och.. 
            ..efter det tillämpas de olika egenskaperna beroende på spelarens val av companion.
            */
            //string PlayerChoice = Console.ReadLine();

            if (PlayerChoice == "1") {
                // ändrar companion till att tillämpa alla arv från LionChar
                companion = new LionChar();
            }

            if (PlayerChoice == "2") {
                // ändrar companion till att tillämpa alla arv från CatChar
                companion = new CatChar();
            }

            while (companion.GetAlive() == "1")
            {
                //requirements.PrintStats();
                companion.PrintCurrentStats();
                Console.WriteLine($"Actions {companion.name}");
                //Tick();
                Console.WriteLine("1: Ge mat");
                Console.WriteLine("2: Lär ord");
                Console.WriteLine("3: Lista på lärda ord");
                string action = Console.ReadLine();
                Console.Clear();

                if (action == "1")
                {
                    companion.Tick();
                    Console.Clear();
                    //Feed();
                }

                
            }
        }
    }
}