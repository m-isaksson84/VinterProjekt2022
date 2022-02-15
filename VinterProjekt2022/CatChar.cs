using System;
using System.Collections.Generic;

namespace VinterProjekt2022
{
    public class CatChar: FelisChar
    {
        //private bool isAlive;
        private List<string> wwords = new List<string>();
        public string species;
        public CatChar()
        {
            // Overridar hunger stats från Companion
            globalHunger = 25;
            globalBoredom = 0;
            name = "Temp_Name_Cat";
        }

        // Använder override då den tar Tick() metoden från Companion som template och 
        // overridar den med nya "regler" för variablerna när metoden körs.
        public override void Tick()
        {   
            globalBoredom++;
            globalHunger -= 3;

            if (globalHunger < 0) 
            {   
                globalHunger = 0;
            }
        }

        public override void Feed()
        {
            globalBoredom += 3;
            globalHunger += 3;
            globalHunger = Math.Min(globalHunger, 25);
        }

        public override void PrintStats()
        {
            Console.WriteLine($"Min boredom: {20} (more is better)");
            Console.WriteLine($"Max hunger: {25} (less is better)");
            Console.WriteLine($"Feed amount: {5}");  
        }

        public override void CompanionSpecies()
        {   
            species = "Cat";
            Console.WriteLine(species);
        }
    }
}