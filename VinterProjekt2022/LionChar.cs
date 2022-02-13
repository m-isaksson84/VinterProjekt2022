using System;
using System.Collections.Generic;

namespace VinterProjekt2022
{
    public class LionChar: PantheraChar
    {
        //private bool isAlive;
        private List<string> words = new List<string>();

        public int tempboredom;

        public LionChar()
        {
            // overridar hunger stats från Companion
            // gör om till inkapslad SetHunger metod
            hunger = 20;
            name = "Change_Name_Lion";
            //SetBoredom(10);
        }


        public void Feed()
        {
            hunger = hunger + 5;
            hunger = Math.Min(hunger, 10);
        }

        // Använder override då den tar Tick() metoden från Companion som template och 
        // overridar den med nya "regler" för variablerna när metoden körs.
        public override void Tick()
        {
            boredom++;
            hunger -= 5;

            if (hunger < 0) 
            {
                hunger = 0;
            }
        }
    
    }
}