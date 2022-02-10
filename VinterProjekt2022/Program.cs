using System;
using System.Collections.Generic;

namespace VinterProjekt2022
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("choose:");
            System.Console.WriteLine("1 lion");
            System.Console.WriteLine("2 cat");
            string PlayerChoice = Console.ReadLine();
            
            /*
            Dessa if-satser ser till att companion tillämpar de egenskaper som de olika djuren/companions har.
            Inledningsvis anropas en tom companion-instans så koden i while-loopen fungerar från början och.. 
            ..efter det tillämpas de olika egenskaperna beroende på spelarens val av companion.
            */

            Companion companion = new Companion();

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
                //PrintStats();
                Console.WriteLine($"Actions {companion.name}");
                //Tick();
                Console.WriteLine("1: Ge mat");
                Console.WriteLine("2: Lär ord");
                Console.WriteLine("3: Lista på lärda ord");
                string action = Console.ReadLine();
                Console.Clear();

                if (action == "mat")
                {
                    Console.Clear();
                    //Feed();
                }

                
            }
        }
    }
}