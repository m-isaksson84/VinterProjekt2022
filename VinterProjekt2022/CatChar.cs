using System;
using System.Collections.Generic;

namespace VinterProjekt2022
{
    public class CatChar: PantheraChar
    {
        //private bool isAlive;
        

        public int tempboredom;

        public CatChar()
        {
            name = "Change_Name_Cat";
            //SetBoredom(10);
        }


        public void Feed()
        {
            hunger = hunger + 5;
            hunger = Math.Min(hunger, 10);
        }

        public void Tick()
        {
            boredom++;
            hunger -= 5;
        }
    
    }
}