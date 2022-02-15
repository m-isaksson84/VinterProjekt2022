using System;

namespace VinterProjekt2022
{
    public class FelisChar: Companion
    {
        public override void CompanionType()
        {   
            type = "Felis";
            Console.WriteLine(type);
        }
    }
}