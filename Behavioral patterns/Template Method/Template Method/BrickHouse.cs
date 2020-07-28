using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method
{
    class BrickHouse : BuildingHouse
    {   
        public override void BuildWalls()
        {
            Console.WriteLine("Возведены стены из кирпичей");
        }
    }
}
