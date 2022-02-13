using System;
using System.Collections.Generic;

namespace VinterProjekt2022
{
    public class PantherChar: PantheraChar
    {
        private List<string> words = new List<string>();

        public PantherChar()
        {
            name = "Change_Name_Panther";
            //SetBoredom(10);
        }


        public void Feed()
        {
            hunger = hunger + 6;
            hunger = Math.Min(hunger, 10);
        }

        public new void Tick()
        {
            boredom = boredom + 3;
            hunger -= 3;
        }
    }
}