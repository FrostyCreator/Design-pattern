using System;
using System.Collections.Generic;
using System.Text;

namespace State.StateWater
{
    class LiquidWaterState : IWaterState
    {
        public void Frost(Water water)
        {
            Console.WriteLine("Превращаем воду в лёд");
            water.State = new SolidWaterState();
        }

        public void Heat(Water water)
        {
            Console.WriteLine("Превращаем воду в пар");
            water.State = new GasWaterState();
        }
    }
}
