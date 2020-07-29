using System;
using System.Collections.Generic;
using System.Text;

namespace State.StateWater
{
    class SolidWaterState : IWaterState
    {
        public void Frost(Water water)
        {
            Console.WriteLine("Продолжаем заморозку льда");
        }

        public void Heat(Water water)
        {
            Console.WriteLine("Превратили лёд в воду");
            water.State = new LiquidWaterState();
        }
    }
}
