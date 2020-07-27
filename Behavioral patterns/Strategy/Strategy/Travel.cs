using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Strategy
{
    class Travel
    {
        IMovable movable;

        public Travel(IMovable movable)
        {
            this.movable = movable;
        }

        public void Move()
        {
            movable.Move();
        }
    }
}
