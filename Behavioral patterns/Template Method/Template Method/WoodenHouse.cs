using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method
{
    class WoodenHouse : BuildingHouse
    {
        public override void BuildWalls()
        {
            Console.WriteLine("Возведены стены из брёвен");
        }
    }
}
