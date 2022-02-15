using System;

namespace VinterProjekt2022
{
    public class Companion
    {
        private int boredom = 55;
        private int hunger = 10;
        public string type;
        public string species;

        public int globalBoredom 
        {
            get
            {
                return boredom;
            }
            set
            {
                boredom = Math.Max(value, 0);
            }
        }

        public int globalHunger 
        {
            get
            {
                return hunger;
            }
            set
            {
                hunger = Math.Min(value, 30);
            }
        }

        // namnet är placeholder som ändras när spelaren specificerar vilken companion de ska ha
        public string name = "DefaultCompanion";
        private List<string> words = new List<string>();

        public void PrintCurrentStats()
        {
            Console.WriteLine($"Current boredom: {globalBoredom}");
            Console.WriteLine($"Current hunger: {globalHunger}");
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

        public virtual void Feed()
        {}

        public virtual void PrintStats()
        {
            Console.WriteLine($"Max boredom: {9999}");
            Console.WriteLine($"Max hunger: {9999}");
            Console.WriteLine($"Max hunger: {9999}");  
        }

        public virtual void Teach(string word)
        {
            Console.WriteLine("Hej!");
        }

        public virtual void ReduceBoredom()
        {
            boredom = boredom - 5;
            boredom = Math.Max(boredom, 0);
        }

        public virtual void Hi()
        {
            Console.WriteLine("Hej!");
            ReduceBoredom();
        }

        public virtual void CompanionType()
        {   
            type = "NULL";
            Console.WriteLine(type);
        }

        public virtual void CompanionSpecies()
        {   
            species = "NULL";
            Console.WriteLine(species);
        }


        // GetAlive() ser till att programmet endast körs när companion lever och därmed returnerar false när companion dör.
        public bool GetAlive()
        {
            if (globalHunger != 0)
            {
                return true;
            }
            
            // broken, fixa
            else if (globalBoredom > 20)
            {
                return false;
            }

            return false;
        }
    }
}