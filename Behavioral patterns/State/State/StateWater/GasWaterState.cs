using System;
using System.Collections.Generic;
using System.Text;

namespace State.StateWater
{
    class GasWaterState : IWaterState
    {
        public void Frost(Water water)
        {
            Console.WriteLine("Превращение пара в воду");
            water.State = new LiquidWaterState();
        }

        public void Heat(Water water)
        {
            Console.WriteLine("Продолжаем нагревание пара");
        }
    }
}
