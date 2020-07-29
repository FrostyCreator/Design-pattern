using State.StateWater;
using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Water
    {
        public IWaterState State { get; set; }
        public Water(IWaterState s)
        {
            State = s;
        }
        public void Heat()
        {
            State.Heat(this);
        }
        public void Frost()
        {
            State.Frost(this);
        }
    }
}
