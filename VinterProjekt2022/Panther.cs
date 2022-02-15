using System;
using System.Collections.Generic;

namespace VinterProjekt2022
{
    public class PantherChar: PantheraChar
    {
        public PantherChar()
        {
            // overridar hunger stats från Companion
            // gör om till inkapslad SetHunger metod
            globalHunger = 25;
            globalBoredom = 0;
            name = "Temp_Name_Panther";
            //SetBoredom(10);
        }

        // Använder override då den tar Tick() metoden från Companion som template och 
        // overridar den med nya "regler" för variablerna när metoden körs.
        public override void Tick()
        {   
            //boredom++;
            globalBoredom++;
            //hunger -= 3;
            globalHunger -= 3;

            if (globalHunger < 0) 
            {   
                //hunger = 0;
                globalHunger = 0;
            }
        }

        public override void Feed()
        {
            globalHunger += 5;
            globalHunger = Math.Min(globalHunger, 25);
        }

        public override void Hi()
        {
            globalBoredom -= 2;
            globalBoredom = Math.Min(globalBoredom, 0);
        }

        public override void PrintStats()
        {
            Console.WriteLine($"Min boredom: {18} (more is better)");
            Console.WriteLine($"Max hunger: {25} (less is better)");
            Console.WriteLine($"Feed amount: {5} hunger");  
        }
        
        public override void CompanionSpecies()
        {   
            species = "Panther";
            Console.WriteLine(species);
        }
    }
}