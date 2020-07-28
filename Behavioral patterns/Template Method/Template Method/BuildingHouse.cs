using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method
{
    abstract class BuildingHouse
    {
        public void BuidHouse()
        {
            BuildWalls();
            PutDoorsAndWindows();
            BuildRoof();
        }
        public abstract void BuildWalls();
        public virtual void PutDoorsAndWindows()
        {
            Console.WriteLine("Поставлены окна и двери");
        }
        public virtual void BuildRoof()
        {
            Console.WriteLine("Крыша построена");
        }
    }
}
