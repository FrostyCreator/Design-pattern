using System;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            BrickHouse brickHouse = new BrickHouse();
            WoodenHouse woodenHouse = new WoodenHouse();

            brickHouse.BuidHouse();
            Console.WriteLine();
            woodenHouse.BuidHouse();
        }
    }
}
