﻿using System;
using System.Collections.Generic;
using System.Text;

namespace State.StateWater
{
    interface IWaterState
    {
        void Heat(Water water);
        void Frost(Water water);
    }
}
