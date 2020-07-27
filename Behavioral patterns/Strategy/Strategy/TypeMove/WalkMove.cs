using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class WalkMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Иду пешком");
        }
    }
}
