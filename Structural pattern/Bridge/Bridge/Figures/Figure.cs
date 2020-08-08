using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    abstract class Figure
    {
        protected IColor color;
        public IColor Color { get; set; }

        protected Figure(IColor clr)
        {
            color = clr;
        }
        public virtual void Paint(IColor clr)
        {
            clr.SetColot();
            this.color = clr;
            clr.GetColor();
        }
    }
}
