using System;

namespace VinterProjekt2022
{
    public class Companion
    {

        public int boredom = 0;
        public int hunger = 10;
        public string name = "DefaultCompanion";
        private List<string> words = new List<string>();
        public string GetAlive()
        {

            if (hunger != 0)
            {
                return "1";
            }
                
            else if (boredom > 20)
            {
                return "0";
            }

            return "0";
        }

        public void PrintCurrentStats()
        {
            Console.WriteLine(boredom);
            Console.WriteLine(hunger);
        }


        // Virtual så override fungerar när spelaren specificerar vilken typ av companian de vill ha
        // denna metod är en placeholder så den kan anropas i main.
        public virtual void Tick()
        {
            boredom++;
            hunger--;

            if (hunger < 0) 
            {
                hunger = 0;
            }
        }
    }
}