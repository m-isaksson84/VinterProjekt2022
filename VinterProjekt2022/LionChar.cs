using System;
using System.Collections.Generic;

namespace VinterProjekt2022
{
    public class LionChar: PantheraChar
    {

        public LionChar()
        {
            // Overridar hunger stats från Companion
            globalHunger = 30;
            globalBoredom = 0;
            name = "Temp_Name_Lion";
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
            globalBoredom++;
            globalHunger += 5;
            globalHunger = Math.Min(globalHunger, 30);
        }

        public override void Hi()
        {
            globalBoredom -= 2;
            globalBoredom = Math.Min(globalBoredom, 0);
        }

        public override void PrintStats()
        {
            Console.WriteLine($"Min boredom: {20} (more is better)");
            Console.WriteLine($"Max hunger: {30} (less is better)");
            Console.WriteLine($"Feed amount: {5} hunger");  
        }

        public override void CompanionSpecies()
        {   
            species = "Lion";
            Console.WriteLine(species);
        }
    }
}