using System;
using System.Collections.Generic;

namespace VinterProjekt2022
{
    public class PantheraChar: Companion
    {

        //public void SetBoredom(int newBoredom)
        //{
        //    boredom = newBoredom;
        //}

        //public int GetHp()
        //{ 
        //    return boredom;
        //} 

        public void Teach(string word)
        {
            Console.WriteLine("Hej!");
        }

        public void Hi()
        {
            Console.WriteLine("Hej!");
            ReduceBoredom();
        }

        public void ReduceBoredom()
        {
            boredom = boredom - 5;
            boredom = Math.Max(boredom, 0);
        }
    }
}