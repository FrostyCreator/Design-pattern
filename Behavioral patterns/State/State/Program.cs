using State.StateWater;
using System;
using System.Xml;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Water water = new Water(new LiquidWaterState());

            Console.WriteLine(water.State);
            water.Frost();
            Console.WriteLine(water.State);
            water.Frost();
            Console.WriteLine(water.State);

            water.Heat();
            Console.WriteLine(water.State);
            water.Heat();
            Console.WriteLine(water.State);
            water.Heat();
            Console.WriteLine(water.State);

        }
    }
}
