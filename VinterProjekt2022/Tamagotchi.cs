using System;
using System.Collections.Generic;

namespace VinterProjekt2022
{
    public class Tamagotchi
    {
        private int hunger = 10;
        private int boredom;
        private bool isAlive;
        public string name;
        private List<string> words = new List<string>();

        public void Tick()
        {
            boredom++;
            hunger--;
        }

        public void Feed()
        {
            hunger = hunger + 5;
            hunger = Math.Min(hunger, 10);
        }

        public void Teach(string word)
        {
            Console.WriteLine("Hej!");
        }

        public void Hi()
        {
            Console.WriteLine("Hej!");
            ReduceBoredom();
        }

        //public void PrintStats()
        //{
        //    Console.WriteLine("Hunger:");
        //    Console.WriteLine(hunger);
        //    Console.WriteLine("Boredom:");
        //    Console.WriteLine(boredom);
        //}

        public bool GetAlive()
        {
            if (hunger != 0)
            {
                return true;
            }
            
            else if (boredom > 10)
            {
                return false;
            }

            else
            {
                return false;
            }
        }

        private void ReduceBoredom()
        {
            boredom = boredom - 5;
            boredom = Math.Max(boredom, 0);
        }
    }
}