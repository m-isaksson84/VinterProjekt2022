using System;
using System.Collections.Generic;

namespace VinterProjekt2022
{
    public class LionChar: PantheraChar
    {

        public LionChar()
        {
            // overridar hunger stats från Companion
            // gör om till inkapslad SetHunger metod
            globalHunger = 30;
            globalBoredom = 0;
            name = "Temp_Name_Lion";
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
            globalBoredom++;
            globalHunger += 5;
            globalHunger = Math.Min(globalHunger, 30);
            //SetHunger(Math.Min(GetHunger(), 30));
        }

        public override void Hi()
        {
            globalBoredom -= 2;
            globalBoredom = Math.Min(globalBoredom, 0);
            //SetHunger(Math.Min(GetHunger(), 30));
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