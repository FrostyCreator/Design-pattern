using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class BusMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Передвигаюсь на автобусе");
        }
    }
}
