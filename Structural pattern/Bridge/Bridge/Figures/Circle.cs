using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class Circle : Figure
    {
        public Circle(IColor clr) : base(clr) { }
    }
}
