using System;
using System.Collections.Generic;

namespace VinterProjekt2022
{
    public class PantheraChar: Companion
    {
        public override void CompanionType()
        {   
            type = "Panthera";
            Console.WriteLine(type);
        }
    }
}