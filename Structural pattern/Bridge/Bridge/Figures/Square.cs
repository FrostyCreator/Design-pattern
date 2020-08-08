using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class Square : Figure
    {
        public Square(IColor clr) : base(clr) { }
    }
}
