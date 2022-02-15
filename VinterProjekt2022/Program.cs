using System;
using System.Collections.Generic;

namespace VinterProjekt2022
{
    class Program
    {
        static void Main(string[] args)
        {
            // to do: gör prompt klass som returnerar ett värde som blir avläst i main och ändrar instansen för companion i main
            Setup Setup = new Setup();
            Companion Companion = new Companion();
            bool nameSelect = false;
            /*
            Dessa if-satser ser till att companion tillämpar de egenskaper som de olika djuren/companions har.
            Inledningsvis anropas en tom companion-instans så koden i while-loopen fungerar från början och.. 
            ..efter det tillämpas de olika egenskaperna beroende på spelarens val av companion.
            */
            //string PlayerChoice = Console.ReadLine();

            // to do: gör prompt klass som returnerar ett värde som blir avläst i main och ändrar instansen för companion i main

            if (Setup.globalGenusChoice == 1) {
                // ändrar companion till att tillämpa alla arv från PantheraChar
                Companion = new PantheraChar();
            }

            if (Setup.globalGenusChoice == 2) {
                // ändrar companion till att tillämpa alla arv från FelisChar
                Companion = new FelisChar();
            }

            if (Setup.globalFinalChoice == 1) {
                // ändrar companion till att tillämpa alla arv från LionChar
                Companion = new LionChar();
                nameSelect = true;
            }

            if (Setup.globalFinalChoice == 2) {
                // ändrar companion till att tillämpa alla arv från PantherChar
                Companion = new PantherChar();
                nameSelect = true;
            }

            if (Setup.globalFinalChoice == 3) {
                // ändrar companion till att tillämpa alla arv från CatChar
                Companion = new CatChar();
                nameSelect = true;
            }

            while (nameSelect == true)
            {
                Console.WriteLine("Choose a name for your companion");
                Companion.name = Console.ReadLine();
                nameSelect = false;
            }

            while (Companion.GetAlive())
            {
                Companion.CompanionType();
                Companion.CompanionSpecies();
                Companion.PrintStats();
                Console.WriteLine("");
                Companion.PrintCurrentStats();
                Console.WriteLine("");
                Console.WriteLine($"Actions {Companion.name}");
                Console.WriteLine("");
                Console.WriteLine($"1: Feed {Companion.name}");
                Console.WriteLine($"2: Greet {Companion.name}");
                Console.WriteLine($"3: Teach {Companion.name}");
                Console.WriteLine($"4: {Companion.name} Learned words");
                string action = Console.ReadLine();
                Console.Clear();

                if (action == "1")
                {
                    Companion.Feed();
                    //companion.Tick();
                    Console.Clear();
                    //Feed();
                }

                if (action == "2")
                {
                    Companion.Hi();
                    //Companion.ListWords();
                }

                if (action == "3")
                {
                    Console.WriteLine("unfinished");
                }

                if (action == "4")
                {
                    Console.WriteLine("unfinished");
                }

                if (action == "5")
                {
                    Companion.Tick();
                    Console.Clear();
                }
            }
        }
    }
}